using System;
namespace ICE.POS.Model
{
    
    
    
    [Serializable]
    public partial class t_app_viplist
    {
        public t_app_viplist()
        { }
        #region Model
        private string _flow_no;
        private string _card_no;
        private decimal _score;
        private decimal _sale_amt;
        private string _oper_date;
        private string _voucher_no;
        private string _over_flag = "0";
        private string _com_flag = "0";
        private decimal _card_score = 0M;
        private decimal _card_amount = 0M;
        
        
        
        public string flow_no
        {
            set { _flow_no = value; }
            get { return _flow_no; }
        }
        
        
        
        public string card_no
        {
            set { _card_no = value; }
            get { return _card_no; }
        }
        
        
        
        public decimal score
        {
            set { _score = value; }
            get { return _score; }
        }
        
        
        
        public decimal sale_amt
        {
            set { _sale_amt = value; }
            get { return _sale_amt; }
        }
        
        
        
        public string oper_date
        {
            set { _oper_date = value; }
            get { return _oper_date; }
        }
        
        
        
        public string voucher_no
        {
            set { _voucher_no = value; }
            get { return _voucher_no; }
        }
        
        
        
        public string over_flag
        {
            set { _over_flag = value; }
            get { return _over_flag; }
        }
        
        
        
        public string com_flag
        {
            set { _com_flag = value; }
            get { return _com_flag; }
        }
        
        
        
        public decimal card_score
        {
            set { _card_score = value; }
            get { return _card_score; }
        }
        
        
        
        public decimal card_amount
        {
            set { _card_amount = value; }
            get { return _card_amount; }
        }
        #endregion Model
    }
}

