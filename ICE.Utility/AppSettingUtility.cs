namespace ICE.Utility
{
    using System;
    using System.Configuration;
    public class AppSettingUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static AppSettingUtility _instance;
        
        
        
        private AppSettingUtility()
        {

        }
        
        
        
        public static AppSettingUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new AppSettingUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共函数
        
        
        
        
        
        public String GetApplicationSettingValue(String appKey)
        {
            return ConfigurationManager.AppSettings[appKey];
        }
        #endregion
    }
}
