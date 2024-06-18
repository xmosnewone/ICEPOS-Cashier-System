using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ICE.Utility
{
    public class ConfigUtility
    {
        #region 单例模式

        
        
        
        private static object sync = new object();
        private static ConfigUtility _instance;
        
        
        
        private ConfigUtility()
        {

        }
        
        
        
        public static ConfigUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new ConfigUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        #region 公共方法

        
        
        
        
        
        public void SetValue(string key, string value)
        {
            //增加的内容写在appSettings段下 <add key="RegCode" value="0"/> 
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//重新加载新的配置文件  
        }

        
        
        
        
        
        public string GetValue(string key)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                return "";
            else
                return config.AppSettings.Settings[key].Value;
        }
        #endregion

    }
}
