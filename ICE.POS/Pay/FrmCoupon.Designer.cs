namespace ICE.POS
{
    partial class FrmCoupon
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
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mention = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.cpNo = new System.Windows.Forms.TextBox();
            this.delBtn = new ICE.POS.Common.ButtonEx(this.components);
            this.bntChk = new ICE.POS.Common.ButtonEx(this.components);
            this.cancelBtn = new ICE.POS.Common.ButtonEx(this.components);
            this.btnDm = new ICE.POS.Common.ButtonEx(this.components);
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giftcert_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_com_label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToResizeColumns = false;
            this.dgItem.AllowUserToResizeRows = false;
            this.dgItem.BackgroundColor = System.Drawing.Color.White;
            this.dgItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.title,
            this.giftcert_no,
            this.is_com_label,
            this.max_num,
            this.min_amount,
            this.start_date,
            this.end_date});
            this.dgItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgItem.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgItem.Location = new System.Drawing.Point(1, 129);
            this.dgItem.Name = "dgItem";
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowTemplate.Height = 27;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(985, 235);
            this.dgItem.TabIndex = 2;
            this.dgItem.Tag = "couponGrid";
            this.dgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mention);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.cpNo);
            this.panel1.Controls.Add(this.bntChk);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 91);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "mypanel";
            // 
            // mention
            // 
            this.mention.AutoSize = true;
            this.mention.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mention.Location = new System.Drawing.Point(126, 64);
            this.mention.Name = "mention";
            this.mention.Size = new System.Drawing.Size(0, 15);
            this.mention.TabIndex = 3;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb1.Location = new System.Drawing.Point(6, 27);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(87, 25);
            this.lb1.TabIndex = 30;
            this.lb1.Text = "券码：";
            // 
            // cpNo
            // 
            this.cpNo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cpNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cpNo.Location = new System.Drawing.Point(123, 21);
            this.cpNo.Name = "cpNo";
            this.cpNo.Size = new System.Drawing.Size(485, 36);
            this.cpNo.TabIndex = 0;
            this.cpNo.Tag = "scancodetxt";
            this.cpNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            // 
            // delBtn
            // 
            this.delBtn.ForeColor = System.Drawing.Color.Transparent;
            this.delBtn.Location = new System.Drawing.Point(729, 377);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(128, 35);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "删除选中";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // bntChk
            // 
            this.bntChk.ForeColor = System.Drawing.Color.Transparent;
            this.bntChk.Location = new System.Drawing.Point(626, 21);
            this.bntChk.Name = "bntChk";
            this.bntChk.Size = new System.Drawing.Size(100, 35);
            this.bntChk.TabIndex = 2;
            this.bntChk.Text = "清空券码";
            this.bntChk.UseVisualStyleBackColor = true;
            this.bntChk.Click += new System.EventHandler(this.clear_code);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(885, 377);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 35);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "取消(ESC)";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.couponCancle);
            // 
            // btnDm
            // 
            this.btnDm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDm.Location = new System.Drawing.Point(573, 377);
            this.btnDm.Name = "btnDm";
            this.btnDm.Size = new System.Drawing.Size(128, 35);
            this.btnDm.TabIndex = 3;
            this.btnDm.Text = "确定(Enter)";
            this.btnDm.UseVisualStyleBackColor = true;
            this.btnDm.Click += new System.EventHandler(this.btnDm_Click);
            // 
            // cb
            // 
            this.cb.DataPropertyName = "isSelect";
            this.cb.HeaderText = "选择";
            this.cb.Name = "cb";
            this.cb.Width = 50;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "优惠券类型";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 120;
            // 
            // giftcert_no
            // 
            this.giftcert_no.DataPropertyName = "giftcert_no";
            this.giftcert_no.HeaderText = "券码";
            this.giftcert_no.Name = "giftcert_no";
            this.giftcert_no.ReadOnly = true;
            // 
            // is_com_label
            // 
            this.is_com_label.DataPropertyName = "is_com_label";
            this.is_com_label.HeaderText = "可组合";
            this.is_com_label.Name = "is_com_label";
            this.is_com_label.ReadOnly = true;
            this.is_com_label.Width = 60;
            // 
            // max_num
            // 
            this.max_num.DataPropertyName = "max_num";
            this.max_num.HeaderText = "限数量";
            this.max_num.Name = "max_num";
            this.max_num.ReadOnly = true;
            // 
            // min_amount
            // 
            this.min_amount.DataPropertyName = "min_amount";
            this.min_amount.HeaderText = "最低金额";
            this.min_amount.Name = "min_amount";
            this.min_amount.ReadOnly = true;
            // 
            // start_date
            // 
            this.start_date.DataPropertyName = "begin_date";
            this.start_date.HeaderText = "开始日期";
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "截止日期";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            // 
            // FrmCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 430);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgItem);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.btnDm);
            this.Name = "FrmCoupon";
            this.Text = "优惠券";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.ButtonEx btnDm;
        private Common.ButtonEx cancelBtn;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.Panel panel1;
        private Common.ButtonEx bntChk;
        private System.Windows.Forms.TextBox cpNo;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label mention;
        private Common.ButtonEx delBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn giftcert_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_com_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn max_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
    }
}