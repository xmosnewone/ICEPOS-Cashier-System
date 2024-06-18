namespace ICE.POS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ICE.Utility;
    
    
    
    public class PServiceProvider
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static PServiceProvider _instance;
        
        
        
        private PServiceProvider()
        {

        }
        
        
        
        public static PServiceProvider Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new PServiceProvider();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 私有方法
        private string GenerateKey(Dictionary<string, object> _dicParameter)
        {
            string key = string.Empty;
            try
            {
                if (!_dicParameter.ContainsKey("access_token") || !_dicParameter.ContainsKey("client_id"))
                {
                    key = string.Empty;
                }
                else
                {
                    key = "access_token={0}&client_id={1}&username={2}&password={3}";
                    key = string.Format(key, _dicParameter["access_token"], _dicParameter["client_id"], _dicParameter["username"], _dicParameter["password"]);
                    key = key + _dicParameter["access_token"];
                    key = SecurityUtility.Instance.GetMD5Hash(SecurityUtility.Instance.GetMD5Hash(key)).ToLower();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return key;
        }
        
        
        
        
        
        private string PrepareParameters(Dictionary<string, object> _dicParameter)
        {
            string result = string.Empty;
            StringBuilder sb = new StringBuilder();
            int index = 0;
            foreach (KeyValuePair<string, object> kv in _dicParameter)
            {
                if (index != _dicParameter.Count - 1)
                {
                    sb.Append(kv.Key + "=" + kv.Value + "&");
                }
                else
                {
                    sb.Append(kv.Key + "=" + kv.Value);
                }
                index++;
            }
            result = sb.ToString();
            return result;
        }
        #endregion
        #region 公共方法
        
        
        
        
        public string InvokeMethod(string url, Dictionary<string, object> _dicParameter, ref bool isok, ref string errorMessage)
        {
            try
            {
                string key = GenerateKey(_dicParameter);
                if (!string.IsNullOrEmpty(key))
                {
                    if (!_dicParameter.ContainsKey("key"))
                    {
                        _dicParameter.Add("key", key);
                    }
                    string parameters = PrepareParameters(_dicParameter);
                    if (!string.IsNullOrEmpty(parameters))
                    {
                        return WebUtility.Instance.GetPostHttpWebResponse(url, parameters);
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                isok = false;
                errorMessage = ex.ToString();
                return string.Empty;
            }
        }
        #endregion
    }
}
