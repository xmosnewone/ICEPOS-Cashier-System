namespace ICE.POS.Common
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class ButtonForPos : PictureBox
    {
        private Color _baseColor = Color.FromArgb(210, 210, 0xd7);
        private ControlState _controlState;
        private Font _downFont = new Font("宋体", 10f, FontStyle.Regular);
        private int _imageWidth = 0x12;
        private bool _isGrass;
        private bool _isItem;
        private string _myText = string.Empty;
        private string _myUpText = string.Empty;
        private int _radius = 8;
        private RoundStyle _roundStyle = RoundStyle.All;
        private Font _upFont = new Font("宋体", 10f, FontStyle.Regular);
        private IContainer components;

        public ButtonForPos()
        {
            this.BackColor = Color.Transparent;
            this.Font = new Font("宋体", 10f, FontStyle.Bold);
            this.ForeColor = Color.FromArgb(0x20, 0x20, 0x20);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
        }

        private void CalculateRect(out Rectangle imageRect, out Rectangle textRect)
        {
            imageRect = Rectangle.Empty;
            textRect = Rectangle.Empty;
            if (base.Image == null)
            {
                textRect = new Rectangle(2, 0, base.Width - 4, base.Height);
            }
            else if (this.RightToLeft == RightToLeft.Yes)
            {
                imageRect.X = base.Width - imageRect.Right;
                textRect.X = base.Width - textRect.Right;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void DrawGlass(Graphics g, RectangleF glassRect, int alphaCenter, int alphaSurround)
        {
            this.DrawGlass(g, glassRect, Color.White, alphaCenter, alphaSurround);
        }

        private void DrawGlass(Graphics g, RectangleF glassRect, Color glassColor, int alphaCenter, int alphaSurround)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(glassRect);
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.FromArgb(alphaCenter, glassColor);
                    brush.SurroundColors = new Color[] { Color.FromArgb(alphaSurround, glassColor) };
                    brush.CenterPoint = new PointF(glassRect.X + (glassRect.Width / 2f), glassRect.Y + (glassRect.Height / 2f));
                    g.FillPath(brush, path);
                }
            }
        }

        private Color GetColor(Color colorBase, int a, int r, int g, int b)
        {
            int num = colorBase.A;
            int num2 = colorBase.R;
            int num3 = colorBase.G;
            int num4 = colorBase.B;
            if ((a + num) > 0xff)
            {
                a = 0xff;
            }
            else
            {
                a = Math.Max(a + num, 0);
            }
            if ((r + num2) > 0xff)
            {
                r = 0xff;
            }
            else
            {
                r = Math.Max(r + num2, 0);
            }
            if ((g + num3) > 0xff)
            {
                g = 0xff;
            }
            else
            {
                g = Math.Max(g + num3, 0);
            }
            if ((b + num4) > 0xff)
            {
                b = 0xff;
            }
            else
            {
                b = Math.Max(b + num4, 0);
            }
            return Color.FromArgb(a, r, g, b);
        }

        internal static TextFormatFlags GetTextFormatFlags(ContentAlignment alignment, bool rightToleft)
        {
            TextFormatFlags flags = TextFormatFlags.SingleLine | TextFormatFlags.WordBreak;
            if (rightToleft)
            {
                flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
            }
            ContentAlignment alignment2 = alignment;
            if (alignment2 <= ContentAlignment.MiddleCenter)
            {
                switch (alignment2)
                {
                    case ContentAlignment.TopLeft:
                        return flags;

                    case ContentAlignment.TopCenter:
                        return (flags | TextFormatFlags.HorizontalCenter);

                    case (ContentAlignment.TopCenter | ContentAlignment.TopLeft):
                        return flags;

                    case ContentAlignment.TopRight:
                        return (flags | TextFormatFlags.Right);

                    case ContentAlignment.MiddleLeft:
                        return (flags | TextFormatFlags.VerticalCenter);

                    case ContentAlignment.MiddleCenter:
                        return (flags | (TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter));
                }
                return flags;
            }
            if (alignment2 <= ContentAlignment.BottomLeft)
            {
                switch (alignment2)
                {
                    case ContentAlignment.MiddleRight:
                        return (flags | (TextFormatFlags.VerticalCenter | TextFormatFlags.Right));

                    case ContentAlignment.BottomLeft:
                        return (flags | TextFormatFlags.Bottom);
                }
                return flags;
            }
            if (alignment2 != ContentAlignment.BottomCenter)
            {
                if (alignment2 != ContentAlignment.BottomRight)
                {
                    return flags;
                }
                return (flags | (TextFormatFlags.Bottom | TextFormatFlags.Right));
            }
            return (flags | (TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter));
        }

        private void InitializeComponent()
        {
            this.components = new Container();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if ((e.Button == MouseButtons.Left) && (e.Clicks == 1))
            {
                this.ControlState =ControlState.Pressed;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.ControlState = ControlState.Hover;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.ControlState = ControlState.Normal;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if ((e.Button == MouseButtons.Left) && (e.Clicks == 1))
            {
                if (base.ClientRectangle.Contains(e.Location))
                {
                    this.ControlState = ControlState.Hover;
                }
                else
                {
                    this.ControlState = ControlState.Normal;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rectangle;
            Rectangle rectangle2;
            Color controlDark;
            Color color2;
            base.OnPaint(e);
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            this.CalculateRect(out rectangle, out rectangle2);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color innerBorderColor = Color.FromArgb(200, 0xff, 0xff, 0xff);
            if (!base.Enabled)
            {
                controlDark = SystemColors.ControlDark;
                color2 = SystemColors.ControlDark;
            }
            else
            {
                switch (this.ControlState)
                {
                    case ControlState.Hover:
                        controlDark = this.GetColor(this._baseColor, 0, -10, -3, -93);
                        color2 = this._baseColor;
                        break;

                    case ControlState.Pressed:
                        controlDark = this.GetColor(this._baseColor, 0, -15, -3, -200);
                        color2 = this._baseColor;
                        break;

                    default:
                        controlDark = this._baseColor;
                        color2 = this._baseColor;
                        break;
                }
                if (this._isItem)
                {
                    color2 = Color.FromArgb(0x8b, 0x8b, 0x8b);
                }
            }
            this.RenderBackgroundInternal(g, base.ClientRectangle, controlDark, color2, innerBorderColor, this.RoundStyle, this.Radius, 0.35f, true, this._isGrass, LinearGradientMode.Vertical);
            if (base.Image != null)
            {
                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                g.DrawImage(base.Image, rectangle, 0, 0, base.Image.Width, base.Image.Height, GraphicsUnit.Pixel);
            }
            if (this._myUpText == string.Empty)
            {
                if (this.MyText.Trim() == "<")
                {
                    Point point = new Point((base.Width / 2) - 6, base.Height / 2);
                    Point point2 = new Point((base.Width / 2) + 6, (base.Height / 2) - 8);
                    Point point3 = new Point((base.Width / 2) + 6, (base.Height / 2) + 8);
                    Point[] points = new Point[] { point, point2, point3 };
                    e.Graphics.FillPolygon(Brushes.Black, points);
                }
                else if (this.MyText.Trim() == ">")
                {
                    Point point4 = new Point((base.Width / 2) + 6, base.Height / 2);
                    Point point5 = new Point((base.Width / 2) - 6, (base.Height / 2) - 8);
                    Point point6 = new Point((base.Width / 2) - 6, (base.Height / 2) + 8);
                    Point[] pointArray2 = new Point[] { point4, point5, point6 };
                    e.Graphics.FillPolygon(Brushes.Black, pointArray2);
                }
                else if (this.MyText.Trim() == "∧")
                {
                    Point point7 = new Point(base.Width / 2, (base.Height / 2) - 6);
                    Point point8 = new Point((base.Width / 2) - 8, (base.Height / 2) + 6);
                    Point point9 = new Point((base.Width / 2) + 8, (base.Height / 2) + 6);
                    Point[] pointArray3 = new Point[] { point7, point8, point9 };
                    e.Graphics.FillPolygon(Brushes.Black, pointArray3);
                }
                else if (this.MyText.Trim() == "∨")
                {
                    Point point10 = new Point(base.Width / 2, (base.Height / 2) + 6);
                    Point point11 = new Point((base.Width / 2) - 8, (base.Height / 2) - 6);
                    Point point12 = new Point((base.Width / 2) + 8, (base.Height / 2) - 6);
                    Point[] pointArray4 = new Point[] { point10, point11, point12 };
                    e.Graphics.FillPolygon(Brushes.Black, pointArray4);
                }
                else
                {
                    TextRenderer.DrawText(g, this.MyText, this.Font, rectangle2, this.ForeColor, GetTextFormatFlags(ContentAlignment.MiddleCenter, this.RightToLeft == RightToLeft.Yes));
                }
            }
            else
            {
                Rectangle bounds = new Rectangle(rectangle2.X, rectangle2.Y, rectangle2.Width, (rectangle2.Height / 2) - 10);
                TextRenderer.DrawText(g, this._myUpText, this._upFont, bounds, this.ForeColor, GetTextFormatFlags(ContentAlignment.MiddleCenter, this.RightToLeft == RightToLeft.Yes));
                if (this.IsItem)
                {
                    rectangle2 = new Rectangle(rectangle2.X, ((rectangle2.Y + rectangle2.Height) / 2) - 2, rectangle2.Width, (rectangle2.Height / 2) - 8);
                    StringFormat format = new StringFormat {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    SolidBrush brush = new SolidBrush(this.ForeColor);
                    g.DrawString(this.MyText, this._upFont, brush, rectangle2, format);
                }
                else
                {
                    rectangle2 = new Rectangle(rectangle2.X, (rectangle2.Y + rectangle2.Height) / 2, rectangle2.Width, rectangle2.Height / 2);
                    ContentAlignment topLeft = ContentAlignment.TopLeft;
                    if (this.MyText.Length < 5)
                    {
                        topLeft = ContentAlignment.TopCenter;
                    }
                    TextRenderer.DrawText(g, this.MyText, this._downFont, rectangle2, this.ForeColor, GetTextFormatFlags(topLeft, this.RightToLeft == RightToLeft.Yes));
                }
            }
        }

        internal void RenderBackgroundInternal(Graphics g, Rectangle rect, Color baseColor, Color borderColor, Color innerBorderColor,RoundStyle style, int roundWidth, float basePosition, bool drawBorder, bool drawGlass, LinearGradientMode mode)
        {
            if (drawBorder)
            {
                rect.Width--;
                rect.Height--;
            }
            if (this.IsItem)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.White, baseColor, mode))
                {
                    using (GraphicsPath path = GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                    {
                        g.FillPath(brush, path);
                    }
                    using (GraphicsPath path2 = GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                    {
                        using (Pen pen = new Pen(borderColor))
                        {
                            g.DrawPath(pen, path2);
                        }
                    }
                    return;
                }
            }
            using (LinearGradientBrush brush2 = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, mode))
            {
                Color[] colorArray = new Color[] { this.GetColor(baseColor, 0, 0x23, 0x18, 9), this.GetColor(baseColor, 0, 13, 8, 3), baseColor, this.GetColor(baseColor, 0, 0x44, 0x45, 0x36) };
                ColorBlend blend = new ColorBlend();
                float[] numArray = new float[4];
                numArray[1] = basePosition;
                numArray[2] = basePosition + 0.05f;
                numArray[3] = 1f;
                blend.Positions = numArray;
                blend.Colors = colorArray;
                brush2.InterpolationColors = blend;
                if (style != RoundStyle.None)
                {
                    using (GraphicsPath path3 = GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                    {
                        g.FillPath(brush2, path3);
                    }
                    if (baseColor.A > 80)
                    {
                        Rectangle rectangle = rect;
                        if (mode == LinearGradientMode.Vertical)
                        {
                            rectangle.Height = (int) (rectangle.Height * basePosition);
                        }
                        else
                        {
                            rectangle.Width = (int) (rect.Width * basePosition);
                        }
                        using (GraphicsPath path4 = GraphicsPathHelper.CreatePath(rectangle, roundWidth, RoundStyle.Top, false))
                        {
                            using (SolidBrush brush3 = new SolidBrush(Color.FromArgb(80, 0xff, 0xff, 0xff)))
                            {
                                g.FillPath(brush3, path4);
                            }
                        }
                    }
                    if (drawGlass)
                    {
                        RectangleF glassRect = rect;
                        if (mode == LinearGradientMode.Vertical)
                        {
                            glassRect.Y = rect.Y + (rect.Height * basePosition);
                            glassRect.Height = (rect.Height - (rect.Height * basePosition)) * 2f;
                        }
                        else
                        {
                            glassRect.X = rect.X + (rect.Width * basePosition);
                            glassRect.Width = (rect.Width - (rect.Width * basePosition)) * 2f;
                        }
                        this.DrawGlass(g, glassRect, 170, 0);
                    }
                    if (!drawBorder)
                    {
                        return;
                    }
                    using (GraphicsPath path5 = GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                    {
                        using (Pen pen2 = new Pen(borderColor))
                        {
                            g.DrawPath(pen2, path5);
                        }
                    }
                    rect.Inflate(-1, -1);
                    using (GraphicsPath path6 = GraphicsPathHelper.CreatePath(rect, roundWidth, style, false))
                    {
                        using (Pen pen3 = new Pen(innerBorderColor))
                        {
                            g.DrawPath(pen3, path6);
                        }
                        return;
                    }
                }
                g.FillRectangle(brush2, rect);
                if (baseColor.A > 80)
                {
                    Rectangle rectangle2 = rect;
                    if (mode == LinearGradientMode.Vertical)
                    {
                        rectangle2.Height = (int) (rectangle2.Height * basePosition);
                    }
                    else
                    {
                        rectangle2.Width = (int) (rect.Width * basePosition);
                    }
                    using (SolidBrush brush4 = new SolidBrush(Color.FromArgb(80, 0xff, 0xff, 0xff)))
                    {
                        g.FillRectangle(brush4, rectangle2);
                    }
                }
                if (drawGlass)
                {
                    RectangleF ef2 = rect;
                    if (mode == LinearGradientMode.Vertical)
                    {
                        ef2.Y = rect.Y + (rect.Height * basePosition);
                        ef2.Height = (rect.Height - (rect.Height * basePosition)) * 2f;
                    }
                    else
                    {
                        ef2.X = rect.X + (rect.Width * basePosition);
                        ef2.Width = (rect.Width - (rect.Width * basePosition)) * 2f;
                    }
                    this.DrawGlass(g, ef2, 200, 0);
                }
                if (drawBorder)
                {
                    using (Pen pen4 = new Pen(borderColor))
                    {
                        g.DrawRectangle(pen4, rect);
                    }
                    rect.Inflate(-1, -1);
                    using (Pen pen5 = new Pen(innerBorderColor))
                    {
                        g.DrawRectangle(pen5, rect);
                    }
                }
            }
        }

        [DefaultValue(typeof(Color), "210, 210, 215")]
        public Color BaseColor
        {
            get
            {
                return this._baseColor;
            }
            set
            {
                this._baseColor = value;
                base.Invalidate();
            }
        }

        internal ControlState ControlState
        {
            get
            {
                return this._controlState;
            }
            set
            {
                if (this._controlState != value)
                {
                    this._controlState = value;
                    base.Invalidate();
                }
            }
        }

        [DefaultValue(0x12)]
        public int ImageWidth
        {
            get
            {
                return this._imageWidth;
            }
            set
            {
                if (value != this._imageWidth)
                {
                    this._imageWidth = (value < 12) ? 12 : value;
                    base.Invalidate();
                }
            }
        }

        [DefaultValue("false")]
        public bool IsGrass
        {
            get
            {
                return this._isGrass;
            }
            set
            {
                this._isGrass = value;
                base.Invalidate();
            }
        }

        [DefaultValue("false")]
        public bool IsItem
        {
            get
            {
                return this._isItem;
            }
            set
            {
                this._isItem = value;
                base.Invalidate();
            }
        }

        [DefaultValue("")]
        public string MyText
        {
            get
            {
                return this._myText;
            }
            set
            {
                if (this._myText != value)
                {
                    this._myText = value;
                    base.Invalidate();
                }
            }
        }

        [DefaultValue("")]
        public string MyUpText
        {
            get
            {
                return this._myUpText;
            }
            set
            {
                if (this._myUpText != value)
                {
                    if (value.Length > 10)
                    {
                        value = "*" + value.Substring(value.Length - 10, 10);
                    }
                    this._myUpText = value;
                    base.Invalidate();
                }
            }
        }

        [DefaultValue(8)]
        public int Radius
        {
            get
            {
                return this._radius;
            }
            set
            {
                if (this._radius != value)
                {
                    this._radius = (value < 4) ? 4 : value;
                    base.Invalidate();
                }
            }
        }

        [DefaultValue(typeof(RoundStyle), "1")]
        public RoundStyle RoundStyle
        {
            get
            {
                return this._roundStyle;
            }
            set
            {
                if (this._roundStyle != value)
                {
                    this._roundStyle = value;
                    base.Invalidate();
                }
            }
        }
    }
}

