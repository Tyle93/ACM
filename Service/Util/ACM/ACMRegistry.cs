using System.Diagnostics;

namespace ACM.Util.Registry
{
    static class ACMRegistry
    {
        private readonly static string WINDOWS_SERVICES_REGISTRY_PATH = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\";
        static ACMRegistry()
        {
#if DEBUG
#else
            if (!IsServiceInstalled())
            {
                Environment.Exit(1);
            }
            if (!IsRunningAsService())
            {
                Environment.Exit(1);
            }
#endif
        }

        public static void SetDbPathRegistryValue(string dbPath)
        {
            var serviceKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\ACM Service", true);
            if (serviceKey != null)
            {
                serviceKey.SetValue("DbPath", dbPath);
            }
        }
        private static bool IsServiceInstalled()
        {
            var serviceKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\ACM Service", true);
            if(serviceKey is null)
            {
                return false;
            }
            return true;
        }
        private static bool IsRunningAsService()
        {
            return !Environment.UserInteractive;   
        }


    }
}
