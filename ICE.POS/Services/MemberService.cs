namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    
    public class MemberService
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static MemberService _instance;
        
        
        
        private MemberService()
        {

        }
        
        
        
        public static MemberService Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new MemberService();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        
        
        private String PrepareParameters(String action, Dictionary<String, String> _dic)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            sb.AppendFormat("/{0}?", action);
            sb.AppendFormat("way={0}&", Gattr.ServiceWay);
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            String time = Convert.ToInt64(ts.TotalSeconds).ToString();
            sb.AppendFormat("time={0}&", time);
            String[] keys = new String[_dic.Count + 2];
            int index = 0;
            foreach (KeyValuePair<String, String> kv in _dic)
            {
                keys[index] = kv.Key;
                sb.AppendFormat("{0}={1}&", kv.Key, kv.Value);
                index++;
            }
            keys[_dic.Count] = "way";
            keys[_dic.Count + 1] = "time";
            String key = String.Empty;
            String[] keys1 = StringUtility.Instance.AsiicAsc(keys);
            for (int rindex = 0; rindex < keys1.Length; rindex++)
            {
                if (_dic.ContainsKey(keys1[rindex]))
                    sb1.AppendFormat("{0}={1}&", keys1[rindex], _dic[keys1[rindex]]);
                else
                {
                    if (keys1[rindex] == "way")
                    {
                        sb1.AppendFormat("way={0}&", Gattr.ServiceWay);
                    }
                    else
                    {
                        sb1.AppendFormat("time={0}&", time);
                    }
                }
            }
            sb1.AppendFormat("key={0}", Gattr.UseToken);
            key = SecurityUtility.Instance.GetMD5Hash(sb1.ToString()).ToLower();
            sb.AppendFormat("&key={0}", key);
            sb.AppendFormat("&username={0}", Gattr.OperId);
            sb.AppendFormat("&password={0}", Gattr.Oper_Pwd);
            sb.AppendFormat("&client_id={0}", Gattr.client_id);
            sb.AppendFormat("&access_token={0}", Gattr.access_token);
            return sb.ToString();
        }
        
        
        
        
        
        public t_member_info GetMemberInfoByMemNo(String mem_no)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            t = InvokeMemberService("get_mem_info", _dic);
            return t;
        }
        
        
        
        
        
        
        
        
        public t_member_info UseMemberCardPayNew(String mem_no, String money, String ordername, String vercode, String memo)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("money", SIString.TryStr(money));
            _dic.Add("ordername", ordername);
            _dic.Add("else", System.Web.HttpUtility.UrlEncode(memo).ToUpper());
            _dic.Add("vercode", vercode);
            t = InvokeMemberService("deduction", _dic);
            if (t.code == "1")
            {
                //t = AddMemberScore(mem_no, money, ordername);
                if (t.code == "1")
                {
                    t = GetMemberInfoByMemNo(mem_no);
                }
            }
            return t;
        }
        
        
        
        
        //返回会员信息
        public t_member_info GetValidateCode(String mem_no)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            t = InvokeMemberService("get_consumer_vercode", _dic);
            return t;
        }
        
        
        
        
        
        public t_member_info CheckMemberinfoForLL(String mem_no)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("type", "WEIXIN");
            t = InvokeMemberService("check_member_istoken", _dic);
            return t;
        }
        
        
        
        
        
        
        public t_member_info GetMemberInfoByMemNoAndPass(String mem_no, String mem_pass)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("mem_pass", mem_pass);
            t = InvokeMemberService("login", _dic);
            if (t.code == "1")
            {
                t = GetMemberInfoByMemNo(mem_no);
            }
            return t;
        }
        
        
        
        
        
        
        
        public t_member_info UpdateMemPayPass(String mem_no, String mem_pass, String mem_new_pass)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("mem_pass", mem_pass);
            _dic.Add("mem_new_pass", mem_new_pass);
            t = InvokeMemberService("passwordchange", _dic);
            if (t.code == "1")
            {
                t = GetMemberInfoByMemNo(mem_no);
            }
            return t;
        }
        
        
        
        
        
        
        public t_member_info ResetPayPass(String mem_no, String mem_new_pass)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("mem_new_pass", mem_new_pass);
            t = InvokeMemberService("password_reset", _dic);
            if (t.code == "1")
            {
                t = GetMemberInfoByMemNo(mem_no);
            }
            return t;
        }







        public t_member_info AddMemberScore(String mem_no, String score, String ordername, String payflow = "", String el = "")
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("else", System.Web.HttpUtility.UrlEncode(el).ToUpper());
            _dic.Add("payflow", payflow);
            _dic.Add("mem_no", mem_no);
            _dic.Add("score", score);
            _dic.Add("ordername", ordername);
            _dic.Add("branch_no", Gattr.BranchNo);
            t = InvokeMemberService("addscore", _dic);
            if (t.code == "1")
            {
                t = GetMemberInfoByMemNo(mem_no);
            }
            return t;
        }







        public t_member_info UseMemberScore(String mem_no, String score, String ordername, String el = "")
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("else", System.Web.HttpUtility.UrlEncode(el).ToUpper());
            _dic.Add("mem_no", mem_no);
            _dic.Add("money", score);//_dic.Add("score", score);
            _dic.Add("ordername", ordername);
            
            t = InvokeMemberService("usescore", _dic);
            if (t.code == "1")
            {
                t = GetMemberInfoByMemNo(mem_no);
            }
            return t;
        }
        
        
        
        
        
        
        
        
        public t_member_info UseMemberCardPay(String mem_no, String money, String ordername, String memo)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("money", SIString.TryStr(money));
            _dic.Add("ordername", ordername);
            _dic.Add("else", memo);
            t = InvokeMemberService("deduction", _dic);
            if (t.code == "1")
            {
                t = AddMemberScore(mem_no, money, ordername);
                if (t.code == "1")
                {
                    t = GetMemberInfoByMemNo(mem_no);
                }
            }
            return t;
        }
        
        
        
        
        
        
        
        
        public t_member_info RechargeMoney(String mem_no, String money, String ordername, String paytype)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("money", money);
            _dic.Add("ordername", ordername);
            _dic.Add("paytype", paytype);
            t = InvokeMemberService("memb_recharge_order_add", _dic);
            return t;
        }
        
        
        
        
        
        
        public t_member_info RechargeMoneyFinsh(String mem_no, String ordername)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_member_info t = null;
            _dic.Add("mem_no", mem_no);
            _dic.Add("ordername", ordername);
            t = InvokeMemberService("memb_recharge_order_finish", _dic);
            return t;
        }

        public t_pos_coupon CounponCheck(String code,decimal payAmount)
        {
            Dictionary<String, String> _dic = new Dictionary<string, string>();
            t_pos_coupon t = null;
            _dic.Add("code", code);
            _dic.Add("payamount", payAmount.ToString());
            try
            {
                Dictionary<string, object> _dic1 = Gfunc.GetServiceParameter();
                foreach (KeyValuePair<String, String> kv in _dic)
                {
                    _dic1.Add(kv.Key, kv.Value);
                }
                string errorMessage = string.Empty;
                bool isok = true;
                string json = PServiceProvider.Instance.InvokeMethod(Gattr.MemberServiceUri + "/coupon_query", _dic1, ref isok, ref errorMessage);
                if (isok)
                {
                    if (!string.IsNullOrEmpty(json))
                    {
                        if (json != "-10" && json != "-20")
                        {
                            t = JsonUtility.Instance.JsonToObject<t_pos_coupon>(json);
                            if (t == null)
                            {
                                t = new t_pos_coupon() { code = "-1", info = "优惠券不存在" };
                            } else{
                                if (t.code == "2") {
                                    t = new t_pos_coupon() { info = "优惠券不存在" };
                                } else if (t.code == "3") {
                                    t = new t_pos_coupon() { info = "优惠券已使用或已停用" };
                                }
                                else if (t.code == "5")
                                {
                                    t = new t_pos_coupon() { info = "支付金额未达到可使用该优惠券的最低金额" };
                                }

                            }
                        }
                        else
                        {
                            t = new t_pos_coupon() { code = "-1", info = "非法访问接口" };
                        }
                    }
                }
                else
                {
                    t = new t_pos_coupon() { code = "404", info = errorMessage+"接口查询失败" };
                }
            }
            catch (Exception ex)
            {
                t = new t_pos_coupon() { code = "404", info = "接口查询失败" };
                LoggerHelper.Log("MsmkLogger", ex.ToString(), LogEnum.ExceptionLog);
            }


            return t;
        }




        private t_member_info InvokeMemberService(String method, Dictionary<String, String> _dic)
        {
            t_member_info t = null;
            try
            {
                Dictionary<string, object> _dic1 = Gfunc.GetServiceParameter();
                foreach (KeyValuePair<String, String> kv in _dic)
                {
                    _dic1.Add(kv.Key,kv.Value);
                }
                string errorMessage = string.Empty;
                bool isok = true;
                string json = PServiceProvider.Instance.InvokeMethod(Gattr.MemberServiceUri + "/"+ method, _dic1, ref isok, ref errorMessage);
                if (isok)
                {
                    if (!string.IsNullOrEmpty(json))
                    {
                        if (json != "-10" && json != "-20")
                        {
                            t = JsonUtility.Instance.JsonToObject<t_member_info>(json);
                            if (t == null)
                            {
                                t = new t_member_info() { code = "-1", info = "会员信息不存在" };
                            }
                        }
                        else {
                                t = new t_member_info() { code = "-1", info = "访问会员接口缺少参数" };
                        }
                    }
                }
                else
                {
                    t = new t_member_info() { code = "404", info = errorMessage };
                }
            }
            catch (Exception ex)
            {
                t = new t_member_info() { code = "404", info = "接口对接错误" };
                LoggerHelper.Log("MsmkLogger", ex.ToString(), LogEnum.ExceptionLog);
            }


            return t;

        }
        #endregion
    }
}
