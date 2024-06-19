/********************************************************
 * Author:xmos
 * Description:POS机数据访问逻辑
 * ******************************************************/
namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using ICE.Common;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    public class PosDal : DalBase
    {
        #region 获取商品大类列表
        
        public DataTable GetBigClsPage(string clsNo, int pageSize, bool isNextPages)
        {
            string sql = "select typeno,typename from t_product_food_type where parent IS NULL or length(rtrim(ltrim(parent)))=0";
            DataTable data = base.dbPosItem.GetData(sql);
            if (data.Rows.Count == 0)
            {
                return data;
            }
            int num = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (SIString.TryStr(data.Rows[i]["typeno"]).Trim() == SIString.TryStr(clsNo).Trim())
                {
                    num = i;
                    break;
                }
            }
            if (isNextPages)
            {
                if ((SIString.TryStr(clsNo).Trim() == string.Empty) || (num == 0))
                {
                    return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
                }
                //重新设置数据
                DataTable table2 = data.Clone();
                for (int k = num + 1; k < ((num + 1) + pageSize); k++)
                {
                    if (data.Rows.Count > k)
                    {
                        table2.ImportRow(data.Rows[k]);
                    }
                }
                int t = table2.Rows.Count;
                return table2;

            }
            DataTable table3 = data.Clone();
            if (((num + 1) - pageSize) < 0)
            {
                return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
            }
            for (int j = num - pageSize; j < num; j++)
            {
                if ((data.Rows.Count > j) && (j >= 0))
                {
                    table3.ImportRow(data.Rows[j]);
                }
            }
            return table3;
        }
        #endregion

        #region 获取商品小类列表
        public DataTable GetClsPage(string clsBigNo, string clsNo, int pageSize, bool isNextPage)
        {
            string sql = "select typeno,typename from t_product_food_type where parent like '" + SIString.TryStr(clsBigNo).Trim() + "%' order by typeno asc ";
            DataTable data = base.dbPosItem.GetData(sql);
            if (data.Rows.Count == 0)
            {
                return data;
            }
            int num = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (SIString.TryStr(data.Rows[i]["typeno"]).Trim() == SIString.TryStr(clsNo).Trim())
                {
                    num = i;
                    break;
                }
            }
            if (isNextPage)
            {
                if ((SIString.TryStr(clsNo).Trim() == string.Empty) || (num == 0))
                {
                    return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
                }
                DataTable table2 = data.Clone();
                for (int k = num + 1; k < ((num + 1) + pageSize); k++)
                {
                    if (data.Rows.Count > k)
                    {
                        table2.ImportRow(data.Rows[k]);
                    }
                }
                return table2;
            }
            if ((SIString.TryStr(clsNo).Trim() == string.Empty) || (num == 0))
            {
                return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
            }
            DataTable table3 = data.Clone();
            if (((num + 1) - pageSize) < 0)
            {
                return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
            }
            for (int j = num - pageSize; j < num; j++)
            {
                if ((data.Rows.Count > j) && (j >= 0))
                {
                    table3.ImportRow(data.Rows[j]);
                }
            }
            return table3;
        }
        #endregion

        #region 获取商品列表
        public DataTable GetItemPage(string clsNo, string itemNo, int pageSize, bool isNextPage)
        {
            string sql = " select item_no,item_name from t_product_food where item_clsno like '" + SIString.TryStr(clsNo).Trim() + "%' order by item_no asc ";
            DataTable data = base.dbPosItem.GetData(sql);
            if (data.Rows.Count == 0)
            {
                return data;
            }
            int num = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (SIString.TryStr(data.Rows[i]["item_no"]).Trim() == SIString.TryStr(itemNo).Trim())
                {
                    num = i;
                    break;
                }
            }
            if (isNextPage)
            {
                if ((SIString.TryStr(itemNo).Trim() == string.Empty) || (num == 0))
                {
                    return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
                }
                DataTable table2 = data.Clone();
                for (int k = num + 1; k < ((num + 1) + pageSize); k++)
                {
                    if (data.Rows.Count > k)
                    {
                        table2.ImportRow(data.Rows[k]);
                    }
                }
                return table2;
            }
            if ((SIString.TryStr(itemNo).Trim() == string.Empty) || (num == 0))
            {
                return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
            }
            DataTable table3 = data.Clone();
            if (((num + 1) - pageSize) < 0)
            {
                return base.dbPosItem.GetData(sql + " limit " + pageSize.ToString());
            }
            for (int j = num - pageSize; j < num; j++)
            {
                if ((data.Rows.Count > j) && (j >= 0))
                {
                    table3.ImportRow(data.Rows[j]);
                }
            }
            return table3;
        }
        #endregion

        #region 查询某个小类下面的商品数量
        
        
        
        
        
        public int GetClsItemCount(string clsNo)
        {
            string strsql = "select count(1) from t_product_food where item_clsno like '" + SIString.TryStr(clsNo).Trim() + "%' order by item_no asc ";
            return SIString.TryInt(base.dbPosItem.GetObjectSingle(strsql));
        }
        #endregion

        #region 获取单个商品信息
        
        
        
        
        
        public t_cur_saleflow GetItemInfo(string itemNo)
        {
            t_cur_saleflow _saleflow = null;
            string sql = "select * from t_product_food where item_no='" + itemNo + "'";
            SQLiteDataReader reader = base.dbPosItem.QueryReader(sql, new SQLiteParameter[] { new SQLiteParameter("@itemNo", itemNo.Trim()) });
            if (!reader.Read())
            {
                reader.Close();
                // return _saleflow;
            }
            else
            {
                //string strItemNo = reader["item_no"].ToString().Trim();
                //string strItemName = reader["item_name"].ToString().Trim();
                //decimal decPrice = Convert.ToDecimal(reader["price"]);
                //decimal decUnitPrice = Convert.ToDecimal(reader["sale_price1"]); //单价
                //decimal decSalePrice = Convert.ToDecimal(reader["sale_price"]); //原价
                //DateTime operDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                //string strItemSubNo = reader["item_subno"].ToString().Trim();
                //string strItemClsNo = reader["item_clsno"].ToString().Trim();
                //string strItemStatus = reader["status"].ToString().Trim();
                //string strItemSubName = reader["item_subname"].ToString().Trim();
                //string strLastItemName = Gfunc.ItemNameFormat(strItemNo, strItemName);
                //_saleflow = new t_cur_saleflow
                //{
                //    item_no = strItemNo,
                //    item_name = strItemName,
                //    oper_date = operDate,
                //    unit_price = decUnitPrice,
                //    sale_price = decSalePrice,
                //    sale_money = decUnitPrice, //默认等于单价
                //    item_subno = strItemSubNo,
                //    item_clsno = strItemClsNo,
                //    item_status = strItemStatus,
                //    item_subname = strItemSubName,
                //    last_item_name = strLastItemName,
                //    num3 = Convert.ToDecimal(reader["num3"])
                //};

                string strItemNo = ExtendUtility.Instance.ParseToString(reader["item_no"]).Trim();
                string strItemName = ExtendUtility.Instance.ParseToString(reader["item_name"]).Trim();
                decimal decPrice = ExtendUtility.Instance.ParseToDecimal(reader["price"]);
                decimal decUnitPrice = ExtendUtility.Instance.ParseToDecimal(reader["sale_price1"]);
                decimal decSalePrice = ExtendUtility.Instance.ParseToDecimal(reader["sale_price"]);
                DateTime operDate = DateTime.Now;// ExtendUtility.Instance.ParseToDateTime(DateTime.Now.ToString(GobalStaticString.DATE_FORMAT));
                string strItemSubNo = ExtendUtility.Instance.ParseToString(reader["item_subno"]).Trim();
                string strItemClsNo = ExtendUtility.Instance.ParseToString(reader["item_clsno"]).Trim();
                string strItemStatus = ExtendUtility.Instance.ParseToString(reader["status"]).Trim();
                string strItemSubName = ExtendUtility.Instance.ParseToString(reader["item_subname"]).Trim();
                string strLastItemName = Gfunc.ItemNameFormat(strItemNo, strItemName);

                _saleflow = new t_cur_saleflow
                {
                    item_no = strItemNo,
                    item_name = strItemName,
                    oper_date = ExtendUtility.Instance.ParseToDateTime(operDate).ToString("s"),
                    price = decPrice,
                    unit_price = decSalePrice,//单价和销售价格相同
                    sale_price = decSalePrice,
                    sale_money = decSalePrice, //默认等于单价
                    item_subno = strItemSubNo,
                    item_clsno = strItemClsNo,
                    item_status = strItemStatus,
                    item_subname = strItemSubName,
                    last_item_name = strLastItemName,
                    num3 = ExtendUtility.Instance.ParseToDecimal(reader["num3"]),
                    item_brand = ExtendUtility.Instance.ParseToString(reader["item_brand"]),
                    change_price = ExtendUtility.Instance.ParseToString(reader["change_price"]),
                    scheme_price = ExtendUtility.Instance.ParseToString(reader["scheme_price"]),
                    vip_acc_flag = ExtendUtility.Instance.ParseToString(reader["vip_acc_flag"]),
                    vip_acc_num = ExtendUtility.Instance.ParseToDecimal(reader["vip_acc_num"])
                };
            }
            if (_saleflow == null)
            {
                _saleflow = GetItemInfoByBarcode(itemNo);
            }
            return _saleflow;
        }





        #endregion

        #region 获取单个商品消息返回t_item_info实体
        
        
        
        
        
        public List<t_item_info> GetItemInfoNew(string itemNo)
        {
            List<t_item_info> _itemInfoList = null;
            StringBuilder sql = new StringBuilder("select * from t_product_food");
            SQLiteDataReader reader = null;
            try
            {
                if (itemNo.Trim() != "")
                {
                    sql.Append(" where item_no like @itemNo or item_subno like @itemNo or item_name like @itemNo or item_clsno like @itemNo or item_brand like @itemNo");

                    reader = base.dbPosItem.QueryReader(sql.ToString(), new SQLiteParameter[] { 
                       new SQLiteParameter("@itemNo", "%" + itemNo.Trim() + "%")
                    });
                }
                else
                {
                    reader = base.dbPosItem.QueryReader(sql.ToString());
                }
                _itemInfoList = new List<t_item_info>();
                while (reader.Read())
                {
                    t_item_info _itemInfo = new t_item_info
                    {
                        item_no = reader["item_no"].ToString().Trim(),
                        item_subno = reader["item_subno"].ToString().Trim(),
                        item_name = reader["item_name"].ToString().Trim(),
                        //_itemInfo.item_rem = reader["item_rem"].ToString().Trim(),
                        item_subname = reader["item_subname"].ToString().Trim(),
                        item_clsno = reader["item_clsno"].ToString().Trim(),
                        item_size = reader["item_size"].ToString().Trim(),
                        main_supcust = reader["main_supcust"].ToString().Trim(),
                        unit_no = reader["unit_no"].ToString().Trim(),
                        sale_price = Math.Round(Convert.ToDecimal(reader["sale_price"]), Convert.ToInt32(Gattr.PosSalePrcPointF.Substring(1, 1))),
                        product_area = reader["product_area"].ToString().Trim()
                        //_itemInfo.vip_price = Math.Round(Convert.ToDecimal(reader["vip_price"]), Convert.ToInt32(Gattr.PosSalePrcPointF.Substring(1, 1))),
                        //_itemInfo.base_price = Math.Round(Convert.ToDecimal(reader["base_price"]), Convert.ToInt32(Gattr.PosSalePrcPointF.Substring(1, 1)))
                        //measure_flag = reader["measure_flag"].ToString().Trim(),
                        //sale_flag = SIString.TryStr(reader["sale_flag"]).Trim(),
                        //purchase_spec = SIString.TryStr(reader["purchase_spec"]).Trim(),
                        //valid_days = SIString.TryDec(reader["valid_days"])
                    };
                    _itemInfoList.Add(_itemInfo);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return _itemInfoList;
        }
        #endregion

        #region 自定义快捷键
        
        
        
        
        
        public Dictionary<string, t_attr_function> GetFuncKeys(bool isAll)
        {
            Dictionary<string, t_attr_function> dictionary = new Dictionary<string, t_attr_function>();
            t_attr_function _function = null;
            string str = null;
            string sql = string.Empty;
            sql = "select pos_key, func_id, func_name,type from t_attr_function where type=1 order by type asc";
            try
            {
                SQLiteDataReader reader = base.dbPosItem.QueryReader(sql);
                while (reader.Read())
                {
                    _function = new t_attr_function
                    {
                        pos_key = reader["pos_key"].ToString().Trim().ToLower(),
                        func_id = reader["func_id"].ToString().Trim(),
                        func_name = reader["func_name"].ToString().Trim()
                    };
                    str = reader["type"].ToString().Trim();
                    if (str.Length > 0)
                    {
                        _function.type = str.ToCharArray()[0];
                    }
                    if (!dictionary.ContainsKey(_function.pos_key.ToLower()))
                    {
                        dictionary.Add(_function.pos_key.ToLower(), _function);
                    }
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            return dictionary;
        }
        #endregion

        #region 保存销售商品数据
        
        
        
        
        private string GetSqlInsertTempSaleRow()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Insert into t_cur_saleflow(flow_id,flow_no,item_no,unit_price,sale_price,sale_qnty,sale_money,discount_rate,oper_id,oper_date,item_subno,item_clsno,item_name,item_status,item_subname,branch_no,pos_id,plan_no,item_brand,vip_acc_flag)");
            builder.Append("values(@flow_id,@flow_no,@item_no,@unit_price,@sale_price,@sale_qnty,@sale_money,@discount_rate,@oper_id,@oper_date,@item_subno,@item_clsno,@item_name,@item_status,@item_subname,@branch_no,@pos_id,@plan_no,@item_brand,@vip_acc_flag)");
            return builder.ToString();
        }
        #endregion

        #region 挂单流水表SQL语句
        
        
        
        
        private string GetSqlInsertTempPendingOrderFlow()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Insert into t_pending_orderflow(flow_id,flow_no,item_no,unit_price,sale_price,sale_qnty,sale_money,discount_rate,oper_id,oper_date,item_subno,item_clsno,item_name,item_status,item_subname,plan_no,item_brand,vip_acc_flag)");
            builder.Append("values(@flow_id,@flow_no,@item_no,@unit_price,@sale_price,@sale_qnty,@sale_money,@discount_rate,@oper_id,@oper_date,@item_subno,@item_clsno,@item_name,@item_status,@item_subname,@plan_no,@item_brand,@vip_acc_flag)");
            return builder.ToString();
        }
        #endregion

        #region 挂单主表插入数据
        
        
        
        
        
        
        public int InsertPendingOrder(List<t_cur_saleflow> saleFlow, t_pending_order pendingOrderInfo)
        {
            int num = 0;
            string commandText = "INSERT INTO t_pending_order(flow_no,sale_man,pending_type,vip_no) ";
            commandText = commandText + "VALUES(@flow_no,@sale_man,@pending_type,@vip_no) ";
            SQLiteTransaction transaction = base.dbPosSale.BeginTransaction();
            try
            {
                foreach (t_cur_saleflow _saleflow in saleFlow)
                {
                    SQLiteCommand command = this.BuildCommandForTempSaleRow(_saleflow, SaleBillType.PenOrdBill);
                    command.Transaction = transaction;
                    num += command.ExecuteNonQuery();
                }
                SQLiteCommand command2 = new SQLiteCommand(commandText, base.dbPosSale, transaction);
                command2.Parameters.Add(new SQLiteParameter("@flow_no", pendingOrderInfo.flow_no));
                command2.Parameters.Add(new SQLiteParameter("@sale_man", pendingOrderInfo.sale_man));
                command2.Parameters.Add(new SQLiteParameter("@pending_type", pendingOrderInfo.pending_type));
                command2.Parameters.Add(new SQLiteParameter("@vip_no", pendingOrderInfo.vip_no));
                num += command2.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw exception;
            }
            return num;
        }

        #endregion

        #region 保存所有当前购买商品数据
        
        
        
        
        public void SaveTempSaleRow(List<t_cur_saleflow> listSaleflow)
        {
            SQLiteTransaction transaction = base.dbPosSale.BeginTransaction();
            try
            {
                //删除表操作
                string str = "delete from t_cur_saleflow ";
                new SQLiteCommand(str.ToString(), base.dbPosSale, transaction).ExecuteNonQuery();
                if (listSaleflow != null)
                {
                    foreach (t_cur_saleflow _saleflow in listSaleflow)
                    {
                        SQLiteCommand command2 = this.BuildCommandForTempSaleRow(_saleflow, SaleBillType.SaleBill);
                        command2.Transaction = transaction;
                        command2.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw exception;
            }
        }
        #endregion

        #region 临时销售行构建命令
        
        
        
        
        
        private SQLiteCommand BuildCommandForTempSaleRow(t_cur_saleflow saleflow, SaleBillType saleBillType)
        {
            string commandText = "";
            if (saleBillType == SaleBillType.SaleBill)
            {
                //临时销售
                commandText = this.GetSqlInsertTempSaleRow();
            }
            else
            {
                //挂单处理
                commandText = this.GetSqlInsertTempPendingOrderFlow();
            }

            SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@flow_id", saleflow.flow_id);
            dictionary.Add("@flow_no", saleflow.flow_no);
            dictionary.Add("@item_no", saleflow.item_no);
            dictionary.Add("@unit_price", saleflow.unit_price);
            dictionary.Add("@sale_price", saleflow.sale_price);
            dictionary.Add("@sale_qnty", saleflow.sale_qnty);
            dictionary.Add("@sale_money", saleflow.sale_money);
            dictionary.Add("@discount_rate", saleflow.discount_rate);
            dictionary.Add("@oper_id", saleflow.oper_id);
            dictionary.Add("@oper_date", ExtendUtility.Instance.ParseToDateTime(saleflow.oper_date).ToString("s"));
            dictionary.Add("@item_subno", saleflow.item_subno);
            dictionary.Add("@item_clsno", saleflow.item_clsno);
            dictionary.Add("@item_name", saleflow.item_name);
            dictionary.Add("@item_status", saleflow.item_status);
            dictionary.Add("@item_subname", saleflow.item_subname);
            dictionary.Add("@pos_id", saleflow.pos_id);
            dictionary.Add("@branch_no", saleflow.branch_no);
            dictionary.Add("@price", saleflow.price);
            dictionary.Add("@plan_no", saleflow.plan_no);
            dictionary.Add("@item_brand", saleflow.item_brand);
            dictionary.Add("@vip_acc_flag", saleflow.vip_acc_flag);
            foreach (string str2 in dictionary.Keys)
            {
                SQLiteParameter parameter = new SQLiteParameter(str2, dictionary[str2]);
                command.Parameters.Add(parameter);
            }

            return command;
        }
        #endregion

        #region 返回挂单表数据
        
        
        
        
        public List<t_pending_order> GetPenOrdRows()
        {
            List<t_pending_order> list = new List<t_pending_order>();
            string commandText = "SELECT * FROM t_pending_order";
            try
            {
                SQLiteDataReader reader = new SQLiteCommand(commandText, base.dbPosSale).ExecuteReader();
                while (reader.Read())
                {
                    t_pending_order item = new t_pending_order
                    {
                        flow_no = reader["flow_no"].ToString().Trim(),
                        vip_no = reader["vip_no"].ToString().Trim(),
                        pending_type = reader["pending_type"].ToString().Trim(),
                        sale_man = reader["sale_man"].ToString().Trim(),
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            return list;
        }
        #endregion

        #region 返回挂单表明细
        
        
        
        
        public List<t_cur_saleflow> GetPenOrdSaleFlow(string strFlowNo)
        {
            string commandText = "SELECT * FROM t_pending_orderflow WHERE flow_no = @flow_no ORDER BY flow_id ASC";
            List<t_cur_saleflow> list = new List<t_cur_saleflow>();
            try
            {
                SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
                command.Parameters.Add(new SQLiteParameter("@flow_no", strFlowNo));
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    t_cur_saleflow _saleflow;
                    _saleflow = new t_cur_saleflow
                    {
                        flow_id = Convert.ToInt32(reader["flow_id"]),
                        item_no = reader["item_no"].ToString().Trim(),
                        flow_no = reader["flow_no"].ToString().Trim(),
                        item_name = reader["item_name"].ToString().Trim(),
                        oper_date = ExtendUtility.Instance.ParseToString(DateTime.Parse(reader["oper_date"].ToString()).ToString("s")),
                        unit_price = Convert.ToDecimal(reader["unit_price"]),
                        sale_price = Convert.ToDecimal(reader["sale_price"]),
                        sale_money = Convert.ToDecimal(reader["sale_money"]), //默认等于单价
                        item_subno = reader["item_subno"].ToString().Trim(),
                        sale_qnty = ExtendUtility.Instance.ParseToDecimal(reader["sale_qnty"]),
                        oper_id = reader["oper_id"].ToString().Trim(),
                        item_clsno = reader["item_clsno"].ToString().Trim(),
                        item_status = reader["Item_status"].ToString().Trim(),
                        vip_acc_flag = reader["vip_acc_flag"].ToString().Trim(),
                        item_subname = reader["item_subname"].ToString().Trim(),
                        last_item_name = Gfunc.ItemNameFormat(reader["item_no"].ToString().Trim(), reader["item_name"].ToString().Trim())
                    };
                    list.Add(_saleflow);
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            return list;
        }
        #endregion

        #region 清空挂单数据
        
        
        
        
        
        public int DelPenOrd(string flowNo)
        {

            int num = 0;
            string commandText = "DELETE FROM t_pending_order WHERE flow_no = @flow_no";
            string str2 = "DELETE FROM t_pending_orderflow WHERE flow_no = @flow_no";
            try
            {
                SQLiteTransaction transaction = base.dbPosSale.BeginTransaction();
                SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
                command.Parameters.Add(new SQLiteParameter("@flow_no", flowNo));
                num = command.ExecuteNonQuery();
                command = new SQLiteCommand(str2, base.dbPosSale);
                command.Parameters.Add(new SQLiteParameter("@flow_no", flowNo));
                num += command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return num;
        }
        #endregion

        #region 判断当前挂单数据是否存在
        
        
        
        
        
        public int CheckPendingOrder(string flowNo)
        {
            object obj2 = null;
            string commandText = "SELECT Count(flow_no) FROM t_pending_order WHERE flow_no = @flow_no";
            SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
            command.Parameters.Add(new SQLiteParameter("@flow_no", flowNo));
            try
            {
                obj2 = command.ExecuteScalar();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            if (obj2 == null)
            {
                return 0;
            }
            return Convert.ToInt32(obj2);
        }
        #endregion

        #region 支付流水表
        
        
        
        
        public List<t_cur_payflow> GetTempPayRow()
        {
            List<t_cur_payflow> list = new List<t_cur_payflow>();
            string commandText = "SELECT * FROM t_cur_payflow";
            try
            {
                SQLiteDataReader reader = new SQLiteCommand(commandText, base.dbPosSale).ExecuteReader();
                while (reader.Read())
                {
                    t_cur_payflow item = new t_cur_payflow
                    {
                        flow_id = Convert.ToInt32(reader["flow_id"]),
                        flow_no = reader["flow_no"].ToString().Trim(),
                        pay_amount = Convert.ToDecimal(reader["pay_amount"]),
                        sale_amount = Convert.ToDecimal(reader["sale_amount"]),
                        pay_way = reader["pay_way"].ToString().Trim(),
                        coin_type = reader["flow_no"].ToString().Trim(),
                        pay_name = reader["pay_name"].ToString().Trim(),
                        coin_rate = Convert.ToDecimal(reader["coin_rate"]),
                        convert_amt = Convert.ToDecimal(reader["convert_amt"]),
                        card_no = reader["card_no"].ToString().Trim(),
                        oper_date = ExtendUtility.Instance.ParseToString(DateTime.Parse(reader["oper_date"].ToString()).ToString("s")),
                        oper_id = reader["oper_id"].ToString().Trim(),
                        branch_no = SIString.TryStr(reader["branch_no"]),
                        pos_id = SIString.TryStr(reader["pos_id"]),
                        sale_way = SIString.TryStr(reader["sale_way"])
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            return list;
        }
        #endregion

        #region 挂起状态的支付流水表
        
        
        
        
        public List<t_cur_payflow> GetPendingPayRow(string flowNo)
        {
            List<t_cur_payflow> list = new List<t_cur_payflow>();
            string commandText = "SELECT * FROM t_pending_payflow where flow_no = @flow_no";
            SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
            command.Parameters.Add(new SQLiteParameter("@flow_no", flowNo));
            try
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    t_cur_payflow item = new t_cur_payflow
                    {
                        flow_id = Convert.ToInt32(reader["flow_id"]),
                        flow_no = reader["flow_no"].ToString().Trim(),
                        pay_amount = Convert.ToDecimal(reader["pay_amount"]),
                        sale_amount = Convert.ToDecimal(reader["sale_amount"]),
                        pay_way = reader["pay_way"].ToString().Trim(),
                        coin_type = reader["flow_no"].ToString().Trim(),
                        pay_name = reader["pay_name"].ToString().Trim(),
                        coin_rate = Convert.ToDecimal(reader["coin_rate"]),
                        convert_amt = Convert.ToDecimal(reader["convert_amt"]),
                        card_no = reader["card_no"].ToString().Trim(),
                        oper_date = ExtendUtility.Instance.ParseToString(DateTime.Parse(reader["oper_date"].ToString()).ToString("s")),
                        oper_id = reader["oper_id"].ToString().Trim(),
                        branch_no = SIString.TryStr(reader["branch_no"]),
                        pos_id = SIString.TryStr(reader["pos_id"]),
                        sale_way = SIString.TryStr(reader["sale_way"]),
                        vip_no = reader["vip_no"].ToString().Trim()
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            return list;
        }
        #endregion

        #region 保存支付数据
        
        
        
        
        public void SaveTempPayRow(List<t_cur_payflow> listPayflow)
        {
            SQLiteTransaction transaction = base.dbPosSale.BeginTransaction();
            try
            {
                string commandText = "delete from t_cur_payflow";
                new SQLiteCommand(commandText, base.dbPosSale, transaction).ExecuteNonQuery();
                if (listPayflow != null)
                {
                    foreach (t_cur_payflow _payflow in listPayflow)
                    {
                        SQLiteCommand command2 = this.BuildCommandForTempPayRow(_payflow);
                        command2.Transaction = transaction;
                        command2.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw new Exception(exception.Message);
            }
        }

        #endregion

        #region 保存挂起支付数据
        
        
        
        
        public void SavePendingPayRow(List<t_cur_payflow> listPayflow, string FlowNo)
        {
            SQLiteTransaction transaction = base.dbPosSale.BeginTransaction();
            try
            {
                //string commandText = "delete from t_pending_payflow";
                //new SQLiteCommand(commandText, base.dbPosSale, transaction).ExecuteNonQuery();
                if (listPayflow != null)
                {
                    foreach (t_cur_payflow _payflow in listPayflow)
                    {
                        _payflow.flow_no = FlowNo;
                        SQLiteCommand command2 = this.BuildCommandForPendingPayRow(_payflow);
                        command2.Transaction = transaction;
                        command2.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw new Exception(exception.Message);
            }
        }

        #endregion

        #region 删除挂起支付数据
        
        
        
        
        public void DelPendingPayRow(string flowNo)
        {
            string commandText = "delete from t_pending_payflow WHERE flow_no = @flow_no";
            try
            {
                SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
                command.Parameters.Add(new SQLiteParameter("@flow_no", flowNo));
                command.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
        #endregion

        #region 支付流水表构结器
        
        
        
        
        
        private SQLiteCommand BuildCommandForTempPayRow(t_cur_payflow payflow)
        {
            SQLiteCommand command = new SQLiteCommand(this.GetInsertTempPaySQL(), base.dbPosSale);
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@flow_id", payflow.flow_id);
            dictionary.Add("@flow_no", payflow.flow_no);
            dictionary.Add("@sale_amount", payflow.sale_amount);
            dictionary.Add("@pay_amount", payflow.pay_amount);
            dictionary.Add("@pay_way", payflow.pay_way);
            dictionary.Add("@card_no", payflow.card_no);
            dictionary.Add("@memo", payflow.memo);
            dictionary.Add("@pay_name", payflow.pay_name);
            dictionary.Add("@coin_type", payflow.coin_type);
            dictionary.Add("@coin_rate", payflow.coin_rate);
            dictionary.Add("@convert_amt", payflow.convert_amt);
            dictionary.Add("@oper_date", ExtendUtility.Instance.ParseToDateTime(payflow.oper_date).ToString("s"));
            dictionary.Add("@oper_id", payflow.oper_id);
            dictionary.Add("@voucher_no", payflow.voucher_no);
            dictionary.Add("@branch_no", payflow.branch_no);
            dictionary.Add("@pos_id", payflow.pos_id);
            dictionary.Add("@sale_way", payflow.sale_way);
            dictionary.Add("@vip_no", payflow.vip_no);
            foreach (string str2 in dictionary.Keys)
            {
                SQLiteParameter parameter = new SQLiteParameter(str2, dictionary[str2]);
                command.Parameters.Add(parameter);
            }
            return command;
        }
        #endregion

        #region 挂起支付流水表构结器
        
        
        
        
        
        private SQLiteCommand BuildCommandForPendingPayRow(t_cur_payflow payflow)
        {
            SQLiteCommand command = new SQLiteCommand(this.GetInsertPendingPaySQL(), base.dbPosSale);
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@flow_no", payflow.flow_no);
            dictionary.Add("@sale_amount", payflow.sale_amount);
            dictionary.Add("@pay_amount", payflow.pay_amount);
            dictionary.Add("@pay_way", payflow.pay_way);
            dictionary.Add("@card_no", payflow.card_no);
            dictionary.Add("@memo", payflow.memo);
            dictionary.Add("@pay_name", payflow.pay_name);
            dictionary.Add("@coin_type", payflow.coin_type);
            dictionary.Add("@coin_rate", payflow.coin_rate);
            dictionary.Add("@convert_amt", payflow.convert_amt);
            dictionary.Add("@oper_date", ExtendUtility.Instance.ParseToDateTime(payflow.oper_date).ToString("s"));
            dictionary.Add("@oper_id", payflow.oper_id);
            dictionary.Add("@voucher_no", payflow.voucher_no);
            dictionary.Add("@branch_no", payflow.branch_no);
            dictionary.Add("@pos_id", payflow.pos_id);
            dictionary.Add("@sale_way", payflow.sale_way);
            dictionary.Add("@vip_no", payflow.vip_no);
            foreach (string str2 in dictionary.Keys)
            {
                SQLiteParameter parameter = new SQLiteParameter(str2, dictionary[str2]);
                command.Parameters.Add(parameter);
            }
            return command;
        }
        #endregion

        #region 支付流水插入数据
        
        
        
        
        private string GetInsertTempPaySQL()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Insert into t_cur_payflow (flow_id,flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,branch_no,pos_id,sale_way)");
            builder.Append(" values(@flow_id,@flow_no,@sale_amount,@pay_way,@pay_amount,@coin_type,@pay_name,@coin_rate,@convert_amt,@card_no,@memo,@oper_date,@oper_id,@branch_no,@pos_id,@sale_way)");
            return builder.ToString();
        }
        #endregion

        #region 挂起支付流水插入数据
        
        
        
        
        private string GetInsertPendingPaySQL()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Insert into t_pending_payflow (flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,branch_no,pos_id,sale_way,vip_no)");
            builder.Append(" values(@flow_no,@sale_amount,@pay_way,@pay_amount,@coin_type,@pay_name,@coin_rate,@convert_amt,@card_no,@memo,@oper_date,@oper_id,@branch_no,@pos_id,@sale_way,@vip_no)");
            return builder.ToString();
        }
        #endregion

        #region 获得当前销售列表
        
        
        
        
        public List<t_cur_saleflow> GetTempSaleRow()
        {
            string commandText = "select * from t_cur_saleflow";
            List<t_cur_saleflow> list = new List<t_cur_saleflow>();
            try
            {
                SQLiteDataReader reader = new SQLiteCommand(commandText, base.dbPosSale).ExecuteReader();
                while (reader.Read())
                {
                    t_cur_saleflow item = new t_cur_saleflow
                    {
                        flow_id = Convert.ToInt32(reader["flow_id"]),
                        flow_no = reader["flow_no"].ToString().Trim(),
                        item_no = reader["item_no"].ToString().Trim(),
                        unit_price = Convert.ToDecimal(reader["unit_price"]),
                        sale_price = Convert.ToDecimal(reader["sale_price"]),
                        oper_date = ExtendUtility.Instance.ParseToString(DateTime.Parse(reader["oper_date"].ToString()).ToString("s")),
                        sale_qnty = Convert.ToDecimal(reader["sale_qnty"]),
                        sale_money = Convert.ToDecimal(reader["sale_money"]),
                        discount_rate = Convert.ToDecimal(reader["discount_rate"]),
                        item_subno = reader["item_subno"].ToString().Trim(),
                        item_clsno = reader["item_clsno"].ToString().Trim(),
                        item_name = reader["item_name"].ToString().Trim(),
                        item_status = reader["item_status"].ToString().Trim(),
                        vip_acc_flag = reader["vip_acc_flag"].ToString().Trim(),
                        oper_id = reader["oper_id"].ToString().Trim(),
                        item_subname = reader["item_subname"].ToString().Trim(),
                        branch_no = SIString.TryStr(reader["branch_no"]),
                        pos_id = SIString.TryStr(reader["pos_id"])
                    };
                    item.last_item_name = Gfunc.ItemNameFormat(item.item_no, item.item_name);
                    list.Add(item);
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            return list;
        }
        #endregion

        #region 结算完成保存数据

        
        
        
        
        
        
        public void SavePosBill(List<t_cur_saleflow> listSaleflow, List<t_cur_payflow> listPayflow, IDbTransaction objTrans)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Insert into t_app_saleflow(flow_id,flow_no,item_no,unit_price,sale_price,sale_qnty,sale_money,discount_rate,oper_id,oper_date,item_subno,item_clsno,item_name,item_status,item_subname,reasonid,sale_way,branch_no,pos_id,price,plan_no,item_brand)");
            builder.Append(" values(@flow_id,@flow_no,@item_no,@unit_price,@sale_price,@sale_qnty,@sale_money,@discount_rate,@oper_id,@oper_date,@item_subno,@item_clsno,@item_name,@item_status,@item_subname,@reasonid,@sale_way,@branch_no,@pos_id,@price,@plan_no,@item_brand)");
            StringBuilder builder2 = new StringBuilder();
            builder2.Append("Insert into t_app_payflow (flow_id,flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,voucher_no,branch_no,pos_id,sale_way,vip_no)");
            builder2.Append(" values(@flow_id,@flow_no,@sale_amount,@pay_way,@pay_amount,@coin_type,@pay_name,@coin_rate,@convert_amt,@card_no,@memo,@oper_date,@oper_id,@voucher_no,@branch_no,@pos_id,@sale_way,@vip_no)");
            try
            {
                SQLiteCommand cmd = new SQLiteCommand
                {
                    Connection = base.dbPosSale,
                    Transaction = objTrans as SQLiteTransaction,
                    CommandText = builder.ToString()
                };
                foreach (t_cur_saleflow _saleflow in listSaleflow)
                {
                    this.PrepareCommandForSaleRow(cmd, _saleflow);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        if (_saleflow.sale_way == "A")
                        {
                            UpdateItemStockByItem(_saleflow.item_no, ExtendUtility.Instance.ParseToDecimal(_saleflow.sale_qnty), "-");
                        }
                        else if (_saleflow.sale_way == "B")
                        {
                            UpdateItemStockByItem(_saleflow.item_no, ExtendUtility.Instance.ParseToDecimal(_saleflow.sale_qnty), "+");
                        }
                    }
                }
                cmd.Parameters.Clear();
                cmd.CommandText = builder2.ToString();
                foreach (t_cur_payflow _payflow in listPayflow)
                {
                    this.PrepareCommandForPayRow(cmd, _payflow);
                    cmd.ExecuteNonQuery();
                }

                //TODO:修改库存 本地库存/服务器库存
                //bool isok = true;
                // PosDownServiceProvider.Instance.InvokeService(Gattr.CONNECT_STRING,"UpdateItemStock" ,ref isok,Gattr.BranchNo,
            }
            catch (SQLiteException)
            {
                throw new Exception("销售数据保存失败!请联系系统管理员!!!");
            }
            catch (Exception)
            {
                throw new Exception("销售数据保存失败!请联系系统管理员!!!");
            }
        }
        private void PrepareCommandForSaleRow(SQLiteCommand cmd, t_cur_saleflow saleflow)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SQLiteParameter("@flow_id", saleflow.flow_id));
            cmd.Parameters.Add(new SQLiteParameter("@flow_no", saleflow.flow_no));
            cmd.Parameters.Add(new SQLiteParameter("@item_no", saleflow.item_no));
            cmd.Parameters.Add(new SQLiteParameter("@unit_price", saleflow.unit_price));
            cmd.Parameters.Add(new SQLiteParameter("@sale_price", saleflow.sale_price));
            cmd.Parameters.Add(new SQLiteParameter("@sale_qnty", saleflow.sale_qnty));
            cmd.Parameters.Add(new SQLiteParameter("@sale_money", saleflow.sale_money));
            cmd.Parameters.Add(new SQLiteParameter("@discount_rate", saleflow.discount_rate));
            cmd.Parameters.Add(new SQLiteParameter("@oper_id", saleflow.oper_id));
            cmd.Parameters.Add(new SQLiteParameter("@oper_date", ExtendUtility.Instance.ParseToDateTime(saleflow.oper_date).ToString("s")));
            cmd.Parameters.Add(new SQLiteParameter("@item_subno", saleflow.item_subno));
            cmd.Parameters.Add(new SQLiteParameter("@item_clsno", saleflow.item_clsno));
            cmd.Parameters.Add(new SQLiteParameter("@item_name", saleflow.item_name));
            cmd.Parameters.Add(new SQLiteParameter("@item_status", saleflow.item_status));
            cmd.Parameters.Add(new SQLiteParameter("@item_subname", saleflow.item_subname));
            cmd.Parameters.Add(new SQLiteParameter("@reasonid", saleflow.reasonid));
            cmd.Parameters.Add(new SQLiteParameter("@sale_way", saleflow.sale_way));
            cmd.Parameters.Add(new SQLiteParameter("@branch_no", saleflow.branch_no));
            cmd.Parameters.Add(new SQLiteParameter("@pos_id", saleflow.pos_id));
            cmd.Parameters.Add(new SQLiteParameter("@price", saleflow.price));
            cmd.Parameters.Add(new SQLiteParameter("@plan_no", saleflow.plan_no));
            cmd.Parameters.Add(new SQLiteParameter("@item_brand", saleflow.item_brand));
        }

        private void PrepareCommandForPayRow(SQLiteCommand cmd, t_cur_payflow payflow)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add(new SQLiteParameter("@flow_id", payflow.flow_id));
            cmd.Parameters.Add(new SQLiteParameter("@flow_no", payflow.flow_no));
            cmd.Parameters.Add(new SQLiteParameter("@sale_amount", payflow.sale_amount));
            cmd.Parameters.Add(new SQLiteParameter("@pay_amount", payflow.pay_amount));
            cmd.Parameters.Add(new SQLiteParameter("@pay_way", payflow.pay_way));
            cmd.Parameters.Add(new SQLiteParameter("@card_no", payflow.card_no));
            cmd.Parameters.Add(new SQLiteParameter("@memo", payflow.memo));
            cmd.Parameters.Add(new SQLiteParameter("@pay_name", payflow.pay_name));
            cmd.Parameters.Add(new SQLiteParameter("@coin_type", payflow.coin_type));
            cmd.Parameters.Add(new SQLiteParameter("@coin_rate", payflow.coin_rate));
            cmd.Parameters.Add(new SQLiteParameter("@convert_amt", payflow.convert_amt));
            cmd.Parameters.Add(new SQLiteParameter("@oper_date", ExtendUtility.Instance.ParseToDateTime(payflow.oper_date).ToString("s")));
            cmd.Parameters.Add(new SQLiteParameter("@oper_id", payflow.oper_id));
            cmd.Parameters.Add(new SQLiteParameter("@voucher_no", payflow.voucher_no));
            cmd.Parameters.Add(new SQLiteParameter("@sale_way", payflow.sale_way));
            cmd.Parameters.Add(new SQLiteParameter("@branch_no", payflow.branch_no));
            cmd.Parameters.Add(new SQLiteParameter("@pos_id", payflow.pos_id));
            cmd.Parameters.Add(new SQLiteParameter("@vip_no", payflow.vip_no));
        }
        #endregion

        #region 删除临时数据
        
        
        
        public void DeleteTempData()
        {
            SQLiteTransaction transaction = base.dbPosSale.BeginTransaction();
            try
            {
                new SQLiteCommand("delete from t_cur_payflow", base.dbPosSale, transaction).ExecuteNonQuery();
                new SQLiteCommand("delete from t_cur_saleflow", base.dbPosSale, transaction).ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw new Exception("清除数据失败!\r\n" + exception.Message);
            }
        }
        #endregion

        #region 开启事务
        
        
        
        
        
        public bool BeginSQLTrans(ref IDbTransaction objTrans)
        {
            objTrans = base.dbPosSale.BeginTransaction();
            return true;
        }
        #endregion

        #region 返回操作人信息
        public t_operator GetOperatorInfo(string operName, string operPwd, string branchId)
        {
            t_operator item = null;
            string sql = "select * from t_operator where oper_name=@operName and oper_pwd=@operPwd and (branch_id=@branchId or rtrim(ltrim(branch_id))='ALL')";
            SQLiteDataReader reader = base.dbPosItem.QueryReader(sql, new SQLiteParameter[] { 
                new SQLiteParameter("@operName", operName.Trim()), 
                new SQLiteParameter("@operPwd", operPwd.Trim()), 
                new SQLiteParameter("@branchId", branchId.Trim()) });
            if (!reader.Read())
            {
                reader.Close();
                return item;
            }

            item = new t_operator
            {
                oper_id = reader["oper_id"].ToString().Trim(),
                oper_name = reader["oper_name"].ToString().Trim(),
                oper_pwd = reader["oper_pwd"].ToString().Trim(),
                full_name = reader["full_name"].ToString().Trim(),
                oper_role = reader["oper_role"].ToString().Trim(),
                oper_state = reader["oper_state"].ToString().Trim(),
                branch_id = reader["branch_id"].ToString().Trim(),
                oper_flag = reader["Oper_flag"].ToString().Trim(),
                group_id = reader["group_id"].ToString().Trim(),
                cash_grant = reader["cash_grant"].ToString().Trim(),
                discount_rate = ExtendUtility.Instance.ParseToDecimal(reader["discount_rate"]),
                last_date = DateTime.Now
            };


            return item;
        }
        #endregion

        #region 根据操作ID,门店ID查询操作人信息
        
        
        
        
        
        
        public List<t_operator> GetOperatorInfo(string operId, string branchId)
        {

            List<t_operator> list = new List<t_operator>();
            string sql = "select * from t_operator where (oper_id like @operId and branch_id = @branchId) or (oper_id like @operId and ltrim(rtrim(branch_id))='ALL')";
            try
            {
                SQLiteDataReader reader = base.dbPosItem.QueryReader(sql, new SQLiteParameter[] { 
                new SQLiteParameter("@operId", "%" + operId.Trim() + "%"),
                new SQLiteParameter("@branchId", branchId.Trim())});
                while (reader.Read())
                {
                    t_operator item = new t_operator
                    {
                        oper_id = reader["oper_id"].ToString().Trim(),
                        oper_name = reader["oper_name"].ToString().Trim(),
                        oper_pwd = reader["oper_pwd"].ToString().Trim(),
                        full_name = reader["full_name"].ToString().Trim(),
                        oper_role = reader["oper_role"].ToString().Trim(),
                        oper_state = reader["oper_state"].ToString().Trim(),
                        branch_id = reader["branch_id"].ToString().Trim(),
                        last_date = DateTime.Now
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }

            return list;
        }
        #endregion

        #region 更新当前操作人最后登录时间
        
        
        
        
        
        
        public int SetOperLoginTime(string operId, DateTime dTime)
        {
            int num2;
            try
            {
                string sql = "UPDATE t_operator SET last_date = @dTime WHERE oper_id = @operId";
                SQLiteParameter[] cmdParams = new SQLiteParameter[] { new SQLiteParameter("@operId", operId), new SQLiteParameter("@dTime", dTime) };
                int num = base.dbPosItem.ExecuteSql(sql, cmdParams);
                cmdParams = null;
                num2 = num;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return num2;
        }
        #endregion
        #region 更新操作人密码
        public int UpdateOperPwd(string operId, string pwd)
        {
            int num2;
            try
            {
                string sql = "UPDATE t_operator SET oper_pwd = @pwd WHERE oper_id = @operId";
                SQLiteParameter[] cmdParams = new SQLiteParameter[] { new SQLiteParameter("@operId", operId), new SQLiteParameter("@pwd", pwd) };
                int num = base.dbPosItem.ExecuteSql(sql, cmdParams);
                cmdParams = null;
                num2 = num;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return num2;
        }
        #endregion
        #region 查询商品价格
        public decimal GetItemPrice(string itemNo)
        {
            string strsql = "select sale_price from t_product_food where item_no='" + itemNo + "'";
            object objA = null;
            try
            {
                objA = base.dbPosItem.GetObjectSingle(strsql, new SQLiteParameter[] { new SQLiteParameter("@itemNo", itemNo.ToUpper()) });
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            if (!object.Equals(objA, null) && !object.Equals(objA, DBNull.Value))
            {
                return Convert.ToDecimal(objA);
            }
            return 0M;
        }
        #endregion
        #region 获取分支信息
        
        
        
        
        public DataTable GetItemDm(string where)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select item_no,item_name,item_size,item_clsname,code_name,unit_no,stock_qty from t_product_food where stock=1 ");
            if (!string.IsNullOrEmpty(where))
            {
                builder.Append(where);
            }
            return base.dbPosItem.GetData(builder.ToString());
        }
        #endregion
        #region 根据WHERE条件查询付款信息
        
        
        
        
        
        public List<t_dict_payment_info> GetPaymentInfo(string where)
        {
            List<t_dict_payment_info> list = new List<t_dict_payment_info>();
            StringBuilder builder = new StringBuilder();
            builder.Append("select pay_way,pay_name,rate from t_dict_payment_info where");
            if (!string.IsNullOrEmpty(where))
            {
                builder.Append(where);
            }
            object objA = null;
            try
            {
                SQLiteDataReader reader = base.dbPosItem.QueryReader(builder.ToString());
                while (reader.Read())
                {
                    t_dict_payment_info item = new t_dict_payment_info
                    {
                        pay_way = reader["pay_way"].ToString().Trim(),
                        pay_name = reader["pay_name"].ToString().Trim()
                    };
                    objA = reader["rate"];
                    if (object.Equals(objA, null) || object.Equals(objA, DBNull.Value))
                    {
                        item.rate = 1M;
                    }
                    else
                    {
                        item.rate = Convert.ToDecimal(objA);
                    }
                    if (item.rate <= 0M)
                    {
                        item.rate = 1M;
                    }
                    list.Add(item);
                }
                reader.Close();
            }
            catch (SQLiteException)
            {
                //throw new Exception(exception.Message);
            }
            return list;
        }
        #endregion

        #region 查询VIP信息
        
        
        
        
        
        public List<t_vip_info> GetVipInfo(string cardId, SearchType seachType)
        {
            List<t_vip_info> list = new List<t_vip_info>();

            SQLiteParameter comm = null;

            string sql = "";
            if (!cardId.Trim().Equals("") && seachType == SearchType.LIKE)
            {
                sql = "SELECT * FROM t_vip_info where vip_card_id like @card_id";
                comm = new SQLiteParameter("@card_id", cardId.Trim() + "%");
            }

            else if (seachType == SearchType.EXAC)
            {
                sql = "SELECT * FROM t_vip_info where vip_card_id = @card_id";
                comm = new SQLiteParameter("@card_id", cardId.Trim());
            }
            else
            {
                sql = "SELECT * FROM t_vip_info";
                comm = new SQLiteParameter();
            }
            try
            {
                SQLiteDataReader reader = base.dbPosItem.QueryReader(sql, new SQLiteParameter[] { 
                comm });
                while (reader.Read())
                {
                    t_vip_info item = new t_vip_info
                    {
                        vip_card_id = reader["vip_card_id"].ToString(),
                        vip_card_pwd = reader["vip_card_pwd"].ToString(),
                        reg_time = DateTime.Parse(reader["reg_time"].ToString()),
                        full_name = reader["full_name"].ToString(),
                        company = reader["company"].ToString(),
                        mobile = reader["mobile"].ToString(),
                        qq = reader["qq"].ToString(),
                        email = reader["email"].ToString(),
                        message = reader["message"].ToString(),
                        insurance = Convert.ToDecimal(reader["insurance"]),
                        recharge = Convert.ToDecimal(reader["recharge"]),
                        game = Convert.ToDecimal(reader["game"]),
                        messageapi = Convert.ToInt32(reader["messageapi"]),
                        //Ionsuranceapi = Convert.ToInt32(reader["ionsuranceapi"]),
                        //Rechargeapi = Convert.ToInt32(reader["rechargeapi"]),
                        //Gameapi = Convert.ToInt32(reader["gameapi"]),
                        //Md5key = reader["md5key"].ToString(),
                        level = reader["level"].ToString(),
                        balance = Convert.ToDecimal(reader["balance"]),
                        total_spending = Convert.ToDecimal(reader["total_spending"]),
                        state = Convert.ToInt32(reader["state"]),
                        lowest = Convert.ToDecimal(reader["lowest"]),
                        //Sms_default_way = Convert.ToInt32(reader["sms_default_way"]),
                        reg_type = reader["reg_type"].ToString(),
                        //Key = reader["key"].ToString(),
                        message_last = reader["message_last"].ToString(),
                        //Ios_message_cllect = reader["ios_message_cllect"].ToString(),
                        //Ios_food_collect = reader["ios_food_collect"].ToString(),
                        all_score = Convert.ToDecimal(reader["all_score"]),
                        use_score = Convert.ToDecimal(reader["use_score"]),
                        //Ios_devicetoken = reader["ios_devicetoken"].ToString(),
                        //Ios_devicetoken_cns = reader["ios_devicetoken_cns"].ToString(),
                        //Smsmk_pwd = reader["smsmk_pwd"].ToString()
                    };
                    item.surplus_score = Convert.ToDecimal(reader["all_score"]) - Convert.ToDecimal(reader["use_score"]);
                    list.Add(item);
                }
                reader.Close();
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            return list;
        }
        #endregion
        #region 获取分支信息
        
        
        
        
        public DataTable GetBranchInfo(string where)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select branch_no,branch_name from t_branch_info where 1=1 ");
            if (!string.IsNullOrEmpty(where))
            {
                builder.Append(where);
            }
            return base.dbPosItem.GetData(builder.ToString());
        }
        #endregion
        
        
        
        
        
        
        public bool InsertAccList(t_vip_info vipInfo, string flowNo)
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("insert into t_vip_acc_list(flow_no,card_id,balance,total_spending,all_score,use_score,surplus_score,oper_date)");
                builder.AppendFormat("values('{0}','{1}',{2},{3},{4},{5},{6},datetime('now','localtime'))",
                        new object[] 
                        { 
                            flowNo, vipInfo.vip_card_id, vipInfo.balance, vipInfo.total_spending, vipInfo.all_score, vipInfo.use_score, vipInfo.surplus_score 
                        }
                    );
                new SQLiteCommand(builder.ToString(), base.dbPosSale).ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }


        #region 退货
        
        
        
        
        
        public List<t_base_code> GetAllReasonInfo(string flag)
        {
            List<t_base_code> _infoDic = null;
            String sql = "";
            t_base_code _reason = null;
            SQLiteDataReader reader = null;
            String _reasonID = string.Empty;
            try
            {
                sql = "SELECT code_id,code_name FROM t_base_code where type_no='RT'";
                reader = base.dbPosItem.QueryReader(sql);
                if (reader.HasRows)
                {
                    _infoDic = new List<t_base_code>();
                }
                while (reader.Read())
                {
                    _reason = new t_base_code();
                    _reason.code_id = SIString.TryStr(_reasonID);
                    _reason.code_name = SIString.TryStr(reader[1]);
                    if (!_infoDic.Contains(_reason))
                    {
                        _infoDic.Add(_reason);
                    }
                }
            }
            catch
            {
                _infoDic = null;

            }
            return _infoDic;
        }
        
        
        
        
        
        public List<t_cur_saleflow> GetSaleFlowInfo(string flowNo)
        {
            List<t_cur_saleflow> modelList = null;
            t_cur_saleflow model = null;
            String sql = "";

            sql = "SELECT item_no,flow_no,unit_price,sale_price,sale_way,discount_rate,item_subno,item_clsno,item_name,item_status,item_subname,sale_qnty,sale_money,price,item_brand FROM " +
    " ( SELECT a.item_no,a.flow_no,a.unit_price,a.sale_price,a.sale_way,a.discount_rate,a.item_subno,a.item_clsno,a.item_name,a.item_status,a.item_subname,a.sale_qnty - ifnull(b.sale_qnty,0) AS sale_qnty,a.unit_price * (a.sale_qnty - b.sale_qnty) AS sale_money,a.price,item_brand  FROM " +
            " ( SELECT flow_no,item_no,unit_price,sale_price,sale_way,discount_rate,item_subno,item_clsno,item_name,item_status,item_subname,sum(sale_qnty) sale_qnty,price,item_brand FROM t_app_saleflow  WHERE flow_no = @flow_no  GROUP BY item_no ) a " +
        " LEFT JOIN ( SELECT item_no, sum(sale_qnty) sale_qnty FROM t_app_saleflow  WHERE flow_no in ( SELECT flow_no FROM t_app_payflow WHERE voucher_no = @flow_no ) GROUP BY item_no " +
        " ) b ON a.item_no = b.item_no ) c WHERE c.sale_qnty > 0";
            //sql = "select id,flow_id,flow_no,item_no,unit_price,sale_price,sale_qnty,sale_money,sale_way,discount_rate,oper_id,oper_date,item_subno,item_clsno,item_name,item_status,item_subname,reasonid from t_app_saleflow where flow_no=@flow_no and item_no not in (SELECT item_no FROM t_app_saleflow WHERE flow_no=(SELECT flow_no FROM t_app_payflow where voucher_no=@flow_no))";
            SQLiteParameter comm = null;
            SQLiteCommand command = null;
            int record = 0;
            try
            {
                comm = new SQLiteParameter("@flow_no", flowNo);
                SQLiteParameter[] parameters = new SQLiteParameter[1];
                parameters[0] = comm;
                object obj = GetSingleData("SELECT COUNT(1) FROM t_app_saleflow WHERE flow_no IN (SELECT flow_no FROM t_app_payflow WHERE voucher_no=@flow_no)", parameters);
                record = SIString.TryInt(obj);
                if (record == 0)
                {
                    sql = "SELECT flow_no,item_no,unit_price,sale_price,sale_way,discount_rate,item_subno,item_clsno,item_name,item_status,item_subname,sum(sale_qnty) sale_qnty,sum(sale_money) sale_money,branch_no,pos_id,price,item_brand FROM t_app_saleflow  WHERE flow_no = @flow_no  GROUP BY item_no";
                }
                command = new SQLiteCommand(sql, base.dbPosSale);
                command.Parameters.Clear();
                command.Parameters.Add(comm);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    modelList = new List<t_cur_saleflow>();
                    while (reader.Read())
                    {
                        model = new t_cur_saleflow();
                        // model.flow_id = SIString.TryInt(reader["flow_id"]);
                        model.flow_no = SIString.TryStr(reader["flow_no"]);
                        model.item_no = SIString.TryStr(reader["item_no"]);
                        model.unit_price = SIString.TryDec(reader["unit_price"]);
                        model.sale_price = SIString.TryDec(reader["sale_price"]);
                        model.sale_qnty = SIString.TryDec(reader["sale_qnty"]);
                        model.sale_money = SIString.TryDec(reader["sale_money"]);
                        model.sale_way = SIString.TryStr(reader["sale_way"]);
                        model.discount_rate = SIString.TryDec(reader["discount_rate"]);
                        // model.oper_id = SIString.TryStr(reader["oper_id"]);
                        //model.oper_date = SIString.ParseToDateTime(reader["oper_date"]);
                        model.item_subno = SIString.TryStr(reader["item_subno"]);
                        model.item_clsno = SIString.TryStr(reader["item_clsno"]);
                        model.item_name = SIString.TryStr(reader["item_name"]);
                        model.item_status = SIString.TryStr(reader["item_status"]);
                        model.item_subname = SIString.TryStr(reader["item_subname"]);
                        //model.reasonid = SIString.TryStr(reader["reasonid"]);
                        model.branch_no = SIString.TryStr(reader["item_subname"]);
                        model.price = ExtendUtility.Instance.ParseToDecimal(reader["price"]);
                        model.pos_id = SIString.TryStr(reader["item_subname"]);
                        model.last_item_name = Gfunc.ItemNameFormat(model.item_no, model.item_name);
                        model.item_brand = ExtendUtility.Instance.ParseToString(reader["item_brand"]);
                        model.vip_acc_flag = GetItemInfo(model.item_no).vip_acc_flag;
                        modelList.Add(model);
                    }
                }
            }
            catch
            {
                model = null;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return modelList;
        }
        
        
        
        
        
        public List<t_cur_saleflow> GetVoucherInfo(string flowNo)
        {
            List<t_cur_saleflow> modelList = null;
            t_cur_saleflow model = null;
            String sql = "";
            sql = "select id,flow_id,flow_no,item_no,unit_price,sale_price,sale_qnty,sale_money,sale_way,discount_rate,oper_id,oper_date,item_subno,item_clsno,item_name,item_status,item_subname,reasonid from t_app_saleflow where flow_no=@flow_no and item_no  in (SELECT item_no FROM t_app_saleflow WHERE flow_no=(SELECT flow_no FROM t_app_payflow where voucher_no=@flow_no))";
            SQLiteParameter comm = null;
            SQLiteCommand command = null;
            try
            {
                comm = new SQLiteParameter("@flow_no", flowNo);
                command = new SQLiteCommand(sql, base.dbPosSale);
                command.Parameters.Clear();
                command.Parameters.Add(comm);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    modelList = new List<t_cur_saleflow>();
                    while (reader.Read())
                    {
                        model = new t_cur_saleflow();
                        model.flow_id = SIString.TryInt(reader["flow_id"]);
                        model.flow_no = SIString.TryStr(reader["flow_no"]);
                        model.item_no = SIString.TryStr(reader["item_no"]);
                        model.unit_price = SIString.TryDec(reader["unit_price"]);
                        model.sale_price = SIString.TryDec(reader["sale_price"]);
                        model.sale_qnty = SIString.TryDec(reader["sale_qnty"]);
                        model.sale_money = SIString.TryDec(reader["sale_money"]);
                        model.sale_way = SIString.TryStr(reader["sale_way"]);
                        model.discount_rate = SIString.TryDec(reader["discount_rate"]);
                        model.oper_id = SIString.TryStr(reader["oper_id"]);
                        model.oper_date = ExtendUtility.Instance.ParseToString(SIString.ParseToDateTime(reader["oper_date"]).ToString("s"));
                        model.item_subno = SIString.TryStr(reader["item_subno"]);
                        model.item_clsno = SIString.TryStr(reader["item_clsno"]);
                        model.item_name = SIString.TryStr(reader["item_name"]);
                        model.item_status = SIString.TryStr(reader["item_status"]);
                        model.item_subname = SIString.TryStr(reader["item_subname"]);
                        model.reasonid = SIString.TryStr(reader["reasonid"]);
                        model.last_item_name = Gfunc.ItemNameFormat(model.item_no, model.item_name);
                        modelList.Add(model);
                    }
                }
            }
            catch
            {
                model = null;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return modelList;
        }
        
        
        
        
        
        public List<t_cur_payflow> GetPayFlowInfo(string flowNo)
        {
            List<t_cur_payflow> modelList = null;
            t_cur_payflow model = null;
            String sql = "";
            sql = "select id,flow_id,flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,voucher_no from t_app_payflow where flow_no=@flow_no";
            SQLiteCommand command = null;
            SQLiteParameter parameter = null;
            try
            {
                command = new SQLiteCommand(sql, base.dbPosSale);
                parameter = new SQLiteParameter("@flow_no", flowNo.Trim());
                command.Parameters.Add(parameter);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    modelList = new List<t_cur_payflow>();
                    while (reader.Read())
                    {
                        model = new t_cur_payflow();
                        model.flow_id = SIString.TryInt(reader["flow_id"]);
                        model.flow_no = SIString.TryStr(reader["flow_no"]);
                        model.sale_amount = SIString.TryDec(reader["sale_amount"]);
                        model.pay_way = SIString.TryStr(reader["pay_way"]);
                        model.pay_amount = SIString.TryDec(reader["pay_amount"]);
                        model.coin_type = SIString.TryStr(reader["coin_type"]);
                        model.pay_name = SIString.TryStr(reader["pay_name"]);
                        model.coin_rate = SIString.TryDec(reader["coin_rate"]);
                        model.convert_amt = SIString.TryDec(reader["convert_amt"]);
                        model.card_no = SIString.TryStr(reader["card_no"]);
                        model.memo = SIString.TryStr(reader["memo"]);
                        model.oper_date = ExtendUtility.Instance.ParseToString(SIString.ParseToDateTime(reader["oper_date"]).ToString("s"));
                        model.oper_id = SIString.TryStr(reader["oper_id"]);
                        model.voucher_no = SIString.TryStr(reader["voucher_no"]);
                        modelList.Add(model);
                    }
                }
            }
            catch
            {
                model = null;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return modelList;
        }
        
        
        
        
        
        public Int32 GetVoucherNoCount(String flowNo)
        {
            Int32 result = 0;
            String sql = "";
            sql = "select count(1) as cut from t_app_payflow where flow_no=@flow_no and length(voucher_no)>0";
            SQLiteCommand command = null;
            SQLiteParameter parameter = null;
            try
            {
                command = new SQLiteCommand(sql, base.dbPosSale);
                parameter = new SQLiteParameter("@flow_no", flowNo.Trim());
                command.Parameters.Add(parameter);
                object obj;
                obj = command.ExecuteScalar();
                result = SIString.TryInt(obj);
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return result;
        }
        #endregion
        #region 交易查询 后期需要添加联网查询

        #region 支付流水信息查询

        
        
        
        
        public DataTable GetPayFlowInfoDataTableByE()
        {
            String sql = string.Empty;
            DataTable table = null;
            try
            {
                sql = "select * from t_app_payflow where sale_way='E' or sale_way='EB'";
                table = GetDataTable(sql, null);
                //绑定oper_name  pay_status
                DataColumn dc = null;
                dc = table.Columns.Add("oper_name", Type.GetType("System.String"));
                dc = table.Columns.Add("pay_status", Type.GetType("System.String"));

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table != null && table.Rows.Count > 0)
                    {
                        String pay_status = SIString.TryStr(table.Rows[i]["sale_way"]);
                        String oper_id = SIString.TryStr(table.Rows[i]["oper_id"]);
                        String branchNo = SIString.TryStr(table.Rows[i]["branch_no"]);
                        String oper_name = oper_id;
                        if (oper_id.Length > 0)
                        {
                            List<t_operator> oper = GetOperatorInfo(oper_id, branchNo);
                            if (oper != null && oper.Count > 0)
                            {
                                oper_name = oper[0].full_name;
                            }
                        }
                        table.Rows[i]["oper_name"] = oper_name;

                        //回款状态
                        if (pay_status == "E")
                        {
                            table.Rows[i]["pay_status"] = "未回款";
                        }
                        else if (pay_status == "EB")
                        {
                            table.Rows[i]["pay_status"] = "部分回款";
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPayFlowInfoDataTableByE--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception e)
            {
                LoggerHelper.Log("MsmkLogger", "GetPayFlowInfoDataTableByE--->>>>" + e.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }

        
        
        
        
        
        public List<t_cur_payflow> GetPayFlowInfoListByFlowNo(String flowNo)
        {
            String sql = string.Empty;
            SQLiteDataReader reader = null;
            List<t_cur_payflow> tList = null;
            try
            {
                sql = "select flow_id,flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,voucher_no,branch_no,pos_id,sale_way from t_app_payflow where flow_no=@flow_no";
                SQLiteParameter[] parameter = new SQLiteParameter[1];
                parameter[0] = new SQLiteParameter("@flow_no", flowNo);
                reader = GetDataReader(sql, parameter);
                tList = GetModelList<t_cur_payflow>(reader);
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            return tList;
        }
        
        
        
        
        
        public DataTable GetPayFlowInfoDataTableByFlowNo(String flowNo)
        {
            String sql = string.Empty;
            DataTable table = null;
            try
            {
                sql = "select flow_id,flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,voucher_no,branch_no,pos_id,sale_way from t_app_payflow where flow_no=@flow_no";
                SQLiteParameter[] parameter = new SQLiteParameter[1];
                parameter[0] = new SQLiteParameter("@flow_no", flowNo);
                table = GetDataTable(sql, parameter);
            }
            catch (SQLiteException ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPayFlowInfoDataTableByFlowNo--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception e)
            {
                LoggerHelper.Log("MsmkLogger", "GetPayFlowInfoDataTableByFlowNo--->>>>" + e.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        
        
        
        
        
        public bool DelPayFlowById(string _id)
        {
            Int32 result = 0;
            Boolean isOK = false;
            String sql = "delete t_app_payflow where id=@id";
            SQLiteCommand command = null;
            SQLiteParameter parameter = null;
            try
            {
                command = new SQLiteCommand(sql, base.dbPosSale);
                parameter = new SQLiteParameter("@id", _id);
                command.Parameters.Add(parameter);
                object obj;
                obj = command.ExecuteNonQuery();
                result = SIString.TryInt(obj);
                if (result > 0)
                {
                    isOK = true;
                }
            }
            catch (SQLiteException ex)
            {
                LoggerHelper.Log("MsmkLogger", "DelPayFlowById--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception e)
            {
                LoggerHelper.Log("MsmkLogger", "DelPayFlowById--->>>>" + e.ToString(), LogEnum.ExceptionLog);
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return isOK;
        }
        
        
        
        public bool UpdatePayFlowByFid(t_pos_payflow _payFlow)
        {
            Int32 result = 0;
            Boolean isOK = false;
            String sql = "update t_app_payflow set pay_way=@pay_way,pay_amount=@pay_amount,pay_name=@pay_name,memo=@memo where flow_no=@flow_no and flow_id=@flow_id";
            SQLiteCommand command = null;
            try
            {
                command = new SQLiteCommand(sql, base.dbPosSale);
                SQLiteParameter[] parameters = new SQLiteParameter[6];
                parameters[0] = new SQLiteParameter("@pay_way", _payFlow.pay_way);
                parameters[1] = new SQLiteParameter("@pay_amount", _payFlow.pay_amount);
                parameters[2] = new SQLiteParameter("@pay_name", _payFlow.pay_name);
                parameters[3] = new SQLiteParameter("@memo", _payFlow.memo);
                //parameters[4] = new SQLiteParameter("@oper_date",_payFlow.oper_date);
                parameters[4] = new SQLiteParameter("@flow_no", _payFlow.flow_no);
                parameters[5] = new SQLiteParameter("@flow_id", _payFlow.flow_id);
                command.Parameters.AddRange(parameters);
                object obj;
                obj = command.ExecuteNonQuery();
                result = SIString.TryInt(obj);
                if (result > 0)
                {
                    isOK = true;
                }
            }
            catch (SQLiteException ex)
            {
                LoggerHelper.Log("MsmkLogger", "DelPayFlowById--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception e)
            {
                LoggerHelper.Log("MsmkLogger", "DelPayFlowById--->>>>" + e.ToString(), LogEnum.ExceptionLog);
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return isOK;
        }

        public bool UpdatePayFlowStatus(t_pos_payflow _payFlow)
        {
            Int32 result = 0;
            Boolean isOK = false;
            String sql = "update t_app_payflow set sale_way=@sale_way,oper_date=@oper_date where flow_no=@flow_no and sale_way like 'E%'";
            SQLiteCommand command = null;
            try
            {
                command = new SQLiteCommand(sql, base.dbPosSale);
                SQLiteParameter[] parameters = new SQLiteParameter[4];
                parameters[0] = new SQLiteParameter("@sale_way", _payFlow.sale_way);
                parameters[1] = new SQLiteParameter("@oper_date", _payFlow.oper_date);
                parameters[2] = new SQLiteParameter("@flow_no", _payFlow.flow_no);
                parameters[3] = new SQLiteParameter("@flow_id", _payFlow.flow_id);
                command.Parameters.AddRange(parameters);
                object obj;
                obj = command.ExecuteNonQuery();
                result = SIString.TryInt(obj);
                if (result > 0)
                {
                    isOK = true;
                }
            }
            catch (SQLiteException ex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdatePayFlowStatus--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception e)
            {
                LoggerHelper.Log("MsmkLogger", "UpdatePayFlowStatus--->>>>" + e.ToString(), LogEnum.ExceptionLog);
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return isOK;
        }
        #endregion

        #region 销售流水信息查询
        
        
        
        
        
        public List<t_cur_saleflow> GetSaleFlowInfoListByFlowNo(String flowNo)
        {
            String sql = string.Empty;
            SQLiteDataReader reader = null;
            List<t_cur_saleflow> tList = null;
            try
            {
                sql = "select flow_id,flow_no,item_no,unit_price,sale_price,sale_qnty,sale_money,sale_way,discount_rate,oper_id,oper_date,item_subno,item_clsno,item_name,item_status,item_subname,reasonid,branch_no,pos_id from t_app_saleflow where flow_no=@flow_no";
                SQLiteParameter[] parameter = new SQLiteParameter[1];
                parameter[0] = new SQLiteParameter("@flow_no", flowNo);
                reader = GetDataReader(sql, parameter);
                tList = GetModelList<t_cur_saleflow>(reader);
                if (tList != null && tList.Count > 0)
                {
                    foreach (t_cur_saleflow sale in tList)
                    {
                        sale.last_item_name = Gfunc.ItemNameFormat(sale.item_no, sale.item_name);
                    }
                }
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            return tList;
        }
        
        
        
        
        
        public DataTable GetSaleFlowInfoDataTableByFlowNo(String flowNo)
        {
            String sql = string.Empty;
            DataTable table = null;
            try
            {
                sql = "select flow_id,flow_no,item_no,unit_price,sale_price,sale_qnty,sale_money,sale_way,discount_rate,oper_id,oper_date,item_subno,item_clsno,item_name,item_status,item_subname,reasonid,branch_no,pos_id from t_app_saleflow where flow_no=@flow_no";
                SQLiteParameter[] parameter = new SQLiteParameter[1];
                parameter[0] = new SQLiteParameter("@flow_no", flowNo);
                table = GetDataTable(sql, parameter);
                if (table != null && table.Rows.Count > 0)
                {
                    DataColumn dc = new DataColumn("last_item_name", Type.GetType("System.String"));
                    if (!table.Columns.Contains(dc.ColumnName))
                    {
                        table.Columns.Add(dc);
                        foreach (DataRow dr in table.Rows)
                        {
                            dr["last_item_name"] = Gfunc.ItemNameFormat(SIString.TryStr(dr["item_no"]), SIString.TryStr(dr["item_name"]));
                        }
                    }
                }
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            return table;
        }
        #endregion

        
        
        
        
        
        
        public DataTable GetMaxPayFlowInfo(String branchNo, String posNo, String flow_no, String operate)
        {
            DataTable table = null;
            StringBuilder builder = new StringBuilder();
            if (string.IsNullOrEmpty(flow_no))
            {
                builder.AppendFormat("select * from t_app_payflow where 1=1 and  flow_no like '{0}%{1}%'", branchNo, posNo);
                builder.Append(" order by oper_date desc  limit 1 ");
                table = GetDataTable(builder.ToString(), null);
            }
            else
            {
                SQLiteParameter[] parameters = new SQLiteParameter[1];
                parameters[0] = new SQLiteParameter("@flow_no", flow_no);
                if (operate == "=")
                {
                    builder.AppendFormat("select * from t_app_payflow where flow_no {0} @flow_no", operate);
                    builder.Append(" order by flow_id desc  limit 1 ");
                }
                else
                {
                    builder.AppendFormat("select * from t_app_payflow where 1=1 and flow_no like '{0}%{1}%' and  flow_no {2} @flow_no", branchNo, posNo, operate);
                    if (operate == ">")
                    {
                        builder.Append(" order by oper_date asc  limit 1 ");
                    }
                    else
                    {
                        builder.Append(" order by oper_date desc  limit 1 ");
                    }
                }

                table = GetDataTable(builder.ToString(), parameters);
            }
            if (table != null && table.Rows.Count > 0)
            {
                String oper_id = SIString.TryStr(table.Rows[0]["oper_id"]);
                String oper_name = oper_id;
                if (oper_id.Length > 0)
                {
                    List<t_operator> oper = GetOperatorInfo(oper_id, branchNo);
                    if (oper != null && oper.Count > 0)
                    {
                        oper_name = oper[0].full_name;
                    }
                }
                DataColumn dc = new DataColumn("oper_name", Type.GetType("System.String"));
                if (!table.Columns.Contains(dc.ColumnName))
                {
                    table.Columns.Add(dc);
                }
                table.Rows[0]["oper_name"] = oper_name;
            }
            return table;
        }
        
        
        
        
        
        public DataTable GetSaleFlowInfoByFlowNo(String flowNo)
        {
            DataTable table = null;
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("select * from t_app_saleflow where flow_no=@flow_no");
            builder.Append(" order by oper_date desc  ");
            SQLiteParameter[] parameters = new SQLiteParameter[1];
            parameters[0] = new SQLiteParameter("@flow_no", flowNo);
            table = GetDataTable(builder.ToString(), parameters);
            return table;
        }
        #endregion
        #region Sale库查询数据公共方法

        
        
        
        
        
        
        private int ExecuteSql(string sql, SQLiteParameter[] parameters)
        {
            int record = 0;
            SQLiteCommand cmd = null;
            try
            {
                cmd = new SQLiteCommand(sql, this.dbPosSale);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                record = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return record;
        }
        
        
        
        
        
        
        private object GetSingleData(string sql, SQLiteParameter[] parameters)
        {
            object obj = null;
            SQLiteCommand cmd = null;
            try
            {
                cmd = new SQLiteCommand(sql, this.dbPosSale);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                obj = cmd.ExecuteScalar();
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return obj;
        }
        
        
        
        
        
        
        private SQLiteDataReader GetDataReader(string sql, SQLiteParameter[] parameters)
        {
            SQLiteDataReader reader = null;
            SQLiteCommand cmd = null;
            try
            {
                cmd = new SQLiteCommand(sql, this.dbPosSale);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                reader = cmd.ExecuteReader();
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return reader;
        }
        
        
        
        
        
        
        private DataTable GetDataTable(string sql, SQLiteParameter[] parameters)
        {
            DataTable table = null;
            SQLiteCommand cmd = null;
            SQLiteDataAdapter da = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                cmd = new SQLiteCommand(sql, this.dbPosSale);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0)
                {
                    table = ds.Tables[0];
                }
            }
            catch (SQLiteException)
            {

            }
            catch (Exception)
            {

            }
            finally
            {

            }
            return table;
        }
        
        
        
        
        
        
        private List<T> GetModelList<T>(SQLiteDataReader reader)
        {
            List<T> tList = new List<T>();
            if (reader != null && reader.HasRows)
            {
                T t = default(T);
                int index = -1;
                try
                {
                    while (reader.Read())
                    {
                        t = Activator.CreateInstance<T>();
                        Type type = t.GetType();
                        PropertyInfo[] pinfos = type.GetProperties();
                        DataTable table = reader.GetSchemaTable();
                        if (table != null && table.Rows.Count > 0)
                        {
                            foreach (DataRow dr in table.Rows)
                            {
                                index = GetPropertyIndex(pinfos, SIString.TryStr(dr["ColumnName"]));
                                if (index >= 0)
                                {
                                    PropertyInfo pi = pinfos[index];
                                    String fieldName = pi.Name;
                                    switch (pi.PropertyType.Name.ToLower())
                                    {
                                        case "int":
                                        case "int32":
                                            pi.SetValue(t, SIString.TryInt(reader[pi.Name.ToLower()]), null);
                                            break;
                                        case "decimal":
                                            pi.SetValue(t, SIString.TryDec(reader[pi.Name.ToLower()]), null);
                                            break;
                                        case "datetime":
                                            pi.SetValue(t, SIString.ParseToDateTime(reader[pi.Name.ToLower()]).ToString("s"), null);
                                            break;
                                        default:
                                            pi.SetValue(t, SIString.TryStr(reader[pi.Name.ToLower()]), null);
                                            break;
                                    }//switch (pi.PropertyType.Name.ToLower())
                                }//if (index > 0) 
                                index = -1;
                            }//foreach (DataColumn dc in table.Columns)
                        }//if (table != null && table.Rows.Count > 0)
                        tList.Add(t);
                    }//while (reader.Read())
                }
                catch (SQLiteException)
                {

                }
                catch (Exception)
                {

                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            return tList;
        }
        
        
        
        
        
        
        int GetPropertyIndex(PropertyInfo[] pinfos, String pname)
        {
            int index = -1;
            for (int rindex = 0; rindex < pinfos.Length; rindex++)
            {
                if (pinfos[rindex].Name.ToLower() == pname.ToLower())
                {
                    index = rindex;
                    break;
                }
            }
            return index;
        }
        #endregion

        #region 基础信息更新
        
        
        
        public t_handle SelectHandleDate()
        {
            t_handle _t_handle = null;
            try
            {
                string sql = "SELECT handle_id,t_base_code,t_base_code_type,t_bd_item_combsplit," +
                "t_operator,t_product_food,t_product_food_barcode,t_product_food_type,t_rm_plan_detail," +
                "t_rm_plan_master,t_product_food_kc,t_product_food_jg FROM t_handle WHERE handle_id = 1";
                //DataTable data = base.dbPosItem.GetData(sql);
                String errorMessage=String.Empty;
                DataTable dt = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                if (dt.Rows.Count==1)
                {
                    _t_handle = new t_handle();
                    _t_handle.t_base_code = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_base_code"]);
                    _t_handle.t_base_code_type = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_base_code_type"]);
                    _t_handle.t_bd_item_combsplit = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_bd_item_combsplit"]);
                    _t_handle.t_operator = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_operator"]);
                    _t_handle.t_product_food = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_product_food"]);
                    _t_handle.t_product_food_barcode = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_product_food_barcode"]);
                    _t_handle.t_product_food_type = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_product_food_type"]);
                    _t_handle.t_rm_plan_detail = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_rm_plan_detail"]);
                    _t_handle.t_rm_plan_master = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_rm_plan_master"]);
                    _t_handle.t_product_food_jg = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_product_food_jg"]);
                    _t_handle.t_product_food_kc = ExtendUtility.Instance.ParseToDecimal(dt.Rows[0]["t_product_food_kc"]);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdataHandleDate--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdataHandleDate--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _t_handle;
        }
        
        
        
        
        
        public bool UpdateHandleDate(t_handle _t_handle)
        {
            try
            {
                string sql = "update t_handle set t_base_code=@t_base_code,t_base_code_type=@t_base_code_type,t_bd_item_combsplit=@t_bd_item_combsplit," +
                "t_operator=@t_operator,t_product_food=@t_product_food,t_product_food_barcode=@t_product_food_barcode,t_product_food_type=@t_product_food_type," +
                "t_rm_plan_detail=@t_rm_plan_detail,t_rm_plan_master=@t_rm_plan_master,t_product_food_jg=@t_product_food_jg,t_product_food_kc=@t_product_food_kc where handle_id = 1";
                SQLiteParameter[] parameters = new SQLiteParameter[11];
                parameters[0] = new SQLiteParameter("@t_base_code", _t_handle.t_base_code);
                parameters[1] = new SQLiteParameter("@t_base_code_type", _t_handle.t_base_code_type);
                parameters[2] = new SQLiteParameter("@t_bd_item_combsplit", _t_handle.t_bd_item_combsplit);
                parameters[3] = new SQLiteParameter("@t_operator", _t_handle.t_operator);
                parameters[4] = new SQLiteParameter("@t_product_food", _t_handle.t_product_food);
                parameters[5] = new SQLiteParameter("@t_product_food_barcode", _t_handle.t_product_food_barcode);
                parameters[6] = new SQLiteParameter("@t_product_food_type", _t_handle.t_product_food_type);
                parameters[7] = new SQLiteParameter("@t_rm_plan_detail", _t_handle.t_rm_plan_detail);
                parameters[8] = new SQLiteParameter("@t_rm_plan_master", _t_handle.t_rm_plan_master);
                parameters[9] = new SQLiteParameter("@t_product_food_jg", _t_handle.t_product_food_jg);
                parameters[10] = new SQLiteParameter("@t_product_food_kc", _t_handle.t_product_food_kc);
                String errorMessage = String.Empty;
                if (DbUtilitySQLite.Instance.ExecuteSql(Gattr.ITEM_DB_FILE_NAME,sql,parameters, ref errorMessage) == 1)
                {
                    return true;
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        LoggerHelper.Log("MsmkLogger", "InsertClsData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                    }
                    return false;
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdataHandleDate--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
                return false;
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdataHandleDate--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
                return false;
            }
        }
        
        
        
        
        
        public bool InsertClsData(DataTable table,decimal del,ref decimal rid)
        {
            String sqlI = "";
            String sqlD = "";
            string sqlU = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;
            bool isok = false;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.DateFormat);
                sqlI = "insert into t_product_food_type(typeno,typename,parent,last_refresh_time) values (@typeno,@typename,@parent,@last_refresh_time)";
                sqlU = "update t_product_food_type set typename=@typename,parent=@parent,last_refresh_time=@last_refresh_time where typeno=@typeno";
                sqlD = "delete from t_product_food_type where typeno=@typeno";
                transList = new List<SqlParaEntity>();
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_product_food_type" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[4];
                    parameters[0] = new SQLiteParameter("@typeno", StringUtility.Instance.StringTrim(dr["item_clsno"]));
                    parameters[1] = new SQLiteParameter("@typename", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["item_clsname"])));
                    parameters[2] = new SQLiteParameter("@parent", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["cls_parent"])));
                    parameters[3] = new SQLiteParameter("@last_refresh_time", date);
                    switch(dr["rtype"].ToString())
                    {
                            //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                            //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                            //删除状态
                        case "D":
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = new SQLiteParameter[] { new SQLiteParameter("@typeno", StringUtility.Instance.StringTrim(dr["item_clsno"])) } };
                            break;
                    }
                    transList.Add(_current);

                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                //return this.dbPosItem.ExecuteSqlTran(transList);
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertClsData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertClsData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertClsData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        //清空商品分类数据表
        public bool DelClsData()
        {
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;

            transList = new List<SqlParaEntity>();
            _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_product_food_type" };
            transList.Add(_current);

            bool isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;

            return isok;
        }


        //清空商品分类数据表
        public bool DelItemData()
        {
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;

            transList = new List<SqlParaEntity>();
            _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_product_food" };
            transList.Add(_current);

            bool isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;

            return isok;
        }

        //更新t_handle表
        public bool UpdateTHandle() {
            String sqlU = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;

            transList = new List<SqlParaEntity>();

            sqlU = "update t_handle set t_product_food_type=@t_product_food_type,t_product_food=@t_product_food,t_product_food_jg=@t_product_food_jg where handle_id = 1";
            parameters = new SQLiteParameter[3];
            parameters[0] = new SQLiteParameter("@t_product_food_type", "0");
            parameters[1] = new SQLiteParameter("@t_product_food", "0");
            parameters[2] = new SQLiteParameter("@t_product_food_jg", "0");
            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                 
            transList.Add(_current);
            bool isOk = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
            return isOk;
        }

        
        
        
        public bool InsertBarCodeData(DataTable table,decimal del,ref decimal rid)
        {
            SQLiteParameter[] parameters = null;
            SQLiteParameter[] parametersD = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                string sqlI = "insert into t_product_food_barcode(item_no,item_barcode,modify_date) values (@item_no,@item_barcode,@modify_date)";
                string sqlU = "update t_product_food_barcode set item_barcode=@item_barcode,modify_date=@modify_date where item_no=@item_no";
                string sqlD = "delete from t_product_food_barcode where item_no=@item_no and item_barcode=@item_barcode";
                transList = new List<SqlParaEntity>();
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_product_food_barcode" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[3];
                    parameters[0] = new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"]));
                    parameters[1] = new SQLiteParameter("@item_barcode", StringUtility.Instance.StringTrim(dr["item_barcode"]));
                    parameters[2] = new SQLiteParameter("@modify_date", date);
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            parametersD = new SQLiteParameter[2];
                            parametersD[0] = new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"]));
                            parametersD[1] = new SQLiteParameter("@item_barcode", StringUtility.Instance.StringTrim(dr["item_barcode"]));
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = parametersD };
                            break;
                    }
                    transList.Add(_current);
                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (isok)
                {
                    string selectSql = "select max(modify_date) from t_product_food_barcode";
                    object data = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME,
                       selectSql, null, ref errorMessage);
                    string last_time = Gattr.LAST_UPDATE_TIME;
                    if (data != null)
                    {
                        last_time = ExtendUtility.Instance.ParseToDateTime(data).ToString();
                    }
                    WindowsAPIUtility.WritePrivateProfileString("download", "barcode", last_time, Gattr.INI_FILE_PATH);
                }
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertBarCodeData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBarCodeData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBarCodeData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }


        //清空商品附加条码数据表
        public bool DelBarcodeData()
        {
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;

            transList = new List<SqlParaEntity>();
            _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_product_food_barcode" };
            transList.Add(_current);

            bool isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;

            return isok;
        }


        public bool InsertItemData(DataTable table,decimal del,ref decimal rid)
        {
            String sqlI = "";
            String sqlU = "";
            String sqlD = "";
            string selectSql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_product_food(item_no,item_subno,item_name,item_subname,item_clsno," +
                    "item_brand,item_brandname,unit_no,item_size,product_area," +
                    "price,sale_price,sale_price1,build_date,lastchange_time," +
                    "main_supcust,num2,status,num3,change_price,vip_acc_flag,vip_acc_num,scheme_price,min_qty,max_qty) " +
                    "values (@item_no,@item_subno,@item_name,@item_subname,@item_clsno," +
                    "@item_brand,@item_brandname,@unit_no,@item_size,@product_area," +
                    "@price,@sale_price,@sale_price1,@build_date,@lastchange_time," +
                    "@main_supcust,@num2,@status,@num3,@change_price,@vip_acc_flag,@vip_acc_num,@scheme_price,@min_qty,@max_qty)";
                sqlU = "update t_product_food set item_subno=@item_subno, item_name=@item_name," +
                    "item_subname=@item_subname,item_clsno=@item_clsno," +
                    "item_brand=@item_brand,item_brandname=@item_brandname," +
                    "unit_no=@unit_no,item_size=@item_size,product_area=@product_area," +
                    "price=@price,sale_price=@sale_price,sale_price1=@sale_price1," +
                    "build_date=@build_date,lastchange_time=@lastchange_time," +
                    "main_supcust=@main_supcust,num2=@num2,status=@status,num3=@num3, " +
                    "change_price=@change_price,vip_acc_flag=@vip_acc_flag," +
                    "min_qty=@min_qty,max_qty=@max_qty,"+
                    "vip_acc_num=@vip_acc_num,scheme_price=@scheme_price where item_no=@item_no";
                sqlD = "delete t_product_food where item_no=@item_no";
                transList = new List<SqlParaEntity>();
                selectSql = "select count(*) from t_product_food where item_no=@item_no";
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_product_food" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[25];
                    parameters[0] = new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"]));
                    parameters[1] = new SQLiteParameter("@item_subno", StringUtility.Instance.StringTrim(dr["item_subno"]));
                    parameters[2] = new SQLiteParameter("@item_name", StringUtility.Instance.StringTrim(dr["item_name"]));
                    parameters[3] = new SQLiteParameter("@item_subname", StringUtility.Instance.StringTrim(dr["item_subname"]));
                    parameters[4] = new SQLiteParameter("@item_clsno", StringUtility.Instance.StringTrim(dr["item_clsno"]));
                    parameters[5] = new SQLiteParameter("@item_brand", StringUtility.Instance.StringTrim(dr["item_brand"]));
                    parameters[6] = new SQLiteParameter("@item_brandname", StringUtility.Instance.StringTrim(dr["item_brandname"]));
                    parameters[7] = new SQLiteParameter("@unit_no", StringUtility.Instance.StringTrim(dr["unit_no"]));
                    parameters[8] = new SQLiteParameter("@item_size", StringUtility.Instance.StringTrim(dr["item_size"]));
                    parameters[9] = new SQLiteParameter("@product_area", StringUtility.Instance.StringTrim(dr["product_area"]));
                    parameters[10] = new SQLiteParameter("@price", StringUtility.Instance.StringTrim(dr["price"]));
                    parameters[11] = new SQLiteParameter("@sale_price", StringUtility.Instance.StringTrim(dr["sale_price"]));
                    parameters[12] = new SQLiteParameter("@sale_price1", StringUtility.Instance.StringTrim(dr["sale_price"]));
                    parameters[13] = new SQLiteParameter("@build_date", StringUtility.Instance.StringTrim(ExtendUtility.Instance.ParseToDateTime(dr["modify_date"]).ToString("s")));
                    parameters[14] = new SQLiteParameter("@lastchange_time", StringUtility.Instance.StringTrim(ExtendUtility.Instance.ParseToDateTime(dr["modify_date"]).ToString("s")));
                    parameters[15] = new SQLiteParameter("@main_supcust", StringUtility.Instance.StringTrim(dr["main_supcust"]));
                    parameters[16] = new SQLiteParameter("@num2", StringUtility.Instance.StringTrim(dr["num2"]));
                    parameters[17] = new SQLiteParameter("@status", StringUtility.Instance.StringTrim(dr["status"]));
                    parameters[18] = new SQLiteParameter("@num3", StringUtility.Instance.StringTrim(dr["num3"]));
                    parameters[19] = new SQLiteParameter("@change_price", StringUtility.Instance.StringTrim(dr["is_focus"]));//议价
                    parameters[20] = new SQLiteParameter("@vip_acc_flag", StringUtility.Instance.StringTrim(dr["vip_acc_flag"]));
                    parameters[21] = new SQLiteParameter("@vip_acc_num", StringUtility.Instance.StringTrim(dr["vip_acc_num"]));
                    parameters[22] = new SQLiteParameter("@scheme_price", StringUtility.Instance.StringTrim(dr["change_price"]));//打折
                    parameters[23] = new SQLiteParameter("@min_qty", StringUtility.Instance.StringTrim(ExtendUtility.Instance.ParseToDecimal(dr["min_qty"])));
                    parameters[24] = new SQLiteParameter("@max_qty", StringUtility.Instance.StringTrim(ExtendUtility.Instance.ParseToDecimal(dr["max_qty"])));
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = new SQLiteParameter[] { new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"])) } };
                            break;
                    }
                    transList.Add(_current);
                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (isok)
                {
                    selectSql = "select max(lastchange_time) from t_product_food";
                    object data = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME,
                       selectSql, null, ref errorMessage);
                    string last_time = Gattr.LAST_UPDATE_TIME;
                    if (data != null)
                    {
                        last_time = ExtendUtility.Instance.ParseToDateTime(data).ToString();
                    }
                    WindowsAPIUtility.WritePrivateProfileString("download", "t_product_food", last_time, Gattr.INI_FILE_PATH);
                }
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertItemData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertItemData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
           {
                LoggerHelper.Log("MsmkLogger", "InsertItemData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertItemComb(DataTable table,decimal del,ref decimal rid)
        {
            String sqlI = "";
            String sqlD = "";
            SQLiteParameter[] parameters = null;
            SQLiteParameter[] parametersD = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_bd_item_combsplit(comb_item_no,item_no,item_qty,relation_px) " +
                    "values (@comb_item_no,@item_no,@item_qty,@relation_px)";
                sqlD = "delete from t_bd_item_combsplit where comb_item_no=@comb_item_no and item_no=@item_no";
                transList = new List<SqlParaEntity>();
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_bd_item_combsplit" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[4];
                    parameters[0] = new SQLiteParameter("@comb_item_no", StringUtility.Instance.StringTrim(dr["comb_item_no"]));
                    parameters[1] = new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"]));
                    parameters[2] = new SQLiteParameter("@item_qty", ExtendUtility.Instance.ParseToDecimal((dr["item_qty"])).ToString(Gattr.PosSalePrcPoint));
                    parameters[3] = new SQLiteParameter("@relation_px", StringUtility.Instance.StringTrim(dr["relation_px"]));
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            parametersD = new SQLiteParameter[2];
                            parametersD[0] = new SQLiteParameter("@comb_item_no", StringUtility.Instance.StringTrim(dr["comb_item_no"]));
                            parametersD[1] = new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"]));
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = parametersD };
                            break;
                    }
                    transList.Add(_current);
                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertItemComb--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertItemComb--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertItemComb--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }


        //清空商品分类数据表
        public bool DelCashierData()
        {
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;

            transList = new List<SqlParaEntity>();
            _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_operator" };
            transList.Add(_current);

            bool isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;

            return isok;
        }


        public bool InsertCashierData(DataTable table,decimal del,ref decimal rid)
        {
            String sqlI = "";
            String sqlU = "";
            String sqlD = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_operator(oper_id,oper_name,oper_pwd,full_name,oper_role,oper_state,branch_id,last_date,oper_flag,group_id,cash_grant,discount_rate) values " +
                       "(@oper_id,@oper_name,@oper_pwd,@full_name,@oper_role,@oper_state,@branch_id,@last_date,@oper_flag,@group_id,@cash_grant,@discount_rate)";
                sqlU = "update t_operator set oper_name=@oper_name,oper_pwd=@oper_pwd,full_name=@full_name,oper_role=@oper_role,oper_state=@oper_state," +
                       "branch_id=@branch_id,last_date=@last_date,oper_flag=@oper_flag,group_id=@group_id,cash_grant=@cash_grant,discount_rate=@discount_rate where oper_id=@oper_id";
                sqlD = "delete from t_operator where oper_id=@oper_id";
                transList = new List<SqlParaEntity>();
                if (del== -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_operator" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[12];
                    parameters[0] = new SQLiteParameter("@oper_id", StringUtility.Instance.StringTrim(dr["oper_id"]));
                    parameters[1] = new SQLiteParameter("@oper_name", StringUtility.Instance.StringTrim(dr["oper_id"]));
                    parameters[2] = new SQLiteParameter("@oper_pwd", StringUtility.Instance.StringTrim(dr["oper_pw"]));
                    parameters[3] = new SQLiteParameter("@full_name", StringUtility.Instance.StringTrim(dr["oper_name"]));
                    parameters[4] = new SQLiteParameter("@oper_role", StringUtility.Instance.StringTrim(dr["oper_type"]));
                    parameters[5] = new SQLiteParameter("@oper_state", StringUtility.Instance.StringTrim(dr["oper_status"]));
                    parameters[6] = new SQLiteParameter("@branch_id", StringUtility.Instance.StringTrim(dr["branch_no"]));
                    parameters[7] = new SQLiteParameter("@last_date", StringUtility.Instance.StringTrim(dr["last_time"]));
                    parameters[8] = new SQLiteParameter("@oper_flag", StringUtility.Instance.StringTrim(dr["Oper_flag"]));
                    parameters[9] = new SQLiteParameter("@group_id", StringUtility.Instance.StringTrim(dr["group_id"]));
                    parameters[10] = new SQLiteParameter("@cash_grant", StringUtility.Instance.StringTrim(dr["cash_grant"]));
                    parameters[11] = new SQLiteParameter("@discount_rate", StringUtility.Instance.StringTrim(dr["discount_rate"]));
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = new SQLiteParameter[] { new SQLiteParameter("@oper_id", StringUtility.Instance.StringTrim(dr["oper_id"])) } };
                            break;
                    }
                    transList.Add(_current);
                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertCashierData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertCashierData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertCashierData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertBaseTypeData(DataTable table,decimal del,ref decimal rid)
        {
            String sqlI = "";
            String sqlU = "";
            String sqlD = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_base_code_type(type_no,type_name) values (@type_no,@type_name)";
                sqlU = "update t_base_code_type set type_name=@type_name where type_no=@type_no";
                sqlD = "delete from t_base_code_type where type_no=@type_no and type_name=@type_name";
                transList = new List<SqlParaEntity>();
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_base_code_type" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[2];
                    parameters[0] = new SQLiteParameter("@type_no", StringUtility.Instance.StringTrim(dr["type_no"]));
                    parameters[1] = new SQLiteParameter("@type_name", StringUtility.Instance.StringTrim(dr["type_name"]));
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = parameters };
                            break;
                    }
                    transList.Add(_current);

                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                       rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertCashierData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBaseTypeData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBaseTypeData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertBaseData(DataTable table,decimal del,ref decimal rid)
        {
            String sqlI = "";
            String sqlU = "";
            String sqlD = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_base_code(type_no,code_id,code_name,english_name,code_type,memo) values (@type_no,@code_id,@code_name,@english_name,@code_type,@memo)"; ;
                sqlU = "update t_base_code set code_name=@code_name,english_name=@english_name,code_type=@code_type,memo=@memo where type_no=@type_no and code_id=@code_id";
                sqlD = "delete from t_base_code where type_no=@type_no and code_id=@code_id and code_name=@code_name and english_name=@english_name and code_type=@code_type and memo=@memo";
                transList = new List<SqlParaEntity>();
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_base_code" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[6];
                    parameters[0] = new SQLiteParameter("@type_no", StringUtility.Instance.StringTrim(dr["type_no"]));
                    parameters[1] = new SQLiteParameter("@code_id", StringUtility.Instance.StringTrim(dr["code_id"]));
                    parameters[2] = new SQLiteParameter("@code_name", StringUtility.Instance.StringTrim(dr["code_name"]));
                    parameters[3] = new SQLiteParameter("@english_name", StringUtility.Instance.StringTrim(dr["english_name"]));
                    parameters[4] = new SQLiteParameter("@code_type", StringUtility.Instance.StringTrim(dr["code_type"]));
                    parameters[5] = new SQLiteParameter("@memo", StringUtility.Instance.StringTrim(dr["memo"]));
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = parameters };
                            break;
                    }
                    transList.Add(_current);

                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertBaseData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBaseData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBaseData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertPaymentData(DataTable table)
        {
            String sql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sql = "insert into t_dict_payment_info(pay_way,pay_flag,pay_name,rate,pay_memo) values (@pay_way,@pay_flag,@pay_name,@rate,@pay_memo)"; ;
                transList = new List<SqlParaEntity>();
                _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_dict_payment_info" };
                transList.Add(_current);
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[5];
                    parameters[0] = new SQLiteParameter("@pay_way", StringUtility.Instance.StringTrim(dr["pay_way"]));
                    parameters[1] = new SQLiteParameter("@pay_flag", StringUtility.Instance.StringTrim(dr["pay_flag"]));
                    parameters[2] = new SQLiteParameter("@pay_name", StringUtility.Instance.StringTrim(dr["pay_name"]));
                    parameters[3] = new SQLiteParameter("@rate", StringUtility.Instance.StringTrim(dr["rate"]));
                    parameters[4] = new SQLiteParameter("@pay_memo", StringUtility.Instance.StringTrim(dr["pay_memo"]));
                    _current = new SqlParaEntity() { Sql = sql, parameters = parameters };
                    transList.Add(_current);
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertPaymentData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPaymentData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPaymentData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertFunction(DataTable table)
        {
            String sql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sql = "insert into t_attr_function(branch_no,func_id,func_name,func_udname,pos_key,flag,type,memo,other1) values (@branch_no,@func_id,@func_name,@func_udname,@pos_key,@flag,@type,@memo,@other1)"; ;
                transList = new List<SqlParaEntity>();
                _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_attr_function" };
                transList.Add(_current);
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[9];

                    parameters[0] = new SQLiteParameter("@branch_no", StringUtility.Instance.StringTrim(dr["branch_no"]));
                    parameters[1] = new SQLiteParameter("@func_id", StringUtility.Instance.StringTrim(dr["func_id"]));
                    parameters[2] = new SQLiteParameter("@func_name", StringUtility.Instance.StringTrim(dr["func_name"]));
                    parameters[3] = new SQLiteParameter("@func_udname", StringUtility.Instance.StringTrim(dr["func_udname"]));
                    parameters[4] = new SQLiteParameter("@pos_key", StringUtility.Instance.StringTrim(dr["pos_key"]));
                    parameters[5] = new SQLiteParameter("@flag", StringUtility.Instance.StringTrim(dr["flag"]));
                    parameters[6] = new SQLiteParameter("@type", StringUtility.Instance.StringTrim(dr["type"]));
                    parameters[7] = new SQLiteParameter("@memo", StringUtility.Instance.StringTrim(dr["memo"]));
                    parameters[8] = new SQLiteParameter("@other1", StringUtility.Instance.StringTrim(dr["other1"]));
                    _current = new SqlParaEntity() { Sql = sql, parameters = parameters };
                    transList.Add(_current);
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertFunction--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertFunction--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertFunction--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertPosSysSet(List<t_sys_pos_set> sets)
        {
            String sql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sql = "insert into t_sys_setting(sys_var_id,sys_var_value) values(@sys_var_id,@sys_var_value)"; ;
                transList = new List<SqlParaEntity>();
                _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_sys_setting" };
                transList.Add(_current);
                foreach (t_sys_pos_set set in sets)
                {
                    parameters = new SQLiteParameter[2];

                    parameters[0] = new SQLiteParameter("@sys_var_id", StringUtility.Instance.StringTrim(set.sys_var_id));
                    parameters[1] = new SQLiteParameter("@sys_var_value", StringUtility.Instance.StringTrim(set.sys_var_value));
                    _current = new SqlParaEntity() { Sql = sql, parameters = parameters };
                    transList.Add(_current);
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertPosSysSet--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPosSysSet--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPosSysSet--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertBranchList(DataTable table)
        {
            String sqlI = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_branch_info(com_no,branch_no,branch_name,property,branch_man,address,zip,branch_email,branch_tel,branch_fax,display_flag,other1,other2,other3,sheet_tag,area,trade_type,com_grant,account,com_init,init_date,indep_bal,dc_no,com_date_up,com_date_down,com_oper_up,com_oper_down,check_flag,check_sheet_no,check_branch_no,price_type,price_rate,tran_flag,oper_flag,allow_cz,order_num,branch_mj) values (@com_no,@branch_no,@branch_name,@property,@branch_man,@address,@zip,@branch_email,@branch_tel,@branch_fax,@display_flag,@other1,@other2,@other3,@sheet_tag,@area,@trade_type,@com_grant,@account,@com_init,@init_date,@indep_bal,@dc_no,@com_date_up,@com_date_down,@com_oper_up,@com_oper_down,@check_flag,@check_sheet_no,@check_branch_no,@price_type,@price_rate,@tran_flag,@oper_flag,@allow_cz,@order_num,@branch_mj )";
                //sqlU = "update t_branch_info set com_no=@com_no,branch_name=@branch_name,property=@property,"+
                //        "branch_man=@branch_man,address=@address,zip=@zip,branch_email=@branch_email,branch_tel=@branch_tel,"+
                //        "branch_fax=@branch_fax,display_flag=@display_flag,other1=@other1,other2=@other2,other3=@other3,"+
                //        "sheet_tag=@sheet_tag,area=@area,trade_type=@trade_type,com_grant=@com_grant,account=@account,com_init=@com_init,"+
                //        "init_date=@init_date,indep_bal=@indep_bal,dc_no=@dc_no,com_date_up=@com_date_up,com_date_down=@com_date_down,"+
                //        "com_oper_up=@com_oper_up,com_oper_down=@com_oper_down,check_flag=@check_flag,check_sheet_no=@check_sheet_no,"+
                //        "check_branch_no=@check_branch_no,price_type=@price_type,price_rate=@price_rate,tran_flag=@tran_flag,"+
                //        "oper_flag=@oper_flag,allow_cz=@allow_cz,order_num=@order_num,branch_mj=@branch_mj where branch_no=@branch_no";
                //sqlD = "delete from t_branch_info where branch_no=@branch_no";
                transList = new List<SqlParaEntity>();
                _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_branch_info" };
                transList.Add(_current);
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[37];
                    parameters[0] = new SQLiteParameter("@com_no", StringUtility.Instance.StringTrim(dr["com_no"]));
                    parameters[1] = new SQLiteParameter("@branch_no", StringUtility.Instance.StringTrim(dr["branch_no"]));
                    parameters[2] = new SQLiteParameter("@branch_name", StringUtility.Instance.StringTrim(dr["branch_name"]));
                    parameters[3] = new SQLiteParameter("@property", StringUtility.Instance.StringTrim(dr["property"]));
                    parameters[4] = new SQLiteParameter("@branch_man", StringUtility.Instance.StringTrim(dr["branch_man"]));

                    parameters[5] = new SQLiteParameter("@address", StringUtility.Instance.StringTrim(dr["address"]));
                    parameters[6] = new SQLiteParameter("@zip", StringUtility.Instance.StringTrim(dr["zip"]));
                    parameters[7] = new SQLiteParameter("@branch_email", StringUtility.Instance.StringTrim(dr["branch_email"]));
                    parameters[8] = new SQLiteParameter("@branch_tel", StringUtility.Instance.StringTrim(dr["branch_tel"]));
                    parameters[9] = new SQLiteParameter("@branch_fax", StringUtility.Instance.StringTrim(dr["branch_fax"]));

                    parameters[10] = new SQLiteParameter("@display_flag", StringUtility.Instance.StringTrim(dr["display_flag"]));
                    parameters[11] = new SQLiteParameter("@other1", StringUtility.Instance.StringTrim(dr["other1"]));
                    parameters[12] = new SQLiteParameter("@other2", StringUtility.Instance.StringTrim(dr["other2"]));
                    parameters[13] = new SQLiteParameter("@other3", StringUtility.Instance.StringTrim(dr["other3"]));
                    parameters[14] = new SQLiteParameter("@sheet_tag", StringUtility.Instance.StringTrim(dr["sheet_tag"]));

                    parameters[15] = new SQLiteParameter("@area", StringUtility.Instance.StringTrim(dr["area"]));
                    parameters[16] = new SQLiteParameter("@trade_type", StringUtility.Instance.StringTrim(dr["trade_type"]));
                    parameters[17] = new SQLiteParameter("@com_grant", StringUtility.Instance.StringTrim(dr["com_grant"]));
                    parameters[18] = new SQLiteParameter("@account", StringUtility.Instance.StringTrim(dr["account"]));
                    parameters[19] = new SQLiteParameter("@com_init", StringUtility.Instance.StringTrim(dr["com_init"]));

                    parameters[20] = new SQLiteParameter("@init_date", StringUtility.Instance.StringTrim(dr["init_date"]));
                    parameters[21] = new SQLiteParameter("@indep_bal", StringUtility.Instance.StringTrim(dr["indep_bal"]));
                    parameters[22] = new SQLiteParameter("@dc_no", StringUtility.Instance.StringTrim(dr["dc_no"]));
                    parameters[23] = new SQLiteParameter("@com_date_up", StringUtility.Instance.StringTrim(dr["com_date_up"]));
                    parameters[24] = new SQLiteParameter("@com_date_down", StringUtility.Instance.StringTrim(dr["com_date_down"]));

                    parameters[25] = new SQLiteParameter("@com_oper_up", StringUtility.Instance.StringTrim(dr["com_oper_up"]));
                    parameters[26] = new SQLiteParameter("@com_oper_down", StringUtility.Instance.StringTrim(dr["com_oper_down"]));
                    parameters[27] = new SQLiteParameter("@check_flag", StringUtility.Instance.StringTrim(dr["check_flag"]));
                    parameters[28] = new SQLiteParameter("@check_sheet_no", StringUtility.Instance.StringTrim(dr["check_sheet_no"]));
                    parameters[29] = new SQLiteParameter("@check_branch_no", StringUtility.Instance.StringTrim(dr["check_branch_no"]));

                    parameters[30] = new SQLiteParameter("@price_type", StringUtility.Instance.StringTrim(dr["price_type"]));
                    parameters[31] = new SQLiteParameter("@price_rate", StringUtility.Instance.StringTrim(dr["price_rate"]));
                    parameters[32] = new SQLiteParameter("@tran_flag", StringUtility.Instance.StringTrim(dr["tran_flag"]));
                    parameters[33] = new SQLiteParameter("@oper_flag", StringUtility.Instance.StringTrim(dr["oper_flag"]));
                    parameters[34] = new SQLiteParameter("@allow_cz", StringUtility.Instance.StringTrim(dr["allow_cz"]));

                    parameters[35] = new SQLiteParameter("@order_num", StringUtility.Instance.StringTrim(dr["order_num"]));
                    parameters[36] = new SQLiteParameter("@branch_mj", StringUtility.Instance.StringTrim(dr["branch_mj"]));

                    _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                    transList.Add(_current);
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertBranchList--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBranchList--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertBranchList--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool UpdateItemPrice(DataTable table,ref decimal rid)
        {
            String sql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sql = "update t_product_food set sale_price=@sale_price,price=@price where item_no=@item_no"; ;
                transList = new List<SqlParaEntity>();
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[3];
                    parameters[0] = new SQLiteParameter("@price", StringUtility.Instance.StringTrim(dr["price"]));
                    parameters[1] = new SQLiteParameter("@sale_price", StringUtility.Instance.StringTrim(dr["sale_price"]));
                    parameters[2] = new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"]));
                    _current = new SqlParaEntity() { Sql = sql, parameters = parameters };
                    transList.Add(_current);

                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (isok)
                {
                    string selectSql = "select max(lastchange_time) from t_product_food";
                    object data = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME,
                       selectSql, null, ref errorMessage);
                    string last_time = Gattr.LAST_UPDATE_TIME;
                    if (data != null)
                    {
                        last_time = ExtendUtility.Instance.ParseToDateTime(data).ToString();
                    }
                    WindowsAPIUtility.WritePrivateProfileString("download", "t_pos_branch_price", last_time, Gattr.INI_FILE_PATH);
                }
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "UpdateItemPrice--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdateItemPrice--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdateItemPrice--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool UpdateItemStock(DataTable table,ref decimal rid)
        {
            String sql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sql = "update t_product_food set stock=@stock where item_no=@item_no"; ;
                transList = new List<SqlParaEntity>();
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[2];
                    parameters[0] = new SQLiteParameter("@stock", StringUtility.Instance.StringTrim(dr["stock_qty"]));
                    parameters[1] = new SQLiteParameter("@item_no", StringUtility.Instance.StringTrim(dr["item_no"]));
                    _current = new SqlParaEntity() { Sql = sql, parameters = parameters };
                    transList.Add(_current);
                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (isok)
                {
                    string selectSql = "select max(lastchange_time) from t_product_food";
                    object data = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME,
                       selectSql, null, ref errorMessage);
                    string last_time = Gattr.LAST_UPDATE_TIME;
                    if (data != null)
                    {
                        last_time = ExtendUtility.Instance.ParseToDateTime(data).ToString();
                    }
                    WindowsAPIUtility.WritePrivateProfileString("download", "t_pos_branch_stock", last_time, Gattr.INI_FILE_PATH);
                }
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "UpdateItemStock--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdateItemStock--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "UpdateItemPrice--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public DataTable GetItemsByItemno(string item_no)
        {
            return null;
        }
        
        
        
        
        
        
        
        public bool UpdateItemStockByItem(string item_no, decimal order_qty, string db_no)
        {
            String sql = "";
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                if (db_no == "-")
                {
                    sql = "update t_product_food set stock=stock - @order_qty where item_no=@item_no"; ;
                }
                else
                {
                    sql = "update t_product_food set stock=stock + @order_qty where item_no=@item_no"; ;
                }
                SQLiteParameter[] parameters = new SQLiteParameter[2];
                parameters[0] = new SQLiteParameter("@order_qty", order_qty);
                parameters[1] = new SQLiteParameter("@item_no", item_no);
                isok = DbUtilitySQLite.Instance.ExecuteSql(Gattr.ITEM_DB_FILE_NAME, sql, parameters, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "ICE.POS->PosDal-->UpdateItemStockByItem--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->PosDal-->UpdateItemStockByItem--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->PosDal-->UpdateItemStockByItem--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertPlanRule(DataTable table)
        {
            String sql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sql = "insert into t_rm_plan_rule(rule_no,range_flag,rule_describe,rule_condition,rule_result,plu_flag) values (@rule_no,@range_flag,@rule_describe,@rule_condition,@rule_result,@plu_flag)"; ;
                transList = new List<SqlParaEntity>();
                _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_rm_plan_rule" };
                transList.Add(_current);
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[6];
                    parameters[0] = new SQLiteParameter("@rule_no", StringUtility.Instance.StringTrim(dr["rule_no"]));
                    parameters[1] = new SQLiteParameter("@range_flag", StringUtility.Instance.StringTrim(dr["range_flag"]));
                    parameters[2] = new SQLiteParameter("@rule_describe", StringUtility.Instance.StringTrim(dr["rule_describe"]));
                    parameters[3] = new SQLiteParameter("@rule_condition", StringUtility.Instance.StringTrim(dr["rule_condition"]));
                    parameters[4] = new SQLiteParameter("@rule_result", StringUtility.Instance.StringTrim(dr["rule_result"]));
                    parameters[5] = new SQLiteParameter("@plu_flag", StringUtility.Instance.StringTrim(dr["plu_flag"]));
                    _current = new SqlParaEntity() { Sql = sql, parameters = parameters };
                    transList.Add(_current);
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertPlanRule--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPlanRule--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPlanRule--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public bool InsertPlanMaster(DataTable table,decimal del,ref decimal rid)
        {
            this.DelPlanMaster();
            String sqlI = "";
            String sqlU = "";
            String sqlD = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_rm_plan_master(plan_no,plan_name,plan_memo,begin_date,end_date,week,vip_type,oper_date,oper_man,confirm_date,confirm_man,stop_date,stop_man,approve_flag,rule_no,range_flag) values (@plan_no,@plan_name,@plan_memo,@begin_date,@end_date,@week,@vip_type,@oper_date,@oper_man,@confirm_date,@confirm_man,@stop_date,@stop_man,@approve_flag,@rule_no,@range_flag)"; ;
                sqlU = "update t_rm_plan_master set plan_name=@plan_name,plan_memo=@plan_memo,begin_date=@begin_date,end_date=@end_date," +
                        "week=@week,vip_type=@vip_type,oper_date=@oper_date,oper_man=@oper_man,confirm_date=@confirm_date,confirm_man=@confirm_man," +
                        "stop_date=@stop_date,stop_man=@stop_man,approve_flag=@approve_flag,rule_no=@rule_no,range_flagrange_flag=@range_flagrange_flag "+
                        "WHERE plan_no=@plan_no";
                sqlD = "delete from t_rm_plan_master where plan_no=@plan_no";
                transList = new List<SqlParaEntity>();
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_rm_plan_master" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[16];
                    parameters[0] = new SQLiteParameter("@plan_no", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["plan_no"])));
                    parameters[1] = new SQLiteParameter("@plan_name", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["plan_name"])));
                    parameters[2] = new SQLiteParameter("@plan_memo", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["plan_memo"])));
                    parameters[3] = new SQLiteParameter("@begin_date", ExtendUtility.Instance.ParseToString(ExtendUtility.Instance.ParseToDateTime(StringUtility.Instance.StringTrim(dr["begin_date"])).ToString(Gattr.DateFormat)));
                    parameters[4] = new SQLiteParameter("@end_date", ExtendUtility.Instance.ParseToString(ExtendUtility.Instance.ParseToDateTime(StringUtility.Instance.StringTrim(dr["end_date"])).ToString(Gattr.DateFormat)));
                    parameters[5] = new SQLiteParameter("@week", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["week"])));
                    parameters[6] = new SQLiteParameter("@vip_type", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["vip_type"])));
                    parameters[7] = new SQLiteParameter("@oper_date", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["oper_date"])));
                    parameters[8] = new SQLiteParameter("@oper_man", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["oper_man"])));
                    parameters[9] = new SQLiteParameter("@confirm_date", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["confirm_date"])));
                    parameters[10] = new SQLiteParameter("@confirm_man", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["confirm_man"])));
                    parameters[11] = new SQLiteParameter("@stop_date", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["stop_date"])));
                    parameters[12] = new SQLiteParameter("@stop_man", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["stop_man"])));
                    parameters[13] = new SQLiteParameter("@approve_flag", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["approve_flag"])));
                    parameters[14] = new SQLiteParameter("@rule_no", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["rule_no"])));
                    parameters[15] = new SQLiteParameter("@range_flag", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["range_flag"])));
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = new SQLiteParameter[] { new SQLiteParameter("@plan_no", StringUtility.Instance.StringTrim(dr["plan_no"])) } };
                            break;
                    }
                    transList.Add(_current);
                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertPlanMaster--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPlanMaster--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPlanMaster--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }

        //删除所有促销方案主表记录
        public bool DelPlanMaster()
        {
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;

            transList = new List<SqlParaEntity>();
            _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_rm_plan_master" };
            transList.Add(_current);

            bool isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;

            return isok;
        }



        public bool InsertPlanDetail(DataTable table,decimal del,ref decimal rid)
        {
            this.DelPlanDetail();
            String sqlI = "";
            String sqlU = "";
            String sqlD = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                sqlI = "insert into t_rm_plan_detail(plan_no,row_id,rule_para,rule_val) values (@plan_no,@row_id,@rule_para,@rule_val)";
                sqlU = "update t_rm_plan_detail set row_id=@row_id,rule_para=@rule_para,rule_val=@rule_val where plan_no=@plan_no";
                sqlD = "delete from t_rm_plan_detail where plan_no=@plan_no and row_id=@row_id and rule_para=@rule_para and rule_val=@rule_val ";
                transList = new List<SqlParaEntity>();
                if (del == -1)
                {
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_rm_plan_detail" };
                    transList.Add(_current);
                }
                foreach (DataRow dr in table.Rows)
                {
                    parameters = new SQLiteParameter[4];
                    parameters[0] = new SQLiteParameter("@plan_no", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["plan_no"])));
                    parameters[1] = new SQLiteParameter("@row_id", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["row_id"])));
                    parameters[2] = new SQLiteParameter("@rule_para", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["rule_para"])));
                    parameters[3] = new SQLiteParameter("@rule_val", ExtendUtility.Instance.ParseToString(StringUtility.Instance.StringTrim(dr["rule_val"])));
                    switch (dr["rtype"].ToString())
                    {
                        //插入状态
                        case "I":
                            _current = new SqlParaEntity() { Sql = sqlI, parameters = parameters };
                            break;
                        //更新状态
                        case "U":
                            _current = new SqlParaEntity() { Sql = sqlU, parameters = parameters };
                            break;
                        //删除状态
                        case "D":
                            _current = new SqlParaEntity() { Sql = sqlD, parameters = parameters };
                            break;
                    }
                    transList.Add(_current);
                    //获取rid最大值
                    if (ExtendUtility.Instance.ParseToDecimal(dr["rid"]) > rid)
                    {
                        rid = ExtendUtility.Instance.ParseToDecimal(dr["rid"]);
                    }
                }
                //rid = -1;
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "InsertPlanDetail--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPlanDetail--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertPlanDetail--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }

        //删除所有促销方案主表记录
        public bool DelPlanDetail()
        {
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            String errorMessage = String.Empty;

            transList = new List<SqlParaEntity>();
            _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_rm_plan_detail" };
            transList.Add(_current);

            bool isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;

            return isok;
        }

        #endregion

        #region 保存非交易记录
        public bool InNonTrading(t_cur_payflow _payflow)
        {
            SQLiteTransaction transaction = base.dbPosSale.BeginTransaction();
            try
            {
                SQLiteCommand command2 = this.BuildCommandForNonTradingPayRow(_payflow);
                command2.Transaction = transaction;
                command2.ExecuteNonQuery();

                transaction.Commit();
                return true;
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw new Exception(exception.Message);
            }
            //return false;
        }
        
        
        
        
        
        private SQLiteCommand BuildCommandForNonTradingPayRow(t_cur_payflow payflow)
        {
            StringBuilder builder2 = new StringBuilder();
            builder2.Append("Insert into t_app_payflow (flow_id,flow_no,sale_amount,pay_way,pay_amount,coin_type,pay_name,coin_rate,convert_amt,card_no,memo,oper_date,oper_id,voucher_no,branch_no,pos_id,sale_way)");
            builder2.Append(" values(@flow_id,@flow_no,@sale_amount,@pay_way,@pay_amount,@coin_type,@pay_name,@coin_rate,@convert_amt,@card_no,@memo,@oper_date,@oper_id,@voucher_no,@branch_no,@pos_id,@sale_way)");
            SQLiteCommand command = new SQLiteCommand(builder2.ToString(), base.dbPosSale);
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@flow_id", payflow.flow_id);
            dictionary.Add("@flow_no", payflow.flow_no);
            dictionary.Add("@sale_amount", payflow.sale_amount);
            dictionary.Add("@pay_amount", payflow.pay_amount);
            dictionary.Add("@pay_way", payflow.pay_way);
            dictionary.Add("@card_no", payflow.card_no);
            dictionary.Add("@memo", payflow.memo);
            dictionary.Add("@pay_name", payflow.pay_name);
            dictionary.Add("@coin_type", payflow.coin_type);
            dictionary.Add("@coin_rate", payflow.coin_rate);
            dictionary.Add("@convert_amt", payflow.convert_amt);
            dictionary.Add("@oper_date", ExtendUtility.Instance.ParseToDateTime(payflow.oper_date).ToString("s"));
            dictionary.Add("@oper_id", payflow.oper_id);
            dictionary.Add("@voucher_no", payflow.voucher_no);
            dictionary.Add("@branch_no", payflow.branch_no);
            dictionary.Add("@pos_id", payflow.pos_id);
            dictionary.Add("@sale_way", payflow.sale_way);
            foreach (string str2 in dictionary.Keys)
            {
                SQLiteParameter parameter = new SQLiteParameter(str2, dictionary[str2]);
                command.Parameters.Add(parameter);
            }
            return command;
        }
        #endregion

        #region 获取流水号
        public int GetIntFlow(string flowNo)
        {
            int num = 0;
            SQLiteCommand command = new SQLiteCommand(string.Format("select flow_no from t_app_payflow where flow_no like '{0}%' order by flow_no desc limit 1 ", flowNo), base.dbPosSale);
            object obj2 = command.ExecuteScalar();
            if ((obj2 != null) && (obj2.ToString().Length >= 0x13))
            {
                num = Convert.ToInt32(obj2.ToString().Substring(obj2.ToString().Length - 5, 5));
            }
            command.Dispose();
            return num;
        }
        #endregion

        #region 挂单流水号
        public string GetMaxPendingOrderFlow()
        {
            object obj2 = null;
            string str2;
            string commandText = "SELECT MAX(flow_no) FROM t_pending_order";
            try
            {
                obj2 = new SQLiteCommand(commandText, base.dbPosSale).ExecuteScalar();
                if (obj2 == null)
                {
                    return "";
                }
                str2 = obj2.ToString();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return str2;
        }
        #endregion

        #region 收银对帐
        
        
        
        
        public DateTime? GetLastAccountTime()
        {
            string commandText = "SELECT max(end_time) from t_rm_pos_account where branch_no ='" + Gattr.BranchNo + "' and pos_id ='" + Gattr.PosId + "'";// and cashier_id = '" + Gattr.CashierNo + "'";
            DateTime now = DateTime.Now;
            SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
            object obj2 = command.ExecuteScalar();
            command.Dispose();
            if (((obj2 != null) && (obj2 != DBNull.Value)) && DateTime.TryParse(obj2.ToString(), out now))
            {
                return new DateTime?(now);
            }
            return null;
        }
        
        
        
        
        
        
        public decimal GetSumAccountAmt(DateTime dtStart, DateTime dtEnd)
        {
            string str = Gattr.BranchNo + "%";
            string commandText = "select sum((case sale_way when 'A' then pay_amount when 'B' then -pay_amount when 'D' then -pay_amount else 0 end) * coin_rate)  from t_app_payflow where oper_id = '" + Gattr.OperId + "' and  oper_date between '" + dtStart.ToString("s") + "' and '" + dtEnd.ToString("s") + "'  and branch_no like '" + str + "' and pay_way <> 'DJF' ";
            decimal result = 0M;
            SQLiteCommand command = new SQLiteCommand(commandText, base.dbPosSale);
            object obj2 = command.ExecuteScalar();
            command.Dispose();
            if ((obj2 != null) && (obj2 != DBNull.Value))
            {
                decimal.TryParse(obj2.ToString(), out result);
            }
            return result;
        }
        
        
        
        
        
        
        
        public void GetQueryPeriod(DateTime? dtLast, out DateTime dtStart, out DateTime dtEnd, out bool hasData)
        {
            string str;
            DateTime time = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            dtStart = DateTime.Now;
            dtEnd = DateTime.Now;
            hasData = false;
            string str2 = Gattr.BranchNo + "%";
            if (!dtLast.HasValue)
            {
                str = "select min(oper_date) as min_oper, max(oper_date) as max_oper from t_app_payflow where branch_no like '" + str2 + "' and oper_id = '" + Gattr.OperId + "'  and oper_date >='" + time.ToString("s") + "'";
            }
            else
            {
                str = "select min(oper_date) as min_oper, max(oper_date) as max_oper from t_app_payflow where branch_no like '" + str2 + "' and oper_id = '" + Gattr.OperId + "'  and oper_date >'" + Convert.ToDateTime(dtLast).ToString("s") + "'";
            }
            SQLiteCommand command = new SQLiteCommand(str, base.dbPosSale);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string str3 = reader["min_oper"].ToString();
                string str4 = reader["max_oper"].ToString();
                if (string.IsNullOrEmpty(str3))
                {
                    str3 = "";
                }
                if (string.IsNullOrEmpty(str4))
                {
                    str4 = "";
                }
                if ((str3.Trim() == "") || (str4.Trim() == ""))
                {
                    reader.Close();
                    command.Dispose();
                    hasData = false;
                    if (dtLast.HasValue)
                    {
                        dtStart = Convert.ToDateTime(dtLast);
                    }
                    return;
                }
                DateTime.TryParse(reader["min_oper"].ToString(), out dtStart);
                DateTime.TryParse(reader["max_oper"].ToString(), out dtEnd);
                hasData = true;
            }
            else
            {
                dtStart = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                dtEnd = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                hasData = false;
            }
            reader.Close();
            command.Dispose();
        }
        #endregion
        
        
        
        
        
        public string GetBranchName(string branchNo)
        {
            string strsql = "select branch_name from t_branch_info where trim(branch_no) = @branchNo";
            object objA = null;
            try
            {
                objA = base.dbPosItem.GetObjectSingle(strsql, new SQLiteParameter[] { new SQLiteParameter("@branchNo", branchNo) });
            }
            catch (SQLiteException exception)
            {
                throw new Exception(exception.Message);
            }
            if (object.Equals(objA, null) || object.Equals(DBNull.Value, objA))
            {
                return "";
            }
            return objA.ToString();
        }
        
        
        
        
        
        
        
        
        public DataSet GetPayCash(string branchNo, string cashierId, DateTime dtFrom, DateTime dtTo)
        {
            DataSet set = new DataSet();
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT count(1) as count, min(oper_date) as min_date, max(oper_date) as max_date FROM t_app_payflow ");
                builder.AppendFormat("WHERE pay_way <> 'DJF' and flow_id = 1 AND branch_no like '{0}%' and  oper_id ='{1}' and datetime(oper_date) >= '{2}' AND datetime(oper_date) <= '{3}' ", new object[] { branchNo, cashierId, dtFrom.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.ToString("yyyy-MM-dd HH:mm:ss") });
                DataTable dataTable = new DataTable("t_rm_cashier_info");
                new SQLiteDataAdapter(builder.ToString(), base.dbPosSale).Fill(dataTable);
                set.Tables.Add(dataTable);
                builder = null;
                builder = new StringBuilder();
                builder.Append("SELECT count(1) as count,sum(unit_price*sale_qnty) as amount FROM t_app_saleflow ");
                builder.AppendFormat(" WHERE branch_no like '{0}%' and sale_way='C' and oper_id = '{1}' and datetime(oper_date) >= '{2}' AND datetime(oper_date) <= '{3}' ", new object[] { branchNo, cashierId, dtFrom.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.ToString("yyyy-MM-dd HH:mm:ss") });
                DataTable table2 = new DataTable("t_rm_scash_info");
                new SQLiteDataAdapter(builder.ToString(), base.dbPosSale).Fill(table2);
                set.Tables.Add(table2);
                builder = null;
                builder = new StringBuilder();
                builder.Append("select  pay_way,sale_way,sum( count) as count,sum(amount) as amount,memo ");
                builder.Append("from (SELECT pay_way,sale_way,count(distinct flow_no) as count,sum(pay_amount) as amount,(case  when substr(memo,1,4)='储值项目' then '1' when substr(memo,1,4)='储值卡充' then '2' when memo='储值卡项目充值' then '3' else '0' end) as memo  FROM t_app_payflow ");
                builder.AppendFormat(" WHERE pay_way <> 'DJF' and branch_no like '{0}%' and sale_way in ('A','B','C','D') and oper_id = '{1}' and datetime(oper_date) >= '{2}' AND datetime(oper_date) <= '{3}' ", new object[] { branchNo, cashierId, dtFrom.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.ToString("yyyy-MM-dd HH:mm:ss") });
                builder.Append(" group by pay_way,sale_way ,memo");
                builder.Append(" )aa ");
                builder.Append(" group by pay_way,sale_way,memo ");
                DataTable table3 = new DataTable("t_rm_jycash_info");
                table3.Columns.Add(new DataColumn("pay_way", typeof(string)));
                table3.Columns.Add(new DataColumn("sale_way", typeof(string)));
                table3.Columns.Add(new DataColumn("count", typeof(int)));
                table3.Columns.Add(new DataColumn("amount", typeof(decimal)));
                table3.Columns.Add(new DataColumn("memo", typeof(string)));
                new SQLiteDataAdapter(builder.ToString(), base.dbPosSale).Fill(table3);
                set.Tables.Add(table3);
                builder = null;
                List<t_dict_payment_info> paymentInfo = this.GetPaymentInfo(" pay_flag = '1' or pay_flag='6' ");
                StringBuilder builder2 = new StringBuilder();
                builder2.AppendFormat("'RMB'", new object[0]);
                if (paymentInfo != null)
                {
                    foreach (t_dict_payment_info _info in paymentInfo)
                    {
                        builder2.AppendFormat(",'{0}'", _info.pay_way);
                    }
                }
                builder = new StringBuilder();
                builder.AppendFormat("SELECT ifnull(sum(CASE sale_way when 'A' THEN pay_amount when 'B' THEN -pay_amount when 'D' THEN -pay_amount else 0 END),0) as SumRMB ", new object[0]);
                builder.AppendFormat(" FROM t_app_payflow ", new object[0]);
                builder.AppendFormat("where pay_way in ({4}) and branch_no like '{0}%' and oper_id = '{1}' and datetime(oper_date) >= '{2}' AND datetime(oper_date) <= '{3}' ", new object[] { branchNo, cashierId, dtFrom.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.ToString("yyyy-MM-dd HH:mm:ss"), builder2.ToString() });
                DataTable table4 = new DataTable("t_rm_rmbcash_info");
                new SQLiteDataAdapter(builder.ToString(), base.dbPosSale).Fill(table4);
                set.Tables.Add(table4);
                builder = null;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return set;
        }
        
        
        
        
        
        
        
        
        public bool InsertAccountRecord(DateTime dtStart, DateTime dtEnd, decimal sumAmt,decimal sumMoney, out string errMsg)
        {
            try
            {
                errMsg = "";
                SQLiteCommand command = new SQLiteCommand("INSERT INTO t_rm_pos_account(branch_no,pos_id,oper_id,oper_date,start_time,end_time,sale_amt,hand_amt,com_flag)  VALUES ('" + Gattr.BranchNo + "','" + Gattr.PosId + "','" + Gattr.OperId + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dtStart.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dtEnd.ToString("yyyy-MM-dd HH:mm:ss") + "'," + sumAmt.ToString() + ","+sumMoney.ToString()+", '0') ", base.dbPosSale);
                command.ExecuteNonQuery();
                command.Dispose();
                command = null;
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }
        
        
        
        
        
        
        
        
        public DataTable ItemAccountStatement(string branchNo, string cashierId, DateTime dtFrom, DateTime dtTo)
        {
            DataTable dataTable = new DataTable();
            DataTable table2 = new DataTable();
            string commandText = "SELECT item_no,item_name FROM t_product_food";
            new SQLiteDataAdapter(commandText, base.dbPosItem.ConnectionString).Fill(dataTable);
            new SQLiteDataAdapter(string.Format(" SELECT t_app_saleflow.item_no,sum(t_app_saleflow.sale_qnty) as sale_qnty,t_app_saleflow.sale_price,t_app_saleflow.sale_way FROM t_app_saleflow WHERE ( datetime(t_app_saleflow.oper_date) >= '{0}' AND datetime(t_app_saleflow.oper_date) <= '{1}' ) AND ( t_app_saleflow.oper_id = '{2}' )  and (t_app_saleflow.branch_no = '{3}')  GROUP BY t_app_saleflow.item_no, t_app_saleflow.sale_price,t_app_saleflow.sale_way ", new object[] { dtFrom.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.ToString("yyyy-MM-dd HH:mm:ss"), cashierId, branchNo }), base.dbPosSale).Fill(table2);
            if (table2 != null)
            {
                table2.Columns.Add("item_name");
            }
            foreach (DataRow row in table2.Rows)
            {
                string str3 = row["item_no"].ToString().Trim().ToLower();
                DataRow[] rowArray = dataTable.Select(string.Format("item_no='{0}'", str3.Replace("'", "''")));
                if ((rowArray != null) && (rowArray.Length > 0))
                {
                    row["item_name"] = rowArray[0]["item_name"];
                }
            }
            return table2;
        }



        #region 基础信息获取
        
        
        
        
        public List<t_sys_pos_set> GetPosSets()
        {
            List<t_sys_pos_set> sets = null;
            String sql = String.Empty;
            String errorMessage = String.Empty;
            try
            {
                sql = "select sys_var_id,sys_var_value from t_sys_setting";

                sets = DbUtilitySQLite.Instance.GetDataList<t_sys_pos_set>(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sets;
        }
        #endregion

        #region 促销信息获取
        
        
        
        
        
        
        
        
        public DataTable GetPlanMaster(string plu_flag, string rule_no, string plan_no, string rrule_no, string vip_type)
        {
            DataTable table = null;
            string sql = "";
            string errorMessage = "";
            try
            {
                sql = "SELECT   " +
"	b.plan_no AS plan_no,   " +
"	b.rule_no AS rule_no,   " +
"	b.range_flag AS range_flag, " +
"	b.vip_type as vip_type,  " +
"	b.rule_condition AS rule_condition,  " +
"	b.rule_describe AS rule_describe,   " +
"	b.rule_result AS rule_result,   " +
"	b.plu_flag AS plu_flag  " +
"FROM   " +
"	(   " +
"		SELECT  " +
"			a.plan_no AS plan_no,   " +
"			a.rule_no AS rule_no,   " +
"			a.range_flag AS range_flag, " +
"				a.vip_type as vip_type,  " +
"			CASE a.range_flag   " +
"		WHEN 'I' THEN   " +
"			4   " +
"		WHEN 'B' THEN   " +
"			3   " +
"		WHEN 'C' THEN   " +
"			2   " +
"		ELSE    " +
"			1   " +
"		END AS range_mark,  " +
"		r.rule_describe AS rule_describe,   " +
"		r.rule_condition AS rule_condition, " +
"		r.rule_result AS rule_result,   " +
"		r.plu_flag AS plu_flag  " +
"	FROM    " +
"		(   " +
"			SELECT  " +
"				m.plan_no,  " +
"				m.vip_type,  " +
"				CASE    " +
"			WHEN strftime('%w', 'now') > '0' THEN " +
"				strftime('%w', 'now')   " +
"			ELSE    " +
"				7   " +
"			END AS week1,   " +
"			m.rule_no,  " +
"			m.range_flag,   " +
"			m.week  " +
"		FROM    " +
"			t_rm_plan_master m  " +
"		WHERE   " +
"			datetime(m.begin_date) <= datetime('now', 'localtime')  " +
"		AND datetime(m.end_date) >= datetime('now', 'localtime')    " +
"		AND m.approve_flag = '1'   AND length(m.stop_man)=0 " +
"		) a " +
"	LEFT JOIN t_rm_plan_rule r ON a.rule_no = r.rule_no " +
"	AND a.range_flag = r.range_flag " +
"	WHERE   " +
"		substr(a.week, a.week1, 1) = '1'    " +
"	) b             ";

                if (!string.IsNullOrEmpty(plu_flag))
                {
                    sql = sql + " where  b.plu_flag='{0}'";
                    sql = string.Format(sql, plu_flag);
                }
                if (!string.IsNullOrEmpty(rule_no))
                {
                    sql = sql + " and  b.rule_no='{0}'";
                    sql = string.Format(sql, rule_no);
                }
                if (!string.IsNullOrEmpty(plan_no))
                {
                    sql = sql + " and  b.plan_no <> '{0}'   ";
                    sql = string.Format(sql, plan_no);
                }

                if (!string.IsNullOrEmpty(rrule_no))
                {
                    sql = sql + " and  b.rule_no not in ({0})  ";
                    sql = string.Format(sql, rrule_no);
                }
                if (!string.IsNullOrEmpty(vip_type))
                {
                    sql = sql + "   and (b.vip_type like '%" + vip_type + "%' and  length(b.vip_type)>0 )";
                }
                sql += "ORDER BY           " +
                "	b.range_mark  DESC";
                table = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanMaster--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanMaster--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        
        
        
        
        
        public DataTable GetPlanDetail(DataTable table)
        {
            DataTable tableDesc = null;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                tableDesc = new DataTable();
                string[] columns = new string[] { "plan_no", "rule_no", "range_flag", "rule_describe", "rule_condition", "rule_result", "rule_desc", "plu_flag" };
                foreach (string str in columns)
                {
                    DataColumn dc = new DataColumn(str);
                    if (!tableDesc.Columns.Contains(str))
                    {
                        tableDesc.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr in table.Rows)
                {
                    string rule_no = ExtendUtility.Instance.ParseToString(dr["rule_no"]);
                    string range_flag = ExtendUtility.Instance.ParseToString(dr["range_flag"]);
                    string plan_no = ExtendUtility.Instance.ParseToString(dr["plan_no"]);
                    StringBuilder sb = new StringBuilder();
                    #region 组合商品
                    if (rule_no == "PG")//组合商品
                    {
                        sql = "select row_id,rule_para,rule_val from t_rm_plan_detail where plan_no='{0}'";
                        sql = string.Format(sql, plan_no);
                        DataTable tempTable = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                        DataRow drNew1 = tableDesc.NewRow();
                        drNew1["plan_no"] = plan_no;
                        drNew1["rule_no"] = ExtendUtility.Instance.ParseToString(dr["rule_no"]);
                        drNew1["range_flag"] = ExtendUtility.Instance.ParseToString(dr["range_flag"]);
                        drNew1["rule_condition"] = ExtendUtility.Instance.ParseToString(dr["rule_condition"]);
                        drNew1["rule_describe"] = ExtendUtility.Instance.ParseToString(dr["rule_describe"]).Replace("多少", "N");
                        drNew1["rule_result"] = ExtendUtility.Instance.ParseToString(dr["rule_result"]);
                        drNew1["plu_flag"] = ExtendUtility.Instance.ParseToString(dr["plu_flag"]);

                        sql = " SELECT distinct d.row_id FROM t_rm_plan_detail d WHERE d.plan_no='{0}' ";
                        sql = string.Format(sql, dr["plan_no"]).ToString();
                        DataTable rowIdTable = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                        foreach (DataRow drId in rowIdTable.Rows)
                        {
                            string row_id = drId["row_id"].ToString();
                            DataRow[] drIds = tempTable.Select("row_id=" + row_id);
                            string r_row_id = row_id.Replace("G", "");
                            if (drIds != null && drIds.Length > 0)
                            {
                                string keyItem = "ITEM" + r_row_id; ;
                                DataRow[] drItem1 = tempTable.Select("rule_para='" + keyItem + "'");
                                if (drItem1 != null && drItem1.Length > 0)
                                {
                                    sb.Append("商品" + GetItemName(drItem1[0]["rule_val"].ToString()));
                                }
                                string keyT1 = "T" + r_row_id; ;
                                DataRow[] drR1 = tempTable.Select("rule_para='" + keyT1 + "'");
                                if (drR1 != null && drR1.Length > 0)
                                {
                                    sb.Append("买满" + drR1[0]["rule_val"].ToString());
                                }
                                string keyR1 = "R" + r_row_id; ;
                                DataRow[] drPrice = tempTable.Select("rule_para='" + keyR1 + "'");
                                if (drPrice != null && drPrice.Length > 0)
                                {
                                    sb.Append("特价" + drPrice[0]["rule_val"].ToString());
                                }
                            }
                            if (sb.ToString().Length > 0)
                            {
                                sb.Append(",");
                            }
                        }
                        if (sb.ToString().Length > 0)
                        {
                            drNew1["rule_desc"] = sb.ToString().Substring(0, sb.ToString().Length - 1);
                        }
                        tableDesc.Rows.Add(drNew1);
                    }
                    #endregion
                    else
                    {
                        #region 非组合商品
                        sql = " SELECT distinct d.row_id FROM t_rm_plan_detail d WHERE d.plan_no='{0}' ";
                        sql = string.Format(sql, dr["plan_no"]).ToString();
                        DataTable rowIdTable = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                        foreach (DataRow drRowId in rowIdTable.Rows)
                        {
                            sb = new StringBuilder();
                            string row_id = drRowId["row_id"].ToString();
                            sql = " SELECT d.rule_para,d.rule_val FROM t_rm_plan_detail d WHERE d.plan_no='{0}' and row_id='{1}' ";
                            sql = string.Format(sql, dr["plan_no"].ToString(), row_id);
                            DataTable table1 = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                            DataRow drNew = tableDesc.NewRow();
                            string model = rule_no.Substring(0, 1).ToUpper();
                            string type = rule_no.Substring(1).ToUpper();
                            drNew["plan_no"] = ExtendUtility.Instance.ParseToString(dr["plan_no"]);
                            drNew["rule_no"] = ExtendUtility.Instance.ParseToString(dr["rule_no"]);
                            drNew["range_flag"] = ExtendUtility.Instance.ParseToString(dr["range_flag"]);
                            drNew["rule_condition"] = ExtendUtility.Instance.ParseToString(dr["rule_condition"]);
                            drNew["rule_describe"] = ExtendUtility.Instance.ParseToString(dr["rule_describe"]).Replace("多少", "N");
                            drNew["rule_result"] = ExtendUtility.Instance.ParseToString(dr["rule_result"]);
                            drNew["plu_flag"] = ExtendUtility.Instance.ParseToString(dr["plu_flag"]);
                            decimal discost = 0M;
                            decimal amt = 0M;
                            decimal qty = 0M;
                            decimal price = 0M;
                            string cls = "";
                            string brand = "";
                            string item = "";
                            DataRow[] drCls = table1.Select("rule_para like 'CLS%'");
                            if (drCls != null && drCls.Length > 0)
                            {
                                cls = GetClsNameByClsNo(ExtendUtility.Instance.ParseToString(drCls[0]["rule_val"]));
                            }
                            DataRow[] drBrand = table1.Select("rule_para like 'BRAND%'");
                            if (drBrand != null && drBrand.Length > 0)
                            {
                                brand = GetBrandName(ExtendUtility.Instance.ParseToString(drBrand[0]["rule_val"]));
                            }
                            DataRow[] drItem = table1.Select("rule_para like 'ITEM%'");
                            if (drItem != null && drItem.Length > 0)
                            {
                                item = GetItemName(ExtendUtility.Instance.ParseToString(drItem[0]["rule_val"]));
                            }
                            if (model == "D")
                            {
                                #region 折扣操作
                                DataRow[] drDis = table1.Select("rule_para='R1'");
                                if (drDis != null && drDis.Length >= 0)
                                {
                                    discost = ExtendUtility.Instance.ParseToDecimal(drDis[0]["rule_val"]);
                                }
                                if (type == "A")
                                {
                                    DataRow[] drAmt = table1.Select("rule_para='T1'");
                                    if (drAmt != null && drAmt.Length >= 0)
                                    {
                                        amt = ExtendUtility.Instance.ParseToDecimal(drAmt[0]["rule_val"]);
                                    }
                                    drNew["rule_desc"] = "买满金额" + amt + "元打折" + discost + "%";
                                }
                                else if (type == "Q")
                                {
                                    DataRow[] drQty = table1.Select("rule_para='T1'");
                                    if (drQty != null && drQty.Length >= 0)
                                    {
                                        qty = ExtendUtility.Instance.ParseToDecimal(drQty[0]["rule_val"]);
                                    }
                                    drNew["rule_desc"] = "买满数量" + qty + "打折" + discost + "%";
                                }
                                switch (range_flag)
                                {
                                    case "B":
                                        drNew["rule_desc"] = "品牌:" + brand + drNew["rule_desc"].ToString();
                                        break;
                                    case "C":
                                        drNew["rule_desc"] = "分类:" + cls + drNew["rule_desc"].ToString();
                                        break;
                                    case "I":
                                        drNew["rule_desc"] = "商品:" + item + drNew["rule_desc"].ToString();
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                            }
                            else if (model == "P")
                            {
                                #region 特价操作
                                DataRow[] drPr = table1.Select("rule_para='R1'");
                                if (drPr != null && drPr.Length >= 0)
                                {
                                    price = ExtendUtility.Instance.ParseToDecimal(drPr[0]["rule_val"]);
                                }
                                switch (type)
                                {
                                    case "E"://偶数特价
                                    case "S"://直接特价
                                        if (type == "E")
                                        {
                                            drNew["rule_desc"] = "购买偶数商品" + item + "价格" + price;
                                        }
                                        else
                                        {
                                            drNew["rule_desc"] = "购买商品" + item + "价格" + price;
                                        }
                                        break;
                                    case "G"://产品组合特价
                                        //drNew["rule_desc"] = "商品" + "价格" + "%";
                                        break;
                                    case "Q"://数量特价
                                        DataRow[] drT = table1.Select("rule_para='T1'");
                                        if (drT != null && drT.Length >= 0)
                                        {
                                            qty = ExtendUtility.Instance.ParseToDecimal(drT[0]["rule_val"]);
                                        }
                                        drNew["rule_desc"] = "商品:" + item + "买满" + qty + "价格" + price;
                                        break;
                                }
                                #endregion
                            }
                            else if (model == "F")
                            {
                                switch (type)
                                {
                                    case "G":
                                    case "I":
                                        #region 买满送
                                        string key1 = "T1";
                                        if (type == "I")
                                        {
                                            key1 = "T2";
                                        }
                                        DataRow[] drItemT1 = table1.Select("rule_para ='" + key1 + "'");
                                        if (drItemT1 != null && drItemT1.Length > 0)
                                        {
                                            if (key1 == "T2")
                                            {
                                                sb.Append("买满金额" + drItemT1[0]["rule_val"].ToString());
                                            }
                                            else
                                            {
                                                sb.Append("买满数量" + drItemT1[0]["rule_val"].ToString());
                                            }
                                        }
                                        if (type == "I")
                                        {
                                            DataRow[] drItemT12 = table1.Select("rule_para ='T1'");
                                            if (drItemT12 != null && drItemT12.Length > 0)
                                            {
                                                sb.Append("加" + drItemT12[0]["rule_val"].ToString());
                                            }
                                        }
                                        DataRow[] drSendG = table1.Select("rule_para like 'BARCODE%'");
                                        if (drSendG != null && drSendG.Length > 0)
                                        {
                                            sb.Append("送");

                                            string barcode = string.Empty;
                                            string rkey = string.Empty;
                                            foreach (DataRow drG1 in drSendG)
                                            {
                                                barcode = drG1["rule_para"].ToString();
                                                rkey = barcode.Replace("BARCODE", "");
                                                sb.Append("商品:" + GetItemName(drG1["rule_val"].ToString()));
                                                string qkey = "R" + rkey;
                                                DataRow[] drSendQ = table1.Select("rule_para='" + qkey + "'");
                                                if (drSendQ != null && drSendQ.Length > 0)
                                                {
                                                    sb.Append("数量:" + drSendQ[0]["rule_val"].ToString());
                                                }
                                            }
                                        }
                                        #endregion
                                        break;
                                    case "R":
                                    case "S":
                                        DataRow[] drItemT13 = table1.Select("rule_para ='T1'");
                                        if (drItemT13 != null && drItemT13.Length > 0)
                                        {
                                            sb.Append("买满金额" + drItemT13[0]["rule_val"].ToString());
                                        }
                                        DataRow[] drItemT14 = table1.Select("rule_para ='R1'");
                                        if (drItemT14 != null && drItemT14.Length > 0)
                                        {
                                            if (type == "R")
                                            {
                                                sb.Append("直减" + drItemT14[0]["rule_val"].ToString());
                                            }
                                            else
                                            {
                                                sb.Append("倍数减" + drItemT14[0]["rule_val"].ToString());
                                            }
                                        }
                                        break;
                                }
                                if (sb.ToString().Length > 0)
                                {
                                    drNew["rule_desc"] = sb.ToString();
                                }
                                switch (range_flag)
                                {
                                    case "B":
                                        drNew["rule_desc"] = "品牌:" + brand + drNew["rule_desc"].ToString();
                                        break;
                                    case "C":
                                        drNew["rule_desc"] = "分类:" + cls + drNew["rule_desc"].ToString();
                                        break;
                                    case "I":
                                        drNew["rule_desc"] = "商品:" + item + drNew["rule_desc"].ToString();
                                        break;
                                    default:
                                        break;
                                }
                            }
                            tableDesc.Rows.Add(drNew);
                        }
                        #endregion
                    }
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanDetail--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanDetail--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return tableDesc;
        }
        
        
        
        
        
        public DataTable GetPlanDetailByPlanNo(string plan_no)
        {
            DataTable table = null;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select plan_no,row_id,rule_para,rule_val from t_rm_plan_detail where plan_no='{0}'";
                sql = string.Format(sql, plan_no);
                table = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanDetailByPlanNo--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanDetailByPlanNo--->>SQLiteException>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        
        
        
        
        
        
        public PlanRule GetPlanRuleInfo(string rule_no, string range_flag)
        {
            PlanRule table = null;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select rule_no,range_flag,rule_condition,rule_result from t_rm_plan_rule where rule_no='{0}' and range_flag='{1}'";
                sql = string.Format(sql, rule_no, range_flag);
                List<PlanRule> _list = DbUtilitySQLite.Instance.GetDataList<PlanRule>(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                if (_list != null && _list.Count > 0)
                {
                    table = _list[0];
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanRuleInfo--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetPlanRuleInfo--->>SQLiteException>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        #endregion
        #region
        
        
        
        
        
        public string GetClsNameByClsNo(string cls_no)
        {
            string cls_name = string.Empty;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select typename from t_product_food_type where typeno='{0}'";
                sql = string.Format(sql, cls_no);
                object result = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                cls_name = ExtendUtility.Instance.ParseToString(result);
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetClsNameByClsNo--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetClsNameByClsNo--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return cls_name;
        }
        
        
        
        
        
        public string GetBrandName(string brand)
        {
            string brand_name = string.Empty;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select code_name from t_base_code where code_id='{0}' and type_no='{1}'";
                sql = string.Format(sql, brand, "PP");
                object result = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                brand_name = ExtendUtility.Instance.ParseToString(result);
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetBrandName--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetBrandName--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return brand_name;
        }
        
        
        
        
        
        public string GetItemName(string item_no)
        {
            string item_name = string.Empty;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select item_name from t_product_food where item_no='{0}' ";
                sql = string.Format(sql, item_no);
                object result = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                item_name = ExtendUtility.Instance.ParseToString(result);
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemName--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemName--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return item_name;
        }
        #endregion


        #region 非交易支付流水保存
        
        
        
        
        
        public bool SaveNonTrading(t_pos_payflow _pay)
        {
            bool isok = false;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            StringBuilder sb = new StringBuilder();
            SQLiteParameter[] sqlParameters = null;
            try
            {
                sql = "insert into t_app_payflow";
                sb.AppendLine("insert into t_app_payflow");
                sb.AppendLine("(flow_id,flow_no,sale_amount,pay_way,pay_amount,");
                sb.AppendLine("coin_type,pay_name,coin_rate,convert_amt,card_no,");
                sb.AppendLine("memo,oper_date,oper_id,voucher_no,branch_no,");
                sb.AppendLine("pos_id,sale_way,vip_no,com_flag)");
                sb.AppendLine(" values (@flow_id,@flow_no,@sale_amount,@pay_way,@pay_amount,");
                sb.AppendLine("@coin_type,@pay_name,@coin_rate,@convert_amt,@card_no,");
                sb.AppendLine("@memo,@oper_date,@oper_id,@voucher_no,@branch_no,");
                sb.AppendLine("@pos_id,@sale_way,@vip_no,@com_flag)");
                sqlParameters = new SQLiteParameter[19];
                sqlParameters[0] = new SQLiteParameter("@flow_id", _pay.flow_id);
                sqlParameters[1] = new SQLiteParameter("@flow_no", _pay.flow_no);
                sqlParameters[2] = new SQLiteParameter("@sale_amount", _pay.sale_amount);
                sqlParameters[3] = new SQLiteParameter("@pay_way", _pay.pay_way);
                sqlParameters[4] = new SQLiteParameter("@pay_amount", _pay.pay_amount);
                sqlParameters[5] = new SQLiteParameter("@coin_type", _pay.coin_type);
                sqlParameters[6] = new SQLiteParameter("@pay_name", _pay.pay_name);
                sqlParameters[7] = new SQLiteParameter("@coin_rate", _pay.coin_rate);
                sqlParameters[8] = new SQLiteParameter("@convert_amt", _pay.convert_amt);
                sqlParameters[9] = new SQLiteParameter("@card_no", _pay.card_no);
                sqlParameters[10] = new SQLiteParameter("@memo", _pay.memo);
                sqlParameters[11] = new SQLiteParameter("@oper_date", _pay.oper_date);
                sqlParameters[12] = new SQLiteParameter("@oper_id", _pay.oper_id);
                sqlParameters[13] = new SQLiteParameter("@voucher_no", _pay.voucher_no);
                sqlParameters[14] = new SQLiteParameter("@branch_no", _pay.branch_no);
                sqlParameters[15] = new SQLiteParameter("@pos_id", _pay.pos_id);
                sqlParameters[16] = new SQLiteParameter("@sale_way", _pay.sale_way);
                sqlParameters[17] = new SQLiteParameter("@vip_no", _pay.vip_no);
                sqlParameters[18] = new SQLiteParameter("@com_flag", _pay.com_flag);
                if (DbUtilitySQLite.Instance.ExecuteSql(Gattr.SALE_DB_ITEM_NAME, sb.ToString(), sqlParameters, ref errorMessage) > 0)
                {
                    isok = true;
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "PosDal->SaveNonTrading--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        #endregion

        
        
        
        
        
        public string GetBranchNameByNo(string branch_no)
        {
            string branch_name = string.Empty;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select branch_name from t_branch_info where branch_no='{0}' ";
                sql = string.Format(sql, branch_no);
                object result = DbUtilitySQLite.Instance.GetSingleData(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                branch_name = ExtendUtility.Instance.ParseToString(result);
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetBranchNameByNo--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetBranchNameByNo--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return branch_name;
        }

        
        
        
        
        
        private t_cur_saleflow GetItemInfoByBarcode(string barcode)
        {
            string sql = string.Empty;
            string errorMessage = string.Empty;
            t_cur_saleflow sale = null;
            DataTable table = null;
            try
            {
                sql = "SELECT   " +
     "f.item_no," +
     "f.item_subno," +
     "f.item_name," +
     "f.item_subname," +
     "f.item_clsno," +
     "f.item_brand," +
     "f.item_brandname," +
     "f.unit_no," +
     "f.item_size," +
     "f.product_area," +
     "f.price," +
     "f.sale_price," +
     "f.sale_price1," +
     "f.build_date," +
     "f.lastchange_time," +
     "f.status," +
     "f.stock," +
     "f.stock_lasttime," +
     "f.main_supcust," +
     "f.images_ios," +
     "f.content," +
     "f.num2," +
     "f.num3," +
     "f.pifaopen," +
     "f.images," +
     "f.appopen," +
     "f.headimages," +
     "f.score," +
     "f.scorenum," +
     "f.vip_acc_flag," +
     "f.vip_acc_num," +
     "f.change_price," +
     "f.scheme_price" +
 "  FROM" +
 "	t_product_food f " +
 "  LEFT JOIN t_product_food_barcode b ON f.item_no = b.item_no" +
 "  WHERE" +
 "	b.item_barcode = '{0}'";
                sql = string.Format(sql, barcode);
                table = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                if (table != null && table.Rows.Count > 0)
                {
                    DataRow dr = table.Rows[0];
                    sale = new t_cur_saleflow();
                    sale.item_no = ExtendUtility.Instance.ParseToString(dr["item_no"]);
                    sale.item_name = ExtendUtility.Instance.ParseToString(dr["item_name"]);
                    sale.oper_date = DateTime.Now.ToString("s");
                    sale.price = ExtendUtility.Instance.ParseToDecimal(ExtendUtility.Instance.ParseToDecimal(dr["price"]).ToString(Gattr.PosSalePrcPoint));
                    sale.unit_price = ExtendUtility.Instance.ParseToDecimal(ExtendUtility.Instance.ParseToDecimal(dr["sale_price"]).ToString(Gattr.PosSalePrcPoint));
                    sale.sale_price = ExtendUtility.Instance.ParseToDecimal(ExtendUtility.Instance.ParseToDecimal(dr["sale_price"]).ToString(Gattr.PosSalePrcPoint));
                    sale.sale_money = sale.sale_price;
                    sale.item_subno = ExtendUtility.Instance.ParseToString(dr["item_subno"]);
                    sale.item_clsno = ExtendUtility.Instance.ParseToString(dr["item_clsno"]);
                    sale.item_status = ExtendUtility.Instance.ParseToString(dr["status"]);
                    sale.item_subname = ExtendUtility.Instance.ParseToString(dr["item_subname"]);
                    sale.last_item_name = Gfunc.ItemNameFormat(sale.item_no, sale.item_name);
                    sale.item_brand = ExtendUtility.Instance.ParseToString(dr["item_brand"]);
                    sale.branch_no = Gattr.BranchNo;  //ExtendUtility.Instance.ParseToString(dr[""]);
                    sale.oper_id = Gattr.OperId;
                    sale.pos_id = Gattr.PosId;
                    sale.sale_qnty = 1;
                    sale.sale_way = "A";
                    sale.unit_no = ExtendUtility.Instance.ParseToString(dr["unit_no"]);
                    sale.num3 = ExtendUtility.Instance.ParseToDecimal(dr["num3"]);
                    sale.change_price = ExtendUtility.Instance.ParseToString(dr["change_price"]);
                    sale.scheme_price = ExtendUtility.Instance.ParseToString(dr["scheme_price"]);
                    sale.vip_acc_flag = ExtendUtility.Instance.ParseToString(dr["vip_acc_flag"]);
                    sale.vip_acc_num = ExtendUtility.Instance.ParseToDecimal(dr["vip_acc_num"]);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemInfoByBarcode--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemInfoByBarcode--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return sale;
        }

        
        
        
        
        
        public List<t_cur_saleflow> GetItemsForPos(string item_no)
        {
            string sql = string.Empty;
            string errorMessage = string.Empty;
            List<t_cur_saleflow> _saleFlows = new List<t_cur_saleflow>();
            try
            {
                sql = "select item_no,item_name,price,sale_price," +
                    "item_subno,item_clsno,item_subname,item_brand," +
                    "unit_no,num3,item_size,product_area,main_supcust,vip_acc_flag" +
                    " from t_product_food   where item_no = '{0}'";
                sql = string.Format(sql, item_no);
                _saleFlows = DbUtilitySQLite.Instance.GetDataList<t_cur_saleflow>(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "GetItemsForPos--->>Execute>>" + errorMessage.ToString(), LogEnum.ExceptionLog);
                }
                if (!(_saleFlows != null && _saleFlows.Count > 0))
                {
                    sql = "SELECT  f.item_no,f.item_subno,f.item_name,f.item_subname," +
     "f.item_clsno,f.item_brand,f.item_brandname,f.unit_no,f.item_size,f.product_area," +
     "f.price,f.sale_price,f.sale_price1,f.build_date,f.lastchange_time,f.status," +
     "f.stock,f.stock_lasttime,f.main_supcust,f.images_ios,f.content,f.num2,f.num3," +
     "f.pifaopen,f.images,f.appopen,f.headimages,f.score,f.scorenum,f.vip_acc_flag,f.vip_acc_num,f.change_price,f.scheme_price FROM t_product_food f " +
     " LEFT JOIN t_product_food_barcode b ON f.item_no = b.item_no WHERE b.item_barcode = '{0}'";
                    sql = string.Format(sql, item_no);
                    _saleFlows = DbUtilitySQLite.Instance.GetDataList<t_cur_saleflow>(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                    if (errorMessage.Length > 0)
                    {
                        LoggerHelper.Log("MsmkLogger", "GetItemsForPos--->>Execute>>" + errorMessage.ToString(), LogEnum.ExceptionLog);
                    }
                    if (!(_saleFlows != null && _saleFlows.Count > 0))
                    {
                        sql = "select item_no,item_name,price,sale_price," +
                    "item_subno,item_clsno,item_subname,item_brand," +
                    "unit_no,num3,item_size,product_area,main_supcust,vip_acc_flag" +
                    " from t_product_food   where item_no like '%{0}%'";
                        sql = string.Format(sql, item_no);
                        _saleFlows = DbUtilitySQLite.Instance.GetDataList<t_cur_saleflow>(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                        if (errorMessage.Length > 0)
                        {
                            LoggerHelper.Log("MsmkLogger", "GetItemsForPos--->>Execute>>" + errorMessage.ToString(), LogEnum.ExceptionLog);
                        }
                        if (!(_saleFlows != null && _saleFlows.Count > 0))
                        {
                            sql = "SELECT f.item_no,f.item_subno,f.item_name,f.item_subname," +
             "f.item_clsno,f.item_brand,f.item_brandname,f.unit_no,f.item_size,f.product_area," +
             "f.price,f.sale_price,f.sale_price1,f.build_date,f.lastchange_time,f.status," +
             "f.stock,f.stock_lasttime,f.main_supcust,f.images_ios,f.content,f.num2,f.num3," +
             "f.pifaopen,f.images,f.appopen,f.headimages,f.score,f.scorenum,f.vip_acc_flag,f.vip_acc_num,f.change_price,f.scheme_price  FROM t_product_food f " +
             " LEFT JOIN t_product_food_barcode b ON f.item_no = b.item_no WHERE b.item_barcode like '%{0}%'";
                            sql = string.Format(sql, item_no);
                            _saleFlows = DbUtilitySQLite.Instance.GetDataList<t_cur_saleflow>(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                            if (errorMessage.Length > 0)
                            {
                                LoggerHelper.Log("MsmkLogger", "GetItemsForPos--->>Execute>>" + errorMessage.ToString(), LogEnum.ExceptionLog);
                            }
                        }
                    }
                }
                if (_saleFlows != null && _saleFlows.Count > 0)
                {
                    foreach (t_cur_saleflow sale in _saleFlows)
                    {
                        sale.oper_date = DateTime.Now.ToString("s");
                        sale.price = ExtendUtility.Instance.ParseToDecimal(ExtendUtility.Instance.ParseToDecimal(sale.price).ToString(Gattr.PosSalePrcPoint));
                        sale.unit_price = ExtendUtility.Instance.ParseToDecimal(ExtendUtility.Instance.ParseToDecimal(sale.sale_price).ToString(Gattr.PosSalePrcPoint));
                        sale.sale_price = ExtendUtility.Instance.ParseToDecimal(ExtendUtility.Instance.ParseToDecimal(sale.sale_price).ToString(Gattr.PosSalePrcPoint));
                        sale.sale_money = sale.sale_price;
                        sale.item_subno = ExtendUtility.Instance.ParseToString(sale.item_subno);
                        sale.item_clsno = ExtendUtility.Instance.ParseToString(sale.item_clsno);
                        sale.item_subname = ExtendUtility.Instance.ParseToString(sale.item_subname);
                        sale.last_item_name = Gfunc.ItemNameFormat(sale.item_no, sale.item_name);
                        sale.item_brand = ExtendUtility.Instance.ParseToString(sale.item_brand);
                        sale.branch_no = Gattr.BranchNo;  //ExtendUtility.Instance.ParseToString(dr[""]);
                        sale.oper_id = Gattr.OperId;
                        sale.pos_id = Gattr.PosId;
                        sale.sale_qnty = 1;
                        sale.sale_way = "A";
                        sale.unit_no = ExtendUtility.Instance.ParseToString(sale.unit_no);
                        sale.num3 = ExtendUtility.Instance.ParseToDecimal(sale.num3);
                        sale.change_price = ExtendUtility.Instance.ParseToString(sale.change_price);
                        sale.scheme_price = ExtendUtility.Instance.ParseToString(sale.scheme_price);
                        sale.vip_acc_flag = ExtendUtility.Instance.ParseToString(sale.vip_acc_flag);
                        sale.vip_acc_num = ExtendUtility.Instance.ParseToDecimal(sale.vip_acc_num);
                    }
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemsForPos--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemsForPos--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return _saleFlows;
        }

        
        
        
        
        public int GetNonUpdateFlow()
        {
            string sql = string.Empty;
            int result = 0;
            string errorMessage = string.Empty;
            try
            {
                sql = "select count(1) from t_app_payflow where com_flag<>1";
                object res = DbUtilitySQLite.Instance.GetSingleData(Gattr.SALE_DB_ITEM_NAME, sql, null, ref errorMessage);
                result = ExtendUtility.Instance.ParseToInt32(res);
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "GetNonUpdateFlow--->>Execute>>sql:" + sql + "Error:" + errorMessage, LogEnum.ExceptionLog);
                }
                if (result == 0)
                {
                    sql = "select count(*) from t_app_viplist where over_flag<>1";
                    res = DbUtilitySQLite.Instance.GetSingleData(Gattr.SALE_DB_ITEM_NAME, sql, null, ref errorMessage);
                    result = ExtendUtility.Instance.ParseToInt32(res);
                    if (errorMessage.Length > 0)
                    {
                        LoggerHelper.Log("MsmkLogger", "GetNonUpdateFlow--->>Execute>>sql:" + sql + "Error:" + errorMessage, LogEnum.ExceptionLog);
                    }
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetNonUpdateFlow--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetNonUpdateFlow--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return result;
        }
        
        
        
        
        
        public string GetVipCardByNo(string memo)
        {
            string vip_no = string.Empty;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select vip_no from t_app_payflow where flow_no='{0}'";
                sql = string.Format(sql, memo);
                object res = DbUtilitySQLite.Instance.GetSingleData(Gattr.SALE_DB_ITEM_NAME, sql, null, ref errorMessage);
                vip_no = ExtendUtility.Instance.ParseToString(res);
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "GetNonUpdateFlow--->>Execute>>" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetVipCardByNo--->>SQLiteException>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetVipCardByNo--->>Exception>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return vip_no;
        }

        
        
        
        
        
        public bool AddVipflow(t_app_viplist vipinfo)
        {
            bool isok = false;
            string errorMessage = string.Empty;
            string sql = string.Empty;
            SQLiteParameter[] _parameters = null;
            try
            {
                sql = "INSERT INTO t_app_viplist (flow_no ,card_no ,score ,sale_amt ," +
                      " oper_date ,voucher_no ,over_flag ,com_flag,card_score,card_amount ) " +
                      " VALUES (@flow_no,@card_no ,@score ,@sale_amt ," +
                      " @oper_date ,@voucher_no ,@over_flag ,@com_flag,@card_score,@card_amount)";
                _parameters = new SQLiteParameter[10];
                _parameters[0] = new SQLiteParameter("@flow_no", vipinfo.flow_no);
                _parameters[1] = new SQLiteParameter("@card_no", vipinfo.card_no);
                _parameters[2] = new SQLiteParameter("@score", vipinfo.score);
                _parameters[3] = new SQLiteParameter("@sale_amt", vipinfo.sale_amt);
                _parameters[4] = new SQLiteParameter("@oper_date", vipinfo.oper_date);
                _parameters[5] = new SQLiteParameter("@voucher_no", vipinfo.voucher_no);
                _parameters[6] = new SQLiteParameter("@over_flag", vipinfo.over_flag);
                _parameters[7] = new SQLiteParameter("@com_flag", "0");
                _parameters[8] = new SQLiteParameter("@card_score", vipinfo.card_score);
                _parameters[9] = new SQLiteParameter("@card_amount", vipinfo.card_amount);
                int result = DbUtilitySQLite.Instance.ExecuteSql(Gattr.SALE_DB_ITEM_NAME, sql, _parameters, ref errorMessage);
                if (result > 0)
                {
                    isok = true;
                }
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->AddVipflow--->Error:" + errorMessage, LogEnum.ExceptionLog);
                }
                if (isok == false)
                {
                    StringBuilder _sb = new StringBuilder();
                    _sb.AppendLine("flow_no:" + vipinfo.flow_no);
                    _sb.AppendLine("card_no:" + vipinfo.card_no);
                    _sb.AppendLine("score:" + vipinfo.score);
                    _sb.AppendLine("sale_amt:" + vipinfo.sale_amt);
                    _sb.AppendLine("oper_date:" + vipinfo.oper_date);
                    _sb.AppendLine("voucher_no:" + vipinfo.voucher_no);
                    _sb.AppendLine("over_flag:" + vipinfo.over_flag);
                    _sb.AppendLine("com_flag:" + vipinfo.com_flag);
                    LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->AddVipflow--->Data---->Detail:" + _sb.ToString(), LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->AddVipflow--->SQLiteException:" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->AddVipflow--->Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        
        
        
        
        
        public t_app_viplist GetVipflow(string flow_no)
        {
            string errorMessage = string.Empty;
            string sql = string.Empty;
            SQLiteParameter[] _parameters = null;
            List<t_app_viplist> applist = null;
            try
            {
                sql = "select * from  t_app_viplist where flow_no=@flow_no";
                _parameters = new SQLiteParameter[1];
                _parameters[0] = new SQLiteParameter("@flow_no", flow_no);
                applist = DbUtilitySQLite.Instance.GetDataList<t_app_viplist>(Gattr.SALE_DB_ITEM_NAME, sql, _parameters, ref errorMessage);
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->AddVipflow--->Error:" + errorMessage, LogEnum.ExceptionLog);
                }
                if (applist != null && applist.Count > 0)
                {
                    return applist[0];
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->AddVipflow--->SQLiteException:" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->AddVipflow--->Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return null;
        }
        
        
        
        
        public bool DeleteTempNonSaleData()
        {
            bool isok = false;
            string sql = string.Empty;
            string errorMessage = string.Empty;
            List<SqlParaEntity> _sqlParas = null;
            try
            {
                _sqlParas = new List<SqlParaEntity>();
                sql = "delete from t_cur_saleflow where sale_way='B'";
                _sqlParas.Add(new SqlParaEntity() { Sql = sql, parameters = null });
                sql = "delete from t_cur_payflow where sale_way='B'";
                _sqlParas.Add(new SqlParaEntity() { Sql = sql, parameters = null });
                int result = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.SALE_DB_ITEM_NAME, _sqlParas, ref errorMessage);
                if (result > 0)
                {
                    isok = true;
                }
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->DeleteTempNonSaleData--->Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->DeleteTempNonSaleData--->SQLiteException:" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->PosDal-->DeleteTempNonSaleData--->SQLiteException:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }



        #region 基础信息添加供应商
        
        
        
        
        
        public bool InsertSupinfo(DataTable table)
        {
            String sql = "";
            SQLiteParameter[] parameters = null;
            List<SqlParaEntity> transList = null;
            SqlParaEntity _current;
            bool isok = false;
            String errorMessage = string.Empty;
            try
            {
                string date = System.DateTime.Now.ToString(Gattr.StampFormat);
                string path = Gattr.DB_FILE_PATH + "item/t_sp_infos.sql";
                string content = FileUtility.Instance.GetFileContent(path, ref errorMessage);
                if (errorMessage.Length > 0)
                {
                    return false;
                }
                else
                {
                    sql = "insert into t_sp_infos(sp_no,sp_name) values(@sp_no,@sp_name)"; ;
                    transList = new List<SqlParaEntity>();
                    _current = new SqlParaEntity() { parameters = null, Sql = content };
                    transList.Add(_current);
                    _current = new SqlParaEntity() { parameters = null, Sql = "delete from t_sp_infos" };
                    transList.Add(_current);
                    foreach (DataRow dr in table.Rows)
                    {
                        parameters = new SQLiteParameter[2];
                        parameters[0] = new SQLiteParameter("@sp_no", ExtendUtility.Instance.ParseToString(dr["sp_no"]));
                        parameters[1] = new SQLiteParameter("@sp_name", ExtendUtility.Instance.ParseToString(dr["sp_company"]));
                        _current = new SqlParaEntity() { Sql = sql, parameters = parameters };
                        transList.Add(_current);
                    }
                    isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(Gattr.ITEM_DB_FILE_NAME, transList, ref errorMessage) > 0 ? true : false;
                    if (errorMessage.Length > 0)
                    {
                        LoggerHelper.Log("MsmkLogger", "InsertSupinfo--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                    }
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertSupinfo--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "InsertSupinfo--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return isok;
        }
        #endregion
        #region 公共查询控件查询
        
        
        
        
        
        
        public DataTable GetCommonSelData(string type, string keyword)
        {
            DataTable table = null;
            string sql = string.Empty;
            String errorMessage = string.Empty;
            try
            {
                switch (type)
                {
                    case "0":
                        sql = "select typeno as code,typename as name from t_product_food_type WHERE 1=1 ";
                        if (!string.IsNullOrEmpty(keyword))
                        {
                            sql += " AND typeno like '%" + keyword + "%' or typename like '%" + keyword + "%'";
                        }
                        break;
                    case "1":
                        sql = "select code_id as code,code_name  as name from t_base_code WHERE type_no='PP' ";
                        if (!string.IsNullOrEmpty(keyword))
                        {
                            sql += " AND  code_id like '%" + keyword + "%' or code_name like '%" + keyword + "%'";
                        }
                        break;
                    case "2":
                        sql = "select sp_no as code,sp_name as name from t_sp_infos WHERE 1=1 ";
                        if (!string.IsNullOrEmpty(keyword))
                        {
                            sql += " AND  sp_no like '%" + keyword + "%' or sp_name like '%" + keyword + "%'";
                        }
                        break;
                }
                table = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "GetCommonSelData--->>>>Error:" + errorMessage, LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetCommonSelData--->>>>" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetCommonSelData--->>>>" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        #endregion

        
        
        
        
        
        public DataTable GetItemStock()
        {
            DataTable tableStock = null;
            String sql = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                sql = "select s.item_no,s.item_subno,s.item_name,s.item_clsno," +
                    "a.typename as item_clsname,s.item_brand,b.code_name," +
                    "s.item_size,s.unit_no,s.stock from t_product_food s " +
                    "   LEFT join t_product_food_type a on s.item_clsno=a.typeno " +
                    "   LEFT JOIN t_base_code b on s.item_brand = b.code_id and b.type_no='PP'";

                tableStock = DbUtilitySQLite.Instance.GetDataTable(Gattr.ITEM_DB_FILE_NAME, sql, null, ref errorMessage);
                if (errorMessage.Length > 0)
                {
                    LoggerHelper.Log("MsmkLogger", "GetItemStock--->>>>Error:" + errorMessage.ToString(), LogEnum.ExceptionLog);
                }
            }
            catch (SQLiteException sqlex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemStock--->>>>SQLiteException:" + sqlex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "GetItemStock--->>>>Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return tableStock;
        }
    }
}
