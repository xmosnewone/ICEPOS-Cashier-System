namespace ICE.POS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using ICE.Common;
    using ICE.Utility;
    using MySql.Data.MySqlClient;
    
    
    
    public class PosUploadServiceProvider
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static PosUploadServiceProvider _instance;
        
        
        
        private PosUploadServiceProvider()
        {

        }
        
        
        
        public static PosUploadServiceProvider Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new PosUploadServiceProvider();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        
        
        
        
        public object UploadFlow(string connectString, ref bool isok, DataTable payTable, DataTable saleTable)
        {
            object obj = null;
            try
            {
                isok = DbUtilityMySql.Instance.TestConnect(connectString);//检查数据库连接
                if (isok)//连接成功
                {
                    string sql = string.Empty;
                    string errorMessage = string.Empty;
                    List<SqlParaEntity> _sqlParaList = new List<SqlParaEntity>();
                    #region 支付流水
                    sql = "insert into t_pos_payflow(flow_id,flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,voucher_no,branch_no,pos_id,sale_way,com_flag)" +
                            "   values(@flow_id,@flow_no,@sale_amount,@pay_way ,@pay_amount,@coin_type,@pay_name,@coin_rate,@convert_amt,@card_no,@memo,@oper_date,@oper_id,@voucher_no,@branch_no,@pos_id,@sale_way,@com_flag)";
                    foreach (DataRow dr in payTable.Rows)
                    {
                        MySqlParameter[] parameters = new MySqlParameter[18];//vip_no,@vip_no
                        #region 参数定义
                        parameters[0] = new MySqlParameter("@flow_id", MySqlDbType.Int64);
                        parameters[0].Value = ExtendUtility.Instance.ParseToInt64(dr["flow_id"]);
                        parameters[1] = new MySqlParameter("@flow_no", MySqlDbType.VarChar);
                        parameters[1].Value = ExtendUtility.Instance.ParseToString(dr["flow_no"]);
                        parameters[2] = new MySqlParameter("@sale_amount", MySqlDbType.Decimal);
                        parameters[2].Value = ExtendUtility.Instance.ParseToDecimal(dr["sale_amount"]);
                        parameters[3] = new MySqlParameter("@pay_way", MySqlDbType.VarChar);
                        parameters[3].Value = ExtendUtility.Instance.ParseToString(dr["pay_way"]);
                        parameters[4] = new MySqlParameter("@pay_amount", MySqlDbType.Decimal);
                        parameters[4].Value = ExtendUtility.Instance.ParseToDecimal(dr["pay_amount"]);
                        parameters[5] = new MySqlParameter("@coin_type", MySqlDbType.VarChar);
                        parameters[5].Value = ExtendUtility.Instance.ParseToDecimal(dr["coin_type"]);
                        parameters[6] = new MySqlParameter("@pay_name", MySqlDbType.VarChar);
                        parameters[6].Value = ExtendUtility.Instance.ParseToString(dr["pay_name"]);
                        parameters[7] = new MySqlParameter("@coin_rate", MySqlDbType.Decimal);
                        parameters[7].Value = ExtendUtility.Instance.ParseToDecimal(dr["coin_rate"]);
                        parameters[8] = new MySqlParameter("@convert_amt", MySqlDbType.Decimal);
                        parameters[8].Value = ExtendUtility.Instance.ParseToDecimal(dr["convert_amt"]);
                        parameters[9] = new MySqlParameter("@card_no", MySqlDbType.VarChar);
                        parameters[9].Value = ExtendUtility.Instance.ParseToString(dr["card_no"]);
                        parameters[10] = new MySqlParameter("@memo", MySqlDbType.VarChar);
                        parameters[10].Value = ExtendUtility.Instance.ParseToString(dr["memo"]);
                        //parameters[11] = new MySqlParameter("@vip_no", MySqlDbType.VarChar);
                        //parameters[11].Value = ExtendUtility.Instance.ParseToString(dr["vip_no"]);
                        parameters[11] = new MySqlParameter("@oper_date", MySqlDbType.DateTime);
                        parameters[11].Value = ExtendUtility.Instance.ParseToDateTime(dr["oper_date"]);
                        parameters[12] = new MySqlParameter("@oper_id", MySqlDbType.VarChar);
                        parameters[12].Value = ExtendUtility.Instance.ParseToString(dr["oper_id"]);
                        parameters[13] = new MySqlParameter("@voucher_no", MySqlDbType.VarChar);
                        parameters[13].Value = ExtendUtility.Instance.ParseToString(dr["voucher_no"]);
                        parameters[14] = new MySqlParameter("@branch_no", MySqlDbType.VarChar);
                        parameters[14].Value = ExtendUtility.Instance.ParseToString(dr["branch_no"]);
                        parameters[15] = new MySqlParameter("@pos_id", MySqlDbType.VarChar);
                        parameters[15].Value = ExtendUtility.Instance.ParseToString(dr["pos_id"]);
                        parameters[16] = new MySqlParameter("@sale_way", MySqlDbType.VarChar);
                        parameters[16].Value = ExtendUtility.Instance.ParseToString(dr["sale_way"]);
                        parameters[17] = new MySqlParameter("@com_flag", MySqlDbType.VarChar);
                        parameters[17].Value = "1";
                        
                        #endregion
                        SqlParaEntity _sqlPara = new SqlParaEntity()
                        {
                            Sql = sql,
                            parameters = parameters
                        };
                        _sqlParaList.Add(_sqlPara);
                    }
                    #endregion
                    #region 销售流水
                    sql = "insert into t_pos_saleflow(flow_id,flow_no,item_no,sale_price,sale_qnty,sale_money,in_price,sell_way,discount_rate,oper_id,oper_date,reasonid,branch_no,pos_id,com_flag,unit_price,plan_no,item_clsno,item_brand)" +//item_subno,item_clsno,item_name,item_status,item_subname,
                           "   values(@flow_id,@flow_no,@item_no,@sale_price,@sale_qnty,@sale_money,@in_price,@sell_way,@discount_rate,@oper_id,@oper_date,@reasonid,@branch_no,@pos_id,@com_flag,@unit_price,@plan_no,@item_clsno,@item_brand)";//@item_subno,@item_clsno,@item_name,@item_status,@item_subname,

                    foreach (DataRow dr in saleTable.Rows)
                    {
                        MySqlParameter[] parameters = new MySqlParameter[19];//in_price,@in_price,unit_price,@unit_price,
                        #region 参数定义
                        parameters[0] = new MySqlParameter("@flow_id", MySqlDbType.Int64);
                        parameters[0].Value = ExtendUtility.Instance.ParseToInt64(dr["flow_id"]);
                        parameters[1] = new MySqlParameter("@flow_no", MySqlDbType.VarChar);
                        parameters[1].Value = ExtendUtility.Instance.ParseToString(dr["flow_no"]);
                        parameters[2] = new MySqlParameter("@item_no", MySqlDbType.VarChar);
                        parameters[2].Value = ExtendUtility.Instance.ParseToString(dr["item_no"]);
                        parameters[3] = new MySqlParameter("@sale_price", MySqlDbType.Decimal);
                        parameters[3].Value = ExtendUtility.Instance.ParseToDecimal(dr["unit_price"]);
                        parameters[4] = new MySqlParameter("@sale_qnty", MySqlDbType.Decimal);
                        parameters[4].Value = ExtendUtility.Instance.ParseToDecimal(dr["sale_qnty"]);
                        parameters[5] = new MySqlParameter("@sale_money", MySqlDbType.Decimal);
                        parameters[5].Value = ExtendUtility.Instance.ParseToDecimal(dr["sale_money"]);
                        parameters[6] = new MySqlParameter("@in_price", MySqlDbType.Decimal);
                        parameters[6].Value = ExtendUtility.Instance.ParseToDecimal(dr["price"]);
                        parameters[7] = new MySqlParameter("@sell_way", MySqlDbType.VarChar);
                        parameters[7].Value = ExtendUtility.Instance.ParseToString(dr["sale_way"]);
                        parameters[8] = new MySqlParameter("@discount_rate", MySqlDbType.Decimal);
                        parameters[8].Value = ExtendUtility.Instance.ParseToDecimal(dr["discount_rate"]);
                        parameters[9] = new MySqlParameter("@oper_id", MySqlDbType.VarChar);
                        parameters[9].Value = ExtendUtility.Instance.ParseToString(dr["oper_id"]);
                        parameters[10] = new MySqlParameter("@oper_date", MySqlDbType.DateTime);
                        parameters[10].Value = ExtendUtility.Instance.ParseToDateTime(dr["oper_date"]);
                        parameters[11] = new MySqlParameter("@reasonid", MySqlDbType.Int32);
                        parameters[11].Value = ExtendUtility.Instance.ParseToInt32(dr["reasonid"]);
                        parameters[12] = new MySqlParameter("@branch_no", MySqlDbType.VarChar);
                        parameters[12].Value = ExtendUtility.Instance.ParseToString(dr["branch_no"]);
                        parameters[13] = new MySqlParameter("@pos_id", MySqlDbType.VarChar);
                        parameters[13].Value = ExtendUtility.Instance.ParseToString(dr["pos_id"]);
                        parameters[14] = new MySqlParameter("@com_flag", MySqlDbType.VarChar);
                        parameters[14].Value = "1";
                        parameters[15] = new MySqlParameter("@unit_price", MySqlDbType.Decimal);
                        parameters[15].Value = ExtendUtility.Instance.ParseToInt32(dr["sale_price"]);
                        parameters[16] = new MySqlParameter("@plan_no", MySqlDbType.VarChar);
                        parameters[16].Value = ExtendUtility.Instance.ParseToString(dr["plan_no"]);
                        parameters[17] = new MySqlParameter("@item_clsno", MySqlDbType.VarChar);
                        parameters[17].Value = ExtendUtility.Instance.ParseToString(dr["item_clsno"]);
                        parameters[18] = new MySqlParameter("@item_brand", MySqlDbType.VarChar);
                        parameters[18].Value = ExtendUtility.Instance.ParseToString(dr["item_brand"]);
                        #endregion
                        SqlParaEntity _sqlPara = new SqlParaEntity()
                        {
                            Sql = sql,
                            parameters = parameters
                        };
                        _sqlParaList.Add(_sqlPara);
                    }
                    #endregion
                    if (DbUtilityMySql.Instance.ExecuteSqlsByTrans(connectString, _sqlParaList, ref errorMessage) > 0)
                    {
                        obj = true;
                    }
                    else
                    {
                        obj = false;
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Common->PosUploadServiceProvider-->UploadFlow--->" + ex.ToString(), LogEnum.ExceptionLog);
                obj = null;
                isok = false;
            }
            return obj;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        public DataTable SearchMaster(string connectString, ref bool isok, string branch_no, string trans_no, string start, string end, string sheet_no, string approve_flag)
        {
            DataTable table = null;
            try
            {
                isok = DbUtilityMySql.Instance.TestConnect(connectString);//检查数据库连接
                string sql = string.Empty;
                StringBuilder sb = new StringBuilder();
                string errorMessage = string.Empty;
                if (isok)//数据库连接成功
                {
                    if (trans_no == "YH")//要货申请单
                    {

                        sb.AppendLine(" select s.sheet_no as sheet_no,s.branch_no,a.branch_name as branch_name,s.d_branch_no,b.branch_name as d_branch_name,s.oper_id as oper_id,s.oper_date as oper_date,");
                        sb.AppendLine("    case s.approve_flag when '1' then '已审核' else '未审核' end as approve_name,s.confirm_man,s.valid_date,s.memo,s.approve_flag,c.oper_name from t_pm_sheet_master s");
                        sb.AppendLine("    left join t_pos_branch_info a on s.branch_no=a.branch_no");
                        sb.AppendLine("    left join t_pos_operator c on s.oper_id=c.oper_id");
                        sb.AppendLine("    left join t_pos_branch_info b on s.d_branch_no=b.branch_no   where ");
                        sb.AppendLine(" s.oper_date>'" + start + "'  and");
                        sb.AppendLine(" s.oper_date<'" + end + "'    and");
                        if (approve_flag != "-1")
                        {
                            sb.AppendLine(" s.approve_flag='" + approve_flag + "'    and");
                        }
                        sb.AppendLine(" s.trans_no='YH' and");
                        sb.AppendLine(" s.d_branch_no='" + branch_no + "'  ");
                        if (sheet_no.Length > 0)
                        {
                            sb.AppendLine(" and s.sheet_no like '%" + sheet_no + "%'");
                        }
                        if (sb.ToString().Length > 0)
                        {
                            table = DbUtilityMySql.Instance.GetDataTable(connectString, sb.ToString(), null, ref errorMessage);
                        }
                    }
                    else if (trans_no == "MO")//直调出库单
                    {
                        //TODO:直调出库单咱不实现
                    }
                }
            }
            catch (Exception ex)
            {
                isok = false;
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Common->PosUploadServiceProvider-->SearchMaster--->" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        
        
        
        
        
        
        
        
        public DataTable SearchDetail(string connectString, ref bool isok, string sheet_no, string trans_no)
        {
            DataTable table = null;
            try
            {
                isok = DbUtilityMySql.Instance.TestConnect(connectString);//检查数据库连接
                string sql = string.Empty;
                StringBuilder sb = new StringBuilder();
                string errorMessage = string.Empty;
                if (isok)//数据库连接成功
                {
                    if (trans_no == "YH")//要货申请单
                    {
                        sb.AppendLine("select s.sheet_no,s.item_no,a.item_subno,a.item_name,a.item_size,a.unit_no,s.real_qty,s.other1 from t_pm_sheet_detail s");
                        sb.AppendLine("left join t_bd_item_info a on s.item_no=a.item_no");
                        sb.AppendLine(" where s.sheet_no='" + sheet_no + "'");
                        table = DbUtilityMySql.Instance.GetDataTable(connectString, sb.ToString(), null, ref errorMessage);
                    }
                    else if (trans_no == "MO")//直调出库单
                    {
                        //TODO:直调出库单咱不实现
                    }
                }
            }
            catch (Exception ex)
            {
                isok = false;
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Common->PosUploadServiceProvider-->SearchDetail--->" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public bool AddOrUpdateSheet(string connectString, ref bool isok, ref string sheet_no, string trans_no, string branch_no, string d_branch_no, string oper_id, string valid_date, decimal sheet_amt,
            DataTable details,string memo)
        {
            bool isok1 = true;
            string sql = string.Empty;
            List<SqlParaEntity> _sqlParaList = null;
            string errorMessage = string.Empty;
            try
            {
                _sqlParaList = new List<SqlParaEntity>();
                if (trans_no == "YH")
                {
                    if (sheet_no.Length > 0)//编辑操作
                    {
                        sql = "update t_pm_sheet_master set branch_no=@branch_no,d_branch_no=@d_branch_no,valid_date=@valid_date,oper_id=@oper_id,sheet_amt=@sheet_amt,oper_date=@oper_date,memo=@memo" +
                                "   where sheet_no=@sheet_no ";
                        MySqlParameter[] parameters = new MySqlParameter[8];
                        #region 准备操作主表的参数
                        parameters[0] = new MySqlParameter("@sheet_no", MySqlDbType.VarChar);
                        parameters[0].Value = sheet_no;
                        parameters[1] = new MySqlParameter("@branch_no", MySqlDbType.VarChar);
                        parameters[1].Value = branch_no;
                        parameters[2] = new MySqlParameter("@d_branch_no", MySqlDbType.VarChar);
                        parameters[2].Value = d_branch_no;
                        parameters[3] = new MySqlParameter("@valid_date", MySqlDbType.VarChar);
                        parameters[3].Value = valid_date;
                        parameters[4] = new MySqlParameter("@oper_id", MySqlDbType.VarChar);
                        parameters[4].Value = oper_id;
                        parameters[5] = new MySqlParameter("@sheet_amt", MySqlDbType.Decimal);
                        parameters[5].Value = sheet_amt;
                        parameters[6] = new MySqlParameter("@oper_date", MySqlDbType.VarChar);
                        parameters[6].Value = System.DateTime.Now.ToString();
                        parameters[7] = new MySqlParameter("@memo", MySqlDbType.VarChar);
                        parameters[7].Value = memo;
                        #endregion
                        SqlParaEntity _sqlPara = new SqlParaEntity();
                        _sqlPara.Sql = sql;
                        _sqlPara.parameters = parameters;
                        _sqlParaList.Add(_sqlPara);
                        sql = "delete  from  t_pm_sheet_detail where sheet_no=@sheet_no";
                        parameters = new MySqlParameter[1];
                        parameters[0] = new MySqlParameter("@sheet_no", MySqlDbType.VarChar);
                        parameters[0].Value = sheet_no;
                        _sqlPara = new SqlParaEntity();
                        _sqlPara.Sql = sql;
                        _sqlPara.parameters = parameters;
                        _sqlParaList.Add(_sqlPara);
                    }
                    else//新增操作
                    {
                        sheet_no = GetSheetNo(connectString, trans_no, d_branch_no);
                        if (sheet_no.Length > 0)
                        {
                            sql = "insert into t_pm_sheet_master(sheet_no,trans_no,branch_no,d_branch_no,valid_date,oper_id,sheet_amt,oper_date,memo)" +
                                "   values(@sheet_no,@trans_no,@branch_no,@d_branch_no,@valid_date,@oper_id,@sheet_amt,@oper_date,@memo)";
                            MySqlParameter[] parameters = new MySqlParameter[9];
                            #region 准备操作主表的参数
                            parameters[0] = new MySqlParameter("@sheet_no", MySqlDbType.VarChar);
                            parameters[0].Value = sheet_no;
                            parameters[1] = new MySqlParameter("@trans_no", MySqlDbType.VarChar);
                            parameters[1].Value = trans_no;
                            parameters[2] = new MySqlParameter("@branch_no", MySqlDbType.VarChar);
                            parameters[2].Value = branch_no;
                            parameters[3] = new MySqlParameter("@d_branch_no", MySqlDbType.VarChar);
                            parameters[3].Value = d_branch_no;
                            parameters[4] = new MySqlParameter("@valid_date", MySqlDbType.VarChar);
                            parameters[4].Value = valid_date;
                            parameters[5] = new MySqlParameter("@oper_id", MySqlDbType.VarChar);
                            parameters[5].Value = oper_id;
                            parameters[6] = new MySqlParameter("@sheet_amt", MySqlDbType.Decimal);
                            parameters[6].Value = sheet_amt;
                            parameters[7] = new MySqlParameter("@oper_date", MySqlDbType.VarChar);
                            parameters[7].Value = System.DateTime.Now.ToString();
                            parameters[8] = new MySqlParameter("@memo", MySqlDbType.VarChar);
                            parameters[8].Value = memo;
                            #endregion
                            SqlParaEntity _sqlPara = new SqlParaEntity();
                            _sqlPara.Sql = sql;
                            _sqlPara.parameters = parameters;
                            _sqlParaList.Add(_sqlPara);

                            sql = "";
                        }
                        else
                        {
                            isok1 = false;
                        }
                    }
                    #region 插入明细数据
                    if (isok1)
                    {
                        sql = "insert into t_pm_sheet_detail(sheet_no,item_no,real_qty,other1) values(@sheet_no,@item_no,@real_qty,@other1)";
                        foreach (DataRow dr in details.Rows)
                        {
                            MySqlParameter[] parameters = new MySqlParameter[4];
                            parameters[0] = new MySqlParameter("@sheet_no", MySqlDbType.VarChar);
                            parameters[0].Value = sheet_no;
                            parameters[1] = new MySqlParameter("@item_no", MySqlDbType.VarChar);
                            parameters[1].Value = ExtendUtility.Instance.ParseToString(dr["item_no"]);
                            parameters[2] = new MySqlParameter("@real_qty", MySqlDbType.Decimal);
                            parameters[2].Value = ExtendUtility.Instance.ParseToDecimal(dr["real_qty"]);
                            parameters[3] = new MySqlParameter("@other1", MySqlDbType.VarChar);
                            parameters[3].Value = ExtendUtility.Instance.ParseToString(dr["other1"]);
                            SqlParaEntity _sqlPara = new SqlParaEntity();
                            _sqlPara.Sql = sql;
                            _sqlPara.parameters = parameters;
                            _sqlParaList.Add(_sqlPara);
                        }
                        isok1 = DbUtilityMySql.Instance.ExecuteSqlsByTrans(connectString, _sqlParaList, ref errorMessage) > 0 ? true : false;
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                isok1 = false;
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Common->PosUploadServiceProvider-->GetSheetNo--->" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok1;
        }
        
        
        
        
        
        
        
        private string GetSheetNo(string connectString, string trans_no, string branch_no)
        {
            string sheet_no = string.Empty;
            string errorMessage = string.Empty;
            bool isok = true;
            try
            {
                string sql = "select sheet_value from t_sys_sheet_no where date(sheet_date)=date('{0}') and sheet_id='{1}'";
                sql = string.Format(sql, System.DateTime.Now.ToString(GobalStaticString.DATE_FORMAT), trans_no);
                object result = DbUtilityMySql.Instance.GetSingleData(connectString, sql, null, ref errorMessage);
                if (result == null)//当前天没有数据 则需要更新
                {
                    sql = "update t_sys_sheet_no set sheet_date='{0}' where sheet_id='{1}'";
                    sql = string.Format(sql, System.DateTime.Now.ToString(GobalStaticString.DATE_FORMAT), trans_no);
                    isok = DbUtilityMySql.Instance.ExecuteSql(connectString, sql, null, ref errorMessage) > 0 ? true : false;
                }
                int temp_no = ExtendUtility.Instance.ParseToInt32(result);
                if (temp_no >= 9999)
                {
                    temp_no = 0;
                }
                temp_no = temp_no + 1;
                if (isok)
                {
                    sql = "update t_sys_sheet_no set sheet_value={0} where sheet_id='{1}'";
                    sql = string.Format(sql, temp_no, trans_no);
                }
                isok = DbUtilityMySql.Instance.ExecuteSql(connectString, sql, null, ref errorMessage) > 0 ? true : false;
                if (isok)
                {
                    sheet_no = string.Format("{0}{1}{2}{3}", trans_no, branch_no, System.DateTime.Now.ToString("yyMMdd"), temp_no.ToString().PadLeft(4, '0'));
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Common->PosUploadServiceProvider-->GetSheetNo--->" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return sheet_no;
        }
        #endregion
    }
}
