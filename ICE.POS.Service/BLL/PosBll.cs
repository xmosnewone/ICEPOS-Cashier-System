 namespace ICE.POS.Service
{
    using System;
    using System.Collections.Generic;
    using System.Data;


    /// <summary>
    /// 业务逻辑类
    /// </summary>
    public class PosBll
    {
        private readonly PosDal dal = new PosDal();
        /// <summary>
        /// 返回收银列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetCashierList(string branchNo,string cashierId)
        {
            return dal.GetCashierList(branchNo,cashierId);
        }

        /// <summary>
        /// 单个组织机构信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetBranchInfo(string branchNo)
        {
            return dal.GetBranchInfo(branchNo);
        }

        /// <summary>
        /// 所有组织机构信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetBranchList()
        {
            return dal.GetBranchList();
        }
        public DataSet GetBranchStock(string branchNo, string branchText)
        {
            return dal.GetBranchStock(branchNo, branchText);
        }
        /// <summary>
        /// 条码
        /// </summary>
        /// <returns></returns>
        public DataSet GetBarcodeList()
        {
            return dal.GetBarcodeList();
        }
        /// <summary>
        /// 商品分类
        /// </summary>
        /// <returns></returns>
        public DataSet GetItemClsList()
        {
            return dal.GetItemClsList();
        }

        /// <summary>
        /// 商品列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetItemList()
        {
            return dal.GetItemList();
        }
        /// <summary>
        /// POS机状态表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPosStatusList()
        {
            return dal.GetPosStatusList();
        }
        /// <summary>
        /// 更新POS机状态表
        /// </summary>
        /// <returns></returns>
        public int UpdatePosStatus(t_sys_pos_status posStatus)
        {
            return dal.UpdatePosStatus(posStatus);
        }
        /// <summary>
        /// 会员卡付款列表
        /// </summary>
        /// <returns></returns>
        public int InsertCardPayList(List<t_rm_card_paylist> cardPayList)
        {
            return dal.InsertCardPayList(cardPayList);
        }
        /// <summary>
        /// 付款列表
        /// </summary>
        /// <returns></returns>
        public bool InPayFlowList(List<t_rm_payflow> payFlow)
        {
            return dal.InPayFlowList(payFlow);
        }
        /// <summary>
        /// 基础代码信息表
        /// </summary>
        /// <returns></returns>
        public DataSet GetBaseCodeType()
        {
            return dal.GetBaseCodeType();
        }
        /// <summary>
        /// 基础代码信息表
        /// </summary>
        /// <returns></returns>
        public DataSet GetBaseCodeInfo()
        {
            return dal.GetBaseCodeInfo();
        }
        /// <summary>
        /// 支付信息表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPaymentInfo()
        {
            return dal.GetPaymentInfo();
        }
        /// <summary>
        /// 快捷键
        /// </summary>
        /// <returns></returns>
        public DataSet GetFunction(string branchNo)
        {
            return dal.GetFunction(branchNo);
        }
        /// <summary>
        ///  终端要货主信息
        /// </summary>
        /// <returns></returns>
        public string InPMSheetMaster(t_pm_sheet_master _sheetMaster)
        {
            return dal.InPMSheetMaster(_sheetMaster);
        }

        /// <summary>
        ///  终端要货主信息
        /// </summary>
        /// <returns></returns>
        public string GetSheetMasterNo()
        {
            return dal.GetSheetMasterNo();
        }
        /// <summary>
        /// 获取终端要货信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetPMSheetMaster(string transNO,string sheetNO,string branchNO,string status,DateTime startDate, DateTime endDate)
        {
            return dal.GetPMSheetMaster(transNO, sheetNO, branchNO, status, startDate, endDate);
        }
        /// <summary>
        /// 获取终端要货商品信息
        /// </summary>
        /// <param name="sheetNO"></param>
        /// <returns></returns>
        public t_pm_sheet_master GetPMSheetDetail(string sheetNO, ref DataTable dt)
        {
            return dal.GetPMSheetDetail(sheetNO, ref dt);
        }
        ///// <summary>
        ///// 单个要货记录
        ///// </summary>
        ///// <param name="sheetNO"></param>
        ///// <returns></returns>
        //public t_pm_sheet_master GetPMSheetMByOne(string sheetNO)
        //{
        //    return dal.GetPMSheetMByOne(sheetNO);
        //}

        /// <summary>
        /// 获取POS机设置
        /// </summary>
        /// <returns></returns>
        public String GetPosSet()
        {
            return dal.GetSysPosSet();
        }
    }
}

