using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmPriceInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPriceInput));
            this.keyBoard1 = new ICE.POS.KeyBoard();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.lbText = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbItemPrice = new System.Windows.Forms.Label();
            this.txtInput = new ICE.POS.Common.TextBoxEx(this.components);
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyBoard1
            // 
            this.keyBoard1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.keyBoard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyBoard1.BackgroundImage")));
            this.keyBoard1.Location = new System.Drawing.Point(12, 146);
            this.keyBoard1.Name = "keyBoard1";
            this.keyBoard1.Size = new System.Drawing.Size(305, 164);
            this.keyBoard1.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(22, 120);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 20);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "价   格：";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(184, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消(&Esc)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(51, 323);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定(&Enter)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbText
            // 
            this.lbText.BackColor = System.Drawing.Color.White;
            this.lbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbText.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbText.ForeColor = System.Drawing.Color.Blue;
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(334, 40);
            this.lbText.TabIndex = 5;
            this.lbText.Text = "请输入单价";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb1.Location = new System.Drawing.Point(22, 52);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(63, 20);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "商   品：";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb2.Location = new System.Drawing.Point(22, 88);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(63, 20);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "原   价：";
            // 
            // lbItemName
            // 
            this.lbItemName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItemName.Location = new System.Drawing.Point(87, 45);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(240, 45);
            this.lbItemName.TabIndex = 7;
            this.lbItemName.Text = "商品";
            // 
            // lbItemPrice
            // 
            this.lbItemPrice.AutoSize = true;
            this.lbItemPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItemPrice.Location = new System.Drawing.Point(87, 88);
            this.lbItemPrice.Name = "lbItemPrice";
            this.lbItemPrice.Size = new System.Drawing.Size(37, 20);
            this.lbItemPrice.TabIndex = 7;
            this.lbItemPrice.Text = "原价";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.Location = new System.Drawing.Point(91, 118);
            this.txtInput.MaxLength = 10;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(184, 26);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextType = 2;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl3.Location = new System.Drawing.Point(278, 119);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(49, 20);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "(1-99)";
            this.lbl3.Visible = false;
            // 
            // FrmPriceInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(334, 315);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbItemPrice);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.keyBoard1);
            this.Name = "FrmPriceInput";
            this.Load += new System.EventHandler(this.FrmPriceInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyBoard keyBoard1;
        private System.Windows.Forms.Label lbName;
        private ButtonEx btnCancel;
        private ButtonEx btnOK;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbItemPrice;
        private TextBoxEx txtInput;
        private System.Windows.Forms.Label lbl3;
    }
}