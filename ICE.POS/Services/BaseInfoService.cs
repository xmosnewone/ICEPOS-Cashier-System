namespace ICE.POS
{
    using System;
    using System.Data;
    using System.Net;
    
    using ICE.POS.Common;
    //using ICE.POS.Msmk;
    
    
    
    public class BaseInfoService
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static BaseInfoService _instance;
        
        
        
        private BaseInfoService()
        {

        }
        
        
        
        public static BaseInfoService Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new BaseInfoService();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 私有方法
        
        
        
        
        
        
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
        #endregion
        #region 公开方法
        
        
        
        
        
        
        
        
        public object InvokeService(String uri, String posPath, String opMark, ref bool isOk, String branch_no)
        {
            object obj = null;
            //String address = string.Empty;
            //bool isConnect = false;
            //DataSet ds = null;
            //try
            //{
            //    address = GetWebRequestAddress(uri, posPath);
            //    if (!SIString.IsNullOrEmptyOrDBNull(address))
            //    {

            //        PosServices posService = new PosServices();
            //        posService.Url = address;
            //        isConnect = posService.TestConnection();

            //        if (isConnect)
            //        {
            //            if (opMark != "TestConnection")
            //            {
            //                ds = new DataSet();
            //            }
            //            switch (opMark)
            //            {
            //                case "GetBarCodeList":
            //                case "GetItemClsList":
            //                case "GetItemList":
            //                case "GetBranchList":
            //                case "GetCashierList":
            //                case "GetBaseCodeType":
            //                case "GetBaseCodeInfo":
            //                case "GetPaymentInfo":
            //                case "GetPosStatusList":
            //                case "GetBranchStock":
            //                case "GetFunction":
            //                case "GetPMSheetMaster":
            //                case "GetPMSheetDetail":
            //                    switch (opMark)
            //                    {
            //                        case "GetBarCodeList":
            //                            ds = posService.GetBarcodeList();
            //                            break;
            //                        case "GetItemClsList":
            //                            ds = posService.GetItemClsList();
            //                            break;
            //                        case "GetItemList":
            //                            ds = posService.GetItemList();
            //                            break;
            //                        case "GetBranchList":
            //                            ds = posService.GetBranchList();
            //                            break;
            //                        case "GetCashierList":
            //                            ds = posService.GetCashierList(branch_no, "");
            //                            break;
            //                        case "GetBaseCodeType":
            //                            ds = posService.GetBaseCodeType();
            //                            break;
            //                        case "GetBaseCodeInfo":
            //                            ds = posService.GetBaseCodeInfo();
            //                            break;
            //                        case "GetPaymentInfo":
            //                            ds = posService.GetPaymentInfo();
            //                            break;
            //                        case "GetFunction":
            //                            ds = posService.GetFunction(branch_no);
            //                            break;
            //                        case "GetPosStatusList":
            //                            ds = posService.GetPosStatusList();
            //                            break;
            //                        case "GetBranchStock":
            //                            ds = posService.GetBranchStock(branch_no, this.BranchTextKey);
            //                            break;
            //                        case "GetPMSheetMaster":
            //                            ds = posService.GetPMSheetMaster(this.TransNO, this.SheetNO, this.BranchNO, this.Status, this.StartDate, this.EndDate);
            //                            break;

            //                    }
            //                    if (!SIString.IsNullOrEmptyDataSet(ds))
            //                    {
            //                        if (!SIString.IsNullOrEmptyDataTable(ds.Tables[0]))
            //                        {
            //                            obj = ds.Tables[0];
            //                        }
            //                    }
            //                    break;
            //                case "InPMSheetMaster":
            //                    obj = (object)posService.InPMSheetMaster(this.SheetMaster);
            //                    break;

            //                default:

            //                    obj = isConnect;
            //                    break;
            //            }
            //        }
            //        else
            //        {
            //            if (opMark != "TestConnection")
            //            {
            //                obj = "连接失败";
            //                isOk = false;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        obj = "网址或POS机服务配置不正确";
            //        isOk = false;
            //    }
            //}
            //catch (Exception exception)
            //{
            //    obj = exception.ToString();
            //    LoggerHelper.Log("MsmkLogger", SIString.TryStr(obj), LogEnum.ExceptionLog);
            //    isOk = false;
            //}
            return obj;
        }
        #endregion
        
        
        
        public string BranchTextKey { set; get; }
        //public t_pm_sheet_master SheetMaster { set; get; }
        public string TransNO { set; get; }
        public string SheetNO { set; get; }
        public string BranchNO { set; get; }
        public string Status { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
    }
}
