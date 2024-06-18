namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public class t_dict_payment_info
    {
        private string _pay_way;
        private int _pay_flag;
        private string _pay_name;
        private decimal _rate;
        private string _pay_memo;

        
        
        
        public string pay_way
        {
            get { return _pay_way; }
            set { _pay_way = value; }
        }
        
        
        
        public int pay_flag
        {
            get { return _pay_flag; }
            set { _pay_flag = value; }
        }

        
        
        
        public string pay_name
        {
            get { return _pay_name; }
            set { _pay_name = value; }
        }
        
        
        
        public decimal rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        
        
        
        public string pay_memo
        {
            get { return _pay_memo; }
            set { _pay_memo = value; }
        }
    }
}
