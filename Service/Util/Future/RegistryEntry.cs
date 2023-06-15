
using System.Diagnostics;
namespace Future.Registry{
    public static class RegistryEntry{
        public static string FPOSRegPath{get; private set;} = "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Future P.O.S.\\DIRECTORIES\\";
        public static string FPOSRegValueName{get; private set;}= "FPOS Directory";
        public static string? FPOSInstallPath{get; private set;}
        public static FileVersionInfo? FPOSVersionInfo{get; private set;}
        public static string? FPOSVersion{get; private set;}
        public static int? FPOSVersionMajor{get; private set;}
        public static string? InstanceName{get; private set;}
        static RegistryEntry(){
            InitFPOS();
            FPOSVersion = FPOSVersionInfo?.FileVersion ?? null;
            FPOSVersionMajor = FPOSVersionInfo?.FileMajorPart ?? null;
            InstanceName = FPOSVersionMajor switch {
                5 => "FPOSSQL",
                6 => "CESSQL",
                _ => null,
            };
        }
            
        private static void InitFPOS(){
            FPOSInstallPath = (string?)Microsoft.Win32.Registry.GetValue(FPOSRegPath,FPOSRegValueName, null);
            try{
                FPOSVersionInfo = FileVersionInfo.GetVersionInfo(FPOSInstallPath+"\\bin\\fpos.exe" ?? "");
            }catch(Exception ex){
                Console.Error.WriteLine(ex.Message);
                FPOSVersionInfo = null;
            }
        }
    }
}