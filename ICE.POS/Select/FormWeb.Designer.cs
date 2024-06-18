namespace ICE.POS
{
    partial class FormWeb
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
            this.Btn_Success = new System.Windows.Forms.Button();
            this.Btn_Failing = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Btn_Success
            // 
            this.Btn_Success.Location = new System.Drawing.Point(337, 595);
            this.Btn_Success.Name = "Btn_Success";
            this.Btn_Success.Size = new System.Drawing.Size(75, 23);
            this.Btn_Success.TabIndex = 1;
            this.Btn_Success.Text = "支付成功";
            this.Btn_Success.UseVisualStyleBackColor = true;
            this.Btn_Success.Click += new System.EventHandler(this.Btn_Success_Click);
            // 
            // Btn_Failing
            // 
            this.Btn_Failing.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Failing.Location = new System.Drawing.Point(508, 595);
            this.Btn_Failing.Name = "Btn_Failing";
            this.Btn_Failing.Size = new System.Drawing.Size(75, 23);
            this.Btn_Failing.TabIndex = 2;
            this.Btn_Failing.Text = "支付失败";
            this.Btn_Failing.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(24, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(898, 589);
            this.webBrowser2.TabIndex = 3;
            // 
            // FormWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Failing;
            this.ClientSize = new System.Drawing.Size(927, 630);
            this.ControlBox = false;
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.Btn_Failing);
            this.Controls.Add(this.Btn_Success);
            this.Name = "FormWeb";
            this.ShowIcon = false;
            this.Text = "支付结果显示";
            this.Load += new System.EventHandler(this.FormWeb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Success;
        private System.Windows.Forms.Button Btn_Failing;
        public System.Windows.Forms.WebBrowser webBrowser2;
    }
}