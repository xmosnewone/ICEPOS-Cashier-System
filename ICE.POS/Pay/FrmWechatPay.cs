using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.POS.Common;
using ICE.Common;
using System.Net.NetworkInformation;

namespace ICE.POS
{

    public partial class FrmWechatPay : ICE.POS.FrmBase
    {
        private decimal _payAmt=0;
        private decimal _returnMoney = 0;
        private string Qrcode_url = string.Empty;
        private string flow_no = string.Empty;
        private string branch_no = string.Empty;
        private string Qrcode_Url = string.Empty;

        //判断支付状态
        private bool PayStatus = false;

        //返回扫描的授权码
        private string _returnCode ="";

        public FrmWechatPay(decimal payAmt, string _flow_no)
        {
            InitializeComponent();

            this._payAmt = payAmt;
            this._returnMoney = payAmt;
            wxPayAmt.Text = "￥"+Convert.ToString(payAmt);
           //订单编号
            flow_no = _flow_no;
            //初始化都为未支付成功
            this.DialogResult = DialogResult.No;

            this.PayStatus = false;
        }

        private bool checkNetworkStatus() {
            try
            {
                Ping ping = new Ping();
                PingReply pr = ping.Send(Gattr.NetworkName);
                if (pr.Status == IPStatus.Success)
                    return true;
                else
                    return false;
            }
            catch (Exception e) {
                LoggerHelper.Log("MsmkLogger", Gattr.OperId + "微信刷卡网络异常！", LogEnum.SysLog);
                return false;
            }
          
        }

        private void wechatpayCancle(object sender, EventArgs e)
        {
            this.Hide();
        }

        //检测扫码录入行为
        private void onScancode(object sender, EventArgs e)
        {
            //MessageBox.Show(this.auth_code.Text);
            String _result = String.Empty;
             this._returnCode = this.auth_code.Text;
             if (this._returnCode.Length>=18)
             {
                 //判读联网状态
                 //if (checkNetworkStatus() == false)
                 //{
                   //  MessageBox.Show("微信支付需要在有网络状态下使用");
                    // return;
                 //}

                 this.mention.Text = "扫码支付中,请稍后..";
                 //执行支付
                 _result=this.Execute_Wechatpay(this._returnCode, this.flow_no, this._payAmt);
                 if (_result == "1")
                 {
                        this.PayStatus = true;
                        this.mention.Text = "微信支付成功";
                 }
                 else if (Convert.ToString(_result) == "-3")
                 {
                        this.PayStatus = false;
                        this.mention.Text = "缺少微信商户参数配置，请到后台设置";
                 }
                 else {
                        this.PayStatus = false;
                        this.mention.Text = "微信支付失败，请重试";
                 }
                
              }

             return;
        }

        //执行微信支付接口买单
        public string Execute_Wechatpay(String auth_code, String flow_no, decimal pay_amt)
        {
            String wxResult = String.Empty;
            bool isok = true;
            string errorMessage = string.Empty;
            Dictionary<string, object> _dic = new Dictionary<string, object>();
            try
            {
                _dic.Add("username", "");
                _dic.Add("password", "");
                _dic.Add("access_token", Gattr.access_token);
                _dic.Add("client_id", Gattr.client_id);
                _dic.Add("branch_no", Gattr.BranchNo);
                _dic.Add("pay_amount", pay_amt);
                _dic.Add("flow_no", flow_no);
                _dic.Add("auth_code", auth_code);
                wxResult = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/wechatPay", _dic, ref isok, ref errorMessage);
                if (wxResult == "1")
                {
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "微信刷卡支付成功！", LogEnum.SysLog);
                }
                else
                {
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "微信刷卡支付失败！", LogEnum.SysLog);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->FrmWechatPay-->Execute_Wechatpay:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return wxResult;
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

        private void paysuccess(object sender, EventArgs e)
        {
            if (this.PayStatus)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("微信支付未成功，请注意");
            }
          
        }

        private void checkPayStatus(object sender, EventArgs e)
        {
            String auth_code = this.auth_code.Text;
            if (auth_code == "")
            {
                MessageBox.Show("请扫码或输入客户的授权码");
                return;
            }

            this.mention.Text = "查询订单支付状态中...";
            String payStatus = this.GetPayStatus(this.flow_no);
            if (payStatus == "1")
            {
                this.mention.Text = "恭喜您：微信支付成功";
            }
            else
            {
                this.mention.Text = "请注意：未完成支付";
            }
            return;
        }


        public string GetPayStatus(String flowno)
        {
            String isPaySuccess = String.Empty;
            bool isok = true;
            string errorMessage = string.Empty;
            Dictionary<string, object> _dic = new Dictionary<string, object>();
            try
            {
                _dic.Add("username", "");
                _dic.Add("password", "");
                _dic.Add("client_id", Gattr.client_id);
                _dic.Add("access_token", Gattr.access_token);
                _dic.Add("flowno", flowno);
                _dic.Add("branch_no", Gattr.BranchNo);
                isPaySuccess = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/getwxPayStatus", _dic, ref isok, ref errorMessage);

                if (isPaySuccess == "1")
                {
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "查询微信支付状态成功！", LogEnum.SysLog);
                }
                else
                {
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "查询微信支付状态失败！" + isPaySuccess, LogEnum.SysLog);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->FrmWechatPay-->GetPayStatus:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isPaySuccess;
        }

    }
}
