using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Mac5SyncData.Models;
using System.Windows.Forms;

namespace Mac5SyncData
{
    class utils
    {
        //Convert  code from MAC5 to guid
        public static string getBranchGuid(string mac5Code)
        {
            using (OleDbConnection connection = new OleDbConnection(globalVar.iserviceConStr))
            {
                try
                {
                    Console.WriteLine("Prepare load guid branch " + mac5Code);
                    connection.Open();
                    OleDbCommand cmdBranch = new OleDbCommand();
                    cmdBranch.Connection = connection;
                    cmdBranch.CommandText = "SELECT [guid] FROM branch WHERE branchcodemac5 ='CT-HQ0002'";
                    cmdBranch.Parameters.AddWithValue("branchcodemac5", mac5Code);

                    var code = cmdBranch.ExecuteReader();

                    if (code.Read())
                    {

                        mac5Code = code.GetString(0);
                        Console.WriteLine("Data reader can read "+mac5Code);
                    }
                    else
                    {
                        Console.WriteLine("Data reader cannot read");
                        mac5Code = string.Empty;
                    }

                }
                catch(Exception ex)
                {
                    mac5Code = string.Empty;
                    Console.WriteLine("Query Branch Error " + ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
                return mac5Code;
        }

        //Check invoice, Is it exist?
        public static string getInvoiceGuid(string invcode)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(globalVar.iserviceConStr))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT [guid] FROM invoice WHERE invcode = @invcode";
                    cmd.Parameters.AddWithValue("invcode", invcode);
                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return string.Empty;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString("H:mm:ss") +" " + ex.Message.ToString());
                return string.Empty;
            }
           
        }

        public static IEnumerable<V_MIL_ISERVICE_LINK> getListInvoiceFromMac5(String invcode)
        {
           using(mac5Entities db = new mac5Entities())
            {
                try
                {
                    var ls = db.V_MIL_ISERVICE_LINK.Where(a => a.MILvnos == invcode).ToList();
                    return ls;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(DateTime.Now.ToString("H:mm:ss") + " " + ex.Message.ToString());
                    return new List<V_MIL_ISERVICE_LINK>();
                }

            }
            
        }

        public static string getInvoiceIOFromMIHtype(string type)
        {
            string returnvalue = "U";

            switch(type)
            {
                case "IS":
                    returnvalue = "I";
                    break;
                case "SS":
                    returnvalue = "I";
                    break;
                case "BS":
                    returnvalue = "O";
                    break;
                case "SP":
                    returnvalue = "O";
                    break;
            }

            return returnvalue;
        }

        //โหลด GUID รหัสสินค้าจาก dbaccess
        public static string getProdGuidFromCode(string code)
        {
            using (OleDbConnection connection = new OleDbConnection(globalVar.iserviceConStr))
            {
                try
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT [guid] FROM prod WHERE prodcode=@prodcode";
                    cmd.Parameters.AddWithValue("prodcode", code);
                    var reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        return reader.GetString(0);

                    }
                    else
                    {
                        return string.Empty;
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
                finally
                {
                    connection.Close();
                }
                
            }
        }
    }
}
