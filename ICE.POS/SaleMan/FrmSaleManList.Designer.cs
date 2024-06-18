using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmSaleManList
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
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.btnExit = new ICE.POS.Common.ButtonEx(this.components);
            this.dgvOperList = new System.Windows.Forms.DataGridView();
            this.oper_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingOperList = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingOperList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(79, 328);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(191, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "取消(&Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvOperList
            // 
            this.dgvOperList.AllowUserToAddRows = false;
            this.dgvOperList.AllowUserToDeleteRows = false;
            this.dgvOperList.AllowUserToResizeColumns = false;
            this.dgvOperList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOperList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvOperList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oper_id,
            this.full_name,
            this.oper_state});
            this.dgvOperList.Location = new System.Drawing.Point(7, 42);
            this.dgvOperList.MultiSelect = false;
            this.dgvOperList.Name = "dgvOperList";
            this.dgvOperList.ReadOnly = true;
            this.dgvOperList.RowTemplate.Height = 30;
            this.dgvOperList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperList.Size = new System.Drawing.Size(344, 270);
            this.dgvOperList.TabIndex = 1;
            this.dgvOperList.DoubleClick += new System.EventHandler(this.dgvOperList_DoubleClick);
            this.dgvOperList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPenOrd_KeyDown);
            // 
            // oper_id
            // 
            this.oper_id.DataPropertyName = "Oper_id";
            this.oper_id.HeaderText = "操作员编号";
            this.oper_id.Name = "oper_id";
            this.oper_id.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "Full_name";
            this.full_name.HeaderText = "操作员名称";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // oper_state
            // 
            this.oper_state.DataPropertyName = "Oper_state";
            this.oper_state.HeaderText = "操作员状态";
            this.oper_state.Name = "oper_state";
            this.oper_state.ReadOnly = true;
            // 
            // bindingOperList
            // 
            this.bindingOperList.AllowNew = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "营业员查询列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSaleManList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(359, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOperList);
            this.Name = "FrmSaleManList";
            this.Load += new System.EventHandler(this.FrmSaleManList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingOperList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingOperList;
        private ButtonEx btnOk;
        private ButtonEx btnExit;
        private System.Windows.Forms.DataGridView dgvOperList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_state;
    }
}