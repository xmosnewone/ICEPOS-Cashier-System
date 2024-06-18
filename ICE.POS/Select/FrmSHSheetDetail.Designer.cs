using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmSHSheetDetail
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
            this.txtSheetNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBranchNO = new ICE.POS.Common.TextBoxEx(this.components);
            this.txtdBranchNO = new ICE.POS.Common.TextBoxEx(this.components);
            this.dgvItemList = new ICE.POS.Common.MyDataGridView();
            this.btnApprove = new ICE.POS.Common.ButtonEx(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCzPersion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCzTime = new System.Windows.Forms.TextBox();
            this.lblApprove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(619, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "退出(Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "申请门店：";
            // 
            // txtBranchNO
            // 
            this.txtBranchNO.Location = new System.Drawing.Point(98, 71);
            this.txtBranchNO.Name = "txtBranchNO";
            this.txtBranchNO.ReadOnly = true;
            this.txtBranchNO.Size = new System.Drawing.Size(216, 21);
            this.txtBranchNO.TabIndex = 22;
            // 
            // txtdBranchNO
            // 
            this.txtdBranchNO.Location = new System.Drawing.Point(98, 100);
            this.txtdBranchNO.Name = "txtdBranchNO";
            this.txtdBranchNO.ReadOnly = true;
            this.txtdBranchNO.Size = new System.Drawing.Size(216, 21);
            this.txtdBranchNO.TabIndex = 22;
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
            this.dgvItemList.Location = new System.Drawing.Point(10, 136);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowTemplate.Height = 23;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvItemList.Size = new System.Drawing.Size(732, 320);
            this.dgvItemList.TabIndex = 24;
            this.dgvItemList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvItemList_CellBeginEdit);
            this.dgvItemList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellEndEdit);
            // 
            // btnApprove
            // 
            this.btnApprove.ForeColor = System.Drawing.Color.Transparent;
            this.btnApprove.Location = new System.Drawing.Point(458, 462);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(86, 28);
            this.btnApprove.TabIndex = 32;
            this.btnApprove.Text = "确认收货(F3)";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
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
            this.lblTitle.Text = "收货单详情";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "操 作 人：";
            // 
            // txtCzPersion
            // 
            this.txtCzPersion.Location = new System.Drawing.Point(399, 69);
            this.txtCzPersion.Name = "txtCzPersion";
            this.txtCzPersion.ReadOnly = true;
            this.txtCzPersion.Size = new System.Drawing.Size(121, 21);
            this.txtCzPersion.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "操作时间：";
            // 
            // txtCzTime
            // 
            this.txtCzTime.Location = new System.Drawing.Point(399, 100);
            this.txtCzTime.Name = "txtCzTime";
            this.txtCzTime.ReadOnly = true;
            this.txtCzTime.Size = new System.Drawing.Size(121, 21);
            this.txtCzTime.TabIndex = 38;
            // 
            // lblApprove
            // 
            this.lblApprove.AutoSize = true;
            this.lblApprove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApprove.Font = new System.Drawing.Font("隶书", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblApprove.ForeColor = System.Drawing.Color.Red;
            this.lblApprove.Location = new System.Drawing.Point(566, 75);
            this.lblApprove.Name = "lblApprove";
            this.lblApprove.Size = new System.Drawing.Size(128, 37);
            this.lblApprove.TabIndex = 39;
            this.lblApprove.Text = "已收货";
            this.lblApprove.Visible = false;
            // 
            // FrmSHSheetDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(752, 496);
            this.Controls.Add(this.lblApprove);
            this.Controls.Add(this.txtCzTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCzPersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.txtdBranchNO);
            this.Controls.Add(this.txtBranchNO);
            this.Controls.Add(this.txtSheetNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FrmSHSheetDetail";
            this.Load += new System.EventHandler(this.FrmDmSheetDetail_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDmSheetDetail_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private ButtonEx btnApprove;
        private ButtonEx btnExit;

        private MyDataGridView dgvItemList;
        private System.Data.DataTable dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitle;
        private TextBoxEx txtBranchNO;
        private TextBoxEx txtdBranchNO;
        private System.Windows.Forms.TextBox txtSheetNO;
        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCzPersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCzTime;
        private System.Windows.Forms.Label lblApprove;
    }
}