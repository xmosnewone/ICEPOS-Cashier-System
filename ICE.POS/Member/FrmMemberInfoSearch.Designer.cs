using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmMemberInfoSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEx2 = new ButtonEx(this.components);
            this.buttonEx1 = new ButtonEx(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbMem_no = new System.Windows.Forms.TextBox();
            this.btnSearch = new ButtonEx(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelEx1 = new TableLayoutPanelEx(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMemberNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMemberType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMemberLevel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMemberEmail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMemberMobile = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbMemberBalance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMemberCons = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbMemberScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 40);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员信息查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonEx2);
            this.panel2.Controls.Add(this.buttonEx1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 40);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "如果卡类型为IC卡,请按F1读取卡号";
            // 
            // buttonEx2
            // 
            this.buttonEx2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEx2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx2.Location = new System.Drawing.Point(331, 8);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(75, 23);
            this.buttonEx2.TabIndex = 1;
            this.buttonEx2.Text = "退出(&Esc)";
            this.buttonEx2.UseVisualStyleBackColor = true;
            // 
            // buttonEx1
            // 
            this.buttonEx1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx1.Location = new System.Drawing.Point(240, 8);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(75, 23);
            this.buttonEx1.TabIndex = 0;
            this.buttonEx1.Text = "确定(&F3)";
            this.buttonEx1.UseVisualStyleBackColor = true;
            this.buttonEx1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "提示：支持按卡号、手机号条件快速查询";
            // 
            // tbMem_no
            // 
            this.tbMem_no.Location = new System.Drawing.Point(17, 71);
            this.tbMem_no.Name = "tbMem_no";
            this.tbMem_no.Size = new System.Drawing.Size(314, 21);
            this.tbMem_no.TabIndex = 4;
            this.tbMem_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMem_no_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(338, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询(&F2)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanelEx1);
            this.panel3.Location = new System.Drawing.Point(17, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 183);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanelEx1
            // 
            this.tableLayoutPanelEx1.ColumnCount = 4;
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelEx1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelEx1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberId, 1, 0);
            this.tableLayoutPanelEx1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberNo, 3, 0);
            this.tableLayoutPanelEx1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberType, 1, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberName, 3, 1);
            this.tableLayoutPanelEx1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberLevel, 1, 2);
            this.tableLayoutPanelEx1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberEmail, 3, 2);
            this.tableLayoutPanelEx1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberMobile, 1, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.label12, 2, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberBalance, 3, 3);
            this.tableLayoutPanelEx1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberCons, 1, 4);
            this.tableLayoutPanelEx1.Controls.Add(this.label14, 2, 4);
            this.tableLayoutPanelEx1.Controls.Add(this.lbMemberScore, 3, 4);
            this.tableLayoutPanelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEx1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEx1.Name = "tableLayoutPanelEx1";
            this.tableLayoutPanelEx1.RowCount = 5;
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelEx1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelEx1.Size = new System.Drawing.Size(394, 181);
            this.tableLayoutPanelEx1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "编号：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberId.Location = new System.Drawing.Point(81, 0);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(112, 36);
            this.lbMemberId.TabIndex = 1;
            this.lbMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(199, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "账号：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberNo
            // 
            this.lbMemberNo.AutoSize = true;
            this.lbMemberNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberNo.Location = new System.Drawing.Point(277, 0);
            this.lbMemberNo.Name = "lbMemberNo";
            this.lbMemberNo.Size = new System.Drawing.Size(114, 36);
            this.lbMemberNo.TabIndex = 3;
            this.lbMemberNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "注册类型：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberType
            // 
            this.lbMemberType.AutoSize = true;
            this.lbMemberType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberType.Location = new System.Drawing.Point(81, 36);
            this.lbMemberType.Name = "lbMemberType";
            this.lbMemberType.Size = new System.Drawing.Size(112, 36);
            this.lbMemberType.TabIndex = 5;
            this.lbMemberType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(199, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "联系人：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberName.Location = new System.Drawing.Point(277, 36);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(114, 36);
            this.lbMemberName.TabIndex = 7;
            this.lbMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "会员等级：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberLevel
            // 
            this.lbMemberLevel.AutoSize = true;
            this.lbMemberLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberLevel.Location = new System.Drawing.Point(81, 72);
            this.lbMemberLevel.Name = "lbMemberLevel";
            this.lbMemberLevel.Size = new System.Drawing.Size(112, 36);
            this.lbMemberLevel.TabIndex = 9;
            this.lbMemberLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(199, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 36);
            this.label9.TabIndex = 10;
            this.label9.Text = "邮箱地址：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberEmail
            // 
            this.lbMemberEmail.AutoSize = true;
            this.lbMemberEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberEmail.Location = new System.Drawing.Point(277, 72);
            this.lbMemberEmail.Name = "lbMemberEmail";
            this.lbMemberEmail.Size = new System.Drawing.Size(114, 36);
            this.lbMemberEmail.TabIndex = 11;
            this.lbMemberEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 36);
            this.label10.TabIndex = 12;
            this.label10.Text = "手机号：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberMobile
            // 
            this.lbMemberMobile.AutoSize = true;
            this.lbMemberMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberMobile.Location = new System.Drawing.Point(81, 108);
            this.lbMemberMobile.Name = "lbMemberMobile";
            this.lbMemberMobile.Size = new System.Drawing.Size(112, 36);
            this.lbMemberMobile.TabIndex = 13;
            this.lbMemberMobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(199, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 36);
            this.label12.TabIndex = 14;
            this.label12.Text = "账户余额：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberBalance
            // 
            this.lbMemberBalance.AutoSize = true;
            this.lbMemberBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberBalance.Location = new System.Drawing.Point(277, 108);
            this.lbMemberBalance.Name = "lbMemberBalance";
            this.lbMemberBalance.Size = new System.Drawing.Size(114, 36);
            this.lbMemberBalance.TabIndex = 15;
            this.lbMemberBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 37);
            this.label13.TabIndex = 16;
            this.label13.Text = "历史消费总额：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberCons
            // 
            this.lbMemberCons.AutoSize = true;
            this.lbMemberCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberCons.Location = new System.Drawing.Point(81, 144);
            this.lbMemberCons.Name = "lbMemberCons";
            this.lbMemberCons.Size = new System.Drawing.Size(112, 37);
            this.lbMemberCons.TabIndex = 17;
            this.lbMemberCons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(199, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 37);
            this.label14.TabIndex = 18;
            this.label14.Text = "可用积分：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMemberScore
            // 
            this.lbMemberScore.AutoSize = true;
            this.lbMemberScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMemberScore.Location = new System.Drawing.Point(277, 144);
            this.lbMemberScore.Name = "lbMemberScore";
            this.lbMemberScore.Size = new System.Drawing.Size(114, 37);
            this.lbMemberScore.TabIndex = 19;
            this.lbMemberScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMemberInfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.CancelButton = this.buttonEx2;
            this.ClientSize = new System.Drawing.Size(430, 341);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbMem_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMemberInfoSearch";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanelEx1.ResumeLayout(false);
            this.tableLayoutPanelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ButtonEx buttonEx2;
        private ButtonEx buttonEx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMem_no;
        private ButtonEx btnSearch;
        private System.Windows.Forms.Panel panel3;
        private TableLayoutPanelEx tableLayoutPanelEx1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMemberNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMemberType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMemberLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMemberMobile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbMemberBalance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbMemberCons;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbMemberScore;
    }
}
