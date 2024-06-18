using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using ICE.POS.Common;
using ICE.Utility;
using ICE.POS.Model;

namespace ICE.POS.Transfer
{
   
    public class SyncProcessor
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static SyncProcessor _instance;
        
        
        
        private SyncProcessor()
        {

        }
        
        
        
        public static SyncProcessor Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new SyncProcessor();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        public bool SyncMember(DataTable table)
        {
            bool isok = true;
            try
            {
                
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Transfer->SyncProcessor-->Exception:" + ex.ToString(),
                     LogEnum.ExceptionLog);
            }
            return isok;
        }
        #endregion
        #region 私有方法
        
        public t_member_info InvokeMemberService(String method, Dictionary<String, String> _dic)
        {
            String parameter = String.Empty;
            String address = String.Empty;
            String response = String.Empty;
            t_member_info t = null;
            try
            {
                parameter = MemberServicesProvider.Instance.PrepareParameters(method, GlobalSet.access_way, GlobalSet.mem_access_token, _dic);
                address = GlobalSet.memberUrl + parameter;
                response = WebUtility.Instance.GetHttpWebResponse(address);
                if (response != "404")
                {
                    t = JsonUtility.Instance.JsonToObject<t_member_info>(response);
                    if (t == null)
                    {
                        t = new t_member_info() { code = "-1", info = response };
                    }
                }
                else
                {
                    t = new t_member_info() { code = "404", info = "远程服务器返回异常" };
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Transfer->SyncProcessor-->InvokeMemberService-->Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return t;
        }
        #endregion
    }
}
