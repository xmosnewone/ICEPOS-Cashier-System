using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmDmSheetDetail
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
            this.btnDelAll = new ICE.POS.Common.ButtonEx(this.components);
            this.btnDel = new ICE.POS.Common.ButtonEx(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnApprove = new ICE.POS.Common.ButtonEx(this.components);
            this.btnSave = new ICE.POS.Common.ButtonEx(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblApprove = new System.Windows.Forms.Label();
            this.btnSelectItem = new ICE.POS.Common.ButtonEx(this.components);
            this.txtRemark = new ICE.POS.Common.TextBoxEx(this.components);
            this.dateValid = new System.Windows.Forms.DateTimePicker();
            this.txtSqPersion = new ICE.POS.Common.TextBoxEx(this.components);
            this.dgvItemList = new ICE.POS.Common.MyDataGridView();
            this.btnSelectBranch = new ICE.POS.Common.ButtonEx(this.components);
            this.txtdBranchNO = new ICE.POS.Common.TextBoxEx(this.components);
            this.txtBranchNO = new ICE.POS.Common.TextBoxEx(this.components);
            this.txtSheetNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(666, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出(Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelAll.Location = new System.Drawing.Point(206, 463);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(90, 28);
            this.btnDelAll.TabIndex = 36;
            this.btnDelAll.Text = "删除全部";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Transparent;
            this.btnDel.Location = new System.Drawing.Point(110, 463);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(90, 28);
            this.btnDel.TabIndex = 35;
            this.btnDel.Text = "删除商品(Del)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.buttonEx1_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(752, 35);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "要货申请单";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApprove
            // 
            this.btnApprove.ForeColor = System.Drawing.Color.Transparent;
            this.btnApprove.Location = new System.Drawing.Point(659, 122);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(85, 28);
            this.btnApprove.TabIndex = 32;
            this.btnApprove.Text = "提交审核(F3)";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(567, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 28);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "保存(F2)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "按“Delete”键可删除选择商品";
            this.label4.Visible = false;
            // 
            // lblApprove
            // 
            this.lblApprove.AutoSize = true;
            this.lblApprove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApprove.Font = new System.Drawing.Font("隶书", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblApprove.ForeColor = System.Drawing.Color.Red;
            this.lblApprove.Location = new System.Drawing.Point(591, 58);
            this.lblApprove.Name = "lblApprove";
            this.lblApprove.Size = new System.Drawing.Size(128, 37);
            this.lblApprove.TabIndex = 29;
            this.lblApprove.Text = "已审核";
            this.lblApprove.Visible = false;
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.ForeColor = System.Drawing.Color.Transparent;
            this.btnSelectItem.Location = new System.Drawing.Point(13, 463);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(91, 28);
            this.btnSelectItem.TabIndex = 28;
            this.btnSelectItem.Text = "添加商品(F4)";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(98, 129);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(455, 21);
            this.txtRemark.TabIndex = 27;
            // 
            // dateValid
            // 
            this.dateValid.CustomFormat = "yyyy-MM-dd";
            this.dateValid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateValid.Location = new System.Drawing.Point(433, 100);
            this.dateValid.Name = "dateValid";
            this.dateValid.Size = new System.Drawing.Size(120, 21);
            this.dateValid.TabIndex = 26;
            // 
            // txtSqPersion
            // 
            this.txtSqPersion.Location = new System.Drawing.Point(432, 71);
            this.txtSqPersion.Name = "txtSqPersion";
            this.txtSqPersion.ReadOnly = true;
            this.txtSqPersion.Size = new System.Drawing.Size(121, 21);
            this.txtSqPersion.TabIndex = 25;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Location = new System.Drawing.Point(12, 160);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowTemplate.Height = 23;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvItemList.Size = new System.Drawing.Size(732, 296);
            this.dgvItemList.TabIndex = 24;
            this.dgvItemList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvItemList_CellBeginEdit);
            this.dgvItemList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellEndEdit);
            this.dgvItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItemList_KeyDown);
            // 
            // btnSelectBranch
            // 
            this.btnSelectBranch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSelectBranch.Location = new System.Drawing.Point(272, 98);
            this.btnSelectBranch.Name = "btnSelectBranch";
            this.btnSelectBranch.Size = new System.Drawing.Size(42, 23);
            this.btnSelectBranch.TabIndex = 23;
            this.btnSelectBranch.Text = "(F1)";
            this.btnSelectBranch.UseVisualStyleBackColor = true;
            this.btnSelectBranch.Click += new System.EventHandler(this.btnSelectBranch_Click);
            // 
            // txtdBranchNO
            // 
            this.txtdBranchNO.Location = new System.Drawing.Point(98, 100);
            this.txtdBranchNO.Name = "txtdBranchNO";
            this.txtdBranchNO.ReadOnly = true;
            this.txtdBranchNO.Size = new System.Drawing.Size(168, 21);
            this.txtdBranchNO.TabIndex = 22;
            // 
            // txtBranchNO
            // 
            this.txtBranchNO.Location = new System.Drawing.Point(98, 71);
            this.txtBranchNO.Name = "txtBranchNO";
            this.txtBranchNO.ReadOnly = true;
            this.txtBranchNO.Size = new System.Drawing.Size(216, 21);
            this.txtBranchNO.TabIndex = 22;
            // 
            // txtSheetNO
            // 
            this.txtSheetNO.Location = new System.Drawing.Point(98, 44);
            this.txtSheetNO.Name = "txtSheetNO";
            this.txtSheetNO.ReadOnly = true;
            this.txtSheetNO.Size = new System.Drawing.Size(216, 21);
            this.txtSheetNO.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "单    号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "发货门店：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "备    注：";
            // 
            // lblValide
            // 
            this.lblValide.AutoSize = true;
            this.lblValide.Location = new System.Drawing.Point(361, 105);
            this.lblValide.Name = "lblValide";
            this.lblValide.Size = new System.Drawing.Size(65, 12);
            this.lblValide.TabIndex = 17;
            this.lblValide.Text = "有效期限：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "申 请 人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "申请门店：";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "分店要货单"});
            this.cmbType.Location = new System.Drawing.Point(432, 44);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 20);
            this.cmbType.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "单据类型：";
            // 
            // FrmDmSheetDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(752, 496);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApprove);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.dateValid);
            this.Controls.Add(this.txtSqPersion);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.btnSelectBranch);
            this.Controls.Add(this.txtdBranchNO);
            this.Controls.Add(this.txtBranchNO);
            this.Controls.Add(this.txtSheetNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FrmDmSheetDetail";
            this.Load += new System.EventHandler(this.FrmDmSheetDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDmSheetDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private ButtonEx btnApprove;
        private ButtonEx btnDel;
        private ButtonEx btnExit;
        private ButtonEx btnSave;
        private ButtonEx btnSelectBranch;
        private ButtonEx btnSelectItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dateValid;
        private MyDataGridView dgvItemList;
        private System.Data.DataTable dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApprove;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblValide;
        private TextBoxEx txtBranchNO;
        private TextBoxEx txtdBranchNO;
        private TextBoxEx txtRemark;
        private System.Windows.Forms.TextBox txtSheetNO;
        private TextBoxEx txtSqPersion;
        #endregion
        private ButtonEx btnDelAll;
    }
}