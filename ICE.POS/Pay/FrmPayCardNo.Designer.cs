using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPayCardNo
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
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.lbCardNo = new System.Windows.Forms.Label();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMemo = new System.Windows.Forms.Label();
            this.tbPayAmt = new System.Windows.Forms.TextBox();
            this.lbPayAmt = new System.Windows.Forms.Label();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(190, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(69, 194);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 25);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定(&Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbCardNo
            // 
            this.lbCardNo.AutoSize = true;
            this.lbCardNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCardNo.Location = new System.Drawing.Point(23, 70);
            this.lbCardNo.Name = "lbCardNo";
            this.lbCardNo.Size = new System.Drawing.Size(58, 21);
            this.lbCardNo.TabIndex = 13;
            this.lbCardNo.Text = "卡号：";
            // 
            // tbCardNo
            // 
            this.tbCardNo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCardNo.Location = new System.Drawing.Point(87, 63);
            this.tbCardNo.MaxLength = 15;
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(223, 34);
            this.tbCardNo.TabIndex = 1;
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
            this.lbTitle.Size = new System.Drawing.Size(341, 43);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "信用(银行)卡号付款";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.Location = new System.Drawing.Point(23, 109);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(58, 21);
            this.lbMemo.TabIndex = 13;
            this.lbMemo.Text = "备注：";
            // 
            // tbPayAmt
            // 
            this.tbPayAmt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPayAmt.Location = new System.Drawing.Point(87, 141);
            this.tbPayAmt.MaxLength = 15;
            this.tbPayAmt.Name = "tbPayAmt";
            this.tbPayAmt.ReadOnly = true;
            this.tbPayAmt.Size = new System.Drawing.Size(223, 34);
            this.tbPayAmt.TabIndex = 3;
            this.tbPayAmt.Text = "0.00";
            this.tbPayAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPayAmt_KeyPress);
            // 
            // lbPayAmt
            // 
            this.lbPayAmt.AutoSize = true;
            this.lbPayAmt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmt.Location = new System.Drawing.Point(23, 148);
            this.lbPayAmt.Name = "lbPayAmt";
            this.lbPayAmt.Size = new System.Drawing.Size(58, 21);
            this.lbPayAmt.TabIndex = 13;
            this.lbPayAmt.Text = "金额：";
            // 
            // tbMemo
            // 
            this.tbMemo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMemo.Location = new System.Drawing.Point(87, 103);
            this.tbMemo.MaxLength = 20;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(223, 34);
            this.tbMemo.TabIndex = 2;
            // 
            // FrmPayCardNo
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(341, 238);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbPayAmt);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.tbPayAmt);
            this.Controls.Add(this.lbCardNo);
            this.Controls.Add(this.tbCardNo);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmPayCardNo";
            this.Text = "卡类支付";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnOK;
        private System.Windows.Forms.Label lbCardNo;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.TextBox tbPayAmt;
        private System.Windows.Forms.Label lbPayAmt;
        private System.Windows.Forms.TextBox tbMemo;
    }
}