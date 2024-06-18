namespace ICE.POS 
{
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;
    using System.Windows.Forms;
    public class DalBase : IDisposable
    {
        //商品信息
        private SqlLiteHelper _dbPosItem = new SqlLiteHelper();
        private string _dbPosItemFileName = (Application.StartupPath + @"\item.db");
        //临时信息
        private SQLiteConnection _dbPosSale = new SQLiteConnection();
        private string _dbPosSaleFileName = Application.StartupPath + @"\sale.db";

        public void Chang2OffLine()
        {
        }

        public bool Change2OnLine()
        {
            return false;
        }
        
        
        
        public void dbClose()
        {
            this._dbPosItem.CloseLite();
            if (this._dbPosSale.State != ConnectionState.Closed)
            {
                this._dbPosSale.Close();
            }
        }
        
        
        
        
        public bool dbOpen()
        {
            try
            {
                if (this._dbPosSale.State != ConnectionState.Open)
                {
                    bool flagItem = false;
                    bool flagSale = false;
                    flagItem = !File.Exists(this._dbPosItemFileName);
                    flagSale = !File.Exists(this._dbPosSaleFileName);
                    SQLiteCommand command = null;
                    string sql = "";

                    this._dbPosItem.ConnectionString = @"Data Source=" + this._dbPosItemFileName + ";Emulator=True;Encoding=UTF8;";
                    this._dbPosSale.ConnectionString = @"Data Source=" + this._dbPosSaleFileName + ";Emulator=True;Encoding=UTF8;";

                    if (this._dbPosSale.State != ConnectionState.Closed)
                    {
                        this._dbPosSale.Close();
                    }
                    this._dbPosItem.OpenLite();

                    #region 初始化商品数据库表
                    try
                    {
                        sql = "CREATE TABLE if not exists t_attr_function (" +
                                "func_id	varchar(4) not null," +
                                "func_name varchar(20)," +
                                "func_udname varchar(20)," +
                                "pos_key	varchar(10)," +
                                "flag	varchar(1)," +
                                "type	varchar(1)," +
                                "memo	varchar(255)," +
                                "constraint pk_t_rm_function primary key(func_id) );";
                        this._dbPosItem.ExecuteSql(sql);
                        sql = "CREATE TABLE if not exists t_operator (" +
                                "oper_id  varchar(4) NOT NULL," +
                                "oper_name  varchar(10) NOT NULL," +
                                "oper_pwd  varchar(20)," +
                                "full_name  varchar(10)," +
                                "oper_role  varchar(10)," +
                                "oper_state  varchar(8)," +
                                "branch_id  varchar(12)," +
                                "last_date  datetime," +
                                "PRIMARY KEY (oper_id ASC, oper_name ASC)" +
                                ");";
                        this._dbPosItem.ExecuteSql(sql);

                        sql = "CREATE TABLE if not exists t_product_food (item_no CHAR(20) NOT NULL," +
                                "item_subno VARCHAR(15) NOT NULL," +
                                "item_name VARCHAR(100)," +
                                "item_subname VARCHAR(50)," +
                                "item_clsno VARCHAR(12)," +
                                "item_brand VARCHAR(12)," +
                                "item_brandname CHAR(6)," +
                                "unit_no CHAR(4)," +
                                "item_size VARCHAR(20)," +
                                "product_area VARCHAR(18)," +
                                "price NUMERIC(9, 4)," +
                                "sale_price NUMERIC(9, 4)," +
                                "sale_price1 NUMERIC(9, 4)," +
                                "build_date TIMESTAMP," +
                                "lastchange_time TIMESTAMP," +
                                "status NUMERIC(5)," +
                                "stock NUMERIC(16, 4)," +
                                "stock_lasttime TIMESTAMP," +
                                "main_supcust VARCHAR(20)," +
                                "images_ios TEXT," +
                                "content TEXT," +
                                "num2 VARCHAR(5)," +
                                "pifaopen NUMERIC(5) DEFAULT 0," +
                                "images TEXT," +
                                "appopen NUMERIC(5) DEFAULT 1," +
                                "headimages VARCHAR(200)," +
                                "score VARCHAR(30)," +
                                "scorenum INTEGER," +
                                "PRIMARY KEY(item_no));";
                        this._dbPosItem.ExecuteSql(sql);

                        sql = "CREATE TABLE if not exists t_product_food_barcode (item_no CHAR(20)," +
                                "item_barcode CHAR(20) NOT NULL," +
                                "num1 NUMERIC(14, 4)," +
                                "num2 NUMERIC(14, 4)," +
                                "num3 NUMERIC(14, 4)," +
                                "other1 VARCHAR(20)," +
                                "other2 VARCHAR(20)," +
                                "other3 VARCHAR(20)," +
                                "modify_date TIMESTAMP," +
                                "PRIMARY KEY(item_barcode));";
                        this._dbPosItem.ExecuteSql(sql);

                        sql = "CREATE TABLE if not exists t_product_food_type (typeno VARCHAR(10) NOT NULL," +
                                "typename VARCHAR(50)," +
                                "parent VARCHAR(10)," +
                                "last_refresh_time VARCHAR(20)," +
                                "images_ios VARCHAR(200)," +
                                "iosopen NUMERIC(5) DEFAULT 1," +
                                "pifaopen NUMERIC(5) DEFAULT 0," +
                                "PRIMARY KEY(typeno));";

                        this._dbPosItem.ExecuteSql(sql);
                        sql = "CREATE TABLE if not exists t_dict_payment_info (" +
                               "pay_way varchar(8) not null," +
                               "pay_flag integer not null," +
                               "pay_name varchar(20) not null," +
                               "rate decimal(6,2) null," +
                               "pay_memo varchar(100) null," +
                               "PRIMARY KEY (pay_way ASC,pay_flag ASC));";

                        this._dbPosItem.ExecuteSql(sql);
                       
                    }
                    catch (SQLiteException exception)
                    {
                        //str2 = sql;
                        throw new Exception("本地资料库创建表失败！\r\n" + exception.Message + "\r\n请退出程序删除文件：" + this._dbPosItemFileName + "后再试！");
                    }
                    #endregion

                    this._dbPosSale.Open();

                    #region 初始化流水数据库表
                    try
                    {

                        sql = "CREATE TABLE if not exists t_app_payflow (" +
                                "id  integer PRIMARY KEY AUTOINCREMENT," +
                                "flow_id  integer," +
                                "flow_no  varchar(20)," +
                                "sale_amount  numeric(16,2)," +
                                "pay_way  varchar(3)," +
                                "pay_amount  numeric(16,2)," +
                                "coin_type  varchar(5)," +
                                "pay_name  varchar(50)," +
                                "coin_rate  numeric(5,4)," +
                                "convert_amt  numeric(15,2)," +
                                "card_no  varchar(20)," +
                                "memo  varchar(50)," +
                                "oper_date  datetime," +
                                "oper_id  varchar(6)" +
                                ");";
                        new SQLiteCommand(sql, this._dbPosSale).ExecuteNonQuery();
                        sql = "CREATE TABLE if not exists t_app_saleflow (" +
                                "id  integer PRIMARY KEY AUTOINCREMENT," +
                                "flow_id  integer(4)," +
                                "flow_no  varchar(20)," +
                                "item_no  varchar(20)," +
                                "unit_price  numeric(15,4)," +
                                "sale_price  numeric(15,4)," +
                                "sale_qnty  numeric(15,4)," +
                                "sale_money  numeric(15,4)," +
                                "oper_id  varchar(6)," +
                                "oper_date  datetime," +
                                "item_subno  varchar(30)," +
                                "item_clsno  varchar(6)," +
                                "item_name  varchar(60)," +
                                "item_status  varchar(1)," +
                                "item_subname  varchar(60)" +
                                ");";
                        new SQLiteCommand(sql, this._dbPosSale).ExecuteNonQuery();
                        sql = "CREATE TABLE if not exists t_cur_payflow (" +
                                "flow_id  integer PRIMARY KEY AUTOINCREMENT," +
                                "flow_no  varchar(20)," +
                                "sale_amount  numeric(16,2)," +
                                "pay_way  varchar(3)," +
                                "pay_amount  numeric(16,2)," +
                                "coin_type  varchar(5)," +
                                "pay_name  varchar(50)," +
                                "coin_rate  numeric(5,4)," +
                                "convert_amt  numeric(15,2)," +
                                "card_no  varchar(20)," +
                                "memo  varchar(50)," +
                                "oper_date  datetime," +
                                "oper_id  varchar(6)" +
                                ");";
                        new SQLiteCommand(sql, this._dbPosSale).ExecuteNonQuery();
                        sql = "CREATE TABLE if not exists t_cur_saleflow (" +
                                "flow_id  integer PRIMARY KEY AUTOINCREMENT," +
                                "flow_no  varchar(20)," +
                                "item_no  varchar(20)," +
                                "unit_price  numeric(15,4)," +
                                "sale_price  numeric(15,4)," +
                                "sale_qnty  numeric(15,4)," +
                                "sale_money  numeric(15,4)," +
                                "oper_id  varchar(6)," +
                                "oper_date  datetime," +
                                "item_subno  varchar(30)," +
                                "item_clsno  varchar(6)," +
                                "item_name  varchar(60)," +
                                "item_status  varchar(1)," +
                                "item_subname  varchar(60)" +
                                ");";
                        new SQLiteCommand(sql, this._dbPosSale).ExecuteNonQuery();

                        sql = "CREATE TABLE if not exists t_pending_order (" +
                                "flow_no  varchar(128)," +
                                "sale_man  varchar(20)," +
                                "PRIMARY KEY (flow_no ASC)" +
                                ");";

                        new SQLiteCommand(sql, this._dbPosSale).ExecuteNonQuery();

                        sql = "CREATE TABLE if not exists t_pending_orderflow (" +
                                "flow_id  integer," +
                                "flow_no  varchar(128)," +
                                "item_no  varchar(20)," +
                                "unit_price  numeric(15,4)," +
                                "sale_price  numeric(15,4)," +
                                "sale_qnty  numeric(15,4)," +
                                "sale_money  numeric(15,4)," +
                                "oper_id  varchar(6)," +
                                "oper_date  datetime," +
                                "item_subno  varchar(30)," +
                                "item_clsno  varchar(6)," +
                                "item_name  varchar(60)," +
                                "item_status  varchar(1)," +
                                "item_subname  varchar(60)," +
                                "PRIMARY KEY (flow_id ASC, flow_no)" +
                                ");";
                        command = new SQLiteCommand(sql, this._dbPosSale);
                        command.ExecuteNonQuery();
                    }
                    catch (SQLiteException )
                    {

                    }
                    #endregion
                }
                else
                {
                    return true;
                }

            }
            catch (Exception exception4)
            {

                this._dbPosItem.CloseLite();
                if (this._dbPosSale.State != ConnectionState.Closed)
                {
                    this._dbPosSale.Close();
                }
                throw new Exception("打开本地资料库失败！请联系系统管理员！\r\n" + exception4.Message);
            }
            return true;
        }

        public void Dispose()
        {
            this.dbClose();
        }
        
        
        
        public SqlLiteHelper dbPosItem
        {
            get
            {
                return this._dbPosItem;
            }
        }

        public SQLiteConnection dbPosSale
        {
            get
            {
                return this._dbPosSale;
            }
        }
    }
}
