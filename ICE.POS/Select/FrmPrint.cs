using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.POS.Common;

namespace ICE.POS
{
    using ICE.Utility;
    using System.IO.Ports;
    public partial class FrmPrint : FrmBase
    {
        public FrmPrint()
        {
            InitializeComponent();
        }
        private string Port="并口";
        //打印机检测
        private void button1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            switch (Port)
            {
                case "并口":
                    SendMoneyBox(cboxBK.Text);
                    break;
                case "串口":
                    System.IO.Ports.SerialPort sPort = new System.IO.Ports.SerialPort();
                    sPort.PortName = cboxCK.Text;
                    sPort.BaudRate = 9600;
                    sPort.DataBits = 8;
                    sPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                    sPort.Parity = (Parity)Enum.Parse(typeof(Parity), "1");
                    sPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "1");
                    IsOpen = POSUtility.Instance.OpenComPort(ref sPort);
                    sPort.Dispose();
                    break;
                case "USB":
                    IsOpen = POSUtility.Instance.OpenUSBPort(cboxUSB.Text);
                    break;
                case "驱动":
                    Gfunc.OpenCash();
                    break;
                case "网口":
                    IsOpen = POSUtility.Instance.OpenNetPort(maskedtboxIP.Text);
                    break;
            }
            if (IsOpen)
            {
                try
                {
                    if (Port=="并口")
                    {
                        //开钱箱
                        bool res = POSUtility.Instance.PrintESC(3);
                        if (!res)
                        {
                            MessageBox.Show("开钱箱失败!指令调用返回值：" + res.ToString(), "系统提示");
                            LoggerHelper.Log("MsmkLogger", "开钱箱失败!指令调用返回值：" + res.ToString(), LogEnum.SysLog);
                        }
                        else
                        {
                            LoggerHelper.Log("MsmkLogger", Gattr.OperId + "通过打印设置打开钱箱", LogEnum.SysLog);
                        }
                        //关闭端口
                        POSUtility.Instance.ClosePrintLPT();
                    }
                    else
                    {
                        IntPtr res = POSUtility.POS_KickOutDrawer(0x00, 100, 100);
                        if ((uint)res != POSUtility.Instance.POS_SUCCESS)
                        {
                            MessageBox.Show("开钱箱失败!指令调用返回值：" + res.ToString(), "系统提示");
                            LoggerHelper.Log("MsmkLogger", "开钱箱失败!指令调用返回值：" + res.ToString(), LogEnum.SysLog);
                        }
                        else
                        {
                            LoggerHelper.Log("MsmkLogger", Gattr.OperId + "通过打印设置打开钱箱", LogEnum.SysLog);
                        }
                        //关闭端口
                        POSUtility.Instance.ClosePrinterPort();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "系统提示");
                }
            }
            else
            {
                if (Port != "驱动" && Port != "并口")
                {
                    MessageBox.Show("端口打开失败，请检查一下端口选择是否正确！", Gattr.AppTitle);
                }
            }
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            //获取系统打印机
           Dictionary<string,string> _dicPrinter = ComputerUtility.Instance.GetPrinterName();
           foreach (string _printer in _dicPrinter.Values)
           {
               cboxQD.Items.Add(_printer);
           }
           switch (Gattr.PortType)
           {
               case "并口":
                   radioButtonBK.Checked = true;
                   cboxBK.SelectedText = Gattr.PortName;
                   Port = "并口";
                   break;
               case "串口":
                   radioButtonCK.Checked = true;
                   cboxCK.SelectedText = Gattr.PortName;
                   Port = "串口";
                   break;
               case "USB":
                   radioButtonUSB.Checked = true;
                   cboxUSB.SelectedText = Gattr.PortName;
                   Port = "USB";
                   break;
               case "驱动":
                   radioButtonQD.Checked = true;
                   cboxQD.Text = Gattr.PosModel;
                   Port = "驱动";
                   break;
               case "网口":
                   radioButtonWK.Checked = true;
                   maskedtboxIP.Text = Gattr.PortName;
                   Port = "网口";
                   break;
           }
           
        }

        //串口
        private void radioButtonCK_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCK.Checked)
            {
                labelCK.Enabled = true;
                cboxCK.Enabled = true;
                cboxCK.SelectedIndex = 0;
                this.Port = "串口";
            }
            else
            {
                labelCK.Enabled = false;
                cboxCK.Enabled = false;
            }
        }
        //并口
        private void radioButtonBK_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBK.Checked)
            {
                labelBK.Enabled = true;
                cboxBK.Enabled = true;
                cboxBK.SelectedIndex = 0;
                this.Port = "并口";
            }
            else
            {
                labelBK.Enabled = false;
                cboxBK.Enabled = false;
            }
        }
        //USB
        private void radioButtonUSB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUSB.Checked)
            {
                labelUSB.Enabled = true;
                cboxUSB.Enabled = true;
                cboxUSB.SelectedIndex = 0;
                this.Port = "USB";
            }
            else 
            {
                labelUSB.Enabled = false;
                cboxUSB.Enabled = false;
            }
        }
        //网口
        private void radioButtonWK_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWK.Checked)
            {
                labelIP.Enabled = true;
                maskedtboxIP.Enabled = true;
                this.Port = "网口";
            }
            else
            {
                labelIP.Enabled = false;
                maskedtboxIP.Enabled = false;
            }
        }
        //驱动
        private void radioButtonQD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQD.Checked)
            {
                labelQD.Enabled = true;
                cboxQD.Enabled = true;
                cboxQD.Text = "打印机名称"; 
                this.Port = "驱动";
            }
            else
            {
                labelQD.Enabled = false;
                cboxQD.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrintInfoSave(Port);
            MessageBox.Show("保存成功！");
        }

        public void PrintInfoSave(string _port)
        {
            switch (_port)
            {
                case "并口":
                    Gattr.PortType = "并口";
                    Gattr.PortName = cboxBK.Text;
                    ConfigUtility.Instance.SetValue("portType", "并口");
                    ConfigUtility.Instance.SetValue("portName", cboxBK.Text);
                    break;
                case "串口":
                    Gattr.PortType = "串口";
                    Gattr.PortName = cboxCK.Text;
                    ConfigUtility.Instance.SetValue("portType", "串口");
                    ConfigUtility.Instance.SetValue("portName", cboxCK.Text);
                    break;
                case "USB":
                    Gattr.PortType = "USB";
                    Gattr.PortName = cboxUSB.Text;
                    ConfigUtility.Instance.SetValue("portType", "USB");
                    ConfigUtility.Instance.SetValue("portName", cboxUSB.Text);
                    break;
                case "驱动":
                    Gattr.PortType = "驱动";
                    Gattr.PosModel = cboxQD.Text;
                    ConfigUtility.Instance.SetValue("portType", "驱动");
                    ConfigUtility.Instance.SetValue("posName", cboxQD.Text);
                    break;
                case "网口":
                    Gattr.PortType = "网口";
                    Gattr.PortName = maskedtboxIP.Text;
                    ConfigUtility.Instance.SetValue("portType", "网口");
                    ConfigUtility.Instance.SetValue("portName", maskedtboxIP.Text);
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            System.IO.Ports.SerialPort sPort = new System.IO.Ports.SerialPort();
            switch (Port)
            {
                case "并口":
                    SendToLTP(cboxBK.Text);
                    break;
                case "串口":
                    sPort.PortName = cboxCK.Text;
                    sPort.BaudRate = 19200;
                    sPort.DataBits = 8;
                    sPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");
                    sPort.Parity = (Parity)Enum.Parse(typeof(Parity), "1");
                    sPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "2");
                    IsOpen = POSUtility.Instance.OpenComPort(ref sPort);
                    //sPort.Dispose();
                    break;
                case "USB":
                    IsOpen = POSUtility.Instance.OpenUSBPort(cboxUSB.Text);
                    break;
                case "驱动":
                    MessageBox.Show("驱动打印测试与开钱箱相同！");
                    break;
                case "网口":
                    IsOpen = POSUtility.Instance.OpenNetPort(maskedtboxIP.Text);
                    break;
            }
            if (IsOpen)
            {
                try
                {
                    POSUtility.POS_SetMode(0x00);
                    POSUtility.POS_SetRightSpacing(0);
                    POSUtility.POS_SetLineSpacing(80);
                    POSUtility.POS_S_TextOut("【"+Port + "】 --打印测试", 0, 1, 1, POSUtility.Instance.POS_FONT_TYPE_STANDARD, POSUtility.Instance.POS_FONT_STYLE_NORMAL);
                    POSUtility.POS_FeedLine();
                    POSUtility.POS_S_TextOut("--------------------------", 0, 1, 1, POSUtility.Instance.POS_FONT_TYPE_STANDARD, POSUtility.Instance.POS_FONT_STYLE_NORMAL);
                    POSUtility.POS_FeedLine();
                    POSUtility.POS_S_TextOut("清晰程度-字体大小-打印测试", 0, 1, 1, POSUtility.Instance.POS_FONT_TYPE_STANDARD, POSUtility.Instance.POS_FONT_STYLE_NORMAL);
                    POSUtility.POS_FeedLine();
                    POSUtility.POS_S_TextOut("--------------------------", 0, 1, 1, POSUtility.Instance.POS_FONT_TYPE_STANDARD, POSUtility.Instance.POS_FONT_STYLE_NORMAL);
                    POSUtility.POS_FeedLine();
                    POSUtility.POS_S_TextOut(System.DateTime.Now.ToString(), 0, 1, 1, POSUtility.Instance.POS_FONT_TYPE_STANDARD, POSUtility.Instance.POS_FONT_STYLE_NORMAL);
                    POSUtility.POS_FeedLines(4);
                    POSUtility.POS_Reset();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "系统提示");
                }
                //关闭端口
                POSUtility.Instance.ClosePrinterPort();
            }
            else
            {
                if (Port != "驱动" && Port != "并口")
                {
                    MessageBox.Show("端口打开失败，请检查一下端口选择是否正确！", Gattr.AppTitle);
                }
            }
            sPort.Dispose();
        }

        
        
        
        public void SendToLTP(string ltpName)
        {
            PrintLPTUtility PrintLPT= new PrintLPTUtility();
            if (PrintLPT.Open(ltpName))
            {
                try
                {
                    PrintLPT.PrintText("【" + Port + "】 --打印测试");
                    PrintLPT.PrintText("--------------------------");
                    PrintLPT.PrintText("清晰程度-字体大小-打印测试");
                    PrintLPT.PrintText("--------------------------");
                    PrintLPT.PrintText(System.DateTime.Now.ToString());
                    PrintLPT.Feed(3);
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "系统提示");
                    LoggerHelper.Log("MsmkLogger", "API打印报错：" + exception.Message, LogEnum.SysLog);
                }
                //关闭端口
                PrintLPT.Close();
            }
            else
            {
                MessageBox.Show(Gattr.PortType + "端口打印机无效！", Gattr.AppTitle);
                LoggerHelper.Log("MsmkLogger", Gattr.PortType + "端口打印机无效！", LogEnum.SysLog);
            }
        }

        public bool SendMoneyBox(string ltpName)
        {
            PrintLPTUtility PrintLPT = new PrintLPTUtility();
            if (PrintLPT.Open(ltpName))
            {
                try
                {
                    if (PrintLPT.OpenMbox())
                    {
                        LoggerHelper.Log("MsmkLogger", Gattr.OperId + "通过测试LPT开钱箱！", LogEnum.SysLog);
                        //关闭端口
                        PrintLPT.Close();
                        return true;
                    }
                    else
                    {
                        //关闭端口
                        PrintLPT.Close();
                        return false;
                    }

                }
                catch (Exception exception)
                {
                    //关闭端口
                    PrintLPT.Close();
                    MessageBox.Show(exception.Message, "系统提示");
                    LoggerHelper.Log("MsmkLogger", "LPT开钱箱错误：" + exception.Message, LogEnum.SysLog);
                    return false;
                }

            }
            else
            {
                MessageBox.Show(Gattr.PortType + "端口打印机无效！", Gattr.AppTitle);
                LoggerHelper.Log("MsmkLogger", Gattr.PortType + "端口打印机无效！", LogEnum.SysLog);
                return false;
            }
        }

    }
}
