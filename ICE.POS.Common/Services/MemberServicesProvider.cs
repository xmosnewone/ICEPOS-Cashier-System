using System;
using System.Collections.Generic;
using System.Text;
using ICE.Utility;

namespace ICE.POS.Common
{
    public class MemberServicesProvider
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static MemberServicesProvider _instance;
        
        
        
        private MemberServicesProvider()
        {

        }
        
        
        
        public static MemberServicesProvider Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new MemberServicesProvider();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        
        
        
        
        
        
        public String PrepareParameters(String action, String ServiceWay, String UseToken, Dictionary<String, String> _dic)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            sb.AppendFormat("?job={0}&", action);
            sb.AppendFormat("way={0}&", ServiceWay);
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
                        sb1.AppendFormat("way={0}&", ServiceWay);
                    }
                    else
                    {
                        sb1.AppendFormat("time={0}&", time);
                    }
                }
            }
            sb1.AppendFormat("key={0}", UseToken);
            key = SecurityUtility.Instance.GetMD5Hash(sb1.ToString()).ToLower();
            sb.AppendFormat("key={0}", key);
            return sb.ToString();
        }
    }
}
