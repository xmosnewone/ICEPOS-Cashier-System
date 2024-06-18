namespace ICE.POS.Model
{
    using System;

    public  class t_pos_saleflow
    {
        public t_pos_saleflow()
        { }
        #region Model
        private int _id;
        private int? _flow_id;
        private string _flow_no;
        private string _item_no;
        private decimal? _unit_price;
        private decimal? _sale_price;
        private decimal? _sale_qnty;
        private decimal? _sale_money;
        private decimal? _in_price;
        private string _sell_way;
        private decimal? _discount_rate;
        private string _oper_id;
        private DateTime? _oper_date;
        private string _item_subno;
        private string _item_clsno;
        private string _item_brand;
        private string _item_name;
        private string _item_status;
        private string _item_subname;
        private int? _reasonid;
        private string _branch_no;
        private string _pos_id;
        private string _com_flag;
        private string _plan_no;
        
        
        
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        
        
        
        public int? flow_id
        {
            set { _flow_id = value; }
            get { return _flow_id; }
        }
        
        
        
        public string flow_no
        {
            set { _flow_no = value; }
            get { return _flow_no; }
        }
        
        
        
        public string item_no
        {
            set { _item_no = value; }
            get { return _item_no; }
        }
        
        
        
        public decimal? unit_price
        {
            set { _unit_price = value; }
            get { return _unit_price; }
        }
        
        
        
        public decimal? sale_price
        {
            set { _sale_price = value; }
            get { return _sale_price; }
        }
        
        
        
        public decimal? sale_qnty
        {
            set { _sale_qnty = value; }
            get { return _sale_qnty; }
        }
        
        
        
        public decimal? sale_money
        {
            set { _sale_money = value; }
            get { return _sale_money; }
        }
        
        
        
        public decimal? in_price
        {
            set { _in_price = value; }
            get { return _in_price; }
        }
        
        
        
        public string sell_way
        {
            set { _sell_way = value; }
            get { return _sell_way; }
        }
        
        
        
        public decimal? discount_rate
        {
            set { _discount_rate = value; }
            get { return _discount_rate; }
        }
        
        
        
        public string oper_id
        {
            set { _oper_id = value; }
            get { return _oper_id; }
        }
        
        
        
        public DateTime? oper_date
        {
            set { _oper_date = value; }
            get { return _oper_date; }
        }
        
        
        
        public string item_subno
        {
            set { _item_subno = value; }
            get { return _item_subno; }
        }
        
        
        
        public string item_clsno
        {
            set { _item_clsno = value; }
            get { return _item_clsno; }
        }
        
        
        
        public string item_brand
        {
            set { _item_brand = value; }
            get { return _item_brand; }
        }
        
        
        
        public string item_name
        {
            set { _item_name = value; }
            get { return _item_name; }
        }
        
        
        
        public string item_status
        {
            set { _item_status = value; }
            get { return _item_status; }
        }
        
        
        
        public string item_subname
        {
            set { _item_subname = value; }
            get { return _item_subname; }
        }
        
        
        
        public int? reasonid
        {
            set { _reasonid = value; }
            get { return _reasonid; }
        }
        
        
        
        public string branch_no
        {
            set { _branch_no = value; }
            get { return _branch_no; }
        }
        
        
        
        public string pos_id
        {
            set { _pos_id = value; }
            get { return _pos_id; }
        }
        
        
        
        public string com_flag
        {
            set { _com_flag = value; }
            get { return _com_flag; }
        }
        
        
        
        public string plan_no
        {
            set { _plan_no = value; }
            get { return _plan_no; }
        }
        #endregion Model

    }
}
