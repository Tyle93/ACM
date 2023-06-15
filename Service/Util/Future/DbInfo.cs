using System.Xml;
using Future.Registry;

namespace Future.Util{
    public static class DbInfo{

        public static string? path{get; private set;}
        public static string? serverName{get; private set;}
        public static string? dbName{get; private set;}
        private static void configureDbInfo(){
            try{
                FileStream xmlstream = File.Open(path, FileMode.Open);
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlstream);
                dbName = xml.SelectSingleNode("/db/ServerDatabase")?.InnerText;
                serverName = xml.SelectSingleNode("/db/Server")?.InnerText;
            }catch(FileNotFoundException e){
                Console.Error.WriteLine(e.Message);
            }catch(ArgumentNullException e){
                Console.Error.WriteLine(e.Message);
            }
        }

        static DbInfo(){
            getDbInfoPath();
            configureDbInfo();
        }

        private static void getDbInfoPath() {
            string? fposPath = RegistryEntry.FPOSInstallPath;
            if(fposPath is null){
                throw new FutureConfigurationException("Could not find Future Installation.");
            }else{
                path = fposPath! + "/data/dbinfo.xml";
            }
        }

    }
    class FutureConfigurationException : Exception{
        public FutureConfigurationException(string message) : base(message){}
    }
}
