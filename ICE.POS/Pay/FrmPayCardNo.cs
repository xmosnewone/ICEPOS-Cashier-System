namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    
    
    
    public partial class FrmPayCardNo : FrmBase
    {
        #region 界面全局声名
        
        
        
        
        
        
        public delegate void SetBCDCardAndMemoDelegate(String bcdCard, String memo, String payAmount);
        
        
        
        public event SetBCDCardAndMemoDelegate SetBCDCardAndMemo;
        #endregion
        #region 构造函数
        public FrmPayCardNo()
        {
            InitializeComponent();
        }
        public FrmPayCardNo(string title, string name, decimal payAmt)
        {
            InitializeComponent();
            this.lbTitle.Text = title;
            this.lbCardNo.Text = name;
            this.tbCardNo.Focus();
            this.tbPayAmt.Text = payAmt.ToString(Gattr.PosSaleAmtPoint);
        }
        #endregion
        #region  界面事件业务逻辑
        
        
        
        
        
        private void tbPayAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar)) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.LastIndexOf('.') != -1)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        
        
        
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SetBCDCardAndMemo != null)
            {
                SetBCDCardAndMemo(tbCardNo.Text.Trim(), tbMemo.Text.Trim(), tbPayAmt.Text.Trim());
            }
            DialogResult = DialogResult.OK;
        }
        
        
        
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            //this._isCancel = false;
            //base.Close();
        }
        #endregion


    }
}
