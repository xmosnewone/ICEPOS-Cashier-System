using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmAccount 
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMoney = new ICE.POS.Common.TextBoxEx(this.components);
            this.rbItem = new System.Windows.Forms.RadioButton();
            this.rbAcc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lbTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.listBox = new System.Windows.Forms.ListBox();
            this.chkCashBox = new System.Windows.Forms.CheckBox();
            this.btnPrint = new ICE.POS.Common.ButtonEx(this.components);
            this.btnClose = new ICE.POS.Common.ButtonEx(this.components);
            this.btnAccount = new ICE.POS.Common.ButtonEx(this.components);
            this.btnQuery = new ICE.POS.Common.ButtonEx(this.components);
            this.lbFrom = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 530);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 33);
            this.panel2.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(3, 0, 12, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(499, 33);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "收银对账单";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMoney);
            this.panel1.Controls.Add(this.rbItem);
            this.panel1.Controls.Add(this.rbAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.lbTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Controls.Add(this.chkCashBox);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.lbFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 497);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "金额：";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(305, 72);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(100, 21);
            this.tbMoney.TabIndex = 13;
            this.tbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // rbItem
            // 
            this.rbItem.AutoSize = true;
            this.rbItem.Location = new System.Drawing.Point(319, 42);
            this.rbItem.Name = "rbItem";
            this.rbItem.Size = new System.Drawing.Size(95, 16);
            this.rbItem.TabIndex = 12;
            this.rbItem.TabStop = true;
            this.rbItem.Text = "商品对账(F7)";
            this.rbItem.UseVisualStyleBackColor = true;
            this.rbItem.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbAcc
            // 
            this.rbAcc.AutoSize = true;
            this.rbAcc.Location = new System.Drawing.Point(217, 42);
            this.rbAcc.Name = "rbAcc";
            this.rbAcc.Size = new System.Drawing.Size(95, 16);
            this.rbAcc.TabIndex = 11;
            this.rbAcc.TabStop = true;
            this.rbAcc.Text = "收银对账(F6)";
            this.rbAcc.UseVisualStyleBackColor = true;
            this.rbAcc.CheckedChanged += new System.EventHandler(this.rbAcc_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "操作提示：进行收银对帐时请点[对帐]按钮即可";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(249, 10);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(165, 21);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTo_KeyDown);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(213, 14);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(35, 12);
            this.lbTo.TabIndex = 2;
            this.lbTo.Text = "结束:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(44, 10);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(168, 21);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFrom_KeyDown);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(8, 109);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox.Size = new System.Drawing.Size(481, 364);
            this.listBox.TabIndex = 9;
            // 
            // chkCashBox
            // 
            this.chkCashBox.AutoSize = true;
            this.chkCashBox.Location = new System.Drawing.Point(11, 42);
            this.chkCashBox.Name = "chkCashBox";
            this.chkCashBox.Size = new System.Drawing.Size(156, 16);
            this.chkCashBox.TabIndex = 5;
            this.chkCashBox.Text = "打印对账单后开钱箱(F5)";
            this.chkCashBox.UseVisualStyleBackColor = true;
            this.chkCashBox.CheckedChanged += new System.EventHandler(this.chkCashBox_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrint.Location = new System.Drawing.Point(12, 69);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(69, 25);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "打印(F2)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(143, 69);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 25);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "返回(Esc)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccount.Location = new System.Drawing.Point(420, 68);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(69, 25);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "对帐(F4)";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuery.Location = new System.Drawing.Point(420, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(69, 25);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询(F3)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(9, 14);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(35, 12);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "开始:";
            // 
            // FrmAccount
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(499, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FrmAccount";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAccount_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ButtonEx btnAccount;
        private ButtonEx btnClose;
        private ButtonEx btnPrint;
        private ButtonEx btnQuery;
        private System.Windows.Forms.CheckBox chkCashBox;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAcc;
        private System.Windows.Forms.RadioButton rbItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private TextBoxEx tbMoney;
    }
}