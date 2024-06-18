namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.Utility;
    
    
    
    public class PosServericeBll
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static PosServericeBll _instance;
        
        
        
        private PosServericeBll()
        {

        }
        
        
        
        public static PosServericeBll Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new PosServericeBll();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        
        
        
        
        public bool TestConnect()
        {
            bool isConnect = false;
            bool isok = true;
            string errorMessage = string.Empty;
            Dictionary<string, object> _dic = null;
            string result = string.Empty;
            try
            {
                _dic = Gfunc.GetServiceParameter();
                result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Testconn", _dic, ref isok, ref errorMessage);
                if (!string.IsNullOrEmpty(result))
                {
                    if (result != "-10" || result != "-20")
                    {
                        if (result == "1")
                        {
                            isConnect = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->PosServericeBll-->TestConn:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isConnect;
        }
        
        
        
        
        
        
        public bool ValidatePos(string branch_no, string pos_id, ref string errorMessage1)
        {
            bool isok = false;
            try
            {
                string mac = ComputerUtility.Instance.GetMacAddress();
                string disk = ComputerUtility.Instance.GetDiskVolumeSerialNumber();
                if (disk == ICE.Common.GobalStaticString.UN_KNOWN_DISK)
                {
                    errorMessage1 = "获取机器信息失败";
                    return false;
                }
                if (mac == ICE.Common.GobalStaticString.UN_KNOWN_MAC||mac=="")
                {
                    mac= ComputerUtility.Instance.GetRandMacAddress();
                }
                string hostname = System.Environment.MachineName;
                Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                bool isok1 = true;
                string errorMessage = string.Empty;
                string result1 = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Testconn", _dic, ref isok1, ref errorMessage);
                if (isok1 == true && result1 == "1")
                {
                    _dic.Add("hostname", hostname);
                    _dic.Add("hostmac", mac);
                    _dic.Add("hostdisk", disk);
                    _dic.Add("branch_no", branch_no);
                    _dic.Add("posid", pos_id);
                    string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Validpos", _dic, ref isok1, ref errorMessage);
                    if (isok1)
                    {
                        if (result != "-10" && result != "-20")
                        {
                            switch (result)
                            {
                                case "0":
                                    isok = true;
                                    break;
                                case "1":
                                    errorMessage1 = "注册成功";
                                    isok = true;
                                    break;
                                case "2":
                                    errorMessage1 = "当前设备已注册其他POS机";
                                    break;
                                case "3":
                                    errorMessage1 = "当前选择POS机已被其他机器注册";
                                    break;
                                case "-3":
                                    errorMessage1 = "当前选择POS机处于停用状态，请选择其他POS机";
                                    break;
                                case "-4":
                                    errorMessage1 = "当前已注册POS机已经停用，请到后台解绑重新绑定其他POS机";
                                    break;
                                case "-2":
                                case "-1":
                                default:
                                    errorMessage1 = "注册/验证POS机失败";
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    isok = true;
                }
            }
            catch (Exception ex)
            {
                errorMessage1 = "注册/验证POS机失败";
                LoggerHelper.Log("MsmkLogger", "ICE.POS->Init->FrmInitData->ValidatePos->Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
    }
}
