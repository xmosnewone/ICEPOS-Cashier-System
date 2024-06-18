using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICE.POS
{
    public partial class FormWeb : Form
    {
        private string _html;
        public FormWeb()
        {
            InitializeComponent();
        }
        public FormWeb(string html)
        {
            InitializeComponent();
            _html = html;
        }

        private void FormWeb_Load(object sender, EventArgs e)
        {
            if (this.webBrowser2.InvokeRequired)
            {
                this.webBrowser2.Invoke(new EventHandler(delegate
                {
                    this.webBrowser2.DocumentText = _html;
                }));
            }
            else
            {
                this.webBrowser2.DocumentText = _html;
            }
            
        }

        private void Btn_Success_Click(object sender, EventArgs e)
        {

        }

        private Bitmap GetWebBrowserScreen()
        {
             Bitmap bitmap = new Bitmap(webBrowser2.Width, webBrowser2.Height);  // 创建高度和宽度与网页相同的图片
             Rectangle rectangle = new Rectangle(0, 0, webBrowser2.Width, webBrowser2.Height);  // 绘图区域
             webBrowser2.DrawToBitmap(bitmap, rectangle);  // 截图
             return bitmap;
        }
    }
}
