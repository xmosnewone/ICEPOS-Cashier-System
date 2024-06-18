namespace ICE.POS
{
    partial class FrmPayWayAlter
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

        #region Windows 窗体设计器生成的代码

        
        
        
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbox_PayWay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.btn_OK = new ICE.POS.Common.ButtonEx(this.components);
            this.btn_ESC = new ICE.POS.Common.ButtonEx(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 36);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "修改交易数据";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "支付方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "支付金额：";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(93, 89);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(128, 21);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // cbox_PayWay
            // 
            this.cbox_PayWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_PayWay.FormattingEnabled = true;
            this.cbox_PayWay.Items.AddRange(new object[] {
            "人民币现金"});
            this.cbox_PayWay.Location = new System.Drawing.Point(93, 53);
            this.cbox_PayWay.Name = "cbox_PayWay";
            this.cbox_PayWay.Size = new System.Drawing.Size(128, 20);
            this.cbox_PayWay.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "备    注：";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(93, 125);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(128, 21);
            this.txtMemo.TabIndex = 20;
            this.txtMemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // btn_OK
            // 
            this.btn_OK.ForeColor = System.Drawing.Color.Transparent;
            this.btn_OK.Location = new System.Drawing.Point(24, 163);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(79, 23);
            this.btn_OK.TabIndex = 21;
            this.btn_OK.Text = "确定(&Enter)";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_ESC
            // 
            this.btn_ESC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ESC.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ESC.Location = new System.Drawing.Point(142, 163);
            this.btn_ESC.Name = "btn_ESC";
            this.btn_ESC.Size = new System.Drawing.Size(79, 23);
            this.btn_ESC.TabIndex = 22;
            this.btn_ESC.Text = "取消(&Esc)";
            this.btn_ESC.UseVisualStyleBackColor = true;
            // 
            // FrmPayWayAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(242, 202);
            this.Controls.Add(this.btn_ESC);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_PayWay);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmPayWayAlter";
            this.Load += new System.EventHandler(this.FrmPayWayAlter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbox_PayWay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemo;
        private Common.ButtonEx btn_OK;
        private Common.ButtonEx btn_ESC;
    }
}
