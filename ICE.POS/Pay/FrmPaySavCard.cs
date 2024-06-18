namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    using ICE.POS.Model;
    
    
    
    public partial class FrmPaySavCard : FrmBase
    {
        #region 全局变量声明
        
        
        
        
        
        
        public delegate void SetCardPayInfoDelegate(String cardNo, Decimal payAmount, String memo);
        
        
        
        public event SetCardPayInfoDelegate SetCardPayInfo;
        #endregion
        #region 构造函数
        
        
        
        
        
        public FrmPaySavCard(t_member_info memberInfo, Decimal payAmt)
        {
            InitializeComponent();
            ActiveControl = tbxCardNo;
            tbxCardNo.Focus();
            if (memberInfo != null && SIString.TryStr(memberInfo.mem_no).Length > 0)
            {
                tbxCardNo.Text = memberInfo.mem_no;
                lbName.Text = memberInfo.username;
                lbRemain.Text = memberInfo.balance.ToString();
                tbxCardNo.Enabled = false;
                ActiveControl = tbxPass;
                tbxPass.Focus();
            }
            tbxAmt.Text = payAmt.ToString(Gattr.PosSaleAmtPoint);
            lbMaxAmt.Text = payAmt.ToString(Gattr.PosSaleAmtPoint);
        }
        #endregion
        #region 界面事件逻辑
        
        
        
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        
        
        
        
        private void btnPass_Click(object sender, EventArgs e)
        {
            if (tbxCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入会员卡/储值卡卡号!", Gattr.AppTitle);
                this.tbxCardNo.Focus();
            }
            else if (this.tbxNewPass.Text.Trim() == "")
            {
                MessageBox.Show("新密码不能为空!", Gattr.AppTitle);
                this.tbxNewPass.Focus();
            }
            else if (this.tbxNewPass.Text.Trim() != this.tbxNew222.Text.Trim())
            {
                MessageBox.Show("确认密码不正确!", Gattr.AppTitle);
                this.tbxNew222.Focus();
            }
            else
            {
                t_member_info memberinfo = MemberService.Instance.UpdateMemPayPass(tbxCardNo.Text.Trim(), tbxPass.Text.Trim(), tbxNewPass.Text.Trim());
                if (memberinfo.code == "1")
                {
                    MessageBox.Show("密码修改成功，请妥善保管好您的密码!", Gattr.AppTitle);
                }
                else
                {
                    MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                }
            }
        }
        
        
        
        
        
        private void FrmPaySavCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!this.tbxCardNo.Focused)
                {
                    if (this.tbxPass.Focused)
                    {
                        this.tbxAmt.Focus();
                    }
                    else if (this.tbxAmt.Focused)
                    {
                        this.PayCard();
                    }
                    else if (this.tbxNewPass.Focused)
                    {
                        this.tbxNew222.Focus();
                    }
                    else if (this.tbxNew222.Focused)
                    {
                        this.btnPass_Click(null, null);
                    }
                }
            }
            else if (e.KeyCode == Keys.F1)
            {
                this.CardNoInput();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.tbxAmt.SelectAll();
                this.tbxAmt.Focus();
            }
            else if (e.KeyCode == Keys.F6)
            {
                this.btnPass_Click(null, null);
            }
            else if (e.KeyCode == Keys.F8)
            {
                this.PayCard();
            }
        }
        
        
        
        
        
        private void btnReadIC_Click(object sender, EventArgs e)
        {
            CardNoInput();
        }
        #endregion
        #region 界面私有方法
        
        
        
        private void PayCard()
        {
            if (lbName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入会员卡/储值卡卡号!", Gattr.AppTitle);
                this.tbxCardNo.Focus();
            }
            else
            {
                bool isok = true;
                Decimal balance = SIString.TryDec(lbRemain.Text.Trim());
                tbxAmt.Text = lbMaxAmt.Text;
                //实际付款
                Decimal pay1 = SIString.TryDec(tbxAmt.Text.Trim());
                Decimal pay2 = SIString.TryDec(lbMaxAmt.Text.Trim());
                if (balance <= 0)//当前没有余额
                {
                    MessageBox.Show("账户余额不足！");
                    isok = false;
                }//if (balance <= 0)
                else if (pay1 > pay2)//现负金额大于应付金额
                {
                    MessageBox.Show("现付金额不能大于应付金额！");
                    tbxAmt.Focus();
                    isok = false;
                }//else if (pay1 > pay2)
                else if (balance < pay2)//当前余额小于应付金额
                {
                    DialogResult res = MessageBox.Show(string.Format("当前储值卡余额为{0},不足消费！是否使用储值卡剩下余额付款？", balance), Gattr.AppTitle, MessageBoxButtons.YesNo);
                    if (res == DialogResult.No)
                    {
                        isok = false;
                    }
                    else
                    {
                        tbxAmt.Text = balance.ToString();
                        pay1 = balance;
                    }
                }
                if (isok)
                {
                    t_member_info memberinfo = MemberService.Instance.GetMemberInfoByMemNoAndPass(tbxCardNo.Text.Trim(), tbxPass.Text.Trim());
                    if (memberinfo.code == "-1")
                    {
                        MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                    }
                    else
                    {
                        //先判断密码
                        if (SetCardPayInfo != null)
                        {
                            SetCardPayInfo(tbxCardNo.Text.Trim(), pay1, (balance - pay1).ToString());
                        }
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
        
        
        
        
        private bool CardNoInput()
        {
            if (tbxCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入会员卡/储值卡卡号!", Gattr.AppTitle);
                this.tbxCardNo.Focus();
            }
            else
            {
                this.lbRemain.Text = string.Empty;
                lbName.Text = string.Empty;
                t_member_info memberinfo = MemberService.Instance.GetMemberInfoByMemNo(tbxCardNo.Text.Trim());
                if (memberinfo.code == "-1")
                {
                    MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                    tbxCardNo.Text = string.Empty;
                    tbxCardNo.Focus();
                }
                else
                {
                    this.lbRemain.Text = memberinfo.balance.ToString();
                    lbName.Text = memberinfo.username;
                }
            }
            return false;
        }
        #endregion
    }
}
