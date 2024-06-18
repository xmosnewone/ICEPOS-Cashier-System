namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    public partial class FrmPayBalance : FrmBase
    {
        private decimal _payAmt = 0M;//支付金额
        private string _returnText = "";
        private decimal _returnMoney = 0M;
        private decimal _mCHA= 0M;
        private t_member_info _memberinfo = null;
        
        
        
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
        public FrmPayBalance()
        {
            InitializeComponent();
        }
        public FrmPayBalance(decimal payAmt, string defaultPayWay, t_member_info memberinfo,decimal moneyCha)
        {
            InitializeComponent();
            if (memberinfo != null)
            {
                //if (defaultPayWay.Equals("USD"))
                if (payAmt < 0)
                {
                    if (moneyCha >= payAmt)
                    {
                        this._mCHA = moneyCha;
                    }
                    else
                    {
                        this._mCHA = payAmt;
                    }
                    this.tbPayAmt.Text = Convert.ToDecimal(String.Format("{0:F}", _mCHA)).ToString();
                    this.tbPayAmt.Enabled = false;
                }
                else
                {
                    if (payAmt < memberinfo.balance)
                    {
                        this.tbPayAmt.Text = Convert.ToDecimal(String.Format("{0:F}", payAmt)).ToString();
                    }
                    else
                    {
                        this.tbPayAmt.Text = Convert.ToDecimal(String.Format("{0:F}", memberinfo.balance)).ToString();
                    }
                    this.tbPayAmt.Enabled = true;
                }
                this._returnText = defaultPayWay;
                this._payAmt = payAmt;
                this._memberinfo = memberinfo;
                this.tbMemberName.Text = _memberinfo.mem_no;
                this.tbMemberBalance.Text = Convert.ToDecimal(String.Format("{0:F}", _memberinfo.balance)).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(this.tbPayAmt.Text.Trim()))
                {
                    MessageBox.Show("付款金额不能为空！");
                    return;
                }
                else
                {
                    if (_returnText == "CHA")
                    {
                        if (_memberinfo != null)
                        {
                            if (this._payAmt > 0)
                            {
                                if (this._payAmt < ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()))
                                {
                                    MessageBox.Show("付款金额不能大于应收金额！", Gattr.AppTitle);
                                    return;
                                }
                                if (0 >= ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()))
                                {
                                    MessageBox.Show("付款金额不能小于等于0！", Gattr.AppTitle);
                                    return;
                                }
                                decimal _amt = ExtendUtility.Instance.ParseToDecimal(_memberinfo.balance);
                                if (ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()) > _amt)
                                {
                                    MessageBox.Show("付款金额不能大于会员账户余额！", Gattr.AppTitle);
                                    return;
                                }
                                //验证会员即可
                                t_member_info memberinfo = MemberService.Instance.GetMemberInfoByMemNo(_memberinfo.mem_no);
                                if (memberinfo.code == "-1")
                                {
                                        MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                                        LoggerHelper.Log("MsmkLogger", memberinfo.mem_no + "余额支付错误信息：" + memberinfo.info, LogEnum.SysLog);
                                        return;
                                }
                                //判断会员余额是否足够
                                if (memberinfo.code == "1") {
                                    
                                    if (ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()) > ExtendUtility.Instance.ParseToDecimal(memberinfo.balance))
                                    {
                                            MessageBox.Show("线上查询到会员账户余额不足！", Gattr.AppTitle);
                                            return;
                                     }
                                }
                            }
                            else
                            {
                                if (this._payAmt > ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()))
                                {
                                    MessageBox.Show("余额退款金额不能大于本单的总退款金额！", Gattr.AppTitle);
                                    return;
                                }
                                if (this._mCHA < ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()))
                                {
                                    MessageBox.Show("余额退款金额不能小于本单原有的余额支付金额！", Gattr.AppTitle);
                                    return;
                                }
                                if (0 == ExtendUtility.Instance.ParseToDecimal(this.tbPayAmt.Text.Trim()))
                                {
                                    MessageBox.Show("余额退款金额不能为0！", Gattr.AppTitle);
                                    return;
                                }
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

        private void tbPayAmt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    this.btnOK_Click(null, null);
                    break;
                case Keys.Escape:
                    DialogResult = DialogResult.Cancel;
                    break;
            }
        }
    }
}
