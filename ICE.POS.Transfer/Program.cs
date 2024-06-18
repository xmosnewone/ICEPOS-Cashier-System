namespace ICE.POS.Transfer
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using ICE.Common;
    using ICE.POS.Common;
    
    
    
    static class Program
    {
        private static Mutex appMutex;
        
        
        
        [STAThread]
        static void Main(String[] args)
        {
            try
            {
                bool flag;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                #region 正式环境部署
                Program.appMutex = new Mutex(true, "ICE.POS.Transfer", out flag);
                if (!flag)
                {
                    Program.appMutex.Close();
                    Program.appMutex = null;
                }
                else
                {

                }
                if (args != null && args.Length > 0)
                {
                    GlobalSet.dbsaleconn = GobalStaticString.SQLITE_DB_STRING.Replace("%path%", AppDomain.CurrentDomain.BaseDirectory + args[0].ToString());
                    GlobalSet.appinifile = args[1].ToString();
                    GlobalSet.appname = args[2].ToString() + "数据传输";
                    GlobalSet.client_id = args[3].ToString();
                    GlobalSet.access_token = args[4].ToString();
                    GlobalSet.serverUrl = args[5].ToString();
                    GlobalSet.memberUrl = args[6].ToString();
                    GlobalSet.access_way = args[7].ToString();
                    GlobalSet.mem_access_token = args[8].ToString();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormMain());
                }
                else
                {
                    MessageBox.Show("参数错误", GlobalSet.appname);
                }
                #endregion
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Transfer.Program--->Main-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        static void OnApplicationExit(object sender, EventArgs e)
        {
            if (Program.appMutex != null)
            {
                Program.appMutex.ReleaseMutex();
                Program.appMutex.Close();
            }
        }
    }
}
