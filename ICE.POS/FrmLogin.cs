namespace ICE.POS
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Reflection;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    using System.Collections;
    using System.Collections.Generic;
    
    public partial class FrmLogin : Form
    {
        #region  窗体全局声名


        private FrmStart _frmStart = null;
        public FrmStart frmStart
        {
            get
            {
                return _frmStart;
            }
            set
            {
                _frmStart = value;
            }
        }
        t_operator _oper;
        string _loginParm = "";
        FrmMain _formMain = null;
        public FrmMain FormMain
        {
            get
            {
                return this._formMain;
            }
            set
            {
                this._formMain = value;
            }
        }
        public string LoginParm
        {
            get
            {
                return this._loginParm;
            }
            set
            {
                this._loginParm = value;
            }
        }
        #endregion
        #region 窗体构造函数
        public FrmLogin(FrmStart _frmstart)
        {
            InitializeComponent();
            try
            {
                this.frmStart = _frmstart;
                this.tbPwd.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.tbPwd.Width, this.tbPwd.Height), 5f));
                this.tbUserName.Region = new Region(GetRoundRectPath(new RectangleF(0, 0, this.tbUserName.Width, this.tbUserName.Height), 5f));
                this.iniSysInfo(false);
                this.tbUserName.Text = string.Empty;
                this.tbPwd.Text = string.Empty;
                this.ActiveControl = this.tbUserName;
                this.tbUserName.Focus();
                Assembly assembly = Assembly.GetExecutingAssembly();
                //this.labelEdition.Text = assembly.FullName;   

                // 获取程序集元数据   
                AssemblyCopyrightAttribute copyright = (AssemblyCopyrightAttribute)
                AssemblyCopyrightAttribute.GetCustomAttribute(Assembly.GetExecutingAssembly(),
                typeof(AssemblyCopyrightAttribute));
                AssemblyDescriptionAttribute description = (AssemblyDescriptionAttribute)
                AssemblyDescriptionAttribute.GetCustomAttribute(System.Reflection.Assembly.GetExecutingAssembly(),
                typeof(AssemblyDescriptionAttribute));


            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "FrmLogin--->FrmLogin-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        #endregion
        #region 窗体事件逻辑
        
        
        
        
        
        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
            CommonUtility.Instance.KillProcesses("ICE.POS.Transfer");
            //base.Close();
        }
        
        
        
        
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbUserName.Text.Length == 0)
                {
                    MessageBox.Show("请输入用户名", Gattr.AppTitle);
                    return;
                }
                if (this.tbPwd.Text.Length == 0 )
                {
                    this.tbPwd.Focus();
                    MessageBox.Show("请输入密码", Gattr.AppTitle);
                    return;
                }
               
                _oper = Gattr.Bll.GetOperatorInfo(this.tbUserName.Text.Trim(), SecurityUtility.Instance.GetMD5Hash(this.tbPwd.Text.Trim()), Gattr.BranchNo);
                if (_oper != null)
                {
                    if (Gattr.Bll.SetOperatorLoginTime(_oper.oper_id, DateTime.Now) > 0)
                    {
                        Gattr.Oper_Pwd = _oper.oper_pwd;
                        this.iniSysInfo(true);
                        LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + this.tbUserName.Text+"登陆成功！", LogEnum.SysLog);
                    }
                }
                else
                {
                    this.tbUserName.Text = "";
                    this.tbPwd.Text = "";
                    this.tbUserName.Focus();
                    MessageBox.Show("用户名或密码错误", Gattr.AppTitle);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "FrmLogin--->btnOk_Click-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        
        
        
        
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Gfunc.InitPosSysSet();
            Gattr.Bll.dbOpen();

            this.label1.Text = "门店:" + Gattr.BranchName + "     版本号:" + Application.ProductVersion;
        }
        
        
        
        
        
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    if (this.tbUserName.Focused)
                    {
                        this.tbPwd.Focus();
                    }
                    return;
                case Keys.Back:
                    if (this.tbPwd.Focused)
                    {
                        if (this.tbPwd.Text.Length > 0)
                        {
                            this.tbPwd.Text = this.tbPwd.Text.Substring(0, this.tbPwd.Text.Length - 1);
                        }
                    }
                    else
                    {
                        if (this.tbUserName.Text.Length > 0)
                        {
                            this.tbUserName.Text = this.tbUserName.Text.Substring(0, this.tbUserName.Text.Length - 1);
                        }
                    }
                    return;
            }
        }
        
        
        
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                PictureBox panel = sender as PictureBox;
                if (panel != null)
                {
                    String tag = panel.Tag.ToString();
                    switch (tag)
                    {
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            SendKeys.Send(tag);
                            break;
                        case "back":
                            SendKeys.Send("{BACKSPACE}");
                            break;
                        case "reset":
                            if (this.tbUserName.Focused)
                            {
                                this.tbUserName.Text = string.Empty;
                            }
                            if (this.tbPwd.Focused)
                            {
                                this.tbPwd.Text = string.Empty;
                            }
                            break;
                        default: break;
                    }
                }
            }
        }
        #endregion
        #region 窗体私有方法
        private void iniSysInfo(bool isOnload)
        {
            try
            {
                Gfunc.InitEnvironment();
                if (isOnload)
                {
                    Gattr.OperId = _oper.oper_id;
                    Gattr.OperPwd = _oper.oper_pwd;
                    Gattr.CheckStandId = _oper.branch_id;
                    Gattr.OperFullName = _oper.full_name;
                    Gattr.Oper_flag = _oper.oper_flag;
                    Gattr.OperGrant = _oper.cash_grant;
                    Gattr.OperDiscount = _oper.discount_rate;
                    base.Visible = false;
                    this._loginParm = "";
                    this.FormMain = new FrmMain(this, this.frmStart);
                    this.FormMain.ShowDialog();
                }
                if ((this.LoginParm == "RETURN LOGIN"))
                {
                    this.LoginParm = "RL";
                    this.tbPwd.Text = string.Empty;
                    base.Visible = true;
                }
                tlpMain.BackgroundImage = ICE.POS.Properties.Resources.newlogin_bg;
                plLogin.BackgroundImage = ICE.POS.Properties.Resources.login_input1;
                Point[] points = new Point[12] { 
new Point(383, 284), new Point(311, 235), new Point(384, 235), new Point(456, 235), new Point(311, 186), 
new Point(383, 185), new Point(457, 186), new Point(310, 137), new Point(384, 136), new Point(456, 137), 
new Point(311, 284), new Point(457, 284) };
                PictureBox pb = null;


                for (int index = 0; index < points.Length; index++)
                {
                    pb = new PictureBox();
                    pb.Click += new EventHandler(pictureBox1_Click);
                    if (index <= 9)
                    {
                        pb.Tag = index;
                    }
                    else if (index == 10)
                    {
                        pb.Tag = "back";
                    }
                    else
                    {
                        pb.Tag = "reset";
                    }
                    pb.Location = points[index];
                    pb.Size = new Size(63, 39);
                    plLogin.Controls.Add(pb);
                }
                plLogin.Refresh();
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", ex.ToString(), LogEnum.ExceptionLog);
            }


        }
        #region 圆角文本框
        GraphicsPath GetRoundRectPath(RectangleF rect, float radius)
        {
            return GetRoundRectPath(rect.X, rect.Y, rect.Width, rect.Height, radius);
        }
        GraphicsPath GetRoundRectPath(float X, float Y, float width, float height, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(X + radius, Y, (X + width) - (radius * 2f), Y);
            path.AddArc((X + width) - (radius * 2f), Y, radius * 2f, radius * 2f, 270f, 90f);
            path.AddLine((float)(X + width), (float)(Y + radius), (float)(X + width), (float)((Y + height) - (radius * 2f)));
            path.AddArc((float)((X + width) - (radius * 2f)), (float)((Y + height) - (radius * 2f)), (float)(radius * 2f), (float)(radius * 2f), 0f, 90f);
            path.AddLine((float)((X + width) - (radius * 2f)), (float)(Y + height), (float)(X + radius), (float)(Y + height));
            path.AddArc(X, (Y + height) - (radius * 2f), radius * 2f, radius * 2f, 90f, 90f);
            path.AddLine(X, (Y + height) - (radius * 2f), X, Y + radius);
            path.AddArc(X, Y, radius * 2f, radius * 2f, 180f, 90f);
            path.CloseFigure();
            return path;
        }
        #endregion

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            int record = Gattr.Bll.GetNonUpdateFlow();
            if (record > 0)
            {
                IntPtr intPtr = WindowsAPIUtility.FindWindow(null, Gattr.AppTitle + "数据传输");
                if (intPtr != IntPtr.Zero)
                {
                    WindowsAPIUtility.ShowWindow(intPtr, 1u);
                    WindowsAPIUtility.SetForegroundWindow(intPtr);
                }
                if (MessageBox.Show("为确保数据能成功同步至服务器，请等待数据传输程序将数据传输完毕，\r\n或手动点击[即时处理]进行上传数据后再退出！\r\n\r\n                          确定要退出前台吗？ ", Gattr.AppTitle, MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            this.tbUserName.ImeMode = ImeMode.Close;
        }
    }
}
