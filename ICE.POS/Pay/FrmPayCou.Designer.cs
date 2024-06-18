using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPayCou
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
            this.btnCancel = new ButtonEx(this.components);
            this.btnOK = new ButtonEx(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMemo = new System.Windows.Forms.Label();
            this.tbWaitPayAmt = new TextBoxEx(this.components);
            this.lbPayAmt = new System.Windows.Forms.Label();
            this.lbWaitPayAmt = new System.Windows.Forms.Label();
            this.tbPayAmt = new TextBoxEx(this.components);
            this.tbMemo = new TextBoxEx(this.components);
            this.lbCouponNo = new System.Windows.Forms.Label();
            this.tbCouponNo = new TextBoxEx(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(178, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(57, 233);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 25);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "确定(&Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.lbTitle.Size = new System.Drawing.Size(322, 43);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "<购物券>付款";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.Location = new System.Drawing.Point(10, 187);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(88, 21);
            this.lbMemo.TabIndex = 13;
            this.lbMemo.Text = "备      注：";
            // 
            // tbWaitPayAmt
            // 
            this.tbWaitPayAmt.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.tbWaitPayAmt.Location = new System.Drawing.Point(99, 136);
            this.tbWaitPayAmt.Name = "tbWaitPayAmt";
            this.tbWaitPayAmt.ReadOnly = true;
            this.tbWaitPayAmt.Size = new System.Drawing.Size(197, 34);
            this.tbWaitPayAmt.TabIndex = 17;
            this.tbWaitPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWaitPayAmt.TextType = 2;
            this.tbWaitPayAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayAmt_KeyDown);
            // 
            // lbPayAmt
            // 
            this.lbPayAmt.AutoSize = true;
            this.lbPayAmt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmt.Location = new System.Drawing.Point(10, 100);
            this.lbPayAmt.Name = "lbPayAmt";
            this.lbPayAmt.Size = new System.Drawing.Size(88, 21);
            this.lbPayAmt.TabIndex = 13;
            this.lbPayAmt.Text = "面      额：";
            // 
            // lbWaitPayAmt
            // 
            this.lbWaitPayAmt.AutoSize = true;
            this.lbWaitPayAmt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWaitPayAmt.Location = new System.Drawing.Point(10, 143);
            this.lbWaitPayAmt.Name = "lbWaitPayAmt";
            this.lbWaitPayAmt.Size = new System.Drawing.Size(88, 21);
            this.lbWaitPayAmt.TabIndex = 13;
            this.lbWaitPayAmt.Text = "待      付：";
            // 
            // tbPayAmt
            // 
            this.tbPayAmt.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.tbPayAmt.Location = new System.Drawing.Point(99, 93);
            this.tbPayAmt.Name = "tbPayAmt";
            this.tbPayAmt.Size = new System.Drawing.Size(197, 34);
            this.tbPayAmt.TabIndex = 17;
            this.tbPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPayAmt.TextType = 2;
            this.tbPayAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayAmt_KeyDown);
            // 
            // tbMemo
            // 
            this.tbMemo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.tbMemo.Location = new System.Drawing.Point(99, 180);
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(197, 34);
            this.tbMemo.TabIndex = 17;
            this.tbMemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayAmt_KeyDown);
            // 
            // lbCouponNo
            // 
            this.lbCouponNo.AutoSize = true;
            this.lbCouponNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCouponNo.Location = new System.Drawing.Point(10, 54);
            this.lbCouponNo.Name = "lbCouponNo";
            this.lbCouponNo.Size = new System.Drawing.Size(88, 21);
            this.lbCouponNo.TabIndex = 13;
            this.lbCouponNo.Text = "券      号：";
            // 
            // tbCouponNo
            // 
            this.tbCouponNo.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.tbCouponNo.Location = new System.Drawing.Point(99, 47);
            this.tbCouponNo.Name = "tbCouponNo";
            this.tbCouponNo.Size = new System.Drawing.Size(197, 34);
            this.tbCouponNo.TabIndex = 17;
            this.tbCouponNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCouponNo.TextType = 2;
            this.tbCouponNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayAmt_KeyDown);
            // 
            // FrmPayCou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(322, 270);
            this.ControlBox = false;
            this.Controls.Add(this.tbCouponNo);
            this.Controls.Add(this.tbPayAmt);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbWaitPayAmt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.lbWaitPayAmt);
            this.Controls.Add(this.lbCouponNo);
            this.Controls.Add(this.lbPayAmt);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmPayCou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "卡类支付";
            this.Load += new System.EventHandler(this.FrmPayWay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnOK;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMemo;
        private TextBoxEx tbWaitPayAmt;
        private System.Windows.Forms.Label lbPayAmt;
        private System.Windows.Forms.Label lbWaitPayAmt;
        private TextBoxEx tbPayAmt;
        private TextBoxEx tbMemo;
        private System.Windows.Forms.Label lbCouponNo;
        private TextBoxEx tbCouponNo;
    }
}