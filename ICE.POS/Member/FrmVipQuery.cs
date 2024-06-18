namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    public partial class FrmVipQuery : FrmBase
    {
        private decimal _num;
        public FrmVipQuery()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && this.SaveNum())
            {
                base.DialogResult = DialogResult.OK;
            }

        }
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
            return true;
        }

        public decimal Num
        {
            get
            {
                return this._num;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.SaveNum())
            {
                base.DialogResult = DialogResult.OK;
            }
        }
        
        
        
        
        
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))// && e.KeyChar!=46) 小数点
            {
                e.Handled = true;
            }
        }
    }
}
