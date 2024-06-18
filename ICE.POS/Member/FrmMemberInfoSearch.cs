namespace ICE.POS
{
    using System.Windows.Forms;
    using ICE.POS.Model;
    using ICE.Utility;
    
    
    
    public partial class FrmMemberInfoSearch : FrmBase
    {
        #region 构造函数
        public FrmMemberInfoSearch()
        {
            InitializeComponent();
            this.ActiveControl = tbMem_no;
            tbMem_no.Focus();
        }
        #endregion
        #region 事件逻辑
        
        
        
        
        
        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            lbMemberBalance.Text = string.Empty;
            lbMemberCons.Text = string.Empty;
            lbMemberEmail.Text = string.Empty;
            lbMemberId.Text = string.Empty;
            lbMemberLevel.Text = string.Empty;
            lbMemberName.Text = string.Empty;
            lbMemberNo.Text = string.Empty;
            lbMemberScore.Text = string.Empty;
            lbMemberType.Text = string.Empty;
            lbMemberMobile.Text = string.Empty;
            if (tbMem_no.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入要查询的会员账号或手机号", Gattr.AppTitle);
                tbMem_no.Focus();
                return;
            }
            t_member_info memberinfo = MemberService.Instance.GetMemberInfoByMemNo(tbMem_no.Text.Trim());

            if (memberinfo.code == "1")
            {
                lbMemberBalance.Text = SIString.TryStr(ExtendUtility.Instance.ParseToDecimal(memberinfo.balance).ToString(Gattr.PosSalePrcPoint));
                lbMemberCons.Text = SIString.TryStr(ExtendUtility.Instance.ParseToDecimal(memberinfo.total_consu).ToString(Gattr.PosSalePrcPoint));
                lbMemberEmail.Text = SIString.TryStr(memberinfo.email);
                lbMemberId.Text = SIString.TryStr(memberinfo.mem_id);
                lbMemberLevel.Text = SIString.TryStr(memberinfo.Level);
                lbMemberName.Text = SIString.TryStr(memberinfo.username);
                lbMemberNo.Text = SIString.TryStr(memberinfo.mem_no);
                lbMemberScore.Text = SIString.TryStr(ExtendUtility.Instance.ParseToDecimal(memberinfo.score).ToString(Gattr.PosSalePrcPoint));
                lbMemberType.Text = SIString.TryStr(memberinfo.regtype);
                lbMemberMobile.Text = SIString.TryStr(memberinfo.mobile);
            }
            else
            {
                MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                tbMem_no.Focus();
            }
        }
        
        
        
        
        
        private void tbMem_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
            {
                this.btnSearch_Click(null, null);
            }
        }
        #endregion


    }
}
