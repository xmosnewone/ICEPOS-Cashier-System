namespace ICE.Utility
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    
    
    
    public class SecurityUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static SecurityUtility _instance;
        
        
        
        private SecurityUtility()
        {

        }
        
        
        
        public static SecurityUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new SecurityUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        
        public  String GetMD5Hash(String input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encryptedBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                sb.AppendFormat("{0:x2}", encryptedBytes[i]);
            }
            return sb.ToString();
        }
        #endregion
    }
}
