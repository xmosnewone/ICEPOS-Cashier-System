namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using ICE.POS.Model;
    using System.Windows.Forms;
    using ICE.POS.Common;
    public partial class FrmHD : FrmBase
    {
        public FrmHD()
        {
            InitializeComponent();
            this.tbCardNo.Focus();
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            SearchMember();
        }
        #region 窗体全局声名
        
        
        
        
        public delegate void SetMemberInfo(t_member_info meminfo);
        
        
        
        public event SetMemberInfo SetMemberEvent;
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
            String mem_no = this.tbCardNo.Text.Trim();
            if (mem_no.Length == 0)
            {
                MessageBox.Show("请输入会员编号", Gattr.AppTitle);
                this.tbCardNo.Focus();
            }
            else
            {
                t_member_info meminfo = MemberService.Instance.GetMemberInfoByMemNo(mem_no);
                if (meminfo.code == "-1")
                {
                    MessageBox.Show(meminfo.info, Gattr.AppTitle);
                    this.tbCardNo.Focus();
                }
                else
                {
                    if (meminfo.code == "1")
                    {
                        t_member_info _temp = MemberService.Instance.CheckMemberinfoForLL(meminfo.mem_no);
                        if (_temp != null)
                        {
                            if (_temp.code == "1")
                            {
                                if (_temp.time.Date == System.DateTime.Now.Date)
                                {
                                    //接口参数
                                    Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                                    _dic.Add("vip_no", mem_no);
                                    _dic.Add("item_no", "80310891");
                                    _dic.Add("plan_no", "WX80310891");
                                    bool isok1 = true;
                                    string errorMessage = string.Empty;
                                    //参数提交
                                    string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/GetIsFirstSale", _dic, ref isok1, ref errorMessage);
                                    if (isok1)
                                    {
                                        if (result == "0")
                                        {
                                            meminfo.mem_type = "WX";
                                            if (SetMemberEvent != null)
                                            {
                                                SetMemberEvent(meminfo);
                                            }
                                            DialogResult = DialogResult.OK;
                                        }
                                        else
                                        {
                                            MessageBox.Show("您领取过本活动的赠品！", Gattr.AppTitle);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("接口信息获取错误！", Gattr.AppTitle);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("您不是今日绑定的会员信息！本次活动仅限于当日绑定的会员！");
                                }
                            }
                            else
                            {
                                MessageBox.Show("您未将会员卡与微信绑定，无法参加活动，请使用微信绑定会员卡！", Gattr.AppTitle);
                            }
                        }
                    }
                    else
                    {
                        if (meminfo.code == "404")
                        {
                            meminfo.code = "1";
                            meminfo.mem_no = mem_no;
                        }
                    }
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

        
        
        
        private void tbCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchMember();
            }
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private void tbCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))// && e.KeyChar!=46) 小数点
            {
                e.Handled = true;
            }
        }
    }
}
