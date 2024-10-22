using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmFlowNoSearch
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
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.lbMemo = new System.Windows.Forms.Label();
            this.lbReasonId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(284, 132);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 42);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(73, 132);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 42);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "确定(&Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMemo.Location = new System.Drawing.Point(23, 82);
            this.lbMemo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(71, 18);
            this.lbMemo.TabIndex = 21;
            this.lbMemo.Text = "原单号:";
            // 
            // lbReasonId
            // 
            this.lbReasonId.AutoSize = true;
            this.lbReasonId.Location = new System.Drawing.Point(33, 146);
            this.lbReasonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReasonId.Name = "lbReasonId";
            this.lbReasonId.Size = new System.Drawing.Size(0, 15);
            this.lbReasonId.TabIndex = 26;
            this.lbReasonId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 56);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始单号录入";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.Location = new System.Drawing.Point(100, 81);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(308, 28);
            this.txtInput.TabIndex = 29;
            // 
            // FrmFlowNoSearch
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 205);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbReasonId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbMemo);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmFlowNoSearch";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx btnCancel;
        private ButtonEx btnOK;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.Label lbReasonId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
    }
}