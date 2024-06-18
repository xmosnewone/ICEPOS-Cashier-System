namespace ICE.POS
{
    partial class FrmCPayWay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbox_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.flow_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPayWay = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Query = new ICE.POS.Common.ButtonEx(this.components);
            this.btn_Add = new ICE.POS.Common.ButtonEx(this.components);
            this.btn_Alter = new ICE.POS.Common.ButtonEx(this.components);
            this.btn_ESC = new ICE.POS.Common.ButtonEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayWay)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(735, 33);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "更改支付方式";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbox_No
            // 
            this.tbox_No.Location = new System.Drawing.Point(76, 49);
            this.tbox_No.Name = "tbox_No";
            this.tbox_No.Size = new System.Drawing.Size(191, 21);
            this.tbox_No.TabIndex = 14;
            this.tbox_No.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_No_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "订单号：";
            // 
            // dgvPay
            // 
            this.dgvPay.AllowUserToAddRows = false;
            this.dgvPay.AllowUserToDeleteRows = false;
            this.dgvPay.AllowUserToOrderColumns = true;
            this.dgvPay.AllowUserToResizeColumns = false;
            this.dgvPay.AllowUserToResizeRows = false;
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flow_no,
            this.OperateTime,
            this.oper_name,
            this.sale_amount});
            this.dgvPay.Location = new System.Drawing.Point(0, 82);
            this.dgvPay.MultiSelect = false;
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.ReadOnly = true;
            this.dgvPay.RowHeadersVisible = false;
            this.dgvPay.RowTemplate.Height = 23;
            this.dgvPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPay.Size = new System.Drawing.Size(735, 53);
            this.dgvPay.TabIndex = 18;
            // 
            // flow_no
            // 
            this.flow_no.DataPropertyName = "flow_no";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.flow_no.DefaultCellStyle = dataGridViewCellStyle1;
            this.flow_no.HeaderText = "流水号";
            this.flow_no.Name = "flow_no";
            this.flow_no.ReadOnly = true;
            this.flow_no.Width = 220;
            // 
            // OperateTime
            // 
            this.OperateTime.DataPropertyName = "oper_date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss";
            this.OperateTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.OperateTime.HeaderText = "操作时间";
            this.OperateTime.Name = "OperateTime";
            this.OperateTime.ReadOnly = true;
            this.OperateTime.Width = 160;
            // 
            // oper_name
            // 
            this.oper_name.DataPropertyName = "oper_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.oper_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.oper_name.HeaderText = "收银员";
            this.oper_name.Name = "oper_name";
            this.oper_name.ReadOnly = true;
            this.oper_name.Width = 150;
            // 
            // sale_amount
            // 
            this.sale_amount.DataPropertyName = "sale_amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sale_amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.sale_amount.HeaderText = "单据金额";
            this.sale_amount.Name = "sale_amount";
            this.sale_amount.ReadOnly = true;
            this.sale_amount.Width = 200;
            // 
            // dgvPayWay
            // 
            this.dgvPayWay.AllowUserToAddRows = false;
            this.dgvPayWay.AllowUserToDeleteRows = false;
            this.dgvPayWay.AllowUserToOrderColumns = true;
            this.dgvPayWay.AllowUserToResizeColumns = false;
            this.dgvPayWay.AllowUserToResizeRows = false;
            this.dgvPayWay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayWay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.flow_id,
            this.dataGridViewTextBoxColumn1,
            this.pay_amount,
            this.pay_name,
            this.oper_date});
            this.dgvPayWay.Location = new System.Drawing.Point(0, 156);
            this.dgvPayWay.MultiSelect = false;
            this.dgvPayWay.Name = "dgvPayWay";
            this.dgvPayWay.ReadOnly = true;
            this.dgvPayWay.RowHeadersVisible = false;
            this.dgvPayWay.RowTemplate.Height = 23;
            this.dgvPayWay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayWay.Size = new System.Drawing.Size(735, 160);
            this.dgvPayWay.TabIndex = 23;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // flow_id
            // 
            this.flow_id.DataPropertyName = "flow_id";
            this.flow_id.HeaderText = "flow_id";
            this.flow_id.Name = "flow_id";
            this.flow_id.ReadOnly = true;
            this.flow_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "flow_no";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "流水号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 220;
            // 
            // pay_amount
            // 
            this.pay_amount.DataPropertyName = "pay_amount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pay_amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.pay_amount.HeaderText = "单据金额";
            this.pay_amount.Name = "pay_amount";
            this.pay_amount.ReadOnly = true;
            this.pay_amount.Width = 150;
            // 
            // pay_name
            // 
            this.pay_name.DataPropertyName = "pay_name";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "yyyy-MM-dd HH:mm:ss";
            this.pay_name.DefaultCellStyle = dataGridViewCellStyle7;
            this.pay_name.HeaderText = "支付方式";
            this.pay_name.Name = "pay_name";
            this.pay_name.ReadOnly = true;
            this.pay_name.Width = 160;
            // 
            // oper_date
            // 
            this.oper_date.DataPropertyName = "oper_date";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.oper_date.DefaultCellStyle = dataGridViewCellStyle8;
            this.oper_date.HeaderText = "操作时间";
            this.oper_date.Name = "oper_date";
            this.oper_date.ReadOnly = true;
            this.oper_date.Width = 200;
            // 
            // btn_Query
            // 
            this.btn_Query.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Query.Location = new System.Drawing.Point(284, 47);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(82, 23);
            this.btn_Query.TabIndex = 25;
            this.btn_Query.Text = "查询(&Enter)";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Add.Location = new System.Drawing.Point(19, 325);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 26;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Alter
            // 
            this.btn_Alter.Enabled = false;
            this.btn_Alter.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Alter.Location = new System.Drawing.Point(125, 325);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(75, 23);
            this.btn_Alter.TabIndex = 27;
            this.btn_Alter.Text = "修改";
            this.btn_Alter.UseVisualStyleBackColor = true;
            this.btn_Alter.Click += new System.EventHandler(this.btn_Alter_Click);
            // 
            // btn_ESC
            // 
            this.btn_ESC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ESC.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ESC.Location = new System.Drawing.Point(621, 325);
            this.btn_ESC.Name = "btn_ESC";
            this.btn_ESC.Size = new System.Drawing.Size(75, 23);
            this.btn_ESC.TabIndex = 28;
            this.btn_ESC.Text = "退出(&ESC)";
            this.btn_ESC.UseVisualStyleBackColor = true;
            this.btn_ESC.Click += new System.EventHandler(this.btn_ESC_Click);
            // 
            // FrmCPayWay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(735, 356);
            this.Controls.Add(this.btn_ESC);
            this.Controls.Add(this.btn_Alter);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.dgvPayWay);
            this.Controls.Add(this.dgvPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_No);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmCPayWay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayWay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbox_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_amount;
        private System.Windows.Forms.DataGridView dgvPayWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_date;
        private Common.ButtonEx btn_Query;
        private Common.ButtonEx btn_Add;
        private Common.ButtonEx btn_Alter;
        private Common.ButtonEx btn_ESC;

    }
}
