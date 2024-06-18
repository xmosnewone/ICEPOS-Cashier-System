namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public class t_vip_info
    {

        private int _id;
        private string _vip_card_id;
        private string _vip_card_pwd;
        private DateTime _reg_time;
        private string _full_name;
        private string _company;
        private string _mobile;
        private string _qq;
        private string _email;
        private string _message;
        private decimal _insurance = 0M;
        private decimal _recharge = 0M;
        private decimal _game = 0;
        private int _messageapi = 0;
        private int _ionsuranceapi = 0;
        private int _rechargeapi = 0;
        private int _gameapi = 0;
        private string _md5key;
        private string _level = "1";
        private decimal _balance = 0M;
        private decimal _total_spending = 0M;
        private int _state = 0;
        private decimal _lowest = 1000M;
        private int _sms_default_way = 1;
        private string _reg_type = "WEB";
        private string _key;
        private string _message_last;
        private string _ios_message_cllect;
        private string _ios_food_collect;
        private decimal _all_score = 0;
        private decimal _use_score = 0;
        private string _ios_devicetoken;
        private string _ios_devicetoken_cns;
        private string _smsmk_pwd;
        private decimal _surplus_score;

       
        public object Clone()
        {
            return base.MemberwiseClone();
        }
        
        
        
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        
        
        public string vip_card_id
        {
            get { return _vip_card_id; }
            set { _vip_card_id = value; }
        }
        
        
        
        public string vip_card_pwd
        {
            get { return _vip_card_pwd; }
            set { _vip_card_pwd = value; }
        }
        
        
        
        public DateTime reg_time
        {
            get { return _reg_time; }
            set { _reg_time = value; }
        }
        
        
        
        public string full_name
        {
            get { return _full_name; }
            set { _full_name = value; }
        }
        
        
        
        public string company
        {
            get { return _company; }
            set { _company = value; }
        }
        
        
        
        public string mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        
        
        
        public string qq
        {
            get { return _qq; }
            set { _qq = value; }
        }
        
        
        
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        
        
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        
        public decimal insurance
        {
            get { return _insurance; }
            set { _insurance = value; }
        }
        
        
        
        public decimal recharge
        {
            get { return _recharge; }
            set { _recharge = value; }
        }
       
        public decimal game
        {
            get { return _game; }
            set { _game = value; }
        }

        public int messageapi
        {
            get { return _messageapi; }
            set { _messageapi = value; }
        }

        public int ionsuranceapi
        {
            get { return _ionsuranceapi; }
            set { _ionsuranceapi = value; }
        }

        public int rechargeapi
        {
            get { return _rechargeapi; }
            set { _rechargeapi = value; }
        }

        public int gameapi
        {
            get { return _gameapi; }
            set { _gameapi = value; }
        }
       
        public string md5key
        {
            get { return _md5key; }
            set { _md5key = value; }
        }
        
        public string level
        {
            get { return _level; }
            set { _level = value; }
        }
        
        
        
        public decimal balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        
        
        
        public decimal total_spending
        {
            get { return _total_spending; }
            set { _total_spending = value; }
        }
        
        
        
        public int state
        {
            get { return _state; }
            set { _state = value; }
        }
       
        public decimal lowest
        {
            get { return _lowest; }
            set { _lowest = value; }
        }
        
        public int sms_default_way
        {
            get { return _sms_default_way; }
            set { _sms_default_way = value; }
        }
        
        
        
        public string reg_type
        {
            get { return _reg_type; }
            set { _reg_type = value; }
        }
        
        public string key
        {
            get { return _key; }
            set { _key = value; }
        }
       
        public string message_last
        {
            get { return _message_last; }
            set { _message_last = value; }
        }
       
        public string ios_message_cllect
        {
            get { return _ios_message_cllect; }
            set { _ios_message_cllect = value; }
        }
       
        public string ios_food_collect
        {
            get { return _ios_food_collect; }
            set { _ios_food_collect = value; }
        }
        
        
        
        public decimal all_score
        {
            get { return _all_score; }
            set { _all_score = value; }
        }
        
        
        
        public decimal use_score
        {
            get { return _use_score; }
            set { _use_score = value; }
        }
        
        public string ios_devicetoken
        {
            get { return _ios_devicetoken; }
            set { _ios_devicetoken = value; }
        }
        

        public string ios_devicetoken_cns
        {
            get { return _ios_devicetoken_cns; }
            set { _ios_devicetoken_cns = value; }
        }
        public string smsmk_pwd
        {
            get { return _smsmk_pwd; }
            set { _smsmk_pwd = value; }
        }
        
        
        
        public decimal surplus_score
        {
            get { return _surplus_score; }
            set { _surplus_score = value; }
        }

    }
}
