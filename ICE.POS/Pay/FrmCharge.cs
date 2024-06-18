using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.POS.Model;
namespace ICE.POS
{
    public partial class FrmCharge : FrmBase
    {
        public delegate void SetVerCodeDelegate(string vercode);
        public event SetVerCodeDelegate SetVerCode;
        private string _vip_no;
        public FrmCharge(string vip_no)
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle + "--验证码";
            this._vip_no = vip_no;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.tbCode.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入验证码", Gattr.AppTitle);
                return;
            }
            else
            {
                if (SetVerCode!=null)
                {
                    SetVerCode(this.tbCode.Text.Trim());
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FrmCharge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnCancel_Click(null, null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.btnOK_Click(null, null);
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
        }
        //重新发送验证码
        private void linkLabelVcode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            t_member_info memberinfo = MemberService.Instance.GetValidateCode(_vip_no);
            if (memberinfo.code == "-1")
            {
                if (string.IsNullOrEmpty(memberinfo.info))
                {
                    MessageBox.Show("验证码发送失败,请尝试重新发送或者使用其他方式支付！", Gattr.AppTitle);
                    //LoggerHelper.Log("MsmkLogger", memberinfo.mem_no + "验证码发送失败,请尝试重新发送或者使用其他方式支付！", LogEnum.SysLog);
                }
                else
                {
                    MessageBox.Show(memberinfo.info, Gattr.AppTitle);
                    //LoggerHelper.Log("MsmkLogger", memberinfo.mem_no + "余额支付错误信息：" + memberinfo.info, LogEnum.SysLog);
                }
                return;
            }
        }
    }
}
