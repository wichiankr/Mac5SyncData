using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Mac5SyncData
{
    class globalVar
    {
        public static string dbPath
        {
            get
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                var conString = config.AppSettings.Settings["msAccessPath"].Value.ToString();
                Console.WriteLine("Start get DB Path " + conString);
                return conString;
            }            
        }

        public static string iserviceConStr
        {
            get
            {
                return "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + dbPath;
            }
        }
    }
}
