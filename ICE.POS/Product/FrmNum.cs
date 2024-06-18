namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    
    
    
    public partial class FrmNum : FrmBase
    {
        #region 全局声名
        #endregion
        private decimal _num;
        #region 构造函数
        public FrmNum()
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
            this.ActiveControl = txtInput;
            txtInput.Focus();
        }
        #endregion
        #region 窗体事件业务逻辑
        
        
        
        
        
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveNum();
            }
        }
        
        
        
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveNum();
        }
        
        
        
        
        
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion
        #region 窗体私有事件逻辑
        
        
        
        
        private bool SaveNum()
        {
            if (string.IsNullOrEmpty(this.txtInput.Text.Trim()))
            {
                MessageBox.Show("数量不能为空！");
                return false;
            }
            if (!Gfunc.IsDigit(this.txtInput.Text.Trim()))
            {
                MessageBox.Show("数量含有非法数值！");
                return false;
            }
            if (Convert.ToDecimal(this.txtInput.Text.Trim()) == 0M)
            {
                MessageBox.Show("数量不能等于0！");
                return false;
            }
            this._num = Convert.ToDecimal(this.txtInput.Text.Trim());
            DialogResult = DialogResult.OK;
            return true;
        }
        #endregion



        public decimal Num
        {
            get
            {
                return this._num;
            }
        }




    }
}
