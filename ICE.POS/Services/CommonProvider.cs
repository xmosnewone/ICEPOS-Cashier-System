using System;
using System.Collections.Generic;
using ICE.POS.Common;

namespace ICE.POS
{
    public class CommonProvider
    {
        public static String InvokePOSAPI(String action, Dictionary<String, Object> _dic)
        {
            String result = string.Empty;
            String errorMessage = string.Empty;
            bool isok = true;
            result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/" + action, _dic, ref isok, ref errorMessage);
            if (errorMessage.Length > 0)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS.CommonProvider-->Error:" + errorMessage, LogEnum.ExceptionLog);
            }
            return result;
        }
    }
}
