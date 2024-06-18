using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPaySavCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaySavCard));
            this.btnOk = new ButtonEx(this.components);
            this.btnCancel = new ButtonEx(this.components);
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbtips = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPass = new ButtonEx(this.components);
            this.tbxNew222 = new TextBoxEx(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.tbxNewPass = new TextBoxEx(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaxAmt = new System.Windows.Forms.Label();
            this.tbxCardNo = new TextBoxEx(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPass = new TextBoxEx(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAmt = new TextBoxEx(this.components);
            this.lbCardType = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRemain = new System.Windows.Forms.Label();
            this.btnReadIC = new ButtonEx(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyBoard = new KeyBoard();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(127, 369);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(81, 29);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确认(F8)";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(219, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbInfo.Location = new System.Drawing.Point(25, 444);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(351, 23);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtips
            // 
            this.lbtips.AutoSize = true;
            this.lbtips.Location = new System.Drawing.Point(3, 423);
            this.lbtips.Name = "lbtips";
            this.lbtips.Size = new System.Drawing.Size(491, 12);
            this.lbtips.TabIndex = 12;
            this.lbtips.Text = "如果卡类型为IC卡，请按F1读取卡号；  请按F8确认储值卡付款；  按Esc取消储值卡付款；";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
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
            this.lbTitle.Size = new System.Drawing.Size(498, 43);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "储值卡付款";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPass);
            this.groupBox1.Controls.Add(this.tbxNew222);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbxNewPass);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(5, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 60);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // btnPass
            // 
            this.btnPass.ForeColor = System.Drawing.Color.Transparent;
            this.btnPass.Location = new System.Drawing.Point(392, 19);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(81, 28);
            this.btnPass.TabIndex = 8;
            this.btnPass.Text = "修改(F6)";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // tbxNew222
            // 
            this.tbxNew222.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbxNew222.Location = new System.Drawing.Point(279, 22);
            this.tbxNew222.MaxLength = 20;
            this.tbxNew222.Name = "tbxNew222";
            this.tbxNew222.PasswordChar = '*';
            this.tbxNew222.Size = new System.Drawing.Size(95, 23);
            this.tbxNew222.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(211, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "确认密码：";
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbxNewPass.Location = new System.Drawing.Point(81, 24);
            this.tbxNewPass.MaxLength = 20;
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.PasswordChar = '*';
            this.tbxNewPass.Size = new System.Drawing.Size(95, 23);
            this.tbxNewPass.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(17, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "新密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "应    付：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡    号：";
            // 
            // lbMaxAmt
            // 
            this.lbMaxAmt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMaxAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbMaxAmt.Location = new System.Drawing.Point(92, 68);
            this.lbMaxAmt.Name = "lbMaxAmt";
            this.lbMaxAmt.Size = new System.Drawing.Size(125, 25);
            this.lbMaxAmt.TabIndex = 0;
            this.lbMaxAmt.Text = "0.00";
            this.lbMaxAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxCardNo
            // 
            this.tbxCardNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxCardNo.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbxCardNo.Location = new System.Drawing.Point(92, 11);
            this.tbxCardNo.MaxLength = 64;
            this.tbxCardNo.Name = "tbxCardNo";
            this.tbxCardNo.Size = new System.Drawing.Size(153, 26);
            this.tbxCardNo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "现付(F3)：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(266, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "卡 密 码：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPass
            // 
            this.tbxPass.Font = new System.Drawing.Font("宋体", 14.25F);
            this.tbxPass.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tbxPass.Location = new System.Drawing.Point(356, 100);
            this.tbxPass.MaxLength = 20;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(108, 29);
            this.tbxPass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(269, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "当前余额：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(551, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "会员名称：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbId
            // 
            this.lbId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbId.Location = new System.Drawing.Point(353, 45);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(125, 14);
            this.lbId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(275, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "身 份 证：";
            // 
            // tbxAmt
            // 
            this.tbxAmt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxAmt.Location = new System.Drawing.Point(95, 104);
            this.tbxAmt.MaxLength = 12;
            this.tbxAmt.Name = "tbxAmt";
            this.tbxAmt.Size = new System.Drawing.Size(107, 29);
            this.tbxAmt.TabIndex = 1;
            this.tbxAmt.Text = "1234567.00";
            this.tbxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxAmt.TextType = 2;
            // 
            // lbCardType
            // 
            this.lbCardType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCardType.Location = new System.Drawing.Point(417, 11);
            this.lbCardType.Name = "lbCardType";
            this.lbCardType.Size = new System.Drawing.Size(37, 14);
            this.lbCardType.TabIndex = 0;
            this.lbCardType.Visible = false;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(95, 46);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 14);
            this.lbName.TabIndex = 0;
            // 
            // lbRemain
            // 
            this.lbRemain.AutoSize = true;
            this.lbRemain.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.lbRemain.ForeColor = System.Drawing.Color.Red;
            this.lbRemain.Location = new System.Drawing.Point(352, 68);
            this.lbRemain.Name = "lbRemain";
            this.lbRemain.Size = new System.Drawing.Size(0, 20);
            this.lbRemain.TabIndex = 0;
            // 
            // btnReadIC
            // 
            this.btnReadIC.ForeColor = System.Drawing.Color.Transparent;
            this.btnReadIC.Location = new System.Drawing.Point(251, 11);
            this.btnReadIC.Name = "btnReadIC";
            this.btnReadIC.Size = new System.Drawing.Size(64, 26);
            this.btnReadIC.TabIndex = 10;
            this.btnReadIC.Text = "读卡(F1)";
            this.btnReadIC.UseVisualStyleBackColor = true;
            this.btnReadIC.Click += new System.EventHandler(this.btnReadIC_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(15, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "会员名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnReadIC);
            this.groupBox2.Controls.Add(this.lbRemain);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.lbCardType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxAmt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxPass);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxCardNo);
            this.groupBox2.Controls.Add(this.lbMaxAmt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(5, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 145);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(362, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "卡类型：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // keyBoard
            // 
            this.keyBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.keyBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyBoard.BackgroundImage")));
            this.keyBoard.Location = new System.Drawing.Point(83, 252);
            this.keyBoard.Name = "keyBoard";
            this.keyBoard.Size = new System.Drawing.Size(305, 164);
            this.keyBoard.TabIndex = 16;
            // 
            // FrmPaySavCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(498, 439);
            this.Controls.Add(this.keyBoard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbtips);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.KeyPreview = true;
            this.Name = "FrmPaySavCard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPaySavCard_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnOk;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbtips;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private ButtonEx btnPass;
        private TextBoxEx tbxNew222;
        private System.Windows.Forms.Label label15;
        private TextBoxEx tbxNewPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaxAmt;
        private TextBoxEx tbxCardNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private TextBoxEx tbxPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label4;
        private TextBoxEx tbxAmt;
        private System.Windows.Forms.Label lbCardType;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbRemain;
        private ButtonEx btnReadIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private KeyBoard keyBoard;
        private System.Windows.Forms.Label label2;
    }
}