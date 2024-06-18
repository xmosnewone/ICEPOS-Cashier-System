namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public class t_cur_payflow
    {
        private decimal _flow_id;
        private string _flow_no;
        private decimal _sale_amount; //付款总金额
        private string _pay_way; //支付方式:RMB,CRD 代码
        private decimal _pay_amount;//支付金额:
        private string _coin_type; //货币类型: 美元，英镑
        private string _pay_name; //支付名称：信用卡，现金
        private decimal _coin_rate; //汇率
        private decimal _convert_amt; //折算金额
        private string _card_no; //卡号
        private string _oper_date;
        private string _oper_id;
        private string _memo;

        public decimal flow_id
        {
            get { return _flow_id; }
            set { _flow_id = value; }
        }

        public string flow_no
        {
            get { return _flow_no; }
            set { _flow_no = value; }
        }

        public string pay_way
        {
            get { return _pay_way; }
            set { _pay_way = value; }
        }

        public decimal sale_amount
        {
            get { return _sale_amount; }
            set { _sale_amount = value; }
        }

        public decimal pay_amount
        {
            get { return _pay_amount; }
            set { _pay_amount = value; }
        }

        public string oper_id
        {
            get { return _oper_id; }
            set { _oper_id = value; }
        }

        public string oper_date
        {
            get { return _oper_date; }
            set { _oper_date = value; }
        }

        public string coin_type
        {
            get { return _coin_type; }
            set { _coin_type = value; }
        }

        public string pay_name
        {
            get { return _pay_name; }
            set { _pay_name = value; }
        }

        public string card_no
        {
            get { return _card_no; }
            set { _card_no = value; }
        }

        public decimal coin_rate
        {
            get { return _coin_rate; }
            set { _coin_rate = value; }
        }


        public decimal convert_amt
        {
            get { return _convert_amt; }
            set { _convert_amt = value; }
        }

        public string memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        private string _voucher_no;
        public string voucher_no
        {
            get { return _voucher_no; }
            set { _voucher_no = value; }
        }
        private String _branch_no;
        
        
        
        public String branch_no
        {
            get
            {
                return _branch_no;
            }
            set
            {
                _branch_no = value;
            }
        }
        private String _pos_id;
        
        
        
        public String pos_id
        {
            get
            {
                return _pos_id;
            }
            set
            {
                _pos_id = value;
            }
        }
        private String _sale_way = "A";
        
        
        
        public String sale_way
        {
            get
            {
                return _sale_way;
            }
            set
            {
                _sale_way = value;
            }
        }

        private string _vip_no;
        
        
        
        public string vip_no
        {
            get
            {
                return _vip_no;
            }
            set
            {
                _vip_no = value;
            }
        }
    }
}
