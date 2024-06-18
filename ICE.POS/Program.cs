namespace ICE.POS
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using ICE.POS.Common;

    static class Program
    {
        private static Mutex appMutex;
        
        
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                bool flag;
                Program.appMutex = new Mutex(true, "Msmk", out flag);
                if (!flag)
                {
                    MessageBox.Show("程序已经运行！", Gattr.AppTitle);
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.ApplicationExit += new EventHandler(Program.OnApplicationExit);
                    Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
                    Application.Run(new FrmStart());
                   // Application.Run(new FrmLogin(null));
                }
            }
            catch
            {

            }
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LoggerHelper.Log("MsmkLogger", e.Exception.ToString(), LogEnum.ExceptionLog);
        }
        private static void OnApplicationExit(object sender, EventArgs e)
        {
            if (Program.appMutex != null)
            {
                Program.appMutex.Close();
            }
        }
    }
}
