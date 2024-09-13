namespace ICE.POS
{
    partial class FrmAliPay2
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
            this.mention = new System.Windows.Forms.Label();
            this.auth_code = new System.Windows.Forms.TextBox();
            this.AliPayAmt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surepay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "支付宝扫码支付";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mention);
            this.panel1.Controls.Add(this.auth_code);
            this.panel1.Controls.Add(this.AliPayAmt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 128);
            this.panel1.TabIndex = 1;
            // 
            // mention
            // 
            this.mention.AutoSize = true;
            this.mention.Location = new System.Drawing.Point(11, 100);
            this.mention.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mention.Name = "mention";
            this.mention.Size = new System.Drawing.Size(0, 15);
            this.mention.TabIndex = 4;
            // 
            // auth_code
            // 
            this.auth_code.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.auth_code.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.auth_code.Location = new System.Drawing.Point(12, 55);
            this.auth_code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.auth_code.Name = "auth_code";
            this.auth_code.Size = new System.Drawing.Size(411, 35);
            this.auth_code.TabIndex = 3;
            this.auth_code.Tag = "scancodetxt";
            // 
            // AliPayAmt
            // 
            this.AliPayAmt.AutoSize = true;
            this.AliPayAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AliPayAmt.Location = new System.Drawing.Point(304, 14);
            this.AliPayAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AliPayAmt.Name = "AliPayAmt";
            this.AliPayAmt.Size = new System.Drawing.Size(22, 15);
            this.AliPayAmt.TabIndex = 2;
            this.AliPayAmt.Text = "￥";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "应收款:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "请扫描客户支付宝付款码";
            // 
            // surepay
            // 
            this.surepay.Location = new System.Drawing.Point(7, 192);
            this.surepay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surepay.Name = "surepay";
            this.surepay.Size = new System.Drawing.Size(127, 41);
            this.surepay.TabIndex = 2;
            this.surepay.Text = "确认支付";
            this.surepay.UseVisualStyleBackColor = true;
            this.surepay.Click += new System.EventHandler(this.paysuccess);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "查询支付状态";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkPayStatus);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "取消支付(ESC)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.alipayCancle);
            // 
            // FrmAliPay2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 236);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.surepay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmAliPay2";
            this.Text = "支付宝扫码支付";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AliPayAmt;
        private System.Windows.Forms.Button surepay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox auth_code;
        private System.Windows.Forms.Label mention;
    }
}