namespace ICE.POS
{
    partial class FrmAliPay
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_send = new ICE.POS.Common.ButtonEx(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbPayAmt = new ICE.POS.Common.TextBoxEx(this.components);
            this.lbPayAmt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(338, 43);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "支付宝付款";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(225, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 25);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消支付(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(11, 146);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 25);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "支付成功(&Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(93, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "请提示顾客扫码支付！";
            // 
            // Btn_send
            // 
            this.Btn_send.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_send.Location = new System.Drawing.Point(118, 146);
            this.Btn_send.Name = "Btn_send";
            this.Btn_send.Size = new System.Drawing.Size(101, 25);
            this.Btn_send.TabIndex = 25;
            this.Btn_send.Text = "查询支付状态";
            this.Btn_send.UseVisualStyleBackColor = true;
            this.Btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbPayAmt
            // 
            this.tbPayAmt.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.tbPayAmt.Location = new System.Drawing.Point(126, 91);
            this.tbPayAmt.Name = "tbPayAmt";
            this.tbPayAmt.ReadOnly = true;
            this.tbPayAmt.Size = new System.Drawing.Size(197, 34);
            this.tbPayAmt.TabIndex = 28;
            this.tbPayAmt.TextType = 2;
            // 
            // lbPayAmt
            // 
            this.lbPayAmt.AutoSize = true;
            this.lbPayAmt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmt.Location = new System.Drawing.Point(16, 98);
            this.lbPayAmt.Name = "lbPayAmt";
            this.lbPayAmt.Size = new System.Drawing.Size(88, 21);
            this.lbPayAmt.TabIndex = 27;
            this.lbPayAmt.Text = "金      额：";
            // 
            // FrmAliPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(338, 189);
            this.Controls.Add(this.tbPayAmt);
            this.Controls.Add(this.lbPayAmt);
            this.Controls.Add(this.Btn_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbTitle);
            this.KeyPreview = true;
            this.Name = "FrmAliPay";
            this.Text = "支付宝支付";
            this.Load += new System.EventHandler(this.FrmAliPay_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAliPay_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Common.ButtonEx btnCancel;
        private Common.ButtonEx btnOK;
        private System.Windows.Forms.Label label1;
        private Common.ButtonEx Btn_send;
        private System.Windows.Forms.Timer timer1;
        private Common.TextBoxEx tbPayAmt;
        private System.Windows.Forms.Label lbPayAmt;
    }
}
