namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    public partial class FrmPayCou : FrmBase
    {
        private decimal _payAmt = 0M;
        private decimal _returnMoney = 0M;
        private string _returnText = "";
        public FrmPayCou()
        {
            InitializeComponent();
        }

        public FrmPayCou(decimal payAmt)
        {
            InitializeComponent();
            this._payAmt = payAmt;
            this.tbWaitPayAmt.Text = this._payAmt.ToString(Gattr.PosSaleAmtPoint);
        }

        private void FrmPayWay_Load(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(this.tbPayAmt.Text.Trim()) >= 0M)
            {

            }
            else
            {
                MessageBox.Show("帐户余额不足！！！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbPayAmt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    this.btnOK_Click(null, null);
                    break;
            }
        }
        
        
        
        public decimal ReturnMoney
        {
            get
            {
                return this._returnMoney;
            }
        }
        public string ReturnText
        {
            get
            {
                return this._returnText;
            }
        }

    }
}
