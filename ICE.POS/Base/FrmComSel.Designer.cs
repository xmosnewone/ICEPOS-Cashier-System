namespace ICE.POS
{
    partial class FrmComSel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnSearch = new ICE.POS.Common.ButtonEx(this.components);
            this.panelEx1 = new ICE.POS.Common.PanelEx(this.components);
            this.dgvBranch = new ICE.POS.Common.MyDataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键字(F1)：";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(86, 18);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(210, 21);
            this.tbKey.TabIndex = 1;
            this.tbKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbKey_MouseClick);
            this.tbKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKey_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(302, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询(&Enter)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.Controls.Add(this.dgvBranch);
            this.panelEx1.Location = new System.Drawing.Point(18, 46);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(367, 353);
            this.panelEx1.TabIndex = 3;
            // 
            // dgvBranch
            // 
            this.dgvBranch.AllowUserToAddRows = false;
            this.dgvBranch.AllowUserToDeleteRows = false;
            this.dgvBranch.BackgroundColor = System.Drawing.Color.White;
            this.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name});
            this.dgvBranch.Location = new System.Drawing.Point(4, 3);
            this.dgvBranch.MultiSelect = false;
            this.dgvBranch.Name = "dgvBranch";
            this.dgvBranch.ReadOnly = true;
            this.dgvBranch.RowTemplate.Height = 23;
            this.dgvBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBranch.Size = new System.Drawing.Size(363, 346);
            this.dgvBranch.TabIndex = 1;
            this.dgvBranch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvBranch_KeyUp);
            this.dgvBranch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBranch_MouseClick);
            this.dgvBranch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBranch_MouseDoubleClick);
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "编号";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Location = new System.Drawing.Point(391, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "退出(&Esc)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmComSel
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(405, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label1);
            this.Name = "FrmComSel";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmComSel_KeyUp);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private Common.ButtonEx btnSearch;
        private Common.PanelEx panelEx1;
        private Common.MyDataGridView dgvBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button button1;

    }
}