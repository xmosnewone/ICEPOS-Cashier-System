namespace ICE.POS
{
    partial class FrmPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDm = new ICE.POS.Common.ButtonEx(this.components);
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rule_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rule_describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rule_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(685, 41);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "促销提示：收银员请提醒顾客！";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToResizeColumns = false;
            this.dgItem.AllowUserToResizeRows = false;
            this.dgItem.BackgroundColor = System.Drawing.Color.White;
            this.dgItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.rule_no,
            this.rule_describe,
            this.rule_desc});
            this.dgItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgItem.Location = new System.Drawing.Point(0, 48);
            this.dgItem.MultiSelect = false;
            this.dgItem.Name = "dgItem";
            this.dgItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowTemplate.Height = 23;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(685, 210);
            this.dgItem.StandardTab = true;
            this.dgItem.TabIndex = 7;
            this.dgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellClick);
            this.dgItem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgItem_DataError);
            this.dgItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgItem_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "注意：按F6进行促销选择或撤销";
            // 
            // btnDm
            // 
            this.btnDm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDm.Location = new System.Drawing.Point(481, 265);
            this.btnDm.Name = "btnDm";
            this.btnDm.Size = new System.Drawing.Size(96, 28);
            this.btnDm.TabIndex = 8;
            this.btnDm.Text = "确定(Enter)";
            this.btnDm.UseVisualStyleBackColor = true;
            this.btnDm.Click += new System.EventHandler(this.btnDm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(586, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cb
            // 
            this.cb.DataPropertyName = "isSelect";
            this.cb.FalseValue = "";
            this.cb.HeaderText = "选择";
            this.cb.Name = "cb";
            this.cb.ReadOnly = true;
            this.cb.TrueValue = "";
            this.cb.Width = 50;
            // 
            // rule_no
            // 
            this.rule_no.DataPropertyName = "rule_no";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.rule_no.DefaultCellStyle = dataGridViewCellStyle2;
            this.rule_no.HeaderText = "促销类型";
            this.rule_no.Name = "rule_no";
            this.rule_no.ReadOnly = true;
            this.rule_no.Width = 80;
            // 
            // rule_describe
            // 
            this.rule_describe.DataPropertyName = "rule_describe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.rule_describe.DefaultCellStyle = dataGridViewCellStyle3;
            this.rule_describe.HeaderText = "促销规则";
            this.rule_describe.Name = "rule_describe";
            this.rule_describe.ReadOnly = true;
            this.rule_describe.Width = 150;
            // 
            // rule_desc
            // 
            this.rule_desc.DataPropertyName = "rule_desc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.rule_desc.DefaultCellStyle = dataGridViewCellStyle4;
            this.rule_desc.HeaderText = "促销描述";
            this.rule_desc.Name = "rule_desc";
            this.rule_desc.ReadOnly = true;
            this.rule_desc.Width = 385;
            // 
            // FrmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgItem);
            this.Name = "FrmPlan";
            this.Text = "促销提示";
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgItem;
        private Common.ButtonEx btnDm;
        private Common.ButtonEx btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn rule_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn rule_describe;
        private System.Windows.Forms.DataGridViewTextBoxColumn rule_desc;

    }
}