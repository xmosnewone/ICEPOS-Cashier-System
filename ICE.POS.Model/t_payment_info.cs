namespace ICE.POS.Model
{
    using System;
    
    
    
    public class t_payment_info
    {
        private String _pay_way;
        
        
        
        public String pay_way
        {
            get { return _pay_way; }
            set { _pay_way = value; }
        }
        private String _pay_flag;
        
        
        
        public String pay_flag
        {
            get
            {
                return _pay_flag;
            }
            set
            {
                _pay_flag = value;
            }
        }
        private String _pay_name;
        
        
        
        public String pay_name
        {
            get
            {
                return _pay_name;
            }
            set
            {
                _pay_name = value;
            }
        }
        private Decimal _rate;
        
        
        
        public Decimal rate
        {
            get
            {
                return _rate;
            }
            set
            {
                _rate = value;
            }
        }
        private String _memo;
        
        
        
        public String memo
        {
            get
            {
                return _memo;
            }
            set
            {
                _memo = value;
            }
        }
    }
}
