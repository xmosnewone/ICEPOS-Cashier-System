using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmItemQuery
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
            this.pnlFill = new ICE.POS.Common.PanelEx(this.components);
            this.dgItem = new ICE.POS.Common.MyDataGridView();
            this.pnlTop = new ICE.POS.Common.PanelEx(this.components);
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.btnSerch = new ICE.POS.Common.ButtonEx(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelEx1 = new ICE.POS.Common.PanelEx(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dgItem);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 84);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(771, 280);
            this.pnlFill.TabIndex = 23;
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToResizeColumns = false;
            this.dgItem.AllowUserToResizeRows = false;
            this.dgItem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgItem.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgItem.Location = new System.Drawing.Point(0, 0);
            this.dgItem.MultiSelect = false;
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowTemplate.Height = 23;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.ShowCellErrors = false;
            this.dgItem.Size = new System.Drawing.Size(771, 280);
            this.dgItem.TabIndex = 5;
            this.dgItem.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgItem_CellMouseDoubleClick);
            this.dgItem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgItem_DataError);
            this.dgItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgItem_KeyDown);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtSearchKey);
            this.pnlTop.Controls.Add(this.btnSerch);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(771, 84);
            this.pnlTop.TabIndex = 22;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchKey.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtSearchKey.Location = new System.Drawing.Point(82, 49);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(582, 21);
            this.txtSearchKey.TabIndex = 5;
            this.txtSearchKey.Text = "可输入货号、自编码、商品名、类别、品牌关键字进行查询";
            this.txtSearchKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchKey_MouseClick);
            // 
            // btnSerch
            // 
            this.btnSerch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSerch.Location = new System.Drawing.Point(670, 45);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(89, 28);
            this.btnSerch.TabIndex = 4;
            this.btnSerch.Text = "查询(Enter)";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "关键字：";
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
            this.lblTitle.Size = new System.Drawing.Size(771, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "商品查询";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEx1
            // 
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.btnCancel);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 364);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(771, 40);
            this.panelEx1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "按F5键或Enter键选择当前行商品返回";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(675, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "退出(ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmItemQuery
            // 
            this.AcceptButton = this.btnSerch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(771, 404);
            this.ControlBox = true;
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FrmItemQuery";
            this.ShowIcon = true;
            this.Activated += new System.EventHandler(this.FrmItemQuery_Activated);
            this.Load += new System.EventHandler(this.FrmItemQuery_Load);
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnSerch;
        private MyDataGridView dgItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private PanelEx panelEx1;
        private PanelEx pnlFill;
        private PanelEx pnlTop;
        private System.Windows.Forms.TextBox txtSearchKey;
    }
}