using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tlpMain = new ICE.POS.Common.TableLayoutPanelEx(this.components);
            this.plLogin = new ICE.POS.Common.PanelEx(this.components);
            this.plInput = new ICE.POS.Common.PanelEx(this.components);
            this.pbEsc = new System.Windows.Forms.PictureBox();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEsc = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.tlpMain.SuspendLayout();
            this.plLogin.SuspendLayout();
            this.plInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.plLogin, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.Size = new System.Drawing.Size(784, 584);
            this.tlpMain.TabIndex = 1;
            // 
            // plLogin
            // 
            this.plLogin.BackColor = System.Drawing.Color.Transparent;
            this.plLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plLogin.Controls.Add(this.plInput);
            this.plLogin.Controls.Add(this.label1);
            this.plLogin.Controls.Add(this.btnEsc);
            this.plLogin.Controls.Add(this.btnOk);
            this.plLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plLogin.Location = new System.Drawing.Point(106, 93);
            this.plLogin.Name = "plLogin";
            this.plLogin.Size = new System.Drawing.Size(572, 396);
            this.plLogin.TabIndex = 1;
            // 
            // plInput
            // 
            this.plInput.Controls.Add(this.pbEsc);
            this.plInput.Controls.Add(this.pbOk);
            this.plInput.Controls.Add(this.lbUserName);
            this.plInput.Controls.Add(this.tbUserName);
            this.plInput.Controls.Add(this.lbPwd);
            this.plInput.Controls.Add(this.tbPwd);
            this.plInput.Location = new System.Drawing.Point(71, 113);
            this.plInput.Name = "plInput";
            this.plInput.Size = new System.Drawing.Size(234, 226);
            this.plInput.TabIndex = 3;
            // 
            // pbEsc
            // 
            this.pbEsc.Location = new System.Drawing.Point(123, 175);
            this.pbEsc.Name = "pbEsc";
            this.pbEsc.Size = new System.Drawing.Size(95, 37);
            this.pbEsc.TabIndex = 2;
            this.pbEsc.TabStop = false;
            this.pbEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // pbOk
            // 
            this.pbOk.Location = new System.Drawing.Point(14, 175);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(95, 37);
            this.pbOk.TabIndex = 2;
            this.pbOk.TabStop = false;
            this.pbOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUserName.Location = new System.Drawing.Point(3, 16);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(92, 27);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "用户名：";
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUserName.Location = new System.Drawing.Point(82, 14);
            this.tbUserName.MaxLength = 10;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(138, 33);
            this.tbUserName.TabIndex = 1;
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbPwd.Location = new System.Drawing.Point(3, 72);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(90, 27);
            this.lbPwd.TabIndex = 0;
            this.lbPwd.Text = "密   码：";
            // 
            // tbPwd
            // 
            this.tbPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPwd.Location = new System.Drawing.Point(82, 70);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(138, 33);
            this.tbPwd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(96, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 2;
            // 
            // btnEsc
            // 
            this.btnEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEsc.ForeColor = System.Drawing.Color.Transparent;
            this.btnEsc.Location = new System.Drawing.Point(194, 288);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(95, 37);
            this.btnEsc.TabIndex = 2;
            this.btnEsc.Text = "退出(&Esc)";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(85, 288);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 37);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定(&Enter)";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnEsc;
            this.ClientSize = new System.Drawing.Size(784, 584);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmLogin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.tlpMain.ResumeLayout(false);
            this.plLogin.ResumeLayout(false);
            this.plLogin.PerformLayout();
            this.plInput.ResumeLayout(false);
            this.plInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanelEx tlpMain;
        private PanelEx plLogin;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private ButtonEx btnEsc;
        private ButtonEx btnOk;
        private PanelEx plInput;
        private System.Windows.Forms.PictureBox pbEsc;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.Label label1;

    }
}