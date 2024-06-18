namespace ICE.Utility
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    
    
    
    public class WindowsAPIUtility
    {
        public const int DT_CALCRECT = 0x400;
        public const int DT_LEFT = 0;
        public const int DT_SINGLELINE = 0x20;
        public const int DT_VCENTER = 4;
        public const int OPAQUE = 2;
        public const int TRANSPARENT = 1;
        
        
        
        
        
        
        
        
        
        
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string strSection, string strKey, string strDef, StringBuilder retVal, int intSize, string strfilePath);
        
        
        
        
        
        
        
        
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string strSection, string strKey, string strVal, string strFilePath);
        
        
        
        
        
        
        
        
        public static string GetLocalSysParam(string section, string key, string def, string filePath)
        {
            StringBuilder stringBuilder = new StringBuilder(255);
            GetPrivateProfileString(section, key, def, stringBuilder, 255, filePath);
            return stringBuilder.ToString();
        }

        [DllImport("gdi32.dll", ExactSpelling = true)]
        public static extern bool DeleteObject(IntPtr hObject);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int DrawText(IntPtr hdc, string lpString, int nCount, ref RECT lpRect, int uFormat);
        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);
        [DllImport("gdi32.dll")]
        public static extern int SetBkMode(IntPtr hdc, int iBkMode);
        //[DllImport("kernel32.dll", SetLastError = true)]
        //public static extern int SetLocalTime(ref SystemTime lpSystemTime);
        [DllImport("gdi32.dll")]
        public static extern int SetTextColor(IntPtr hdc, int crColor);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [DllImport("User32.dll")]
        
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);
        [DllImport("user32.dll")]
        
        public static extern void SetForegroundWindow(IntPtr hwnd);


        
        
        
        private const int SC_CLOSE = 0xF060;

        private const int MF_ENABLED = 0x00000000;

        private const int MF_GRAYED = 0x00000001;

        private const int MF_DISABLED = 0x00000002;

        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]

        public static extern IntPtr GetSystemMenu(IntPtr hWnd, int bRevert);

        [DllImport("User32.dll")]

        public static extern bool EnableMenuItem(IntPtr hMenu, int uIDEnableItem, int uEnable);
        /*
           1.
             窗体Load里添加
               IntPtr hMenu = GetSystemMenu(this.Handle, 0);
               EnableMenuItem(hMenu, SC_CLOSE, MF_DISABLED | MF_GRAYED);
         
            2. Windows Forms中禁用窗体的关闭按钮和ALT+F4关闭
            protected override CreateParams CreateParams

            {
               get
               {
                  const int CS_NOCLOSE = 0x200;
                  CreateParams cp = base.CreateParams;
                  cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                  return cp;
               }

            }
         */
    }
}
