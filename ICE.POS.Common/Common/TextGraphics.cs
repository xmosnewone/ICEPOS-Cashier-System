namespace ICE.POS.Common
{
    using System;
    using System.Drawing;
    using ICE.Utility;

    public class TextGraphics : IDisposable
    {
        private Graphics graphics;
        private IntPtr graphicsHandle;

        public TextGraphics(Graphics graphics)
        {
            this.graphics = graphics;
            this.graphicsHandle = graphics.GetHdc();
        }

        public TextGraphics(IntPtr graphicsHandle)
        {
            this.graphics = null;
            this.graphicsHandle = graphicsHandle;
        }

        public void Dispose()
        {
            if (this.graphics != null)
            {
                this.graphics.ReleaseHdc(this.graphicsHandle);
                this.graphics = null;
            }
            this.graphicsHandle = IntPtr.Zero;
        }

        public void DrawText(string text, Point point, Font font, Color foreColor)
        {
            WindowsAPIUtility.RECT rect = new WindowsAPIUtility.RECT();
            IntPtr hgdiobj = font.ToHfont();
            IntPtr ptr2 = WindowsAPIUtility.SelectObject(this.graphicsHandle, hgdiobj);
            int iBkMode = WindowsAPIUtility.SetBkMode(this.graphicsHandle, 1);
            int crColor = WindowsAPIUtility.SetTextColor(this.graphicsHandle, Color.FromArgb(0, foreColor.R, foreColor.G, foreColor.B).ToArgb());
            Size size = this.MeassureTextInternal(text);

            rect = new WindowsAPIUtility.RECT
            {
                left = point.X,
                top = point.Y,
                right = rect.left + size.Width,
                bottom = rect.top + size.Height
            };
            WindowsAPIUtility.DrawText(this.graphicsHandle, text, text.Length, ref rect, 0x20);
            WindowsAPIUtility.SetTextColor(this.graphicsHandle, crColor);
            WindowsAPIUtility.SetBkMode(this.graphicsHandle, iBkMode);
            WindowsAPIUtility.SelectObject(this.graphicsHandle, ptr2);
            WindowsAPIUtility.DeleteObject(hgdiobj);
        }

        private Size MeassureTextInternal(string text)
        {
            WindowsAPIUtility.RECT lpRect = new WindowsAPIUtility.RECT
            {
                left = 0,
                right = 0,
                top = 0,
                bottom = 0
            };
            WindowsAPIUtility.DrawText(this.graphicsHandle, text, text.Length, ref lpRect, 0x420);
            return new Size(lpRect.right, lpRect.bottom);
        }

        public Size MeasureText(string text, Font font)
        {
            IntPtr hgdiobj = font.ToHfont();
            IntPtr ptr2 = WindowsAPIUtility.SelectObject(this.graphicsHandle, hgdiobj);
            Size size = this.MeassureTextInternal(text);
            WindowsAPIUtility.SelectObject(this.graphicsHandle, ptr2);
            WindowsAPIUtility.DeleteObject(hgdiobj);
            return size;
        }
    }
}

