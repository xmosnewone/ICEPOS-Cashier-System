using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.POS.Model
{
    
    
    
    [Serializable]
    public partial class t_pm_sheet_detail
    {
        public t_pm_sheet_detail()
        { }
        #region Model
        private int _flow_id;
        private string _sheet_no;
        private string _item_no;
        private decimal? _order_qty = 0.0000M;
        private decimal? _real_qty = 0.0000M;
        private decimal? _large_qty;
        private decimal? _send_qty = 0.0000M;
        private decimal? _orgi_price = 0.0000M;
        private decimal? _valid_price;
        private decimal? _sub_amt;
        private decimal? _tax;
        private DateTime? _valid_date;
        private string _other1;
        private string _other2;
        private string _other3;
        private decimal? _num1;
        private decimal? _num2;
        private decimal? _num3;
        private decimal? _route_qty;
        private decimal? _jhd_qty;
        
        
        
        public int flow_id
        {
            set { _flow_id = value; }
            get { return _flow_id; }
        }
        
        
        
        public string sheet_no
        {
            set { _sheet_no = value; }
            get { return _sheet_no; }
        }
        
        
        
        public string item_no
        {
            set { _item_no = value; }
            get { return _item_no; }
        }
        
        
        
        public decimal? order_qty
        {
            set { _order_qty = value; }
            get { return _order_qty; }
        }
        
        
        
        public decimal? real_qty
        {
            set { _real_qty = value; }
            get { return _real_qty; }
        }
        
        
        
        public decimal? large_qty
        {
            set { _large_qty = value; }
            get { return _large_qty; }
        }
        
        
        
        public decimal? send_qty
        {
            set { _send_qty = value; }
            get { return _send_qty; }
        }
        
        
        
        public decimal? orgi_price
        {
            set { _orgi_price = value; }
            get { return _orgi_price; }
        }
        
        
        
        public decimal? valid_price
        {
            set { _valid_price = value; }
            get { return _valid_price; }
        }
        
        
        
        public decimal? sub_amt
        {
            set { _sub_amt = value; }
            get { return _sub_amt; }
        }
        
        
        
        public decimal? tax
        {
            set { _tax = value; }
            get { return _tax; }
        }
        
        
        
        public DateTime? valid_date
        {
            set { _valid_date = value; }
            get { return _valid_date; }
        }
        
        
        
        public string other1
        {
            set { _other1 = value; }
            get { return _other1; }
        }
        
        
        
        public string other2
        {
            set { _other2 = value; }
            get { return _other2; }
        }
        
        
        
        public string other3
        {
            set { _other3 = value; }
            get { return _other3; }
        }
        
        
        
        public decimal? num1
        {
            set { _num1 = value; }
            get { return _num1; }
        }
        
        
        
        public decimal? num2
        {
            set { _num2 = value; }
            get { return _num2; }
        }
        
        
        
        public decimal? num3
        {
            set { _num3 = value; }
            get { return _num3; }
        }
        
        
        
        public decimal? route_qty
        {
            set { _route_qty = value; }
            get { return _route_qty; }
        }
        
        
        
        public decimal? jhd_qty
        {
            set { _jhd_qty = value; }
            get { return _jhd_qty; }
        }
        #endregion Model

    }
}
