
namespace ICE.POS.Common
{
    using System;
    using System.Data;
    //using ICE.POS.Common.POSServices;
    public class PosServiceProvider
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static PosServiceProvider _instance;
        
        
        
        private PosServiceProvider()
        {

        }
        
        
        
        public static PosServiceProvider Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new PosServiceProvider();
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
            if (!String.IsNullOrEmpty(uri) && !String.IsNullOrEmpty(path))
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
        
        
        
        
        
        
        
        
        //public bool UploadPayAndSaleInfo(String uri, String posPath, DataTable tablePay, DataTable tableSale, ref bool isok)
        //{
        //    object obj = null;
        //    String address = string.Empty;
        //    bool isConnect = false;
        //    t_rm_payflow[] payarr = null;
        //    t_rm_saleflow[] salearr = null;
        //    try
        //    {
        //        address = GetWebRequestAddress(uri, posPath);
        //        if (!String.IsNullOrEmpty(address))
        //        {
        //            PosServices posService = new PosServices();
        //            posService.Url = address;
        //            isConnect = posService.TestConnection();
        //            if (isConnect)
        //            {
        //                if (tablePay != null && tablePay.Rows.Count > 0)
        //                {
        //                    payarr = new t_rm_payflow[tablePay.Rows.Count];
        //                    int rindex = 0;
        //                    foreach (DataRow dr in tablePay.Rows)
        //                    {
        //                        payarr[rindex] = new t_rm_payflow();
        //                        payarr[rindex].flow_id = decimal.Parse(dr["flow_id"].ToString());
        //                        payarr[rindex].flow_no = dr["flow_no"].ToString();
        //                        payarr[rindex].sale_amount = decimal.Parse(dr["sale_amount"].ToString());
        //                        payarr[rindex].branch_no = dr["branch_no"].ToString();
        //                        payarr[rindex].pay_way = dr["pay_way"].ToString();
        //                        payarr[rindex].sell_way = dr["sale_way"].ToString();
        //                        payarr[rindex].card_no = dr["card_no"].ToString();
        //                        payarr[rindex].vip_no = "";
        //                        payarr[rindex].coin_no = dr["coin_type"].ToString();
        //                        payarr[rindex].coin_rate = decimal.Parse(dr["coin_rate"].ToString());
        //                        payarr[rindex].pay_amount = decimal.Parse(dr["pay_amount"].ToString());
        //                        payarr[rindex].oper_date = DateTime.Parse(dr["oper_date"].ToString());
        //                        payarr[rindex].oper_id = dr["oper_id"].ToString();
        //                        payarr[rindex].voucher_no = dr["voucher_no"].ToString();
        //                        payarr[rindex].posid = dr["pos_id"].ToString();
        //                        payarr[rindex].memo = dr["memo"].ToString();
        //                        payarr[rindex].com_flag = dr["com_flag"].ToString();
        //                        payarr[rindex].com_no = 0;
        //                        payarr[rindex].counter_no = "";
        //                        payarr[rindex].exchange_flag = "";
        //                        payarr[rindex].is_jxc = "";
        //                        payarr[rindex].real_date = null;
        //                        payarr[rindex].remote_flag = "";
        //                        payarr[rindex].sale_man = "";
        //                        payarr[rindex].shift_no = "";
        //                        payarr[rindex].uptime = null;
        //                        if (rindex == 0)
        //                        {
        //                            if (tableSale != null && tableSale.Rows.Count > 0)
        //                            {
        //                                salearr = new t_rm_saleflow[tableSale.Rows.Count];
        //                                for (int index = 0; index < tableSale.Rows.Count; index++)
        //                                {
        //                                    salearr[index] = new t_rm_saleflow();
        //                                    salearr[index].flow_id = decimal.Parse(tableSale.Rows[index]["flow_id"].ToString());
        //                                    salearr[index].flow_no = tableSale.Rows[index]["flow_no"].ToString();
        //                                    salearr[index].branch_no = tableSale.Rows[index]["branch_no"].ToString();
        //                                    salearr[index].item_no = tableSale.Rows[index]["item_no"].ToString();
        //                                    salearr[index].source_price = decimal.Parse(tableSale.Rows[index]["unit_price"].ToString());
        //                                    salearr[index].sale_price = decimal.Parse(tableSale.Rows[index]["sale_price"].ToString());
        //                                    salearr[index].sale_qnty = decimal.Parse(tableSale.Rows[index]["sale_qnty"].ToString());
        //                                    salearr[index].sale_money = decimal.Parse(tableSale.Rows[index]["sale_money"].ToString());
        //                                    salearr[index].sell_way = tableSale.Rows[index]["sale_way"].ToString();
        //                                    salearr[index].oper_id = tableSale.Rows[index]["oper_id"].ToString();
        //                                    salearr[index].sale_man = "";
        //                                    salearr[index].counter_no = "";
        //                                    salearr[index].oper_date = DateTime.Parse(tableSale.Rows[index]["oper_date"].ToString());
        //                                    salearr[index].remote_flag = "";
        //                                    salearr[index].shift_no = "";
        //                                    salearr[index].real_date = DateTime.Parse(tableSale.Rows[index]["oper_date"].ToString());
        //                                    salearr[index].spec_flag = "";
        //                                    salearr[index].pref_amt = 0M;
        //                                    salearr[index].in_price = 0M;
        //                                    salearr[index].n_stan = 0M;
        //                                    salearr[index].posid = tableSale.Rows[index]["pos_id"].ToString();
        //                                    salearr[index].uptime = null;
        //                                    salearr[index].is_jxc = "";
        //                                    salearr[index].spec_group_id = "";
        //                                    salearr[index].spec_sheet_no = "";
        //                                    salearr[index].chr_stan = "";
        //                                    salearr[index].com_flag = "";
        //                                    salearr[index].com_no = "";
        //                                }
        //                            }
        //                            payarr[rindex].saleFlowlList = salearr;
        //                        }//if (rindex == 0)
        //                        rindex++;
        //                    }//foreach (DataRow dr in tablePay.Rows)
        //                }// if (tablePay != null && tablePay.Rows.Count > 0)
        //                if (payarr != null && payarr.Length > 0)
        //                {
        //                    obj = posService.InPayFlowList(payarr);
        //                }
        //            }//if (isConnect)
        //            else
        //            {
        //                obj = "连接失败";
        //                isok = false;
        //            }
        //        }
        //        else
        //        {
        //            obj = "网址或POS机服务配置不正确";
        //            isok = false;
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        obj = exception.ToString();
        //        LoggerHelper.Log("MsmkLogger", "Msmk.Common--->PosServiceProvider---->UploadPayAndSaleInfo---->Error:" + exception.ToString(), LogEnum.ExceptionLog);
        //        LoggerHelper.Log("MsmkLogger", obj, LogEnum.ExceptionLog);
        //        isok = false;
        //    }
        //    return isok;
        //}
        
        
        
        
        
        
        
        
        //public object InvokeService(String uri, String posPath, String opMark, ref bool isOk, String branch_no)
        //{
            //object obj = null;
            //String address = string.Empty;
            //bool isConnect = false;
            //DataSet ds = null;
            //try
            //{
            //    address = GetWebRequestAddress(uri, posPath);
            //    if (!String.IsNullOrEmpty(address))
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
            //                    if (ds != null && ds.Tables.Count > 0)
            //                    {
            //                        if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            //                        {
            //                            obj = ds.Tables[0];
            //                        }
            //                    }
            //                    break;
            //                case "InPMSheetMaster":
            //                    obj = (object)posService.InPMSheetMaster(this.SheetMaster);
            //                    break;
            //                case "GetPosSet":
            //                    obj= posService.GetPosSet();
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
            //    LoggerHelper.Log("MsmkLogger", exception.ToString(), LogEnum.ExceptionLog);
            //    //LoggerHelper.Log("MsmkLogger", obj, LogEnum.ExceptionLog);
            //    isOk = false;
            //}
           // return obj;
        //}
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
