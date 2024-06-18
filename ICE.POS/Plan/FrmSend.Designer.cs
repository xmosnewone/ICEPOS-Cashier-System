namespace ICE.POS
{
    partial class FrmSend
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
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.isSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.item_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMessage = new System.Windows.Forms.Label();
            this.buttonEx1 = new ICE.POS.Common.ButtonEx(this.components);
            this.buttonEx2 = new ICE.POS.Common.ButtonEx(this.components);
            this.btnDm = new ICE.POS.Common.ButtonEx(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToResizeColumns = false;
            this.dgItem.AllowUserToResizeRows = false;
            this.dgItem.BackgroundColor = System.Drawing.Color.White;
            this.dgItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelect,
            this.item_no,
            this.item_name,
            this.sale_qnty});
            this.dgItem.Location = new System.Drawing.Point(0, 44);
            this.dgItem.MultiSelect = false;
            this.dgItem.Name = "dgItem";
            this.dgItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowTemplate.Height = 23;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.ShowRowErrors = false;
            this.dgItem.Size = new System.Drawing.Size(676, 202);
            this.dgItem.TabIndex = 19;
            // 
            // isSelect
            // 
            this.isSelect.DataPropertyName = "isSelect";
            this.isSelect.HeaderText = "选择";
            this.isSelect.Name = "isSelect";
            // 
            // item_no
            // 
            this.item_no.DataPropertyName = "item_no";
            this.item_no.HeaderText = "货号";
            this.item_no.Name = "item_no";
            this.item_no.ReadOnly = true;
            this.item_no.Width = 150;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "货名";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.Width = 280;
            // 
            // sale_qnty
            // 
            this.sale_qnty.DataPropertyName = "sale_qnty";
            this.sale_qnty.HeaderText = "数量";
            this.sale_qnty.Name = "sale_qnty";
            this.sale_qnty.ReadOnly = true;
            this.sale_qnty.Width = 130;
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMessage.Location = new System.Drawing.Point(5, 249);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(285, 40);
            this.lbMessage.TabIndex = 18;
            // 
            // buttonEx1
            // 
            this.buttonEx1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx1.Location = new System.Drawing.Point(299, 254);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(80, 28);
            this.buttonEx1.TabIndex = 16;
            this.buttonEx1.Text = "全选(&F1)";
            this.buttonEx1.UseVisualStyleBackColor = true;
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // buttonEx2
            // 
            this.buttonEx2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx2.Location = new System.Drawing.Point(395, 254);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(75, 28);
            this.buttonEx2.TabIndex = 17;
            this.buttonEx2.Text = "全不选(&F2)";
            this.buttonEx2.UseVisualStyleBackColor = true;
            this.buttonEx2.Click += new System.EventHandler(this.buttonEx2_Click);
            // 
            // btnDm
            // 
            this.btnDm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDm.Location = new System.Drawing.Point(487, 253);
            this.btnDm.Name = "btnDm";
            this.btnDm.Size = new System.Drawing.Size(80, 28);
            this.btnDm.TabIndex = 13;
            this.btnDm.Text = "确定(Enter)";
            this.btnDm.UseVisualStyleBackColor = true;
            this.btnDm.Click += new System.EventHandler(this.btnDm_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(676, 41);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "促销提示：收银员请提醒顾客！";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(584, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 293);
            this.Controls.Add(this.dgItem);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.buttonEx1);
            this.Controls.Add(this.buttonEx2);
            this.Controls.Add(this.btnDm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmSend";
            this.Text = "赠品窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.ButtonEx btnDm;
        private System.Windows.Forms.Label lblTitle;
        private Common.ButtonEx btnCancel;
        private Common.ButtonEx buttonEx1;
        private Common.ButtonEx buttonEx2;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_qnty;
    }
}