namespace ICE.POS.Common
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public static class GraphicsPathHelper
    {
        
        public static GraphicsPath CreatePath(Rectangle rect, int radius, RoundStyle style, bool correction)
        {
            GraphicsPath path = new GraphicsPath();
            int num = correction ? 1 : 0;
            switch (style)
            {
                case RoundStyle.None:
                    path.AddRectangle(rect);
                    break;

                case RoundStyle.All:
                    path.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
                    path.AddArc((rect.Right - radius) - num, rect.Y, radius, radius, 270f, 90f);
                    path.AddArc((rect.Right - radius) - num, (rect.Bottom - radius) - num, radius, radius, 0f, 90f);
                    path.AddArc(rect.X, (rect.Bottom - radius) - num, radius, radius, 90f, 90f);
                    break;

                case RoundStyle.Left:
                    path.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
                    path.AddLine(rect.Right - num, rect.Y, rect.Right - num, rect.Bottom - num);
                    path.AddArc(rect.X, (rect.Bottom - radius) - num, radius, radius, 90f, 90f);
                    break;

                case RoundStyle.Right:
                    path.AddArc((rect.Right - radius) - num, rect.Y, radius, radius, 270f, 90f);
                    path.AddArc((rect.Right - radius) - num, (rect.Bottom - radius) - num, radius, radius, 0f, 90f);
                    path.AddLine(rect.X, rect.Bottom - num, rect.X, rect.Y);
                    break;

                case RoundStyle.Top:
                    path.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
                    path.AddArc((rect.Right - radius) - num, rect.Y, radius, radius, 270f, 90f);
                    path.AddLine(rect.Right - num, rect.Bottom - num, rect.X, rect.Bottom - num);
                    break;

                case RoundStyle.Bottom:
                    path.AddArc((rect.Right - radius) - num, (rect.Bottom - radius) - num, radius, radius, 0f, 90f);
                    path.AddArc(rect.X, (rect.Bottom - radius) - num, radius, radius, 90f, 90f);
                    path.AddLine(rect.X, rect.Y, rect.Right - num, rect.Y);
                    break;
            }
            path.CloseFigure();
            return path;
        }
    }
}

