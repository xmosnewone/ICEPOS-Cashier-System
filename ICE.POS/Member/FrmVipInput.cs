namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    using ICE.POS.Model;
    
    
    
    public partial class FrmVipInput : FrmBase
    {
        #region 窗体全局声名
        
        
        
        
        public delegate void SetMemberInfo(t_member_info meminfo);
        
        
        
        public event SetMemberInfo SetMemberEvent;
        #endregion
        #region 窗体初始化
        public FrmVipInput()
        {
            InitializeComponent();
        }
        #endregion
        #region 窗体事件逻辑
        
        
        
        
        
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchMember();
            }
        }
        
        
        
        
        
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))// && e.KeyChar!=46) 小数点
            {
                e.Handled = true;
            }
        }
        
        
        
        
        
        private void btnSeach_Click(object sender, EventArgs e)
        {
            SearchMember();
        }
        #endregion
        #region 窗体私有方法
        
        
        
        public void SearchMember()
        {
            String mem_no = this.txtInput.Text.Trim();
            if (mem_no.Length == 0)
            {
                MessageBox.Show("请输入会员编号", Gattr.AppTitle);
                this.txtInput.Focus();
            }
            else
            {
                t_member_info meminfo = MemberService.Instance.GetMemberInfoByMemNo(mem_no);
                if (meminfo.code == "-1")
                {
                    MessageBox.Show(meminfo.info, Gattr.AppTitle);
                    this.txtInput.Focus();
                }
                else
                {
                    if (meminfo.code == "1")
                    {
                        //检测是否微信会员
                        //t_member_info _temp = MemberService.Instance.CheckMemberinfoForLL(meminfo.mem_no);
                        //if (_temp != null)
                        //{
                        //    if (_temp.code == "1")
                        //    {
                        //        meminfo.mem_type = "WX";
                        //    }
                        //}
                    }
                    else
                    {
                        //没有会员接口报404
                        if (meminfo.code == "404")
                        {
                            meminfo.code = "1";
                            meminfo.mem_no = mem_no;
                        }
                    }
                    if (SetMemberEvent != null)
                    {
                        SetMemberEvent(meminfo);
                    }
                    DialogResult = DialogResult.OK;
                }
                //if (meminfo.code == "1")
                //{
                //    if (SetMemberEvent != null)
                //    {
                //        SetMemberEvent(meminfo);
                //    }
                //    DialogResult = DialogResult.OK;
                //}
                //else
                //{
                //    MessageBox.Show(meminfo.info, Gattr.AppTitle);
                //    this.txtInput.Focus();
                //}
            }
        }
        #endregion

    }
}
