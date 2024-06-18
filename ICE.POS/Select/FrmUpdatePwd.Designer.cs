using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmUpdatePwd
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
            this.lbSaleMan = new System.Windows.Forms.Label();
            this.lbOldPwd = new System.Windows.Forms.Label();
            this.tbOldPwd = new ICE.POS.Common.TextBoxEx(this.components);
            this.lbNewPwd = new System.Windows.Forms.Label();
            this.lbReNewPwd = new System.Windows.Forms.Label();
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbSaleMan = new ICE.POS.Common.TextBoxEx(this.components);
            this.tbNewPwd = new ICE.POS.Common.TextBoxEx(this.components);
            this.tbReNewPwd = new ICE.POS.Common.TextBoxEx(this.components);
            this.SuspendLayout();
            // 
            // lbSaleMan
            // 
            this.lbSaleMan.AutoSize = true;
            this.lbSaleMan.Location = new System.Drawing.Point(55, 53);
            this.lbSaleMan.Name = "lbSaleMan";
            this.lbSaleMan.Size = new System.Drawing.Size(53, 12);
            this.lbSaleMan.TabIndex = 10;
            this.lbSaleMan.Text = "收银员：";
            // 
            // lbOldPwd
            // 
            this.lbOldPwd.AutoSize = true;
            this.lbOldPwd.Location = new System.Drawing.Point(55, 88);
            this.lbOldPwd.Name = "lbOldPwd";
            this.lbOldPwd.Size = new System.Drawing.Size(53, 12);
            this.lbOldPwd.TabIndex = 9;
            this.lbOldPwd.Text = "原密码：";
            // 
            // tbOldPwd
            // 
            this.tbOldPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOldPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.tbOldPwd.ForeColor = System.Drawing.Color.Blue;
            this.tbOldPwd.Location = new System.Drawing.Point(114, 81);
            this.tbOldPwd.MaxLength = 10;
            this.tbOldPwd.Multiline = true;
            this.tbOldPwd.Name = "tbOldPwd";
            this.tbOldPwd.PasswordChar = '*';
            this.tbOldPwd.Size = new System.Drawing.Size(131, 21);
            this.tbOldPwd.TabIndex = 1;
            // 
            // lbNewPwd
            // 
            this.lbNewPwd.AutoSize = true;
            this.lbNewPwd.Location = new System.Drawing.Point(55, 126);
            this.lbNewPwd.Name = "lbNewPwd";
            this.lbNewPwd.Size = new System.Drawing.Size(53, 12);
            this.lbNewPwd.TabIndex = 8;
            this.lbNewPwd.Text = "新密码：";
            // 
            // lbReNewPwd
            // 
            this.lbReNewPwd.AutoSize = true;
            this.lbReNewPwd.Location = new System.Drawing.Point(31, 161);
            this.lbReNewPwd.Name = "lbReNewPwd";
            this.lbReNewPwd.Size = new System.Drawing.Size(77, 12);
            this.lbReNewPwd.TabIndex = 7;
            this.lbReNewPwd.Text = "重复新密码：";
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(57, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 28);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "确定(Enter)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(171, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消(Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.lblTitle.Size = new System.Drawing.Size(320, 36);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "修改密码";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSaleMan
            // 
            this.tbSaleMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSaleMan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.tbSaleMan.ForeColor = System.Drawing.Color.Blue;
            this.tbSaleMan.Location = new System.Drawing.Point(114, 46);
            this.tbSaleMan.MaxLength = 8;
            this.tbSaleMan.Multiline = true;
            this.tbSaleMan.Name = "tbSaleMan";
            this.tbSaleMan.ReadOnly = true;
            this.tbSaleMan.Size = new System.Drawing.Size(131, 21);
            this.tbSaleMan.TabIndex = 2;
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.tbNewPwd.ForeColor = System.Drawing.Color.Blue;
            this.tbNewPwd.Location = new System.Drawing.Point(114, 119);
            this.tbNewPwd.MaxLength = 10;
            this.tbNewPwd.Multiline = true;
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.PasswordChar = '*';
            this.tbNewPwd.Size = new System.Drawing.Size(131, 21);
            this.tbNewPwd.TabIndex = 2;
            // 
            // tbReNewPwd
            // 
            this.tbReNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReNewPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.tbReNewPwd.ForeColor = System.Drawing.Color.Blue;
            this.tbReNewPwd.Location = new System.Drawing.Point(114, 161);
            this.tbReNewPwd.MaxLength = 10;
            this.tbReNewPwd.Multiline = true;
            this.tbReNewPwd.Name = "tbReNewPwd";
            this.tbReNewPwd.PasswordChar = '*';
            this.tbReNewPwd.Size = new System.Drawing.Size(131, 21);
            this.tbReNewPwd.TabIndex = 2;
            // 
            // FrmUpdatePwd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(320, 257);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbReNewPwd);
            this.Controls.Add(this.lbNewPwd);
            this.Controls.Add(this.tbReNewPwd);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.tbSaleMan);
            this.Controls.Add(this.tbOldPwd);
            this.Controls.Add(this.lbOldPwd);
            this.Controls.Add(this.lbSaleMan);
            this.KeyPreview = true;
            this.Name = "FrmUpdatePwd";
            this.Load += new System.EventHandler(this.FrmUpdatePwd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUpdatePwd_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnOk;
        private System.Windows.Forms.Label lbSaleMan;
        private System.Windows.Forms.Label lbOldPwd;
        private System.Windows.Forms.Label lbNewPwd;
        private System.Windows.Forms.Label lbReNewPwd;
        private System.Windows.Forms.Label lblTitle;
        private TextBoxEx tbOldPwd;
        private TextBoxEx tbSaleMan;
        private TextBoxEx tbNewPwd;
        private TextBoxEx tbReNewPwd;

    }
}