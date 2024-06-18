using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmMemberRecharge
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

        #region Windows 窗体设计器生成的代码

        
        
        
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelEx1 = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbMemberNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMemberNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMemberBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbPayAmount2 = new System.Windows.Forms.TextBox();
            this.tbPayAmount = new ICE.POS.Common.TextBoxEx(this.components);
            this.tbPayAmount1 = new ICE.POS.Common.TextBoxEx(this.components);
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(523, 284);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 56);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员卡充值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanelEx1);
            this.panel2.Location = new System.Drawing.Point(16, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 195);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanelEx1
            // 
            this.tableLayoutPanelEx1.ColumnCount = 4;
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanelEx1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanelEx1.Controls.Add(this.tbMemberNo, 1, 0);
            this.tableLayoutPanelEx1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberNo, 1, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberBalance, 3, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanelEx1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanelEx1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.label10, 2, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.comboBox1, 3, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.tbPayAmount2, 1, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.tbPayAmount, 1, 2);
            this.tableLayoutPanelEx1.Controls.Add(this.tbPayAmount1, 3, 2);
            this.tableLayoutPanelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEx1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelEx1.Name = "tableLayoutPanelEx1";
            this.tableLayoutPanelEx1.RowCount = 4;
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelEx1.Size = new System.Drawing.Size(607, 191);
            this.tableLayoutPanelEx1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "卡号：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMemberNo
            // 
            this.tbMemberNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemberNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMemberNo.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbMemberNo.Location = new System.Drawing.Point(143, 4);
            this.tbMemberNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbMemberNo.MaxLength = 15;
            this.tbMemberNo.Name = "tbMemberNo";
            this.tbMemberNo.Size = new System.Drawing.Size(155, 30);
            this.tbMemberNo.TabIndex = 1;
            this.tbMemberNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMemberNo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 47);
            this.label4.TabIndex = 2;
            this.label4.Text = "姓名：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberNo
            // 
            this.lbMemberNo.AutoSize = true;
            this.lbMemberNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemberNo.Location = new System.Drawing.Point(143, 47);
            this.lbMemberNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberNo.Name = "lbMemberNo";
            this.lbMemberNo.Size = new System.Drawing.Size(155, 47);
            this.lbMemberNo.TabIndex = 3;
            this.lbMemberNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(306, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "卡余额：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberBalance
            // 
            this.lbMemberBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberBalance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemberBalance.Location = new System.Drawing.Point(445, 47);
            this.lbMemberBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberBalance.Name = "lbMemberBalance";
            this.lbMemberBalance.Size = new System.Drawing.Size(158, 47);
            this.lbMemberBalance.TabIndex = 5;
            this.lbMemberBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 47);
            this.label7.TabIndex = 6;
            this.label7.Text = "充值金额：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(306, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 47);
            this.label8.TabIndex = 7;
            this.label8.Text = "现付：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(4, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 50);
            this.label9.TabIndex = 8;
            this.label9.Text = "赠送金额：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(306, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 50);
            this.label10.TabIndex = 9;
            this.label10.Text = "付款方式：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "人民币",
            "银行卡"});
            this.comboBox1.Location = new System.Drawing.Point(445, 145);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMemberRecharge_KeyDown);
            // 
            // tbPayAmount2
            // 
            this.tbPayAmount2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPayAmount2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPayAmount2.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbPayAmount2.Location = new System.Drawing.Point(143, 145);
            this.tbPayAmount2.Margin = new System.Windows.Forms.Padding(4);
            this.tbPayAmount2.Name = "tbPayAmount2";
            this.tbPayAmount2.ReadOnly = true;
            this.tbPayAmount2.Size = new System.Drawing.Size(155, 30);
            this.tbPayAmount2.TabIndex = 13;
            // 
            // tbPayAmount
            // 
            this.tbPayAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPayAmount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPayAmount.Location = new System.Drawing.Point(143, 98);
            this.tbPayAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbPayAmount.MaxLength = 4;
            this.tbPayAmount.Name = "tbPayAmount";
            this.tbPayAmount.Size = new System.Drawing.Size(155, 30);
            this.tbPayAmount.TabIndex = 2;
            this.tbPayAmount.TextType = 2;
            this.tbPayAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMemberRecharge_KeyDown);
            // 
            // tbPayAmount1
            // 
            this.tbPayAmount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPayAmount1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPayAmount1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbPayAmount1.Location = new System.Drawing.Point(445, 98);
            this.tbPayAmount1.Margin = new System.Windows.Forms.Padding(4);
            this.tbPayAmount1.Name = "tbPayAmount1";
            this.tbPayAmount1.Size = new System.Drawing.Size(158, 30);
            this.tbPayAmount1.TabIndex = 3;
            this.tbPayAmount1.TextType = 2;
            this.tbPayAmount1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMemberRecharge_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(396, 284);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 29);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确认(&F2)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "如果卡类型为IC卡,请按F1读取卡号";
            // 
            // FrmMemberRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(644, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMemberRecharge";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMemberRecharge_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanelEx1.ResumeLayout(false);
            this.tableLayoutPanelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ButtonEx btnOk;
        private System.Windows.Forms.Label label2;
        private TableLayoutPanelEx tableLayoutPanelEx1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMemberNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMemberNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMemberBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbPayAmount2;
        private TextBoxEx tbPayAmount;
        private TextBoxEx tbPayAmount1;
    }
}
