using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPayFlowInfoSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEx3 = new ICE.POS.Common.ButtonEx(this.components);
            this.btnNext = new ICE.POS.Common.ButtonEx(this.components);
            this.buttonEx4 = new ICE.POS.Common.ButtonEx(this.components);
            this.btnPre = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.txtInput = new ICE.POS.Common.TextBoxEx(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.flow_no1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_way_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "交易查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonEx3);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.buttonEx4);
            this.panel2.Controls.Add(this.btnPre);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.txtInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 53);
            this.panel2.TabIndex = 1;
            // 
            // buttonEx3
            // 
            this.buttonEx3.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx3.Location = new System.Drawing.Point(567, 12);
            this.buttonEx3.Name = "buttonEx3";
            this.buttonEx3.Size = new System.Drawing.Size(74, 28);
            this.buttonEx3.TabIndex = 36;
            this.buttonEx3.Tag = "r";
            this.buttonEx3.Text = "打印(&F3)";
            this.buttonEx3.UseVisualStyleBackColor = true;
            this.buttonEx3.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(486, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 28);
            this.btnNext.TabIndex = 35;
            this.btnNext.Tag = "n";
            this.btnNext.Text = "下一单(&F5)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // buttonEx4
            // 
            this.buttonEx4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEx4.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx4.Location = new System.Drawing.Point(647, 12);
            this.buttonEx4.Name = "buttonEx4";
            this.buttonEx4.Size = new System.Drawing.Size(80, 28);
            this.buttonEx4.TabIndex = 34;
            this.buttonEx4.Tag = "e";
            this.buttonEx4.Text = "取消(&Esc)";
            this.buttonEx4.UseVisualStyleBackColor = true;
            this.buttonEx4.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnPre
            // 
            this.btnPre.ForeColor = System.Drawing.Color.Transparent;
            this.btnPre.Location = new System.Drawing.Point(405, 12);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(74, 28);
            this.btnPre.TabIndex = 31;
            this.btnPre.Tag = "p";
            this.btnPre.Text = "上一单(&F4)";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(321, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Tag = "s";
            this.btnOK.Text = "查询(&F2)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.Location = new System.Drawing.Point(87, 14);
            this.txtInput.MaxLength = 30;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(229, 23);
            this.txtInput.TabIndex = 29;
            this.txtInput.TextType = 1;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "流水号(&F1):";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPay);
            this.panel3.Location = new System.Drawing.Point(1, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 102);
            this.panel3.TabIndex = 2;
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
            this.sale_way_name,
            this.OperateTime,
            this.oper_name,
            this.sale_amount});
            this.dgvPay.Location = new System.Drawing.Point(3, 6);
            this.dgvPay.MultiSelect = false;
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.ReadOnly = true;
            this.dgvPay.RowHeadersVisible = false;
            this.dgvPay.RowTemplate.Height = 23;
            this.dgvPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPay.Size = new System.Drawing.Size(735, 93);
            this.dgvPay.TabIndex = 0;
            this.dgvPay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvSale);
            this.panel4.Location = new System.Drawing.Point(3, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 161);
            this.panel4.TabIndex = 3;
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.AllowUserToOrderColumns = true;
            this.dgvSale.AllowUserToResizeColumns = false;
            this.dgvSale.AllowUserToResizeRows = false;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flow_no1,
            this.item_no,
            this.item_name,
            this.sale_price,
            this.unit_price,
            this.sale_qnty,
            this.sale_amount1});
            this.dgvSale.Location = new System.Drawing.Point(1, 3);
            this.dgvSale.MultiSelect = false;
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.RowTemplate.Height = 23;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(735, 155);
            this.dgvSale.TabIndex = 1;
            this.dgvSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // flow_no1
            // 
            this.flow_no1.DataPropertyName = "flow_no";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.flow_no1.DefaultCellStyle = dataGridViewCellStyle5;
            this.flow_no1.HeaderText = "流水号";
            this.flow_no1.Name = "flow_no1";
            this.flow_no1.ReadOnly = true;
            this.flow_no1.Width = 180;
            // 
            // item_no
            // 
            this.item_no.DataPropertyName = "item_no";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.item_no.DefaultCellStyle = dataGridViewCellStyle6;
            this.item_no.HeaderText = "货号";
            this.item_no.Name = "item_no";
            this.item_no.ReadOnly = true;
            this.item_no.Width = 135;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.item_name.DefaultCellStyle = dataGridViewCellStyle7;
            this.item_name.HeaderText = "品名";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            this.item_name.Width = 135;
            // 
            // sale_price
            // 
            this.sale_price.DataPropertyName = "sale_price";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sale_price.DefaultCellStyle = dataGridViewCellStyle8;
            this.sale_price.HeaderText = "原价";
            this.sale_price.Name = "sale_price";
            this.sale_price.ReadOnly = true;
            this.sale_price.Width = 70;
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "unit_price";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unit_price.DefaultCellStyle = dataGridViewCellStyle9;
            this.unit_price.HeaderText = "售价";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 70;
            // 
            // sale_qnty
            // 
            this.sale_qnty.DataPropertyName = "sale_qnty";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sale_qnty.DefaultCellStyle = dataGridViewCellStyle10;
            this.sale_qnty.HeaderText = "数量";
            this.sale_qnty.Name = "sale_qnty";
            this.sale_qnty.ReadOnly = true;
            this.sale_qnty.Width = 70;
            // 
            // sale_amount1
            // 
            this.sale_amount1.DataPropertyName = "sale_money";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sale_amount1.DefaultCellStyle = dataGridViewCellStyle11;
            this.sale_amount1.HeaderText = "金额";
            this.sale_amount1.Name = "sale_amount1";
            this.sale_amount1.ReadOnly = true;
            this.sale_amount1.Width = 70;
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
            // sale_way_name
            // 
            this.sale_way_name.DataPropertyName = "sale_way_name";
            this.sale_way_name.HeaderText = "单据性质";
            this.sale_way_name.Name = "sale_way_name";
            this.sale_way_name.ReadOnly = true;
            this.sale_way_name.Width = 150;
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
            // 
            // sale_amount
            // 
            this.sale_amount.DataPropertyName = "sale_amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sale_amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.sale_amount.HeaderText = "单据金额";
            this.sale_amount.Name = "sale_amount";
            this.sale_amount.ReadOnly = true;
            // 
            // FrmPayFlowInfoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonEx4;
            this.ClientSize = new System.Drawing.Size(739, 367);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPayFlowInfoSearch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private TextBoxEx txtInput;
        private ButtonEx btnOK;
        private ButtonEx buttonEx4;
        private ButtonEx btnPre;
        private ButtonEx btnNext;
        private ButtonEx buttonEx3;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow_no1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_way_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_amount;
    }
}