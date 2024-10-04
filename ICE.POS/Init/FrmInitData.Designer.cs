using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmInitData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInitData));
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.cbbPOS = new System.Windows.Forms.ComboBox();
            this.btnTest = new ICE.POS.Common.ButtonEx(this.components);
            this.plMain = new System.Windows.Forms.Panel();
            this.lbWWW = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(400, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Tag = "ca";
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Enabled = false;
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(291, 185);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 29);
            this.btnOk.TabIndex = 12;
            this.btnOk.Tag = "ok";
            this.btnOk.Text = "完成";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "门      店：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(43, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "POS     机：";
            // 
            // cbbBranch
            // 
            this.cbbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(181, 109);
            this.cbbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(316, 23);
            this.cbbBranch.TabIndex = 34;
            this.cbbBranch.Tag = "branch";
            this.cbbBranch.SelectedIndexChanged += new System.EventHandler(this.cbbBranch_SelectedIndexChanged);
            // 
            // cbbPOS
            // 
            this.cbbPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPOS.FormattingEnabled = true;
            this.cbbPOS.Location = new System.Drawing.Point(181, 148);
            this.cbbPOS.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPOS.Name = "cbbPOS";
            this.cbbPOS.Size = new System.Drawing.Size(316, 23);
            this.cbbPOS.TabIndex = 35;
            this.cbbPOS.Tag = "pos";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTest.ForeColor = System.Drawing.Color.Transparent;
            this.btnTest.Location = new System.Drawing.Point(183, 185);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 29);
            this.btnTest.TabIndex = 36;
            this.btnTest.Tag = "co";
            this.btnTest.Text = "连接";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.plMain.Controls.Add(this.lbWWW);
            this.plMain.Controls.Add(this.txtServerUrl);
            this.plMain.Controls.Add(this.picLogo);
            this.plMain.Controls.Add(this.btnTest);
            this.plMain.Controls.Add(this.cbbPOS);
            this.plMain.Controls.Add(this.cbbBranch);
            this.plMain.Controls.Add(this.btnOk);
            this.plMain.Controls.Add(this.label3);
            this.plMain.Controls.Add(this.btnCancel);
            this.plMain.Controls.Add(this.label2);
            this.plMain.Location = new System.Drawing.Point(7, 5);
            this.plMain.Margin = new System.Windows.Forms.Padding(4);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(543, 240);
            this.plMain.TabIndex = 37;
            // 
            // lbWWW
            // 
            this.lbWWW.AutoSize = true;
            this.lbWWW.BackColor = System.Drawing.Color.Transparent;
            this.lbWWW.Location = new System.Drawing.Point(41, 78);
            this.lbWWW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWWW.Name = "lbWWW";
            this.lbWWW.Size = new System.Drawing.Size(100, 15);
            this.lbWWW.TabIndex = 38;
            this.lbWWW.Text = "网      址：";
            this.lbWWW.Visible = false;
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtServerUrl.Location = new System.Drawing.Point(181, 74);
            this.txtServerUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(316, 25);
            this.txtServerUrl.TabIndex = 37;
            this.txtServerUrl.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = global::ICE.POS.Properties.Resources.init;
            this.picLogo.Location = new System.Drawing.Point(28, 5);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(487, 89);
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // FrmInitData
            // 
            this.AcceptButton = this.btnTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(553, 250);
            this.Controls.Add(this.plMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInitData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS初始化";
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnOk;
        private ButtonEx btnTest;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.ComboBox cbbPOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWWW;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.TextBox txtServerUrl;
    }
}