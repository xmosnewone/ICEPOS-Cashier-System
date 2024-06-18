namespace ICE.POS.Common
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Windows.Forms;

    public class ButtonEx : Button
    {
        private bool calledbykey;
        private IContainer components;
        private Image mBackImage;
        private Color mBaseColor;
        private Color mButtonColor;
        private State mButtonState;
        private Style mButtonStyle;
        private int mCornerRadius;
        private Timer mFadeIn;
        private Timer mFadeOut;
        private Color mForeColor;
        private int mGlowAlpha;
        private Color mGlowColor;
        private Color mHighlightColor;
        private Size mImageSize;

        public ButtonEx()
        {
            this.mFadeIn = new Timer();
            this.mFadeOut = new Timer();
            this.mForeColor = Color.Black;
            this.mHighlightColor = Color.FromArgb(0x6f, 0x6f, 0x6f);
            this.mButtonColor = Color.White;
            this.mGlowColor = Color.FromArgb(180, 180, 250);
            this.mBaseColor = Color.Transparent;
            this.mImageSize = new Size(0x18, 0x18);
            this.InitializeComponent();
            this.ForeColor = Color.Transparent;
            this.mFadeIn.Tick += new EventHandler(this.mFadeIn_Tick);
            this.mFadeOut.Tick += new EventHandler(this.mFadeOut_Tick);
        }

        public ButtonEx(IContainer container)
        {
            this.mFadeIn = new Timer();
            this.mFadeOut = new Timer();
            this.mForeColor = Color.Black;
            this.mHighlightColor = Color.FromArgb(0x6f, 0x6f, 0x6f);
            this.mButtonColor = Color.White;
            this.mGlowColor = Color.FromArgb(180, 180, 250);
            this.mBaseColor = Color.Transparent;
            this.mImageSize = new Size(0x18, 0x18);
            container.Add(this);
            this.InitializeComponent();
            this.ForeColor = Color.Transparent;
            this.mFadeIn.Tick += new EventHandler(this.mFadeIn_Tick);
            this.mFadeOut.Tick += new EventHandler(this.mFadeOut_Tick);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void DrawBackground(Graphics g)
        {
            if ((this.ButtonStyle != Style.Flat) || (this.mButtonState != State.None))
            {
                int alpha = (this.mButtonState == State.Pressed) ? 0xcc : 0x7f;
                Rectangle clientRectangle = base.ClientRectangle;
                clientRectangle.Width--;
                clientRectangle.Height--;
                using (GraphicsPath path = this.RoundRect(clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
                {
                    using (SolidBrush brush = new SolidBrush(this.BaseColor))
                    {
                        g.FillPath(brush, path);
                    }
                    this.SetClip(g);
                    if (this.BackImage != null)
                    {
                        g.DrawImage(this.BackImage, new Rectangle((base.Width / 2) - (this.BackImage.Width / 2), (base.Height / 2) - (this.BackImage.Height / 2), this.BackImage.Width, this.BackImage.Height));
                    }
                    g.ResetClip();
                    using (SolidBrush brush2 = new SolidBrush(Color.FromArgb(alpha, this.ButtonColor)))
                    {
                        g.FillPath(brush2, path);
                    }
                }
            }
        }

        private void DrawGlow(Graphics g)
        {
            if (this.mButtonState != State.Pressed)
            {
                this.SetClip(g);
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(-5, (base.Height / 2) - 10, base.Width + 11, base.Height + 11);
                    using (PathGradientBrush brush = new PathGradientBrush(path))
                    {
                        brush.CenterColor = Color.FromArgb(this.mGlowAlpha, this.GlowColor);
                        brush.SurroundColors = new Color[] { Color.FromArgb(0, this.GlowColor) };
                        g.FillPath(brush, path);
                    }
                }
                g.ResetClip();
            }
        }

        private void DrawHighlight(Graphics g)
        {
        }

        private void DrawImage(Graphics g)
        {
            if (base.Image != null)
            {
                Rectangle rect = new Rectangle(8, 8, this.ImageSize.Width, this.ImageSize.Height);
                switch (base.ImageAlign)
                {
                    case ContentAlignment.TopCenter:
                        rect = new Rectangle((base.Width / 2) - (this.ImageSize.Width / 2), 8, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.TopRight:
                        rect = new Rectangle((base.Width - 8) - this.ImageSize.Width, 8, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.MiddleLeft:
                        rect = new Rectangle(8, (base.Height / 2) - (this.ImageSize.Height / 2), this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.MiddleCenter:
                        rect = new Rectangle((base.Width / 2) - (this.ImageSize.Width / 2), (base.Height / 2) - (this.ImageSize.Height / 2), this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.BottomCenter:
                        rect = new Rectangle((base.Width / 2) - (this.ImageSize.Width / 2), (base.Height - 8) - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.BottomRight:
                        rect = new Rectangle((base.Width - 8) - this.ImageSize.Width, (base.Height - 8) - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.MiddleRight:
                        rect = new Rectangle((base.Width - 8) - this.ImageSize.Width, (base.Height / 2) - (this.ImageSize.Height / 2), this.ImageSize.Width, this.ImageSize.Height);
                        break;

                    case ContentAlignment.BottomLeft:
                        rect = new Rectangle(8, (base.Height - 8) - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                        break;
                }
                g.DrawImage(base.Image, rect);
            }
        }

        private void DrawInnerStroke(Graphics g)
        {
            if ((this.ButtonStyle != Style.Flat) || (this.mButtonState != State.None))
            {
                Rectangle clientRectangle = base.ClientRectangle;
                clientRectangle.X++;
                clientRectangle.Y++;
                clientRectangle.Width -= 3;
                clientRectangle.Height -= 3;
                using (GraphicsPath path = this.RoundRect(clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
                {
                    using (Pen pen = new Pen(this.HighlightColor))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }

        private void DrawOuterStroke(Graphics g)
        {
            if ((this.ButtonStyle != Style.Flat) || (this.mButtonState != State.None))
            {
                Rectangle clientRectangle = base.ClientRectangle;
                clientRectangle.Width--;
                clientRectangle.Height--;
                using (GraphicsPath path = this.RoundRect(clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
                {
                    using (Pen pen = new Pen(this.ButtonColor))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }

        private void DrawText(Graphics g)
        {
            StringFormat format = this.StringFormatAlignment(this.TextAlign);
            format.LineAlignment = StringAlignment.Center;
            format.HotkeyPrefix = HotkeyPrefix.Show;
            Rectangle layoutRectangle = new Rectangle(2, 2, base.Width - 4, base.Height - 4);
            if (base.Enabled)
            {
                g.DrawString(this.Text, this.Font, new SolidBrush(this.mForeColor), layoutRectangle, format);
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
        }

        private void mFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.ButtonStyle == Style.Flat)
            {
                this.mGlowAlpha = 0;
            }
            if ((this.mGlowAlpha + 30) >= 0xff)
            {
                this.mGlowAlpha = 0xff;
                this.mFadeIn.Stop();
            }
            else
            {
                this.mGlowAlpha += 30;
            }
            base.Invalidate();
        }

        private void mFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.ButtonStyle == Style.Flat)
            {
                this.mGlowAlpha = 0;
            }
            if ((this.mGlowAlpha - 30) <= 0)
            {
                this.mGlowAlpha = 0;
                this.mFadeOut.Stop();
            }
            else
            {
                this.mGlowAlpha -= 30;
            }
            base.Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Space)
            {
                MouseEventArgs args = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
                this.OnMouseDown(args);
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Space)
            {
                MouseEventArgs args = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
                this.calledbykey = true;
                this.OnMouseUp(args);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.mButtonState = State.Pressed;
                if (this.mButtonStyle != Style.Flat)
                {
                    this.mGlowAlpha = 0xff;
                }
                this.mFadeIn.Stop();
                this.mFadeOut.Stop();
                base.Invalidate();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.mButtonState = State.Hover;
            this.mFadeOut.Stop();
            this.mFadeIn.Start();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.mButtonState = State.None;
            if (this.mButtonStyle == Style.Flat)
            {
                this.mGlowAlpha = 0;
            }
            this.mFadeIn.Stop();
            this.mFadeOut.Start();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                this.mButtonState = State.Hover;
                this.mFadeIn.Stop();
                this.mFadeOut.Stop();
                base.Invalidate();
                if (this.calledbykey)
                {
                    this.OnClick(EventArgs.Empty);
                    this.calledbykey = false;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            this.DrawBackground(e.Graphics);
            this.DrawHighlight(e.Graphics);
            this.DrawImage(e.Graphics);
            this.DrawGlow(e.Graphics);
            this.DrawOuterStroke(e.Graphics);
            this.DrawInnerStroke(e.Graphics);
            this.DrawText(e.Graphics);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Rectangle clientRectangle = base.ClientRectangle;
            clientRectangle.X--;
            clientRectangle.Y--;
            clientRectangle.Width += 2;
            clientRectangle.Height += 2;
            using (GraphicsPath path = this.RoundRect(clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
            {
                base.Region = new Region(path);
            }
        }

        private GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X;
            float y = r.Y;
            float width = r.Width;
            float height = r.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            path.AddLine(x + r1, y, (x + width) - r2, y);
            path.AddBezier((x + width) - r2, y, x + width, y, x + width, y + r2, x + width, y + r2);
            path.AddLine((float) (x + width), (float) (y + r2), (float) (x + width), (float) ((y + height) - r3));
            path.AddBezier((float) (x + width), (float) ((y + height) - r3), (float) (x + width), (float) (y + height), (float) ((x + width) - r3), (float) (y + height), (float) ((x + width) - r3), (float) (y + height));
            path.AddLine((float) ((x + width) - r3), (float) (y + height), (float) (x + r4), (float) (y + height));
            path.AddBezier(x + r4, y + height, x, y + height, x, (y + height) - r4, x, (y + height) - r4);
            path.AddLine(x, (y + height) - r4, x, y + r1);
            return path;
        }

        private void SetClip(Graphics g)
        {
            Rectangle clientRectangle = base.ClientRectangle;
            clientRectangle.X++;
            clientRectangle.Y++;
            clientRectangle.Width -= 3;
            clientRectangle.Height -= 3;
            using (GraphicsPath path = this.RoundRect(clientRectangle, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius, (float) this.CornerRadius))
            {
                g.SetClip(path);
            }
        }

        public StringFormat StringFormatAlignment(ContentAlignment textalign)
        {
            StringFormat format = new StringFormat();
            ContentAlignment alignment = textalign;
            if (alignment <= ContentAlignment.MiddleCenter)
            {
                switch (alignment)
                {
                    case ContentAlignment.TopLeft:
                    case ContentAlignment.MiddleLeft:
                        goto Label_005A;

                    case ContentAlignment.TopCenter:
                    case ContentAlignment.MiddleCenter:
                        goto Label_0063;

                    case (ContentAlignment.TopCenter | ContentAlignment.TopLeft):
                        return format;

                    case ContentAlignment.TopRight:
                        goto Label_006C;
                }
                return format;
            }
            if (alignment <= ContentAlignment.BottomLeft)
            {
                switch (alignment)
                {
                    case ContentAlignment.MiddleRight:
                        goto Label_006C;

                    case ContentAlignment.BottomLeft:
                        goto Label_005A;
                }
                return format;
            }
            switch (alignment)
            {
                case ContentAlignment.BottomCenter:
                    goto Label_0063;

                case ContentAlignment.BottomRight:
                    goto Label_006C;

                default:
                    return format;
            }
        Label_005A:
            format.Alignment = StringAlignment.Near;
            return format;
        Label_0063:
            format.Alignment = StringAlignment.Center;
            return format;
        Label_006C:
            format.Alignment = StringAlignment.Far;
            return format;
        }

        [Category("Others"), DefaultValue((string) null), Description("背景图!")]
        public Image BackImage
        {
            get
            {
                return this.mBackImage;
            }
            set
            {
                this.mBackImage = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Black"), Description("绘制在Button上凸显明净的颜色，产生玻璃效果（绘制在没有Glow色绘制的客户端区域)!"), Category("Others"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BaseColor
        {
            get
            {
                return this.mBaseColor;
            }
            set
            {
                this.mBaseColor = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "Black"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Description("设置Button的颜色!"), Category("Others")]
        public Color ButtonColor
        {
            get
            {
                return this.mButtonColor;
            }
            set
            {
                this.mButtonColor = value;
                base.Invalidate();
            }
        }

        [Category("Others"), DefaultValue(typeof(Style), "Default"), Description("设置当鼠标不再客户区的时候，button的背景是不是被绘制")]
        public Style ButtonStyle
        {
            get
            {
                return this.mButtonStyle;
            }
            set
            {
                this.mButtonStyle = value;
                base.Invalidate();
            }
        }

        [DefaultValue(8), Category("Others"), Description("设置button的圆角的弧度，弧度越大，越光滑,弧度的大小不超过Button高的一半!"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius
        {
            get
            {
                return this.mCornerRadius;
            }
            set
            {
                this.mCornerRadius = value;
                base.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DefaultValue(typeof(Color), "141,189,255"), Description("当鼠标在控件客户端范围内，绘制控件的暗光!"), Category("Others")]
        public Color GlowColor
        {
            get
            {
                return this.mGlowColor;
            }
            set
            {
                this.mGlowColor = value;
                base.Invalidate();
            }
        }

        [Category("Others"), DefaultValue(typeof(Color), "White"), Description("设置高光颜色!"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HighlightColor
        {
            get
            {
                return this.mHighlightColor;
            }
            set
            {
                this.mHighlightColor = value;
                base.Invalidate();
            }
        }

        [Description("图片大小"), DefaultValue(typeof(Size), "24, 24"), Category("Image")]
        public Size ImageSize
        {
            get
            {
                return this.mImageSize;
            }
            set
            {
                this.mImageSize = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "White"), Description("设置字体颜色!"), Category("Others"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TForeColor
        {
            get
            {
                return this.mForeColor;
            }
            set
            {
                this.mForeColor = value;
                base.Invalidate();
            }
        }

        private enum State
        {
            None,
            Hover,
            Pressed
        }

        public enum Style
        {
            Default,
            Flat
        }
    }
}

