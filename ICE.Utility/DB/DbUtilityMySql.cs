namespace ICE.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Reflection;
    using MySql.Data.MySqlClient;
    
    public class DbUtilityMySql : IDBUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static DbUtilityMySql _instance;
        
        
        
        private DbUtilityMySql()
        {

        }
        
        
        
        public static DbUtilityMySql Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new DbUtilityMySql();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        
        
        
        
        
        public bool TestConnect(string connectString)
        {
            bool isConnect = true;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectString);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception)
            {
                isConnect = false;
            }
            finally
            {
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return isConnect;
        }
        
        
        
        
        
        
        
        
        public int ExecuteSql(string connectString, string sql, DbParameter[] parameters, ref string errorMessage)
        {
            int result = 0;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectString);
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException mysql)
            {
                errorMessage = mysql.ToString();
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return result;
        }
        
        
        
        
        
        
        
        
        public object GetSingleData(string connectionString, string sql, DbParameter[] parameters, ref string errorMessage)
        {
            object obj = null;
            MySqlCommand cmd = null;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                obj = cmd.ExecuteScalar();
            }
            catch (MySqlException mysql)
            {
                errorMessage = mysql.ToString();
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return obj;
        }
        
        
        
        
        
        
        
        
        
        public List<T> GetDataList<T>(string connectionString, string sql, DbParameter[] parameters, ref string errorMessage)
        {
            MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection conn = null;
            List<T> tList = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                reader = cmd.ExecuteReader();
                tList = GetModelList<T>(reader);
            }
            catch (MySqlException mysql)
            {
                errorMessage = mysql.ToString();
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                    reader.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return tList;
        }
        
        
        
        
        
        
        
        
        public DataTable GetDataTable(string connectionString, string sql, DbParameter[] parameters, ref string errorMessage)
        {
            DataTable table = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter da = null;
            DataSet ds = null;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ds = new DataSet();
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0)
                {
                    table = ds.Tables[0];
                }
            }
            catch (MySqlException mysql)
            {
                errorMessage = mysql.ToString();
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
            return table;
        }
        
        
        
        
        
        
        
        public int ExecuteSqlsByTrans(string connectionString, List<SqlParaEntity> _dicParameters, ref string errorMessage)
        {
            int result = 1;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlTransaction trans = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                trans = conn.BeginTransaction();
                foreach (SqlParaEntity kv in _dicParameters)
                {
                    cmd = new MySqlCommand(kv.Sql, conn);
                    cmd.Parameters.Clear();
                    if (kv.parameters != null && kv.parameters.Length > 0)
                        cmd.Parameters.AddRange(kv.parameters);
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (MySqlException mysql)
            {
                errorMessage = mysql.ToString();
                trans.Rollback();
                result = 0;
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                trans.Rollback();
                result = 0;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null)
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                    conn.Dispose();
                }
            }
            return result;
        }

        
        
        
        
        
        
        public List<T> GetModelList<T>(MySqlDataReader reader)
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
                                index = GetPropertyIndex(pinfos, dr["ColumnName"].ToString());
                                if (index >= 0)
                                {
                                    PropertyInfo pi = pinfos[index];
                                    String fieldName = pi.Name;
                                    switch (pi.PropertyType.Name.ToLower())
                                    {
                                        case "int":
                                        case "int32":
                                            pi.SetValue(t, ExtendUtility.Instance.ParseToInt32(reader[pi.Name.ToLower()]), null);
                                            break;
                                        case "decimal":
                                            pi.SetValue(t, ExtendUtility.Instance.ParseToDecimal(reader[pi.Name.ToLower()]), null);
                                            break;
                                        case "datetime":
                                            pi.SetValue(t, ExtendUtility.Instance.ParseToDateTime(reader[pi.Name.ToLower()]), null);
                                            break;
                                        default:
                                            pi.SetValue(t, ExtendUtility.Instance.ParseToString(reader[pi.Name.ToLower()]), null);
                                            break;
                                    }//switch (pi.PropertyType.Name.ToLower())
                                }//if (index > 0) 
                                index = -1;
                            }//foreach (DataColumn dc in table.Columns)
                        }//if (table != null && table.Rows.Count > 0)
                        tList.Add(t);
                    }//while (reader.Read())
                }
                catch (MySqlException mysql)
                {
                    String errorMessage = mysql.ToString();
                    Console.Write("Mysql:"+errorMessage);
                }
                catch (Exception ex)
                {
                   String errorMessage = ex.ToString();
                    Console.Write(errorMessage);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Dispose();
                        reader.Close();
                    }
                }
            }
            return tList;
        }

        
        
        
        
        
        
        public List<T> GetModelListByDataTable<T>(DataTable table)
        {
            List<T> tList = new List<T>();
            if (table != null && table.Rows.Count > 0)
            {
                T t = default(T);
                int index = -1;
                try
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        t = Activator.CreateInstance<T>();
                        Type type = t.GetType();
                        PropertyInfo[] pinfos = type.GetProperties();
                        foreach (DataColumn dc in table.Columns)
                        {
                            index = GetPropertyIndex(pinfos, dc.ColumnName);
                            if (index >= 0)
                            {
                                PropertyInfo pi = pinfos[index];
                                String fieldName = pi.Name;
                                switch (pi.PropertyType.Name.ToLower())
                                {
                                    case "int":
                                    case "int32":
                                        pi.SetValue(t, ExtendUtility.Instance.ParseToInt32(dr[pi.Name.ToLower()]), null);
                                        break;
                                    case "decimal":
                                        pi.SetValue(t, ExtendUtility.Instance.ParseToDecimal(dr[pi.Name.ToLower()]), null);
                                        break;
                                    case "datetime":
                                        pi.SetValue(t, ExtendUtility.Instance.ParseToDateTime(dr[pi.Name.ToLower()]), null);
                                        break;
                                    default:
                                        pi.SetValue(t, ExtendUtility.Instance.ParseToString(dr[pi.Name.ToLower()]), null);
                                        break;
                                }//switch (pi.PropertyType.Name.ToLower())
                            }//if (index > 0) 
                            index = -1;
                        }//foreach (DataColumn dc in table.Columns)
                        tList.Add(t);
                    }//while (reader.Read())
                }
                catch (MySqlException)
                {

                }
                catch (Exception)
                {

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
    }
}
