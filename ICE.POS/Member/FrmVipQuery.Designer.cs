﻿using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmVipQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVipQuery));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOK = new ICE.POS.Common.ButtonEx(this.components);
            this.btnCancel = new ICE.POS.Common.ButtonEx(this.components);
            this.lbText = new System.Windows.Forms.Label();
            this.keyBoard1 = new ICE.POS.KeyBoard();
            this.lbPrompt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.Location = new System.Drawing.Point(12, 41);
            this.txtInput.MaxLength = 30;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(305, 34);
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
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbText.Location = new System.Drawing.Point(85, 6);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(142, 19);
            this.lbText.TabIndex = 4;
            this.lbText.Text = "请输入会员编号";
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
            // lbPrompt
            // 
            this.lbPrompt.AutoSize = true;
            this.lbPrompt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPrompt.Location = new System.Drawing.Point(25, 265);
            this.lbPrompt.Name = "lbPrompt";
            this.lbPrompt.Size = new System.Drawing.Size(245, 14);
            this.lbPrompt.TabIndex = 5;
            this.lbPrompt.Text = "如果IC卡类型，请按F1读取会员信息。";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 33);
            this.panel1.TabIndex = 6;
            // 
            // FrmVipQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPrompt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.keyBoard1);
            this.Name = "FrmVipQuery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyBoard keyBoard1;
        private System.Windows.Forms.TextBox txtInput;
        private ButtonEx btnOK;
        private ButtonEx btnCancel;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbPrompt;
        private System.Windows.Forms.Panel panel1;
    }
}