/********************************************************
 * Description:POS机下载数据服务
 * ******************************************************/
namespace ICE.POS.Common
{
    using System;
    using ICE.Utility;
    
    
    
    public class PosDownServiceProvider
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static PosDownServiceProvider _instance;
        
        
        
        private PosDownServiceProvider()
        {

        }
        
        public static PosDownServiceProvider Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new PosDownServiceProvider();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        public object InvokeService(string connectString, string mark, ref bool isok, string branch_no, string item_no,
            decimal order_qty, string db_no)
        {
            object obj = null;
            try
            {
                isok = DbUtilityMySql.Instance.TestConnect(connectString);//检查数据库连接
                if (isok)//连接成功
                {
                    string sql = string.Empty;
                    string errorMessage = string.Empty;
                    switch (mark)
                    {
                        case "GetBranchList"://门店信息
                            sql = "select * from t_pos_branch_info";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetItemClsList"://商品分类信息
                            sql = "select * from t_bd_item_cls";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetBarCodeList"://BarCode列表信息
                            sql = "select * from t_bd_item_barcode";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetItemList"://商品信息
                            sql = "select * from t_bd_item_info";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetBaseCodeType"://基础代码分类信息
                            sql = "select * from t_bd_basecode_type";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetBaseCodeInfo"://基础代码
                            sql = "select * from t_bd_base_code";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetCashierList"://操作员信息
                            sql = "select * from t_pos_operator";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetItemStock"://获取门店库存信息
                            sql = "select s.branch_no,s.item_no,a.item_name,a.item_size,s.stock_qty,b.item_clsname,c.code_name from t_pos_branch_stock s" +
                                "   left join t_bd_item_info as a on s.item_no=a.item_no" +
                                "   left join t_bd_item_cls as b on a.item_clsno=b.item_clsno" +
                                "   left join t_bd_base_code as c on a.item_brand=c.code_id" +
                                " where s.branch_no='{0}' and c.type_no='PP'";
                            sql = string.Format(sql, branch_no);
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "UpdateItemStock"://更新库存
                            if (db_no == "-")
                            {
                                sql = "update t_pos_branch_stock set stock_qty=stock_qty-{0},oper_date='{3}' where branch_no='{1}' and item_no='{2}'";
                            }
                            else
                            {
                                sql = "update t_pos_branch_stock set stock_qty=stock_qty+{0},oper_date='{3}' where branch_no='{1}' and item_no='{2}'";
                            }
                            sql = string.Format(sql, order_qty, branch_no, item_no, System.DateTime.Now.ToString());
                            obj = DbUtilityMySql.Instance.ExecuteSql(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetPaymentInfo"://支付方式
                            sql = "select * from t_bd_payment_info";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetFunction"://快捷键
                            sql = "select * from t_pos_function where branch_no='{0}'";
                            sql = string.Format(sql, branch_no);
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetPosStatus"://获取Pos状态
                            sql = "select * from t_pos_status where branch_no='{0}'";
                            sql = string.Format(sql, branch_no);
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        //case "GetPosSet"://POS机配置
                        //    break;
                        case "GetItemPrice"://获取门店商品售价
                            sql = "select branch_no,item_no,price,sale_price,vip_price from t_pc_branch_price where branch_no='{0}'";
                            sql = string.Format(sql, branch_no);
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetPlanRule":
                            sql = "select rule_no,range_flag,rule_describe,rule_condition,rule_result,plu_flag from t_pos_plan_rule";
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetPlanMaster":
                            sql = "select m.plan_no,m.plan_name,m.plan_memo,m.begin_date,m.end_date," +
                                "   m.week,m.vip_type,m.oper_date,m.oper_man,m.confirm_date," +
                                "   m.confirm_man,m.stop_date,m.stop_man,m.approve_flag,m.rule_no,m.range_flag " +
                                "   from  t_pos_plan_master m "+
                                "   left join t_pos_plan_branch b on m.plan_no=b.plan_no"+
                                "   where b.branch_no='{0}' and m.approve_flag='1'";
                            sql = string.Format(sql, branch_no);
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        case "GetPlanDetail":
                            sql = "select d.plan_no,d.row_id,d.rule_para,d.rule_val "+
                                "   from t_pos_plan_detail d"+
                                "   left join t_pos_plan_branch b on d.plan_no=b.plan_no "+
                                "   where b.branch_no='{0}'";
                            sql = string.Format(sql, branch_no);
                            obj = DbUtilityMySql.Instance.GetDataTable(connectString, sql, null, ref errorMessage);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Common->PosDownServiceProvider-->InvokeService--->" + mark + ":" + ex.ToString(), LogEnum.ExceptionLog);
                obj = null;
                isok = false;
            }
            return obj;
        }
        #endregion
    }
}
