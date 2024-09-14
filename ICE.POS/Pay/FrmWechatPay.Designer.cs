namespace ICE.POS
{
    partial class FrmWechatPay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wxPayAmt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mention = new System.Windows.Forms.Label();
            this.auth_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.surepay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "微信扫码支付";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wxPayAmt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mention);
            this.panel1.Controls.Add(this.auth_code);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 128);
            this.panel1.TabIndex = 1;
            // 
            // wxPayAmt
            // 
            this.wxPayAmt.AutoSize = true;
            this.wxPayAmt.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.wxPayAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(181)))), ((int)(((byte)(73)))));
            this.wxPayAmt.Location = new System.Drawing.Point(291, 11);
            this.wxPayAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wxPayAmt.Name = "wxPayAmt";
            this.wxPayAmt.Size = new System.Drawing.Size(26, 17);
            this.wxPayAmt.TabIndex = 4;
            this.wxPayAmt.Tag = "wxPayAmt";
            this.wxPayAmt.Text = "￥";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "应收款:";
            // 
            // mention
            // 
            this.mention.AutoSize = true;
            this.mention.Location = new System.Drawing.Point(12, 102);
            this.mention.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mention.Name = "mention";
            this.mention.Size = new System.Drawing.Size(0, 15);
            this.mention.TabIndex = 2;
            this.mention.Tag = "mention";
            // 
            // auth_code
            // 
            this.auth_code.Font = new System.Drawing.Font("宋体", 14F);
            this.auth_code.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.auth_code.Location = new System.Drawing.Point(12, 55);
            this.auth_code.Margin = new System.Windows.Forms.Padding(4);
            this.auth_code.MaxLength = 20;
            this.auth_code.Name = "auth_code";
            this.auth_code.Size = new System.Drawing.Size(411, 34);
            this.auth_code.TabIndex = 1;
            this.auth_code.Tag = "scancodetxt";
            this.auth_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onScancode);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "请扫描客户微信付款码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "取消支付(ESC)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.wechatpayCancle);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "查询支付状态";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkPayStatus);
            // 
            // surepay
            // 
            this.surepay.Location = new System.Drawing.Point(7, 194);
            this.surepay.Margin = new System.Windows.Forms.Padding(4);
            this.surepay.Name = "surepay";
            this.surepay.Size = new System.Drawing.Size(127, 41);
            this.surepay.TabIndex = 2;
            this.surepay.Text = "确认已支付";
            this.surepay.UseVisualStyleBackColor = true;
            this.surepay.Click += new System.EventHandler(this.paysuccess);
            // 
            // FrmWechatPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 236);
            this.Controls.Add(this.surepay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmWechatPay";
            this.Text = "微信扫码支付";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox auth_code;
        private System.Windows.Forms.Label mention;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wxPayAmt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button surepay;
    }
}