namespace ICE.POS
{
    partial class FrmHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.buttonEx1 = new ICE.POS.Common.ButtonEx(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(194, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消(Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "会员号：";
            // 
            // tbCardNo
            // 
            this.tbCardNo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCardNo.Location = new System.Drawing.Point(117, 62);
            this.tbCardNo.MaxLength = 11;
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(182, 34);
            this.tbCardNo.TabIndex = 0;
            this.tbCardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCardNo_KeyDown);
            this.tbCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCardNo_KeyPress);
            // 
            // buttonEx1
            // 
            this.buttonEx1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx1.Location = new System.Drawing.Point(44, 121);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(89, 32);
            this.buttonEx1.TabIndex = 15;
            this.buttonEx1.Text = "确定";
            this.buttonEx1.UseVisualStyleBackColor = true;
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
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
            this.lbTitle.Size = new System.Drawing.Size(326, 43);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "微信送礼---验证";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 176);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCardNo);
            this.Controls.Add(this.buttonEx1);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmHD";
            this.Text = "微信活动";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Common.ButtonEx buttonEx1;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.Label label1;
        private Common.ButtonEx btnCancel;
    }
}