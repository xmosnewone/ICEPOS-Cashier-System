using ICE.POS.Common;
namespace ICE.POS
{
    partial class _FrmTot
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
            this.tblPanelBalance = new TableLayoutPanelEx(this.components);
            this.GvPayFlow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plPayListTilte = new PanelEx(this.components);
            this.plPayInfo = new PanelEx(this.components);
            this.gbPayInput = new System.Windows.Forms.GroupBox();
            this.plPayKey = new PanelEx(this.components);
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plPayInput = new PanelEx(this.components);
            this.lbPayInput = new System.Windows.Forms.Label();
            this.lbPayCursor = new System.Windows.Forms.Label();
            this.gbPayInfo = new System.Windows.Forms.GroupBox();
            this.plPayLeft = new PanelEx(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tblPanelBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvPayFlow)).BeginInit();
            this.plPayInfo.SuspendLayout();
            this.gbPayInput.SuspendLayout();
            this.plPayKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plPayInput.SuspendLayout();
            this.gbPayInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanelBalance
            // 
            this.tblPanelBalance.ColumnCount = 1;
            this.tblPanelBalance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBalance.Controls.Add(this.GvPayFlow, 0, 3);
            this.tblPanelBalance.Controls.Add(this.plPayListTilte, 0, 2);
            this.tblPanelBalance.Controls.Add(this.plPayInfo, 0, 1);
            this.tblPanelBalance.Location = new System.Drawing.Point(11, 11);
            this.tblPanelBalance.Margin = new System.Windows.Forms.Padding(2);
            this.tblPanelBalance.Name = "tblPanelBalance";
            this.tblPanelBalance.Padding = new System.Windows.Forms.Padding(4);
            this.tblPanelBalance.RowCount = 4;
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblPanelBalance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBalance.Size = new System.Drawing.Size(657, 439);
            this.tblPanelBalance.TabIndex = 0;
            // 
            // GvPayFlow
            // 
            this.GvPayFlow.AllowUserToAddRows = false;
            this.GvPayFlow.AllowUserToDeleteRows = false;
            this.GvPayFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvPayFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GvPayFlow.Location = new System.Drawing.Point(4, 347);
            this.GvPayFlow.Margin = new System.Windows.Forms.Padding(0);
            this.GvPayFlow.Name = "GvPayFlow";
            this.GvPayFlow.ReadOnly = true;
            this.GvPayFlow.RowTemplate.Height = 23;
            this.GvPayFlow.Size = new System.Drawing.Size(643, 75);
            this.GvPayFlow.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "付款方式";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "付款金额";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "汇率";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "折算金额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // plPayListTilte
            // 
            this.plPayListTilte.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plPayListTilte.BackgroundImage = global::ICE.POS.Properties.Resources.pay_title;
            this.plPayListTilte.Location = new System.Drawing.Point(4, 321);
            this.plPayListTilte.Margin = new System.Windows.Forms.Padding(0);
            this.plPayListTilte.Name = "plPayListTilte";
            this.plPayListTilte.Size = new System.Drawing.Size(643, 26);
            this.plPayListTilte.TabIndex = 2;
            // 
            // plPayInfo
            // 
            this.plPayInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.plPayInfo.Controls.Add(this.gbPayInput);
            this.plPayInfo.Controls.Add(this.gbPayInfo);
            this.plPayInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plPayInfo.Location = new System.Drawing.Point(5, 74);
            this.plPayInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.plPayInfo.Name = "plPayInfo";
            this.plPayInfo.Size = new System.Drawing.Size(647, 247);
            this.plPayInfo.TabIndex = 3;
            // 
            // gbPayInput
            // 
            this.gbPayInput.Controls.Add(this.plPayKey);
            this.gbPayInput.Controls.Add(this.plPayInput);
            this.gbPayInput.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.gbPayInput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbPayInput.Location = new System.Drawing.Point(310, 0);
            this.gbPayInput.Name = "gbPayInput";
            this.gbPayInput.Size = new System.Drawing.Size(336, 244);
            this.gbPayInput.TabIndex = 1;
            this.gbPayInput.TabStop = false;
            this.gbPayInput.Text = "金额输入";
            // 
            // plPayKey
            // 
            this.plPayKey.BackgroundImage = global::ICE.POS.Properties.Resources.touch_pay_key;
            this.plPayKey.Controls.Add(this.pictureBox15);
            this.plPayKey.Controls.Add(this.pictureBox14);
            this.plPayKey.Controls.Add(this.pictureBox10);
            this.plPayKey.Controls.Add(this.pictureBox9);
            this.plPayKey.Controls.Add(this.pictureBox13);
            this.plPayKey.Controls.Add(this.pictureBox5);
            this.plPayKey.Controls.Add(this.pictureBox8);
            this.plPayKey.Controls.Add(this.pictureBox12);
            this.plPayKey.Controls.Add(this.pictureBox4);
            this.plPayKey.Controls.Add(this.pictureBox7);
            this.plPayKey.Controls.Add(this.pictureBox11);
            this.plPayKey.Controls.Add(this.pictureBox3);
            this.plPayKey.Controls.Add(this.pictureBox6);
            this.plPayKey.Controls.Add(this.pictureBox2);
            this.plPayKey.Controls.Add(this.pictureBox1);
            this.plPayKey.Location = new System.Drawing.Point(15, 75);
            this.plPayKey.Name = "plPayKey";
            this.plPayKey.Size = new System.Drawing.Size(308, 164);
            this.plPayKey.TabIndex = 3;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Location = new System.Drawing.Point(246, 108);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(58, 48);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "enter";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Location = new System.Drawing.Point(185, 108);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(58, 48);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "3";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(245, 57);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(58, 48);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Location = new System.Drawing.Point(184, 57);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(58, 48);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "6";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Location = new System.Drawing.Point(124, 108);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(58, 48);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(245, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 48);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "backspace";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(123, 57);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(58, 48);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "5";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Location = new System.Drawing.Point(63, 108);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(58, 48);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(184, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 48);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "9";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(62, 57);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(58, 48);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "4";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(3, 108);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(58, 48);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(123, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 48);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "8";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(2, 57);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 48);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(62, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 48);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // plPayInput
            // 
            this.plPayInput.BackgroundImage = global::ICE.POS.Properties.Resources.pay_input;
            this.plPayInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plPayInput.Controls.Add(this.lbPayInput);
            this.plPayInput.Controls.Add(this.lbPayCursor);
            this.plPayInput.Location = new System.Drawing.Point(15, 24);
            this.plPayInput.Name = "plPayInput";
            this.plPayInput.Size = new System.Drawing.Size(306, 50);
            this.plPayInput.TabIndex = 0;
            // 
            // lbPayInput
            // 
            this.lbPayInput.BackColor = System.Drawing.Color.White;
            this.lbPayInput.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPayInput.Location = new System.Drawing.Point(9, 5);
            this.lbPayInput.Margin = new System.Windows.Forms.Padding(0, 0, 4, 3);
            this.lbPayInput.Name = "lbPayInput";
            this.lbPayInput.Size = new System.Drawing.Size(270, 40);
            this.lbPayInput.TabIndex = 9;
            this.lbPayInput.Text = "1234567890123";
            this.lbPayInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPayInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInput_KeyDown);
            // 
            // lbPayCursor
            // 
            this.lbPayCursor.BackColor = System.Drawing.Color.Black;
            this.lbPayCursor.Location = new System.Drawing.Point(130, 11);
            this.lbPayCursor.Name = "lbPayCursor";
            this.lbPayCursor.Size = new System.Drawing.Size(2, 30);
            this.lbPayCursor.TabIndex = 10;
            this.lbPayCursor.Text = "232131233";
            // 
            // gbPayInfo
            // 
            this.gbPayInfo.Controls.Add(this.plPayLeft);
            this.gbPayInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbPayInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbPayInfo.Location = new System.Drawing.Point(3, 1);
            this.gbPayInfo.Name = "gbPayInfo";
            this.gbPayInfo.Size = new System.Drawing.Size(300, 243);
            this.gbPayInfo.TabIndex = 0;
            this.gbPayInfo.TabStop = false;
            this.gbPayInfo.Text = "付款信息";
            // 
            // plPayLeft
            // 
            this.plPayLeft.BackgroundImage = global::ICE.POS.Properties.Resources.touch_pay_info;
            this.plPayLeft.Location = new System.Drawing.Point(8, 23);
            this.plPayLeft.Name = "plPayLeft";
            this.plPayLeft.Size = new System.Drawing.Size(276, 214);
            this.plPayLeft.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmTot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 497);
            this.Controls.Add(this.tblPanelBalance);
            this.Name = "FrmTot";
            this.Text = "GvPayflow";
            this.Load += new System.EventHandler(this.FrmTot_Load);
            this.tblPanelBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvPayFlow)).EndInit();
            this.plPayInfo.ResumeLayout(false);
            this.gbPayInput.ResumeLayout(false);
            this.plPayKey.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plPayInput.ResumeLayout(false);
            this.gbPayInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanelEx tblPanelBalance;
        private System.Windows.Forms.DataGridView GvPayFlow;
        private PanelEx plPayListTilte;
        private PanelEx plPayInfo;
        private System.Windows.Forms.GroupBox gbPayInfo;
        private System.Windows.Forms.GroupBox gbPayInput;
        private PanelEx plPayInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private PanelEx plPayLeft;
        private System.Windows.Forms.Label lbPayInput;
        private System.Windows.Forms.Label lbPayCursor;
        private System.Windows.Forms.Timer timer1;
        private PanelEx plPayKey;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}