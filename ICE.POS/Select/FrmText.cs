using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.Utility;

namespace ICE.POS
{
    public partial class FrmText : Form
    {
        public FrmText()
        {
            InitializeComponent();
            string err = string.Empty;
            richTextBox1.Text = FileUtility.Instance.GetFileContent(Gattr.TextFile, ref err);
            //this.timer1.Start();
        }

        private void FrmText_Load(object sender, EventArgs e)
        {
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Bounds.Contains(Cursor.Position))
            {
                switch (this.StopAanhor)
                {
                    case AnchorStyles.Top:
                        //窗体在最上方隐藏时，鼠标接触自动出现
                        this.Location = new Point(this.Location.X, 0);
                        break;
                    //窗体在最左方隐藏时，鼠标接触自动出现
                    case AnchorStyles.Left:
                        this.Location = new Point(0, this.Location.Y);
                        break;
                    //窗体在最右方隐藏时，鼠标接触自动出现
                    case AnchorStyles.Right:
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
                        break;
                }
            }
            else
            {
                //窗体隐藏时在靠近边界的一侧边会出现2像素原因：感应鼠标，同时2像素不会影响用户视线
                switch (this.StopAanhor)
                {
                    //窗体在顶部时时，隐藏在顶部，底部边界出现2像素
                    case AnchorStyles.Top:
                        this.TopMost = true;
                        this.Location = new Point(this.Location.X, (this.Height - 2) * (-1));
                        break;
                    //窗体在最左边时时，隐藏在左边，右边边界出现2像素
                    case AnchorStyles.Left:
                        this.TopMost = true;
                        this.Location = new Point((-1) * (this.Width - 2), this.Location.Y);
                        break;
                    //窗体在最右边时时，隐藏在右边，左边边界出现2像素
                    case AnchorStyles.Right:
                        this.TopMost = true;
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 2, this.Location.Y);
                        break;
                }
            }
        }

        internal AnchorStyles StopAanhor = AnchorStyles.None;
        
        
        
        private void mStopAnhor()
        {
            if (this.Top <= 0)
            {
                StopAanhor = AnchorStyles.Top;
            }
            else if (this.Left <= 0)
            {
                StopAanhor = AnchorStyles.Left;
            }
            else if (this.Left >= Screen.PrimaryScreen.Bounds.Width - this.Width)
            {
                StopAanhor = AnchorStyles.Right;
            }
            else
            {
                StopAanhor = AnchorStyles.None;
            }
        }

        private void FrmText_LocationChanged(object sender, EventArgs e)
        {
            //this.TopMost = false;
            //this.mStopAnhor();
        }

        private void FrmText_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileUtility.Instance.WriteFile(Gattr.TextFile, richTextBox1.Text.Trim());
            //this.Dispose();
        }
    }
}
