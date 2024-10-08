﻿using System;
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
    public partial class FrmAliPay2 : ICE.POS.FrmBase
    {
        private decimal _payAmt = 0;
        private decimal _returnMoney = 0;
        private string Qrcode_url = string.Empty;
        public string flow_no = string.Empty;
        private string branch_no = string.Empty;
        private string Qrcode_Url = string.Empty;

        //判断支付状态
        private bool PayStatus = false;
        //返回扫描的授权码
        private string _returnCode = "";

        public FrmAliPay2(decimal payAmt, string _flow_no)
        {
            InitializeComponent();
            this._payAmt = payAmt;
            this._returnMoney = payAmt;
            AliPayAmt.Text = "￥" + Convert.ToString(payAmt);
            //订单编号
            flow_no = _flow_no;
            //初始化都为未支付成功
            this.DialogResult = DialogResult.No;

            this.PayStatus = false;

            this.auth_code.Focus();
        }

        private void alipayCancle(object sender, EventArgs e)
        {
            this.Close();

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
            else
            {
                MessageBox.Show("支付未成功，请注意");
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
                this.mention.Text = "恭喜您：支付宝支付成功";
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
                _dic.Add("username", Gattr.OperId);
                _dic.Add("password", Gattr.Oper_Pwd);
                _dic.Add("client_id", Gattr.client_id);
                _dic.Add("access_token", Gattr.access_token);
                _dic.Add("flowno", flowno);
                _dic.Add("branch_no", Gattr.BranchNo);
                isPaySuccess = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/getAliPayStatus", _dic, ref isok, ref errorMessage);

                if (isPaySuccess == "1")
                {
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "查询支付宝支付状态成功！", LogEnum.SysLog);
                }
                else
                {
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "查询支付宝支付状态失败！" + isPaySuccess, LogEnum.SysLog);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->FrmWechatPay-->GetPayStatus:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isPaySuccess;
        }

        private void onScancode(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                String _result = String.Empty;
                this._returnCode = this.auth_code.Text;
                if (this._returnCode.Length >= 18)
                {

                    this.mention.Text = "扫码支付中,请稍后..";
                    //执行支付
                    _result = this.Execute_Alipay(this._returnCode, this.flow_no, this._payAmt);
                    string res = Convert.ToString(_result);
                    if (res == "1")
                    {
                        this.PayStatus = true;
                        this.mention.Text = "支付宝支付成功";
                    }
                    else if (res == "-3")
                    {
                        this.PayStatus = false;
                        this.mention.Text = "缺少支付宝商户参数配置，请到后台设置";
                    }
                    else if (res == "-9")
                    {
                        this.PayStatus = false;
                        this.mention.Text = "";
                    }
                    else
                    {
                        this.PayStatus = false;
                        this.mention.Text = "支付宝支付失败，请重试";
                    }

                }

                return;

            } else if (e.KeyCode == Keys.Escape) {

                base.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            }
        }

        //执行支付宝支付接口买单
        public string Execute_Alipay(String auth_code, String flow_no, decimal pay_amt)
        {
            String wxResult = String.Empty;
            bool isok = true;
            string errorMessage = string.Empty;
            Dictionary<string, object> _dic = new Dictionary<string, object>();
            this.mention.Text = "";
            try
            {
                _dic.Add("username", Gattr.OperId);
                _dic.Add("password", Gattr.Oper_Pwd);
                _dic.Add("access_token", Gattr.access_token);
                _dic.Add("client_id", Gattr.client_id);
                _dic.Add("branch_no", Gattr.BranchNo);
                _dic.Add("pay_amount", pay_amt);
                _dic.Add("flow_no", flow_no);
                _dic.Add("auth_code", auth_code);
                wxResult = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/aliPayFtf", _dic, ref isok, ref errorMessage);
                if (wxResult == "1")
                {
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "支付宝扫码支付成功！", LogEnum.SysLog);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.mention.Text = "支付宝扫码支付失败！";
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "支付宝扫码支付失败！", LogEnum.SysLog);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->FrmWechatPay-->Execute_Wechatpay:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return wxResult;
        }

    }
}
