using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmDoubleDisplay
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
            this.plSaleFlow = new System.Windows.Forms.Panel();
            this.GvSaleFlow = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelhead = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plpay = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.lbChgAmt = new System.Windows.Forms.Label();
            this.lbPaedAmt = new System.Windows.Forms.Label();
            this.lbRemainAmt = new System.Windows.Forms.Label();
            this.lbBTotalAmt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plSale = new System.Windows.Forms.Panel();
            this.bindingSaleFlow = new System.Windows.Forms.BindingSource(this.components);
            this.tblCardInfo = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbCard = new System.Windows.Forms.Label();
            this.lbTotalAmt = new System.Windows.Forms.Label();
            this.lbTotalQty = new System.Windows.Forms.Label();
            this.plSaleFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvSaleFlow)).BeginInit();
            this.tableLayoutPanelhead.SuspendLayout();
            this.plpay.SuspendLayout();
            this.plSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSaleFlow)).BeginInit();
            this.tblCardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // plSaleFlow
            // 
            this.plSaleFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(222)))), ((int)(((byte)(247)))));
            this.plSaleFlow.Controls.Add(this.GvSaleFlow);
            this.plSaleFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSaleFlow.Location = new System.Drawing.Point(0, 54);
            this.plSaleFlow.Margin = new System.Windows.Forms.Padding(0);
            this.plSaleFlow.Name = "plSaleFlow";
            this.plSaleFlow.Size = new System.Drawing.Size(324, 254);
            this.plSaleFlow.TabIndex = 23;
            // 
            // GvSaleFlow
            // 
            this.GvSaleFlow.AllowUserToAddRows = false;
            this.GvSaleFlow.BackgroundColor = System.Drawing.Color.White;
            this.GvSaleFlow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvSaleFlow.ColumnHeadersHeight = 60;
            this.GvSaleFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GvSaleFlow.ColumnHeadersVisible = false;
            this.GvSaleFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvSaleFlow.Location = new System.Drawing.Point(0, 0);
            this.GvSaleFlow.Margin = new System.Windows.Forms.Padding(4);
            this.GvSaleFlow.MultiSelect = false;
            this.GvSaleFlow.Name = "GvSaleFlow";
            this.GvSaleFlow.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvSaleFlow.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GvSaleFlow.RowHeadersVisible = false;
            this.GvSaleFlow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GvSaleFlow.RowTemplate.Height = 40;
            this.GvSaleFlow.RowTemplate.ReadOnly = true;
            this.GvSaleFlow.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GvSaleFlow.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GvSaleFlow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvSaleFlow.Size = new System.Drawing.Size(324, 254);
            this.GvSaleFlow.TabIndex = 0;
            this.GvSaleFlow.TabStop = false;
            this.GvSaleFlow.VirtualMode = true;
            this.GvSaleFlow.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GvSaleFlow_DataError);
            this.GvSaleFlow.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.GvSaleFlow_RowPostPaint);
            this.GvSaleFlow.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GvSaleFlow_RowsAdded);
            // 
            // tableLayoutPanelhead
            // 
            this.tableLayoutPanelhead.ColumnCount = 3;
            this.tableLayoutPanelhead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelhead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelhead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelhead.Controls.Add(this.label13, 2, 1);
            this.tableLayoutPanelhead.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanelhead.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanelhead.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanelhead.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanelhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelhead.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelhead.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelhead.Name = "tableLayoutPanelhead";
            this.tableLayoutPanelhead.RowCount = 2;
            this.tableLayoutPanelhead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelhead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelhead.Size = new System.Drawing.Size(324, 54);
            this.tableLayoutPanelhead.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(226, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 27);
            this.label13.TabIndex = 25;
            this.label13.Text = "金额";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(129, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 27);
            this.label11.TabIndex = 24;
            this.label11.Text = "单价";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(0, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 27);
            this.label12.TabIndex = 23;
            this.label12.Text = "数量(kg/件)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelhead.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(129, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 27);
            this.label9.TabIndex = 21;
            this.label9.Text = "品名";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "货号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plpay
            // 
            this.plpay.BackColor = System.Drawing.Color.White;
            this.plpay.Controls.Add(this.label27);
            this.plpay.Controls.Add(this.lbChgAmt);
            this.plpay.Controls.Add(this.lbPaedAmt);
            this.plpay.Controls.Add(this.lbRemainAmt);
            this.plpay.Controls.Add(this.lbBTotalAmt);
            this.plpay.Controls.Add(this.label6);
            this.plpay.Controls.Add(this.label3);
            this.plpay.Controls.Add(this.label2);
            this.plpay.Controls.Add(this.label1);
            this.plpay.Location = new System.Drawing.Point(8, 472);
            this.plpay.Margin = new System.Windows.Forms.Padding(0);
            this.plpay.Name = "plpay";
            this.plpay.Size = new System.Drawing.Size(323, 193);
            this.plpay.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Blue;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.Color.Blue;
            this.label27.Location = new System.Drawing.Point(1, -205);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(273, 2);
            this.label27.TabIndex = 15;
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbChgAmt
            // 
            this.lbChgAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbChgAmt.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChgAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbChgAmt.Location = new System.Drawing.Point(159, 139);
            this.lbChgAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChgAmt.Name = "lbChgAmt";
            this.lbChgAmt.Size = new System.Drawing.Size(143, 29);
            this.lbChgAmt.TabIndex = 13;
            this.lbChgAmt.Text = "0.00";
            this.lbChgAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPaedAmt
            // 
            this.lbPaedAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPaedAmt.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPaedAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPaedAmt.Location = new System.Drawing.Point(159, 97);
            this.lbPaedAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaedAmt.Name = "lbPaedAmt";
            this.lbPaedAmt.Size = new System.Drawing.Size(143, 29);
            this.lbPaedAmt.TabIndex = 12;
            this.lbPaedAmt.Text = "0.00";
            this.lbPaedAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRemainAmt
            // 
            this.lbRemainAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRemainAmt.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRemainAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbRemainAmt.Location = new System.Drawing.Point(159, 59);
            this.lbRemainAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRemainAmt.Name = "lbRemainAmt";
            this.lbRemainAmt.Size = new System.Drawing.Size(143, 29);
            this.lbRemainAmt.TabIndex = 11;
            this.lbRemainAmt.Text = "0.00";
            this.lbRemainAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBTotalAmt
            // 
            this.lbBTotalAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBTotalAmt.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBTotalAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBTotalAmt.Location = new System.Drawing.Point(159, 18);
            this.lbBTotalAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBTotalAmt.Name = "lbBTotalAmt";
            this.lbBTotalAmt.Size = new System.Drawing.Size(143, 29);
            this.lbBTotalAmt.TabIndex = 10;
            this.lbBTotalAmt.Text = "0.00";
            this.lbBTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "总计：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(0, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "找零：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "实收：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "应收：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plSale
            // 
            this.plSale.BackColor = System.Drawing.Color.White;
            this.plSale.Controls.Add(this.plSaleFlow);
            this.plSale.Controls.Add(this.tableLayoutPanelhead);
            this.plSale.Location = new System.Drawing.Point(8, 5);
            this.plSale.Margin = new System.Windows.Forms.Padding(4);
            this.plSale.Name = "plSale";
            this.plSale.Size = new System.Drawing.Size(324, 308);
            this.plSale.TabIndex = 47;
            // 
            // tblCardInfo
            // 
            this.tblCardInfo.BackColor = System.Drawing.Color.White;
            this.tblCardInfo.ColumnCount = 2;
            this.tblCardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCardInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCardInfo.Controls.Add(this.lbScore, 0, 3);
            this.tblCardInfo.Controls.Add(this.lbMoney, 0, 1);
            this.tblCardInfo.Controls.Add(this.lbCard, 0, 1);
            this.tblCardInfo.Controls.Add(this.lbTotalAmt, 1, 0);
            this.tblCardInfo.Controls.Add(this.lbTotalQty, 0, 0);
            this.tblCardInfo.Location = new System.Drawing.Point(8, 329);
            this.tblCardInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tblCardInfo.Name = "tblCardInfo";
            this.tblCardInfo.RowCount = 4;
            this.tblCardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCardInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCardInfo.Size = new System.Drawing.Size(324, 132);
            this.tblCardInfo.TabIndex = 48;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.tblCardInfo.SetColumnSpan(this.lbScore, 2);
            this.lbScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbScore.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbScore.Location = new System.Drawing.Point(0, 102);
            this.lbScore.Margin = new System.Windows.Forms.Padding(0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(324, 30);
            this.lbScore.TabIndex = 6;
            this.lbScore.Text = "积 分:";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.BackColor = System.Drawing.Color.Transparent;
            this.tblCardInfo.SetColumnSpan(this.lbMoney, 2);
            this.lbMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMoney.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMoney.Location = new System.Drawing.Point(0, 72);
            this.lbMoney.Margin = new System.Windows.Forms.Padding(0);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(324, 30);
            this.lbMoney.TabIndex = 5;
            this.lbMoney.Text = "余 额:";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCard
            // 
            this.lbCard.AutoSize = true;
            this.lbCard.BackColor = System.Drawing.Color.Transparent;
            this.tblCardInfo.SetColumnSpan(this.lbCard, 2);
            this.lbCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCard.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCard.Location = new System.Drawing.Point(0, 42);
            this.lbCard.Margin = new System.Windows.Forms.Padding(0);
            this.lbCard.Name = "lbCard";
            this.lbCard.Size = new System.Drawing.Size(324, 30);
            this.lbCard.TabIndex = 4;
            this.lbCard.Text = "卡 号:";
            this.lbCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalAmt
            // 
            this.lbTotalAmt.AutoSize = true;
            this.lbTotalAmt.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalAmt.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalAmt.Location = new System.Drawing.Point(162, 0);
            this.lbTotalAmt.Margin = new System.Windows.Forms.Padding(0);
            this.lbTotalAmt.Name = "lbTotalAmt";
            this.lbTotalAmt.Size = new System.Drawing.Size(162, 42);
            this.lbTotalAmt.TabIndex = 1;
            this.lbTotalAmt.Text = "金额:0.00";
            this.lbTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalQty
            // 
            this.lbTotalQty.AutoSize = true;
            this.lbTotalQty.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalQty.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalQty.Location = new System.Drawing.Point(0, 0);
            this.lbTotalQty.Margin = new System.Windows.Forms.Padding(0);
            this.lbTotalQty.Name = "lbTotalQty";
            this.lbTotalQty.Size = new System.Drawing.Size(162, 42);
            this.lbTotalQty.TabIndex = 0;
            this.lbTotalQty.Text = "数量:0.00";
            this.lbTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDoubleDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1087, 694);
            this.Controls.Add(this.tblCardInfo);
            this.Controls.Add(this.plSale);
            this.Controls.Add(this.plpay);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoubleDisplay";
            this.Text = "FrmDoubleDisplay";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.FrmDoubleDisplay_Load);
            this.VisibleChanged += new System.EventHandler(this.visibleChange);
            this.plSaleFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvSaleFlow)).EndInit();
            this.tableLayoutPanelhead.ResumeLayout(false);
            this.tableLayoutPanelhead.PerformLayout();
            this.plpay.ResumeLayout(false);
            this.plSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSaleFlow)).EndInit();
            this.tblCardInfo.ResumeLayout(false);
            this.tblCardInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSaleFlow;
        public System.DateTime currNow;
        private System.Windows.Forms.DataGridView GvSaleFlow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbBTotalAmt;
        private System.Windows.Forms.Label lbChgAmt;
        private System.Windows.Forms.Label lbPaedAmt;
        private System.Windows.Forms.Label lbRemainAmt;
        private System.Windows.Forms.Label lbTotalAmt;
        private System.Windows.Forms.Label lbTotalQty;
        private System.Windows.Forms.Panel plpay;
        private System.Windows.Forms.Panel plSale;
        private System.Windows.Forms.Panel plSaleFlow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelhead;
        private TableLayoutPanelEx tblCardInfo;
        private System.Windows.Forms.Label lbCard;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbMoney;
    }
}