using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.POS.Common;
using ICE.POS.Model;
using ICE.Utility;

namespace ICE.POS
{
    public partial class FrmPayWayAlter : FrmBase
    {
        private decimal _payAmt = 0M;
        private string _returnText = "";
        private decimal _returnMoney = 0M;
        private t_pos_payflow _payflow = null;
        private bool _isAdd = true;//是否是添加
        private bool _isF = false;//是否是回款

        public FrmPayWayAlter()
        {
            InitializeComponent();
        }
        
        
        
        public FrmPayWayAlter(t_pos_payflow _payFlow,bool isAdd,bool isF)
        {
            InitializeComponent();
            this._payflow = _payFlow;
            this._isAdd = isAdd;
            this._isF = isF;
            if (!isAdd)
            {
                this.txtAmount.Text = _payFlow.pay_amount.ToString();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            AddPayFow(_payflow, _isAdd);
        }
       
       
       
       
       
        private void AddPayFow(t_pos_payflow payFlow,bool isAdd)
        {
            if (!PosServericeBll.Instance.TestConnect())
            {
                MessageBox.Show("断网状态，操作取消!", Gattr.AppTitle);
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtAmount.Text.Trim()))
                {
                    MessageBox.Show("金额不能为空！");
                    this.txtAmount.Focus();
                }
                else
                {
                    decimal amount = 0M;
                    amount = Convert.ToDecimal(this.txtAmount.Text.Trim());
                    if (amount < 0M)
                    {
                        MessageBox.Show("金额必须大于等于零！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.txtAmount.SelectAll();
                        this.txtAmount.Focus();
                    }
                    else if (amount > payFlow.sale_amount)
                    {
                        MessageBox.Show("金额值过大！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.txtAmount.SelectAll();
                        this.txtAmount.Focus();
                    }
                    else
                    {
                        try
                        {
                            ListItem list = (ListItem)this.cbox_PayWay.SelectedItem;
                            string key = list.Key;
                            int index = key.IndexOf(']');
                            this._returnText = key.Substring(0, index).Substring(1);
                            string flowNo = payFlow.flow_no;
                            string pay_name = list.Key.Substring(list.Key.LastIndexOf("]") + 1);
                            t_pos_payflow _pay = new t_pos_payflow();
                            if (isAdd)
                            {
                                _pay.flow_id = payFlow.flow_id + 1;
                                _pay.oper_date = System.DateTime.Now.ToString("s");
                                _pay.com_flag = "0";
                            }
                            else
                            {
                                _pay.flow_id = payFlow.flow_id;
                                _pay.com_flag = "1";
                            }
                            _pay.flow_no = flowNo;
                            _pay.branch_no = payFlow.branch_no;
                            if (_isF)
                            {
                                _pay.sale_way = "F";
                            }
                            else
                            {
                                _pay.sale_way = "A";
                            }
                            _pay.sale_amount = payFlow.sale_amount;
                            _pay.pay_way = _returnText;//支付方式
                            _pay.oper_id = payFlow.oper_id;
                            _pay.pos_id = payFlow.pos_id;
                            _pay.pay_amount = amount;
                            _pay.coin_rate = 1M;
                            _pay.convert_amt = amount;
                            _pay.memo = this.txtMemo.Text.Trim();
                            _pay.coin_type = _returnText;
                            _pay.pay_name = pay_name;

                            bool isOK = false;
                            string message = string.Empty;
                            if(isAdd)
                            {
                                isOK = Gattr.Bll.SaveNonTrading(_pay);
                                message = "添加";
                            }
                            else
                            {
                                Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                                //flow_no，flow_id，pay_way，pay_name，pay_amount
                                _dic.Add("flow_no", _pay.flow_no);
                                _dic.Add("flow_id", _pay.flow_id);
                                _dic.Add("pay_way", _pay.pay_way);
                                _dic.Add("pay_name", _pay.pay_name);
                                _dic.Add("pay_amount", _pay.pay_amount);
                                string errorMessage = string.Empty; bool isok = false;
                                string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Updatepayflow", _dic, ref isok, ref errorMessage);
                                message = "修改";
                                if (result == "1")
                                {
                                    LoggerHelper.Log("MsmkLogger", flowNo + message + "接口Updatepayflow更新支付成功", LogEnum.SysLog);
                                    isOK = Gattr.Bll.UpdatePayFlowByFid(_pay);
                                }
                                else
                                {
                                    LoggerHelper.Log("MsmkLogger", flowNo + message + "接口Updatepayflow更新失败", LogEnum.SysLog);
                                    isOK = false;
                                }
                            }

                            if (isOK)
                            {
                                MessageBox.Show(message + "支付成功", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                LoggerHelper.Log("MsmkLogger", flowNo + message + "支付成功", LogEnum.SysLog);
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show(message + "支付失败！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                LoggerHelper.Log("MsmkLogger", flowNo + message + "支付失败", LogEnum.SysLog);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("调整支付方式失败！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            LoggerHelper.Log("MsmkLogger", "修改支付----调整支付方式失败", LogEnum.ExceptionLog);
                        }
                    }
                }
            }
        }

        private void FrmPayWayAlter_Load(object sender, EventArgs e)
        {
            try
            {
                //获取支付方式
                this.cbox_PayWay.Items.Clear();
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
                    this.cbox_PayWay.Items.Add(new ListItem(string.Format("[{0}]{1}", _info.pay_way, _info.pay_name), _info.rate.ToString()));
                    if (_info.pay_way.Equals(this._returnText))
                    {
                        num = num2;
                    }
                    num2++;
                }
                this.cbox_PayWay.DisplayMember = "Key";
                this.cbox_PayWay.ValueMember = "Value";
                this._returnText = "";
                payInfo.Clear();
                if (this.cbox_PayWay.Items.Count > 0)
                {
                    if (num == -1)
                    {
                        this.cbox_PayWay.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cbox_PayWay.SelectedIndex = num;
                    }
                }
                this.cbox_PayWay.Focus();
            }
            catch (Exception exception)
            {
                throw exception;
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

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //对输入字符进行限制
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar)&& e.KeyChar!=46) //小数点
            {
                e.Handled = true;
            }
        }
        //快捷键
        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPayFow(_payflow, _isAdd);
            }
        }
    }
}
