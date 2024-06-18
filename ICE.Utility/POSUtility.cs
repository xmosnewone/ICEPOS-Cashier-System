using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.IO;

namespace ICE.Utility
{
    
    
    
    public class POSUtility
    {
        public POSUtility()
        {

        }
        private static object sync = new object();
        private static POSUtility _instance;
        public static POSUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new POSUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        const string _DllVer = "1.4.8";
        
        
        
        public string GetDllVer
        {
            get { return _DllVer; }
        }


        
        
        
        public IntPtr POS_IntPtr;

        
        
        
        public uint POS_SUCCESS = 1001;//  函数执行成功 
        public uint POS_FAIL = 1002;   //  函数执行失败 
        public uint POS_ERROR_INVALID_HANDLE = 1101; // 端口或文件的句柄无效 
        public uint POS_ERROR_INVALID_PARAMETER = 1102;// 参数无效 
        public uint POS_ERROR_NOT_BITMAP = 1103; // 不是位图格式的文件 
        public uint POS_ERROR_NOT_MONO_BITMAP = 1104;// 位图不是单色的 
        public uint POS_ERROR_BEYONG_AREA = 1105;//位图超出打印机可以处理的大小 
        public uint POS_ERROR_INVALID_PATH = 1106; // 没有找到指定的文件路径或名 

        
        
        
        public uint POS_COM_ONESTOPBIT = 0x00;//停止位为1
        public uint POS_COM_ONE5STOPBITS = 0x01;//停止位为1.5
        public uint POS_COM_TWOSTOPBITS = 0x02;//停止位为2
        
        
        
        public uint POS_COM_NOPARITY = 0x00;//无校验
        public uint POS_COM_ODDPARITY = 0x01;//奇校验
        public uint POS_COM_EVENPARITY = 0x02;//偶校验
        public uint POS_COM_MARKPARITY = 0x03;//标记校验
        public uint POS_COM_SPACEPARITY = 0x04;//空格校验
        
        
        
        public uint POS_COM_DTR_DSR = 0x00;// 流控制为DTR/DST  
        public uint POS_COM_RTS_CTS = 0x01;// 流控制为RTS/CTS 
        public uint POS_COM_XON_XOFF = 0x02;// 流控制为XON/OFF 
        public uint POS_COM_NO_HANDSHAKE = 0x03;//无握手 
        public uint POS_OPEN_PARALLEL_PORT = 0x12;//打开并口通讯端口 
        public uint POS_OPEN_BYUSB_PORT = 0x13;//打开USB通讯端口 
        public uint POS_OPEN_PRINTNAME = 0X14;// 打开打印机驱动程序 
        public uint POS_OPEN_NETPORT = 0x15;// 打开网络接口 

        public uint POS_CUT_MODE_FULL = 0x00;// 全切 
        public uint POS_CUT_MODE_PARTIAL = 0x01;// 半切 

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr POS_Open([MarshalAs(UnmanagedType.LPStr)]string lpName,
                                             uint nComBaudrate,
                                             uint nComDataBits,
                                             uint nComStopBits,
                                             uint nComParity,
                                             uint nParam);

        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_Close();

        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_Reset();

        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_SetMotionUnit(uint nHorizontalMU, uint nVerticalMU);
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_SetCharSetAndCodePage(uint nCharSet, uint nCodePage);

        
        
        
        
        public uint POS_FONT_TYPE_STANDARD = 0x00;// 标准 ASCII 
        public uint POS_FONT_TYPE_COMPRESSED = 0x01;// 压缩 ASCII  
        public uint POS_FONT_TYPE_UDC = 0x02;       // 用户自定义字符 
        public uint POS_FONT_TYPE_CHINESE = 0x03;   // 标准 “宋体” 
        public uint POS_FONT_STYLE_NORMAL = 0x00;   //  正常 
        public uint POS_FONT_STYLE_BOLD = 0x08;   //  加粗 
        public uint POS_FONT_STYLE_THIN_UNDERLINE = 0x80;   //  1点粗的下划线 
        public uint POS_FONT_STYLE_THICK_UNDERLINE = 0x100;   //  2点粗的下划线 
        public uint POS_FONT_STYLE_UPSIDEDOWN = 0x200;   //  倒置（只在行首有效） 
        public uint POS_FONT_STYLE_REVERSE = 0x400;   //  反显（黑底白字） 
        public uint POS_FONT_STYLE_SMOOTH = 0x800;   //  平滑处理（用于放大时） 
        public uint POS_FONT_STYLE_CLOCKWISE_90 = 0x1000;   //  每个字符顺时针旋转 90 度

        
        
        
        
        
        
        
        
        
        
        

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_S_TextOut([MarshalAs(UnmanagedType.LPStr)]string pszString,
                                                   uint nOrgx, uint nWidthTimes, uint nHeightTimes,
                                                   uint nFontType, uint nFontStyle);

        
        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_SetMode(uint nPrintMode);
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_SetLineSpacing(uint nDistance);
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_SetRightSpacing(int nDistance);

        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_FeedLine();
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_FeedLines(uint nLines);

        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_CutPaper(uint nMode, uint nDistance);

        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_SetRightSpacing(uint nDistance);
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PreDownloadBmpToRAM([MarshalAs(UnmanagedType.LPStr)]string pszPath, uint nID);
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_S_DownloadAndPrintBmp([MarshalAs(UnmanagedType.LPStr)]string pszPath, uint nOrgx, uint nMode);

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_S_PrintBmpInRAM(uint nID, uint nOrgx, uint nMode);

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_S_PrintBmpInFlash(uint nID, uint nOrgx, uint nMode);

        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_RTQueryStatus(byte[] address);

        
        
        
        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_QueryStatus(byte[] pszStatus, int nTimeouts);
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern int POS_NETQueryStatus([MarshalAs(UnmanagedType.LPStr)]string ipAddress, out Byte pszStatus);


        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_S_SetBarcode([MarshalAs(UnmanagedType.LPStr)]string pszInfo,
                                                      uint nOrgx, uint nType, uint nWidthX, uint nheight,
                                                      uint nHriFontType, uint nHriFontPosition, uint nBytesOfInfo);


        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PL_SetArea(uint nOrgx, uint nOrgY, uint nWidth, uint nheight, uint nDirection);

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PL_TextOut([MarshalAs(UnmanagedType.LPStr)]string pszString, uint nOrgx, uint nOrgY,
                                                   uint nWidthTimes, uint nHeightTimes, uint nFontType, uint nFontStyle);

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PL_PrintBmpInRAM(uint nID, uint nOrgx, uint nOrgY, uint nMode);

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PL_PrintBmpInFlash(uint nID, uint nOrgx, uint nOrgY, uint nMode);

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PL_SetBarcode([MarshalAs(UnmanagedType.LPStr)]string pszInfo,
                                                       uint nOrgx, uint nOrgY, uint nType, uint nWidthX, uint nheight,
                                                       uint nHriFontType, uint nHriFontPosition, uint nBytesOfInfo);

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PL_Clear();

        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_PL_Print();
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_KickOutDrawer(uint nID, uint nOnTimes, uint nOffTimes);
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern bool POS_StartDoc();
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern bool POS_EndDoc();
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_WriteFile(IntPtr hPort, byte[] pszData, uint nBytesToWrite);
        
        
        
        
        
        
        
        
        [DllImport("POSDLL.dll", SetLastError = true)]
        public static extern IntPtr POS_ReadFile(IntPtr hPort, byte[] pszData, uint nBytesToRead, uint nTimeouts);

        
        
        
        
        
        public bool OpenComPort(ref SerialPort PrintSerialPort)
        {
            uint i_stopbits = 0;
            if (PrintSerialPort.StopBits == StopBits.One)
                i_stopbits = POS_COM_ONESTOPBIT;
            if (PrintSerialPort.StopBits == StopBits.OnePointFive)
                i_stopbits = POS_COM_ONE5STOPBITS;
            if (PrintSerialPort.StopBits == StopBits.Two)
                i_stopbits = POS_COM_TWOSTOPBITS;

            uint i_nComParity = 0;
            if (PrintSerialPort.Parity == Parity.None)
                i_nComParity = POS_COM_NOPARITY;
            if (PrintSerialPort.Parity == Parity.Even)
                i_nComParity = POS_COM_EVENPARITY;
            if (PrintSerialPort.Parity == Parity.Odd)
                i_nComParity = POS_COM_ODDPARITY;
            if (PrintSerialPort.Parity == Parity.Space)
                i_nComParity = POS_COM_SPACEPARITY;
            if (PrintSerialPort.Parity == Parity.Mark)
                i_nComParity = POS_COM_MARKPARITY;

            uint i_para = 0;
            if (PrintSerialPort.Handshake == Handshake.None)
                i_para = POS_COM_NO_HANDSHAKE;
            if (PrintSerialPort.Handshake == Handshake.RequestToSend)
                i_para = POS_COM_DTR_DSR;
            if (PrintSerialPort.Handshake == Handshake.RequestToSendXOnXOff)
                i_para = POS_COM_RTS_CTS;
            if (PrintSerialPort.Handshake == Handshake.XOnXOff)
                i_para = POS_COM_XON_XOFF;

            POS_IntPtr = POS_Open(PrintSerialPort.PortName,
                                 (uint)PrintSerialPort.BaudRate,
                                 (uint)PrintSerialPort.DataBits,
                                 i_stopbits, i_nComParity, i_para);

            if ((int)POS_IntPtr != -1)
                return true;
            else
                return false;
        }
        
        
        
        
        
        public bool OpenLPTPort(string LPTPortName)
        {
            POS_IntPtr = POS_Open(LPTPortName, 0, 0, 0, 0, POS_OPEN_PARALLEL_PORT);
            if ((int)POS_IntPtr != -1)
                return true;
            else
                return false;
        }

        #region LPT端口打印

        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0x40000000;
        private const int OPEN_EXISTING = 3;

        [StructLayout(LayoutKind.Sequential)]
        private struct OVERLAPPED
        {
            int Internal;
            int InternalHigh;
            int Offset;
            int OffSetHigh;
            int hEvent;
        }
        [DllImport("kernel32.dll")]
        private static extern bool WriteFile(
         IntPtr hFile,
         byte[] lpBuffer,
         int nNumberOfBytesToWrite,
         ref int lpNumberOfBytesWritten,
         ref OVERLAPPED lpOverlapped
         );
        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(
         int hObject
         );
        
        
        
        [DllImport("kernel32.dll", EntryPoint = "CreateFile", CharSet = CharSet.Auto)]
        private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes,
                                                int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);
        
        
        
        public bool OpenPrintLPT(string lptName)
        {
            POS_IntPtr = CreateFile(lptName, GENERIC_READ | GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0);

            if (POS_IntPtr.ToInt32() == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void WritePrintLPT(string Mystring)
        {
            if ((int)POS_IntPtr != -1)
            {
                int i=0;
                OVERLAPPED x = new OVERLAPPED();
                byte[] mybyte = System.Text.Encoding.Default.GetBytes(Mystring);
                WriteFile(POS_IntPtr, mybyte, mybyte.Length, ref i, ref x);
            }
            else
            {
                throw new Exception("端口未打开~！");
            }
        }
        
        
        
        
        public bool PrintESC(int iSelect)
        {
            if (POS_IntPtr.ToInt32() != -1)
            {
                OVERLAPPED x = new OVERLAPPED();
                int i = 0;
                string send;
                byte[] buf = new byte[80];
                switch (iSelect)
                {
                    case 0:
                        send = "" + (char)(27) + (char)(64) + (char)(27) + 'j' + (char)(255);    //退纸1 255 为半张纸长
                        send = send + (char)(27) + 'j' + (char)(125);    //退纸2
                        break;
                    case 1:
                        send = "" + (char)(27) + (char)(64) + (char)(27) + 'J' + (char)(255);    //进纸
                        break;
                    case 2:
                        send = "" + (char)(27) + (char)(64) + (char)(12);   //换行
                        break;
                    case 3:
                        send = "" + (char)(27) + (char)(112) + (char)(0) + (char)(60) + (char)(255);  //开钱箱
                        break;
                    case 4:
                        send = "" + (char)(27) + (char)(112) + (char)(7);   //开钱箱
                        break;
                    case 5:
                        send = "" + (char)(27) + (char)(100) + (char)(4);   //打印并向前走N行
                        break;
                    default:
                        send = "" + (char)(27) + (char)(64) + (char)(12);   //换行
                        break;
                }
                for (int k = 0; k < send.Length; k++)
                {
                    buf[k] = (byte)send[k];
                }
                if (WriteFile(POS_IntPtr, buf, buf.Length, ref i, ref x))
                return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        
        
        
        public bool ClosePrintLPT()
        {
            return CloseHandle(POS_IntPtr.ToInt32());
        }

        #endregion

        
        
        
        
        
        public bool OpenNetPort(string IPAddress)
        {
            POS_IntPtr = POS_Open(IPAddress, 0, 0, 0, 0, POS_OPEN_NETPORT);
            if ((int)POS_IntPtr != -1)
                return true;
            else
                return false;
        }
        
        
        
        
        
        public bool OpenUSBPort(string USBPortName)
        {
            POS_IntPtr = POS_Open(USBPortName, 0, 0, 0, 0, POS_OPEN_BYUSB_PORT);
            if ((int)POS_IntPtr != -1)
                return true;
            else
                return false;
        }
        
        
        
        
        
        public bool OpenPrinter(string PrintName)
        {
            POS_IntPtr = POS_Open(PrintName, 0, 0, 0, 0, POS_OPEN_PRINTNAME);
            if ((int)POS_IntPtr != -1)
                return true;
            else
                return false;
        }
        
        
        
        
        public bool ClosePrinterPort()
        {
            IntPtr tmpIntPtr = POS_Close();
            return ((uint)tmpIntPtr == POS_SUCCESS);
        }
    }
}
