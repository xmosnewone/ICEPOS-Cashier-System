namespace ICE.POS 
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    
    
    
    public class SqlLiteHelper : IDisposable
    {
        private SQLiteConnection _conn;
        private string _connString = string.Empty;
        public bool OpenLite()
        {
            bool flag;
            try
            {
                if (this._conn == null)
                {
                    this._conn = new SQLiteConnection(this._connString);
                }
                if (this._conn.State == ConnectionState.Closed)
                {
                    this._conn.Open();
                }
                if (this._conn.State != ConnectionState.Open)
                {
                    return false;
                }
                flag = true;
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            return flag;
        }
        public void CloseLite()
        {
            try
            {
                if ((this._conn != null) && (this._conn.State != ConnectionState.Closed))
                {
                    this._conn.Close();
                }
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
        }

        public int ExecuteSql(string sql)
        {
            int num = 0;
            SQLiteCommand command = new SQLiteCommand(sql, this._conn);
            try
            {
                num = command.ExecuteNonQuery();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return num;
        }

        public int ExecuteSql(string sql, SQLiteParameter[] cmdParams)
        {
            int num = 0;
            SQLiteCommand command = new SQLiteCommand(sql, this._conn);
            try
            {
                if (cmdParams != null)
                {
                    foreach (SQLiteParameter parameter in cmdParams)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                num = command.ExecuteNonQuery();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return num;
        }

        public int ExecuteSql(SQLiteTransaction trans, string sql, SQLiteParameter[] cmdParams)
        {
            int num = 0;
            SQLiteCommand command = new SQLiteCommand(sql, trans.Connection);
            try
            {
                command.Transaction = trans;
                if (cmdParams != null)
                {
                    foreach (SQLiteParameter parameter in cmdParams)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                num = command.ExecuteNonQuery();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return num;
        }

        public bool ExecuteSqlTran(List<SqlLiteTranParam> param)
        {
            bool flag = false;
            SQLiteCommand command = new SQLiteCommand();
            try
            {
                this.OpenLite();
                command.Connection = this._conn;
                command.Transaction = this._conn.BeginTransaction();
                foreach (SqlLiteTranParam param2 in param)
                {
                    command.CommandText = param2.sql;
                    if (param2.param != null)
                    {
                        foreach (SQLiteParameter parameter in param2.param)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                command.Transaction.Commit();
                flag = true;
            }
            catch (SQLiteException exception)
            {
                if (command.Transaction != null)
                {
                    try
                    {
                        command.Transaction.Rollback();
                    }
                    catch (SQLiteException exception2)
                    {
                        throw exception2;
                    }
                }
                flag = false;
                throw exception;
            }
            catch (Exception exception3)
            {
                flag = false;
                throw exception3;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return flag;
        }

        public DataTable FindByPaging(string sql, int startRecord, int maxRecord)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteCommand command = new SQLiteCommand(string.Concat(new object[] { sql, " LIMIT ", startRecord, ",", maxRecord }), this._conn))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (SQLiteException exception)
                    {
                        throw exception;
                    }
                    catch (Exception exception2)
                    {
                        throw exception2;
                    }
                    return dataTable;
                }
            }
        }

        public DataTable GetData(string sql)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteCommand command = new SQLiteCommand(sql, this._conn))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (SQLiteException exception)
                    {
                        throw exception;
                    }
                    catch (Exception exception2)
                    {
                        throw exception2;
                    }
                    return dataTable;
                }
            }
        }

        public DataTable GetData(string sql, SQLiteParameter[] cmdParams)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteCommand command = new SQLiteCommand(sql, this._conn))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    try
                    {
                        foreach (SQLiteParameter parameter in cmdParams)
                        {
                            command.Parameters.Add(parameter);
                        }
                        adapter.Fill(dataTable);
                    }
                    catch (SQLiteException exception)
                    {
                        throw exception;
                    }
                    catch (Exception exception2)
                    {
                        throw exception2;
                    }
                    return dataTable;
                }
            }
        }

        public object GetObjectSingle(string strsql)
        {
            object obj2;
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(strsql, this._conn))
                {
                    this.OpenLite();
                    obj2 = command.ExecuteScalar();
                }
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            return obj2;
        }

        public object GetObjectSingle(string strsql, SQLiteParameter[] cmdParams)
        {
            object obj2;
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(strsql, this._conn))
                {
                    this.OpenLite();
                    foreach (SQLiteParameter parameter in cmdParams)
                    {
                        command.Parameters.Add(parameter);
                    }
                    obj2 = command.ExecuteScalar();
                }
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            return obj2;
        }

        public int GetSingle(string strsql)
        {
            int num;
            try
            {
                object obj2 = null;
                using (SQLiteCommand command = new SQLiteCommand(strsql, this._conn))
                {
                    this.OpenLite();
                    obj2 = command.ExecuteScalar();
                    string s = "";
                    if ((obj2 != null) && (obj2 != DBNull.Value))
                    {
                        s = obj2.ToString();
                    }
                    if ((s == null) || (s.Trim().Length == 0))
                    {
                        return 0;
                    }
                    num = int.Parse(s);
                }
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            return num;
        }

        public bool IsExist(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, this._conn);
            try
            {
                object obj2 = command.ExecuteScalar();
                if ((obj2 != null) && (obj2 != DBNull.Value))
                {
                    return true;
                }
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return false;
        }

        public bool IsExist(string sql, SQLiteParameter[] cmdParams)
        {
            SQLiteCommand command = new SQLiteCommand(sql, this._conn);
            try
            {
                foreach (SQLiteParameter parameter in cmdParams)
                {
                    command.Parameters.Add(parameter);
                }
                object obj2 = command.ExecuteScalar();
                if ((obj2 != null) && (obj2 != DBNull.Value))
                {
                    return true;
                }
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return false;
        }

       

        public SQLiteDataReader QueryReader(string sql)
        {
            SQLiteDataReader reader;
            SQLiteCommand command = new SQLiteCommand(sql, this._conn);
            try
            {
                this.OpenLite();
                reader = command.ExecuteReader();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return reader;
        }

        public SQLiteDataReader QueryReader(string sql, SQLiteParameter[] cmdParams)
        {
            SQLiteDataReader reader;
            SQLiteCommand command = new SQLiteCommand(sql, this._conn);
            try
            {
                this.OpenLite();
                foreach (SQLiteParameter parameter in cmdParams)
                {
                    command.Parameters.Add(parameter);
                }
                reader = command.ExecuteReader();
            }
            catch (SQLiteException exception)
            {
                throw exception;
            }
            catch (Exception exception2)
            {
                throw exception2;
            }
            finally
            {
                if (command != null)
                {
                    command.Dispose();
                }
            }
            return reader;
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        public SQLiteConnection Conn
        {
            get
            {
                return this._conn;
            }
        }

        public string ConnectionString
        {
            get
            {
                return this._connString;
            }
            set
            {
                this._connString = value;
            }
        }
    }
}
