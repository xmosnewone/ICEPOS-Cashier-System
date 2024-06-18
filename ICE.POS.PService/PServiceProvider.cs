using System;
using ICE.Utility;
using System.Collections.Generic;
using System.Collections;
using System.Text;
namespace ICE.POS.PService
{
    /// <summary>
    /// PHP接口数据服务
    /// </summary>
    public class PServiceProvider
    {
        #region 单例模式
        /// <summary>
        /// 实体锁
        /// </summary>
        private static object sync = new object();
        private static PServiceProvider _instance;
        /// <summary>
        /// 私有构造函数
        /// </summary>
        private PServiceProvider()
        {

        }
        /// <summary>
        /// 实体
        /// </summary>
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
        /// <summary>
        /// 生成客户端访问加密秘钥
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="access_token">访问秘钥</param>
        /// <param name="client_id">客户端访问标示</param>
        /// <returns>加密秘钥</returns>
        private string GenerateKey(Dictionary<string, object> _dicParameter)
        {
            string key = string.Empty;
            try
            {
                if (!_dicParameter.ContainsKey("access_token") || !_dicParameter.ContainsKey("client_id") || !_dicParameter.ContainsKey("username") || !_dicParameter.ContainsKey("password"))
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
        /// <summary>
        /// 准备参数
        /// </summary>
        /// <param name="_dicParameter">参数键值</param>
        /// <returns>参数组成字符串</returns>
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
        /// <summary>
        /// 获取所有门店信息
        /// </summary>
        /// <returns>门店信息</returns>
        public string InvokeMethod(string url,Dictionary<string, object> _dicParameter)
        {
            try
            {
                string key = GenerateKey(_dicParameter);
                if (!string.IsNullOrEmpty(key))
                {
                    _dicParameter.Add("key", key);
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
                throw ex;
            }
        }
        #endregion
    }
}
