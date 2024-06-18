using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmSaleMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleMan));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSeach = new ICE.POS.Common.ButtonEx(this.components);
            this.keyBoard1 = new ICE.POS.KeyBoard();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.Location = new System.Drawing.Point(12, 48);
            this.txtInput.MaxLength = 4;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(242, 34);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(49, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(182, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbTitle.ForeColor = System.Drawing.Color.Blue;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(334, 38);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "请输入营业员编号";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeach
            // 
            this.btnSeach.ForeColor = System.Drawing.Color.Transparent;
            this.btnSeach.Location = new System.Drawing.Point(259, 48);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(59, 34);
            this.btnSeach.TabIndex = 14;
            this.btnSeach.Text = "查询";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // keyBoard1
            // 
            this.keyBoard1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.keyBoard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyBoard1.BackgroundImage")));
            this.keyBoard1.Location = new System.Drawing.Point(13, 94);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(305, 164);
            this.keyBoard1.TabIndex = 0;
            // 
            // FrmSaleMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(334, 272);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.keyBoard1);
            this.Name = "FrmSaleMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyBoard keyBoard1;
        private System.Windows.Forms.TextBox txtInput;
        private ButtonEx btnOK;
        private ButtonEx btnCancel;
        private System.Windows.Forms.Label lbTitle;
        private ButtonEx btnSeach;
    }
}