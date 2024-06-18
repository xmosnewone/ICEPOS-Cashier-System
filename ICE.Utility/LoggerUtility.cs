namespace ICE.Utility
{
    using System;
    using log4net;
    
    
    
    public class LoggerUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static LoggerUtility _instance;
        
        
        
        private LoggerUtility()
        {

        }
        
        
        
        public static LoggerUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new LoggerUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 变量声明
        static ILog logger = null;
        #endregion
        #region 私有方法
        void GetLogger(String loggerName)
        {
            if (logger == null)
            {
                logger = log4net.LogManager.GetLogger(loggerName);
            }
        }
        #endregion
        #region 对外公开方法
        
        
        
        
        
        
        
        public void WriteLog(String loggerName, Exception ex, String exType, Int32 mark)
        {
            GetLogger(loggerName);
            switch (mark)
            {
                case 1:
                    logger.Fatal(exType, ex);
                    break;
                case 2:
                    logger.Error(exType, ex);
                    break;
                case 3:
                    logger.Warn(exType, ex);
                    break;
                case 5:
                    logger.Debug(exType, ex);
                    break;
                default:
                    logger.Info(exType, ex);
                    break;
            }
        }
        
        
        
        
        
        
        public void WriteLog(String loggerName, string msg, Int32 mark)
        {
            GetLogger(loggerName);
            switch (mark)
            {
                case 1:
                    logger.Fatal(msg);
                    break;
                case 2:
                    logger.Error(msg);
                    break;
                case 3:
                    logger.Warn(msg);
                    break;
                case 5:
                    logger.Debug(msg);
                    break;
                default:
                    logger.Info(msg);
                    break;
            }
        }
        #endregion
    }
}
