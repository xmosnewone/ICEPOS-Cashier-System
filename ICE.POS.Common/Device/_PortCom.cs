namespace ICE.POS.Common
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    public class PortCom
    {
        private const byte EVENPARITY = 2;
        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0x40000000;
        private int hComm = -1;
        private const int INVALID_HANDLE_VALUE = -1;
        private const byte MARKPARITY = 3;
        private const byte NOPARITY = 0;
        private const byte ODDPARITY = 1;
        private const byte ONE5STOPBITS = 1;
        private const byte ONESTOPBIT = 0;
        private const int OPEN_EXISTING = 3;
        public bool Opened = false;
        private const byte SPACEPARITY = 4;
        private const byte TWOSTOPBITS = 2;

        [DllImport("kernel32.dll")]
        private static extern bool BuildCommDCB(string lpDef, ref DCB lpDCB);
        public void Close()
        {
            if (this.hComm != -1)
            {
                CloseHandle(this.hComm);
            }
        }

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(int hObject);
        [DllImport("kernel32.dll")]
        private static extern int CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);
        [DllImport("kernel32.dll")]
        private static extern bool GetCommState(int hFile, ref DCB lpDCB);
        [DllImport("kernel32.dll")]
        private static extern bool GetCommTimeouts(int hFile, ref COMMTIMEOUTS lpCommTimeouts);
        [DllImport("kernel32.dll")]
        private static extern uint GetLastError();
        public bool Open(int PortNum, int BaudRate, char cParity, byte ByteSize, byte StopBits)
        {
            uint lastError;
            DCB lpDCB = new DCB();
            COMMTIMEOUTS lpCommTimeouts = new COMMTIMEOUTS();
            this.hComm = CreateFile("COM" + PortNum, 0xc0000000, 0, 0, 3, 0, 0);
            if (this.hComm == -1)
            {
                throw new ApplicationException("打开端口[COM" + PortNum + "]失败！");
            }
            GetCommTimeouts(this.hComm, ref lpCommTimeouts);
            lpCommTimeouts.ReadTotalTimeoutConstant = 0x7d0;
            lpCommTimeouts.ReadTotalTimeoutMultiplier = 0;
            lpCommTimeouts.WriteTotalTimeoutMultiplier = 0;
            lpCommTimeouts.WriteTotalTimeoutConstant = 0x1388;
            SetCommTimeouts(this.hComm, ref lpCommTimeouts);
            if (!GetCommState(this.hComm, ref lpDCB))
            {
                lastError = GetLastError();
                this.Close();
                throw new ApplicationException(string.Concat(new object[] { "打开端口[COM", PortNum, "]时执行GetCommState()失败！\r\n错误号: ", lastError.ToString() }));
            }
            lpDCB.BaudRate = BaudRate;
            lpDCB.ByteSize = ByteSize;
            switch (cParity)
            {
                case 'm':
                case 'M':
                    lpDCB.Parity = 3;
                    break;

                case 'n':
                case 'N':
                    lpDCB.Parity = 0;
                    break;

                case 'o':
                case 'O':
                    lpDCB.Parity = 1;
                    break;

                case 's':
                case 'S':
                    lpDCB.Parity = 4;
                    break;

                case 'e':
                case 'E':
                    lpDCB.Parity = 2;
                    break;
            }
            switch (StopBits)
            {
                case 1:
                    lpDCB.StopBits = 0;
                    break;

                case 2:
                    lpDCB.StopBits = 2;
                    break;
            }
            if (!SetCommState(this.hComm, ref lpDCB))
            {
                lastError = GetLastError();
                this.Close();
                throw new ApplicationException(string.Concat(new object[] { "打开端口[COM", PortNum, "]执行SetCommState()失败！\r\n错误号: ", lastError.ToString() }));
            }
            this.Opened = true;
            return true;
        }

        public byte[] Read(int NumBytes)
        {
            byte[] destinationArray = null;
            byte[] lpBuffer = new byte[NumBytes];
            if (this.hComm != -1)
            {
                OVERLAPPED lpOverlapped = new OVERLAPPED();
                int lpNumberOfBytesRead = 0;
                ReadFile(this.hComm, lpBuffer, NumBytes, ref lpNumberOfBytesRead, ref lpOverlapped);
                destinationArray = new byte[lpNumberOfBytesRead];
                Array.Copy(lpBuffer, destinationArray, lpNumberOfBytesRead);
            }
            return destinationArray;
        }

        [DllImport("kernel32.dll")]
        private static extern bool ReadFile(int hFile, byte[] lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, ref OVERLAPPED lpOverlapped);
        [DllImport("kernel32.dll")]
        private static extern bool SetCommState(int hFile, ref DCB lpDCB);
        [DllImport("kernel32.dll")]
        private static extern bool SetCommTimeouts(int hFile, ref COMMTIMEOUTS lpCommTimeouts);
        public int Write(byte[] WriteBytes)
        {
            int lpNumberOfBytesWritten = 0;
            if (this.hComm != -1)
            {
                OVERLAPPED lpOverlapped = new OVERLAPPED();
                WriteFile(this.hComm, WriteBytes, WriteBytes.Length, ref lpNumberOfBytesWritten, ref lpOverlapped);
            }
            return lpNumberOfBytesWritten;
        }

        public int Write(string strOut)
        {
            if (this.hComm != -1)
            {
                return this.Write(Encoding.Default.GetBytes(strOut));
            }
            return 0;
        }

        [DllImport("kernel32.dll")]
        private static extern bool WriteFile(int hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);

        [StructLayout(LayoutKind.Sequential)]
        private struct COMMTIMEOUTS
        {
            public int ReadIntervalTimeout;
            public int ReadTotalTimeoutMultiplier;
            public int ReadTotalTimeoutConstant;
            public int WriteTotalTimeoutMultiplier;
            public int WriteTotalTimeoutConstant;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DCB
        {
            public int DCBlength;
            public int BaudRate;
            public uint flags;
            public ushort wReserved;
            public ushort XonLim;
            public ushort XoffLim;
            public byte ByteSize;
            public byte Parity;
            public byte StopBits;
            public char XonChar;
            public char XoffChar;
            public char ErrorChar;
            public char EofChar;
            public char EvtChar;
            public ushort wReserved1;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct OVERLAPPED
        {
            public int Internal;
            public int InternalHigh;
            public int Offset;
            public int OffsetHigh;
            public int hEvent;
        }
    }
}

