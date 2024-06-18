namespace ICE.POS
{
    partial class FrmArrearage
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
            this.dgvArrearage = new System.Windows.Forms.DataGridView();
            this.flow_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btn_retMoney = new ICE.POS.Common.ButtonEx(this.components);
            this.btn_ESC = new ICE.POS.Common.ButtonEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrearage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArrearage
            // 
            this.dgvArrearage.AllowUserToAddRows = false;
            this.dgvArrearage.AllowUserToDeleteRows = false;
            this.dgvArrearage.AllowUserToOrderColumns = true;
            this.dgvArrearage.AllowUserToResizeColumns = false;
            this.dgvArrearage.AllowUserToResizeRows = false;
            this.dgvArrearage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArrearage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flow_no,
            this.vip_No,
            this.oper_name,
            this.sale_amount,
            this.pay_name,
            this.pay_status,
            this.OperateTime});
            this.dgvArrearage.Location = new System.Drawing.Point(-1, 36);
            this.dgvArrearage.MultiSelect = false;
            this.dgvArrearage.Name = "dgvArrearage";
            this.dgvArrearage.ReadOnly = true;
            this.dgvArrearage.RowHeadersVisible = false;
            this.dgvArrearage.RowTemplate.Height = 23;
            this.dgvArrearage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArrearage.Size = new System.Drawing.Size(864, 360);
            this.dgvArrearage.TabIndex = 19;
            this.dgvArrearage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvArrearage_KeyDown);
            this.dgvArrearage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvArrearage_MouseDoubleClick);
            // 
            // flow_no
            // 
            this.flow_no.DataPropertyName = "flow_no";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.flow_no.DefaultCellStyle = dataGridViewCellStyle1;
            this.flow_no.HeaderText = "流水号";
            this.flow_no.Name = "flow_no";
            this.flow_no.ReadOnly = true;
            this.flow_no.Width = 200;
            // 
            // vip_No
            // 
            this.vip_No.DataPropertyName = "vip_no";
            this.vip_No.HeaderText = "会员号";
            this.vip_No.Name = "vip_No";
            this.vip_No.ReadOnly = true;
            // 
            // oper_name
            // 
            this.oper_name.DataPropertyName = "oper_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.oper_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.oper_name.HeaderText = "收银员";
            this.oper_name.Name = "oper_name";
            this.oper_name.ReadOnly = true;
            // 
            // sale_amount
            // 
            this.sale_amount.DataPropertyName = "sale_amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sale_amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.sale_amount.HeaderText = "单据金额";
            this.sale_amount.Name = "sale_amount";
            this.sale_amount.ReadOnly = true;
            // 
            // pay_name
            // 
            this.pay_name.DataPropertyName = "pay_name";
            this.pay_name.HeaderText = "支付方式";
            this.pay_name.Name = "pay_name";
            this.pay_name.ReadOnly = true;
            // 
            // pay_status
            // 
            this.pay_status.DataPropertyName = "pay_status";
            this.pay_status.HeaderText = "当前状态";
            this.pay_status.Name = "pay_status";
            this.pay_status.ReadOnly = true;
            // 
            // OperateTime
            // 
            this.OperateTime.DataPropertyName = "oper_date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "yyyy-MM-dd HH:mm:ss";
            this.OperateTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.OperateTime.HeaderText = "操作时间";
            this.OperateTime.Name = "OperateTime";
            this.OperateTime.ReadOnly = true;
            this.OperateTime.Width = 160;
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
            this.lbTitle.Size = new System.Drawing.Size(863, 39);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "挂账信息";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_retMoney
            // 
            this.btn_retMoney.ForeColor = System.Drawing.Color.Transparent;
            this.btn_retMoney.Location = new System.Drawing.Point(554, 403);
            this.btn_retMoney.Name = "btn_retMoney";
            this.btn_retMoney.Size = new System.Drawing.Size(91, 23);
            this.btn_retMoney.TabIndex = 20;
            this.btn_retMoney.Text = "回款(&Enter)";
            this.btn_retMoney.UseVisualStyleBackColor = true;
            this.btn_retMoney.Click += new System.EventHandler(this.btn_retMoney_Click);
            // 
            // btn_ESC
            // 
            this.btn_ESC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ESC.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ESC.Location = new System.Drawing.Point(710, 403);
            this.btn_ESC.Name = "btn_ESC";
            this.btn_ESC.Size = new System.Drawing.Size(91, 23);
            this.btn_ESC.TabIndex = 21;
            this.btn_ESC.Text = "退出(&ESC)";
            this.btn_ESC.UseVisualStyleBackColor = true;
            // 
            // FrmArrearage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(863, 432);
            this.Controls.Add(this.btn_ESC);
            this.Controls.Add(this.btn_retMoney);
            this.Controls.Add(this.dgvArrearage);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmArrearage";
            this.Load += new System.EventHandler(this.FrmArrearage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrearage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvArrearage;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperateTime;
        private Common.ButtonEx btn_retMoney;
        private Common.ButtonEx btn_ESC;
    }
}
