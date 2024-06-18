namespace ICE.POS.Common
{
    using System;
    using ICE.Utility;
    
    
    
    public class LoggerHelper
    {
       
        public static void Log(String loggerName, String message, LogEnum logEnum)
        {
            LoggerUtility.Instance.WriteLog(loggerName, message, (int)logEnum);
        }
    }
}
