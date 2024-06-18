namespace ICE.POS
{
    partial class FrmPrint
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedtboxIP = new System.Windows.Forms.MaskedTextBox();
            this.cboxQD = new System.Windows.Forms.ComboBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelQD = new System.Windows.Forms.Label();
            this.labelUSB = new System.Windows.Forms.Label();
            this.cboxUSB = new System.Windows.Forms.ComboBox();
            this.cboxBK = new System.Windows.Forms.ComboBox();
            this.labelBK = new System.Windows.Forms.Label();
            this.cboxCK = new System.Windows.Forms.ComboBox();
            this.labelCK = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQD = new System.Windows.Forms.RadioButton();
            this.radioButtonWK = new System.Windows.Forms.RadioButton();
            this.radioButtonUSB = new System.Windows.Forms.RadioButton();
            this.radioButtonBK = new System.Windows.Forms.RadioButton();
            this.radioButtonCK = new System.Windows.Forms.RadioButton();
            this.button1 = new ICE.POS.Common.ButtonEx(this.components);
            this.btnPrint = new ICE.POS.Common.ButtonEx(this.components);
            this.btnSave = new ICE.POS.Common.ButtonEx(this.components);
            this.btnESC = new ICE.POS.Common.ButtonEx(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedtboxIP);
            this.groupBox2.Controls.Add(this.cboxQD);
            this.groupBox2.Controls.Add(this.labelIP);
            this.groupBox2.Controls.Add(this.labelQD);
            this.groupBox2.Controls.Add(this.labelUSB);
            this.groupBox2.Controls.Add(this.cboxUSB);
            this.groupBox2.Controls.Add(this.cboxBK);
            this.groupBox2.Controls.Add(this.labelBK);
            this.groupBox2.Controls.Add(this.cboxCK);
            this.groupBox2.Controls.Add(this.labelCK);
            this.groupBox2.Location = new System.Drawing.Point(0, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 205);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "端口信息";
            // 
            // maskedtboxIP
            // 
            this.maskedtboxIP.Enabled = false;
            this.maskedtboxIP.Location = new System.Drawing.Point(88, 168);
            this.maskedtboxIP.Mask = "000.000.000.000";
            this.maskedtboxIP.Name = "maskedtboxIP";
            this.maskedtboxIP.Size = new System.Drawing.Size(120, 21);
            this.maskedtboxIP.TabIndex = 10;
            // 
            // cboxQD
            // 
            this.cboxQD.Enabled = false;
            this.cboxQD.FormattingEnabled = true;
            this.cboxQD.Location = new System.Drawing.Point(88, 129);
            this.cboxQD.Name = "cboxQD";
            this.cboxQD.Size = new System.Drawing.Size(121, 20);
            this.cboxQD.TabIndex = 8;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Enabled = false;
            this.labelIP.Location = new System.Drawing.Point(23, 171);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(65, 12);
            this.labelIP.TabIndex = 7;
            this.labelIP.Text = "I P 地址：";
            // 
            // labelQD
            // 
            this.labelQD.AutoSize = true;
            this.labelQD.Enabled = false;
            this.labelQD.Location = new System.Drawing.Point(23, 135);
            this.labelQD.Name = "labelQD";
            this.labelQD.Size = new System.Drawing.Size(65, 12);
            this.labelQD.TabIndex = 6;
            this.labelQD.Text = "驱动名称：";
            // 
            // labelUSB
            // 
            this.labelUSB.AutoSize = true;
            this.labelUSB.Enabled = false;
            this.labelUSB.Location = new System.Drawing.Point(23, 99);
            this.labelUSB.Name = "labelUSB";
            this.labelUSB.Size = new System.Drawing.Size(65, 12);
            this.labelUSB.TabIndex = 5;
            this.labelUSB.Text = "USB 名称：";
            // 
            // cboxUSB
            // 
            this.cboxUSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUSB.Enabled = false;
            this.cboxUSB.FormattingEnabled = true;
            this.cboxUSB.Items.AddRange(new object[] {
            "BYUSB-0",
            "BYUSB-1",
            "BYUSB-2",
            "BYUSB-3",
            "BYUSB-4"});
            this.cboxUSB.Location = new System.Drawing.Point(88, 94);
            this.cboxUSB.Name = "cboxUSB";
            this.cboxUSB.Size = new System.Drawing.Size(121, 20);
            this.cboxUSB.TabIndex = 4;
            // 
            // cboxBK
            // 
            this.cboxBK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBK.Enabled = false;
            this.cboxBK.FormattingEnabled = true;
            this.cboxBK.Items.AddRange(new object[] {
            "LPT1",
            "LPT2",
            "LPT3"});
            this.cboxBK.Location = new System.Drawing.Point(88, 59);
            this.cboxBK.Name = "cboxBK";
            this.cboxBK.Size = new System.Drawing.Size(121, 20);
            this.cboxBK.TabIndex = 3;
            // 
            // labelBK
            // 
            this.labelBK.AutoSize = true;
            this.labelBK.Location = new System.Drawing.Point(23, 63);
            this.labelBK.Name = "labelBK";
            this.labelBK.Size = new System.Drawing.Size(65, 12);
            this.labelBK.TabIndex = 2;
            this.labelBK.Text = "并口名称：";
            // 
            // cboxCK
            // 
            this.cboxCK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCK.Enabled = false;
            this.cboxCK.FormattingEnabled = true;
            this.cboxCK.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cboxCK.Location = new System.Drawing.Point(88, 24);
            this.cboxCK.Name = "cboxCK";
            this.cboxCK.Size = new System.Drawing.Size(121, 20);
            this.cboxCK.TabIndex = 1;
            // 
            // labelCK
            // 
            this.labelCK.AutoSize = true;
            this.labelCK.Enabled = false;
            this.labelCK.Location = new System.Drawing.Point(23, 27);
            this.labelCK.Name = "labelCK";
            this.labelCK.Size = new System.Drawing.Size(65, 12);
            this.labelCK.TabIndex = 0;
            this.labelCK.Text = "串口名称：";
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
            this.lblTitle.Size = new System.Drawing.Size(232, 35);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "打印设置";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQD);
            this.groupBox1.Controls.Add(this.radioButtonWK);
            this.groupBox1.Controls.Add(this.radioButtonUSB);
            this.groupBox1.Controls.Add(this.radioButtonBK);
            this.groupBox1.Controls.Add(this.radioButtonCK);
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口选择";
            // 
            // radioButtonQD
            // 
            this.radioButtonQD.AutoSize = true;
            this.radioButtonQD.Location = new System.Drawing.Point(124, 55);
            this.radioButtonQD.Name = "radioButtonQD";
            this.radioButtonQD.Size = new System.Drawing.Size(89, 16);
            this.radioButtonQD.TabIndex = 4;
            this.radioButtonQD.TabStop = true;
            this.radioButtonQD.Text = "windows驱动";
            this.radioButtonQD.UseVisualStyleBackColor = true;
            this.radioButtonQD.CheckedChanged += new System.EventHandler(this.radioButtonQD_CheckedChanged);
            // 
            // radioButtonWK
            // 
            this.radioButtonWK.AutoSize = true;
            this.radioButtonWK.Location = new System.Drawing.Point(23, 55);
            this.radioButtonWK.Name = "radioButtonWK";
            this.radioButtonWK.Size = new System.Drawing.Size(71, 16);
            this.radioButtonWK.TabIndex = 3;
            this.radioButtonWK.TabStop = true;
            this.radioButtonWK.Text = "网络接口";
            this.radioButtonWK.UseVisualStyleBackColor = true;
            this.radioButtonWK.CheckedChanged += new System.EventHandler(this.radioButtonWK_CheckedChanged);
            // 
            // radioButtonUSB
            // 
            this.radioButtonUSB.AutoSize = true;
            this.radioButtonUSB.Location = new System.Drawing.Point(167, 25);
            this.radioButtonUSB.Name = "radioButtonUSB";
            this.radioButtonUSB.Size = new System.Drawing.Size(41, 16);
            this.radioButtonUSB.TabIndex = 2;
            this.radioButtonUSB.TabStop = true;
            this.radioButtonUSB.Text = "USB";
            this.radioButtonUSB.UseVisualStyleBackColor = true;
            this.radioButtonUSB.CheckedChanged += new System.EventHandler(this.radioButtonUSB_CheckedChanged);
            // 
            // radioButtonBK
            // 
            this.radioButtonBK.AutoSize = true;
            this.radioButtonBK.Location = new System.Drawing.Point(95, 25);
            this.radioButtonBK.Name = "radioButtonBK";
            this.radioButtonBK.Size = new System.Drawing.Size(47, 16);
            this.radioButtonBK.TabIndex = 1;
            this.radioButtonBK.TabStop = true;
            this.radioButtonBK.Text = "并口";
            this.radioButtonBK.UseVisualStyleBackColor = true;
            this.radioButtonBK.CheckedChanged += new System.EventHandler(this.radioButtonBK_CheckedChanged);
            // 
            // radioButtonCK
            // 
            this.radioButtonCK.AutoSize = true;
            this.radioButtonCK.Location = new System.Drawing.Point(23, 25);
            this.radioButtonCK.Name = "radioButtonCK";
            this.radioButtonCK.Size = new System.Drawing.Size(47, 16);
            this.radioButtonCK.TabIndex = 0;
            this.radioButtonCK.TabStop = true;
            this.radioButtonCK.Text = "串口";
            this.radioButtonCK.UseVisualStyleBackColor = true;
            this.radioButtonCK.CheckedChanged += new System.EventHandler(this.radioButtonCK_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(25, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "开钱箱";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrint.Location = new System.Drawing.Point(124, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "打印测试";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(25, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnESC
            // 
            this.btnESC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnESC.ForeColor = System.Drawing.Color.Transparent;
            this.btnESC.Location = new System.Drawing.Point(124, 373);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(75, 23);
            this.btnESC.TabIndex = 21;
            this.btnESC.Text = "取消(&Esc)";
            this.btnESC.UseVisualStyleBackColor = true;
            // 
            // FrmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.CancelButton = this.btnESC;
            this.ClientSize = new System.Drawing.Size(232, 404);
            this.Controls.Add(this.btnESC);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrint";
            this.Load += new System.EventHandler(this.FrmPrint_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radioButtonQD;
        private System.Windows.Forms.RadioButton radioButtonWK;
        private System.Windows.Forms.RadioButton radioButtonUSB;
        private System.Windows.Forms.RadioButton radioButtonBK;
        private System.Windows.Forms.RadioButton radioButtonCK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCK;
        private System.Windows.Forms.ComboBox cboxCK;
        private System.Windows.Forms.Label labelBK;
        private System.Windows.Forms.ComboBox cboxUSB;
        private System.Windows.Forms.ComboBox cboxBK;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelQD;
        private System.Windows.Forms.Label labelUSB;
        private System.Windows.Forms.ComboBox cboxQD;
        private System.Windows.Forms.MaskedTextBox maskedtboxIP;
        private Common.ButtonEx button1;
        private Common.ButtonEx btnPrint;
        private Common.ButtonEx btnSave;
        private Common.ButtonEx btnESC;

    }
}
