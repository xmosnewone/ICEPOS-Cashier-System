using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPayBalance
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
            this.lbPayAmt = new System.Windows.Forms.Label();
            this.tbMemberBalance = new ICE.POS.Common.TextBoxEx(this.components);
            this.lbMemo = new System.Windows.Forms.Label();
            this.tbPayAmt = new ICE.POS.Common.TextBoxEx(this.components);
            this.lbCardNo = new System.Windows.Forms.Label();
            this.tbMemberName = new ICE.POS.Common.TextBoxEx(this.components);
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
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
            this.lbTitle.Size = new System.Drawing.Size(333, 43);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "余额付款";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPayAmt
            // 
            this.lbPayAmt.AutoSize = true;
            this.lbPayAmt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmt.Location = new System.Drawing.Point(25, 153);
            this.lbPayAmt.Name = "lbPayAmt";
            this.lbPayAmt.Size = new System.Drawing.Size(58, 21);
            this.lbPayAmt.TabIndex = 17;
            this.lbPayAmt.Text = "金额：";
            // 
            // tbMemberBalance
            // 
            this.tbMemberBalance.Enabled = false;
            this.tbMemberBalance.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMemberBalance.Location = new System.Drawing.Point(89, 108);
            this.tbMemberBalance.MaxLength = 20;
            this.tbMemberBalance.Name = "tbMemberBalance";
            this.tbMemberBalance.ReadOnly = true;
            this.tbMemberBalance.Size = new System.Drawing.Size(223, 34);
            this.tbMemberBalance.TabIndex = 15;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.Location = new System.Drawing.Point(25, 114);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(58, 21);
            this.lbMemo.TabIndex = 19;
            this.lbMemo.Text = "余额：";
            // 
            // tbPayAmt
            // 
            this.tbPayAmt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPayAmt.Location = new System.Drawing.Point(89, 146);
            this.tbPayAmt.MaxLength = 15;
            this.tbPayAmt.Name = "tbPayAmt";
            this.tbPayAmt.Size = new System.Drawing.Size(223, 34);
            this.tbPayAmt.TabIndex = 16;
            this.tbPayAmt.Text = "0.00";
            this.tbPayAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayAmt_KeyDown);
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCardNo.Location = new System.Drawing.Point(25, 75);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(58, 21);
            this.lbCardNo.TabIndex = 18;
            this.lbCardNo.Text = "会员：";
            // 
            // tbMemberName
            // 
            this.tbMemberName.Enabled = false;
            this.tbMemberName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMemberName.Location = new System.Drawing.Point(89, 68);
            this.tbMemberName.MaxLength = 15;
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.ReadOnly = true;
            this.tbMemberName.Size = new System.Drawing.Size(223, 34);
            this.tbMemberName.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(186, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 25);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(65, 194);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 25);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "确定(&Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmPayBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 236);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbPayAmt);
            this.Controls.Add(this.tbMemberBalance);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.tbPayAmt);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmPayBalance";
            this.Text = "余额支付";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbPayAmt;
        private TextBoxEx tbMemberBalance;
        private System.Windows.Forms.Label lbMemo;
        private TextBoxEx tbPayAmt;
        private System.Windows.Forms.Label lbCardNo;
        private TextBoxEx tbMemberName;
        private ButtonEx btnCancel;
        private ButtonEx btnOK;
    }
}