using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySQL_Manager
{
    public class Configuration
    {
        public static string CONFIGURATIONS_FOLDER = "settings";
        static Configuration()
        {
            InitializeFolders();
        }

        private static void InitializeFolders()
        {
            if (!Directory.Exists(CONFIGURATIONS_FOLDER))
                Directory.CreateDirectory(CONFIGURATIONS_FOLDER);
        }

        public static string GetSettingFile(string tableName)
        {
            return CONFIGURATIONS_FOLDER + @"\" + tableName + ".json";
        }

    }
}
