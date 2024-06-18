using ICE.POS.Common;
namespace ICE.POS
{
    partial class FrmVipInfoList
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
            this.btnOk = new ICE.POS.Common.ButtonEx(this.components);
            this.btnExit = new ICE.POS.Common.ButtonEx(this.components);
            this.dgvVipInfoList = new System.Windows.Forms.DataGridView();
            this.vip_card_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_spending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.all_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.use_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surplus_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingVipInfoList = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVipInfoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingVipInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Transparent;
            this.btnOk.Location = new System.Drawing.Point(268, 329);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定(&Enter)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(422, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "取消(&Esc)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvVipInfoList
            // 
            this.dgvVipInfoList.AllowUserToAddRows = false;
            this.dgvVipInfoList.AllowUserToDeleteRows = false;
            this.dgvVipInfoList.AllowUserToResizeColumns = false;
            this.dgvVipInfoList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVipInfoList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvVipInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVipInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vip_card_id,
            this.full_name,
            this.balance,
            this.total_spending,
            this.all_score,
            this.use_score,
            this.surplus_score,
            this.company,
            this.mobile,
            this.qq,
            this.email,
            this.reg_time});
            this.dgvVipInfoList.Location = new System.Drawing.Point(7, 42);
            this.dgvVipInfoList.MultiSelect = false;
            this.dgvVipInfoList.Name = "dgvVipInfoList";
            this.dgvVipInfoList.ReadOnly = true;
            this.dgvVipInfoList.RowTemplate.Height = 30;
            this.dgvVipInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVipInfoList.Size = new System.Drawing.Size(740, 270);
            this.dgvVipInfoList.TabIndex = 1;
            this.dgvVipInfoList.DoubleClick += new System.EventHandler(this.dgvOperList_DoubleClick);
            this.dgvVipInfoList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPenOrd_KeyDown);
            // 
            // vip_card_id
            // 
            this.vip_card_id.DataPropertyName = "vip_card_id";
            this.vip_card_id.HeaderText = "会员卡号";
            this.vip_card_id.Name = "vip_card_id";
            this.vip_card_id.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "会员名称";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "账户余额";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // total_spending
            // 
            this.total_spending.DataPropertyName = "total_spending";
            this.total_spending.HeaderText = "总消费金额";
            this.total_spending.Name = "total_spending";
            this.total_spending.ReadOnly = true;
            // 
            // all_score
            // 
            this.all_score.DataPropertyName = "all_score";
            this.all_score.HeaderText = "总积分";
            this.all_score.Name = "all_score";
            this.all_score.ReadOnly = true;
            // 
            // use_score
            // 
            this.use_score.DataPropertyName = "use_score";
            this.use_score.HeaderText = "已用积分";
            this.use_score.Name = "use_score";
            this.use_score.ReadOnly = true;
            // 
            // surplus_score
            // 
            this.surplus_score.DataPropertyName = "surplus_score";
            this.surplus_score.HeaderText = "剩余积分";
            this.surplus_score.Name = "surplus_score";
            this.surplus_score.ReadOnly = true;
            // 
            // company
            // 
            this.company.DataPropertyName = "company";
            this.company.HeaderText = "公司名称";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "联系电话";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // qq
            // 
            this.qq.DataPropertyName = "qq";
            this.qq.HeaderText = "QQ";
            this.qq.Name = "qq";
            this.qq.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // reg_time
            // 
            this.reg_time.DataPropertyName = "reg_time";
            this.reg_time.HeaderText = "注册时间";
            this.reg_time.Name = "reg_time";
            this.reg_time.ReadOnly = true;
            // 
            // bindingVipInfoList
            // 
            this.bindingVipInfoList.AllowNew = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "会员查询列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmVipInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(759, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVipInfoList);
            this.Name = "FrmVipInfoList";
            this.Load += new System.EventHandler(this.FrmVipInfoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVipInfoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingVipInfoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingVipInfoList;
        private ButtonEx btnOk;
        private ButtonEx btnExit;
        private System.Windows.Forms.DataGridView dgvVipInfoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vip_card_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_spending;
        private System.Windows.Forms.DataGridViewTextBoxColumn all_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn use_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn surplus_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn qq;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_time;
    }
}