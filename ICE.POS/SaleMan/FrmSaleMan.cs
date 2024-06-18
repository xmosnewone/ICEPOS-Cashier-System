namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;
    
    
    
    public partial class FrmSaleMan : FrmBase
    {
        #region 窗体全局声名
        
        
        
        
        
        public delegate void SetOperatorInfoDelegate(String _operatorId, String _operatorName);
        
        
        
        public event SetOperatorInfoDelegate SetOperatorInfo;
        #endregion
        #region 构造函数逻辑
        public FrmSaleMan()
        {
            InitializeComponent();
        }
        #endregion
        #region 窗体事件业务逻辑
        
        
        
        
        
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))// && e.KeyChar!=46) 小数点
            {
                e.Handled = true;
            }
        }
        
        
        
        
        
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IsOperInfo();
            }
        }
        
        
        
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            IsOperInfo();
        }

        #endregion
        #region 窗体私有方法
        
        
        
        
        private bool IsOperInfo()
        {
            bool flag = false;
            List<t_operator> _operatorList = Gattr.Bll.GetOperatorInfo(this.txtInput.Text.Trim(), Gattr.BranchNo);
            if (_operatorList == null || _operatorList.Count == 0)
            {
                MessageBox.Show("没有找到营业员信息，请重新输入！！！", Gattr.AppTitle);
            }
            else
            {
                if (_operatorList.Count == 1)
                {
                    if (SetOperatorInfo != null)
                    {
                        SetOperatorInfo(_operatorList[0].oper_id, _operatorList[0].full_name);
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    String _operatorId = "9999";
                    String _operatorName = "默认营业员";
                    FrmSaleManList frmSml = new FrmSaleManList(_operatorList);
                    frmSml.TopMost = true;
                    frmSml.SetOperatorInfoList += (id, name) =>
                    {
                        _operatorId = id;
                        _operatorName = name;
                    };
                    if (frmSml.ShowDialog() == DialogResult.OK)
                    {
                        if (SetOperatorInfo != null)
                        {
                            SetOperatorInfo(_operatorId, _operatorName);
                        }
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            return flag;
        }
        #endregion
    }
}
