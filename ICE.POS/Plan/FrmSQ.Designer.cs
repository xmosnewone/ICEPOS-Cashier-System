namespace ICE.POS
{
    partial class FrmSQ
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btn_ShouQuan = new ICE.POS.Common.ButtonEx(this.components);
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.tbox_PWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(167, 158);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消(Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(287, 41);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "用户授权";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ShouQuan
            // 
            this.btn_ShouQuan.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ShouQuan.Location = new System.Drawing.Point(31, 158);
            this.btn_ShouQuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ShouQuan.Name = "btn_ShouQuan";
            this.btn_ShouQuan.Size = new System.Drawing.Size(92, 31);
            this.btn_ShouQuan.TabIndex = 15;
            this.btn_ShouQuan.Text = "授权";
            this.btn_ShouQuan.UseVisualStyleBackColor = true;
            this.btn_ShouQuan.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // tbox_Name
            // 
            this.tbox_Name.Enabled = false;
            this.tbox_Name.Location = new System.Drawing.Point(125, 56);
            this.tbox_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(132, 25);
            this.tbox_Name.TabIndex = 21;
            this.tbox_Name.Text = "1001";
            this.tbox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_Name_KeyPress);
            // 
            // tbox_PWD
            // 
            this.tbox_PWD.Location = new System.Drawing.Point(125, 104);
            this.tbox_PWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbox_PWD.Name = "tbox_PWD";
            this.tbox_PWD.PasswordChar = '*';
            this.tbox_PWD.Size = new System.Drawing.Size(132, 25);
            this.tbox_PWD.TabIndex = 1;
            this.tbox_PWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_PWD_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "密  码：";
            // 
            // FrmSQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_PWD);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_ShouQuan);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmSQ";
            this.Text = "用户授权";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private Common.ButtonEx btnCancel;
        private Common.ButtonEx btn_ShouQuan;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.TextBox tbox_PWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}