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
    public partial class FrmUpdatePwd : FrmBase
    {
       private t_operator _oper; //操作人
        private bool _updateStatus;
        public FrmUpdatePwd()
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle + " - 修改密码";
            this.tbSaleMan.Text = Gattr.OperFullName;
            this._updateStatus = false;
        }
        private void FrmUpdatePwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnOk_Click(null, null);
            }
        }

        private void FrmUpdatePwd_Load(object sender, EventArgs e)
        {
            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.tbNewPwd.Text.Trim() != this.tbReNewPwd.Text.Trim()){
                    MessageBox.Show("两次密码不一致！！！", Gattr.AppTitle);
                }
                _oper = Gattr.Bll.GetOperatorInfo(Gattr.OperId, SecurityUtility.Instance.GetMD5Hash(this.tbOldPwd.Text.Trim()), Gattr.BranchNo);
                
                if (_oper != null)
                {
                    if (Gattr.Bll.UpdateOperPwd(_oper.oper_id, SecurityUtility.Instance.GetMD5Hash(this.tbNewPwd.Text.Trim())) > 0)
                    {
                        Gattr.Oper_Pwd = SecurityUtility.Instance.GetMD5Hash(this.tbNewPwd.Text.Trim());

                        Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                        _dic.Add("operId", Gattr.OperId);
                        _dic.Add("pwd", Gattr.Oper_Pwd);
                        bool isok1 = true;
                        string errorMessage = string.Empty;
                        string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/UpdateOperPwd", _dic, ref isok1, ref errorMessage);
                        if (result == "1")
                        {
                            this._updateStatus = true;
                            MessageBox.Show("修改密码成功！！！", Gattr.AppTitle);
                            LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + Gattr.OperId + "修改密码成功！", LogEnum.SysLog);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("密码修改失败！！！", Gattr.AppTitle);
                            LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + Gattr.OperId + "修改密码失败！", LogEnum.SysLog);
                        }
                    }
                }
                else
                {

                    MessageBox.Show("原密码错误！！！", Gattr.AppTitle);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "FrmUpatePwd--->btnOk_Click-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        
        
        
        public bool UpdateStatus
        {
            get
            {
                return this._updateStatus;
            }
        }
    }
}
