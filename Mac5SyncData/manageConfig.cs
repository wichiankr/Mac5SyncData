using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Mac5SyncData
{
    class manageConfig
    {
        public static bool updateDbPathConfig(string key,string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                config.AppSettings.Settings.Remove(key);
                config.AppSettings.Settings.Add(key, value);

                config.Save(ConfigurationSaveMode.Modified);
                Console.WriteLine("Config file saved successfully");
                return true;
            }
            catch
            {
                Console.WriteLine("Error writing app settings Key:" + key);
                return false;
            }
        }
    }
}
