namespace ICE.POS 
{
    using System.Data.SQLite;

    public class SqlLiteTranParam
    {
        public SQLiteParameter[] param;
        public string sql;

        public SqlLiteTranParam()
        {
        }

        public SqlLiteTranParam(string sql, SQLiteParameter[] param)
        {
            this.sql = sql;
            this.param = param;
        }
    }
}

