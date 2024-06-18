namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;
    
    public partial class FrmPayBack : FrmBase
    {
        
        public delegate void DelegateSetReasonID(String _reasonid);
        
        public event DelegateSetReasonID EventSetReasonID;
        #region 窗体构造函数
        public FrmPayBack()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmPayBack_Load);
        }
        #endregion
        #region 窗口事件逻辑
        void FrmPayBack_Load(object sender, EventArgs e)
        {
            List<t_base_code> reasonDic = Gattr.Bll.GetReasonInfos("");
            this.cbReason.Items.Clear();
            this.cbReason.DataSource = reasonDic;
            this.cbReason.DisplayMember = "code_name";
            this.cbReason.ValueMember = "code_id";
        }
        
        
        
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            SetReasonID();
        }
        
        
        
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
        
        
        
        
        private void cbReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetReasonID();
                e.Handled = true;
            }
        }
        #endregion
        #region 窗体私有方法
        void SetReasonID()
        {
            if (this.cbReason.SelectedIndex >= 0)
            {
                t_base_code model = this.cbReason.SelectedItem as t_base_code;
                if (EventSetReasonID != null)
                {
                    EventSetReasonID(model.code_id.ToString());
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请选择退货原因");
            }
        }
        #endregion
    }
}
