using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ICE.Utility
{
    public class PrintLPTUtility
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct OVERLAPPED
        {
            private int Internal;
            private int InternalHigh;
            private int Offset;
            private int OffSetHigh;
            private int hEvent;
        }

        #region 指令定义

        private static Byte[] Const_Init = new byte[] { 0x1B, 0x40, 
            0x20, 0x20, 0x20, 0x0A, 
            0x1B, 0x64,0x10};

        //设置左边距
        private const string Const_SetLeft = "1D 4C ";
        //设置打印机初始化
        private const string Const_Reset = "1B 40 ";


        //设置粗体
        private const string Const_SetBold = "1B 45 ";
        private const String Const_Bold_YES = "01";
        private const String Const_Bold_NO = "00";


        //设置对齐方式
        private const string Const_SetAlign = "1B 61 ";
        private const String Const_Align_Left = "30";
        private const String Const_Align_Middle = "31";
        private const String Const_Align_Right = "32";

        //设置字体大小,与 SetBigFont 不能同时使用
        private const string Const_SetFontSize = "1D 21 ";

        //设置是否大字体,等同于 SetFontSize = 2
        //private const String Const_SetBigFontBold = "1B 21 38";
        //private const String Const_SetBigFontNotBold = "1B 21 30";
        //private const String Const_SetCancelBigFont = "1B 21 00";

        
        
        
        private static Byte[] Const_Cmd_Print = new byte[] { 0x1B, 0x4A, 0x00 };
        //设置字体大小
        private const string Const_SizeB = "1D 21 00";
        //走纸
        private const string Const_FeedForward = "1B 64 ";
        private const string Const_FeedBack = "1B 6A ";
        //开钱箱
        private const string Const_OpenMbox = "1B 70 00 3C 3F";
        //切纸
        private static Byte[] Const_SetCut = new byte[] { 0x1D, 0x56, 0x30 };

        //查询打印机状态
        private static Byte[] Const_QueryID = new byte[] { 0x1D, 0x67, 0x61 };

        //回复帧以 ID 开头 
        private static String Const_ResponseQueryID = "ID";

        
        
        
        private static Byte[] Const_SetImageCommand = new Byte[] { 0x1B, 0x2A, 0x21 };

        
        
        
        public enum eTextAlignMode
        {
            Left = 0,
            Middle = 1,
            Right = 2
        }

        #endregion

        #region 常量定义

        
        
        
        public const Int32 Const_MaxFontSize = 8;
        
        
        
        public const Int32 Const_MaxFeedLength = 5000;

        
        
        
        public const Int32 Const_MaxImageLength = 480;

        
        
        
        public const Int32 Const_OncePrintRowCount = 24;

        public const Int32 Const_BrightnessGate = 100;

        
        
        
        public const Int32 Const_InvalidHandle = -1;
        #endregion

        #region 私有成员

        
        
        
        private int m_Handle = -1;

        
        
        
        private Boolean m_Inited = false;


        #endregion

        #region 私有函数

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(int hObject);
        [DllImport("kernel32.dll")]
        private static extern int CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);
        [DllImport("kernel32.dll")]
        private static extern bool WriteFile(int hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, out int lpNumberOfBytesWritten, out OVERLAPPED lpOverlapped);


        
        
        
        
        
        private Boolean SendCommand(Byte[] cmd)
        {
            if (m_Handle == Const_InvalidHandle || cmd == null || cmd.Length < 2)
            {
                return false;
            }
            OVERLAPPED overlapped;
            int writelen = 0;
            Boolean bl = WriteFile(m_Handle, cmd, cmd.Length, out writelen, out overlapped);

            if (!bl) return false;
            return (writelen >= cmd.Length);
        }

        
        
        
        
        
        private Boolean SendCommand(String hexstrcmd)
        {
            if (m_Handle == Const_InvalidHandle || hexstrcmd == null || hexstrcmd.Length < 4)
            {
                return false;
            }

            byte[] mybyte = Hex2ByteArr(hexstrcmd);
            Boolean bl = SendCommand(mybyte);
            return bl;
        }
        
        
        
        
        
        public byte[] Hex2ByteArr(string newString)
        {
            newString = newString.Replace(" ", "");
            int num = newString.Length / 2;
            byte[] buffer = new byte[num];
            for (int i = 0; i < num; i++)
            {
                buffer[i] = Convert.ToByte(newString.Substring(i * 2, 2), 0x10);
            }
            return buffer;
        }

        #endregion

        #region 公开函数

        
        
        
        
        
        public Boolean Open(String lptname)
        {
            bool flag = false;
            if (m_Inited)
            {
                flag = true;
            }
            m_Handle = CreateFile(lptname, 3, 0, 0, 3, 0, 0);
            if (m_Handle != -1)
            {
                m_Inited = (m_Handle != 0);
                flag = true;
            }
            return flag;
        }

        
        
        
        
        public Boolean Close()
        {
            if (!m_Inited)
            {
                return true;
            }
            m_Inited = false;

            SendCommand(Const_Reset);
            //关闭设备句柄
            CloseHandle(m_Handle);
            m_Handle = -1;
            return true;
        }

        
        
        
        
        
        public Boolean PrintText(String content)
        {
            if (!m_Inited)
            {
                return false;
            }

            byte[] bytes = null;
            if (content.Length < 1)
            {
                content = "  ";
            }

            if (content[content.Length - 1] != (char)0x0D &&
                content[content.Length - 1] != (char)0x0A)
            {
                content = content + (char)0x0A;
            }

            bytes = Encoding.Default.GetBytes(content);
            bool bl = SendCommand(bytes);
            return bl;
        }

        
        
        
        
        
        public bool SetAlignMode(eTextAlignMode alignmode)
        {
            if (!m_Inited)
            {
                return false;
            }

            String code = String.Empty;
            switch (alignmode)
            {
                case eTextAlignMode.Left:
                    code = Const_Align_Left;
                    break;
                case eTextAlignMode.Middle:
                    code = Const_Align_Middle;
                    break;
                case eTextAlignMode.Right:
                    code = Const_Align_Right;
                    break;
                default:
                    code = Const_Align_Left;
                    break;
            }

            //注意：先低字节后高字节 
            string str = Const_SetAlign + code;
            bool bl = SendCommand(str);
            return bl;
        }

        
        
        
        
        
        public bool SetLeft(int left)
        {
            if (!m_Inited)
            {
                return false;
            }

            //注意：先低字节后高字节
            String hexstr = left.ToString("X4");
            string str = Const_SetLeft + hexstr.Substring(2, 2) + hexstr.Substring(0, 2);
            bool bl = SendCommand(str);
            return bl;
        }

        
        
        
        
        
        public Boolean SetBold(Boolean bold)
        {
            if (!m_Inited)
            {
                return false;
            }

            //注意：先低字节后高字节
            String str = String.Empty;
            if (bold)
            {
                str = Const_SetBold + Const_Bold_YES;
            }
            else
            {
                str = Const_SetBold + Const_Bold_NO;
            }
            bool bl = SendCommand(str);
            return bl;
        }

        
        
        
        
        public bool Cut()
        {
            if (!m_Inited)
            {
                return false;
            }
            bool bl = SendCommand(Const_SetCut);
            return bl;
        }
        
        
        
        
        public bool OpenMbox()
        {
            if (!m_Inited)
            {
                return false;
            }
            bool bl = SendCommand(Const_OpenMbox);
            return bl;
        }
        
        
        
        
        
        public bool Feed(int length)
        {
            if (!m_Inited)
            {
                return false;
            }
            if (length < 1)
                length = 1;
            //if (length > Const_MaxFeedLength)
            //{
            //    length = Const_MaxFeedLength;
            //}
            string len = length.ToString("X2");
            len = Const_FeedForward + len;
            bool bl = SendCommand(len);
            return bl;
        }

        
        
        
        
        
        public bool FeedBack(int length)
        {
            if (!m_Inited)
            {
                return false;
            }
            if (length < 1)
                length = 1;
            if (length > Const_MaxFeedLength)
            {
                length = Const_MaxFeedLength;
            }
            string len = length.ToString("X2");
            len = Const_FeedBack + len;
            bool bl = SendCommand(len);
            return bl;
        }

        
        
        
        
        
        public bool SetFontSize(Int32 sizerate)
        {
            if (!m_Inited)
            {
                return false;
            }

            if (sizerate < 1)
            {
                sizerate = 1;
            }

            if (sizerate > Const_MaxFontSize)
            {
                sizerate = Const_MaxFontSize;
            }
            sizerate--;
            String sizecodestr = Const_SetFontSize + sizerate.ToString("X1") + sizerate.ToString("X1");
            bool bl = SendCommand(sizecodestr);
            return bl;
        }

        public bool SetFontSizeB()
        {
            bool bl = SendCommand(Const_SizeB);
            return bl;
        }

        #endregion
    }
}
