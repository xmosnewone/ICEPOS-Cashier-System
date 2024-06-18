namespace ICE.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    
    
    
    public interface IDBUtility
    {
        
        
        
        
        
        
        
        int ExecuteSql(String connectString, String sql, DbParameter[] parameters,ref String errorMessage);
        
        
        
        
        
        
        
        object GetSingleData(String connectionString, string sql, DbParameter[] parameters, ref String errorMessage);
        
        
        
        
        
        
        
        
        List<T> GetDataList<T>(String connectionString, string sql, DbParameter[] parameters, ref String errorMessage);
        
        
        
        
        
        
        
        DataTable GetDataTable(String connectionString, string sql, DbParameter[] parameters, ref String errorMessage);
        
        
        
        
        
        int ExecuteSqlsByTrans(String connectionString, List<SqlParaEntity> _dicParameters, ref String errorMessage);

    }
    
    
    
    public struct SqlParaEntity
    {
        public String Sql
        {
            get;
            set;
        }
        public DbParameter[] parameters
        {
            get;
            set;
        }
    }
}
