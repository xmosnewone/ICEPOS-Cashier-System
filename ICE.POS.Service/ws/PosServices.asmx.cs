namespace ICE.POS.Service
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Web.Services;
    using System.Xml.Serialization;
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class PosServices : System.Web.Services.WebService
    {
        private readonly PosBll bll = new PosBll();
        RSAGenerator rsag = new RSAGenerator();
        [WebMethod]
        public string HelloWorld()
        {
            return bll.GetSheetMasterNo();
        }
        [WebMethod(Description = "测试连接")]
        public bool TestConnection()
        {
            return SqlHelper.TestConnection(SqlHelper.connectionString);
        }
        [WebMethod(Description = "修改收银密码")]
        public string SetCashierPwd(string pwd)
        {
            return "";
        }
        [WebMethod(Description = "收银员信息,CashierId允许为空")]
        public DataSet GetCashierList(string branchNo, string cashierId)
        {
            return bll.GetCashierList(branchNo, cashierId);
        }
        [WebMethod(Description = "获取单个机构信息")]
        public DataSet GetBranchInfo(string branchNo)
        {
            return bll.GetBranchInfo(branchNo);
        }
        [WebMethod(Description = "所有机构信息")]
        public DataSet GetBranchList()
        {
            return bll.GetBranchList();
        }
        [WebMethod(Description = "机构库存信息")]
        public DataSet GetBranchStock(string branchNo, string branchText)
        {
            return bll.GetBranchStock(branchNo, branchText);
        }
        [WebMethod(Description = "条码信息")]
        public DataSet GetBarcodeList()
        {
            return bll.GetBarcodeList();
        }
        [WebMethod(Description = "商品列表")]
        public DataSet GetItemList()
        {
            return bll.GetItemList();
        }
        [WebMethod(Description = "商品分类列表")]
        public DataSet GetItemClsList()
        {
            return bll.GetItemClsList();
        }
        [WebMethod(Description = "POS机状态信息")]
        public DataSet GetPosStatusList()
        {
            return bll.GetPosStatusList();
        }
        [WebMethod(Description = "基础代码信息表")]
        public DataSet GetBaseCodeType()
        {
            return bll.GetBaseCodeType();
        }
        [WebMethod(Description = "基础代码信息表")]
        public DataSet GetBaseCodeInfo()
        {
            return bll.GetBaseCodeInfo();
        }
        [WebMethod(Description = "支付信息")]
        public DataSet GetPaymentInfo()
        {
            return bll.GetPaymentInfo();
        }
        [WebMethod(Description = "快捷键")]
        public DataSet GetFunction(string branchNo)
        {
            return bll.GetFunction(branchNo);
        }
        [WebMethod(Description = "查询要货主表信息")]
        public DataSet GetPMSheetMaster(string transNO, string sheetNO, string branchNO, string status, DateTime startDate, DateTime endDate)
        {
            return bll.GetPMSheetMaster(transNO, sheetNO, branchNO, status, startDate, endDate);
        }
        [WebMethod(Description = "查询要货商品信息")]
        public t_pm_sheet_master GetPMSheetDetail(string sheetNO, ref DataTable dt)
        {
            return bll.GetPMSheetDetail(sheetNO, ref dt);
        }
        //[WebMethod(Description = "要货主表实体")]
        //public t_pm_sheet_master GetPMSheetMByOne(string sheetNO)
        //{
        //    return bll.GetPMSheetMByOne(sheetNO);
        //}
        [XmlInclude(typeof(t_sys_pos_status))]
        [WebMethod(Description = "更新POS机状态信息")]
        public int UpdatePosStatus(t_sys_pos_status posStatus)
        {
            return bll.UpdatePosStatus(posStatus);
        }
        [XmlInclude(typeof(List<t_rm_card_paylist>))]
        [WebMethod(Description = "会员卡付款列表")]
        public int InsertCardPayList(List<t_rm_card_paylist> cardPayList)
        {
            return bll.InsertCardPayList(cardPayList);
        }
        [XmlInclude(typeof(List<t_rm_card_paylist>))]
        [WebMethod(Description = "付款列表")]
        public bool InPayFlowList(List<t_rm_payflow> payFlow)
        {
            return bll.InPayFlowList(payFlow);
        }
        [XmlInclude(typeof(t_pm_sheet_master))]
        [WebMethod(Description = "终端采购主信息")]
        public string InPMSheetMaster(t_pm_sheet_master _sheetMaster)
        {
            return bll.InPMSheetMaster(_sheetMaster);
        }
        [WebMethod(Description = "获取POS机配置信息")]
        public String GetPosSet()
        {
            return bll.GetPosSet();
        }
        //[WebMethod(Description = "公钥")]
        //public string GetPublicKey()
        //{
        //    return rsag.GetPublicKey();
        //}
        //[WebMethod(Description = "私钥")]
        //public string GetPrivateKey()
        //{
        //    return rsag.GetPrivateKey();
        //}

        //[WebMethod(Description = "根据公钥加密字符串")]
        //public string EncriptByPublicKey(string orgStr,string publicKey)
        //{
        //    return rsag.EncriptByPublicKey(orgStr, publicKey);
        //}
        //[WebMethod(Description = "根据私钥解密")]
        //public string DecriptByPrivateKey(string encStr,string privateKey)
        //{
        //    return rsag.DecriptByPrivateKey(encStr, privateKey);
        //}
    }
}