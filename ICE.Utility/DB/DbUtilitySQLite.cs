namespace ICE.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.SQLite;
    using System.Reflection;

    public class DbUtilitySQLite : IDBUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static DbUtilitySQLite _instance;
        
        
        
        private DbUtilitySQLite()
        {

        }
        
        
        
        public static DbUtilitySQLite Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new DbUtilitySQLite();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        
        
        public int ExecuteSql(String connectionString, string sql, DbParameter[] parameters, ref String errorMessage)
        {
            int record = 0;
            SQLiteCommand cmd = null;
            SQLiteConnection conn = null;
            try
            {
                conn = new SQLiteConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                record = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException sqlite)
            {
                errorMessage = sqlite.ToString();
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
            return record;
        }
        
        
        
        
        
        
        public object GetSingleData(String connectionString, string sql, DbParameter[] parameters, ref String errorMessage)
        {
            object obj = null;
            SQLiteCommand cmd = null;
            SQLiteConnection conn = null;
            try
            {
                conn = new SQLiteConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);
                obj = cmd.ExecuteScalar();
            }
            catch (SQLiteException sqlite)
            {
                errorMessage = sqlite.ToString();
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
        
        
        
        
        
        
        public List<T> GetDataList<T>(String connectionString, string sql, DbParameter[] parameters, ref String errorMessage)
        {
            SQLiteDataReader reader = null;
            SQLiteCommand cmd = null;
            SQLiteConnection conn = null;
            List<T> tList = null;
            try
            {
                conn = new SQLiteConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.Clear();
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                reader = cmd.ExecuteReader();
                tList = GetModelList<T>(reader);
            }
            catch (SQLiteException sqlite)
            {
                errorMessage = sqlite.ToString();
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
        
        
        
        
        
        
        public DataTable GetDataTable(String connectionString, string sql, DbParameter[] parameters, ref String errorMessage)
        {
            DataTable table = null;
            SQLiteCommand cmd = null;
            SQLiteDataAdapter da = null;
            DataSet ds = null;
            SQLiteConnection conn = null;
            try
            {
                conn = new SQLiteConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ds = new DataSet();
                cmd = new SQLiteCommand(sql, conn);
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
            catch (SQLiteException sqlex)
            {
                errorMessage = sqlex.ToString();
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
        
        
        
        
        
        
        public int ExecuteSqlsByTrans(String connectionString, List<SqlParaEntity> _dicParameters, ref String errorMessage)
        {
            int result = 1;
            SQLiteConnection conn = null;
            SQLiteCommand cmd = null;
            SQLiteTransaction trans = null;
            try
            {
                conn = new SQLiteConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                trans = conn.BeginTransaction();
                foreach (SqlParaEntity kv in _dicParameters)
                {
                    cmd = new SQLiteCommand(kv.Sql, conn);
                    cmd.Parameters.Clear();
                    if (kv.parameters != null && kv.parameters.Length > 0)
                        cmd.Parameters.AddRange(kv.parameters);
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (SQLiteException sqlite)
            {
                errorMessage = sqlite.ToString();
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
        
        
        
        
        
        
        public List<T> GetModelList<T>(SQLiteDataReader reader)
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
                                            pi.SetValue(t, ExtendUtility.Instance.ParseToDateTime(reader[pi.Name.ToLower()]).ToString("s"), null);
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
                catch (Exception)
                {

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
        #endregion
    }
}
