using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmDmSheet
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
            this.btnExit = new ICE.POS.Common.ButtonEx(this.components);
            this.dgvSheet = new ICE.POS.Common.MyDataGridView();
            this.btnSearch = new ICE.POS.Common.ButtonEx(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new ICE.POS.Common.ButtonEx(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtSheetNO = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new ICE.POS.Common.ButtonEx(this.components);
            this.btnDel = new ICE.POS.Common.ButtonEx(this.components);
            this.sheet_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oper_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approve_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirm_man = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(603, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "退出(Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvSheet
            // 
            this.dgvSheet.AllowUserToAddRows = false;
            this.dgvSheet.AllowUserToOrderColumns = true;
            this.dgvSheet.AllowUserToResizeRows = false;
            this.dgvSheet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sheet_no,
            this.order_status,
            this.branch_name,
            this.d_branch_name,
            this.oper_id,
            this.oper_date,
            this.approve_name,
            this.confirm_man});
            this.dgvSheet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSheet.Location = new System.Drawing.Point(12, 108);
            this.dgvSheet.MultiSelect = false;
            this.dgvSheet.Name = "dgvSheet";
            this.dgvSheet.ReadOnly = true;
            this.dgvSheet.RowTemplate.Height = 23;
            this.dgvSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSheet.Size = new System.Drawing.Size(716, 331);
            this.dgvSheet.TabIndex = 6;
            this.dgvSheet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSheet_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(464, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询(Enter)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "审核状态：";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "全部",
            "未审核",
            "已审核"});
            this.cmbStatus.Location = new System.Drawing.Point(464, 44);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(90, 20);
            this.cmbStatus.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(331, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增单据(F2)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "单    号：";
            // 
            // txtSheetNO
            // 
            this.txtSheetNO.Location = new System.Drawing.Point(135, 44);
            this.txtSheetNO.Name = "txtSheetNO";
            this.txtSheetNO.Size = new System.Drawing.Size(204, 21);
            this.txtSheetNO.TabIndex = 1;
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
            this.lblTitle.Size = new System.Drawing.Size(740, 35);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "要货申请单";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "yyyy-MM-dd";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(249, 74);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(90, 21);
            this.dateEnd.TabIndex = 4;
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "yyyy-MM-dd";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(134, 75);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(90, 21);
            this.dateStart.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "到";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "开始时间：";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "分店要货单",
            "店间直调申请单"});
            this.cmbType.Location = new System.Drawing.Point(99, 452);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(147, 20);
            this.cmbType.TabIndex = 110;
            this.cmbType.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "单据类型：";
            this.label1.Visible = false;
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpen.Location = new System.Drawing.Point(422, 446);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 28);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "打开单据(F3)";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Transparent;
            this.btnDel.Location = new System.Drawing.Point(513, 446);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 28);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除单据(F4)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // sheet_no
            // 
            this.sheet_no.DataPropertyName = "sheet_no";
            this.sheet_no.HeaderText = "单号";
            this.sheet_no.Name = "sheet_no";
            this.sheet_no.ReadOnly = true;
            this.sheet_no.Width = 120;
            // 
            // order_status
            // 
            this.order_status.DataPropertyName = "order_status";
            this.order_status.HeaderText = "order_status";
            this.order_status.Name = "order_status";
            this.order_status.ReadOnly = true;
            this.order_status.Visible = false;
            // 
            // branch_name
            // 
            this.branch_name.DataPropertyName = "branch_name";
            this.branch_name.HeaderText = "申请门店";
            this.branch_name.Name = "branch_name";
            this.branch_name.ReadOnly = true;
            // 
            // d_branch_name
            // 
            this.d_branch_name.DataPropertyName = "d_branch_name";
            this.d_branch_name.HeaderText = "发货门店";
            this.d_branch_name.Name = "d_branch_name";
            this.d_branch_name.ReadOnly = true;
            // 
            // oper_id
            // 
            this.oper_id.DataPropertyName = "oper_id";
            this.oper_id.HeaderText = "操作员";
            this.oper_id.Name = "oper_id";
            this.oper_id.ReadOnly = true;
            this.oper_id.Width = 90;
            // 
            // oper_date
            // 
            this.oper_date.DataPropertyName = "oper_date";
            this.oper_date.HeaderText = "申请日期";
            this.oper_date.Name = "oper_date";
            this.oper_date.ReadOnly = true;
            // 
            // approve_name
            // 
            this.approve_name.DataPropertyName = "approve_name";
            this.approve_name.HeaderText = "状态";
            this.approve_name.Name = "approve_name";
            this.approve_name.ReadOnly = true;
            this.approve_name.Width = 80;
            // 
            // confirm_man
            // 
            this.confirm_man.DataPropertyName = "confirm_man";
            this.confirm_man.HeaderText = "审核人";
            this.confirm_man.Name = "confirm_man";
            this.confirm_man.ReadOnly = true;
            this.confirm_man.Width = 80;
            // 
            // FrmDmSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(740, 478);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSheetNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSheet);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FrmDmSheet";
            this.Load += new System.EventHandler(this.FrmDmSheet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDmSheet_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnAdd;
        private ButtonEx btnDel;
        private ButtonEx btnExit;
        private ButtonEx btnOpen;
        private ButtonEx btnSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private MyDataGridView dgvSheet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSheetNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheet_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn oper_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn approve_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirm_man;
    }
}