namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public class t_vip_acclist
    {

        private string _flow_no;
        private string _card_id;
        private decimal _balance;
        private decimal _total_spending;
        private decimal _all_score;
        private decimal _use_score;
        private decimal _surplus_score;
        private DateTime _oper_time;
        
        
        
        public string flow_no
        {
            get
            {
                return this._flow_no;
            }
            set
            {
                this._flow_no = value;
            }
        }
        
        
        
        public string card_id
        {
            get
            {
                return this._card_id;
            }
            set
            {
                this._card_id = value;
            }
        }
        
        
        
        public decimal balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
        
        
        
        public decimal total_spending
        {
            get
            {
                return this._total_spending;
            }
            set
            {
                this._total_spending = value;
            }
        }
        
        
        
        public decimal all_score
        {
            get
            {
                return this._all_score;
            }
            set
            {
                this._all_score = value;
            }
        }
        
        
        
        public decimal use_score
        {
            get
            {
                return this._use_score;
            }
            set
            {
                this._use_score = value;
            }
        }
        
        
        
        public decimal surplus_score
        {
            get
            {
                return this._surplus_score;
            }
            set
            {
                this._surplus_score = value;
            }
        }
        
        
        
        public DateTime oper_time
        {
            get { return _oper_time; }
            set { _oper_time = value; }
        }
    }
}

