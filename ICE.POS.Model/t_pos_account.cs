namespace ICE.POS.Model
{
    using System;
    
    
    
    public class t_pos_account
    {
        public t_pos_account()
        { }
        #region Model
        private string _branch_no;
        private string _pos_id;
        private string _oper_id;
        private string _oper_date;
        private string _start_time;
        private string _end_time;
        private decimal? _sale_amt = 0M;
        private decimal? _hand_amt = 0M;
        private string _com_flag = "0";

        
        
        
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
        
        
        
        public string oper_id
        {
            set { _oper_id = value; }
            get { return _oper_id; }
        }
        
        
        
        public string oper_date
        {
            set { _oper_date = value; }
            get { return _oper_date; }
        }
        
        
        
        public string start_time
        {
            set { _start_time = value; }
            get { return _start_time; }
        }
        
        
        
        public string end_time
        {
            set { _end_time = value; }
            get { return _end_time; }
        }
        
        
        
        public decimal? sale_amt
        {
            set { _sale_amt = value; }
            get { return _sale_amt; }
        }
        
        
        
        public decimal? hand_amt
        {
            set { _hand_amt = value; }
            get { return _hand_amt; }
        }
        
        
        
        public string com_flag
        {
            set { _com_flag = value; }
            get { return _com_flag; }
        }
        #endregion Model
    }
}
