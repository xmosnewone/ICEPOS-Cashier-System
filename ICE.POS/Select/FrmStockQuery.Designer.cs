using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmStockQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnok = new ICE.POS.Common.ButtonEx(this.components);
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.buttonEx3 = new ICE.POS.Common.ButtonEx(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEx2 = new ICE.POS.Common.ButtonEx(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEx1 = new ICE.POS.Common.ButtonEx(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectBranch = new ICE.POS.Common.ButtonEx(this.components);
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtBranchNO = new System.Windows.Forms.TextBox();
            this.btnDm = new ICE.POS.Common.ButtonEx(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.ForeColor = System.Drawing.Color.Transparent;
            this.btnok.Location = new System.Drawing.Point(699, 72);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(81, 21);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "查询(Enter)";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(736, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "退出(ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // buttonEx3
            // 
            this.buttonEx3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEx3.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx3.Location = new System.Drawing.Point(171, 88);
            this.buttonEx3.Name = "buttonEx3";
            this.buttonEx3.Size = new System.Drawing.Size(40, 22);
            this.buttonEx3.TabIndex = 15;
            this.buttonEx3.Tag = "2";
            this.buttonEx3.Text = "(&F6)";
            this.buttonEx3.UseVisualStyleBackColor = true;
            this.buttonEx3.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.textBox3.Location = new System.Drawing.Point(90, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 21);
            this.textBox3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "供应商(F6)：";
            // 
            // buttonEx2
            // 
            this.buttonEx2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEx2.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx2.Location = new System.Drawing.Point(619, 58);
            this.buttonEx2.Name = "buttonEx2";
            this.buttonEx2.Size = new System.Drawing.Size(40, 22);
            this.buttonEx2.TabIndex = 12;
            this.buttonEx2.Tag = "1";
            this.buttonEx2.Text = "(&F5)";
            this.buttonEx2.UseVisualStyleBackColor = true;
            this.buttonEx2.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.textBox2.Location = new System.Drawing.Point(538, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 21);
            this.textBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(458, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "商品品牌(F5)：";
            // 
            // buttonEx1
            // 
            this.buttonEx1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEx1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx1.Location = new System.Drawing.Point(396, 56);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(40, 22);
            this.buttonEx1.TabIndex = 9;
            this.buttonEx1.Tag = "0";
            this.buttonEx1.Text = "(&F4)";
            this.buttonEx1.UseVisualStyleBackColor = true;
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.textBox1.Location = new System.Drawing.Point(315, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 21);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(232, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "商品分类(F4)：";
            // 
            // btnSelectBranch
            // 
            this.btnSelectBranch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectBranch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSelectBranch.Location = new System.Drawing.Point(171, 56);
            this.btnSelectBranch.Name = "btnSelectBranch";
            this.btnSelectBranch.Size = new System.Drawing.Size(40, 22);
            this.btnSelectBranch.TabIndex = 2;
            this.btnSelectBranch.Text = "(&F3)";
            this.btnSelectBranch.UseVisualStyleBackColor = true;
            this.btnSelectBranch.Click += new System.EventHandler(this.btnSelectBranch_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKey.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtKey.Location = new System.Drawing.Point(315, 89);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(344, 21);
            this.txtKey.TabIndex = 3;
            this.txtKey.Text = "支持 货号、商品名 关键字查询";
            this.txtKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKey_MouseClick);
            this.txtKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmStockQuery_KeyUp);
            this.txtKey.Leave += new System.EventHandler(this.txtKey_Leave);
            // 
            // txtBranchNO
            // 
            this.txtBranchNO.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBranchNO.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtBranchNO.Location = new System.Drawing.Point(90, 56);
            this.txtBranchNO.Name = "txtBranchNO";
            this.txtBranchNO.Size = new System.Drawing.Size(78, 21);
            this.txtBranchNO.TabIndex = 1;
            this.txtBranchNO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmStockQuery_KeyUp);
            // 
            // btnDm
            // 
            this.btnDm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDm.Location = new System.Drawing.Point(626, 457);
            this.btnDm.Name = "btnDm";
            this.btnDm.Size = new System.Drawing.Size(96, 28);
            this.btnDm.TabIndex = 6;
            this.btnDm.Text = "要货申请(&F8)";
            this.btnDm.UseVisualStyleBackColor = true;
            this.btnDm.Visible = false;
            this.btnDm.Click += new System.EventHandler(this.btnDm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "门  店(F3)：";
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
            this.lblTitle.Size = new System.Drawing.Size(823, 35);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "库存查询";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToResizeColumns = false;
            this.dgItem.AllowUserToResizeRows = false;
            this.dgItem.BackgroundColor = System.Drawing.Color.White;
            this.dgItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgItem.Location = new System.Drawing.Point(7, 121);
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowTemplate.Height = 23;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(808, 329);
            this.dgItem.StandardTab = true;
            this.dgItem.TabIndex = 5;
            this.dgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellClick);
            this.dgItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItem_CellDoubleClick);
            this.dgItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmStockQuery_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(221, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "商品关键字(F7)：";
            // 
            // FrmStockQuery
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(823, 496);
            this.ControlBox = true;
            this.Controls.Add(this.buttonEx3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEx2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEx1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectBranch);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtBranchNO);
            this.Controls.Add(this.btnDm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.dgItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.KeyPreview = true;
            this.Name = "FrmStockQuery";
            this.Activated += new System.EventHandler(this.FrmStockQuery_Activated);
            this.Load += new System.EventHandler(this.FrmStockQuery_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStockQuery_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmStockQuery_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnDm;
        private ButtonEx btnok;
        private ButtonEx btnSelectBranch;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBranchNO;
        private System.Windows.Forms.TextBox txtKey;
        private string TxtTitle = "支持 货号、商品名 关键字查询";
        private ButtonEx buttonEx1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private ButtonEx buttonEx2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private ButtonEx buttonEx3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}