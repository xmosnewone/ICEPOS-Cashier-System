namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Net;
    using System.Windows.Forms;
    using System.IO;
    using ICE.POS.Model;
    using ICE.POS.Common;
    using System.Security.Permissions;
    
    
    
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FrmDoubleDisplay : Form
    {
        private List<t_cur_saleflow> _listSaleFlow;
        public List<string> adp_list;
        public List<string> av_file;
        private FrmMain _frmMain;
        public int curradp;
        public int currfil;
        public int l_height;
        public int l_width;
        public string alipay_no = string.Empty;
        public string html2 = string.Empty;
        public WebBrowser webBrowser1;
        public Panel parentContainer = new Panel(); // 创建父容器

        public FrmDoubleDisplay(FrmMain frmmain, FrmStart _frmStart)
        {
            this._listSaleFlow = null;
            this._frmMain = null;
            this.currfil = 0;
            this.curradp = 0;
            this.components = null;
            this.InitializeComponent();



            this._frmMain = frmmain;
            if (Gattr.IsDoubleSetwh)
            {
                //固定宽高设置双排显示，默认是false
                try
                {
                    this.l_width = Gattr.DoubleSetwidth;
                    this.l_height = Gattr.DoubleSetheight;
                }
                catch
                {
                    this.l_width = this._frmMain.Width;
                    this.l_height = this._frmMain.Height;
                }
                base.Width = this.l_width;
                base.Height = this.l_height;
                base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width, 0);
            }
            else
            {
                base.Width = this._frmMain.Width;
                base.Height = this._frmMain.Height;
                base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width, 0);
            }

            this.plpay.Location = new Point(0, (base.Height - this.plpay.Height) + 10);
            this.tblCardInfo.Location = new Point(2, ((base.Height - this.plpay.Height) - this.tblCardInfo.Height) + 5);
            this.tblCardInfo.Width = this.plSale.Width;
            this.plSale.Location = new Point(0, 5);
            this.plSale.Height = ((base.Height - this.plpay.Height) - this.tblCardInfo.Height) - 6;
            this.plpay.Width = this.plSale.Width;

            this.av_file = new List<string>();
            this.adp_list = new List<string>();
           
            //要用线程开启webbrowser
            Thread thd = new Thread(new ParameterizedThreadStart(showWeb));
            CheckForIllegalCrossThreadCalls = false;
            thd.SetApartmentState(ApartmentState.STA);//关键设置
            thd.IsBackground = true;
            //Thread.Sleep(300);
            try
            {
                thd.Start();
            }
            catch (ThreadStateException stateException)
            {
                Console.WriteLine(stateException.ToString());
            }



        }

        private void CreateUI()
        {
            AddPanel();
        }

        private void AddPanel()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { AddPanel(); }));
                return;
            }
            
            parentContainer.Location = new Point(this.plpay.Width+10, 0);
            parentContainer.Width = base.Width - this.plpay.Width - 10;
            parentContainer.Height = base.Height;
            parentContainer.BackColor = Color.Gray;
            parentContainer.Name = "mypannel1";
            
            this.Controls.Add(parentContainer);
        }

        /*线程创建webbrowser*/
        public void showWeb(object obj)
        {
          
            this.webBrowser1 = new WebBrowser();
            this.webBrowser1.AllowNavigation = true;
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Navigate(Gattr.adUrl);
            //Console.WriteLine(Gattr.adUrl);
            
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler((object sender, WebBrowserDocumentCompletedEventArgs e) =>
            {
                if (this.webBrowser1.ReadyState == WebBrowserReadyState.Complete)
                {
                    this.webBrowser1.Location = new Point(0, 0);
                    this.webBrowser1.Width = base.Width - this.plpay.Width - 10; ;
                    this.webBrowser1.Height = base.Height;
                    this.webBrowser1.Refresh();
                    try
                    {
                        this.parentContainer.Controls.Add(this.webBrowser1);
                        Thread t = new Thread(new ThreadStart(CreateUI));
                        t.Start();
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine(es.ToString());
                    }
                }
            });


            Application.Run();

        }



        private long DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            TimeSpan span = new TimeSpan(DateTime1.Ticks);
            TimeSpan ts = new TimeSpan(DateTime2.Ticks);
            TimeSpan span3 = span.Subtract(ts).Duration();
            return (long)((((((span3.Days * 0x18) * 60) * 60) + ((span3.Hours * 60) * 60)) + (span3.Minutes * 60)) + span3.Seconds);
        }
        private void FrmDoubleDisplay_Load(object sender, EventArgs e)
        {
            
            Screen[] sc = Screen.AllScreens;
            if (sc.Length == 2)
            {
                this.Location = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
                string str4;
                this._listSaleFlow = this._frmMain._listSaleFlow;
                this.bindingSaleFlow.DataSource = this._listSaleFlow;
                this.GvSaleFlow.DataSource = this.bindingSaleFlow;
                base.ShowInTaskbar = false;
                short doubleColorRed = Gattr.DoubleColorRed;
                short doubleColorGreen = Gattr.DoubleColorGreen;
                short doubleColorBlue = Gattr.DoubleColorBlue;
                //this.BackColor = Color.FromArgb(doubleColorRed, doubleColorGreen, doubleColorBlue);
                //this.plSaleFlow.BackColor = Color.FromArgb(doubleColorRed, doubleColorGreen, doubleColorBlue);
               // this.plpay.BackColor = Color.FromArgb(doubleColorRed, doubleColorGreen, doubleColorBlue);
                //this.GvSaleFlow.BackgroundColor = Color.FromArgb(doubleColorRed, doubleColorGreen, doubleColorBlue);

                this.currNow = DateTime.Now;
            }
        }
        //lable字体颜色变化
        private void ColorChange()
        {
            Random random = new Random();
            while (true)
            {
                int red = random.Next(1, 256);
                int green = random.Next(1, 256);
                int blue = random.Next(1, 256);
               // this.tbAd.ForeColor = Color.FromArgb(red, green, blue);
                System.Threading.Thread.Sleep(500);
            }
        }
        private void GvSaleFlow_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                t_cur_saleflow _saleflow = this.bindingSaleFlow[e.RowIndex] as t_cur_saleflow;
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255));
                if (this.bindingSaleFlow.Position == e.RowIndex)
                {
                    brush = new SolidBrush(Color.FromArgb(255, 255, 255));
                }
                e.Graphics.FillRectangle(brush, e.RowBounds);
                SolidBrush brush2 = new SolidBrush(Color.FromArgb(0x80, 0x80, 0x80));
                SolidBrush brush3 = new SolidBrush(Color.Black);
                e.Graphics.DrawRectangle(new Pen(brush2), e.RowBounds);
                Rectangle layoutRectangle = new Rectangle(e.RowBounds.X, e.RowBounds.Y + 5, (e.RowBounds.Width / 3) + 0x10, e.RowBounds.Height / 2);
                e.Graphics.DrawString(_saleflow.item_no, this.Font, brush3, layoutRectangle);
                Rectangle rectangle2 = new Rectangle(layoutRectangle.X + layoutRectangle.Width, layoutRectangle.Y, e.RowBounds.Width - layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString(_saleflow.item_name, this.Font, brush3, rectangle2);
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Far
                };
                Rectangle rectangle3 = new Rectangle(layoutRectangle.X, layoutRectangle.Y + layoutRectangle.Height, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString(_saleflow.sale_qnty.ToString(Gattr.PosSaleNumPoint), this.Font, brush3, rectangle3, format);
                Rectangle rectangle4 = new Rectangle(rectangle2.X, rectangle3.Y, rectangle2.Width / 2, layoutRectangle.Height);
                e.Graphics.DrawString(_saleflow.sale_price.ToString(Gattr.PosSalePrcPoint), this.Font, brush3, rectangle4, format);
                Rectangle rectangle5 = new Rectangle(rectangle2.X + rectangle4.Width, rectangle3.Y, rectangle2.Width / 2, layoutRectangle.Height);
                e.Graphics.DrawString(_saleflow.sale_money.ToString(Gattr.PosSaleAmtPoint), this.Font, brush3, rectangle5, format);
            }
        }

        private void GvSaleFlow_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < this.GvSaleFlow.RowCount; i++)
            {
                if (this.GvSaleFlow.Rows[i].Height < this.GvSaleFlow.ColumnHeadersHeight)
                {
                    this.GvSaleFlow.Rows[i].Height = this.GvSaleFlow.ColumnHeadersHeight;
                }
            }
        }
        
       
        public void SetDoubleDisplay(string state, string TotalAmt, string RemainAmt, string PaedAmt, string ChgAmt, string TotalQty, string cardid, string money,string score)
        {
            this._listSaleFlow = this._frmMain._listSaleFlow;
            this.bindingSaleFlow.DataSource = this._listSaleFlow;
            this.GvSaleFlow.DataSource = this.bindingSaleFlow;
            this.bindingSaleFlow.ResetBindings(true);
            this.bindingSaleFlow.Position = this.bindingSaleFlow.Count - 1;
            this.GvSaleFlow.Refresh();
            if (state == "1")
            {
                this.lbBTotalAmt.Text = TotalAmt;
                this.lbRemainAmt.Text = RemainAmt;
                this.lbPaedAmt.Text = "0.00";
                this.lbChgAmt.Text = "0.00";
            }
            else
            {
                this.lbBTotalAmt.Text = TotalAmt;
                this.lbRemainAmt.Text = RemainAmt;
                this.lbPaedAmt.Text = PaedAmt;
                this.lbChgAmt.Text = ChgAmt;
            }
            this.lbTotalQty.Text = "数量和:" + TotalQty;
            this.lbTotalAmt.Text = "金额和:" + TotalAmt;
            this.lbCard.Text = "卡 号:" + cardid;
            this.lbMoney.Text = "金 额：" + money;
            this.lbScore.Text = "积 分：" + score;
            //if (Gattr.IsVipNoInvisible && (cardid != string.Empty))
            //{
            //    this.lbCard.Text = "卡 号: ******* ";
            //}
        }
        
 
        public void SetWebBrowserUrl(string url)
        {
            this.webBrowser1.Navigate(url);
        }

        public void SetWebDocument(string html)
        {
            this.webBrowser1.DocumentText = html;
        }
        //截取顾显WebBrowser界面
        public Bitmap GetWebBrowserScreen()
        {
            //创建高度和宽度与网页相同的图片
            Bitmap bitmap = new Bitmap(webBrowser1.Width, webBrowser1.Height);
            //绘图区域
            Rectangle rectangle = new Rectangle(0, 0, webBrowser1.Width, webBrowser1.Height);
            //截图
            webBrowser1.DrawToBitmap(bitmap, rectangle);
            return bitmap;
        }

        private void GvSaleFlow_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                //应用程序要求关闭窗口
                case CloseReason.ApplicationExitCall:
                    e.Cancel = false; //不拦截，响应操作
                    break;
                //自身窗口上的关闭按钮
                case CloseReason.FormOwnerClosing:
                    e.Cancel = true;//拦截，不响应操作
                    break;
                //MDI窗体关闭事件
                case CloseReason.MdiFormClosing:
                    e.Cancel = true;//拦截，不响应操作
                    break;
                //不明原因的关闭
                case CloseReason.None:
                    break;
                //任务管理器关闭进程
                case CloseReason.TaskManagerClosing:
                    e.Cancel = false;//不拦截，响应操作
                    break;
                //用户通过UI关闭窗口或者通过Alt+F4关闭窗口
                case CloseReason.UserClosing:
                    e.Cancel = true;//拦截，不响应操作
                    break;
                //操作系统准备关机
                case CloseReason.WindowsShutDown:
                    e.Cancel = false;//不拦截，响应操作
                    break;
                default:
                    break;
            }
        }

        private void visibleChange(object sender, EventArgs e) {
            
        }
    }
}
