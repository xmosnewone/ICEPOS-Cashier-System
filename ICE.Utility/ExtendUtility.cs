namespace ICE.Utility
{
    using System;
    public class ExtendUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static ExtendUtility _instance;
        
        
        
        private ExtendUtility()
        {

        }
        
        
        
        public static ExtendUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new ExtendUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        #region 公共方法
        
        
        
        
        
        public String ParseToString(object obj)
        {
            String result = string.Empty;
            try
            {
                if (obj != null && obj != DBNull.Value)
                {
                    String str = obj.ToString();
                    if (str != string.Empty && str.Trim().Length > 0)
                    {
                        result = str;
                    }
                    else
                    {
                        result = String.Empty;
                    }
                }
            }
            catch (Exception)
            {

            }
            return result;
        }
        
        
        
        
        
        public Int32 ParseToInt32(object obj)
        {
            Int32 result = 0;
            try
            {
                String str = ParseToString(obj);
                if (Int32.TryParse(str, out result))
                {
                    return result;
                }
            }
            catch
            {
                result = 0;
            }
            return result;
        }
        
        
        
        
        
        public Int64 ParseToInt64(object obj)
        {
            Int64 result = 0;
            try
            {
                String str = ParseToString(obj);
                if (Int64.TryParse(str, out result))
                {
                    return result;
                }
            }
            catch
            {
                result = 0;
            }
            return result;
        }
        
        
        
        
        
        public Decimal ParseToDecimal(object obj)
        {
            Decimal result = 0M;
            try
            {
                String str = ParseToString(obj);
                if (Decimal.TryParse(str, out result))
                {
                    return result;
                }
            }
            catch
            {
                result = 0M;
            }
            return result;
        }
        
        
        
        
        
        public DateTime ParseToDateTime(object obj)
        {
            DateTime time = DateTime.MinValue;
            try
            {
                String str = ParseToString(obj);
                if (DateTime.TryParse(str, out time))
                {
                    return time;
                }
            }
            catch
            {
                time = DateTime.MinValue;
            }
            return time;
        }
        #endregion
    }
}
