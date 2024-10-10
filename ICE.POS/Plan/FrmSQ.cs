namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using ICE.POS.Model;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.Utility;
    public partial class FrmSQ : FrmBase
    {
        public FrmSQ()
        {
            InitializeComponent();
            this.tbox_PWD.Focus();
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            Accredit();
        }
        #region 窗体全局声名
        
        
        
        
        public delegate void SetIsOK(bool isok);
        
        
        
        public event SetIsOK SetIsOKEvent;
        #endregion

        //授权认证
        //根据登陆有授权权限的账号，登陆成功即为授权成功！
        public void Accredit()
        {
            bool _isOK = false;
            try
            {
                if (this.tbox_Name.Text.Length == 0)
                {
                    MessageBox.Show("请输入用户名", Gattr.AppTitle);
                    return;
                }
                if (this.tbox_PWD.Text.Length == 0 && this.tbox_Name.Text.Length == 4)
                {
                    this.tbox_PWD.Focus();
                    return;
                }
                if (this.tbox_PWD.Text.Length == 0)
                {
                    MessageBox.Show("请输入密码", Gattr.AppTitle);
                    return;
                }
                t_operator _oper = Gattr.Bll.GetOperatorInfo(this.tbox_Name.Text.Trim(), SecurityUtility.Instance.GetMD5Hash(this.tbox_PWD.Text.Trim()), Gattr.BranchNo);
                if (_oper != null)
                {
                    _isOK = true;
                    if (Gattr.Bll.SetOperatorLoginTime(_oper.oper_id, DateTime.Now) > 0)
                    {
                        if (SetIsOKEvent != null)
                        {
                            SetIsOKEvent(_isOK);
                        }
                        DialogResult = DialogResult.OK;
                        LoggerHelper.Log("MsmkLogger", this.tbox_Name.Text + "为"+Gattr.OperId+"进行授权！", LogEnum.SysLog);
                    }
                }
                else
                {
                    this.tbox_PWD.Text = "";
                    this.tbox_PWD.Focus();
                    MessageBox.Show("用户名或密码错误", Gattr.AppTitle);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "FrmSQ--->Accredit()-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }

        private void tbox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar)&&e.KeyChar!=46)// 小数点
            {
                e.Handled = true;
            }
        }

        private void tbox_PWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Accredit();
            }
            if (e.KeyCode == Keys.Escape)
            {
                base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            return;
        }
    }
}
