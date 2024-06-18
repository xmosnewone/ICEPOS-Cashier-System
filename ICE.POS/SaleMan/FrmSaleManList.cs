namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;
    
    
    
    public partial class FrmSaleManList : FrmBase
    {
        #region 全局声名
        
        
        
        
        
        public delegate void SetOperatorInfoListDelegate(String _operatorId, String _operatorName);
        
        
        
        public event SetOperatorInfoListDelegate SetOperatorInfoList;
        
        
        
        List<t_operator> _currentList;
        #endregion
        #region 构造函数逻辑
        public FrmSaleManList(List<t_operator> list)
        {
            InitializeComponent();
            _currentList = list;
        }
        #endregion
        #region 窗体事件逻辑
        
        
        
        
        
        private void FrmSaleManList_Load(object sender, EventArgs e)
        {
            this.dgvOperList.AutoGenerateColumns = false;
            this.bindingOperList.DataSource = _currentList;
            this.dgvOperList.DataSource = this.bindingOperList;
            this.dgvOperList.Refresh();
        }
        
        
        
        
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectOperator();
        }
        
        
        
        
        
        private void dgvPenOrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectOperator();
            }
        }
        
        
        
        
        
        private void dgvOperList_DoubleClick(object sender, EventArgs e)
        {
            SelectOperator();
        }
        
        
        
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion
        #region 窗体私有方法
        
        
        
        void SelectOperator()
        {
            String _operatorId = "9999";
            String _operatorName = "默认营业员";
            if (this.dgvOperList.CurrentRow.Index >= 0)
            {
                if (this.dgvOperList.Rows[this.dgvOperList.CurrentRow.Index].Cells["oper_id"].Value != null)
                {
                    _operatorId = dgvOperList.Rows[this.dgvOperList.CurrentRow.Index].Cells["oper_id"].Value.ToString();
                    _operatorName = dgvOperList.Rows[this.dgvOperList.CurrentRow.Index].Cells["full_name"].Value.ToString();
                }
            }
            if (SetOperatorInfoList != null)
            {
                SetOperatorInfoList(_operatorId, _operatorName);
            }
            DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
