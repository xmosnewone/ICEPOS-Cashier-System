namespace ICE.POS.Common
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public class CashBox : IDisposable
    {
        private byte[] _instruction = null;
        private string _port = "NONE";
        private PosPrint _printer = null;

        public void Dispose()
        {
            this._port = "NONE";
            this._instruction = null;
            this._printer = null;
        }

        public byte[] GetBytes(string strCommand)
        {
            if (string.IsNullOrEmpty(strCommand))
            {
                return null;
            }
            byte[] buffer = null;
            string[] strArray = strCommand.Split(new char[] { ',' });
            if (strArray.Length == 0)
            {
                this._instruction = null;
            }
            if (strArray.Length > 0)
            {
                buffer = new byte[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    buffer[i] = Convert.ToByte(Convert.ToInt16(strArray[i].Trim()));
                }
            }
            return buffer;
        }

        public bool Open(string drawerCommand, string port, PosPrint printer)
        {
            this._port = port;
            this._printer = printer;
            this._instruction = this.GetBytes(drawerCommand);
            if ((this._port == "NONE") || (this._instruction == null))
            {
                return false;
            }
            return true;
        }

        public void OpenCashBox()
        {
            if (this._instruction != null)
            {
                bool isWindowPrinter = true;
                if (this._printer != null)
                {
                    isWindowPrinter = this._printer.IsWindowPrinter;
                }
                if (isWindowPrinter)
                {
                    PortCom com = null;
                    try
                    {
                        string name = "NONE";//Gfunc.GetLocalSysParam("pos", "custdisp_name", "NONE", Gattr.InitFile);
                        string port = "NONE";//Gfunc.GetLocalSysParam("pos", "custdisp_port", "NONE", Gattr.InitFile);
                        if ((this._port != "NONE") && (port == this._port))
                        {
                            //Gattr.PosDisplay.Close();
                            com = new PortCom();
                            if (!com.Open(Convert.ToInt32(this._port.Substring(3)), 0x2580, 'n', 8, 1))
                            {
                                MessageBox.Show(string.Format("钱箱端口{0}打不开!", this._port));
                                com.Close();
                            }
                            else
                            {
                                Thread.Sleep(10);
                                com.Write(this._instruction);
                                com.Close();
                               // Gattr.PosDisplay.Open(name, port);
                            }
                        }
                        else
                        {
                            com = new PortCom();
                            if (!com.Open(Convert.ToInt32(this._port.Substring(3)), 0x2580, 'n', 8, 1))
                            {
                                MessageBox.Show(string.Format("钱箱端口{0}打不开!", this._port));
                                com.Close();
                            }
                            else
                            {
                                Thread.Sleep(10);
                                com.Write(this._instruction);
                                com.Close();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (com != null)
                        {
                            com.Close();
                        }
                    }
                    finally
                    {
                        if (com != null)
                        {
                            com.Close();
                        }
                    }
                }
                else
                {
                    //this._printer.PrintOut(this._instruction);
                }
            }
        }
    }
}

