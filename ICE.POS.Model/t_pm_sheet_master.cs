using System;

namespace ICE.POS.Model
{
    
    
    
    [Serializable]
    public  class t_pm_sheet_master
    {
        public t_pm_sheet_master()
        { }
        #region Model
        private string _sheet_no;
        private string _trans_no;
        private string _db_no;
        private string _branch_no;
        private string _d_branch_no;
        private string _voucher_no;
        private string _supcust_no;
        private string _coin_no;
        private string _pay_way;
        private DateTime? _pay_date;
        private string _dept_flag;
        private string _approve_flag = "0";
        private DateTime? _oper_date;
        private DateTime? _work_date;
        private DateTime? _valid_date;
        private decimal? _order_amt;
        private string _order_status = "0";
        private string _order_man;
        private string _oper_id;
        private string _confirm_man;
        private string _dept_id;
        private string _sale_way;
        private string _reverse_flag;
        private string _reverse_sheet;
        private string _direct_flag;
        private string _trans_flag;
        private string _acct_flag;
        private string _other1;
        private string _other2;
        private string _other3;
        private decimal? _sheet_amt;
        private string _branch_flag;
        private string _com_flag;
        private decimal? _num1;
        private decimal? _num2;
        private string _relate_sheet_no;
        private string _memo;
        
        
        
        public string sheet_no
        {
            set { _sheet_no = value; }
            get { return _sheet_no; }
        }
        
        
        
        public string trans_no
        {
            set { _trans_no = value; }
            get { return _trans_no; }
        }
        
        
        
        public string db_no
        {
            set { _db_no = value; }
            get { return _db_no; }
        }
        
        
        
        public string branch_no
        {
            set { _branch_no = value; }
            get { return _branch_no; }
        }
        
        
        
        public string d_branch_no
        {
            set { _d_branch_no = value; }
            get { return _d_branch_no; }
        }
        
        
        
        public string voucher_no
        {
            set { _voucher_no = value; }
            get { return _voucher_no; }
        }
        
        
        
        public string supcust_no
        {
            set { _supcust_no = value; }
            get { return _supcust_no; }
        }
        
        
        
        public string coin_no
        {
            set { _coin_no = value; }
            get { return _coin_no; }
        }
        
        
        
        public string pay_way
        {
            set { _pay_way = value; }
            get { return _pay_way; }
        }
        
        
        
        public DateTime? pay_date
        {
            set { _pay_date = value; }
            get { return _pay_date; }
        }
        
        
        
        public string dept_flag
        {
            set { _dept_flag = value; }
            get { return _dept_flag; }
        }
        
        
        
        public string approve_flag
        {
            set { _approve_flag = value; }
            get { return _approve_flag; }
        }
        
        
        
        public DateTime? oper_date
        {
            set { _oper_date = value; }
            get { return _oper_date; }
        }
        
        
        
        public DateTime? work_date
        {
            set { _work_date = value; }
            get { return _work_date; }
        }
        
        
        
        public DateTime? valid_date
        {
            set { _valid_date = value; }
            get { return _valid_date; }
        }
        
        
        
        public decimal? order_amt
        {
            set { _order_amt = value; }
            get { return _order_amt; }
        }
        
        
        
        public string order_status
        {
            set { _order_status = value; }
            get { return _order_status; }
        }
        
        
        
        public string order_man
        {
            set { _order_man = value; }
            get { return _order_man; }
        }
        
        
        
        public string oper_id
        {
            set { _oper_id = value; }
            get { return _oper_id; }
        }
        
        
        
        public string confirm_man
        {
            set { _confirm_man = value; }
            get { return _confirm_man; }
        }
        
        
        
        public string dept_id
        {
            set { _dept_id = value; }
            get { return _dept_id; }
        }
        
        
        
        public string sale_way
        {
            set { _sale_way = value; }
            get { return _sale_way; }
        }
        
        
        
        public string reverse_flag
        {
            set { _reverse_flag = value; }
            get { return _reverse_flag; }
        }
        
        
        
        public string reverse_sheet
        {
            set { _reverse_sheet = value; }
            get { return _reverse_sheet; }
        }
        
        
        
        public string direct_flag
        {
            set { _direct_flag = value; }
            get { return _direct_flag; }
        }
        
        
        
        public string trans_flag
        {
            set { _trans_flag = value; }
            get { return _trans_flag; }
        }
        
        
        
        public string acct_flag
        {
            set { _acct_flag = value; }
            get { return _acct_flag; }
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
        
        
        
        public decimal? sheet_amt
        {
            set { _sheet_amt = value; }
            get { return _sheet_amt; }
        }
        
        
        
        public string branch_flag
        {
            set { _branch_flag = value; }
            get { return _branch_flag; }
        }
        
        
        
        public string com_flag
        {
            set { _com_flag = value; }
            get { return _com_flag; }
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
        
        
        
        public string relate_sheet_no
        {
            set { _relate_sheet_no = value; }
            get { return _relate_sheet_no; }
        }
        
        
        
        public string memo
        {
            set { _memo = value; }
            get { return _memo; }
        }
        #endregion Model
    }
}
