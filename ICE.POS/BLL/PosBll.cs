namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Text;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    
    public class PosBll : BllBase
    {
        
        public List<string> AccountReportFromServer(string storeNo, string posId, string cashierId, DateTime dtFrom, DateTime dtTo, int intPrintLen)
        {
            List<string> list3;
            List<string> list = new List<string>();
            try
            {
                string str = "";
                string str2 = string.Empty;
                string str3 = string.Empty;
                int num = 0;
                int result = 0;
                int num3 = 0;
                int num4 = 0;
                decimal num5 = 0M;
                decimal num6 = 0M;
                decimal num7 = 0M;
                string branchNo = Gattr.BranchNo;//storeNo.Substring(0, 4);
                DataSet set = new DataSet();
                set = base._dal.GetPayCash(branchNo, cashierId, dtFrom, dtTo);
                if (set != null)
                {
                    DataTable table = set.Tables["t_rm_cashier_info"];
                    if (((table == null) || (table.Rows.Count == 0)) || (Convert.ToInt32(table.Rows[0][0]) == 0))
                    {
                        list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                        list.Add(Gfunc.PrintStrAlign("收银对帐 ", intPrintLen, TextAlign.Center));
                        str = "";
                        list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                        list.Add("收银员(" + cashierId + ")今天无收付款记录. ");
                        return list;
                    }
                    List<t_operator> cashierInfo = base._dal.GetOperatorInfo(Gattr.OperId, Gattr.BranchNo);
                    list.Add("");
                    list.Add(Gfunc.PrintStrAlign("   收银对帐单   ", intPrintLen, TextAlign.Center));
                    list.Add(Gfunc.PrintStrAlign("================", intPrintLen, TextAlign.Center));
                    str = "";
                    list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                    list.Add("  机构: " + base._dal.GetBranchName(branchNo));
                    //list.Add("  仓库: " + base._dal.GetBranchName(storeNo));
                    list.Add("  收银机号: " + posId);
                    list.Add("  收 银 员: [" + cashierId.Trim() + "] " + cashierInfo[0].oper_name.Trim());
                    list.Add("  对账日期: " + DateTime.Today.ToString("yyyy-MM-dd"));
                    list.Add("  首笔: " + Convert.ToDateTime(table.Rows[0][1]).ToString("s"));
                    list.Add("  末笔: " + Convert.ToDateTime(table.Rows[0][2]).ToString("s"));
                    list.Add("  笔数: " + table.Rows[0][0].ToString());
                    str = "";
                    list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                    DataTable table2 = set.Tables["t_rm_scash_info"];
                    if ((table2 != null) && (table2.Rows.Count > 0))
                    {
                        result = 0;
                        num5 = 0M;
                        int.TryParse(table2.Rows[0]["count"].ToString(), out result);
                        decimal.TryParse(table2.Rows[0]["amount"].ToString(), out num5);
                        list.Add("赠送");
                        list.Add("--笔数: " + Gfunc.PrintStrAlign(result.ToString(), 6, TextAlign.Left) + "--金额: " + num5.ToString(Gattr.PosSaleAmtPoint));
                    }
                    DataTable table3 = set.Tables["t_rm_jycash_info"];
                    decimal num8 = 0M;
                    if ((table3 != null) && (table3.Rows.Count > 0))
                    {
                        List<t_dict_payment_info> paymentInfo = base._dal.GetPaymentInfo(" pay_flag = '0' or pay_flag = '1' or pay_flag='6' ");
                        foreach (t_dict_payment_info _info in paymentInfo)
                        {
                            for (int i = 1; i <= 3; i++)
                            {
                                switch (i)
                                {
                                    case 1:
                                        str2 = "A";
                                        str3 = "销售";
                                        num = 1;
                                        break;

                                    case 2:
                                        str2 = "B";
                                        str3 = "退货";
                                        num = -1;
                                        break;

                                    case 3:
                                        str2 = "D";
                                        str3 = "找零";
                                        num = -1;
                                        break;
                                }
                                DataRow[] rowArray = table3.Select(string.Format(" pay_way='{0}' and sale_way='{1}' ", _info.pay_way, str2));
                                if ((rowArray != null) && (rowArray.Length > 0))
                                {
                                    int num10;
                                    if ((rowArray.Length > 0) && _info.pay_way.ToUpper().Equals("SAV"))
                                    {
                                        num10 = 0;
                                        while (num10 <= (rowArray.Length - 1))
                                        {
                                            result = Convert.ToInt32(rowArray[num10]["count"]);
                                            num5 = Convert.ToDecimal(rowArray[num10]["amount"]);
                                            if ((result > 0) || (num5 > 0M))
                                            {
                                                if (rowArray[num10]["memo"].ToString() == "1")
                                                {
                                                    list.Add(_info.pay_name + "-项目" + str3);
                                                }
                                                else
                                                {
                                                    list.Add(_info.pay_name + "-" + str3);
                                                }
                                                list.Add("--笔数: " + Gfunc.PrintStrAlign(result.ToString(), 6, TextAlign.Left) + "--金额: " + num5.ToString(Gattr.PosSaleAmtPoint));
                                                if (num == 1)
                                                {
                                                    num6 += num5 * _info.rate;
                                                    num3 += result;
                                                }
                                                else if (num == -1)
                                                {
                                                    num7 += num5 * _info.rate;
                                                    num4 += result;
                                                }
                                            }
                                            num10++;
                                        }
                                    }
                                    else
                                    {
                                        for (num10 = 0; num10 <= (rowArray.Length - 1); num10++)
                                        {
                                            result = Convert.ToInt32(rowArray[num10]["count"]);
                                            num5 = Convert.ToDecimal(rowArray[num10]["amount"]);
                                            if ((result > 0) || (num5 > 0M))
                                            {
                                                if ((rowArray[num10]["memo"].ToString() == "2") || _info.pay_way.ToUpper().Equals("ORD"))
                                                {
                                                    if (str2 == "B")
                                                    {
                                                        list.Add(string.Format("退订货订金(人民币)", new object[0]));
                                                    }
                                                    else
                                                    {
                                                        list.Add(_info.pay_name + "-储值卡充值");
                                                    }
                                                }
                                                else if (rowArray[num10]["memo"].ToString() == "3")
                                                {
                                                    list.Add(_info.pay_name + "-储值卡项目充值");
                                                }
                                                else
                                                {
                                                    list.Add(_info.pay_name + "-" + str3);
                                                }
                                                list.Add("--笔数: " + Gfunc.PrintStrAlign(result.ToString(), 6, TextAlign.Left) + "--金额: " + num5.ToString(Gattr.PosSaleAmtPoint));
                                                switch (num)
                                                {
                                                    case 1:
                                                        num6 += num5 * _info.rate;
                                                        num3 += result;
                                                        break;

                                                    case -1:
                                                        num7 += num5 * _info.rate;
                                                        num4 += result;
                                                        break;
                                                }
                                                if (_info.pay_way == "RMB")
                                                {
                                                    num8 += num5 * num;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if ((num3 > 0) || (num4 > 0))
                    {
                        list.Add("");
                        list.Add("收支合计  笔数: " + ((num3 + num4)).ToString() + " ");
                        if (num4 > 0)
                        {
                            list.Add(Gfunc.PrintStrAlign("--支出笔数: " + num4.ToString(), 0x10, TextAlign.Left) + "支出金额: " + num7.ToString(Gattr.PosSaleAmtPoint));
                        }
                        if (num3 > 0)
                        {
                            list.Add(Gfunc.PrintStrAlign("--收入笔数: " + num3.ToString(), 0x10, TextAlign.Left) + "收入金额: " + num6.ToString(Gattr.PosSaleAmtPoint));
                        }
                        list.Add("--合计金额: " + ((num6 - num7)).ToString(Gattr.PosSaleAmtPoint));
                        list.Add("");
                        list.Add("人民币现金额: " + num8.ToString(Gattr.PosSaleAmtPoint));
                        str = "";
                        list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                    }
                }
                list.Add(Gfunc.PrintStrAlign("==完==", intPrintLen, TextAlign.Center));
                list3 = list;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return list3;
        }
        
        
        
        
        
        
        
        
        
        
        
        public List<string> ItemAccountStatement(string storeNo, string posId, string cashierId, string cashierName, DateTime dtFrom, DateTime dtTo, int intPrintLen)
        {
            int QtyLen = 6; //数量长度
            int PrcLen = 6; //单价长度
            int ItemLen = 15; //商品号
            int CntLen = 6;//

            List<string> list2;
            List<string> list = new List<string>();
            try
            {
                string str = "";
                DataTable table = new DataTable();
                table = base._dal.ItemAccountStatement(storeNo, cashierId, dtFrom, dtTo);
                if ((table == null) || (table.Rows.Count == 0))
                {
                    list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                    list.Add(Gfunc.PrintStrAlign("商品对帐 ", intPrintLen, TextAlign.Center));
                    str = "";
                    list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                    list.Add("收银员(" + cashierId + ")今天无收付款记录. ");
                    return list;
                }
                List<t_operator> cashierInfo = base._dal.GetOperatorInfo(cashierId, Gattr.BranchNo);
                list.Add("");
                list.Add(Gfunc.PrintStrAlign("   商品对帐单   ", intPrintLen, TextAlign.Center));
                list.Add(Gfunc.PrintStrAlign("================", intPrintLen, TextAlign.Center));
                str = "";
                list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                list.Add("  机构: " + base._dal.GetBranchName(storeNo));
                //list.Add("  仓库: " + base._dal.GetBranchName(storeNo));
                list.Add("  收银机号: " + posId);
                list.Add("  收 银 员:[" + cashierId + "]" + cashierInfo[0].oper_name.Trim());
                list.Add("  对账日期: " + DateTime.Today.ToString("yyyy-MM-dd"));
                str = "";
                list.Add(str.PadLeft((intPrintLen < 0) ? 0 : intPrintLen, '-'));
                string item = (Gfunc.PrintStrAlign("品名", ItemLen, TextAlign.Left) + Gfunc.PrintStrAlign("售价", PrcLen, TextAlign.Right)) + Gfunc.PrintStrAlign("数量", QtyLen, TextAlign.Center) + Gfunc.PrintStrAlign("金额", CntLen, TextAlign.Right);
                list.Add(item);
                decimal num = 0M;
                decimal num2 = 0M;
                foreach (DataRow row in table.Rows)
                {
                    decimal num6;
                    string s = row["item_name"].ToString().Trim();
                    if (ItemLen < Encoding.Default.GetByteCount(s))
                    {
                        s = SIString.SubChar(s, ItemLen);
                    }
                    string str4 = Gfunc.PrintStrAlign(s, ItemLen, TextAlign.Left);
                    decimal num3 = SIString.TryDec(row["sale_price"]);
                    string str5 = Gfunc.PrintStrAlign(num3.ToString(Gattr.PosSaleAmtPoint), PrcLen, TextAlign.Right);
                    decimal num4 = SIString.TryDec(row["sale_qnty"]);
                    num += (row["sale_way"].ToString() == "B") ? (num4 * -1M) : num4;
                    string str6 = Gfunc.PrintStrAlign((row["sale_way"].ToString() == "B") ? (num6 = num4 * -1M).ToString("N0") : num4.ToString("N0"), QtyLen, TextAlign.Center);
                    decimal num5 = num3 * num4;
                    num2 += (row["sale_way"].ToString() == "B") ? (num5 * -1M) : num5;
                    list.Add(str4 + str5 + str6 + Gfunc.PrintStrAlign((row["sale_way"].ToString() == "B") ? (num6 = num5 * -1M).ToString(Gattr.PosSaleAmtPoint) : num5.ToString(Gattr.PosSaleAmtPoint), CntLen, TextAlign.Right));
                }
                list.Add(str.PadLeft((Gattr.PrtLen < 0) ? 0 : Gattr.PrtLen, '-'));
                string str8 = (Gfunc.PrintStrAlign("合计：", ItemLen, TextAlign.Left) + Gfunc.PrintStrAlign("", PrcLen, TextAlign.Right)) + Gfunc.PrintStrAlign(num.ToString("N0"), QtyLen, TextAlign.Center) + Gfunc.PrintStrAlign(num2.ToString(Gattr.PosSaleAmtPoint), CntLen, TextAlign.Right);
                list.Add(str8);
                list.Add(Gfunc.PrintStrAlign("==完==", Gattr.PrtLen, TextAlign.Center));
                list2 = list;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return list2;
        }
        
        
        
        
        
        
        
        public DataTable GetBigClsPage(string clsNo, int pageSize, bool isNextPages)
        {
            return base._dal.GetBigClsPage(clsNo, pageSize, isNextPages);
        }
        
        
        
        
        
        
        
        public DataTable GetClsPage(string clsBigNo, string clsNo, int pageSize, bool isNextPage)
        {
            return base._dal.GetClsPage(clsBigNo, clsNo, pageSize, isNextPage);
        }
        
        
        
        
        
        
        
        
        public DataTable GetItemPage(string clsNo, string itemNo, int pageSize, bool isNextPage)
        {
            return base._dal.GetItemPage(clsNo, itemNo, pageSize, isNextPage);
        }

        
        
        
        
        
        public t_cur_saleflow GetItemInfo(string itemNo)
        {
            return base._dal.GetItemInfo(itemNo);
        }
        
        
        
        
        
        public List<t_item_info> GetItemInfoNew(string itemNo)
        {
            return base._dal.GetItemInfoNew(itemNo);
        }
        
        
        
        
        public void SaveTempSaleRow(List<t_cur_saleflow> listSaleflow)
        {
            base._dal.SaveTempSaleRow(listSaleflow);
        }
        
        
        
        
        
        
        
        
        public int GetClsItemCount(string clsNo)
        {
            return base._dal.GetClsItemCount(clsNo);
        }
        
        
        
        
        
        public decimal GetItemPrice(string itemNo)
        {
            return base._dal.GetItemPrice(itemNo);
        }
        
        
        
        
        
        public decimal GetItemDm(string itemNo)
        {
            return base._dal.GetItemPrice(itemNo);
        }
        
        
        
        
        
        public Dictionary<string, t_attr_function> GetFuncKeys(bool isAll)
        {
            return base._dal.GetFuncKeys(isAll);
        }
        
        
        
        
        public List<t_cur_saleflow> GetTempSaleRow()
        {
            return base._dal.GetTempSaleRow();
        }
        
        
        
        
        
        public void InsertPendingOrder(string flowNo, List<t_cur_saleflow> listSaleFlow, t_pending_order penOrd)
        {

            for (int i = 0; i < listSaleFlow.Count; i++)
            {
                listSaleFlow[i].flow_no = flowNo;
            }

            base._dal.InsertPendingOrder(listSaleFlow, penOrd);
        }
        
        
        
        
        public List<t_pending_order> GetPenOrdRows()
        {
            return base._dal.GetPenOrdRows();
        }
        
        
        
        
        
        public List<t_cur_saleflow> GetPenOrdSaleFlow(string flowNo)
        {
            return base._dal.GetPenOrdSaleFlow(flowNo);
        }


        public bool CheckPendingOrder(int flowNo)
        {
            string str = flowNo.ToString("0000");
            return (base._dal.CheckPendingOrder(str) >= 1);
        }
        
        
        
        
        
        public bool DelPenOrd(string flowNo)
        {
            return (base._dal.DelPenOrd(flowNo) > 0);
        }
        
        
        
        
        public List<t_cur_payflow> GetTempPayRow()
        {
            return base._dal.GetTempPayRow();
        }
        
        
        
        
        public List<t_cur_payflow> GetPendingPayRow(string flowNo)
        {
            return base._dal.GetPendingPayRow(flowNo);
        }
        
        
        
        
        public void SaveTempPayRow(List<t_cur_payflow> listPayflow)
        {
            base._dal.SaveTempPayRow(listPayflow);
        }
        
        
        
        
        public void SavePendingPayRow(List<t_cur_payflow> listPayflow, string FlowNo)
        {
            base._dal.SavePendingPayRow(listPayflow, FlowNo);
        }

        
        
        
        
        public void DelPendingPayRow(string flowNo)
        {
            base._dal.DelPendingPayRow(flowNo);
        }
        
        
        
        
        
        
        public void SavePosBill(string flowNo, List<t_cur_saleflow> listSaleflow, List<t_cur_payflow> listPayflow)
        {
            DateTime operDataTime = this.GetOperDataTime();
            foreach (t_cur_saleflow _saleflow in listSaleflow)
            {
                _saleflow.flow_no = flowNo;
                _saleflow.sale_money = Math.Abs(_saleflow.sale_money);
                _saleflow.sale_qnty = Math.Abs(_saleflow.sale_qnty);
                _saleflow.discount_rate = ExtendUtility.Instance.ParseToDecimal((_saleflow.unit_price / _saleflow.sale_price).ToString(Gattr.PosSaleAmtPoint));
                _saleflow.oper_date = ExtendUtility.Instance.ParseToDateTime(operDataTime).ToString("s");
            }

            foreach (t_cur_payflow _payflow in listPayflow)
            {
                _payflow.flow_no = flowNo;
                _payflow.pay_amount = Math.Abs(_payflow.pay_amount);
                _payflow.sale_amount = Math.Abs(_payflow.sale_amount);
                _payflow.convert_amt = Math.Abs(_payflow.convert_amt);//折算金额（支付方式的汇率折算）
                _payflow.oper_date = ExtendUtility.Instance.ParseToDateTime(operDataTime).ToString("s");
            }

            IDbTransaction objTrans = null;
            bool flag = base._dal.BeginSQLTrans(ref objTrans);
            try
            {
                base._dal.SavePosBill(listSaleflow, listPayflow, objTrans);
            }
            catch (SQLiteException exception)
            {
                if (flag)
                {
                    objTrans.Rollback();
                    throw exception;
                }
            }
            if (flag)
            {
                objTrans.Commit();
            }
        }
        
        
        
        public void DeleteTempData()
        {
            base._dal.DeleteTempData();
        }


        //保存优惠券使用
        public void SaveCoupon(string flowNo, String mem_no, List<t_pos_coupon> listCoupon)
        {

            foreach (t_pos_coupon coupon in listCoupon)
            {
                coupon.flow_no = flowNo;//订单流水号
                coupon.oper_uid = mem_no;//会员编号
                coupon.oper_date= System.DateTime.Now.ToString("s");//当前日期
                coupon.branch_no = Gattr.BranchNo;
            }

            
            IDbTransaction objTrans = null;
            bool flag = base._dal.BeginSQLTrans(ref objTrans);
            try
            {
                base._dal.SaveCoupon(listCoupon, objTrans);
            }
            catch (SQLiteException exception)
            {
                if (flag)
                {
                    objTrans.Rollback();
                    throw exception;
                }
            }
            if (flag)
            {
                objTrans.Commit();
            }
        }



        public t_operator GetOperatorInfo(string operName, string operPwd, string branckId)
        {
            return base._dal.GetOperatorInfo(operName, operPwd, branckId);
        }
        
        
        
        
        
        
        public int SetOperatorLoginTime(string operId, DateTime dt)
        {
            return (base._dal.SetOperLoginTime(operId, dt) > 0) ? 1 : 0;
        }
        
        
        
        
        
        public List<t_operator> GetOperatorInfo(string operId, string branchId)
        {
            return base._dal.GetOperatorInfo(operId, branchId);
        }

        
        
        
        
        
        public List<t_dict_payment_info> GetPaymentInfo(string where)
        {
            return base._dal.GetPaymentInfo(where);
        }
        
        
        
        
        public List<t_vip_info> GetVipInfo(string cardNo, SearchType searchType)
        {
            return base._dal.GetVipInfo(cardNo, searchType);
        }
        
        
        
        
        
        
        
        public bool InsertAccList(t_vip_info vipInfo, string flowNo)
        {
            return base._dal.InsertAccList(vipInfo, flowNo);
        }

        
        
        
        
        
        public List<t_base_code> GetReasonInfos(string flag)
        {
            return base._dal.GetAllReasonInfo(flag);
        }
        
        
        
        
        
        public List<t_cur_saleflow> GetSaleFlowInfoByFlowNo(string flowNo)
        {
            return base._dal.GetSaleFlowInfo(flowNo);
        }
        
        
        
        
        
        public List<t_cur_saleflow> GetVoucherInfoByFlowNo(string flowNo)
        {
            return base._dal.GetVoucherInfo(flowNo);
        }
        
        
        
        
        
        public List<t_cur_payflow> GetPayFlowInfoByFlowNo(string flowNo)
        {
            return base._dal.GetPayFlowInfo(flowNo);
        }
        
        
        
        
        
        public DataTable GetBranchInfo(string where)
        {
            return base._dal.GetBranchInfo(where);
        }
        
        
        
        
        
        public Int32 GetVoucherNoCount(String flowNo)
        {
            return base._dal.GetVoucherNoCount(flowNo);
        }
        #region 商品查询
        
        
        
        
        
        
        public DataTable GetMaxPayFlowInfo(String brancheNo, String posNo, String flowno, String operate)
        {
            return base._dal.GetMaxPayFlowInfo(brancheNo, posNo, flowno, operate);
        }
        
        
        
        
        
        public DataTable GetSaleFlowInfos(String flowNo)
        {
            return base._dal.GetSaleFlowInfoByFlowNo(flowNo);
        }
        
        
        
        public DataTable GetPayFlowInfoDataTableByE()
        {
            return base._dal.GetPayFlowInfoDataTableByE();
        }
        
        
        
        
        
        public List<t_cur_payflow> GetPayFlowInfoListByFlowNo(String flowNo)
        {
            return base._dal.GetPayFlowInfoListByFlowNo(flowNo);
        }
        
        
        
        
        
        public DataTable GetPayFlowInfoDataTableByFlowNo(String flowNo)
        {
            return base._dal.GetPayFlowInfoDataTableByFlowNo(flowNo);
        }
        
        
        
        
        public bool DelPayFlowById(string id)
        {
            return base._dal.DelPayFlowById(id);
        }
        
        
        
        
        public bool UpdatePayFlowStatus(t_pos_payflow _payFlow)
        {
            return base._dal.UpdatePayFlowStatus(_payFlow);
        }
        
        
        
        
        public bool UpdatePayFlowByFid(t_pos_payflow _payFlow)
        {
            return base._dal.UpdatePayFlowByFid(_payFlow);
        }
        
        
        
        
        
        public List<t_cur_saleflow> GetSaleFlowInfoListByFlowNo(String flowNo)
        {
            return base._dal.GetSaleFlowInfoListByFlowNo(flowNo);
        }
        
        
        
        
        
        public DataTable GetSaleFlowInfoDataTableByFlowNo(String flowNo)
        {
            return base._dal.GetSaleFlowInfoDataTableByFlowNo(flowNo);
        }
        #endregion

        #region 基础数据更新
        
        
        
        public t_handle SelectHandleData()
        {
            return this._dal.SelectHandleDate();
        }
        
        
        
        
        public bool UpdateHandleData(t_handle t_h)
        {
            return this._dal.UpdateHandleDate(t_h);
        }
        
        
        
        
        
        public bool InsertItemData(DataTable table,decimal del,ref decimal rid)
        {
            return this._dal.InsertItemData(table,del,ref rid);
        }
        
        
        
        
        
        public bool InsertBarcodeData(DataTable table, decimal del, ref decimal rid)
        {
            this.DelBarcodeData();
            return this._dal.InsertBarCodeData(table,del,ref rid);
        }

        //清空商品附加条码SQLLite表
        public bool DelBarcodeData()
        {
            return this._dal.DelBarcodeData();
        }



        public bool InsertItemClsData(DataTable table, decimal del, ref decimal rid)
        {
            //清空所有商品分类，保存所有数据
            this.DelItemClsData();
            return  this._dal.InsertClsData(table,del,ref rid);
        }
        
        //清空商品分类SQLLite表
        public bool DelItemClsData() {
            return this._dal.DelClsData();
        }

        //清空商品内容SQLLite表
        public bool DelItemData()
        {
            return this._dal.DelItemData();
        }

        //更新t_handle表
        public bool UpdateTHandleData()
        {
            return this._dal.UpdateTHandle();
        }


        //清空营业员SQLLite表
        public bool DelCashierData()
        {
            return this._dal.DelCashierData();
        }


        public bool InsertCashierData(DataTable table, decimal del, ref decimal rid)
        {
            //清空营业员表
            this.DelCashierData();
            return this._dal.InsertCashierData(table,del,ref rid);
        }
        
        
        
        
        
        public bool InsertBaseTypeData(DataTable table,decimal del,ref decimal rid)
        {
            return this._dal.InsertBaseTypeData(table,del,ref rid);
        }
        
        
        
        
        
        public bool InsertBaseData(DataTable table,decimal del,ref decimal rid)
        {
            return this._dal.InsertBaseData(table,del,ref rid);
        }
        
        
        
        
        
        public bool InsertPaymentInfo(DataTable table)
        {
            return this._dal.InsertPaymentData(table);
        }
        
        
        
        
        
        public bool InsertFunction(DataTable table)
        {
            return this._dal.InsertFunction(table);
        }
        
        
        
        
        
        public bool InsertPlanRule(DataTable table)
        {
            return this._dal.InsertPlanRule(table);
        }
        
        
        
        
        
        public bool InsertPlanMaster(DataTable table,decimal del, ref decimal rid)
        {
            return this._dal.InsertPlanMaster(table,del,ref rid);
        }

        
        
        
        
        
        public bool InsertPlanDetail(DataTable table, decimal del, ref decimal rid)
        {
            return this._dal.InsertPlanDetail(table,del,ref rid);
        }
        
        
        
        
        
        public bool InsertPosSysSet(List<t_sys_pos_set> sets)
        {
            return this._dal.InsertPosSysSet(sets);
        }
        
        
        
        
        
        public bool InsertBrancheList(DataTable table)
        {
            return this._dal.InsertBranchList(table);
        }
        
        
        
        
        
        public int GetIntFlow(string flowNo)
        {
            return this._dal.GetIntFlow(flowNo);
        }
        
        
        
        
        
        public bool InNonTrading(t_cur_payflow _payflow)
        {
            return this._dal.InNonTrading(_payflow);
        }
        
        
        
        
        
        public bool UpdateItemPrice(DataTable table,ref decimal rid)
        {
            return _dal.UpdateItemPrice(table,ref rid);
        }
        
        
        
        
        
        public bool UpdateItemStock(DataTable table,ref decimal rid)
        {
            return _dal.UpdateItemStock(table,ref rid);
        }
        #endregion
        
        
        
        
        public int GetMaxPendingOrderFlowNo()
        {
            return Gfunc.TypeToInt(base._dal.GetMaxPendingOrderFlow(), 0);
        }
        
        
        
        
        public DateTime? GetLastAccountTime()
        {
            return base._dal.GetLastAccountTime();
        }
        
        
        
        
        
        
        public decimal GetSumAccountAmt(DateTime dtStart, DateTime dtEnd)
        {
            return base._dal.GetSumAccountAmt(dtStart, dtEnd);
        }
        
        
        
        
        
        
        public void GetQueryPeriod(out DateTime dtStart, out DateTime dtEnd, out bool hasData)
        {
            DateTime? lastAccountTime = this.GetLastAccountTime();
            base._dal.GetQueryPeriod(lastAccountTime, out dtStart, out dtEnd, out hasData);
        }
        
        
        
        
        
        
        
        
        public bool InsertAccountRecord(DateTime dtStart, DateTime dtEnd, decimal sumAmt,decimal sumMoney, out string errMsg)
        {
            return base._dal.InsertAccountRecord(dtStart, dtEnd, sumAmt,sumMoney,out errMsg);
        }
        
        
        
        
        public DateTime GetOperDataTime()
        {
            DateTime now = DateTime.Now;
            return now;
        }



        #region POS机设置
        
        
        
        
        public List<t_sys_pos_set> GetPosSets()
        {
            return _dal.GetPosSets();
        }
        #endregion

        #region 促销模块
        
        
        
        
        
        
        
        
        public DataTable GetPlanMaster(string plu_flag, string rule_no, string plan_no, string rrule_no, string vip_type)
        {
            return this._dal.GetPlanMaster(plu_flag, rule_no, plan_no, rrule_no, vip_type);
        }
        
        
        
        
        
        public DataTable GetPlanDetail(DataTable table)
        {
            return this._dal.GetPlanDetail(table);
        }
        
        
        
        
        
        public DataTable GetPlanDetailByPlanNo(string plan_no)
        {
            return this._dal.GetPlanDetailByPlanNo(plan_no);
        }
        
        
        
        
        
        
        public PlanRule GetPlanRuleInfo(string rule_no, string range_flag)
        {
            return this._dal.GetPlanRuleInfo(rule_no, range_flag);
        }
        
        
        
        
        
        public string GetClsNameByClsNo(string cls_no)
        {
            return this._dal.GetClsNameByClsNo(cls_no);
        }
        
        
        
        
        
        public string GetBrandName(string brand)
        {
            return this._dal.GetBrandName(brand);
        }
        
        
        
        
        
        public string GetItemName(string item_no)
        {
            return this._dal.GetItemName(item_no);
        }
        #endregion

        
        
        
        
        
        public bool SaveNonTrading(t_pos_payflow _pay)
        {
            return this._dal.SaveNonTrading(_pay);
        }
        
        
        
        
        
        public string GetBranchNameByNo(string branch_no)
        {
            return this._dal.GetBranchNameByNo(branch_no);
        }
        
        
        
        
        
        public bool InsertItemComb(DataTable table,decimal del,ref decimal rid)
        {
            return this._dal.InsertItemComb(table,del,ref rid);
        }
        
        
        
        
        
        public List<t_cur_saleflow> GetItemsForPos(string item_no)
        {
            return this._dal.GetItemsForPos(item_no);
        }
        
        
        
        
        
        
        public int UpdateOperPwd(string operId, string pwd)
        {
            return this._dal.UpdateOperPwd(operId, pwd);
        }
        
        
        
        
        public int GetNonUpdateFlow()
        {
            return this._dal.GetNonUpdateFlow();
        }
        
        
        
        
        
        public string GetVipCardByNo(string memo)
        {
            return this._dal.GetVipCardByNo(memo);
        }
        
        
        
        
        
        public bool AddVipflow(t_app_viplist vipinfo)
        {
            return this._dal.AddVipflow(vipinfo);
        }
        
        
        
        
        public bool DeleteTempNonSaleData()
        {
            return this._dal.DeleteTempNonSaleData();
        }
        #region 基础信息添加供应商
        
        
        
        
        
        public bool InsertSupinfo(DataTable table)
        {
            return this._dal.InsertSupinfo(table);
        }
        #endregion
        #region 公共查询控件查询
        
        
        
        
        
        
        public DataTable GetCommonSelData(string type, string keyword)
        {
            return this._dal.GetCommonSelData(type, keyword);
        }
        #endregion


        
        
        
        
        
        public DataTable GetItemStock()
        {
            return this._dal.GetItemStock();
        }
        
        
        
        
        
        public t_app_viplist GetVipflow(string flow_no)
        {
            return this._dal.GetVipflow(flow_no);
        }
    }
}

