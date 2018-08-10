using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Mac5SyncData.Models;
using System.Data.OleDb;
namespace Mac5SyncData
{
    public partial class Main : MetroForm
    {
        List<V_MIH_ISERVICE_LINK> invList;
        public Main()
        {
            InitializeComponent();
            
            txt_dbpath.Text = globalVar.dbPath;

            

            
        }

        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            bgk_loaddata.RunWorkerAsync();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "MS Access Files (*.accdb)|*.accdb| All files(*.*)|*.*";
            //file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                txt_dbpath.Text = file.FileName;
            }
        }

        private void btn_savedbpath_Click(object sender, EventArgs e)
        {
            if(txt_dbpath.Text != null)
            {
                manageConfig.updateDbPathConfig("msAccessPath", txt_dbpath.Text.Trim());
                MessageBox.Show("Update config successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("con str: " + globalVar.iserviceConStr);
            }
        }

        private void bgk_loaddata_DoWork(object sender, DoWorkEventArgs e)
        {
            Action action = () => txt_progress.Text = string.Empty;
            txt_progress.Invoke(action);

             action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " เริ่มค้นหาข้อมูล \r\n" + txt_progress.Text;
            txt_progress.Invoke(action);

            try
            {
                using (mac5Entities db = new mac5Entities())
                {
                    invList = db.V_MIH_ISERVICE_LINK.Where(a => a.MIHdate >= dpk_from.Value && a.MIHdate <= dpk_to.Value).ToList();
                    if(invList.Count>0)
                    {

                         action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " พบข้อมูล " + invList.Count + " รายการ \r\n" + txt_progress.Text;
                        txt_progress.Invoke(action);
                        e.Result = invList.Count;
                    }
                    else
                    {
                        action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " ไม่พบข้อมูล  \r\n" + txt_progress.Text;
                        txt_progress.Invoke(action);

                        e.Result = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgk_loaddata_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if((int)e.Result > 0)
            {
                MessageBox.Show("พบข้อมูล " + e.Result + " รายการ","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bgk_loaddata_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Action action = () => txt_progress.Text += DateTime.Now.ToString("H:mm:ss") + e.ProgressPercentage + "\t\r\n";
            txt_progress.Invoke(action);
        }

        private void btn_syncdata_Click(object sender, EventArgs e)
        {
            bgk_syncdata.RunWorkerAsync();
        }

        //เริ่มโหลด Invoice เข้าฐานข้อมูล Access
        private void bgk_syncdata_DoWork(object sender, DoWorkEventArgs e)
        {
            Action action;
            if (invList.Count > 0)
            {

                //แสดงสถานะ
                action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " เริ่ม Sync ข้อมูล " + invList.Count + "\t\r\n" + txt_progress.Text;
                txt_progress.Invoke(action);

                using (OleDbConnection con = new OleDbConnection(globalVar.iserviceConStr))
                {
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbTransaction tran = null;
                    
                    try
                    {

                        con.Open();
                        tran = con.BeginTransaction();
                        cmd.Connection = con;
                        cmd.Transaction = tran;

                        foreach (var l in invList)
                        {
                            //แสดงสถานะ
                            action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " เริ่ม Sync ข้อมูล " + l.MIHvnos + "\t\r\n" + txt_progress.Text;
                            txt_progress.Invoke(action);

                            // Start to delete old invoice in db Access
                            var invGuid = System.Guid.NewGuid().ToString();
                            var invExistguid = utils.getInvoiceGuid(l.MIHvnos);
                            //cmd.Parameters.AddWithValue("guid", invExistguid);
                            cmd.Parameters.Add("guid", OleDbType.Char).Value = invExistguid;
                            //cmd.Parameters.AddWithValue("Existguid", invExistguid);
                            cmd.Parameters.Add("Existguid", OleDbType.Char).Value = invExistguid;
                            //cmd.Parameters.AddWithValue("invcode", l.MIHvnos);
                            cmd.Parameters.Add("invcode", OleDbType.Char).Value = l.MIHvnos;
                            //cmd.Parameters.AddWithValue("invdate", l.MIHdate);
                            cmd.Parameters.Add("invdate", OleDbType.Date).Value = l.MIHdate.ToString();
                            //cmd.Parameters.AddWithValue("invspecdisc", 0);
                            cmd.Parameters.Add("invspecdisc", OleDbType.Integer).Value = 0;                        
                            //cmd.Parameters.AddWithValue("invcust", string.Empty);
                            cmd.Parameters.Add("invcust", OleDbType.Char).Value = string.Empty;
                            //cmd.Parameters.AddWithValue("invcusttype", string.Empty);
                            cmd.Parameters.Add("invcusttype", OleDbType.Char).Value = string.Empty;
                            //cmd.Parameters.AddWithValue("invnote", l.MIHnotes);
                            cmd.Parameters.Add("invnote", OleDbType.Char).Value = l.MIHnotes;
                            //cmd.Parameters.AddWithValue("invtype", l.MIHtype);
                            cmd.Parameters.Add("invtype", OleDbType.Char).Value = l.MIHtype;
                            //cmd.Parameters.AddWithValue("branch", utils.getBranchGuid(l.MIHcus));
                            cmd.Parameters.Add("branch",OleDbType.Char).Value = utils.getBranchGuid(l.MIHcus);
                            //cmd.Parameters.AddWithValue("custnote", string.Empty);
                            cmd.Parameters.Add("customer", OleDbType.Char).Value = string.Empty;

                            //ตรวจสอบว่ามี invoice เก่าอยู่ไหม ถ้ามี ให้อัพเดท ถ้าไม่มีให้เพิ่มใหม่
                            if (!string.IsNullOrEmpty(invExistguid))
                            {

                                cmd.CommandText = "UPDATE invoice SET invcode=@invcode,invdate=@invdate,invspecdisc=@invspecidisc,invcust=@invcust,invcusttype=@invcusttype,invnote=@invnote,invtype=@invtype,branch=@branch,custnote=@custnote" +
                                    "WHERE [guid]=@Existguid";
                                cmd.ExecuteNonQuery();

                                // ลบรายการสินค้าเก่า
                                cmd.CommandText = "DELETE FROM refinvoice WHERE invoice=@Existguid";
                                cmd.ExecuteNonQuery();

                                invGuid = invExistguid;
                            }
                            else
                            {
                                Console.WriteLine("Insert into invoice");
                                // Start to add invoice
                                cmd.CommandText = "INSERT INTO invoice([guid],invcode,invdate,invprice,invspecdisc,invcust,invcusttype,invnote,invtype,branch,custnote)" +
                                    "values(@guid,@invcode,@invdate,@invprice,@invspecdisc,@invcust,@invcusttype,@invnote,@invtype,@branch,@custnote)";

                                cmd.CommandText = "INSERT INTO invoice([guid])" +
                                  "values(@guid)";
                                cmd.ExecuteNonQuery();
                                Console.WriteLine("Test str passed");
                            }
                            cmd.Parameters.Clear();

                            //เริ่ม Add product List
                            var prodList = utils.getListInvoiceFromMac5(l.MIHvnos);

                            foreach (var p in prodList)
                            {
                                
                                cmd.CommandText = "INSERT INTO refinvoice ([guid],refdate,refprice,refqty,refamount,refcost,refsort,refio,prod,invoice,branch)" +
                                    "values(@guid,@refdate,@refprice,@refqty,@refamount,@refcost,@refsort,@refio,@prod,@invoice,@branch)";

                                cmd.CommandText = "INSERT INTO refinvoice ([guid],refdate,refprice,refqty,refamount,refcost,refsort,refio,prod,invoice,branch)" +
                                   "values(?,?,?,?,?,?,?,?,?,?,?)";

                                var refguid = System.Guid.NewGuid().ToString();
                                cmd.Parameters.Add("guid",OleDbType.Char).Value = refguid;
                                cmd.Parameters.Add("refdate",OleDbType.Date ).Value = l.MIHdate;
                                cmd.Parameters.Add("refprice", OleDbType.Double).Value = p.MILuprice;
                                cmd.Parameters.Add("refqty",OleDbType.Integer).Value = p.MILquan;
                                cmd.Parameters.Add("refamount",OleDbType.Double).Value = p.MILcog;
                                cmd.Parameters.Add("refcost", OleDbType.Integer).Value = 0;
                                cmd.Parameters.Add("refsort",OleDbType.Integer).Value = p.MILlistNo;
                                cmd.Parameters.Add("refio",OleDbType.Char).Value = utils.getInvoiceIOFromMIHtype(p.MILtype);
                                cmd.Parameters.Add("prod",OleDbType.Char).Value =  utils.getProdGuidFromCode(p.MILstk);
                                cmd.Parameters.Add("invoice",OleDbType.Char).Value = invGuid;
                                cmd.Parameters.Add("branch",OleDbType.Char).Value =  utils.getBranchGuid(l.MIHcus);

                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }                        

                        }

                        //แสดงสถานะ
                        action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " ทดสอบระบบผ่าน กำลังลบข้อมูล... \t\r\n" + txt_progress.Text;
                        txt_progress.Invoke(action);
                        //All job completed
                        tran.Rollback();
                    }
                    catch (Exception ex)
                    {
                        //Job fail rollback transection
                        //tran.Rollback();


                        //แสดงสถานะ
                        action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " " + ex.Message.ToString() + "\r\n" + txt_progress.Text;
                        txt_progress.Invoke(action);

                        //แสดงสถานะ
                        action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " Error found \t\r\n" + txt_progress.Text;
                        txt_progress.Invoke(action);

                        Console.WriteLine(ex.Message.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }
            else
            {
                action = () => txt_progress.Text = DateTime.Now.ToString("H:mm:ss") + " ไม่พบข้อมูล \t\r\n" + txt_progress.Text;
                txt_progress.Invoke(action);
            }

            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
