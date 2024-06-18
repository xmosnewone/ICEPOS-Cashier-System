namespace ICE.POS
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class FrmPriceInput : FrmBase
    {
        private decimal _returnNumber = 0.00M;


        public FrmPriceInput()
        {
            InitializeComponent();
        }
        public FrmPriceInput(string name, string text)
        {
            InitializeComponent();
            this.lbName.Text = name;
            this.lbText.Text = text;
            base.ClientSize = new Size(340, 275);

            this.keyBoard1.Location = new Point(15, 100);
            this.lbName.Location = new Point(22, 58);
            this.txtInput.Location = new Point(91, 57);
            this.lbl3.Location = new Point(278, 58);
            this.lbl3.Visible = true;

            this.lb1.Visible = false;
            this.lb2.Visible = false;
            this.lbItemName.Visible = false;
            this.lbItemPrice.Visible = false;

        }
        public FrmPriceInput(string name, string text, string itemNameNo, string itemPrice)
        {
            InitializeComponent();
            this.lbName.Text = name;
            this.lbText.Text = text;
            this.lbItemName.Text = itemNameNo;
            this.lbItemPrice.Text = itemPrice;
            if (name == "折扣值：")
            {
                this.lbl3.Visible = true;
            }
        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && this.CheckPrice())
            {
                base.DialogResult = DialogResult.OK;
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.CheckPrice())
            {
                base.DialogResult = DialogResult.OK;
            }
        }
        
        
        
        
        
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != 46) //小数点
            {
                e.Handled = true;
            }
        }

        private bool CheckPrice()
        {
            if (string.IsNullOrEmpty(this.txtInput.Text.Trim()))
            {
                MessageBox.Show("价格不能为空!");
                this.txtInput.Text = 0.ToString(Gattr.PosSalePrcPoint);
                return false;
            }
            this._returnNumber = Convert.ToDecimal(this.txtInput.Text.Trim());
            if (this._returnNumber > 99999M)
            {
                MessageBox.Show("价格值过大，请重新输入！");
                this.txtInput.Text = "0.00";
                return false;
            }
            if ((this._returnNumber == 0M))
            {
                MessageBox.Show("不允许销售售价为零的商品!");

                return false;
            }
            return true;
        }
        public decimal GetNumber
        {
            get { return _returnNumber; }
        }

        private void FrmPriceInput_Load(object sender, EventArgs e)
        {
            this.txtInput.Focus();
            this.txtInput.SelectAll();
        }

    }
}
