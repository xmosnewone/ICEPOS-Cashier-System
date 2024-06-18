using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPendingOrder
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
            this.dgvSaleFlow = new System.Windows.Forms.DataGridView();
            this.bindingSaleFlow = new System.Windows.Forms.BindingSource(this.components);
            this.btnDel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.btnExit = new ICE.POS.Common.ButtonEx(this.components);
            this.dgvPenOrd = new System.Windows.Forms.DataGridView();
            this.bindingPenOrd = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSaleFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenOrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPenOrd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSaleFlow
            // 
            this.dgvSaleFlow.AllowUserToAddRows = false;
            this.dgvSaleFlow.AllowUserToDeleteRows = false;
            this.dgvSaleFlow.AllowUserToResizeColumns = false;
            this.dgvSaleFlow.AutoGenerateColumns = false;
            this.dgvSaleFlow.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSaleFlow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSaleFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleFlow.DataSource = this.bindingSaleFlow;
            this.dgvSaleFlow.Location = new System.Drawing.Point(244, 42);
            this.dgvSaleFlow.MultiSelect = false;
            this.dgvSaleFlow.Name = "dgvSaleFlow";
            this.dgvSaleFlow.ReadOnly = true;
            this.dgvSaleFlow.RowTemplate.Height = 30;
            this.dgvSaleFlow.Size = new System.Drawing.Size(484, 329);
            this.dgvSaleFlow.TabIndex = 2;
            this.dgvSaleFlow.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSaleFlow_DataError);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Transparent;
            this.btnDel.Location = new System.Drawing.Point(406, 384);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(527, 384);
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
            this.btnExit.Location = new System.Drawing.Point(644, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "取消(&Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvPenOrd
            // 
            this.dgvPenOrd.AllowUserToAddRows = false;
            this.dgvPenOrd.AllowUserToDeleteRows = false;
            this.dgvPenOrd.AllowUserToResizeColumns = false;
            this.dgvPenOrd.AutoGenerateColumns = false;
            this.dgvPenOrd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPenOrd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPenOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenOrd.DataSource = this.bindingPenOrd;
            this.dgvPenOrd.Location = new System.Drawing.Point(1, 42);
            this.dgvPenOrd.MultiSelect = false;
            this.dgvPenOrd.Name = "dgvPenOrd";
            this.dgvPenOrd.ReadOnly = true;
            this.dgvPenOrd.RowTemplate.Height = 30;
            this.dgvPenOrd.Size = new System.Drawing.Size(238, 329);
            this.dgvPenOrd.TabIndex = 1;
            this.dgvPenOrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPenOrd_DataBindingComplete);
            this.dgvPenOrd.SelectionChanged += new System.EventHandler(this.dgvPenOrd_SelectionChanged);
            this.dgvPenOrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPenOrd_KeyDown);
            // 
            // bindingPenOrd
            // 
            this.bindingPenOrd.AllowNew = true;
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
            this.label1.Size = new System.Drawing.Size(729, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "挂单";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPendingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(729, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPenOrd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvSaleFlow);
            this.Name = "FrmPendingOrder";
            this.Load += new System.EventHandler(this.FrmPendingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSaleFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenOrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPenOrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaleFlow;
        private System.Windows.Forms.BindingSource bindingPenOrd;
        private System.Windows.Forms.BindingSource bindingSaleFlow;
        private ButtonEx btnDel;
        private ButtonEx btnOk;
        private ButtonEx btnExit;
        private System.Windows.Forms.DataGridView dgvPenOrd;
        private System.Windows.Forms.Label label1;
    }
}