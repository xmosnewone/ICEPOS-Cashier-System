/// 类说明：公共的数据库访问访问类
namespace ICE.POS.Service
{
    using System.Data;
    using System.Data.SqlClient;
    /// <summary>
    /// 数据库的通用访问代码
    /// 此类为抽象类，
    /// 不允许实例化，在应用时直接调用即可
    /// </summary>
    public abstract class SqlTransHelper
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr"].ToString().Trim();
        public static SqlConnection conn = null;
        /// <summary>
        /// 测试是否连接数据库
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        private static bool GetConnection()
        {
            bool result = false;

            conn = new SqlConnection(connectionString);
            
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                result = true;
            }

            return result;
        }
        public static SqlTransaction GetSqlTransaction()
        {
            SqlTransaction trans = null;
            if (GetConnection())
            {
                trans = conn.BeginTransaction();
                
            }
            return trans;
        }
            //关闭数据库连接
        public static void Close()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}


