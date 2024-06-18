/********************************************************
 * Description:POS促销帮助类
 * ******************************************************/
namespace ICE.POS.Model
{
    using System;
    using System.Collections.Generic;
    public class t_rm_plan_master
    {
        private string _plan_no;
        
        
        
        public string plan_no
        {
            get { return _plan_no; }
            set { _plan_no = value; }
        }
        private string _plan_name;
        
        
        
        public string plan_name
        {
            get { return _plan_name; }
            set { _plan_name = value; }
        }
        private string _plan_memo;
        
        
        
        public string plan_memo
        {
            get { return _plan_memo; }
            set { _plan_memo = value; }
        }
        private DateTime _begin_date;
        
        
        
        public DateTime begin_date
        {
            get { return _begin_date; }
            set { _begin_date = value; }
        }
        private DateTime _end_date;
        
        
        
        public DateTime end_date
        {
            get { return _end_date; }
            set { _end_date = value; }
        }
        private string _week;
        
        
        
        public string week
        {
            get { return _week; }
            set { _week = value; }
        }
        private string _vip_type;
        
        
        
        public string vip_type
        {
            get { return _vip_type; }
            set { _vip_type = value; }
        }
        private DateTime _stop_date;
        
        
        
        public DateTime stop_date
        {
            get { return _stop_date; }
            set { _stop_date = value; }
        }
        private string _stop_man;
        
        
        
        public string stop_man
        {
            get { return _stop_man; }
            set { _stop_man = value; }
        }
        private string _approve_flag;
        
        
        
        public string approve_flag
        {
            get { return _approve_flag; }
            set { _approve_flag = value; }
        }
        private string _rule_no;
        
        
        
        public string rule_no
        {
            get { return _rule_no; }
            set { _rule_no = value; }
        }
        private string _range_flag;
        
        
        
        public string range_flag
        {
            get { return _range_flag; }
            set { _range_flag = value; }
        }
        private string _rule_describe;
        
        
        
        public string rule_describe
        {
            get { return _rule_describe; }
            set { _rule_describe = value; }
        }
        private string _rule_condition;
        
        
        
        public string rule_condition
        {
            get { return _rule_condition; }
            set { _rule_condition = value; }
        }
        private string _rule_result;
        
        
        
        public string rule_result
        {
            get { return _rule_result; }
            set { _rule_result = value; }
        }
        private string _plu_flag;
        
        
        
        public string plu_flag
        {
            get { return _plu_flag; }
            set { _plu_flag = value; }
        }
        private string _rule_desc;
        
        
        
        public string rule_desc
        {
            get { return _rule_desc; }
            set { _rule_desc = value; }
        }
        private PlanPara _planPara;
        
        
        
        public PlanPara PlanPara
        {
            get { return _planPara; }
            set { _planPara = value; }
        }

        private bool _isSelect = false;
        
        
        
        public bool isSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }
    }
}
