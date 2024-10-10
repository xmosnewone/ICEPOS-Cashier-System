using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmMain
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        
        
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tNowTime = new System.Windows.Forms.Timer(this.components);
            this.timeCursor = new System.Windows.Forms.Timer(this.components);
            this.plOtherFunc = new ICE.POS.Common.PanelEx(this.components);
            this.lbxFunc = new System.Windows.Forms.ListBox();
            this.tblPanelBalance = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.GvPayFlow = new System.Windows.Forms.DataGridView();
            this.bindingPayFlow = new System.Windows.Forms.BindingSource(this.components);
            this.plPayListTilte = new ICE.POS.Common.PanelEx(this.components);
            this.plPayInfo = new ICE.POS.Common.PanelEx(this.components);
            this.gbPayInput = new System.Windows.Forms.GroupBox();
            this.plPayKey = new ICE.POS.Common.PanelEx(this.components);
            this.picPayNumEnter = new System.Windows.Forms.PictureBox();
            this.picPayNum3 = new System.Windows.Forms.PictureBox();
            this.btnSaleReset = new System.Windows.Forms.PictureBox();
            this.picPayNum6 = new System.Windows.Forms.PictureBox();
            this.picPayNum2 = new System.Windows.Forms.PictureBox();
            this.picPayNumBack = new System.Windows.Forms.PictureBox();
            this.picPayNum5 = new System.Windows.Forms.PictureBox();
            this.picPayNum1 = new System.Windows.Forms.PictureBox();
            this.picPayNum9 = new System.Windows.Forms.PictureBox();
            this.picPayNum4 = new System.Windows.Forms.PictureBox();
            this.picPayNum0 = new System.Windows.Forms.PictureBox();
            this.picPayNum8 = new System.Windows.Forms.PictureBox();
            this.picPayNumDot = new System.Windows.Forms.PictureBox();
            this.picPayNum7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plPayInput = new ICE.POS.Common.PanelEx(this.components);
            this.lbPayCursor = new System.Windows.Forms.Label();
            this.lbPayInput = new System.Windows.Forms.Label();
            this.gbPayInfo = new System.Windows.Forms.GroupBox();
            this.plPayLeft = new ICE.POS.Common.PanelEx(this.components);
            this.lbPayAmtChange = new System.Windows.Forms.Label();
            this.lbPayAmtPaid = new System.Windows.Forms.Label();
            this.lbPayAmtRec = new System.Windows.Forms.Label();
            this.lbPayTotalAmt = new System.Windows.Forms.Label();
            this.plPayTitle = new ICE.POS.Common.PanelEx(this.components);
            this.tblPayWay = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.btnPicFunWechat = new ICE.POS.Common.ButtonForPos();
            this.btnPicFuncPayEsc = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunRmb = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunCup = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunZfb = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunCou = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunPayOther = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunAllDis = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunAllcan = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunAzs = new ICE.POS.Common.ButtonForPos();
            this.btnPicFunAgz = new ICE.POS.Common.ButtonForPos();
            this.tlpMain = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.plButton = new ICE.POS.Common.PanelEx(this.components);
            this.tlpBottom = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.btnFastOther = new ICE.POS.Common.ButtonForPos();
            this.btnFastExit = new ICE.POS.Common.ButtonForPos();
            this.btnFastTot = new ICE.POS.Common.ButtonForPos();
            this.btnFastNum = new ICE.POS.Common.ButtonForPos();
            this.btnFastDel = new ICE.POS.Common.ButtonForPos();
            this.btnFastPrc = new ICE.POS.Common.ButtonForPos();
            this.btnFastDct = new ICE.POS.Common.ButtonForPos();
            this.btnFastPnr = new ICE.POS.Common.ButtonForPos();
            this.btnFastDou = new ICE.POS.Common.ButtonForPos();
            this.btnFastVip = new ICE.POS.Common.ButtonForPos();
            this.tlpCenter = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.tlpCenterRight = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.plItem = new ICE.POS.Common.PanelEx(this.components);
            this.plClsBig = new ICE.POS.Common.PanelEx(this.components);
            this.btnClsNextPage = new ICE.POS.Common.ButtonForPos();
            this.plClsSmall = new ICE.POS.Common.PanelEx(this.components);
            this.btnClsSmallLeft = new ICE.POS.Common.ButtonForPos();
            this.btnClsPriorPage = new ICE.POS.Common.ButtonForPos();
            this.btnClsSmallRight = new ICE.POS.Common.ButtonForPos();
            this.tlpSale = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.lbMessage = new System.Windows.Forms.Label();
            this.plSaleTitle = new ICE.POS.Common.PanelEx(this.components);
            this.GvSaleFlow = new System.Windows.Forms.DataGridView();
            this.bindingSaleFlow = new System.Windows.Forms.BindingSource(this.components);
            this.plSaleDown = new ICE.POS.Common.PanelEx(this.components);
            this.btnSaleDown = new ICE.POS.Common.ButtonForPos();
            this.btnSaleUp = new ICE.POS.Common.ButtonForPos();
            this.tlpMiddleRight = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.plQtyLeft = new ICE.POS.Common.PanelEx(this.components);
            this.plQtyRight = new ICE.POS.Common.PanelEx(this.components);
            this.plQtyCenter = new ICE.POS.Common.PanelEx(this.components);
            this.lbQntyTitle = new System.Windows.Forms.Label();
            this.lbQntyTotal = new System.Windows.Forms.Label();
            this.plAmtRight = new ICE.POS.Common.PanelEx(this.components);
            this.plAmtCenter = new ICE.POS.Common.PanelEx(this.components);
            this.lbAmtTitle = new System.Windows.Forms.Label();
            this.lbAmtTotal = new System.Windows.Forms.Label();
            this.plAmtLeft = new ICE.POS.Common.PanelEx(this.components);
            this.plTop = new ICE.POS.Common.PanelEx(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lbApplication = new System.Windows.Forms.Label();
            this.tlpMiddleLeft = new ICE.POS.Common.PanelEx(this.components);
            this.labelNetStatus = new System.Windows.Forms.Label();
            this.lbVip = new System.Windows.Forms.Label();
            this.lbShopAssistant = new System.Windows.Forms.Label();
            this.lbShopAssistantValue = new System.Windows.Forms.Label();
            this.lbVipValue = new System.Windows.Forms.Label();
            this.lbNowTime = new System.Windows.Forms.Label();
            this.lbCheckStandValue = new System.Windows.Forms.Label();
            this.lbCheckStand = new System.Windows.Forms.Label();
            this.plNumInput = new ICE.POS.Common.PanelEx(this.components);
            this.lbCursor = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.tblNum = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.btnSaleNum0 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNumEnter = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNumDot = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum8 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum1 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum9 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum3 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum7 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum2 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum4 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum5 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNum6 = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNumReset = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNumBack = new ICE.POS.Common.ButtonForPos();
            this.btnSaleNumDiv = new ICE.POS.Common.ButtonForPos();
            this.plOtherFunc.SuspendLayout();
            this.tblPanelBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvPayFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPayFlow)).BeginInit();
            this.plPayInfo.SuspendLayout();
            this.gbPayInput.SuspendLayout();
            this.plPayKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNumEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNumBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNumDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plPayInput.SuspendLayout();
            this.gbPayInfo.SuspendLayout();
            this.plPayLeft.SuspendLayout();
            this.plPayTitle.SuspendLayout();
            this.tblPayWay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunWechat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFuncPayEsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunRmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunCup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunZfb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunCou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunPayOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAllDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAllcan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAzs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAgz)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.plButton.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastTot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastPrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastDct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastPnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastDou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastVip)).BeginInit();
            this.tlpCenter.SuspendLayout();
            this.tlpCenterRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClsNextPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClsSmallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClsPriorPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClsSmallRight)).BeginInit();
            this.tlpSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvSaleFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSaleFlow)).BeginInit();
            this.plSaleDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleUp)).BeginInit();
            this.tlpMiddleRight.SuspendLayout();
            this.plQtyCenter.SuspendLayout();
            this.plAmtCenter.SuspendLayout();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpMiddleLeft.SuspendLayout();
            this.plNumInput.SuspendLayout();
            this.tblNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // tNowTime
            // 
            this.tNowTime.Enabled = true;
            this.tNowTime.Interval = 1000;
            this.tNowTime.Tick += new System.EventHandler(this.tNowTime_Tick);
            // 
            // timeCursor
            // 
            this.timeCursor.Enabled = true;
            this.timeCursor.Interval = 1000;
            this.timeCursor.Tick += new System.EventHandler(this.timeCursor_Tick);
            // 
            // plOtherFunc
            // 
            this.plOtherFunc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plOtherFunc.Controls.Add(this.lbxFunc);
            this.plOtherFunc.Location = new System.Drawing.Point(790, 10);
            this.plOtherFunc.Margin = new System.Windows.Forms.Padding(0);
            this.plOtherFunc.Name = "plOtherFunc";
            this.plOtherFunc.Padding = new System.Windows.Forms.Padding(5);
            this.plOtherFunc.Size = new System.Drawing.Size(134, 450);
            this.plOtherFunc.TabIndex = 28;
            this.plOtherFunc.Visible = false;
            // 
            // lbxFunc
            // 
            this.lbxFunc.BackColor = System.Drawing.SystemColors.Menu;
            this.lbxFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxFunc.Font = new System.Drawing.Font("宋体", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbxFunc.FormattingEnabled = true;
            this.lbxFunc.ItemHeight = 29;
            this.lbxFunc.Items.AddRange(new object[] {
            " 会员查询",
            " 商品查询",
            " 交易查询",
            " 修改支付",
            " 收银对账",
            " 库存查询",
            " 更改密码",
            " 数据下载",
            " 非 交 易",
            " 挂账回款",
            " 退    货",
            " 赠    送",
            " 要 货 单",
            " 收 货 单",
            " 微信活动",
            " 打印设置",
            " 切换键盘",
            " 操作手册",
            " 商品删除",
            " 提交反馈"});
            this.lbxFunc.Location = new System.Drawing.Point(5, 5);
            this.lbxFunc.Margin = new System.Windows.Forms.Padding(5);
            this.lbxFunc.Name = "lbxFunc";
            this.lbxFunc.Size = new System.Drawing.Size(124, 440);
            this.lbxFunc.TabIndex = 27;
            this.lbxFunc.Click += new System.EventHandler(this.ListFunc_Click);
            // 
            // tblPanelBalance
            // 
            this.tblPanelBalance.AutoSize = true;
            this.tblPanelBalance.BackColor = System.Drawing.Color.AliceBlue;
            this.tblPanelBalance.ColumnCount = 1;
            this.tblPanelBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelBalance.Controls.Add(this.GvPayFlow, 0, 3);
            this.tblPanelBalance.Controls.Add(this.plPayListTilte, 0, 2);
            this.tblPanelBalance.Controls.Add(this.plPayInfo, 0, 1);
            this.tblPanelBalance.Controls.Add(this.plPayTitle, 0, 0);
            this.tblPanelBalance.Location = new System.Drawing.Point(102, 56);
            this.tblPanelBalance.Margin = new System.Windows.Forms.Padding(2);
            this.tblPanelBalance.Name = "tblPanelBalance";
            this.tblPanelBalance.Padding = new System.Windows.Forms.Padding(4);
            this.tblPanelBalance.RowCount = 4;
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelBalance.Size = new System.Drawing.Size(686, 439);
            this.tblPanelBalance.TabIndex = 10;
            this.tblPanelBalance.Visible = false;
            // 
            // GvPayFlow
            // 
            this.GvPayFlow.AllowUserToAddRows = false;
            this.GvPayFlow.AllowUserToDeleteRows = false;
            this.GvPayFlow.AutoGenerateColumns = false;
            this.GvPayFlow.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GvPayFlow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvPayFlow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GvPayFlow.ColumnHeadersVisible = false;
            this.GvPayFlow.DataSource = this.bindingPayFlow;
            this.GvPayFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvPayFlow.Location = new System.Drawing.Point(5, 347);
            this.GvPayFlow.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.GvPayFlow.MultiSelect = false;
            this.GvPayFlow.Name = "GvPayFlow";
            this.GvPayFlow.ReadOnly = true;
            this.GvPayFlow.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GvPayFlow.RowTemplate.Height = 30;
            this.GvPayFlow.RowTemplate.ReadOnly = true;
            this.GvPayFlow.Size = new System.Drawing.Size(677, 88);
            this.GvPayFlow.TabIndex = 0;
            this.GvPayFlow.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GvPayFlow_DataError);
            // 
            // plPayListTilte
            // 
            this.plPayListTilte.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plPayListTilte.BackgroundImage = global::ICE.POS.Properties.Resources.pay_title;
            this.plPayListTilte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plPayListTilte.Location = new System.Drawing.Point(5, 321);
            this.plPayListTilte.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.plPayListTilte.Name = "plPayListTilte";
            this.plPayListTilte.Size = new System.Drawing.Size(677, 26);
            this.plPayListTilte.TabIndex = 2;
            // 
            // plPayInfo
            // 
            this.plPayInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.plPayInfo.Controls.Add(this.gbPayInput);
            this.plPayInfo.Controls.Add(this.gbPayInfo);
            this.plPayInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPayInfo.Location = new System.Drawing.Point(5, 74);
            this.plPayInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.plPayInfo.Name = "plPayInfo";
            this.plPayInfo.Size = new System.Drawing.Size(676, 247);
            this.plPayInfo.TabIndex = 3;
            // 
            // gbPayInput
            // 
            this.gbPayInput.Controls.Add(this.plPayKey);
            this.gbPayInput.Controls.Add(this.plPayInput);
            this.gbPayInput.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gbPayInput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbPayInput.Location = new System.Drawing.Point(310, 0);
            this.gbPayInput.Name = "gbPayInput";
            this.gbPayInput.Size = new System.Drawing.Size(336, 244);
            this.gbPayInput.TabIndex = 1;
            this.gbPayInput.TabStop = false;
            this.gbPayInput.Text = "金额输入";
            // 
            // plPayKey
            // 
            this.plPayKey.BackgroundImage = global::ICE.POS.Properties.Resources.touch_pay_key;
            this.plPayKey.Controls.Add(this.picPayNumEnter);
            this.plPayKey.Controls.Add(this.picPayNum3);
            this.plPayKey.Controls.Add(this.btnSaleReset);
            this.plPayKey.Controls.Add(this.picPayNum6);
            this.plPayKey.Controls.Add(this.picPayNum2);
            this.plPayKey.Controls.Add(this.picPayNumBack);
            this.plPayKey.Controls.Add(this.picPayNum5);
            this.plPayKey.Controls.Add(this.picPayNum1);
            this.plPayKey.Controls.Add(this.picPayNum9);
            this.plPayKey.Controls.Add(this.picPayNum4);
            this.plPayKey.Controls.Add(this.picPayNum0);
            this.plPayKey.Controls.Add(this.picPayNum8);
            this.plPayKey.Controls.Add(this.picPayNumDot);
            this.plPayKey.Controls.Add(this.picPayNum7);
            this.plPayKey.Controls.Add(this.pictureBox1);
            this.plPayKey.Location = new System.Drawing.Point(15, 75);
            this.plPayKey.Name = "plPayKey";
            this.plPayKey.Size = new System.Drawing.Size(308, 164);
            this.plPayKey.TabIndex = 3;
            // 
            // picPayNumEnter
            // 
            this.picPayNumEnter.BackColor = System.Drawing.Color.Transparent;
            this.picPayNumEnter.Location = new System.Drawing.Point(246, 108);
            this.picPayNumEnter.Name = "picPayNumEnter";
            this.picPayNumEnter.Size = new System.Drawing.Size(58, 48);
            this.picPayNumEnter.TabIndex = 0;
            this.picPayNumEnter.TabStop = false;
            this.picPayNumEnter.Tag = "Enter";
            this.picPayNumEnter.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum3
            // 
            this.picPayNum3.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum3.Location = new System.Drawing.Point(185, 108);
            this.picPayNum3.Name = "picPayNum3";
            this.picPayNum3.Size = new System.Drawing.Size(58, 48);
            this.picPayNum3.TabIndex = 0;
            this.picPayNum3.TabStop = false;
            this.picPayNum3.Tag = "3";
            this.picPayNum3.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnSaleReset
            // 
            this.btnSaleReset.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleReset.Location = new System.Drawing.Point(245, 57);
            this.btnSaleReset.Name = "btnSaleReset";
            this.btnSaleReset.Size = new System.Drawing.Size(58, 48);
            this.btnSaleReset.TabIndex = 0;
            this.btnSaleReset.TabStop = false;
            this.btnSaleReset.Tag = "reset";
            this.btnSaleReset.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum6
            // 
            this.picPayNum6.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum6.Location = new System.Drawing.Point(184, 57);
            this.picPayNum6.Name = "picPayNum6";
            this.picPayNum6.Size = new System.Drawing.Size(58, 48);
            this.picPayNum6.TabIndex = 0;
            this.picPayNum6.TabStop = false;
            this.picPayNum6.Tag = "6";
            this.picPayNum6.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum2
            // 
            this.picPayNum2.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum2.Location = new System.Drawing.Point(124, 108);
            this.picPayNum2.Name = "picPayNum2";
            this.picPayNum2.Size = new System.Drawing.Size(58, 48);
            this.picPayNum2.TabIndex = 0;
            this.picPayNum2.TabStop = false;
            this.picPayNum2.Tag = "2";
            this.picPayNum2.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNumBack
            // 
            this.picPayNumBack.BackColor = System.Drawing.Color.Transparent;
            this.picPayNumBack.Location = new System.Drawing.Point(245, 5);
            this.picPayNumBack.Name = "picPayNumBack";
            this.picPayNumBack.Size = new System.Drawing.Size(58, 48);
            this.picPayNumBack.TabIndex = 0;
            this.picPayNumBack.TabStop = false;
            this.picPayNumBack.Tag = "backspace";
            this.picPayNumBack.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum5
            // 
            this.picPayNum5.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum5.Location = new System.Drawing.Point(123, 57);
            this.picPayNum5.Name = "picPayNum5";
            this.picPayNum5.Size = new System.Drawing.Size(58, 48);
            this.picPayNum5.TabIndex = 0;
            this.picPayNum5.TabStop = false;
            this.picPayNum5.Tag = "5";
            this.picPayNum5.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum1
            // 
            this.picPayNum1.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum1.Location = new System.Drawing.Point(63, 108);
            this.picPayNum1.Name = "picPayNum1";
            this.picPayNum1.Size = new System.Drawing.Size(58, 48);
            this.picPayNum1.TabIndex = 0;
            this.picPayNum1.TabStop = false;
            this.picPayNum1.Tag = "1";
            this.picPayNum1.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum9
            // 
            this.picPayNum9.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum9.Location = new System.Drawing.Point(184, 5);
            this.picPayNum9.Name = "picPayNum9";
            this.picPayNum9.Size = new System.Drawing.Size(58, 48);
            this.picPayNum9.TabIndex = 0;
            this.picPayNum9.TabStop = false;
            this.picPayNum9.Tag = "9";
            this.picPayNum9.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum4
            // 
            this.picPayNum4.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum4.Location = new System.Drawing.Point(62, 57);
            this.picPayNum4.Name = "picPayNum4";
            this.picPayNum4.Size = new System.Drawing.Size(58, 48);
            this.picPayNum4.TabIndex = 0;
            this.picPayNum4.TabStop = false;
            this.picPayNum4.Tag = "4";
            this.picPayNum4.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum0
            // 
            this.picPayNum0.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum0.Location = new System.Drawing.Point(3, 108);
            this.picPayNum0.Name = "picPayNum0";
            this.picPayNum0.Size = new System.Drawing.Size(58, 48);
            this.picPayNum0.TabIndex = 0;
            this.picPayNum0.TabStop = false;
            this.picPayNum0.Tag = "0";
            this.picPayNum0.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum8
            // 
            this.picPayNum8.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum8.Location = new System.Drawing.Point(123, 5);
            this.picPayNum8.Name = "picPayNum8";
            this.picPayNum8.Size = new System.Drawing.Size(58, 48);
            this.picPayNum8.TabIndex = 0;
            this.picPayNum8.TabStop = false;
            this.picPayNum8.Tag = "8";
            this.picPayNum8.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNumDot
            // 
            this.picPayNumDot.BackColor = System.Drawing.Color.Transparent;
            this.picPayNumDot.Location = new System.Drawing.Point(2, 57);
            this.picPayNumDot.Name = "picPayNumDot";
            this.picPayNumDot.Size = new System.Drawing.Size(58, 48);
            this.picPayNumDot.TabIndex = 0;
            this.picPayNumDot.TabStop = false;
            this.picPayNumDot.Tag = "dot";
            this.picPayNumDot.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // picPayNum7
            // 
            this.picPayNum7.BackColor = System.Drawing.Color.Transparent;
            this.picPayNum7.Location = new System.Drawing.Point(62, 5);
            this.picPayNum7.Name = "picPayNum7";
            this.picPayNum7.Size = new System.Drawing.Size(58, 48);
            this.picPayNum7.TabIndex = 0;
            this.picPayNum7.TabStop = false;
            this.picPayNum7.Tag = "7";
            this.picPayNum7.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "-";
            this.pictureBox1.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // plPayInput
            // 
            this.plPayInput.BackgroundImage = global::ICE.POS.Properties.Resources.pay_input;
            this.plPayInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plPayInput.Controls.Add(this.lbPayCursor);
            this.plPayInput.Controls.Add(this.lbPayInput);
            this.plPayInput.Location = new System.Drawing.Point(15, 24);
            this.plPayInput.Name = "plPayInput";
            this.plPayInput.Size = new System.Drawing.Size(306, 50);
            this.plPayInput.TabIndex = 0;
            // 
            // lbPayCursor
            // 
            this.lbPayCursor.BackColor = System.Drawing.Color.Black;
            this.lbPayCursor.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayCursor.Location = new System.Drawing.Point(131, 10);
            this.lbPayCursor.Name = "lbPayCursor";
            this.lbPayCursor.Size = new System.Drawing.Size(2, 30);
            this.lbPayCursor.TabIndex = 10;
            this.lbPayCursor.Text = "12312313";
            // 
            // lbPayInput
            // 
            this.lbPayInput.BackColor = System.Drawing.Color.Transparent;
            this.lbPayInput.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayInput.Location = new System.Drawing.Point(7, 5);
            this.lbPayInput.Margin = new System.Windows.Forms.Padding(0, 0, 4, 3);
            this.lbPayInput.Name = "lbPayInput";
            this.lbPayInput.Size = new System.Drawing.Size(270, 40);
            this.lbPayInput.TabIndex = 9;
            this.lbPayInput.Text = "1234567890123";
            this.lbPayInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPayInfo
            // 
            this.gbPayInfo.Controls.Add(this.plPayLeft);
            this.gbPayInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbPayInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbPayInfo.Location = new System.Drawing.Point(3, 1);
            this.gbPayInfo.Name = "gbPayInfo";
            this.gbPayInfo.Size = new System.Drawing.Size(300, 243);
            this.gbPayInfo.TabIndex = 0;
            this.gbPayInfo.TabStop = false;
            this.gbPayInfo.Text = "付款信息";
            // 
            // plPayLeft
            // 
            this.plPayLeft.BackgroundImage = global::ICE.POS.Properties.Resources.touch_pay_info;
            this.plPayLeft.Controls.Add(this.lbPayAmtChange);
            this.plPayLeft.Controls.Add(this.lbPayAmtPaid);
            this.plPayLeft.Controls.Add(this.lbPayAmtRec);
            this.plPayLeft.Controls.Add(this.lbPayTotalAmt);
            this.plPayLeft.Location = new System.Drawing.Point(8, 23);
            this.plPayLeft.Name = "plPayLeft";
            this.plPayLeft.Size = new System.Drawing.Size(276, 214);
            this.plPayLeft.TabIndex = 0;
            // 
            // lbPayAmtChange
            // 
            this.lbPayAmtChange.BackColor = System.Drawing.Color.Transparent;
            this.lbPayAmtChange.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmtChange.Location = new System.Drawing.Point(87, 171);
            this.lbPayAmtChange.Name = "lbPayAmtChange";
            this.lbPayAmtChange.Size = new System.Drawing.Size(176, 33);
            this.lbPayAmtChange.TabIndex = 0;
            this.lbPayAmtChange.Text = "0.00";
            this.lbPayAmtChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPayAmtPaid
            // 
            this.lbPayAmtPaid.BackColor = System.Drawing.Color.Transparent;
            this.lbPayAmtPaid.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmtPaid.Location = new System.Drawing.Point(87, 118);
            this.lbPayAmtPaid.Name = "lbPayAmtPaid";
            this.lbPayAmtPaid.Size = new System.Drawing.Size(176, 33);
            this.lbPayAmtPaid.TabIndex = 0;
            this.lbPayAmtPaid.Text = "0.00";
            this.lbPayAmtPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPayAmtRec
            // 
            this.lbPayAmtRec.BackColor = System.Drawing.Color.Transparent;
            this.lbPayAmtRec.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmtRec.Location = new System.Drawing.Point(87, 64);
            this.lbPayAmtRec.Name = "lbPayAmtRec";
            this.lbPayAmtRec.Size = new System.Drawing.Size(176, 33);
            this.lbPayAmtRec.TabIndex = 0;
            this.lbPayAmtRec.Text = "0.00";
            this.lbPayAmtRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPayTotalAmt
            // 
            this.lbPayTotalAmt.BackColor = System.Drawing.Color.Transparent;
            this.lbPayTotalAmt.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayTotalAmt.Location = new System.Drawing.Point(87, 9);
            this.lbPayTotalAmt.Name = "lbPayTotalAmt";
            this.lbPayTotalAmt.Size = new System.Drawing.Size(176, 33);
            this.lbPayTotalAmt.TabIndex = 0;
            this.lbPayTotalAmt.Text = "0.00";
            this.lbPayTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plPayTitle
            // 
            this.plPayTitle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.plPayTitle.Controls.Add(this.tblPayWay);
            this.plPayTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPayTitle.Location = new System.Drawing.Point(4, 4);
            this.plPayTitle.Margin = new System.Windows.Forms.Padding(0);
            this.plPayTitle.Name = "plPayTitle";
            this.plPayTitle.Size = new System.Drawing.Size(678, 69);
            this.plPayTitle.TabIndex = 4;
            // 
            // tblPayWay
            // 
            this.tblPayWay.BackColor = System.Drawing.Color.Transparent;
            this.tblPayWay.ColumnCount = 11;
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblPayWay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblPayWay.Controls.Add(this.btnPicFunWechat, 3, 0);
            this.tblPayWay.Controls.Add(this.btnPicFuncPayEsc, 9, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunRmb, 0, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunCup, 1, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunZfb, 2, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunCou, 4, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunPayOther, 5, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunAllDis, 5, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunAllcan, 8, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunAzs, 6, 0);
            this.tblPayWay.Controls.Add(this.btnPicFunAgz, 7, 0);
            this.tblPayWay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPayWay.Location = new System.Drawing.Point(0, 0);
            this.tblPayWay.Margin = new System.Windows.Forms.Padding(0);
            this.tblPayWay.Name = "tblPayWay";
            this.tblPayWay.RowCount = 1;
            this.tblPayWay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPayWay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPayWay.Size = new System.Drawing.Size(678, 69);
            this.tblPayWay.TabIndex = 1;
            // 
            // btnPicFunWechat
            // 
            this.btnPicFunWechat.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunWechat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunWechat.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunWechat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunWechat.IsGrass = false;
            this.btnPicFunWechat.IsItem = false;
            this.btnPicFunWechat.Location = new System.Drawing.Point(186, 0);
            this.btnPicFunWechat.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunWechat.MyText = "微信支付";
            this.btnPicFunWechat.MyUpText = "v";
            this.btnPicFunWechat.Name = "btnPicFunWechat";
            this.btnPicFunWechat.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunWechat.TabIndex = 7;
            this.btnPicFunWechat.TabStop = false;
            this.btnPicFunWechat.Tag = "wechat";
            this.btnPicFunWechat.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFuncPayEsc
            // 
            this.btnPicFuncPayEsc.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFuncPayEsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFuncPayEsc.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFuncPayEsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFuncPayEsc.IsGrass = false;
            this.btnPicFuncPayEsc.IsItem = false;
            this.btnPicFuncPayEsc.Location = new System.Drawing.Point(620, 0);
            this.btnPicFuncPayEsc.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFuncPayEsc.MyText = "退出";
            this.btnPicFuncPayEsc.MyUpText = "Esc";
            this.btnPicFuncPayEsc.Name = "btnPicFuncPayEsc";
            this.btnPicFuncPayEsc.Size = new System.Drawing.Size(58, 69);
            this.btnPicFuncPayEsc.TabIndex = 4;
            this.btnPicFuncPayEsc.TabStop = false;
            this.btnPicFuncPayEsc.Tag = "payesc";
            this.btnPicFuncPayEsc.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunRmb
            // 
            this.btnPicFunRmb.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunRmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunRmb.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunRmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunRmb.IsGrass = false;
            this.btnPicFunRmb.IsItem = false;
            this.btnPicFunRmb.Location = new System.Drawing.Point(0, 0);
            this.btnPicFunRmb.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunRmb.MyText = "现金";
            this.btnPicFunRmb.MyUpText = "-";
            this.btnPicFunRmb.Name = "btnPicFunRmb";
            this.btnPicFunRmb.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunRmb.TabIndex = 0;
            this.btnPicFunRmb.TabStop = false;
            this.btnPicFunRmb.Tag = "rmb";
            this.btnPicFunRmb.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunCup
            // 
            this.btnPicFunCup.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunCup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunCup.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunCup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunCup.IsGrass = false;
            this.btnPicFunCup.IsItem = false;
            this.btnPicFunCup.Location = new System.Drawing.Point(62, 0);
            this.btnPicFunCup.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunCup.MyText = "优惠券";
            this.btnPicFunCup.MyUpText = "i";
            this.btnPicFunCup.Name = "btnPicFunCup";
            this.btnPicFunCup.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunCup.TabIndex = 0;
            this.btnPicFunCup.TabStop = false;
            this.btnPicFunCup.Tag = "coupon";
            this.btnPicFunCup.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunZfb
            // 
            this.btnPicFunZfb.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunZfb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunZfb.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunZfb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunZfb.IsGrass = false;
            this.btnPicFunZfb.IsItem = false;
            this.btnPicFunZfb.Location = new System.Drawing.Point(124, 0);
            this.btnPicFunZfb.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunZfb.MyText = "支付宝";
            this.btnPicFunZfb.MyUpText = "f";
            this.btnPicFunZfb.Name = "btnPicFunZfb";
            this.btnPicFunZfb.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunZfb.TabIndex = 0;
            this.btnPicFunZfb.TabStop = false;
            this.btnPicFunZfb.Tag = "zfb";
            this.btnPicFunZfb.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunCou
            // 
            this.btnPicFunCou.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunCou.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunCou.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunCou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunCou.IsGrass = false;
            this.btnPicFunCou.IsItem = false;
            this.btnPicFunCou.Location = new System.Drawing.Point(248, 0);
            this.btnPicFunCou.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunCou.MyText = "余额支付";
            this.btnPicFunCou.MyUpText = "=";
            this.btnPicFunCou.Name = "btnPicFunCou";
            this.btnPicFunCou.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunCou.TabIndex = 0;
            this.btnPicFunCou.TabStop = false;
            this.btnPicFunCou.Tag = "yezf";
            this.btnPicFunCou.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunPayOther
            // 
            this.btnPicFunPayOther.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunPayOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunPayOther.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunPayOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunPayOther.IsGrass = false;
            this.btnPicFunPayOther.IsItem = false;
            this.btnPicFunPayOther.Location = new System.Drawing.Point(310, 0);
            this.btnPicFunPayOther.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunPayOther.MyText = "其他方式";
            this.btnPicFunPayOther.MyUpText = ",";
            this.btnPicFunPayOther.Name = "btnPicFunPayOther";
            this.btnPicFunPayOther.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunPayOther.TabIndex = 0;
            this.btnPicFunPayOther.TabStop = false;
            this.btnPicFunPayOther.Tag = "payother";
            this.btnPicFunPayOther.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunAllDis
            // 
            this.btnPicFunAllDis.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunAllDis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunAllDis.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunAllDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunAllDis.IsGrass = false;
            this.btnPicFunAllDis.IsItem = false;
            this.btnPicFunAllDis.Location = new System.Drawing.Point(372, 0);
            this.btnPicFunAllDis.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunAllDis.MyText = "整单折扣";
            this.btnPicFunAllDis.MyUpText = "j";
            this.btnPicFunAllDis.Name = "btnPicFunAllDis";
            this.btnPicFunAllDis.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunAllDis.TabIndex = 0;
            this.btnPicFunAllDis.TabStop = false;
            this.btnPicFunAllDis.Tag = "ads";
            this.btnPicFunAllDis.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunAllcan
            // 
            this.btnPicFunAllcan.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunAllcan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunAllcan.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunAllcan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunAllcan.IsGrass = false;
            this.btnPicFunAllcan.IsItem = false;
            this.btnPicFunAllcan.Location = new System.Drawing.Point(558, 0);
            this.btnPicFunAllcan.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunAllcan.MyText = "整单取消";
            this.btnPicFunAllcan.MyUpText = "e";
            this.btnPicFunAllcan.Name = "btnPicFunAllcan";
            this.btnPicFunAllcan.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunAllcan.TabIndex = 0;
            this.btnPicFunAllcan.TabStop = false;
            this.btnPicFunAllcan.Tag = "aca";
            this.btnPicFunAllcan.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunAzs
            // 
            this.btnPicFunAzs.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunAzs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunAzs.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunAzs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunAzs.IsGrass = false;
            this.btnPicFunAzs.IsItem = false;
            this.btnPicFunAzs.Location = new System.Drawing.Point(434, 0);
            this.btnPicFunAzs.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunAzs.MyText = "整单赠送";
            this.btnPicFunAzs.MyUpText = "q";
            this.btnPicFunAzs.Name = "btnPicFunAzs";
            this.btnPicFunAzs.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunAzs.TabIndex = 5;
            this.btnPicFunAzs.TabStop = false;
            this.btnPicFunAzs.Tag = "azs";
            this.btnPicFunAzs.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // btnPicFunAgz
            // 
            this.btnPicFunAgz.BackColor = System.Drawing.Color.Transparent;
            this.btnPicFunAgz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPicFunAgz.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnPicFunAgz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPicFunAgz.IsGrass = false;
            this.btnPicFunAgz.IsItem = false;
            this.btnPicFunAgz.Location = new System.Drawing.Point(496, 0);
            this.btnPicFunAgz.Margin = new System.Windows.Forms.Padding(0);
            this.btnPicFunAgz.MyText = "挂账";
            this.btnPicFunAgz.MyUpText = "g";
            this.btnPicFunAgz.Name = "btnPicFunAgz";
            this.btnPicFunAgz.Size = new System.Drawing.Size(62, 69);
            this.btnPicFunAgz.TabIndex = 6;
            this.btnPicFunAgz.TabStop = false;
            this.btnPicFunAgz.Tag = "agz";
            this.btnPicFunAgz.Click += new System.EventHandler(this.picPayNum_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.plButton, 0, 3);
            this.tlpMain.Controls.Add(this.tlpCenter, 0, 2);
            this.tlpMain.Controls.Add(this.tlpMiddleRight, 1, 1);
            this.tlpMain.Controls.Add(this.plTop, 0, 0);
            this.tlpMain.Controls.Add(this.tlpMiddleLeft, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(796, 574);
            this.tlpMain.TabIndex = 7;
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.LightGreen;
            this.tlpMain.SetColumnSpan(this.plButton, 2);
            this.plButton.Controls.Add(this.tlpBottom);
            this.plButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plButton.Location = new System.Drawing.Point(0, 494);
            this.plButton.Margin = new System.Windows.Forms.Padding(0);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(796, 80);
            this.plButton.TabIndex = 8;
            // 
            // tlpBottom
            // 
            this.tlpBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tlpBottom.ColumnCount = 10;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBottom.Controls.Add(this.btnFastOther, 8, 0);
            this.tlpBottom.Controls.Add(this.btnFastExit, 9, 0);
            this.tlpBottom.Controls.Add(this.btnFastTot, 7, 0);
            this.tlpBottom.Controls.Add(this.btnFastNum, 0, 0);
            this.tlpBottom.Controls.Add(this.btnFastDel, 1, 0);
            this.tlpBottom.Controls.Add(this.btnFastPrc, 2, 0);
            this.tlpBottom.Controls.Add(this.btnFastDct, 3, 0);
            this.tlpBottom.Controls.Add(this.btnFastPnr, 4, 0);
            this.tlpBottom.Controls.Add(this.btnFastDou, 6, 0);
            this.tlpBottom.Controls.Add(this.btnFastVip, 5, 0);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpBottom.Margin = new System.Windows.Forms.Padding(5);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 2;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBottom.Size = new System.Drawing.Size(796, 80);
            this.tlpBottom.TabIndex = 1;
            // 
            // btnFastOther
            // 
            this.btnFastOther.BackColor = System.Drawing.Color.Transparent;
            this.btnFastOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastOther.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastOther.IsGrass = false;
            this.btnFastOther.IsItem = false;
            this.btnFastOther.Location = new System.Drawing.Point(634, 5);
            this.btnFastOther.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastOther.MyText = "其它";
            this.btnFastOther.Name = "btnFastOther";
            this.btnFastOther.Size = new System.Drawing.Size(75, 65);
            this.btnFastOther.TabIndex = 6;
            this.btnFastOther.TabStop = false;
            this.btnFastOther.Tag = "oth";
            this.btnFastOther.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastExit
            // 
            this.btnFastExit.BackColor = System.Drawing.Color.Transparent;
            this.btnFastExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastExit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastExit.IsGrass = false;
            this.btnFastExit.IsItem = false;
            this.btnFastExit.Location = new System.Drawing.Point(713, 5);
            this.btnFastExit.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastExit.MyText = "退出";
            this.btnFastExit.Name = "btnFastExit";
            this.btnFastExit.Size = new System.Drawing.Size(81, 65);
            this.btnFastExit.TabIndex = 0;
            this.btnFastExit.TabStop = false;
            this.btnFastExit.Tag = "exit";
            this.btnFastExit.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastTot
            // 
            this.btnFastTot.BackColor = System.Drawing.Color.Transparent;
            this.btnFastTot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastTot.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastTot.IsGrass = false;
            this.btnFastTot.IsItem = false;
            this.btnFastTot.Location = new System.Drawing.Point(555, 5);
            this.btnFastTot.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastTot.MyText = "结算";
            this.btnFastTot.Name = "btnFastTot";
            this.btnFastTot.Size = new System.Drawing.Size(75, 65);
            this.btnFastTot.TabIndex = 25;
            this.btnFastTot.TabStop = false;
            this.btnFastTot.Tag = "tot";
            this.btnFastTot.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastNum
            // 
            this.btnFastNum.BackColor = System.Drawing.Color.Transparent;
            this.btnFastNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastNum.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastNum.IsGrass = false;
            this.btnFastNum.IsItem = false;
            this.btnFastNum.Location = new System.Drawing.Point(2, 5);
            this.btnFastNum.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastNum.MyText = "数量";
            this.btnFastNum.Name = "btnFastNum";
            this.btnFastNum.Size = new System.Drawing.Size(75, 65);
            this.btnFastNum.TabIndex = 3;
            this.btnFastNum.TabStop = false;
            this.btnFastNum.Tag = "num";
            this.btnFastNum.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastDel
            // 
            this.btnFastDel.BackColor = System.Drawing.Color.Transparent;
            this.btnFastDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastDel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastDel.IsGrass = false;
            this.btnFastDel.IsItem = false;
            this.btnFastDel.Location = new System.Drawing.Point(81, 5);
            this.btnFastDel.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastDel.MyText = "删除";
            this.btnFastDel.Name = "btnFastDel";
            this.btnFastDel.Size = new System.Drawing.Size(75, 65);
            this.btnFastDel.TabIndex = 4;
            this.btnFastDel.TabStop = false;
            this.btnFastDel.Tag = "can";
            this.btnFastDel.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastPrc
            // 
            this.btnFastPrc.BackColor = System.Drawing.Color.Transparent;
            this.btnFastPrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastPrc.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastPrc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastPrc.IsGrass = false;
            this.btnFastPrc.IsItem = false;
            this.btnFastPrc.Location = new System.Drawing.Point(160, 5);
            this.btnFastPrc.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastPrc.MyText = "单价";
            this.btnFastPrc.Name = "btnFastPrc";
            this.btnFastPrc.Size = new System.Drawing.Size(75, 65);
            this.btnFastPrc.TabIndex = 1;
            this.btnFastPrc.TabStop = false;
            this.btnFastPrc.Tag = "prc";
            this.btnFastPrc.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastDct
            // 
            this.btnFastDct.BackColor = System.Drawing.Color.Transparent;
            this.btnFastDct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastDct.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastDct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastDct.IsGrass = false;
            this.btnFastDct.IsItem = false;
            this.btnFastDct.Location = new System.Drawing.Point(239, 5);
            this.btnFastDct.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastDct.MyText = "折扣";
            this.btnFastDct.Name = "btnFastDct";
            this.btnFastDct.Size = new System.Drawing.Size(75, 65);
            this.btnFastDct.TabIndex = 2;
            this.btnFastDct.TabStop = false;
            this.btnFastDct.Tag = "dct";
            this.btnFastDct.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastPnr
            // 
            this.btnFastPnr.BackColor = System.Drawing.Color.Transparent;
            this.btnFastPnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastPnr.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastPnr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastPnr.IsGrass = false;
            this.btnFastPnr.IsItem = false;
            this.btnFastPnr.Location = new System.Drawing.Point(318, 5);
            this.btnFastPnr.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastPnr.MyText = "挂单";
            this.btnFastPnr.Name = "btnFastPnr";
            this.btnFastPnr.Size = new System.Drawing.Size(75, 65);
            this.btnFastPnr.TabIndex = 10;
            this.btnFastPnr.TabStop = false;
            this.btnFastPnr.Tag = "gdj";
            this.btnFastPnr.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastDou
            // 
            this.btnFastDou.BackColor = System.Drawing.Color.Transparent;
            this.btnFastDou.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastDou.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastDou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastDou.IsGrass = false;
            this.btnFastDou.IsItem = false;
            this.btnFastDou.Location = new System.Drawing.Point(476, 5);
            this.btnFastDou.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastDou.MyText = "收银员";
            this.btnFastDou.Name = "btnFastDou";
            this.btnFastDou.Size = new System.Drawing.Size(75, 65);
            this.btnFastDou.TabIndex = 21;
            this.btnFastDou.TabStop = false;
            this.btnFastDou.Tag = "dou";
            this.btnFastDou.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // btnFastVip
            // 
            this.btnFastVip.BackColor = System.Drawing.Color.Transparent;
            this.btnFastVip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFastVip.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnFastVip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnFastVip.IsGrass = false;
            this.btnFastVip.IsItem = false;
            this.btnFastVip.Location = new System.Drawing.Point(397, 5);
            this.btnFastVip.Margin = new System.Windows.Forms.Padding(2, 5, 2, 10);
            this.btnFastVip.MyText = "会员";
            this.btnFastVip.Name = "btnFastVip";
            this.btnFastVip.Size = new System.Drawing.Size(75, 65);
            this.btnFastVip.TabIndex = 23;
            this.btnFastVip.TabStop = false;
            this.btnFastVip.Tag = "vip";
            this.btnFastVip.Click += new System.EventHandler(this.btnSaleFunc_Click);
            // 
            // tlpCenter
            // 
            this.tlpCenter.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpCenter, 2);
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenter.Controls.Add(this.tlpCenterRight, 0, 0);
            this.tlpCenter.Controls.Add(this.tlpSale, 0, 0);
            this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenter.Location = new System.Drawing.Point(0, 150);
            this.tlpCenter.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCenter.Name = "tlpCenter";
            this.tlpCenter.RowCount = 1;
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenter.Size = new System.Drawing.Size(796, 344);
            this.tlpCenter.TabIndex = 3;
            // 
            // tlpCenterRight
            // 
            this.tlpCenterRight.ColumnCount = 4;
            this.tlpCenterRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCenterRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenterRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpCenterRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCenterRight.Controls.Add(this.plItem, 0, 1);
            this.tlpCenterRight.Controls.Add(this.plClsBig, 2, 2);
            this.tlpCenterRight.Controls.Add(this.btnClsNextPage, 2, 3);
            this.tlpCenterRight.Controls.Add(this.plClsSmall, 1, 0);
            this.tlpCenterRight.Controls.Add(this.btnClsSmallLeft, 0, 0);
            this.tlpCenterRight.Controls.Add(this.btnClsPriorPage, 2, 1);
            this.tlpCenterRight.Controls.Add(this.btnClsSmallRight, 3, 0);
            this.tlpCenterRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenterRight.Location = new System.Drawing.Point(400, 0);
            this.tlpCenterRight.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tlpCenterRight.Name = "tlpCenterRight";
            this.tlpCenterRight.RowCount = 4;
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenterRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCenterRight.Size = new System.Drawing.Size(393, 344);
            this.tlpCenterRight.TabIndex = 2;
            // 
            // plItem
            // 
            this.plItem.BackColor = System.Drawing.Color.Silver;
            this.tlpCenterRight.SetColumnSpan(this.plItem, 2);
            this.plItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plItem.Location = new System.Drawing.Point(0, 80);
            this.plItem.Margin = new System.Windows.Forms.Padding(0);
            this.plItem.Name = "plItem";
            this.tlpCenterRight.SetRowSpan(this.plItem, 3);
            this.plItem.Size = new System.Drawing.Size(305, 264);
            this.plItem.TabIndex = 10;
            // 
            // plClsBig
            // 
            this.plClsBig.BackColor = System.Drawing.Color.LightGray;
            this.tlpCenterRight.SetColumnSpan(this.plClsBig, 2);
            this.plClsBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plClsBig.Location = new System.Drawing.Point(305, 130);
            this.plClsBig.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.plClsBig.Name = "plClsBig";
            this.plClsBig.Size = new System.Drawing.Size(86, 164);
            this.plClsBig.TabIndex = 3;
            // 
            // btnClsNextPage
            // 
            this.btnClsNextPage.BackColor = System.Drawing.Color.Transparent;
            this.tlpCenterRight.SetColumnSpan(this.btnClsNextPage, 2);
            this.btnClsNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClsNextPage.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnClsNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClsNextPage.IsGrass = false;
            this.btnClsNextPage.IsItem = false;
            this.btnClsNextPage.Location = new System.Drawing.Point(305, 294);
            this.btnClsNextPage.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnClsNextPage.MyText = "∨";
            this.btnClsNextPage.Name = "btnClsNextPage";
            this.btnClsNextPage.Size = new System.Drawing.Size(86, 50);
            this.btnClsNextPage.TabIndex = 4;
            this.btnClsNextPage.TabStop = false;
            this.btnClsNextPage.Tag = "BigCls&NextPage";
            this.btnClsNextPage.Click += new System.EventHandler(this.btnTouchScreenForBigCls_Click);
            // 
            // plClsSmall
            // 
            this.plClsSmall.BackColor = System.Drawing.Color.LightGray;
            this.tlpCenterRight.SetColumnSpan(this.plClsSmall, 2);
            this.plClsSmall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plClsSmall.Location = new System.Drawing.Point(50, 0);
            this.plClsSmall.Margin = new System.Windows.Forms.Padding(0);
            this.plClsSmall.Name = "plClsSmall";
            this.plClsSmall.Size = new System.Drawing.Size(293, 80);
            this.plClsSmall.TabIndex = 6;
            // 
            // btnClsSmallLeft
            // 
            this.btnClsSmallLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnClsSmallLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClsSmallLeft.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnClsSmallLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClsSmallLeft.IsGrass = false;
            this.btnClsSmallLeft.IsItem = false;
            this.btnClsSmallLeft.Location = new System.Drawing.Point(3, 3);
            this.btnClsSmallLeft.MyText = "<";
            this.btnClsSmallLeft.Name = "btnClsSmallLeft";
            this.btnClsSmallLeft.Size = new System.Drawing.Size(44, 74);
            this.btnClsSmallLeft.TabIndex = 7;
            this.btnClsSmallLeft.TabStop = false;
            this.btnClsSmallLeft.Tag = "SmallCls&PriorPage";
            this.btnClsSmallLeft.Click += new System.EventHandler(this.btnTouchScreenForSmallCls_Click);
            // 
            // btnClsPriorPage
            // 
            this.btnClsPriorPage.BackColor = System.Drawing.Color.Transparent;
            this.tlpCenterRight.SetColumnSpan(this.btnClsPriorPage, 2);
            this.btnClsPriorPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClsPriorPage.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnClsPriorPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClsPriorPage.IsGrass = false;
            this.btnClsPriorPage.IsItem = false;
            this.btnClsPriorPage.Location = new System.Drawing.Point(305, 80);
            this.btnClsPriorPage.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.btnClsPriorPage.MyText = "∧";
            this.btnClsPriorPage.Name = "btnClsPriorPage";
            this.btnClsPriorPage.Size = new System.Drawing.Size(86, 50);
            this.btnClsPriorPage.TabIndex = 9;
            this.btnClsPriorPage.TabStop = false;
            this.btnClsPriorPage.Tag = "BigCls&PriorPage";
            this.btnClsPriorPage.Click += new System.EventHandler(this.btnTouchScreenForBigCls_Click);
            // 
            // btnClsSmallRight
            // 
            this.btnClsSmallRight.BackColor = System.Drawing.Color.Transparent;
            this.btnClsSmallRight.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.btnClsSmallRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClsSmallRight.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnClsSmallRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClsSmallRight.IsGrass = false;
            this.btnClsSmallRight.IsItem = false;
            this.btnClsSmallRight.Location = new System.Drawing.Point(346, 3);
            this.btnClsSmallRight.MyText = ">";
            this.btnClsSmallRight.Name = "btnClsSmallRight";
            this.btnClsSmallRight.Size = new System.Drawing.Size(44, 74);
            this.btnClsSmallRight.TabIndex = 8;
            this.btnClsSmallRight.TabStop = false;
            this.btnClsSmallRight.Tag = "SmallCls&NextPage";
            this.btnClsSmallRight.Click += new System.EventHandler(this.btnTouchScreenForSmallCls_Click);
            // 
            // tlpSale
            // 
            this.tlpSale.BackColor = System.Drawing.Color.Gray;
            this.tlpSale.ColumnCount = 1;
            this.tlpSale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSale.Controls.Add(this.lbMessage, 0, 3);
            this.tlpSale.Controls.Add(this.plSaleTitle, 0, 0);
            this.tlpSale.Controls.Add(this.GvSaleFlow, 0, 1);
            this.tlpSale.Controls.Add(this.plSaleDown, 0, 2);
            this.tlpSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSale.Location = new System.Drawing.Point(0, 0);
            this.tlpSale.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSale.Name = "tlpSale";
            this.tlpSale.RowCount = 4;
            this.tlpSale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpSale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSale.Size = new System.Drawing.Size(400, 344);
            this.tlpSale.TabIndex = 0;
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMessage.Location = new System.Drawing.Point(0, 304);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(400, 40);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Messages";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plSaleTitle
            // 
            this.plSaleTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.plSaleTitle.BackgroundImage = global::ICE.POS.Properties.Resources.sale_title;
            this.plSaleTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSaleTitle.Location = new System.Drawing.Point(0, 0);
            this.plSaleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.plSaleTitle.Name = "plSaleTitle";
            this.plSaleTitle.Size = new System.Drawing.Size(400, 36);
            this.plSaleTitle.TabIndex = 1;
            // 
            // GvSaleFlow
            // 
            this.GvSaleFlow.AllowUserToAddRows = false;
            this.GvSaleFlow.AllowUserToDeleteRows = false;
            this.GvSaleFlow.AutoGenerateColumns = false;
            this.GvSaleFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvSaleFlow.DataSource = this.bindingSaleFlow;
            this.GvSaleFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvSaleFlow.Location = new System.Drawing.Point(0, 36);
            this.GvSaleFlow.Margin = new System.Windows.Forms.Padding(0);
            this.GvSaleFlow.MultiSelect = false;
            this.GvSaleFlow.Name = "GvSaleFlow";
            this.GvSaleFlow.ReadOnly = true;
            this.GvSaleFlow.RowTemplate.Height = 52;
            this.GvSaleFlow.RowTemplate.ReadOnly = true;
            this.GvSaleFlow.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GvSaleFlow.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GvSaleFlow.Size = new System.Drawing.Size(400, 228);
            this.GvSaleFlow.TabIndex = 2;
            // 
            // plSaleDown
            // 
            this.plSaleDown.BackColor = System.Drawing.Color.White;
            this.plSaleDown.Controls.Add(this.btnSaleDown);
            this.plSaleDown.Controls.Add(this.btnSaleUp);
            this.plSaleDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSaleDown.Location = new System.Drawing.Point(0, 264);
            this.plSaleDown.Margin = new System.Windows.Forms.Padding(0);
            this.plSaleDown.Name = "plSaleDown";
            this.plSaleDown.Size = new System.Drawing.Size(400, 40);
            this.plSaleDown.TabIndex = 3;
            // 
            // btnSaleDown
            // 
            this.btnSaleDown.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleDown.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaleDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleDown.IsGrass = false;
            this.btnSaleDown.IsItem = false;
            this.btnSaleDown.Location = new System.Drawing.Point(205, 3);
            this.btnSaleDown.MyText = "∨";
            this.btnSaleDown.Name = "btnSaleDown";
            this.btnSaleDown.Size = new System.Drawing.Size(186, 34);
            this.btnSaleDown.TabIndex = 0;
            this.btnSaleDown.TabStop = false;
            this.btnSaleDown.Click += new System.EventHandler(this.btnSaleDown_Click);
            // 
            // btnSaleUp
            // 
            this.btnSaleUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleUp.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaleUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleUp.IsGrass = false;
            this.btnSaleUp.IsItem = false;
            this.btnSaleUp.Location = new System.Drawing.Point(10, 3);
            this.btnSaleUp.MyText = "∧";
            this.btnSaleUp.Name = "btnSaleUp";
            this.btnSaleUp.Size = new System.Drawing.Size(186, 34);
            this.btnSaleUp.TabIndex = 0;
            this.btnSaleUp.TabStop = false;
            this.btnSaleUp.Click += new System.EventHandler(this.btnSaleUp_Click);
            // 
            // tlpMiddleRight
            // 
            this.tlpMiddleRight.BackColor = System.Drawing.Color.Silver;
            this.tlpMiddleRight.ColumnCount = 6;
            this.tlpMiddleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpMiddleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMiddleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpMiddleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpMiddleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMiddleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tlpMiddleRight.Controls.Add(this.plQtyLeft, 3, 0);
            this.tlpMiddleRight.Controls.Add(this.plQtyRight, 5, 0);
            this.tlpMiddleRight.Controls.Add(this.plQtyCenter, 4, 0);
            this.tlpMiddleRight.Controls.Add(this.plAmtRight, 2, 0);
            this.tlpMiddleRight.Controls.Add(this.plAmtCenter, 1, 0);
            this.tlpMiddleRight.Controls.Add(this.plAmtLeft, 0, 0);
            this.tlpMiddleRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMiddleRight.Location = new System.Drawing.Point(400, 45);
            this.tlpMiddleRight.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMiddleRight.Name = "tlpMiddleRight";
            this.tlpMiddleRight.RowCount = 1;
            this.tlpMiddleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMiddleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMiddleRight.Size = new System.Drawing.Size(396, 105);
            this.tlpMiddleRight.TabIndex = 1;
            // 
            // plQtyLeft
            // 
            this.plQtyLeft.BackColor = System.Drawing.Color.SkyBlue;
            this.plQtyLeft.BackgroundImage = global::ICE.POS.Properties.Resources.middle_amt_left;
            this.plQtyLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plQtyLeft.Location = new System.Drawing.Point(199, 0);
            this.plQtyLeft.Margin = new System.Windows.Forms.Padding(0);
            this.plQtyLeft.Name = "plQtyLeft";
            this.plQtyLeft.Size = new System.Drawing.Size(17, 105);
            this.plQtyLeft.TabIndex = 0;
            // 
            // plQtyRight
            // 
            this.plQtyRight.BackColor = System.Drawing.Color.SkyBlue;
            this.plQtyRight.BackgroundImage = global::ICE.POS.Properties.Resources.middle_amt_right;
            this.plQtyRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plQtyRight.Location = new System.Drawing.Point(378, 0);
            this.plQtyRight.Margin = new System.Windows.Forms.Padding(0);
            this.plQtyRight.Name = "plQtyRight";
            this.plQtyRight.Size = new System.Drawing.Size(18, 105);
            this.plQtyRight.TabIndex = 2;
            // 
            // plQtyCenter
            // 
            this.plQtyCenter.BackColor = System.Drawing.Color.White;
            this.plQtyCenter.BackgroundImage = global::ICE.POS.Properties.Resources.middle_amt_center;
            this.plQtyCenter.Controls.Add(this.lbQntyTitle);
            this.plQtyCenter.Controls.Add(this.lbQntyTotal);
            this.plQtyCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plQtyCenter.Location = new System.Drawing.Point(216, 0);
            this.plQtyCenter.Margin = new System.Windows.Forms.Padding(0);
            this.plQtyCenter.Name = "plQtyCenter";
            this.plQtyCenter.Size = new System.Drawing.Size(162, 105);
            this.plQtyCenter.TabIndex = 3;
            // 
            // lbQntyTitle
            // 
            this.lbQntyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbQntyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQntyTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.lbQntyTitle.Location = new System.Drawing.Point(0, 0);
            this.lbQntyTitle.Name = "lbQntyTitle";
            this.lbQntyTitle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lbQntyTitle.Size = new System.Drawing.Size(162, 42);
            this.lbQntyTitle.TabIndex = 1;
            this.lbQntyTitle.Text = "数量:";
            this.lbQntyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbQntyTotal
            // 
            this.lbQntyTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbQntyTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbQntyTotal.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.lbQntyTotal.Location = new System.Drawing.Point(0, 62);
            this.lbQntyTotal.Name = "lbQntyTotal";
            this.lbQntyTotal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lbQntyTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbQntyTotal.Size = new System.Drawing.Size(162, 43);
            this.lbQntyTotal.TabIndex = 0;
            this.lbQntyTotal.Text = "0.00";
            this.lbQntyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plAmtRight
            // 
            this.plAmtRight.BackColor = System.Drawing.Color.SkyBlue;
            this.plAmtRight.BackgroundImage = global::ICE.POS.Properties.Resources.middle_amt_right;
            this.plAmtRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAmtRight.Location = new System.Drawing.Point(180, 0);
            this.plAmtRight.Margin = new System.Windows.Forms.Padding(0);
            this.plAmtRight.Name = "plAmtRight";
            this.plAmtRight.Size = new System.Drawing.Size(19, 105);
            this.plAmtRight.TabIndex = 4;
            // 
            // plAmtCenter
            // 
            this.plAmtCenter.BackColor = System.Drawing.Color.White;
            this.plAmtCenter.BackgroundImage = global::ICE.POS.Properties.Resources.middle_amt_center;
            this.plAmtCenter.Controls.Add(this.lbAmtTitle);
            this.plAmtCenter.Controls.Add(this.lbAmtTotal);
            this.plAmtCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAmtCenter.Location = new System.Drawing.Point(18, 0);
            this.plAmtCenter.Margin = new System.Windows.Forms.Padding(0);
            this.plAmtCenter.Name = "plAmtCenter";
            this.plAmtCenter.Size = new System.Drawing.Size(162, 105);
            this.plAmtCenter.TabIndex = 5;
            // 
            // lbAmtTitle
            // 
            this.lbAmtTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbAmtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAmtTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.lbAmtTitle.Location = new System.Drawing.Point(0, 0);
            this.lbAmtTitle.Name = "lbAmtTitle";
            this.lbAmtTitle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lbAmtTitle.Size = new System.Drawing.Size(162, 42);
            this.lbAmtTitle.TabIndex = 1;
            this.lbAmtTitle.Text = "总价:";
            this.lbAmtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAmtTotal
            // 
            this.lbAmtTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbAmtTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbAmtTotal.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.lbAmtTotal.Location = new System.Drawing.Point(0, 62);
            this.lbAmtTotal.Name = "lbAmtTotal";
            this.lbAmtTotal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lbAmtTotal.Size = new System.Drawing.Size(162, 43);
            this.lbAmtTotal.TabIndex = 0;
            this.lbAmtTotal.Text = "0.00";
            this.lbAmtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plAmtLeft
            // 
            this.plAmtLeft.BackColor = System.Drawing.Color.SkyBlue;
            this.plAmtLeft.BackgroundImage = global::ICE.POS.Properties.Resources.middle_amt_left;
            this.plAmtLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAmtLeft.Location = new System.Drawing.Point(0, 0);
            this.plAmtLeft.Margin = new System.Windows.Forms.Padding(0);
            this.plAmtLeft.Name = "plAmtLeft";
            this.plAmtLeft.Size = new System.Drawing.Size(18, 105);
            this.plAmtLeft.TabIndex = 6;
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.Transparent;
            this.plTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plTop.BackgroundImage")));
            this.tlpMain.SetColumnSpan(this.plTop, 2);
            this.plTop.Controls.Add(this.picLogo);
            this.plTop.Controls.Add(this.lbApplication);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Margin = new System.Windows.Forms.Padding(0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(796, 45);
            this.plTop.TabIndex = 4;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(2, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(70, 42);
            this.picLogo.TabIndex = 29;
            this.picLogo.TabStop = false;
            // 
            // lbApplication
            // 
            this.lbApplication.AutoSize = true;
            this.lbApplication.Font = new System.Drawing.Font("宋体", 12F);
            this.lbApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbApplication.Location = new System.Drawing.Point(83, 17);
            this.lbApplication.Name = "lbApplication";
            this.lbApplication.Size = new System.Drawing.Size(69, 20);
            this.lbApplication.TabIndex = 0;
            this.lbApplication.Text = "123456";
            // 
            // tlpMiddleLeft
            // 
            this.tlpMiddleLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.tlpMiddleLeft.Controls.Add(this.labelNetStatus);
            this.tlpMiddleLeft.Controls.Add(this.lbVip);
            this.tlpMiddleLeft.Controls.Add(this.lbShopAssistant);
            this.tlpMiddleLeft.Controls.Add(this.lbShopAssistantValue);
            this.tlpMiddleLeft.Controls.Add(this.lbVipValue);
            this.tlpMiddleLeft.Controls.Add(this.lbNowTime);
            this.tlpMiddleLeft.Controls.Add(this.lbCheckStandValue);
            this.tlpMiddleLeft.Controls.Add(this.lbCheckStand);
            this.tlpMiddleLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMiddleLeft.Location = new System.Drawing.Point(0, 45);
            this.tlpMiddleLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMiddleLeft.Name = "tlpMiddleLeft";
            this.tlpMiddleLeft.Size = new System.Drawing.Size(400, 105);
            this.tlpMiddleLeft.TabIndex = 6;
            // 
            // labelNetStatus
            // 
            this.labelNetStatus.AutoSize = true;
            this.labelNetStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNetStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelNetStatus.Location = new System.Drawing.Point(218, 43);
            this.labelNetStatus.Name = "labelNetStatus";
            this.labelNetStatus.Size = new System.Drawing.Size(92, 27);
            this.labelNetStatus.TabIndex = 30;
            this.labelNetStatus.Text = "联网状态";
            // 
            // lbVip
            // 
            this.lbVip.AutoSize = true;
            this.lbVip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVip.Location = new System.Drawing.Point(3, 75);
            this.lbVip.Name = "lbVip";
            this.lbVip.Size = new System.Drawing.Size(75, 27);
            this.lbVip.TabIndex = 0;
            this.lbVip.Text = "会   员:";
            // 
            // lbShopAssistant
            // 
            this.lbShopAssistant.AutoSize = true;
            this.lbShopAssistant.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbShopAssistant.Location = new System.Drawing.Point(3, 42);
            this.lbShopAssistant.Name = "lbShopAssistant";
            this.lbShopAssistant.Size = new System.Drawing.Size(77, 27);
            this.lbShopAssistant.TabIndex = 0;
            this.lbShopAssistant.Text = "收银员:";
            // 
            // lbShopAssistantValue
            // 
            this.lbShopAssistantValue.AutoSize = true;
            this.lbShopAssistantValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbShopAssistantValue.Location = new System.Drawing.Point(71, 47);
            this.lbShopAssistantValue.Name = "lbShopAssistantValue";
            this.lbShopAssistantValue.Size = new System.Drawing.Size(143, 18);
            this.lbShopAssistantValue.TabIndex = 0;
            this.lbShopAssistantValue.Text = "【10002】管理员";
            // 
            // lbVipValue
            // 
            this.lbVipValue.AutoSize = true;
            this.lbVipValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVipValue.Location = new System.Drawing.Point(70, 80);
            this.lbVipValue.Name = "lbVipValue";
            this.lbVipValue.Size = new System.Drawing.Size(0, 18);
            this.lbVipValue.TabIndex = 0;
            // 
            // lbNowTime
            // 
            this.lbNowTime.AutoSize = true;
            this.lbNowTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNowTime.Location = new System.Drawing.Point(196, 12);
            this.lbNowTime.Name = "lbNowTime";
            this.lbNowTime.Size = new System.Drawing.Size(214, 27);
            this.lbNowTime.TabIndex = 0;
            this.lbNowTime.Text = "0000-00-00 00:00:00";
            // 
            // lbCheckStandValue
            // 
            this.lbCheckStandValue.AutoSize = true;
            this.lbCheckStandValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCheckStandValue.Location = new System.Drawing.Point(71, 12);
            this.lbCheckStandValue.Name = "lbCheckStandValue";
            this.lbCheckStandValue.Size = new System.Drawing.Size(89, 18);
            this.lbCheckStandValue.TabIndex = 0;
            this.lbCheckStandValue.Text = "【10002】";
            // 
            // lbCheckStand
            // 
            this.lbCheckStand.AutoSize = true;
            this.lbCheckStand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCheckStand.Location = new System.Drawing.Point(3, 7);
            this.lbCheckStand.Name = "lbCheckStand";
            this.lbCheckStand.Size = new System.Drawing.Size(77, 27);
            this.lbCheckStand.TabIndex = 0;
            this.lbCheckStand.Text = "收银台:";
            // 
            // plNumInput
            // 
            this.plNumInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblNum.SetColumnSpan(this.plNumInput, 5);
            this.plNumInput.Controls.Add(this.lbCursor);
            this.plNumInput.Controls.Add(this.lbInput);
            this.plNumInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plNumInput.Location = new System.Drawing.Point(3, 3);
            this.plNumInput.Name = "plNumInput";
            this.plNumInput.Size = new System.Drawing.Size(459, 64);
            this.plNumInput.TabIndex = 0;
            // 
            // lbCursor
            // 
            this.lbCursor.BackColor = System.Drawing.Color.Black;
            this.lbCursor.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCursor.Location = new System.Drawing.Point(100, 40);
            this.lbCursor.Name = "lbCursor";
            this.lbCursor.Size = new System.Drawing.Size(3, 50);
            this.lbCursor.TabIndex = 1;
            // 
            // lbInput
            // 
            this.lbInput.BackColor = System.Drawing.Color.White;
            this.lbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInput.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Bold);
            this.lbInput.Location = new System.Drawing.Point(0, 0);
            this.lbInput.Margin = new System.Windows.Forms.Padding(0);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(459, 64);
            this.lbInput.TabIndex = 0;
            this.lbInput.Text = "1234567890123";
            this.lbInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblNum
            // 
            this.tblNum.BackColor = System.Drawing.Color.Transparent;
            this.tblNum.ColumnCount = 5;
            this.tblNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tblNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tblNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tblNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tblNum.Controls.Add(this.btnSaleNum0, 0, 3);
            this.tblNum.Controls.Add(this.plNumInput, 0, 0);
            this.tblNum.Controls.Add(this.btnSaleNumEnter, 4, 3);
            this.tblNum.Controls.Add(this.btnSaleNumDot, 0, 2);
            this.tblNum.Controls.Add(this.btnSaleNum8, 2, 1);
            this.tblNum.Controls.Add(this.btnSaleNum1, 1, 3);
            this.tblNum.Controls.Add(this.btnSaleNum9, 3, 1);
            this.tblNum.Controls.Add(this.btnSaleNum3, 3, 3);
            this.tblNum.Controls.Add(this.btnSaleNum7, 1, 1);
            this.tblNum.Controls.Add(this.btnSaleNum2, 2, 3);
            this.tblNum.Controls.Add(this.btnSaleNum4, 1, 2);
            this.tblNum.Controls.Add(this.btnSaleNum5, 2, 2);
            this.tblNum.Controls.Add(this.btnSaleNum6, 3, 2);
            this.tblNum.Controls.Add(this.btnSaleNumReset, 4, 2);
            this.tblNum.Controls.Add(this.btnSaleNumBack, 4, 1);
            this.tblNum.Controls.Add(this.btnSaleNumDiv, 0, 1);
            this.tblNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNum.Location = new System.Drawing.Point(0, 0);
            this.tblNum.Margin = new System.Windows.Forms.Padding(0);
            this.tblNum.Name = "tblNum";
            this.tblNum.RowCount = 4;
            this.tblNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00012F));
            this.tblNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99872F));
            this.tblNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00058F));
            this.tblNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00058F));
            this.tblNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNum.Size = new System.Drawing.Size(465, 281);
            this.tblNum.TabIndex = 0;
            this.tblNum.Visible = false;
            // 
            // btnSaleNum0
            // 
            this.btnSaleNum0.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum0.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum0.IsGrass = false;
            this.btnSaleNum0.IsItem = false;
            this.btnSaleNum0.Location = new System.Drawing.Point(3, 213);
            this.btnSaleNum0.MyText = "0";
            this.btnSaleNum0.Name = "btnSaleNum0";
            this.btnSaleNum0.Size = new System.Drawing.Size(87, 65);
            this.btnSaleNum0.TabIndex = 22;
            this.btnSaleNum0.TabStop = false;
            this.btnSaleNum0.Tag = "0";
            this.btnSaleNum0.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNumEnter
            // 
            this.btnSaleNumEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNumEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNumEnter.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.btnSaleNumEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNumEnter.IsGrass = false;
            this.btnSaleNumEnter.IsItem = false;
            this.btnSaleNumEnter.Location = new System.Drawing.Point(375, 213);
            this.btnSaleNumEnter.MyText = "确定";
            this.btnSaleNumEnter.Name = "btnSaleNumEnter";
            this.btnSaleNumEnter.Size = new System.Drawing.Size(87, 65);
            this.btnSaleNumEnter.TabIndex = 21;
            this.btnSaleNumEnter.TabStop = false;
            this.btnSaleNumEnter.Tag = "enter";
            this.btnSaleNumEnter.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNumDot
            // 
            this.btnSaleNumDot.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNumDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNumDot.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNumDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNumDot.IsGrass = false;
            this.btnSaleNumDot.IsItem = false;
            this.btnSaleNumDot.Location = new System.Drawing.Point(3, 143);
            this.btnSaleNumDot.MyText = ".";
            this.btnSaleNumDot.Name = "btnSaleNumDot";
            this.btnSaleNumDot.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNumDot.TabIndex = 18;
            this.btnSaleNumDot.TabStop = false;
            this.btnSaleNumDot.Tag = "dot";
            this.btnSaleNumDot.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum8
            // 
            this.btnSaleNum8.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum8.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum8.IsGrass = false;
            this.btnSaleNum8.IsItem = false;
            this.btnSaleNum8.Location = new System.Drawing.Point(189, 73);
            this.btnSaleNum8.MyText = "8";
            this.btnSaleNum8.Name = "btnSaleNum8";
            this.btnSaleNum8.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNum8.TabIndex = 14;
            this.btnSaleNum8.TabStop = false;
            this.btnSaleNum8.Tag = "8";
            this.btnSaleNum8.Text = "8";
            this.btnSaleNum8.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum1
            // 
            this.btnSaleNum1.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum1.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum1.IsGrass = false;
            this.btnSaleNum1.IsItem = false;
            this.btnSaleNum1.Location = new System.Drawing.Point(96, 213);
            this.btnSaleNum1.MyText = "1";
            this.btnSaleNum1.Name = "btnSaleNum1";
            this.btnSaleNum1.Size = new System.Drawing.Size(87, 65);
            this.btnSaleNum1.TabIndex = 17;
            this.btnSaleNum1.TabStop = false;
            this.btnSaleNum1.Tag = "1";
            this.btnSaleNum1.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum9
            // 
            this.btnSaleNum9.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum9.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum9.IsGrass = false;
            this.btnSaleNum9.IsItem = false;
            this.btnSaleNum9.Location = new System.Drawing.Point(282, 73);
            this.btnSaleNum9.MyText = "9";
            this.btnSaleNum9.Name = "btnSaleNum9";
            this.btnSaleNum9.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNum9.TabIndex = 11;
            this.btnSaleNum9.TabStop = false;
            this.btnSaleNum9.Tag = "9";
            this.btnSaleNum9.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum3
            // 
            this.btnSaleNum3.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum3.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum3.IsGrass = false;
            this.btnSaleNum3.IsItem = false;
            this.btnSaleNum3.Location = new System.Drawing.Point(282, 213);
            this.btnSaleNum3.MyText = "3";
            this.btnSaleNum3.Name = "btnSaleNum3";
            this.btnSaleNum3.Size = new System.Drawing.Size(87, 65);
            this.btnSaleNum3.TabIndex = 19;
            this.btnSaleNum3.TabStop = false;
            this.btnSaleNum3.Tag = "3";
            this.btnSaleNum3.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum7
            // 
            this.btnSaleNum7.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum7.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum7.IsGrass = false;
            this.btnSaleNum7.IsItem = false;
            this.btnSaleNum7.Location = new System.Drawing.Point(96, 73);
            this.btnSaleNum7.MyText = "7";
            this.btnSaleNum7.Name = "btnSaleNum7";
            this.btnSaleNum7.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNum7.TabIndex = 13;
            this.btnSaleNum7.TabStop = false;
            this.btnSaleNum7.Tag = "7";
            this.btnSaleNum7.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum2
            // 
            this.btnSaleNum2.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum2.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum2.IsGrass = false;
            this.btnSaleNum2.IsItem = false;
            this.btnSaleNum2.Location = new System.Drawing.Point(189, 213);
            this.btnSaleNum2.MyText = "2";
            this.btnSaleNum2.Name = "btnSaleNum2";
            this.btnSaleNum2.Size = new System.Drawing.Size(87, 65);
            this.btnSaleNum2.TabIndex = 20;
            this.btnSaleNum2.TabStop = false;
            this.btnSaleNum2.Tag = "2";
            this.btnSaleNum2.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum4
            // 
            this.btnSaleNum4.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum4.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum4.IsGrass = false;
            this.btnSaleNum4.IsItem = false;
            this.btnSaleNum4.Location = new System.Drawing.Point(96, 143);
            this.btnSaleNum4.MyText = "4";
            this.btnSaleNum4.Name = "btnSaleNum4";
            this.btnSaleNum4.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNum4.TabIndex = 12;
            this.btnSaleNum4.TabStop = false;
            this.btnSaleNum4.Tag = "4";
            this.btnSaleNum4.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum5
            // 
            this.btnSaleNum5.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum5.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum5.IsGrass = false;
            this.btnSaleNum5.IsItem = false;
            this.btnSaleNum5.Location = new System.Drawing.Point(189, 143);
            this.btnSaleNum5.MyText = "5";
            this.btnSaleNum5.Name = "btnSaleNum5";
            this.btnSaleNum5.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNum5.TabIndex = 15;
            this.btnSaleNum5.TabStop = false;
            this.btnSaleNum5.Tag = "5";
            this.btnSaleNum5.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNum6
            // 
            this.btnSaleNum6.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNum6.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold);
            this.btnSaleNum6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNum6.IsGrass = false;
            this.btnSaleNum6.IsItem = false;
            this.btnSaleNum6.Location = new System.Drawing.Point(282, 143);
            this.btnSaleNum6.MyText = "6";
            this.btnSaleNum6.Name = "btnSaleNum6";
            this.btnSaleNum6.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNum6.TabIndex = 16;
            this.btnSaleNum6.TabStop = false;
            this.btnSaleNum6.Tag = "6";
            this.btnSaleNum6.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNumReset
            // 
            this.btnSaleNumReset.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNumReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNumReset.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.btnSaleNumReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNumReset.IsGrass = false;
            this.btnSaleNumReset.IsItem = false;
            this.btnSaleNumReset.Location = new System.Drawing.Point(375, 143);
            this.btnSaleNumReset.MyText = "取消";
            this.btnSaleNumReset.Name = "btnSaleNumReset";
            this.btnSaleNumReset.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNumReset.TabIndex = 23;
            this.btnSaleNumReset.TabStop = false;
            this.btnSaleNumReset.Tag = "reset";
            this.btnSaleNumReset.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNumBack
            // 
            this.btnSaleNumBack.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNumBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNumBack.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.btnSaleNumBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNumBack.IsGrass = false;
            this.btnSaleNumBack.IsItem = false;
            this.btnSaleNumBack.Location = new System.Drawing.Point(375, 73);
            this.btnSaleNumBack.MyText = "退格";
            this.btnSaleNumBack.Name = "btnSaleNumBack";
            this.btnSaleNumBack.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNumBack.TabIndex = 24;
            this.btnSaleNumBack.TabStop = false;
            this.btnSaleNumBack.Tag = "backspace";
            this.btnSaleNumBack.Click += new System.EventHandler(this.picSaleFunc_Click);
            // 
            // btnSaleNumDiv
            // 
            this.btnSaleNumDiv.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleNumDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaleNumDiv.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
            this.btnSaleNumDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSaleNumDiv.IsGrass = false;
            this.btnSaleNumDiv.IsItem = false;
            this.btnSaleNumDiv.Location = new System.Drawing.Point(3, 73);
            this.btnSaleNumDiv.MyText = "-";
            this.btnSaleNumDiv.Name = "btnSaleNumDiv";
            this.btnSaleNumDiv.Size = new System.Drawing.Size(87, 64);
            this.btnSaleNumDiv.TabIndex = 25;
            this.btnSaleNumDiv.TabStop = false;
            this.btnSaleNumDiv.Tag = "div";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(796, 574);
            this.ControlBox = false;
            this.Controls.Add(this.plOtherFunc);
            this.Controls.Add(this.tblPanelBalance);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.plOtherFunc.ResumeLayout(false);
            this.tblPanelBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvPayFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPayFlow)).EndInit();
            this.plPayInfo.ResumeLayout(false);
            this.gbPayInput.ResumeLayout(false);
            this.plPayKey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPayNumEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNumBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNumDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayNum7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plPayInput.ResumeLayout(false);
            this.gbPayInfo.ResumeLayout(false);
            this.plPayLeft.ResumeLayout(false);
            this.plPayTitle.ResumeLayout(false);
            this.tblPayWay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunWechat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFuncPayEsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunRmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunCup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunZfb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunCou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunPayOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAllDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAllcan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAzs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicFunAgz)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.plButton.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFastOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastTot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastPrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastDct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastPnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastDou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFastVip)).EndInit();
            this.tlpCenter.ResumeLayout(false);
            this.tlpCenterRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClsNextPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClsSmallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClsPriorPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClsSmallRight)).EndInit();
            this.tlpSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvSaleFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSaleFlow)).EndInit();
            this.plSaleDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleUp)).EndInit();
            this.tlpMiddleRight.ResumeLayout(false);
            this.plQtyCenter.ResumeLayout(false);
            this.plAmtCenter.ResumeLayout(false);
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpMiddleLeft.ResumeLayout(false);
            this.tlpMiddleLeft.PerformLayout();
            this.plNumInput.ResumeLayout(false);
            this.tblNum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNum6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaleNumDiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSaleFlow;
        private TableLayoutPanelEx tlpMain;
        private PanelEx plTop;
        private TableLayoutPanelEx tlpCenter;
        private TableLayoutPanelEx tlpSale;
        private PanelEx plSaleTitle;
        private System.Windows.Forms.DataGridView GvSaleFlow;
        private System.Windows.Forms.Label lbMessage;
        private PanelEx plSaleDown;
        private TableLayoutPanelEx tlpMiddleRight;
        private PanelEx plQtyLeft;
        private PanelEx plQtyRight;
        private PanelEx plQtyCenter;
        private System.Windows.Forms.Label lbQntyTitle;
        private System.Windows.Forms.Label lbQntyTotal;
        private PanelEx plAmtRight;
        private PanelEx plAmtCenter;
        private System.Windows.Forms.Label lbAmtTitle;
        private System.Windows.Forms.Label lbAmtTotal;
        private PanelEx plAmtLeft;
        private PanelEx tlpMiddleLeft;
        private PanelEx plButton;
        private TableLayoutPanelEx tlpBottom;
        private ButtonForPos btnFastDel;
        private ButtonForPos btnFastNum;
        private ButtonForPos btnFastDct;
        private ButtonForPos btnFastPrc;
        private ButtonForPos btnSaleDown;
        private ButtonForPos btnSaleUp;
        private System.Windows.Forms.Label lbCheckStand;
        private System.Windows.Forms.Label lbVip;
        private System.Windows.Forms.Label lbShopAssistant;
        private System.Windows.Forms.Label lbShopAssistantValue;
        private System.Windows.Forms.Label lbVipValue;
        private System.Windows.Forms.Label lbNowTime;
        private System.Windows.Forms.Label lbCheckStandValue;
        private System.Windows.Forms.Timer tNowTime;
        private ButtonForPos btnFastOther;
        private ButtonForPos btnFastExit;
        private ButtonForPos btnFastTot;
        private ButtonForPos btnFastPnr;
        private ButtonForPos btnFastDou;
        private ButtonForPos btnFastVip;
        private System.Windows.Forms.Timer timeCursor;
        private TableLayoutPanelEx tlpCenterRight;
        private System.Windows.Forms.BindingSource bindingPayFlow;
        private System.Windows.Forms.ListBox lbxFunc;
        private PanelEx plOtherFunc;
        private PanelEx plItem;
        private PanelEx plClsBig;
        private ButtonForPos btnClsNextPage;
        private PanelEx plClsSmall;
        private ButtonForPos btnClsSmallLeft;
        private ButtonForPos btnClsPriorPage;
        private ButtonForPos btnClsSmallRight;
        private PanelEx plPayTitle;
        private TableLayoutPanelEx tblPayWay;
        private ButtonForPos btnPicFuncPayEsc;
        private ButtonForPos btnPicFunRmb;
        private ButtonForPos btnPicFunCup;
        private ButtonForPos btnPicFunZfb;
        private ButtonForPos btnPicFunCou;
        private ButtonForPos btnPicFunPayOther;
        private ButtonForPos btnPicFunAllDis;
        private ButtonForPos btnPicFunAllcan;
        private PanelEx plPayInfo;
        private System.Windows.Forms.GroupBox gbPayInput;
        private PanelEx plPayKey;
        private System.Windows.Forms.PictureBox picPayNumEnter;
        private System.Windows.Forms.PictureBox picPayNum3;
        private System.Windows.Forms.PictureBox btnSaleReset;
        private System.Windows.Forms.PictureBox picPayNum6;
        private System.Windows.Forms.PictureBox picPayNum2;
        private System.Windows.Forms.PictureBox picPayNumBack;
        private System.Windows.Forms.PictureBox picPayNum5;
        private System.Windows.Forms.PictureBox picPayNum1;
        private System.Windows.Forms.PictureBox picPayNum9;
        private System.Windows.Forms.PictureBox picPayNum4;
        private System.Windows.Forms.PictureBox picPayNum0;
        private System.Windows.Forms.PictureBox picPayNum8;
        private System.Windows.Forms.PictureBox picPayNumDot;
        private System.Windows.Forms.PictureBox picPayNum7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PanelEx plPayInput;
        private System.Windows.Forms.Label lbPayCursor;
        private System.Windows.Forms.Label lbPayInput;
        private System.Windows.Forms.GroupBox gbPayInfo;
        private PanelEx plPayLeft;
        private System.Windows.Forms.Label lbPayAmtChange;
        private System.Windows.Forms.Label lbPayAmtPaid;
        private System.Windows.Forms.Label lbPayAmtRec;
        private System.Windows.Forms.Label lbPayTotalAmt;
        private PanelEx plPayListTilte;
        private System.Windows.Forms.DataGridView GvPayFlow;
        private TableLayoutPanelEx tblPanelBalance;
        private ButtonForPos btnSaleNumDiv;
        private ButtonForPos btnSaleNumBack;
        private ButtonForPos btnSaleNumReset;
        private ButtonForPos btnSaleNum6;
        private ButtonForPos btnSaleNum5;
        private ButtonForPos btnSaleNum4;
        private ButtonForPos btnSaleNum2;
        private ButtonForPos btnSaleNum7;
        private ButtonForPos btnSaleNum3;
        private ButtonForPos btnSaleNum9;
        private ButtonForPos btnSaleNum1;
        private ButtonForPos btnSaleNum8;
        private ButtonForPos btnSaleNumDot;
        private ButtonForPos btnSaleNumEnter;
        private PanelEx plNumInput;
        private TableLayoutPanelEx tblNum;
        private ButtonForPos btnSaleNum0;
        private System.Windows.Forms.Label lbCursor;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbApplication;
        private System.Windows.Forms.PictureBox picLogo;
        private ButtonForPos btnPicFunAzs;
        private ButtonForPos btnPicFunAgz;
        private System.Windows.Forms.Label labelNetStatus;
        private ButtonForPos btnPicFunWechat;


    }
}