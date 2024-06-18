namespace ICE.POS.Service
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Globalization;
    using System.Text;
    using ICE.POS.Common;
    using ICE.Utility;
    public class PosDal
    {
        #region 查询操作
        /// <summary>
        /// 收银员列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetCashierList(string branchNo, string cashierId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_sys_operator");

            if (cashierId != "" && branchNo != "")
            {
                strSql.Append(" where oper_id=@oper_id");
                strSql.Append(" and (branch_no=@branch_no or branch_no='ALL')");
                SqlParameter[] parameters = { 
                    new SqlParameter("@oper_id", SqlDbType.VarChar, 10),
                    new SqlParameter("@branch_no", SqlDbType.VarChar, 10)
                };
                parameters[0].Value = cashierId.Trim();
                parameters[1].Value = branchNo.Trim();

                return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parameters);
            }
            else if (branchNo != "")
            {
                strSql.Append(" where branch_no=@branch_no or branch_no='ALL'");
                SqlParameter[] parameters = { 
                    new SqlParameter("@branch_no", SqlDbType.VarChar, 10)
                };
                parameters[0].Value = branchNo.Trim();

                return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parameters);
            }
            //else if (cashierId != "")
            //{
            //    strSql.Append(" where oper_id=@oper_id");
            //    SqlParameter[] parameters = { 
            //        new SqlParameter("@oper_id", SqlDbType.VarChar, 10)
            //    };	
            //    parameters[0].Value = cashierId.Trim();

            //    return SqlHelper.ExecuteDataSet(CommandType.Text,strSql.ToString(),parameters);
            //}

            return null;
        }
        /// <summary>
        /// 单个组织机构信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetBranchInfo(string branchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_branch_info");

            if (branchNo != "")
            {
                strSql.Append(" where branch_no=@branch_no and property=0");

                SqlParameter[] parameters = { 
                    new SqlParameter("@branch_no", SqlDbType.VarChar, 10)
                };
                parameters[0].Value = branchNo.Trim();

                return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parameters);
            }

            return null;
        }

        /// <summary>
        /// 所有组织机构信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetBranchList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_branch_info");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }
        /// <summary>
        /// 库存信息表
        /// </summary>
        /// <param name="branchNo"></param>
        /// <returns></returns>
        public DataSet GetBranchStock(string branchNo, string branchTextKey)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("select ics.item_no,ics.item_name,ics.item_size,ics.branch_no,ics.stock_qty,ics.item_clsname,c.code_name from t_bd_base_code as c,");
            strSql.Append(" (select ics.item_no,ics.item_name,ics.item_size,ics.branch_no,ics.stock_qty,c.item_clsname,ics.item_brand");
            strSql.Append(" from t_bd_item_cls as c,");
            strSql.Append(" (select s.item_no,i.item_name,i.item_size,s.branch_no,s.stock_qty,i.item_clsno,i.item_brand");
            strSql.Append(" from t_bd_item_info as i,t_im_branch_stock as s");
            strSql.Append(" where i.item_no = s.item_no and s.branch_no=@branch_no and (i.item_no like @branchTextKey or i.item_name like @branchTextKey)) as ics");
            strSql.Append(" where c.item_clsno=ics.item_clsno) as ics where c.type_no='PP' and c.code_id=ics.item_brand");

            if (branchNo != "")
            {
                //  strSql.Append(" where branch_no=@branch_no");

                SqlParameter[] parameters = { 
                    new SqlParameter("@branch_no", SqlDbType.VarChar, 10),
                    new SqlParameter("@branchTextKey", SqlDbType.VarChar, 20)
                };
                parameters[0].Value = branchNo.Trim();
                parameters[1].Value = "%" + branchTextKey.Trim() + "%";

                return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parameters);
            }
            return null;
        }
        /// <summary>
        /// 商品条码
        /// </summary>
        /// <returns></returns>
        public DataSet GetBarcodeList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_item_barcode");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }
        /// <summary>
        /// 商品分类列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetItemClsList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_item_cls");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }
        /// <summary>
        /// 商品列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetItemList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_item_info");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }
        /// <summary>
        /// POS机状态表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPosStatusList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_sys_pos_status");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }

        /// <summary>
        /// 基础代码类型表
        /// </summary>
        /// <returns></returns>
        public DataSet GetBaseCodeType()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_basecode_type");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }

        /// <summary>
        /// 基础代码信息表
        /// </summary>
        /// <returns></returns>
        public DataSet GetBaseCodeInfo()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_base_code");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }
        /// <summary>
        /// 支付信息表
        /// </summary>
        /// <returns></returns>
        public DataSet GetPaymentInfo()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_bd_payment_info");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }

        /// <summary>
        /// 快捷键表
        /// </summary>
        /// <returns></returns>
        public DataSet GetFunction(string branchNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from t_rm_function");
            if (branchNo.Trim() != "")
            {
                strSql.Append(" where branch_no=@branch_no");

                SqlParameter[] parameters = { 
                    new SqlParameter("@branch_no", SqlDbType.VarChar, 10)
                };
                parameters[0].Value = branchNo.Trim();

                return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parameters);
            }
            else
            {
                strSql.Append(" where branch_no=@branch_no");

                SqlParameter[] parameters = { 
                    new SqlParameter("@branch_no", SqlDbType.VarChar, 10)
                };
                parameters[0].Value = "000";

                return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parameters);
            }
        }
        #endregion
        private DataSet GetItemInfo(string itemNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select price,purchase_tax from t_bd_item_info where status=1 and item_no='" + itemNo + "'");

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
        }

        #region 终端要货查询
        public DataSet GetPMSheetMaster(string transNO, string sheetNO, string branchNO, string status, DateTime startDate, DateTime endDate)
        {
            if (branchNO.Trim().Equals(""))
            {
                return null;
            }

            StringBuilder strSql = new StringBuilder();
            List<SqlParameter> lstSQLParam = new List<SqlParameter>();

            strSql.Append("SELECT cc.sheet_no,cc.branch_name,bi.branch_name AS d_branch_name,cc.oper_id,cc.oper_date,case when cc.approve_flag=1 then '已审核' else '未审核' end AS approve_name,cc.confirm_man");
            strSql.Append(" FROM (SELECT sm.sheet_no,bi.branch_name,sm.d_branch_no,sm.oper_id,sm.oper_date,sm.trans_no,sm.approve_flag,so.oper_name AS confirm_man");
            strSql.Append(" FROM t_pm_sheet_master AS sm,t_bd_branch_info AS bi,t_sys_operator AS so");
            strSql.Append(" WHERE sm.branch_no=bi.branch_no and sm.oper_id=so.oper_id and sm.branch_no=@branchNo) AS cc,t_bd_branch_info AS bi");
            strSql.Append(" WHERE bi.branch_no=cc.d_branch_no");
            lstSQLParam.Add(new SqlParameter("@branchNO", branchNO));
            if (transNO.Trim().Equals(""))
            {
                strSql.Append(" and cc.trans_no=@transNO");
                lstSQLParam.Add(new SqlParameter("@transNO", transNO));
            }
            if (!status.Trim().Equals("-1"))
            {
                strSql.Append(" and cc.approve_flag=@status");
                lstSQLParam.Add(new SqlParameter("@status", status.Trim()));
            }
            if (!sheetNO.Trim().Equals(""))
            {
                strSql.Append(" and cc.sheet_no like @sheetNO");
                lstSQLParam.Add(new SqlParameter("@sheetNO", "%" + sheetNO + "%"));
            }
            if (!startDate.Equals(""))
            {
                strSql.Append(" and cc.oper_date>=@startDate");
                lstSQLParam.Add(new SqlParameter("@startDate", startDate));
            }
            if (!endDate.Equals(""))
            {
                strSql.Append(" and cc.oper_date<=@endDate");
                lstSQLParam.Add(new SqlParameter("@endDate", endDate));
            }

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), lstSQLParam.ToArray());
        }

        #endregion
        #region 终端要货商品明细查询
        public t_pm_sheet_master GetPMSheetDetail(string sheetNO, ref DataTable dt)
        {
            StringBuilder strSqlSM = new StringBuilder();
            List<SqlParameter> lstSQLParam = new List<SqlParameter>();

            strSqlSM.Append("SELECT sheet_no,branch_no,d_branch_no,approve_flag,oper_id,valid_date FROM t_pm_sheet_master where sheet_no=@sheetNO");
            lstSQLParam.Add(new SqlParameter("@sheetNO", sheetNO));
            DataTable dtSm = SqlHelper.ExecuteDataSet(CommandType.Text, strSqlSM.ToString(), lstSQLParam.ToArray()).Tables[0];
            t_pm_sheet_master sm = new t_pm_sheet_master
            {
                sheet_no = dtSm.Rows[0]["sheet_no"].ToString(),
                branch_no = dtSm.Rows[0]["branch_no"].ToString(),
                approve_flag = dtSm.Rows[0]["approve_flag"].ToString(),
                d_branch_no = dtSm.Rows[0]["d_branch_no"].ToString(),
                oper_id = dtSm.Rows[0]["oper_id"].ToString(),
                valid_date = DateTime.Parse(dtSm.Rows[0]["valid_date"].ToString())
            };

            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT sd.item_no,ii.item_name,ii.unit_no,sd.real_qty");
            strSql.Append(" FROM t_pm_sheet_detail AS sd,t_bd_item_info AS ii");
            strSql.Append(" WHERE sd.item_no=ii.item_no and sd.sheet_no=@sheetNO");
            SqlParameter[] parameters = { 
                    new SqlParameter("@sheetNO",sheetNO.Trim())
                };
            dt = SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parameters).Tables[0];
            return sm;
        }
        #endregion
        #region 更新数据

        #region 更新POS机状态
        /// <summary>
        /// POS机状态表
        /// </summary>
        /// <returns></returns>
        public int UpdatePosStatus(t_sys_pos_status posStatus)
        {
            if (posStatus.branch_no.Trim().Equals(""))
            {
                return 1001;
            }
            if (posStatus.posid.Trim().Equals(""))
            {
                return 1002;
            }
            if (posStatus.lasttime.ToString().Equals(""))
            {
                return 1003;
            }
            if (posStatus.lastcashier.Trim().Equals(""))
            {
                return 1004;
            }
            if (posStatus.load_flag.Trim() == "")
            {
                return 1005;
            }
            StringBuilder strSql = new StringBuilder();
            int num = 0; ;
            strSql.Append("UPDATE t_sys_pos_status SET");
            strSql.Append(" (branch_no=@branch_no,posid=@posid,posdesc=@posdesc, hostip=@hostip,");
            strSql.Append(" hostname=@hostname, operdate=@operdate, amount=@amount,orderqty=@orderqty,");
            strSql.Append(" orderqty=@orderqty, lasttime=@lasttime, lastcashier=@lastcashier, status=@status,");
            strSql.Append(" other=@other, com_flag=@com_flag, load_flag=@load_flag)");
            SqlTransaction tran = null;
            try
            {
                tran = SqlTransHelper.GetSqlTransaction();

                SqlParameter[] parameters = { 
                    new SqlParameter("@branch_no",posStatus.branch_no),
                    new SqlParameter("@posid", posStatus.posid),
                    new SqlParameter("@posdesc", posStatus.posid),
                    new SqlParameter("@hostip", posStatus.posid),
                    new SqlParameter("@hostname", posStatus.posid),
                    new SqlParameter("@operdate", posStatus.posid),
                    new SqlParameter("@amount", posStatus.amount),
                    new SqlParameter("@orderqty", posStatus.orderqty),
                    new SqlParameter("@lasttime", posStatus.lasttime),
                    new SqlParameter("@lastcashier", posStatus.lastcashier),
                    new SqlParameter("@status", posStatus.status),
                    new SqlParameter("@other", posStatus.other),
                    new SqlParameter("@com_flag", posStatus.com_flag.Trim().Equals("")?"0":posStatus.com_flag),
                    new SqlParameter("@load_flag", posStatus.load_flag)
                };
                DataTable dtTemp = GetPosStatus(posStatus.branch_no).Tables[0];
                SqlParameter[] parms = { 
                    new SqlParameter("@branch_no",dtTemp.Rows[0]["branch_no"]),
                    new SqlParameter("@posid", dtTemp.Rows[0]["posid"]),
                    new SqlParameter("@posdesc", dtTemp.Rows[0]["posdesc"]),
                    new SqlParameter("@hostip", dtTemp.Rows[0]["hostip"]),
                    new SqlParameter("@hostname",dtTemp.Rows[0]["hostname"]),
                    new SqlParameter("@operdate",dtTemp.Rows[0]["operdate"]),
                    new SqlParameter("@amount", dtTemp.Rows[0]["amount"]),
                    new SqlParameter("@orderqty", dtTemp.Rows[0]["orderqty"]),
                    new SqlParameter("@lasttime", dtTemp.Rows[0]["lasttime"]),
                    new SqlParameter("@lastcashier", dtTemp.Rows[0]["lastcashier"]),
                    new SqlParameter("@status", dtTemp.Rows[0]["status"]),
                    new SqlParameter("@other", dtTemp.Rows[0]["other"]),
                    new SqlParameter("@com_flag", dtTemp.Rows[0]["com_flag"]),
                    new SqlParameter("@load_flag", dtTemp.Rows[0]["load_flag"])
                };
                num = SqlHelper.ExecteNonQuery(SqlTransHelper.conn, tran, CommandType.Text, this.GetSqlInsertPosStatus(), parms);

                num = SqlHelper.ExecteNonQuery(SqlTransHelper.conn, tran, CommandType.Text, strSql.ToString(), parameters);
            }
            catch (Exception exception)
            {
                tran.Rollback();
                SqlTransHelper.Close();
                tran.Dispose();
                throw exception;
                throw exception;
            }
            tran.Commit();
            tran.Dispose();
            SqlTransHelper.Close();
            return num;
        }

        #region POS机历史记录
        private string GetSqlInsertPosStatus()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_sys_pos_status values(branch_no,posid,posdesc,hostip,");
            strSql.Append(" hostname,operdate,amount,orderqty,lasttime,lastcashier,status,other,com_flag,load_flag)");
            strSql.Append(" VALUES (@branch_no,@posid,@posdesc, @hostip,");
            strSql.Append(" @hostname, @operdate, @amount,@orderqty, @orderqty, @lasttime, @lastcashier, @status,");
            strSql.Append(" @other, @com_flag, @load_flag)");
            return strSql.ToString();
        }

        private DataSet GetPosStatus(string branchNo)
        {
            string strSql = "select * from t_sys_pos_status where branch_no=@branch_no";
            SqlParameter[] parms = { 
                new SqlParameter("@branch_no",branchNo.Trim())
            };

            return SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), parms);
        }
        #endregion
        #endregion

        #endregion

        #region 插入数据

        #region 会员卡付款列表
        /// <summary>
        /// 会员卡付款列表
        /// </summary>
        /// <returns></returns>
        public int InsertCardPayList(List<t_rm_card_paylist> cardPayList)
        {
            int num = 0;
            try
            {
                foreach (t_rm_card_paylist cardPay in cardPayList)
                {
                    SqlParameter[] parameters = { 
                        new SqlParameter("@card_id", cardPay.card_id),
                        new SqlParameter("@flow_no", cardPay.flow_no),
                        new SqlParameter("@amount", cardPay.amount),
                        new SqlParameter("@pay_time", cardPay.pay_time),
                        new SqlParameter("@other1", cardPay.other1),
                        new SqlParameter("@other2", cardPay.other2),
                        new SqlParameter("@branch_no", cardPay.branch_no),
                        new SqlParameter("@residual_amt", cardPay.residual_amt),
                        new SqlParameter("@com_flag", cardPay.com_flag),
                        new SqlParameter("@vip_acc", cardPay.vip_acc),
                        new SqlParameter("@real_date", cardPay.real_date)
                     };
                    num = SqlHelper.ExecteNonQuery(CommandType.Text, this.GetSqlInsertCardPayList(), parameters);
                }

            }
            catch (Exception exception)
            {

                throw exception;
            }
            return num;
        }

        private string GetSqlInsertCardPayList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_sys_pos_status");
            strSql.Append(" (flow_no, card_type, card_id, amount, pay_time, other1, other2,");
            strSql.Append(" branch_no, residual_amt, com_flag, vip_acc, real_date)");
            strSql.Append(" VALUES(@flow_no, @card_type, @card_id, @amount, @pay_time, @other1, @other2");
            strSql.Append(" @branch_no, @residual_amt, @com_flag, @vip_acc, @real_date)");
            return strSql.ToString();
        }
        #endregion
        #region 销售列表
        /// <summary>
        /// 销售列表
        /// </summary>
        /// <returns></returns>_
        private int InsertSaleFlow(List<t_rm_saleflow> saleFlow, SqlTransaction tran)
        {
            int num = 0;
            try
            {
                foreach (t_rm_saleflow _saleFlow in saleFlow)
                {
                    SqlParameter[] parameters = { 
                        new SqlParameter("@flow_id", _saleFlow.flow_id),
                        new SqlParameter("@flow_no", _saleFlow.flow_no),
                        new SqlParameter("@branch_no", _saleFlow.branch_no),
                        new SqlParameter("@item_no", _saleFlow.item_no),
                        new SqlParameter("@source_price", _saleFlow.source_price),
                        new SqlParameter("@sale_price", _saleFlow.sale_money),
                        new SqlParameter("@sale_qnty", _saleFlow.sale_qnty),
                        new SqlParameter("@sale_money", _saleFlow.sale_money),
                        new SqlParameter("@sell_way", _saleFlow.sell_way),
                        new SqlParameter("@oper_id", _saleFlow.oper_id),
                        new SqlParameter("@sale_man", DBNull.Value),
                        new SqlParameter("@counter_no", "0001"),
                        new SqlParameter("@oper_date", _saleFlow.oper_date),
                        new SqlParameter("@remote_flag", "0"),
                        new SqlParameter("@shift_no", DBNull.Value),
                        new SqlParameter("@real_date", _saleFlow.oper_date),
                        new SqlParameter("@com_flag", DBNull.Value),
                        new SqlParameter("@spec_flag", DBNull.Value),
                        new SqlParameter("@pref_amt", DBNull.Value),
                        new SqlParameter("@in_price", _saleFlow.sale_money),
                        new SqlParameter("@n_stan", DBNull.Value),
                        new SqlParameter("@posid", _saleFlow.posid),
                        new SqlParameter("@uptime", DBNull.Value),
                        new SqlParameter("@is_jxc", "1"),
                        new SqlParameter("@spec_sheet_no", DBNull.Value),
                        new SqlParameter("@spec_group_id", DBNull.Value),
                        new SqlParameter("@chr_stan", DBNull.Value)
                     };
                    num = SqlHelper.ExecteNonQuery(SqlTransHelper.conn, tran, CommandType.Text, this.GetSqlInsertSaleFlow(), parameters);
                }

            }
            catch (Exception exception)
            {

                throw exception;
            }
            return num;
        }
        private string GetSqlInsertSaleFlow()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_rm_saleflow");
            strSql.Append(" (flow_id, flow_no, branch_no, item_no, source_price, sale_price, sale_qnty,");
            strSql.Append(" sale_money, sell_way, oper_id, sale_man, counter_no,oper_date,remote_flag,shift_no,");
            strSql.Append(" com_flag, spec_flag,pref_amt,in_price,n_stan,chr_stan,posid,uptime, is_jxc,");
            strSql.Append(" real_date,spec_sheet_no,spec_group_id)");
            strSql.Append(" VALUES(@flow_id, @flow_no, @branch_no, @item_no, @source_price, @sale_price, @sale_qnty,");
            strSql.Append(" @sale_money, @sell_way, @oper_id, @sale_man, @counter_no,@oper_date,@remote_flag,@shift_no,");
            strSql.Append(" @com_flag, @spec_flag,@pref_amt,@in_price,@n_stan,@chr_stan,@posid,@uptime, @is_jxc,");
            strSql.Append(" @real_date,@spec_sheet_no,@spec_group_id)");
            return strSql.ToString();
        }
        #endregion
        #region 付款列表
        public bool InPayFlowList(List<t_rm_payflow> payFlow)
        {
            int num = 0;
            bool iscomplete = true;
            SqlTransaction tran = null;
            try
            {
                tran = SqlTransHelper.GetSqlTransaction();
                foreach (t_rm_payflow _payFlow in payFlow)
                {
                    SqlParameter[] parameters = { 
                        new SqlParameter("@flow_id", _payFlow.flow_id),
                        new SqlParameter("@flow_no", _payFlow.flow_no),
                        new SqlParameter("@sale_amount", _payFlow.sale_amount),
                        new SqlParameter("@branch_no", _payFlow.branch_no),
                        new SqlParameter("@pay_way", _payFlow.pay_way),
                        new SqlParameter("@sell_way", _payFlow.sell_way),
                        new SqlParameter("@card_no", _payFlow.card_no==null?"":_payFlow.card_no),
                        new SqlParameter("@vip_no", _payFlow.vip_no==null?"":_payFlow.vip_no),
                        new SqlParameter("@coin_no", _payFlow.coin_no),
                        new SqlParameter("@coin_rate", _payFlow.coin_rate),
                        new SqlParameter("@pay_amount", _payFlow.pay_amount),
                        new SqlParameter("@oper_date", _payFlow.oper_date),
                        new SqlParameter("@oper_id", _payFlow.oper_id),
                        new SqlParameter("@counter_no", "0001"),
                        new SqlParameter("@sale_man", "9999"),
                        new SqlParameter("@memo", _payFlow.memo),
                        new SqlParameter("@voucher_no", _payFlow.voucher_no==null?"":_payFlow.voucher_no),
                        new SqlParameter("@remote_flag", ""),
                        new SqlParameter("@exchange_flag", ""),
                        new SqlParameter("@shift_no", "0"),
                        new SqlParameter("@com_flag", ""),
                        new SqlParameter("@posid", _payFlow.posid==null?"":_payFlow.posid),
                        new SqlParameter("@uptime", _payFlow.uptime == null?DBNull.Value as object:_payFlow.uptime),
                        new SqlParameter("@is_jxc", "1"),
                        new SqlParameter("@real_date", _payFlow.oper_date)
                     };
                    num = SqlHelper.ExecteNonQuery(SqlTransHelper.conn, tran, CommandType.Text, this.GetSqlInsertPayFlow(), parameters);
                    if (num > 0)
                    {
                        if (_payFlow.saleFlowlList != null)
                        {
                            num = this.InsertSaleFlow(new List<t_rm_saleflow>(_payFlow.saleFlowlList), tran);
                            if (num <= 0)
                            {
                                iscomplete = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        iscomplete = false;
                        break;
                    }
                }
                if (iscomplete)
                {
                    tran.Commit();
                }
            }
            catch (Exception exception)
            {
                tran.Rollback();
                throw exception;
            }
            finally
            {
                SqlTransHelper.Close();
                if (tran != null)
                {
                    tran.Dispose();
                }
            }
            return num > 0 ? true : false;
        }
        private string GetSqlInsertPayFlow()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_rm_payflow");
            strSql.Append(" (flow_id,flow_no,sale_amount,branch_no,pay_way,sell_way,card_no,vip_no,coin_no,coin_rate,");
            strSql.Append(" pay_amount,oper_date,oper_id,counter_no,sale_man,memo,voucher_no,remote_flag,exchange_flag,");
            strSql.Append(" shift_no,com_flag,posid,uptime,is_jxc,real_date)");
            strSql.Append(" VALUES(@flow_id,@flow_no,@sale_amount,@branch_no,@pay_way,@sell_way,@card_no,@vip_no,@coin_no,@coin_rate,");
            strSql.Append(" @pay_amount,@oper_date,@oper_id,@counter_no,@sale_man,@memo,@voucher_no,@remote_flag,@exchange_flag,");
            strSql.Append(" @shift_no,@com_flag,@posid,@uptime,@is_jxc,@real_date)");
            return strSql.ToString();
        }
        #endregion
        #region 终端要货主信息
        /// <summary>
        /// 终端采购主信息
        /// </summary>
        /// <returns></returns>
        public string InPMSheetMaster(t_pm_sheet_master _sheetMaster)
        {

            int num;

            //总价格
            decimal? sheetAmt = 0;

            List<t_pm_sheet_detail> sheetDetail = new List<t_pm_sheet_detail>(_sheetMaster.detailList);
            foreach (t_pm_sheet_detail _sd in sheetDetail)
            {
                DataTable dt = (DataTable)this.GetItemInfo(_sd.item_no).Tables[0];
                sheetAmt = Convert.ToDecimal(dt.Rows[0]["price"].ToString()) * _sd.real_qty;
            }
            _sheetMaster.sheet_no = "YH" + _sheetMaster.branch_no + this.GetSheetMasterNo();
            SqlParameter[] parameters = { 
                    new SqlParameter("@sheet_no",  _sheetMaster.sheet_no),
                    new SqlParameter("@trans_no", "YH"),
                    new SqlParameter("@db_no", "+"),
                    new SqlParameter("@branch_no", _sheetMaster.branch_no),
                    new SqlParameter("@d_branch_no", _sheetMaster.d_branch_no),
                    new SqlParameter("@supcust_no", _sheetMaster.oper_id),
                    new SqlParameter("@approve_flag", '0'),
                    new SqlParameter("@oper_date", DateTime.Now),
                    new SqlParameter("@order_status", "0"),
                    new SqlParameter("@oper_id", _sheetMaster.oper_id),
                    new SqlParameter("@confirm_man", ""),
                    new SqlParameter("@sale_way", "A"),
                    new SqlParameter("@sheet_amt", sheetAmt),
                    new SqlParameter("@memo", "测试")
                };
            SqlTransaction tran = null;
            try
            {
                tran = SqlTransHelper.GetSqlTransaction();

                num = SqlHelper.ExecteNonQuery(SqlTransHelper.conn, tran, CommandType.Text, this.GetSqlInsertSheetMaster(), parameters);

                num = this.InsertSheetDetailList(new List<t_pm_sheet_detail>(_sheetMaster.detailList), _sheetMaster, tran);

            }
            catch (Exception exception)
            {
                tran.Rollback();
                SqlTransHelper.Close();
                tran.Dispose();
                throw exception;
            }
            tran.Commit();
            tran.Dispose();
            SqlTransHelper.Close();

            return _sheetMaster.sheet_no;
        }
        public string GetSheetMasterNo()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 sheet_no from t_pm_sheet_master where sheet_no like 'YH%' order by sheet_no desc");
            DataSet dt = SqlHelper.ExecuteDataSet(CommandType.Text, strSql.ToString(), null);
            string sheetMasterNo = dt.Tables[0].Rows[0][0].ToString().Trim();
            sheetMasterNo = (Convert.ToInt32(sheetMasterNo.Substring(sheetMasterNo.Length - 4)) + 1).ToString();
            if (sheetMasterNo.Length < 4)
            {
                for (int i = 0; sheetMasterNo.Length < 4; i++)
                {
                    sheetMasterNo = "0" + sheetMasterNo;
                }
            }
            sheetMasterNo = DateTime.Now.ToString("yyMMdd", DateTimeFormatInfo.InvariantInfo) + sheetMasterNo;
            return sheetMasterNo;
        }
        private string GetSqlInsertSheetMaster()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_pm_sheet_master (sheet_no,trans_no,db_no,branch_no,d_branch_no,supcust_no");
            strSql.Append("approve_flag,oper_date,order_status,oper_id,confirm_man,sale_way,sheet_amt,memo)");
            strSql.Append(" VALUES (@sheet_no,@trans_no,@db_no,@branch_no,@d_branch_no,@supcust_no,");
            strSql.Append(" @approve_flag,@oper_date,@order_status,@oper_id,@confirm_man,@sale_way,@sheet_amt,@memo)");
            return strSql.ToString();
        }
        #endregion
        #region 终端要货详细信息
        /// <summary>
        /// 销售列表
        /// </summary>
        /// <returns></returns>
        private int InsertSheetDetailList(List<t_pm_sheet_detail> sheetDetail, t_pm_sheet_master sheetMaster, SqlTransaction tran)
        {
            int num = 0;
            try
            {
                foreach (t_pm_sheet_detail _sheetDetail in sheetDetail)
                {
                    DataTable dt = (DataTable)this.GetItemInfo(_sheetDetail.item_no).Tables[0];
                    _sheetDetail.orgi_price = Convert.ToDecimal(dt.Rows[0]["price"].ToString());

                    SqlParameter[] parameters = { 
                        new SqlParameter("@sheet_no", sheetMaster.sheet_no),
                        new SqlParameter("@item_no", _sheetDetail.item_no),
                        new SqlParameter("@order_qty", _sheetDetail.real_qty),
                        new SqlParameter("@real_qty", _sheetDetail.real_qty),
                        new SqlParameter("@large_qty", _sheetDetail.large_qty),
                        new SqlParameter("@orgi_price", _sheetDetail.orgi_price),
                        new SqlParameter("@valid_price", "0.000"),
                        new SqlParameter("@tax", 0.17),
                        new SqlParameter("@valid_date", DateTime.Now),
                        new SqlParameter("@num3", "0.000")

                     };
                    num = SqlHelper.ExecteNonQuery(SqlTransHelper.conn, tran, CommandType.Text, this.GetSqlInsertSheetDetail(), parameters);
                }

            }
            catch (Exception exception)
            {
                throw exception;
            }
            return num;
        }
        private string GetSqlInsertSheetDetail()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into t_pm_sheet_detail (sheet_no,item_no,order_qty,real_qty,large_qty,");
            strSql.Append("orgi_price,valid_price,tax,valid_date,num3)");
            strSql.Append(" VALUES (@sheet_no,@item_no,@order_qty,@real_qty,@large_qty,");
            strSql.Append("@orgi_price,@valid_price,@tax,@valid_date,@num3)");
            return strSql.ToString();
        }
        #endregion

        #endregion

        #region POS机设置逻辑代码
        /// <summary>
        /// 获取POS机设置
        /// </summary>
        /// <returns></returns>
        public String GetSysPosSet()
        {
            String json = String.Empty;
            String sql = String.Empty;
            DataTable table = null;
            String errorMessage = String.Empty;
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr"].ToString().Trim();
            try
            {
                sql = "SELECT sys_var_id , sys_var_value from t_sys_pos_set";
                table = DBUtilitySqlServer.Instance.GetDataTable(connectionString, sql, null, ref errorMessage);
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("PosServiceLogger", "PosDal--->GetSysPosSet-->Error:" + errorMessage, LogEnum.ExceptionLog);
                }
                json = JsonUtility.Instance.DataTableToJson(table);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("PosServiceLogger", "PosDal--->GetSysPosSet-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return json;
        }
        #endregion

    }
}
