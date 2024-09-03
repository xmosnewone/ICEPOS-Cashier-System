/********************************************************
 * Description:促销处理逻辑类
 * ******************************************************/
using System;
namespace ICE.POS
{
    using System.Collections.Generic;
    using System.Data;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    public class PlanDealer
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static PlanDealer _instance;
        
        
        
        private PlanDealer()
        {

        }
        
        
        
        public static PlanDealer Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new PlanDealer();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        
        public List<t_rm_plan_master> GetPlanPluMasters(List<t_cur_saleflow> _saleInfos, string vip_type)
        {
            List<t_rm_plan_master> _planMasters = new List<t_rm_plan_master>();
            try
            {
                List<t_rm_plan_master> _tempMasters = GetPlanPara("1", "", "", "'PG'", vip_type);
                foreach (t_rm_plan_master _master in _tempMasters)
                {
                    if (CheckItems(_master.PlanPara, _saleInfos))//满足规则
                    {
                        _planMasters.Add(_master);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>GetPlanPluMasters>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _planMasters;
        }
        
        
        
        
        
        public List<t_cur_saleflow> DearBeforePLU(List<t_cur_saleflow> _saleFlow, string vip_type)
        {
            List<t_cur_saleflow> _saleInfo = new List<t_cur_saleflow>();
            try
            {
                List<t_rm_plan_master> _planPara = GetPlanPara("0", "", "", "'PG'", vip_type);
                _saleInfo = DearSaleFlow(_saleFlow, _planPara, vip_type);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearDisSaleFlow>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleInfo;
        }
        
        
        
        
        
        
        public List<t_cur_saleflow> DearPluSaleFlow(t_rm_plan_master plan, List<t_cur_saleflow> saleFlows)
        {
            List<t_cur_saleflow> resultFlows = new List<t_cur_saleflow>();
            try
            {
                List<CheckPara> _cps = plan.PlanPara.AddPara;
                List<CheckPara> _res = plan.PlanPara.ResultParas;
                if (_res != null && _res.Count > 0)//有附加信息
                {
                    foreach (CheckPara _cp in _res)
                    {
                        decimal _sumAmt = 0M;
                        decimal _subAmt = 0M;
                        decimal _sum = 0M;
                        decimal _realSubAmt = 0M;
                        #region 倍数减规则
                        if (_cp.check_operator == "*-" || _cp.check_operator == "-")
                        {
                            #region 获取总金额
                            foreach (t_cur_saleflow sale in saleFlows)
                            {
                                switch (_cp.check_type)
                                {
                                    case "CLS":
                                        if (sale.item_clsno.StartsWith(_cp.type_val))
                                        {
                                            _sum += sale.sale_money;
                                        }
                                        break;
                                    case "BRAND":
                                        if (sale.item_brand == _cp.type_val)
                                        {
                                            _sum += sale.sale_money;
                                        }
                                        break;
                                    case "ITEM":
                                        if (sale.item_no == _cp.type_val)
                                        {
                                            _sum += sale.sale_money;
                                        }
                                        break;
                                    default:
                                        _sum += sale.sale_money;
                                        break;
                                }
                            }
                            #endregion
                            if (_cp.check_operator == "*-")
                            {
                                _sumAmt = _cps[0].throld;
                                _subAmt = _cp.throld;
                                _realSubAmt = ((_sum / _sumAmt) * _subAmt);
                                _realSubAmt = _sum - _realSubAmt;
                            }
                            else
                            {
                                _sumAmt = _cp.throld;
                                _subAmt = _res[0].throld;
                                _realSubAmt = _sum - _sumAmt;
                            }
                            foreach (t_cur_saleflow sale in saleFlows)
                            {
                                bool isok = false;
                                switch (_cp.check_type)
                                {
                                    case "CLS":
                                        if (sale.item_clsno.StartsWith(_cp.type_val))
                                        {
                                            isok = true;
                                        }
                                        break;
                                    case "BRAND":
                                        if (sale.item_brand == _cp.type_val)
                                        {
                                            isok = true;
                                        }
                                        break;
                                    case "ITEM":
                                        if (sale.item_no == _cp.type_val)
                                        {
                                            isok = true;
                                        }
                                        break;
                                    default:
                                        isok = true;
                                        break;
                                }
                                if (isok)
                                {
                                    //金额占总金额的比例然后在乘以需要添加的金额
                                    decimal _money = (sale.sale_money * _realSubAmt) / _sum;
                                    sale.sale_money = GetDecimal(_money);
                                    sale.unit_price = GetDecimal(sale.sale_money / sale.sale_qnty);
                                    sale.plan_no = plan.plan_no;
                                    sale.isYh = true;
                                    resultFlows.Add(sale);
                                }
                                else
                                {
                                    resultFlows.Add(sale);
                                }
                            }
                        }
                        #endregion
                        #region 打折
                        else if (_cp.check_operator == "*")
                        {
                            if (_cp.isAmt)
                            {
                                _sumAmt = _cp.throld;
                            }
                            foreach (t_cur_saleflow sale in saleFlows)
                            {
                                bool isok22 = false;
                                switch (_cp.check_type)
                                {
                                    case "CLS":
                                        if (sale.item_clsno.StartsWith(_cp.type_val))
                                        {
                                            isok22 = true;
                                        }
                                        break;
                                    case "BRAND":
                                        if (sale.item_brand == _cp.type_val)
                                        {
                                            isok22 = true;
                                        }
                                        break;
                                    case "ITEM":
                                        if (sale.item_no == _cp.type_val)
                                        {
                                            isok22 = true;
                                        }
                                        break;
                                    default:
                                        isok22 = true;
                                        break;
                                }
                                if (isok22)
                                {
                                    //金额占总金额的比例然后在乘以需要添加的金额
                                    sale.unit_price = GetDecimal(sale.unit_price * _sumAmt);
                                    sale.sale_money = GetDecimal(sale.unit_price * sale.sale_qnty);
                                    sale.plan_no = plan.plan_no;
                                    sale.isYh = true;
                                    resultFlows.Add(sale);
                                }
                                else
                                {
                                    resultFlows.Add(sale);
                                }
                            }

                        }
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearPluSaleFlow>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }

            return resultFlows;
        }
        
        
        
        
        
        
        public List<t_cur_saleflow> DearSendFlow(t_rm_plan_master master, List<t_cur_saleflow> sendInfos)
        {
            List<t_cur_saleflow> _saleInfos = new List<t_cur_saleflow>();
            try
            {
                List<CheckPara> _addParas = master.PlanPara.AddPara;
                if (_addParas != null && _addParas.Count > 0)
                {
                    //需要修改商品的价格信息
                    foreach (CheckPara _cp in _addParas)
                    {
                        decimal _sumAmt = 0M;
                        if (_cp.check_operator == "+")
                        {
                            if (_cp.isAmt)
                            {
                                _sumAmt = _cp.throld;
                            }
                            decimal _sum = 0M;
                            foreach (t_cur_saleflow sale in sendInfos)
                            {
                                _sum += sale.sale_money;
                            }
                            foreach (t_cur_saleflow sale in sendInfos)
                            {
                                //金额占总金额的比例然后在乘以需要添加的金额
                                decimal _money = (sale.sale_money * _sumAmt) / _sum;
                                sale.sale_money = GetDecimal(_money);
                                sale.unit_price = GetDecimal(sale.sale_money / sale.sale_qnty);
                                sale.plan_no = master.plan_no;
                                sale.sale_way = "C";
                                sale.isYh = true;
                                _saleInfos.Add(sale);
                            }
                        }
                    }
                }
                else
                {
                    //直接赠送
                    foreach (t_cur_saleflow saleinfo in sendInfos)
                    {
                        saleinfo.unit_price = 0M;
                        saleinfo.sale_money = 0M;
                        saleinfo.sale_way = "C";
                        saleinfo.plan_no = master.plan_no;
                        _saleInfos.Add(saleinfo);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearSendFlow>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleInfos;
        }
        
        
        
        
        
        public List<t_cur_saleflow> DearSendInfo(string plan_no, List<CheckPara> _paras)
        {
            List<t_cur_saleflow> saleInfos = new List<t_cur_saleflow>();
            try
            {
                foreach (CheckPara cp in _paras)
                {
                    if (cp.check_operator == "s=")
                    {
                        t_cur_saleflow saleinfo = Gattr.Bll.GetItemInfo(cp.type_val);
                        saleinfo.sale_qnty = cp.throld;
                        saleinfo.sale_money = GetDecimal(saleinfo.unit_price * saleinfo.sale_qnty);
                        saleinfo.isYh = true;
                        saleinfo.plan_no = plan_no;
                        saleInfos.Add(saleinfo);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>GetSendSaleInfo>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return saleInfos;
        }
        
        
        
        
        
        public List<t_cur_saleflow> DearPGSaleInfo(List<t_cur_saleflow> saleInfo, string vip_type)
        {
            List<t_cur_saleflow> saleInfos = new List<t_cur_saleflow>();
            try
            {
                List<t_rm_plan_master> _planMasters = GetPlanPara("1", "PG", "", "", vip_type);
                if (_planMasters != null && _planMasters.Count > 0)
                {
                    List<decimal> flowIdList = new List<decimal>();
                    foreach (t_rm_plan_master _master in _planMasters)
                    {
                        PlanPara _para = _master.PlanPara;
                        //验证商品
                        List<CheckPara> paras = _para.CheckParas;
                        bool isok = true;
                        foreach (CheckPara _cp in paras)
                        {
                            #region 所有商品验证
                            bool isok1 = true;
                            List<t_cur_saleflow> sales = GetSaleInfoFromList(saleInfo, _cp.type_val);
                            if (sales.Count == 0)
                            {
                                isok1 = false;
                            }
                            else
                            {
                                decimal _amt = 0M;
                                foreach (t_cur_saleflow sale in sales)
                                {
                                    if (_cp.isAmt)
                                    {
                                        _amt += sale.sale_money;
                                    }
                                    else if (_cp.isQty)
                                    {
                                        _amt += sale.sale_qnty;
                                    }
                                }
                                switch (_cp.check_operator)
                                {
                                    case ">=":
                                    case "=":
                                        if (!(_amt >= _cp.throld))
                                        {
                                            isok1 = false;
                                        }
                                        break;
                                    case ">":
                                        if (!(_amt > _cp.throld))
                                        {
                                            isok1 = false;
                                        }
                                        break;
                                    case "<=":
                                        if (!(_amt <= _cp.throld))
                                        {
                                            isok1 = false;
                                        }
                                        break;
                                    case "<":
                                        if (!(_amt < _cp.throld))
                                        {
                                            isok1 = false;
                                        }
                                        break;
                                }
                                if (isok1 == false)
                                {
                                    isok = false;
                                    break;
                                }
                            }
                            #endregion
                        }
                        if (isok)
                        {
                            foreach (CheckPara _cp in _para.ResultParas)
                            {
                                #region 结果
                                List<t_cur_saleflow> sales = GetSaleInfoFromList(saleInfo, _cp.type_val);
                                foreach (t_cur_saleflow sale in sales)
                                {
                                    if (_cp.isAmt)
                                    {
                                        sale.unit_price = _cp.throld;
                                    }
                                    else if (_cp.isQty)
                                    {
                                        sale.sale_qnty = _cp.throld;
                                    }
                                    sale.sale_money = GetDecimal(sale.unit_price * sale.sale_qnty);
                                    saleInfos.Add(sale);
                                    sale.plan_no = _para.planNo;
                                    sale.isYh = true;
                                    if (!flowIdList.Contains(sale.flow_id))
                                    {
                                        flowIdList.Add(sale.flow_id);
                                    }
                                }
                                #endregion
                            }
                        }
                        foreach (t_cur_saleflow sale in saleInfo)
                        {
                            if (!flowIdList.Contains(sale.flow_id))
                            {
                                saleInfos.Add(sale);
                            }
                        }
                    }
                }
                else
                {
                    saleInfos.AddRange(saleInfo);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearPGSaleInfo>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return saleInfos;
        }
        #endregion
        #region 私有方法
        
        
        
        
        
        private List<t_cur_saleflow> DearDiscustSaleFlow(List<t_cur_saleflow> _saleFlow, string vip_type)
        {
            List<t_cur_saleflow> _saleInfo = new List<t_cur_saleflow>();
            try
            {
                List<t_rm_plan_master> _planPara = GetPlanPara("0", "", "", "'PG','PE','PS'",vip_type);
                _saleInfo = DearSaleFlow(_saleFlow, _planPara, vip_type);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearDisSaleFlow>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleInfo;
        }
        
        
        
        
        
        
        private bool CheckItems(PlanPara _para, List<t_cur_saleflow> _saleInfos)
        {
            bool isok = true;
            foreach (CheckPara _cp in _para.CheckParas)
            {
                bool isok1 = false;
                decimal _cpValue = 0M;
                switch (_cp.check_type)
                {
                    #region 获取判断的值
                    case "ITEM":
                        foreach (t_cur_saleflow sale in _saleInfos)
                        {
                            if (sale.item_no == _cp.type_val)
                            {
                                if (_cp.isAmt)
                                {
                                    _cpValue += sale.sale_money;
                                }
                                else if (_cp.isQty)
                                {
                                    _cpValue += sale.sale_qnty;
                                }
                            }
                        }
                        break;
                    case "BRAND":
                        foreach (t_cur_saleflow sale in _saleInfos)
                        {
                            if (sale.item_brand == _cp.type_val)
                            {
                                if (_cp.isAmt)
                                {
                                    _cpValue += sale.sale_money;
                                }
                                else if (_cp.isQty)
                                {
                                    _cpValue += sale.sale_qnty;
                                }
                            }
                        }
                        break;
                    case "CLS":
                        foreach (t_cur_saleflow sale in _saleInfos)
                        {
                            if (!string.IsNullOrEmpty(sale.item_clsno))
                            {
                                if (sale.item_clsno.StartsWith(_cp.type_val))
                                {
                                    if (_cp.isAmt)
                                    {
                                        _cpValue += sale.sale_money;
                                    }
                                    else if (_cp.isQty)
                                    {
                                        _cpValue += sale.sale_qnty;
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        foreach (t_cur_saleflow sale in _saleInfos)
                        {
                            if (_cp.isAmt)
                            {
                                _cpValue += sale.sale_money;
                            }
                            else if (_cp.isQty)
                            {
                                _cpValue += sale.sale_qnty;
                            }
                        }
                        break;
                    #endregion
                }
                switch (_cp.check_operator)
                {
                    case ">=":
                        if (_cpValue >= _cp.throld)
                        {
                            isok1 = true;
                        }
                        break;
                    case ">":
                        if (_cpValue > _cp.throld)
                        {
                            isok1 = true;
                        }
                        break;
                    case "<=":
                        if (_cpValue <= _cp.throld)
                        {
                            isok1 = true;
                        }
                        break;
                    case "<":
                        if (_cpValue < _cp.throld)
                        {
                            isok1 = true;
                        }
                        break;
                    case "=":
                        if (_cpValue == _cp.throld)
                        {
                            isok1 = true;
                        }
                        break;
                }
                if (isok1 == false)
                {
                    isok = false;
                    break;
                }
            }
            return isok;
        }
        
        
        
        
        
        private List<t_cur_saleflow> DearSaleFlow(List<t_cur_saleflow> _saleFlow, List<t_rm_plan_master> _planPara,string vip_type)
        {
            List<t_cur_saleflow> _saleInfo = new List<t_cur_saleflow>();
            try
            {
                if (_planPara != null && _planPara.Count > 0)
                {
                    List<string> itemNos = new List<string>();
                    foreach (t_cur_saleflow _saleflow in _saleFlow)
                    {
                        bool isok = false;
                        if (!itemNos.Contains(_saleflow.item_no))
                        {
                            foreach (t_rm_plan_master _master in _planPara)
                            {
                                PlanPara _plan = _master.PlanPara;
                                string item_no = string.Empty;
                                t_cur_saleflow _currentSale = _saleflow;
                                //检测商品是否符合促销方案
                                isok = CheckItem(_plan.CheckParas, _currentSale, _saleFlow);
                                if (isok)
                                {
                                    List<t_cur_saleflow> _saleinfos = GetResult(_plan, _currentSale, ref item_no, _saleFlow, _plan.planNo, vip_type);
                                    if (!string.IsNullOrEmpty(item_no))
                                    {
                                        itemNos.Add(item_no);
                                    }
                                    if (_saleinfos != null && _saleinfos.Count > 0)
                                    {
                                        //会员登录之后，促销政策显示单价按原价显示的逻辑
                                        /*if (_master.range_flag == "A" && vip_type != "ALL")
                                        {
                                            for (int i = 0; i < _saleinfos.Count; i++)
                                            {
                                                _saleinfos[i].sale_money = _saleinfos[i].sale_price * _saleinfos[i].sale_qnty;
                                            }
                                        }*/
                                         _saleInfo.AddRange(_saleinfos);
                                    }
                                    break;
                                }
                            }
                            if (!isok)
                            {
                                _saleInfo.Add(_saleflow);
                            }
                        }
                    }
                }
                else
                {
                    _saleInfo.AddRange(_saleFlow);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearDisSaleFlow>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleInfo;
        }
        
        
        
        
        
        
        
        private bool CheckItem(List<CheckPara> _checkParas, t_cur_saleflow _saleInfo, List<t_cur_saleflow> _oldSales)
        {
            bool isok = false;
            try
            {
                if (_checkParas == null)
                {
                    isok = true;
                }
                else
                {
                    if (_checkParas.Count == 0)
                    {
                        isok = true;
                    }
                    else
                    {
                        foreach (CheckPara _para in _checkParas)
                        {
                            bool _isok = CheckTypeinfo(_para.check_type, _para.type_val, _saleInfo);
                            if (!string.IsNullOrEmpty(_para.check_operator))
                            {
                                if (_isok)
                                {
                                    
                                    isok = CheckCondtionInfo(_para, _saleInfo, _oldSales);
                                    if (!isok)
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                isok = _isok;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>CheckItem>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        
        //检测商品是否符合条件
        private bool CheckCondtionInfo(CheckPara _para, t_cur_saleflow _saleInfo, List<t_cur_saleflow> _oldSales)
        {
            bool isok = false;
            try
            {
                string check_operator = _para.check_operator.Trim();
                decimal check_val = 0M;
                switch (_para.check_type)
                {
                    case "ALL":
                        #region 全场
                        foreach (t_cur_saleflow _sale in _oldSales)
                        {
                            if (_para.isAmt)
                            {
                                check_val += _sale.sale_money;
                            }
                            else if (_para.isQty)
                            {
                                check_val += _sale.sale_qnty;
                            }
                        }
                        #endregion
                        break;
                    case "CLS":
                        #region 分类
                        foreach (t_cur_saleflow _sale in _oldSales)
                        {
                            if (_sale.item_clsno.StartsWith(_para.type_val))
                            {
                                if (_para.isAmt)
                                {
                                    check_val += _sale.sale_money;
                                }
                                else if (_para.isQty)
                                {
                                    check_val += _sale.sale_qnty;
                                }
                            }
                        }
                        #endregion
                        break;
                    case "BRAND":
                        #region 品牌
                        foreach (t_cur_saleflow _sale in _oldSales)
                        {
                            if (_sale.item_brand == _para.type_val)
                            {
                                if (_para.isAmt)
                                {
                                    check_val += _sale.sale_money;
                                }
                                else if (_para.isQty)
                                {
                                    check_val += _sale.sale_qnty;
                                }
                            }
                        }
                        #endregion
                        break;
                    case "ITEM":
                        #region 具体商品的信息
                        foreach (t_cur_saleflow _sale in _oldSales)
                        {
                            if (_sale.item_no == _para.type_val)
                            {
                                if (_para.isAmt)
                                {
                                    check_val += _sale.sale_money;
                                }
                                else if (_para.isQty)
                                {
                                    check_val += _sale.sale_qnty;
                                }
                            }
                        }
                        #endregion
                        break;
                }
                switch (check_operator)
                {
                    case ">=":
                        if (check_val >= _para.throld)
                        {
                            isok = true;
                        }
                        break;
                    case ">":
                        if (check_val > _para.throld)
                        {
                            isok = true;
                        }
                        break;
                    case "<":
                        if (check_val < _para.throld)
                        {
                            isok = true;
                        }
                        break;
                    case "<=":
                        if (!(_para.throld < 0))
                        {
                            isok = true;
                        }
                        break;
                    case "=":
                        if (check_val == _para.throld)
                        {
                            isok = true;
                        }
                        break;
                    case "%":
                        isok = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>CheckCondtionInfo>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        
        //检测商品编码 分类 品牌是否符合条件
        private bool CheckTypeinfo(string type_no, string type_val, t_cur_saleflow saleinfo)
        {
            bool isok = false;
            try
            {
                if (type_no == "ALL")
                {
                    isok = true;
                }
                else
                {
                    if (type_no == "ITEM")
                    {
                        if (type_val == saleinfo.item_no)
                        {
                            isok = true;
                        }
                    }
                    else
                    {
                        if (type_no == "BRAND")
                        {
                            if (type_val == saleinfo.item_brand)
                            {
                                isok = true;
                            }
                        }
                        else if (type_no == "CLS")
                        {
                            if (type_val == saleinfo.item_clsno)
                            {
                                isok = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>CheckTypeinfo>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        
        
        
        private List<t_cur_saleflow> GetResult(PlanPara _resultParas, t_cur_saleflow _saleInfo, ref string item_no, List<t_cur_saleflow> _oldSales, string plan_no, string vip_type)
        {
            List<t_cur_saleflow> _saleInfos = new List<t_cur_saleflow>();
            try
            {
                bool isSend = false;
                bool isOdd = false;
                t_cur_saleflow tempSaleInfo = Gattr.Bll.GetItemInfo(_saleInfo.item_no);
                foreach (CheckPara _para in _resultParas.ResultParas)
                {
                    t_cur_saleflow _currentSaleInfo = _saleInfo.clone() as t_cur_saleflow;
                    switch (_para.check_operator)
                    {
                        case "+":
                            if (_para.isAmt)
                            {
                                _currentSaleInfo.unit_price = GetDecimal(tempSaleInfo.unit_price + _para.throld);
                            }
                            else if (_para.isQty)
                            {
                                _currentSaleInfo.sale_qnty = GetDecimal(_currentSaleInfo.sale_qnty + _para.throld);
                            }
                            break;
                        case "-":
                            if (_para.isAmt)
                            {
                                _currentSaleInfo.unit_price = GetDecimal(tempSaleInfo.unit_price - _para.throld);
                            }
                            else if (_para.isQty)
                            {
                                _currentSaleInfo.sale_qnty = GetDecimal(_currentSaleInfo.sale_qnty - _para.throld);
                            }
                            break;
                        case "*":
                            if (_para.isAmt)
                            {
                                _currentSaleInfo.unit_price = GetDecimal(tempSaleInfo.unit_price * _para.throld);
                            }
                            else if (_para.isQty)
                            {
                                _currentSaleInfo.sale_qnty = GetDecimal(_currentSaleInfo.sale_qnty * _para.throld);
                            }
                            break;
                        case "/":
                            if (_para.isAmt)
                            {
                                if (_para.throld > 0)
                                {
                                    _currentSaleInfo.unit_price = GetDecimal(tempSaleInfo.unit_price / _para.throld);
                                }
                            }
                            else if (_para.isQty)
                            {
                                if (_para.throld > 0)
                                {
                                    _currentSaleInfo.sale_qnty = GetDecimal(_currentSaleInfo.sale_qnty / _para.throld);
                                }
                            }
                            break;
                        case "*-"://倍数减
                            break;
                        case "s="://赠送
                            isSend = true;//需要添加之前的商品
                            _currentSaleInfo = Gattr.Bll.GetItemInfo(_para.type_val);//获取赠送商品的信息
                            _currentSaleInfo.sale_qnty = _para.throld;//设置赠送数量
                            break;
                        case "=":
                            if (_resultParas.AddPara != null && _resultParas.AddPara.Count > 0)
                            {
                                isOdd = true;
                                item_no = _currentSaleInfo.item_no;
                                List<t_cur_saleflow> _newSaleInfos1 = GetSaleInfoFromList(_oldSales, _currentSaleInfo.item_no);
                                //偶数特价，获取之前特价的数量，获取可以特价的数量，然后新增特价的数量或者减掉特价的数量，其他的都为正常价格
                                _saleInfos = DearLimitInfo(_newSaleInfos1, _resultParas.AddPara[0].throld, _resultParas.planNo, _resultParas.ResultParas[0].throld, vip_type);
                            }
                            else
                            {
                                if (_para.isAmt)
                                {
                                    _currentSaleInfo.unit_price = GetDecimal(_para.throld);
                                }
                                else if (_para.isQty)
                                {
                                    _currentSaleInfo.sale_qnty = GetDecimal(_para.throld);
                                }
                            }
                            break;
                        case "/%"://偶数商品
                            isOdd = true;
                            item_no = _currentSaleInfo.item_no;
                            List<t_cur_saleflow> _newSaleInfos = GetSaleInfoFromList(_oldSales, _currentSaleInfo.item_no);
                            //偶数特价，获取之前特价的数量，获取可以特价的数量，然后新增特价的数量或者减掉特价的数量，其他的都为正常价格
                            _saleInfos = DearOddInfo(_newSaleInfos, _para.throld, plan_no, vip_type);
                            break;
                    }
                    if (!isOdd)
                    {
                        _currentSaleInfo.sale_money = GetDecimal(_currentSaleInfo.unit_price * _currentSaleInfo.sale_qnty); ;//设置赠送数量
                        _currentSaleInfo.plan_no = plan_no;
                        _currentSaleInfo.isYh = true;
                        _saleInfos.Add(_currentSaleInfo);
                    }
                }
                if (isSend)
                {
                    _saleInfo.isYh = true;
                    _saleInfo.plan_no = plan_no;
                    _saleInfos.Add(_saleInfo);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>GetResult>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleInfos;
        }
        
        
        
        
        
        private List<t_cur_saleflow> DearOddInfo(List<t_cur_saleflow> oddSales, decimal price, string plan_no, string vip_type)
        {
            List<t_cur_saleflow> _saleInfos = new List<t_cur_saleflow>();
            t_cur_saleflow _evenSaleInfo = new t_cur_saleflow();
            string item_no = oddSales[0].item_no;
            t_cur_saleflow emptyInfo = Gattr.Bll.GetItemInfo(item_no);
            List<t_cur_saleflow> _sales = new List<t_cur_saleflow>();
            List<t_cur_saleflow> _sales1 = new List<t_cur_saleflow>();
            int sum_amt = 0;
            foreach (t_cur_saleflow _curSaleflow in oddSales)
            {
                if (_curSaleflow.unit_price == price)
                {
                    _sales.Add(_curSaleflow);//获取所有特价的商品，需要将特价的商品组合
                }
                else
                {
                    _sales1.Add(_curSaleflow);
                }
                sum_amt = sum_amt + decimal.ToInt32(_curSaleflow.sale_qnty);//获取总数量
            }
            int even_amt = 0;
            foreach (t_cur_saleflow _saleInfo in _sales)
            {
                even_amt += ExtendUtility.Instance.ParseToInt32(_saleInfo.sale_qnty);
            }
            int real_even = ExtendUtility.Instance.ParseToInt32(sum_amt / 2);
            #region 处理特价
            if (_sales.Count > 0)
            {
                _evenSaleInfo = _sales[0];
            }
            else
            {
                _evenSaleInfo = emptyInfo;
            }
            _evenSaleInfo.isYh = true;
            _evenSaleInfo.plan_no = plan_no;
            _evenSaleInfo.unit_price = price;
            _evenSaleInfo.sale_qnty = real_even;
            _evenSaleInfo.sale_money = GetDecimal(_evenSaleInfo.unit_price * _evenSaleInfo.sale_qnty);
            if (_evenSaleInfo.sale_qnty > 0)
            {
                _saleInfos.Add(_evenSaleInfo);
            }
            #endregion
            #region 处理非特价
            int real_odd = sum_amt - real_even;//特价
            decimal price1 = Gattr.Bll.GetItemInfo(item_no).unit_price;
            if (_sales1.Count == 0)
            {
                t_cur_saleflow _oddSale = _evenSaleInfo;
                _oddSale.sale_qnty = real_odd;
                _oddSale.unit_price = price1;
                _oddSale.sale_money = GetDecimal(_oddSale.unit_price * _oddSale.sale_qnty);
                _saleInfos.Add(_oddSale);
            }
            else if (_sales1.Count == 1)
            {
                t_cur_saleflow _oddSale = _sales1[0];
                _oddSale.sale_qnty = real_odd;
                _oddSale.unit_price = price1;
                _oddSale.sale_money = GetDecimal(_oddSale.unit_price * _oddSale.sale_qnty);
                _saleInfos.Add(_oddSale);
            }
            else
            {



                int sum1 = 0;
                //int k = GetPriceIndex(_sales1, price1);
                int k = CommonUtility.Instance.GetFieldIndex<t_cur_saleflow>(_saleInfos, "unit_price", price1);
                if (k == -1)
                {
                    k = 0;
                }
                for (int index = 0; index < _sales1.Count; index++)
                {
                    if (index != k)
                    {
                        //_sales1[index].isYh = true;
                        sum1 += ExtendUtility.Instance.ParseToInt32(_sales1[index].sale_qnty);
                    }
                }
                _sales1[k].sale_qnty = real_odd - sum1;
                //_sales1[k].isYh = true;
                _sales1[k].sale_money = GetDecimal(_sales1[k].unit_price * _sales1[k].sale_qnty);
                for (int index = 0; index < _sales1.Count; index++)
                {
                    if (_sales1[index].sale_qnty > 0)
                    {
                        List<t_cur_saleflow> _saleInfoList = new List<t_cur_saleflow>();
                        _saleInfoList.Add(_sales1[index]);
                        List<t_cur_saleflow> _saleInfoList1 = DearDiscustSaleFlow(_saleInfoList, vip_type);
                        if (_saleInfoList1 != null && _saleInfoList1.Count > 0)
                        {
                            _saleInfos.AddRange(_saleInfoList1);
                        }
                        //_saleInfos.Add(_sales1[index]);
                    }
                }
            }
            #endregion
            return _saleInfos;
        }
        
        
        
        
        
        
        
        private List<t_cur_saleflow> DearLimitInfo(List<t_cur_saleflow> limitSales, decimal qty, string plan_no, decimal price, string vip_type)
        {
            List<t_cur_saleflow> _limitSales = new List<t_cur_saleflow>();
            try
            {
                decimal sumQty = 0M;
                foreach (t_cur_saleflow sale in limitSales)
                {
                    sumQty += sale.sale_qnty;
                }
                if (sumQty <= qty)
                {
                    decimal num = 9999;
                    foreach (t_cur_saleflow sale in limitSales)
                    {
                        t_cur_saleflow sale1 = sale;
                        sale1.flow_id = num;
                        sale1.unit_price = GetDecimal(price);
                        sale1.sale_money = GetDecimal(sale1.unit_price * sale1.sale_qnty);
                        sale1.plan_no = plan_no;
                        sale1.isYh = true;
                        _limitSales.Add(sale1);
                        num++;
                    }
                }
                else
                {
                    t_cur_saleflow sale2 = limitSales[0];
                    sale2.sale_qnty = qty;
                    sale2.unit_price = price;
                    sale2.sale_money = GetDecimal(sale2.sale_qnty * sale2.unit_price);
                    sale2.plan_no = plan_no;
                    sale2.isYh = true;
                    _limitSales.Add(sale2);
                    t_cur_saleflow sale3 = Gattr.Bll.GetItemInfo(limitSales[0].item_no);
                    sale3.sale_qnty = GetDecimal(sumQty - qty);
                    sale3.sale_money = GetDecimal(sale3.sale_qnty * sale3.unit_price);
                    List<t_cur_saleflow> _saleInfoList = new List<t_cur_saleflow>();
                    _saleInfoList.Add(sale3);
                    List<t_cur_saleflow> _saleInfoList1 = DearDiscustSaleFlow(_saleInfoList, vip_type);
                    if (_saleInfoList1 != null && _saleInfoList1.Count > 0)
                    {
                        _limitSales.AddRange(_saleInfoList1);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearLimitInfo>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _limitSales;
        }
        
        
        
        
        
        
        private List<t_cur_saleflow> GetSaleInfoFromList(List<t_cur_saleflow> oldSales, string item_no)
        {
            List<t_cur_saleflow> _saleInfos = new List<t_cur_saleflow>();
            try
            {
                foreach (t_cur_saleflow _sale in oldSales)
                {
                    if (_sale.item_no == item_no)
                    {
                        _saleInfos.Add(_sale);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>GetSaleInfoFromList>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleInfos;
        }
        
        
        
        
        
        
        private List<t_cur_saleflow> GetSaleInfoFromList(List<t_cur_saleflow> oldSales, decimal price, int mark)
        {
            List<t_cur_saleflow> _saleInfos = new List<t_cur_saleflow>();
            try
            {
                foreach (t_cur_saleflow _sale in oldSales)
                {
                    if (mark == 0)
                    {
                        if (_sale.unit_price.Equals(price))
                        {
                            _saleInfos.Add(_sale);
                        }
                    }
                    else
                    {
                        if (!_sale.unit_price.Equals(price))
                        {
                            _saleInfos.Add(_sale);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>GetSaleInfoFromList>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleInfos;
        }
        
        
        
        
        
        private decimal GetDecimal(object obj)
        {
            return ExtendUtility.Instance.ParseToDecimal(ExtendUtility.Instance.ParseToDecimal(obj).ToString("N4"));
        }
        
        
        
        
        
        
        
        
        private List<t_rm_plan_master> GetPlanPara(string plu_flag, string rule_no, string plan_no, string rrule_no, string vip_type)
        {
            List<t_rm_plan_master> _planMasters = new List<t_rm_plan_master>();
            try
            {
                DataTable table = Gattr.Bll.GetPlanMaster(plu_flag, rule_no, plan_no, rrule_no, vip_type);
                for (int k = 0; k < table.Rows.Count;k++ )
                {
                    DataRow row = table.Rows[k];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (row["rule_no"].ToString() == table.Rows[i]["rule_no"].ToString() && row["range_flag"].ToString() == table.Rows[i]["range_flag"].ToString() && row["vip_type"].ToString() != table.Rows[i]["vip_type"].ToString())
                        {
                            if (row["vip_type"].ToString() == "ALL")
                            {
                                table.Rows.Remove(row);//清除此类的行
                                break;
                            }
                        }
                    }
                }

                DataTable tableDetails = Gattr.Bll.GetPlanDetail(table);
                if (tableDetails != null && tableDetails.Rows.Count > 0)
                {
                    List<decimal> flowIdList = new List<decimal>();
                    //foreach (DataRow dr in tableDetails.Rows)
                    string plan_no2 = string.Empty;//活动编号，用来区分每个活动的1对N特惠
                    int k = 0;//1对N 循环标记
                    for (int i = 0; i < tableDetails.Rows.Count; i++)
                    {
                        DataRow dr = tableDetails.Rows[i];
                        string plan_no1 = ExtendUtility.Instance.ParseToString(dr["plan_no"]);
                        string rule_no1 = ExtendUtility.Instance.ParseToString(dr["rule_no"]);
                        string range_flag1 = ExtendUtility.Instance.ParseToString(dr["range_flag"]);
                        PlanRule rule = Gattr.Bll.GetPlanRuleInfo(rule_no1, range_flag1);
                        DataTable _detail = Gattr.Bll.GetPlanDetailByPlanNo(plan_no1);
                        /*根据每条促销的详细信息获取促销的规则参数*/
                        if (plan_no2 != plan_no1) k = 0; else k++;
                        PlanPara _para = DearPlanDataTable(_detail, rule,k);
                        /*----------------------------------------*/
                        int index = CommonUtility.Instance.GetFieldIndex<t_rm_plan_master>(_planMasters, "plan_no", plan_no1);
                        if (index == -1)
                        {
                            t_rm_plan_master _master = new t_rm_plan_master();
                            _master.plan_no = plan_no;
                            _master.rule_no = rule_no;
                            _master.rule_result = rule.rule_result;
                            _master.rule_condition = rule.rule_result;
                            _master.range_flag = rule.range_flag;
                            _master.rule_describe = ExtendUtility.Instance.ParseToString(dr["rule_describe"]);
                            _master.rule_desc = ExtendUtility.Instance.ParseToString(dr["rule_desc"]);
                            _master.PlanPara = _para;
                            _master.isSelect = false;
                            _planMasters.Add(_master);
                        }

                        plan_no2 = plan_no1;
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDealer--->>GetPlanPara>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _planMasters;
        }
        
        
        
        
        
        
        
        private PlanPara DearPlanDataTable(DataTable table, PlanRule rule,int i)
        {
            PlanPara _listPara = new PlanPara();
            try
            {
                if (table != null && table.Rows.Count > 0)
                {
                    _listPara.PlanRule = rule;
                    if (rule.rule_no == "PG" && rule.range_flag == "I")
                    {
                        //组合商品需要都进行判断
                        if (table != null && table.Rows.Count > 0)
                        {
                            PlanPara _planPara = new PlanPara();
                            _planPara.row_id = "0";//使用默认0的取值
                            _planPara.planNo = ExtendUtility.Instance.ParseToString(table.Rows[0]["plan_no"]);
                            _planPara.CheckParas = new List<CheckPara>();
                            _planPara.CheckParas.Clear();
                            _planPara.ResultParas = new List<CheckPara>();
                            _planPara.ResultParas.Clear();
                            _planPara.typeNo = "ITEM";
                            string condtionZH = rule.rule_condition;
                            string resultZH = rule.rule_result;
                            #region 准备条件验证参数
                            Dictionary<int, object> _dicRowIds = CommonUtility.Instance.GetDistinctValue(table, "row_id");
                            if (_dicRowIds.Count > 0)
                            {
                                string row_id = ExtendUtility.Instance.ParseToString(_dicRowIds[i]);
                                DataRow[] drIds = table.Select("row_id='" + row_id + "'");
                                if (drIds != null && drIds.Length > 0)
                                {
                                    DataTable table11 = CommonUtility.Instance.DataRowToDataTable(drIds);
                                    string _row_id = ExtendUtility.Instance.ParseToString(drIds[0]["row_id"]);
                                    CheckPara _cp = new CheckPara();
                                    CheckPara _resultCp = new CheckPara();
                                    _cp.check_type = "ITEM";
                                    _resultCp.check_type = "ITEM";
                                    _cp.check_operator = "=";
                                    _resultCp.check_operator = "=";
                                    if (!string.IsNullOrEmpty(condtionZH) && condtionZH.Contains("AMT"))
                                    {
                                        _cp.isAmt = true;
                                    }
                                    else
                                    {
                                        _cp.isQty = true;
                                    }
                                    if (!string.IsNullOrEmpty(resultZH) && resultZH.Contains("AMT"))
                                    {
                                        _resultCp.isAmt = true;
                                    }
                                    else
                                    {
                                        _resultCp.isQty = true;
                                    }
                                    string typeField = _cp.check_type + _row_id;
                                    DataRow[] drTypeVal = table11.Select("rule_para='" + typeField + "'");
                                    if (drTypeVal != null && drTypeVal.Length > 0)
                                    {
                                        _cp.type_val = ExtendUtility.Instance.ParseToString(drTypeVal[0]["rule_val"]);//获取具体商品编号
                                        _resultCp.type_val = ExtendUtility.Instance.ParseToString(drTypeVal[0]["rule_val"]);//获取具体商品编号
                                    }
                                    string throldField = "T" + _row_id;
                                    DataRow[] drThrold = table11.Select("rule_para='" + throldField + "'");
                                    if (drThrold != null && drThrold.Length > 0)
                                    {
                                        _cp.throld = ExtendUtility.Instance.ParseToDecimal(drThrold[0]["rule_val"]);//获取具体商品编号
                                    }
                                    string priceField = "R" + _row_id;
                                    DataRow[] drPrice = table11.Select("rule_para='" + priceField + "'");
                                    if (drPrice != null && drPrice.Length > 0)
                                    {
                                        _resultCp.throld = ExtendUtility.Instance.ParseToDecimal(drPrice[0]["rule_val"]);//获取具体商品编号
                                    }
                                    _planPara.CheckParas.Add(_cp);
                                    _planPara.ResultParas.Add(_resultCp);
                                    _listPara = _planPara;
                                }
                            }
                            #endregion
                        }
                    }
                    else
                    {
                        Dictionary<int, object> _dicRowIds = CommonUtility.Instance.GetDistinctValue(table, "row_id");
                        if (_dicRowIds.Count > 0)
                        {
                            string row_id = ExtendUtility.Instance.ParseToString(_dicRowIds[i]);
                            DataRow[] drIds = table.Select("row_id='" + row_id + "'");

                            #region 非组合商品
                            if (drIds != null && drIds.Length > 0)
                            {
                                DataTable table11 = CommonUtility.Instance.DataRowToDataTable(drIds);
                                PlanPara _planPara = new PlanPara();
                                _planPara.row_id = ExtendUtility.Instance.ParseToString(drIds[0]["row_id"]);
                                _planPara.planNo = ExtendUtility.Instance.ParseToString(drIds[0]["plan_no"]);
                                string rule_condtion = ExtendUtility.Instance.ParseToString(rule.rule_condition);
                                string result = rule.rule_result;
                                string result1 = rule_condtion + result;
                                if (!string.IsNullOrEmpty(result1) && result1.Contains("ALL"))
                                {
                                    _planPara.typeNo = "ALL";
                                }
                                if (!string.IsNullOrEmpty(result1) && result1.Contains("BRAND1"))
                                {
                                    _planPara.typeNo = "BRAND";
                                }
                                if (!string.IsNullOrEmpty(result1) && result1.Contains("CLS1"))
                                {
                                    _planPara.typeNo = "CLS";
                                }
                                if (!string.IsNullOrEmpty(result1) && result1.Contains("ITEM1"))
                                {
                                    _planPara.typeNo = "ITEM";
                                }
                                if (!string.IsNullOrEmpty(rule_condtion) && rule_condtion.Contains("TN"))
                                {
                                    _planPara.isN = true;
                                }
                                List<CheckPara> _checkPara = new List<CheckPara>();
                                List<CheckPara> _addPara = new List<CheckPara>();
                                if (!string.IsNullOrEmpty(_planPara.typeNo))
                                {
                                    string[] rules = rule_condtion.Split('&');
                                    foreach (string _rule in rules)
                                    {
                                        #region 单个条件
                                        CheckPara _para = new CheckPara();
                                        _para.check_type = _planPara.typeNo;
                                        bool isAdd = false;
                                        bool isAdd1 = false;
                                        if (_para.check_type != "ALL")
                                        {
                                            string typeField = _para.check_type.Trim() + "1";
                                            DataRow[] drTypeValue = table11.Select("rule_para='" + typeField + "'");
                                            if (drTypeValue != null && drTypeValue.Length > 0)
                                            {
                                                _para.type_val = ExtendUtility.Instance.ParseToString(drTypeValue[0]["rule_val"]);
                                                _planPara.typeValue = _para.type_val;
                                            }
                                        }
                                        if (_rule.Contains("AMT"))
                                        {
                                            _para.isAmt = true;
                                        }
                                        else
                                        {
                                            if (_rule.Contains("ADD"))
                                            {
                                                _para.isAmt = true;
                                            }
                                            else
                                            {
                                                _para.isQty = true;
                                            }
                                        }
                                        bool isGet = true;
                                        if (rule_condtion == string.Empty)
                                        {

                                        }
                                        else
                                        {
                                            string condtion = rule_condtion;
                                            string replace = "";
                                            if (_rule.Contains("ADD"))
                                            {
                                                _para.check_operator = "+";
                                                replace = "ADD";
                                                isAdd = true;

                                            }
                                            if (string.IsNullOrEmpty(_para.check_operator) && _rule.Contains(">="))
                                            {
                                                _para.check_operator = ">=";
                                            }
                                            if (string.IsNullOrEmpty(_para.check_operator) && _rule.Contains(">"))
                                            {
                                                _para.check_operator = ">";
                                            }
                                            if (string.IsNullOrEmpty(_para.check_operator) && _rule.Contains("<="))
                                            {
                                                _para.check_operator = "<=";
                                            }
                                            if (string.IsNullOrEmpty(_para.check_operator) && _rule.Contains("<"))
                                            {
                                                _para.check_operator = "<";
                                            }
                                            if (string.IsNullOrEmpty(_para.check_operator) && _rule.Contains("LIMIT"))
                                            {
                                                _para.check_operator = "<=";
                                                replace = "LIMIT";
                                                isAdd1 = true;
                                            }
                                            if (string.IsNullOrEmpty(_para.check_operator) && _rule.Contains("="))
                                            {
                                                _para.check_operator = "=";
                                            }
                                            if (string.IsNullOrEmpty(_para.check_operator) && _rule.Contains("DOUBLE"))
                                            {
                                                _para.check_operator = "%";
                                                _para.throld = 2;
                                                isGet = false;//共有总量/2个可以特价的商品，其他均不能特价
                                            }
                                            if (isGet)
                                            {
                                                string valField = string.Empty;
                                                if (!string.IsNullOrEmpty(replace))
                                                {
                                                    valField = _rule.Replace(replace, "").Trim();
                                                }
                                                else
                                                {
                                                    int num = _rule.IndexOf(_para.check_operator);
                                                    valField = _rule.Substring(num + 2).Trim();
                                                }
                                                DataRow[] drFields = table11.Select("rule_para='" + valField + "'");
                                                if (drFields != null && drFields.Length > 0)
                                                {
                                                    _para.throld = ExtendUtility.Instance.ParseToDecimal(drFields[0]["rule_val"]);
                                                }
                                                if (result == "Send R1")
                                                {
                                                    isAdd1 = true;
                                                    //_para.check_operator = "*-";
                                                }
                                                else if (result == "Reduce R1")
                                                {
                                                    isAdd1 = true;
                                                    //_para.check_operator = "-";
                                                }
                                            }
                                        }
                                        if (isAdd1)
                                        {
                                            _addPara.Add(_para);
                                        }

                                        if (!isAdd)
                                        {
                                            _checkPara.Add(_para);
                                        }
                                        else
                                        {
                                            _addPara.Add(_para);
                                        }
                                        #endregion
                                    }
                                    _planPara.CheckParas = _checkPara;
                                }
                                //bool _isAdd = false;
                                List<CheckPara> _resultPara = new List<CheckPara>();
                                if (rule.rule_result.Contains("RN"))
                                {
                                    #region 多个计算
                                    string _checktype = "";
                                    if (result.Contains("BARCODE"))
                                    {
                                        _checktype = "BARCODE";
                                    }
                                    if (result.Contains("ITEM"))
                                    {
                                        _checktype = "ITEM";
                                    }
                                    DataRow[] drTypes = table.Select("rule_para like '" + _checktype + "%'");
                                    if (drTypes != null && drTypes.Length > 0)
                                    {
                                        foreach (DataRow drTN in drTypes)
                                        {
                                            string cts = ExtendUtility.Instance.ParseToString(drTN["rule_para"]).Trim();
                                            string id = cts.Replace(_checktype, "").Trim();
                                            string keyValue = "R" + id;
                                            DataRow[] drValue = table11.Select("rule_para = '" + keyValue + "'");
                                            if (drValue != null && drValue.Length > 0)
                                            {
                                                CheckPara _res = new CheckPara();
                                                if (result.Contains("QTY"))
                                                {
                                                    _res.isQty = true;
                                                }
                                                else
                                                {
                                                    _res.isAmt = true;
                                                }
                                                _res.check_type = _checktype;
                                                _res.check_operator = "s=";
                                                _res.type_val = ExtendUtility.Instance.ParseToString(drTN["rule_val"]).Trim();
                                                _res.throld = ExtendUtility.Instance.ParseToDecimal(drValue[0]["rule_val"]);
                                                _resultPara.Add(_res);
                                            }
                                        }
                                    }
                                    #endregion
                                }
                                else
                                {
                                    #region 只有一个计算
                                    CheckPara _res = new CheckPara();
                                    if (!string.IsNullOrEmpty(result1) && result1.Contains("ALL"))
                                    {
                                        _res.check_type = "ALL";
                                    }
                                    if (!string.IsNullOrEmpty(result1) && result1.Contains("BRAND1"))
                                    {
                                        _res.check_type = "BRAND";
                                    }
                                    if (!string.IsNullOrEmpty(result1) && result1.Contains("CLS1"))
                                    {
                                        _res.check_type = "CLS";
                                    }
                                    if (!string.IsNullOrEmpty(result1) && result1.Contains("ITEM1"))
                                    {
                                        _res.check_type = "ITEM";
                                    }
                                    if (_res.check_type != "ALL")
                                    {
                                        string typeField = _res.check_type.Trim() + "1";
                                        DataRow[] drTypeValue = table11.Select("rule_para='" + typeField + "'");
                                        if (drTypeValue != null && drTypeValue.Length > 0)
                                        {
                                            _res.type_val = ExtendUtility.Instance.ParseToString(drTypeValue[0]["rule_val"]);
                                            _planPara.typeValue = _res.type_val;
                                        }
                                    }
                                    if (result.Contains("QTY"))
                                    {
                                        _res.isQty = true;
                                    }
                                    else
                                    {
                                        _res.isAmt = true;
                                    }
                                    if (result.Contains("Reduce") || result.Contains("Send"))
                                    {
                                        _res.check_operator = "-";
                                        if (result.Contains("Send"))
                                        {
                                            _res.check_operator = "*-";
                                        }
                                        string keyField = string.Empty;
                                        keyField = result.Replace("Send", "").Replace("Reduce", "").Trim();
                                        DataRow[] drFields = table11.Select("rule_para='" + keyField + "'");
                                        if (drFields != null && drFields.Length > 0)
                                        {
                                            _res.throld = ExtendUtility.Instance.ParseToDecimal(drFields[0]["rule_val"]);
                                        }
                                    }
                                    else
                                    {
                                        int numEq = result.IndexOf('=');
                                        string keyFiled = string.Empty;
                                        if (!string.IsNullOrEmpty(rule_condtion) && rule_condtion.Contains("DOUBLE"))
                                        {
                                            _res.check_operator = "/%";
                                            keyFiled = result.Substring(numEq + 1).Trim();
                                        }
                                        else
                                        {
                                            if (result.Contains("+"))
                                            {
                                                _res.check_operator = "+";
                                            }
                                            if (result.Contains("-"))
                                            {
                                                _res.check_operator = "-";
                                            }
                                            if (result.Contains("*"))
                                            {
                                                _res.check_operator = "*";
                                            }
                                            if (result.Contains("/"))
                                            {
                                                _res.check_operator = "/";
                                            }

                                            int position = result.IndexOf(_res.check_operator);
                                            if (position > 1)
                                            {
                                                keyFiled = result.Substring(numEq + 1, position - 1 - (numEq + 1)).Trim();
                                            }
                                            else
                                            {
                                                _res.check_operator = "=";
                                                keyFiled = result.Substring(numEq + 1).Trim();
                                            }
                                        }
                                        DataRow[] drFields = table11.Select("rule_para='" + keyFiled + "'");
                                        if (drFields != null && drFields.Length > 0)
                                        {
                                            _res.throld = ExtendUtility.Instance.ParseToDecimal(drFields[0]["rule_val"]);
                                        }
                                    }
                                    _resultPara.Add(_res);
                                    #endregion
                                }
                                _planPara.AddPara = _addPara;
                                _planPara.ResultParas = _resultPara;
                                _listPara = _planPara;
                            }
                            #endregion
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PlanDear--->>DearPlanDataTable>>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _listPara;
        }
        #endregion
    }
}
