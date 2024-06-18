using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmNonTrading
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPayName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new ICE.POS.Common.TextBoxEx(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPayOut = new System.Windows.Forms.RadioButton();
            this.rbComing = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "付款名称：";
            // 
            // cbPayName
            // 
            this.cbPayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayName.FormattingEnabled = true;
            this.cbPayName.Location = new System.Drawing.Point(99, 50);
            this.cbPayName.Name = "cbPayName";
            this.cbPayName.Size = new System.Drawing.Size(189, 20);
            this.cbPayName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "金    额：";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txtAmount.ForeColor = System.Drawing.Color.Blue;
            this.txtAmount.Location = new System.Drawing.Point(99, 81);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(189, 26);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextType = 2;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "现金收支：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPayOut);
            this.groupBox1.Controls.Add(this.rbComing);
            this.groupBox1.Location = new System.Drawing.Point(99, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 40);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbPayOut
            // 
            this.rbPayOut.AutoSize = true;
            this.rbPayOut.Location = new System.Drawing.Point(100, 15);
            this.rbPayOut.Name = "rbPayOut";
            this.rbPayOut.Size = new System.Drawing.Size(71, 16);
            this.rbPayOut.TabIndex = 5;
            this.rbPayOut.TabStop = true;
            this.rbPayOut.Text = "支出(F3)";
            this.rbPayOut.UseVisualStyleBackColor = true;
            // 
            // rbComing
            // 
            this.rbComing.AutoSize = true;
            this.rbComing.Checked = true;
            this.rbComing.Location = new System.Drawing.Point(15, 15);
            this.rbComing.Name = "rbComing";
            this.rbComing.Size = new System.Drawing.Size(71, 16);
            this.rbComing.TabIndex = 4;
            this.rbComing.TabStop = true;
            this.rbComing.Text = "收入(F2)";
            this.rbComing.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "备注信息：";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(99, 158);
            this.txtMemo.MaxLength = 40;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(189, 21);
            this.txtMemo.TabIndex = 6;
            this.txtMemo.Tag = "备注";
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(50, 199);
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
            this.btnCancel.Location = new System.Drawing.Point(172, 199);
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
            this.lblTitle.Text = "非交易收入";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmNonTrading
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(320, 257);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPayName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FrmNonTrading";
            this.Load += new System.EventHandler(this.FrmNonTrading_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNonTrading_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnOk;
        private System.Windows.Forms.ComboBox cbPayName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbComing;
        private System.Windows.Forms.RadioButton rbPayOut;
        private TextBoxEx txtAmount;
        private System.Windows.Forms.TextBox txtMemo;

    }
}