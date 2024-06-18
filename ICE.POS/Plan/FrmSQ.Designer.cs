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
            this.btnCancel.Location = new System.Drawing.Point(125, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 25);
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
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(215, 33);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "用户授权";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ShouQuan
            // 
            this.btn_ShouQuan.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ShouQuan.Location = new System.Drawing.Point(23, 126);
            this.btn_ShouQuan.Name = "btn_ShouQuan";
            this.btn_ShouQuan.Size = new System.Drawing.Size(69, 25);
            this.btn_ShouQuan.TabIndex = 15;
            this.btn_ShouQuan.Text = "授权";
            this.btn_ShouQuan.UseVisualStyleBackColor = true;
            this.btn_ShouQuan.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // tbox_Name
            // 
            this.tbox_Name.Enabled = false;
            this.tbox_Name.Location = new System.Drawing.Point(94, 45);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(100, 21);
            this.tbox_Name.TabIndex = 21;
            this.tbox_Name.Text = "1001";
            this.tbox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_Name_KeyPress);
            // 
            // tbox_PWD
            // 
            this.tbox_PWD.Location = new System.Drawing.Point(94, 83);
            this.tbox_PWD.Name = "tbox_PWD";
            this.tbox_PWD.PasswordChar = '*';
            this.tbox_PWD.Size = new System.Drawing.Size(100, 21);
            this.tbox_PWD.TabIndex = 22;
            this.tbox_PWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_PWD_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "密  码：";
            // 
            // FrmSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 164);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_PWD);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_ShouQuan);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmSD";
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