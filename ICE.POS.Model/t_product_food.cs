namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public class t_product_food
    {
        //CREATE TABLE "esales_product_food" ("item_no" CHAR(20) NOT NULL,
        //"item_subno" VARCHAR(15) NOT NULL,
        //"item_name" VARCHAR(100),
        //"item_subname" VARCHAR(50),
        //"item_clsno" VARCHAR(12),
        //"item_brand" VARCHAR(12),
        //"item_brandname" CHAR(6),
        //"unit_no" CHAR(4),
        //"item_size" VARCHAR(20),
        //"product_area" VARCHAR(18),
        //"price" NUMERIC(9, 4),
        //"sale_price" NUMERIC(9, 4),
        //"sale_price1" NUMERIC(9, 4),
        //"build_date" TIMESTAMP,
        //"lastchange_time" TIMESTAMP,
        //"status" NUMERIC(5),
        //"stock" NUMERIC(16, 4),
        //"stock_lasttime" TIMESTAMP,
        //"main_supcust" VARCHAR(20),
        //"images_ios" TEXT,
        //"content" TEXT,
        //"num2" VARCHAR(5),
        //"pifaopen" NUMERIC(5) DEFAULT 0,
        //"images" TEXT,
        //"appopen" NUMERIC(5) DEFAULT 1,
        //"headimages" VARCHAR(200),
        //"score" VARCHAR(30),
        //"scorenum" INTEGER,
        //PRIMARY KEY("item_no"))

        private string _item_no;
        private string _item_subno;
        private string _item_name;
        private string _item_subname;
        private string _item_clsno;
        private string _item_brand;
        private string _item_brandname;
        private string _unit_no;
        private string _item_size;
        private string _product_area;
        private decimal _price;
        private decimal _sale_price;
        private decimal _sale_price1;
        private int _status;
        private int _stock;
        private string _main_supcust;
        //"stock_lasttime" TIMESTAMP,
        //"content" TEXT,
        //"num2" VARCHAR(5),
        //"pifaopen" NUMERIC(5) DEFAULT 0,
        //"images" TEXT,
        //"appopen" NUMERIC(5) DEFAULT 1,
        //"headimages" VARCHAR(200),
        //"score" VARCHAR(30),
        //"scorenum" INTEGER,
        public string item_no
        {
            get { return this._item_no; }
            set { this._item_no = value; }
        }
        public string item_subno
        {
            get { return this._item_subno; }
            set { this._item_subno = value; }
        }
        public string item_name
        {
            get { return this._item_name; }
            set { this._item_name = value; }
        }
        public string item_subname
        {
            get { return this._item_subname; }
            set { this._item_subname = value; }
        }

        public string item_clsno
        {
            get { return this._item_clsno; }
            set { this._item_clsno = value; }
        }

        public string item_brand
        {
            get { return this._item_brand; }
            set { this._item_brand = value; }
        }
        public string item_brandname
        {
            get { return this._item_brandname; }
            set { this._item_brandname = value; }
        }
        public string unit_no
        {
            get { return this._unit_no; }
            set { this._unit_no = value; }
        }
        public string item_size
        {
            get { return this._item_size; }
            set { this._item_size = value; }
        }
        public string product_area
        {
            get { return this._product_area; }
            set { this._product_area = value; }
        }
        public decimal price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public decimal sale_price
        {
            get { return this._sale_price; }
            set { this._sale_price = value; }
        }
        public decimal sale_price1
        {
            get { return this._sale_price1; }
            set { this._sale_price1 = value; }
        }
        public int status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        public int stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        public string main_supcust
        {
            get { return this._main_supcust; }
            set { this._main_supcust = value; }
        }
    }
}
