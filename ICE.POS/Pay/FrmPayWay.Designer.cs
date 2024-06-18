using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPayWay
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
            this.lbPayAmt = new System.Windows.Forms.Label();
            this.cbPayWay = new System.Windows.Forms.ComboBox();
            this.tbPayAmt = new TextBoxEx(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(192, 152);
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
            this.btnOK.Location = new System.Drawing.Point(71, 152);
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
            this.lbTitle.Size = new System.Drawing.Size(341, 43);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "请选择付款方式";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.Location = new System.Drawing.Point(12, 62);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(90, 21);
            this.lbMemo.TabIndex = 13;
            this.lbMemo.Text = "付款方式：";
            // 
            // lbPayAmt
            // 
            this.lbPayAmt.AutoSize = true;
            this.lbPayAmt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayAmt.Location = new System.Drawing.Point(12, 112);
            this.lbPayAmt.Name = "lbPayAmt";
            this.lbPayAmt.Size = new System.Drawing.Size(88, 21);
            this.lbPayAmt.TabIndex = 13;
            this.lbPayAmt.Text = "金      额：";
            // 
            // cbPayWay
            // 
            this.cbPayWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayWay.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.cbPayWay.FormattingEnabled = true;
            this.cbPayWay.Location = new System.Drawing.Point(122, 56);
            this.cbPayWay.Name = "cbPayWay";
            this.cbPayWay.Size = new System.Drawing.Size(197, 35);
            this.cbPayWay.TabIndex = 16;
            this.cbPayWay.SelectedIndexChanged += new System.EventHandler(this.cbPayWay_SelectedIndexChanged);
            // 
            // tbPayAmt
            // 
            this.tbPayAmt.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.tbPayAmt.Location = new System.Drawing.Point(122, 105);
            this.tbPayAmt.Name = "tbPayAmt";
            this.tbPayAmt.ReadOnly = true;
            this.tbPayAmt.Size = new System.Drawing.Size(197, 34);
            this.tbPayAmt.TabIndex = 17;
            this.tbPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPayAmt.TextType = 2;
            this.tbPayAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPayAmt_KeyDown);
            // 
            // FrmPayWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(341, 195);
            this.ControlBox = false;
            this.Controls.Add(this.tbPayAmt);
            this.Controls.Add(this.cbPayWay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbPayAmt);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmPayWay";
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
        private System.Windows.Forms.Label lbPayAmt;
        private System.Windows.Forms.ComboBox cbPayWay;
        private TextBoxEx tbPayAmt;
    }
}