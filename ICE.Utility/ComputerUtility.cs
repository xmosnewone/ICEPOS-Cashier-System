namespace ICE.Utility
{
    using System;
    using System.Management;
    using System.Collections.Generic;
    using ICE.Common;
    using System.Windows.Forms;


    public class ComputerUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static ComputerUtility _instance;
        
        
        
        private ComputerUtility()
        {

        }
        
        
        
        public static ComputerUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new ComputerUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        public String GetMacAddress()
        {
            String mac = "";
            ManagementObjectCollection moc = null;
            ManagementClass mc = null;
            try
            {
               
                mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {

                    if ((bool)mo["IPEnabled"] == true)
                    {
                        mac = mo["MacAddress"].ToString();
                        break;
                    }
                }

                return mac;
            }
            catch(Exception)
            {
                return GobalStaticString.UN_KNOWN_MAC;
            }
            finally
            {
                if (moc != null)
                {
                    moc.Dispose();
                }
                if (mc != null)
                {
                    mc.Dispose();
                }
            }
        }

        //随机获取一MAC地址
        public String GetRandMacAddress()
        {
            String mac = "";
            ManagementObjectCollection moc = null;
            ManagementClass mc = null;
            try
            {
            
                mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                        mac = mo["MacAddress"].ToString();
                        if (mac!="") {
                            break;
                        }
                }

                return mac;
            }
            catch (Exception)
            {
                return GobalStaticString.UN_KNOWN_MAC;
            }
        }

        private  bool IsWindows7()
        {
            Version currentVersion = Environment.OSVersion.Version;
            Version compareToVersion = new Version("6.0");
            if (currentVersion.CompareTo(compareToVersion) >= 0)
                return true;
            else
                return false;
        }
        
        
        public String GetDiskVolumeSerialNumber()
        {
            String disk = string.Empty;
            ManagementClass mc = null;
            ManagementObjectCollection moc = null;
            try
            {
                mc = new ManagementClass("Win32_DiskDrive");
                    //HDid = (string)mo.Properties["SerialNumber"].Value;//SerialNumber在Win7以上系统有效
                    //PNPDeviceID:取\之后的值
                moc = mc.GetInstances();
                Dictionary<string, object> _dic = new Dictionary<string, object>();
                foreach (ManagementObject mo in moc)
                {
                    foreach (PropertyData pd in mo.Properties)
                    {
                        if (!_dic.ContainsKey(pd.Name))
                        {
                            _dic.Add(pd.Name, pd.Value);
                        }
                    }
                }

                foreach (KeyValuePair<string, object> kv in _dic)
                {
                    if (kv.Key== "Model") { //用其他下标Signature 有可能报错，跳转到下面 catch(Exception)
                        disk = kv.Value.ToString();
                    }
                }

            }
            catch (Exception)
            {
                Boolean isWin7 = IsWindows7();
                if (isWin7)
                {
                    String HDid = "";
                    String HdType = "";
                    ManagementClass mc1 = new ManagementClass("Win32_DiskDrive");
                    ManagementObjectCollection moc1 = mc.GetInstances();
                    foreach (ManagementObject mo in moc)
                    {
                       
                        HdType = (string)mo.Properties["InterfaceType"].Value;
                        if (HdType!="USB") {
                            HDid = (string)mo.Properties["Model"].Value;
                            break;
                        }

                    }
                    if (HDid=="") {
                        //查找USB等外挂的磁盘
                        foreach (ManagementObject mo in moc)
                        {
                                HDid = (string)mo.Properties["Model"].Value;
                                if (HDid!="") {
                                        break;
                                 }
                        }
                    }
                    moc1 = null;
                    mc1 = null;
                    return HDid;
                }
                else {
                    return GobalStaticString.UN_KNOWN_DISK;
                }
            }
            finally
            {
                if (moc != null)
                {
                    moc.Dispose();
                }
                if (mc != null)
                {
                    mc.Dispose();
                }
            }
            return disk;
        }

        
        
        
        
        public Dictionary<string,object> GetDiskVolumeSerialNumber11()
        {
            Dictionary<string, object> _dic = new Dictionary<string, object>();
            ManagementClass mc = null;
            ManagementObjectCollection moc = null;
            try
            {
                mc = new ManagementClass("Win32_DiskDrive");
                moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    foreach (PropertyData pd in mo.Properties)
                    {
                        if (!_dic.ContainsKey(pd.Name))
                        {
                            _dic.Add(pd.Name, pd.Value);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return _dic;
            }
            finally
            {
                if (moc != null)
                {
                    moc.Dispose();
                }
                if (mc != null)
                {
                    mc.Dispose();
                }
            }
            return _dic;
        }

        public Dictionary<string, string> GetPrinterName()
        {
            string l_strSQL = string.Format("SELECT * from Win32_Printer where default = true ");
            Dictionary<string, string> _dic = new Dictionary<string, string>();
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(l_strSQL);
                ManagementObjectCollection printers = searcher.Get();
                foreach (ManagementObject print in printers)
                {
                    if (!_dic.ContainsKey(print["PortName"].ToString()))
                    {
                        _dic.Add(print["PortName"].ToString(), print["DriverName"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                return _dic;
            }
            return _dic;
        }
        #endregion
    }
}
