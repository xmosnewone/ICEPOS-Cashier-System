namespace ICE.POS
{
    partial class FrmFeedBack
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonEx1 = new ICE.POS.Common.ButtonEx(this.components);
            this.buttonEx2 = new ICE.POS.Common.ButtonEx(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "反馈信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "(提示:限制50个字)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 21);
            this.richTextBox1.MaxLength = 50;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 88);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonEx1
            // 
            this.buttonEx1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx1.Location = new System.Drawing.Point(207, 192);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(79, 23);
            this.buttonEx1.TabIndex = 1;
            this.buttonEx1.Text = "确定(&Enter)";
            this.buttonEx1.UseVisualStyleBackColor = true;
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // buttonEx2
            // 
            this.buttonEx2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEx2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx2.Location = new System.Drawing.Point(316, 192);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(75, 23);
            this.buttonEx2.TabIndex = 2;
            this.buttonEx2.Text = "取消(&Esc)";
            this.buttonEx2.UseVisualStyleBackColor = true;
            this.buttonEx2.Click += new System.EventHandler(this.buttonEx2_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(425, 36);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "提交反馈";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFeedBack
            // 
            this.AcceptButton = this.buttonEx1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.CancelButton = this.buttonEx2;
            this.ClientSize = new System.Drawing.Size(425, 223);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.buttonEx2);
            this.Controls.Add(this.buttonEx1);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FrmFeedBack";
            this.Load += new System.EventHandler(this.FrmFeedBack_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Common.ButtonEx buttonEx1;
        private Common.ButtonEx buttonEx2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;

    }
}
