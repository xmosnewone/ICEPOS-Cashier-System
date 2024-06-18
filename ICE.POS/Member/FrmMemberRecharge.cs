namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;
    using ICE.POS.Common;
    
    
    
    public partial class FrmMemberRecharge : FrmBase
    {
        #region 会员充值构造函数
        public FrmMemberRecharge()
        {
            InitializeComponent();
            ActiveControl = tbMemberNo;
            tbMemberNo.Focus();
        }
        #endregion
        #region 事件逻辑
        
        
        
        
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            tbPayAmount2.Text = "0.00";
            bool isok = true;
            if (lbMemberNo.Text.Length == 0)
            {
                MessageBox.Show("请输入会员卡号", Gattr.AppTitle);
                tbMemberNo.Focus();
                isok = false;
            }
            else
            {
                if (tbPayAmount.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入充值金额", Gattr.AppTitle);
                    tbPayAmount.Focus();
                    isok = false;
                }
                else
                {
                    if (tbPayAmount.Text.Trim() != tbPayAmount1.Text.Trim())
                    {
                        MessageBox.Show("充值金额和已付金额必须相等", Gattr.AppTitle);
                        tbPayAmount1.Focus();
                        isok = false;
                    }
                    else
                    {
                        if (this.comboBox1.SelectedIndex < 0)
                        {
                            MessageBox.Show("请选择支付方式", Gattr.AppTitle);
                            comboBox1.Focus();
                            isok = false;
                        }
                    }
                }
            }
            if (isok)
            {
                String payway = SIString.TryStr(this.comboBox1.SelectedItem);
                if (payway == "银行卡")
                {
                    payway = "CRD";
                }
                else
                {
                    payway = "RMB";
                }
                TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                String ordername = Convert.ToInt64(ts.TotalSeconds).ToString();
                if (MessageBox.Show("确定要充值？", Gattr.AppTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    t_member_info memberinfo = MemberService.Instance.RechargeMoney(tbMemberNo.Text.Trim(), tbPayAmount.Text.Trim(), ordername, payway);
                    if (memberinfo.code == "1")
                    {
                        t_member_info memberinfo1 = MemberService.Instance.RechargeMoneyFinsh(tbMemberNo.Text.Trim(), ordername);
                        if (memberinfo1.code == "1")
                        {
                            MessageBox.Show("充值成功，卡号:[" + tbMemberNo.Text.Trim() + "]充值金额[" + tbPayAmount.Text.Trim() + "]", Gattr.AppTitle);
                            DialogResult = DialogResult.OK;
                            //TODO:打印充值小票
                            Print(Gattr.BranchNo, tbMemberNo.Text.Trim(), SIString.TryDec(this.tbPayAmount.Text.Trim()), 0, SIString.TryDec(this.tbPayAmount.Text.Trim()) + SIString.TryDec(lbMemberBalance.Text.Trim()));
                            LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】进行会员账户充值！充值成功，卡号:[" + tbMemberNo.Text.Trim() + "]充值金额[" + tbPayAmount.Text.Trim() + "]", LogEnum.SysLog);
                        }
                        else
                        {
                            MessageBox.Show(memberinfo1.info, Gattr.AppTitle);
                        }
                    }
                    else
                    {
                        MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                    }
                }
            }
        }
        
        
        
        
        
        private void tbMemberNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetMemberInfo();
                e.Handled = true;
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    btnOk_Click(null, null);
                }
            }
        }
        
        
        
        
        
        private void FrmMemberRecharge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
            {
                btnOk_Click(null, null);
                e.Handled = true;
            }
        }
        #endregion
        #region 私有方法
        
        
        
        
        
        
        
        
        private void Print(string branchNo, string cardId, decimal accAmt, decimal sendAmt, decimal remAmt)
        {
            List<string> list = new List<string>();
            list.Add("储值卡充值");
            string text = "分店：  " + branchNo;
            string item = "会员编号：  " + cardId.ToString();
            string item2 = "充值金额：  " + accAmt.ToString(Gattr.PosSaleAmtPoint);
            string item3 = "赠送余额：  " + sendAmt.ToString(Gattr.PosSaleAmtPoint);
            string item4 = "卡内余额：  " + remAmt.ToString(Gattr.PosSaleAmtPoint);
            string item5 = "充值付款方式：  " + SIString.TryStr(this.comboBox1.SelectedItem.ToString());
            list.Add(text);
            list.Add(item);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            list.Add(item5);
            Gattr.PosPrinter.OpenPrinter(Gattr.PosModel, Gattr.PosPort);
            Gfunc.PrintHeader();
            List<PrintString> print = new List<PrintString>();
            foreach (String str in list)
            {
                print.Add(new PrintString(str));
            }
            Gfunc.PrintOut(print);
            Gfunc.SendToAPIPrint();
        }
        
        
        
        void SetMemberInfo()
        {
            if (tbMemberNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入会员卡号", Gattr.AppTitle);
                tbMemberNo.Focus();
                return;
            }
            lbMemberNo.Text = string.Empty;
            lbMemberBalance.Text = string.Empty;
            t_member_info memberinfo = MemberService.Instance.GetMemberInfoByMemNo(this.tbMemberNo.Text.Trim());
            if (memberinfo.code == "1")
            {
                lbMemberNo.Text = memberinfo.username;
                lbMemberBalance.Text = SIString.TryStr(memberinfo.balance);
            }
            else
            {
                MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                tbMemberNo.Focus();
            }
        }
        #endregion


    }
}
