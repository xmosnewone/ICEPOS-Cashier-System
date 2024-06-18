using ICE.POS;
namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;
    using System.IO;
    using ICE.Utility;
    using ICE.Common;
    
    
    
    public class DBCreater
    {
        #region 单例模式
        private DBCreater()
        { }
        private static object lockobj = new object();
        private static DBCreater _instance = null;
        
        
        
        public static DBCreater Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new DBCreater();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        public bool CreateDB(Dictionary<String, String[]> _dicTablePath)
        {
            bool isok = true;
            String errorMessage = String.Empty;
            try
            {
                foreach (String path in _dicTablePath.Keys)
                {
                    if (CreateDataBase(path, ref  errorMessage))
                    {
                        String connectionString = GobalStaticString.SQLITE_DB_STRING.Replace("%path%", path);
                        if (!CreateTable(connectionString, _dicTablePath[path], ref errorMessage))
                        {
                            isok = false;
                            break;
                        }
                    }
                    else
                    {
                        isok = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isok;
        }
        public bool UpdateSQL(string dbPath,string[] sqlPath)
        {
            bool isok = true;
            String errorMessage = String.Empty;
            try
            {
                String connectionString = GobalStaticString.SQLITE_DB_STRING.Replace("%path%", dbPath);
                if (!CreateTable(connectionString, sqlPath, ref errorMessage))
                {
                    isok = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isok;
        }
        
        
        
        
        
        
        private bool CreateDataBase(String filePath, ref String message)
        {
            bool isok = false;
            String fileName = String.Empty;
            String backUpFileName = String.Empty;
            String directory = String.Empty;
            try
            {
                directory = Path.GetDirectoryName(filePath);
                fileName = Path.GetFileName(filePath);
                backUpFileName = "Temp" + fileName;
                if (File.Exists(filePath))
                {
                    if (File.Exists(directory + backUpFileName))
                    {
                        File.Delete(directory + backUpFileName);
                    }
                    File.Copy(filePath, directory + backUpFileName);
                    File.Delete(filePath);
                }
                SQLiteConnection.CreateFile(filePath);
                isok = true;
            }
            catch (SQLiteException sqlex)
            {
                message = sqlex.ToString();
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            if (isok == false)
            {
                if (!File.Exists(filePath) && File.Exists(directory + backUpFileName))
                {
                    File.Copy(directory + backUpFileName, filePath);
                }
            }
            return isok;
        }
        
        
        
        
        
        
        private bool CreateTable(String connectionString, String[] tablePath, ref String message)
        {
            bool isok = false;
            StreamReader reader = null;
            FileStream fs = null;
            String sql = String.Empty;
            String errorMessage = String.Empty;
            List<SqlParaEntity> _sqlParameters;
            try
            {
                _sqlParameters = new List<SqlParaEntity>();
                for (int index = 0; index < tablePath.Length; index++)
                {
                    String path = tablePath[index];
                    if (File.Exists(path))
                    {
                        fs = new FileStream(path, FileMode.Open);
                        reader = new StreamReader(fs);
                        sql = reader.ReadToEnd();
                        _sqlParameters.Add(new SqlParaEntity() { Sql = sql });
                    }
                }
                isok = DbUtilitySQLite.Instance.ExecuteSqlsByTrans(connectionString, _sqlParameters, ref errorMessage) > 0 ? true : false;
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
            return isok;
        }
        #endregion
    }
}
