namespace ICE.POS
{


    using System;
    using System.Collections.Generic;
    using System.Data;
    //using ICE.POS.Msmk;
    public class ServerBll
    {
        private string _serverUrl = string.Empty;

        
        
        
        
        public bool TestConnection()
        {
            try
            {
                //new PosServices { Url = GetWebRequestAddress(Gattr.HttpAddress, Gattr.WebPosServicePath), Timeout = 0x2710 }.TestConnection();
                return true;
            }
            catch (Exception exception)
            {
                Gattr.ErrMsg = "连接出错，错误信息为:\r\n\r\n" + exception.Message;
                return false;
            }
        }

        //public PosServices GetPosServices()
        //{
        //    PosServices pos = null;
        //    if (TestConnection())
        //    {
        //        pos = new PosServices();
        //        pos.Url = GetWebRequestAddress(Gattr.HttpAddress, Gattr.WebPosServicePath);
        //        return pos;

        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}
        
        
        
        
        
        
        //public t_pm_sheet_master GetPMSheetDetail(string sheetNO, ref DataTable dt)
        //{
        //    if (GetPosServices() != null)
        //    {
        //        return this.GetPosServices().GetPMSheetDetail(sheetNO, ref dt);
        //    }
        //    return null;
        //}
        
        
        
        
        
        
        //public bool InPayFlowList(List<t_rm_payflow> payflowList)
        //{
        //    if (GetPosServices() != null)
        //    {
        //        return this.GetPosServices().InPayFlowList(payflowList.ToArray());
        //    }
        //    return false;
        //}
        
        
        
        
        
        
        private String GetWebRequestAddress(String uri, String path)
        {
            String address = String.Empty;
            if (!SIString.IsNullOrEmptyOrDBNull(uri) && !SIString.IsNullOrEmptyOrDBNull(path))
            {
                if (uri.EndsWith(@"/"))
                {
                    address = string.Format(@"{0}{1}", uri, path);
                }
                else
                {
                    address = string.Format(@"{0}/{1}", uri, path);
                }
            }
            return address;
        }
        //public string SetPwd()
        //{
        //    PosServices service = new PosServices();
        //    try
        //    {
        //        service.Url = Gattr.WebPosServicePath;
        //        // return service.vippasswordchange("15020364165", "8f92b9ac87ccc718dea786477e46e1c4");
        //    }
        //    catch (Exception exception)
        //    {
        //        throw exception;
        //    }
        //    finally
        //    {
        //        service.Dispose();
        //    }
        //    return "";
        //}

        //public string GetHellWorld()
        //{
        //    //if (this.TestConnection())
        //    //{
        //    //PosServices service = new PosServices();
        //    //try
        //    //{
        //    //    service.Url = this.GetWebUrl(Gattr.WebPosServicePath);

        //    //    return "";// service.GetData("sss");
        //    //}
        //    //catch (Exception exception)
        //    //{
        //    //    throw exception;
        //    //}
        //    //finally
        //    //{
        //    //    service.Dispose();
        //    //}
        //    //}
        //    //return "";
        //}

        
        
        
        
        
        public string GetWebUrl(string webPath)
        {
            if (SIString.TryStr(this._serverUrl).Trim() == string.Empty)
            {
                throw new Exception("服务器地址不能为空！");
            }
            return SIString.TryStr(this._serverUrl + webPath).Trim();
        }
        
        
        
        public string ServerUrl
        {
            get { return _serverUrl; }
            set { _serverUrl = value; }
        }
    }
}
