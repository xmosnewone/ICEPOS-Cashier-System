namespace ICE.POS.Common
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    internal class _PortLpt
    {
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const short INVALID_HANDLE_VALUE = -1;
        private int m_lpt = -1;
        public const int OPEN_EXISTING = 3;

        public void Close()
        {
            if (this.m_lpt != -1)
            {
                CloseHandle(this.m_lpt);
                this.m_lpt = -1;
            }
        }

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(int hObject);
        [DllImport("kernel32.dll")]
        private static extern int CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);
        public bool IsOpen()
        {
            if (this.m_lpt == -1)
            {
                return false;
            }
            return true;
        }

        public bool Open(string lptName)
        {
            this.m_lpt = CreateFile(lptName, 0x40000000, 0, 0, 3, 0, 0);
            if (this.m_lpt == -1)
            {
                return false;
            }
            return true;
        }

        public bool Write(byte[] byteData)
        {
            if (this.m_lpt == -1)
            {
                return false;
            }
            if (byteData.Length == 0)
            {
                return true;
            }
            int lpNumberOfBytesWritten = 0;
            OVERLAPPED lpOverlapped = new OVERLAPPED();
            return WriteFile(this.m_lpt, byteData, byteData.Length, ref lpNumberOfBytesWritten, ref lpOverlapped);
        }

        public bool Write(string strOut)
        {
            if (this.m_lpt == -1)
            {
                return false;
            }
            byte[] bytes = Encoding.Default.GetBytes(strOut);
            return this.Write(bytes);
        }

        [DllImport("kernel32.dll")]
        private static extern bool WriteFile(int hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, ref OVERLAPPED lpOverlapped);

        [StructLayout(LayoutKind.Sequential)]
        private struct OVERLAPPED
        {
            private int Internal;
            private int InternalHigh;
            private int Offset;
            private int OffSetHigh;
            private int hEvent;
        }
    }
}

