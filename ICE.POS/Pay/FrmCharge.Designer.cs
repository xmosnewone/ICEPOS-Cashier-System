namespace ICE.POS
{
    partial class FrmCharge
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.lbCardNo = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnG = new ICE.POS.Common.ButtonEx(this.components);
            this.linkLabelVcode = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(297, 43);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "验证码";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(203, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(12, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 25);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确定(&Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCardNo.Location = new System.Drawing.Point(12, 71);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(84, 21);
            this.lbCardNo.TabIndex = 19;
            this.lbCardNo.Text = "验 证 码：";
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCode.Location = new System.Drawing.Point(102, 64);
            this.tbCode.MaxLength = 15;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(171, 34);
            this.tbCode.TabIndex = 16;
            // 
            // btnG
            // 
            this.btnG.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnG.ForeColor = System.Drawing.Color.Transparent;
            this.btnG.Location = new System.Drawing.Point(114, 130);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(70, 25);
            this.btnG.TabIndex = 24;
            this.btnG.Text = "挂起(&G)";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // linkLabelVcode
            // 
            this.linkLabelVcode.AutoSize = true;
            this.linkLabelVcode.Location = new System.Drawing.Point(132, 105);
            this.linkLabelVcode.Name = "linkLabelVcode";
            this.linkLabelVcode.Size = new System.Drawing.Size(137, 12);
            this.linkLabelVcode.TabIndex = 25;
            this.linkLabelVcode.TabStop = true;
            this.linkLabelVcode.Text = "未收到验证码，重新发送";
            this.linkLabelVcode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVcode_LinkClicked);
            // 
            // FrmCharge
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(297, 177);
            this.Controls.Add(this.linkLabelVcode);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmCharge";
            this.Text = "FrmCharge";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCharge_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Common.ButtonEx btnCancel;
        private Common.ButtonEx btnOK;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.TextBox tbCode;
        private Common.ButtonEx btnG;
        private System.Windows.Forms.LinkLabel linkLabelVcode;
    }
}