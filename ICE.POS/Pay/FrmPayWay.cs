namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    
    
    
    public partial class FrmPayWay : FrmBase
    {
        private decimal _payAmt = 0M;
        private string _returnText = "";
        private decimal _returnMoney = 0M;
        private t_member_info _memberinfo = null;
        //string defaultPayWay = "";
        public FrmPayWay()
        {
            InitializeComponent();
        }

        public FrmPayWay(decimal payAmt, string defaultPayWay, string sellWay, t_member_info memberinfo)
        {
            InitializeComponent();

            //if (defaultPayWay.Equals("USD"))
            if (sellWay.Equals("D"))
            {
                this.lbTitle.Text = "请选择找零方式";
            }
            this.sale_way = sellWay;
            this.tbPayAmt.Text = Convert.ToDecimal(String.Format("{0:F}", payAmt)).ToString();
            this._returnText = defaultPayWay;
            this._payAmt = payAmt;
            this._memberinfo = memberinfo;

        }

        private void FrmPayWay_Load(object sender, EventArgs e)
        {
            //
            try
            {
                this.cbPayWay.Items.Clear();
                int num = -1;
                int num2 = 0;
                string where = " pay_flag = '0' and pay_way not in ('CHA','CHG','MOY','RPA','RTN','DJF','GZH','ORD','SHC','SVP','CFP','HKD','USD','GIF','SHP')";
                if (this.sale_way.Equals("D"))
                {
                    where = " pay_flag = '0' and pay_way not in ('CHG','MOY','RPA','RTN','DJF','GZH','ORD','SHC','SVP','CHQ','CRD','SAV','SHP','VIP', 'CFP','HKD','USD','GIF') ";
                }
                List<t_dict_payment_info> payInfo = Gattr.Bll.GetPaymentInfo(where);
                if (payInfo == null)
                {
                    payInfo = new List<t_dict_payment_info>();
                }
                foreach (t_dict_payment_info _info in payInfo)
                {
                    this.cbPayWay.Items.Add(new ListItem(string.Format("[{0}]{1}", _info.pay_way, _info.pay_name), _info.rate.ToString()));
                    if (_info.pay_way.Equals(this._returnText))
                    {
                        num = num2;
                    }
                    num2++;
                }
                this.cbPayWay.DisplayMember = "Key";
                this.cbPayWay.ValueMember = "Value";
                this._returnText = "";
                payInfo.Clear();
                if (this.cbPayWay.Items.Count > 0)
                {
                    if (num == -1)
                    {
                        this.cbPayWay.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cbPayWay.SelectedIndex = num;
                    }
                }
                this.cbPayWay.Focus();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void cbPayWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbPayAmt.Text = (this.PayAmt / Convert.ToDecimal(this.cbPayWay.SelectedItem.ToString())).ToString("0.00");
            ListItem list = (ListItem)this.cbPayWay.SelectedItem;
            string key = list.Key;
            int index = key.IndexOf(']');
            key = key.Substring(0, index).Substring(1);

            if (this.sale_way.Equals("D"))
            {
                this.tbPayAmt.ReadOnly = false;
            }
            else
            {
                if (key.ToUpper() == "VIP" || key.ToUpper() == "CRD" || key.ToUpper().Equals("HF") || key.ToUpper().Equals("CHA"))
                {
                    this.tbPayAmt.ReadOnly = false;
                }
                else
                {
                    this.tbPayAmt.ReadOnly = true;
                }
            }
            //if (key.Length != 0)
            //{
            //    if (key.Equals("USD"))
            //    {
            //        this.tbPayAmt.ReadOnly = false;
            //    }
            //    else if (key.Equals("HKD"))
            //    {
            //        this.tbPayAmt.ReadOnly = false;
            //    }
            //    else if (key.Equals("VIP"))
            //    {
            //        this.tbPayAmt.ReadOnly = false;
            //    }
            //    else if (key.Equals("HF"))
            //    {
            //        this.tbPayAmt.ReadOnly = false;
            //    }
            //    else
            //    {
            //        this.tbPayAmt.ReadOnly = true;
            //    }
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ListItem list = (ListItem)this.cbPayWay.SelectedItem;
            string key = list.Key;
            int index = key.IndexOf(']');
            this._returnText = key.Substring(0, index).Substring(1);
            if (key.Length != 0)
            {
                if (string.IsNullOrEmpty(this.tbPayAmt.Text.Trim()))
                {
                    MessageBox.Show("付款金额不能为空！");
                }
                else
                {
                    if (_returnText == "HF")
                    {
                        if (this._payAmt < ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()))
                        {
                            MessageBox.Show("付款金额不能大于应收金额！", Gattr.AppTitle);
                            return;
                        }
                    }
                    if (_returnText == "CHA")
                    {
                        if (_memberinfo != null)
                        {
                            if (this._payAmt < ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()))
                            {
                                MessageBox.Show("付款金额不能大于应收金额！", Gattr.AppTitle);
                                return;
                            }
                            decimal _amt = ExtendUtility.Instance.ParseToDecimal(_memberinfo.balance);
                            if (this._payAmt > _amt)
                            {
                                MessageBox.Show("付款金额不能大于会员账户余额！", Gattr.AppTitle);
                                return;
                            }
                            t_member_info memberinfo = MemberService.Instance.GetValidateCode(_memberinfo.mem_no);
                            if (memberinfo.code == "-1")
                            {
                                if (string.IsNullOrEmpty(memberinfo.info))
                                {
                                    MessageBox.Show("验证码发送失败,请尝试重新发送或者使用其他方式支付！", Gattr.AppTitle);
                                }
                                else
                                {
                                    MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                                }
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("会员信息不存在，不能使用余额支付！", Gattr.AppTitle);
                            return;
                        }
                    }


                    decimal.TryParse(this.tbPayAmt.Text.Trim(), out this._returnMoney);
                    this.ReturnMoney = this._returnMoney;
                    this.DialogResult = DialogResult.OK;
                }
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
        private string _sale_way = "A";
        
        
        
        public string sale_way
        {
            get { return _sale_way; }
            set { _sale_way = value; }
        }
        
        
        
        private decimal PayAmt
        {
            get
            {
                return this._payAmt;
            }
            set
            {
                this._payAmt = value;
            }
        }
        
        
        
        public string ReturnPayWay
        {
            get
            {
                return this._returnText;
            }
        }
        
        
        
        public decimal ReturnMoney
        {
            get
            {
                return this._returnMoney;
            }
            set
            {
                this._returnMoney = value;
            }
        }

    }
}
