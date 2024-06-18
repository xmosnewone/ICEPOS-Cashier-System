namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    //using ICE.POS.Msmk;
    using ICE.Utility;
    using System.Text;
    public partial class FrmNonTrading : FrmBase
    {
        public FrmNonTrading()
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
        }
        private void FrmNonTrading_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnOk_Click(null, null);
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.rbComing.Checked = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.rbPayOut.Checked = true;
            }
        }

        private void FrmNonTrading_Load(object sender, EventArgs e)
        {
            List<t_dict_payment_info> paymentInfo = null;
            paymentInfo = Gattr.Bll.GetPaymentInfo(" pay_flag not in ('0','2') ");
            this.cbPayName.Items.Clear();
            if (paymentInfo != null)
            {
                foreach (t_dict_payment_info _info in paymentInfo)
                {
                    this.cbPayName.Items.Add(new ListItem("[" + _info.pay_way + "]" + _info.pay_name, _info.rate.ToString()));
                }
                paymentInfo.Clear();
                paymentInfo = null;
            }
            this.cbPayName.DisplayMember = "Key";
            this.cbPayName.ValueMember = "Value";
            if (this.cbPayName.Items.Count >= 1)
            {
                this.cbPayName.SelectedIndex = 0;
            }
            this.cbPayName.Focus();
        }
        private void btnOk_Click(object sender, EventArgs e)
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
                    amount = Convert.ToDecimal(this.txtAmount.Text.Trim()) * Convert.ToDecimal((this.cbPayName.SelectedItem as ListItem).Value.Trim());
                    if (amount <= 0M)
                    {
                        MessageBox.Show("金额必须大于零！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.txtAmount.SelectAll();
                        this.txtAmount.Focus();
                    }
                    else if (amount > 999999999M)
                    {
                        MessageBox.Show("金额值过大！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.txtAmount.SelectAll();
                        this.txtAmount.Focus();
                    }
                    else
                    {
                        if (this.rbPayOut.Checked)
                        {
                            amount = -amount;
                        }
                        try
                        {
                            string flowNo = Gfunc.GetFlowNo();
                            ListItem item = this.cbPayName.SelectedItem as ListItem;
                            string pay_name = item.Key.Substring(item.Key.LastIndexOf("]") + 1);
                            List<t_pos_payflow> _listPay = new List<t_pos_payflow>();
                            t_pos_payflow _pay = new t_pos_payflow();
                            _pay.flow_id = 1;
                            _pay.flow_no = flowNo;
                            _pay.branch_no = Gattr.BranchNo;
                            _pay.sale_way = "A";
                            _pay.sale_amount = amount;
                            _pay.pay_way = (this.cbPayName.SelectedItem as ListItem).Key.Substring(1, (this.cbPayName.SelectedItem as ListItem).Key.IndexOf("]") - 1);
                            _pay.oper_date = DateTime.Now.ToString("s");
                            _pay.oper_id = Gattr.OperId;
                            _pay.pos_id = Gattr.PosId;
                            _pay.pay_amount = amount;
                            _pay.coin_rate = 1M;
                            _pay.convert_amt = amount;
                            _pay.memo = this.txtMemo.Text.Trim();
                            _pay.coin_type = "RMB";
                            _pay.com_flag = "1";
                            _pay.pos_flag = "1";
                            _pay.pay_name = pay_name;
                            _listPay.Add(_pay);
                            Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                            string pay = JsonUtility.Instance.ObjectToJson<t_pos_payflow>(_listPay);
                            _dic.Add("pay", pay);
                            bool isok = true;
                            string errorMessage = string.Empty;
                            if (PosServericeBll.Instance.TestConnect())
                            {
                                string json = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Addflow", _dic, ref isok, ref errorMessage);
                                if (isok)
                                {
                                    if (!string.IsNullOrEmpty(json))
                                    {
                                        string message = string.Empty;
                                        switch (json)
                                        {
                                            case "-10":
                                                message = "参数错误";
                                                break;
                                            case "-20":
                                                message = "权限不足";
                                                break;
                                            case "1":
                                                //TODO :保存数据本地
                                                _pay.com_flag = "1";
                                                if (Gattr.Bll.SaveNonTrading(_pay))
                                                {
                                                    Gfunc.SetFlowNo();
                                                    message = "付款成功";
                                                    bool isok1 = true;
                                                    if (this.rbPayOut.Checked)
                                                    {
                                                        isok1 = false;
                                                    }
                                                    this.Print(_pay.flow_no, isok1, _pay.pay_name, _pay.pay_amount.Value, _pay.memo);
                                                    DialogResult = System.Windows.Forms.DialogResult.OK;
                                                    //MessageBox.Show(message, Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                    LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】进行非交易记录！" + _pay.sale_amount+"元", LogEnum.SysLog);
                                                }
                                                break;
                                            default:
                                                message = "付款失败";
                                                break;
                                        }
                                        if (json != "1")
                                        {
                                            MessageBox.Show("付款失败！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("付款失败！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(errorMessage, Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                if (Gattr.Bll.SaveNonTrading(_pay))
                                {
                                    Gfunc.SetFlowNo();
                                    string message = "付款成功";
                                    bool isok1 = true;
                                    if (this.rbPayOut.Checked)
                                    {
                                        isok1 = false;
                                    }
                                    this.Print(_pay.flow_no, isok1, _pay.pay_name, _pay.pay_amount.Value, _pay.memo);
                                    DialogResult = System.Windows.Forms.DialogResult.OK;
                                    MessageBox.Show(message, Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    MessageBox.Show("付款失败！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("付款失败！", Gattr.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }
        private void Print(string flowNo, bool isSr, string payName, decimal amount, string memo)
        {
            List<PrintString> list = new List<PrintString>();
            string text = amount.ToString(Gattr.PosSaleAmtPoint);
            string str = "分店：" + Gattr.BranchNo;
            string str2 = "收银员：" + Gattr.OperId;
            string item = DateTime.Now.ToString("yyyy.MM.dd HH:mm") + "\r\n";
            string text2;
            if (isSr)
            {
                text2 = "非交易收入[" + payName + "]：";
            }
            else
            {
                text2 = "非交易支出[" + payName + "]：";
            }
            text2 += text.PadLeft(Gattr.PrtLen - Encoding.Default.GetByteCount(text2) - Encoding.Default.GetByteCount(text), ' ');
            list.Add(new PrintString(str + "   " + str2));
            list.Add(new PrintString(flowNo));
            list.Add(new PrintString(item));
            list.Add(new PrintString(text2));
            list.Add(new PrintString(string.IsNullOrEmpty(memo) ? "" : ("备注：" + memo + "\n")));
            //list.Add(str + "   " + str2);
            //list.Add(flowNo);
            //list.Add(item);
            //list2.Add(text2);
            //list2.Add(string.IsNullOrEmpty(memo) ? "" : ("备注：" + memo + "\n"));
            Gattr.PosPrinter.OpenPrinter(Gattr.PosModel, Gattr.PosPort);
            Gfunc.PrintHeader();
            Gfunc.PrintOut(list);
            Gfunc.SendToAPIPrint();
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
