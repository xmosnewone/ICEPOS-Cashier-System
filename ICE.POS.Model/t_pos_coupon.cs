/********************************************************
 * Description:POS优惠券类
 * ******************************************************/
namespace ICE.POS.Model
{
    using System;
    using System.Collections.Generic;
    public class t_pos_coupon
    {
        //优惠券编号
        private string _giftcert_no;

        public string giftcert_no
        {
            get { return _giftcert_no; }
            set { _giftcert_no = value; }
        }

        //优惠券分类
        private string _gift_type;

        public string gift_type
        {
            get { return _gift_type; }
            set { _gift_type = value; }
        }

        //面值
        private decimal _gift_money;

        public decimal gift_money
        {
            get { return _gift_money; }
            set { _gift_money = value; }
        }


        //优惠券分类名称
        private string _title;
        
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        //状态
        private int _status;

        public int status
        {
            get { return _status; }
            set { _status = value; }
        }

        //开始日期
        private string _begin_date;

        public string begin_date
        {
            get { return _begin_date; }
            set { _begin_date = value; }
        }

        //结束日期
        private string _end_date;

        public string end_date
        {
            get { return _end_date; }
            set { _end_date = value; }
        }

        //所属分店
        private string _send_branch;

        public string send_branch
        {
            get { return _send_branch; }
            set { _send_branch = value; }
        }

        //领券会员uid
        private int _uid;

        public int uid
        {
            get { return _uid; }
            set { _uid = value; }
        }

        //订单号
        private string _flow_no;

        public string flow_no
        {
            get { return _flow_no; }
            set { _flow_no = value; }
        }

        public String branch_no { get; set; }

        public String oper_uid { get; set; }

        public String oper_date { get; set; }

        //可用最多张数
        private int _max_num;
        
        public int max_num
        {
            get { return _max_num; }
            set { _max_num = value; }
        }

        //使用该优惠券的最低金额
        private decimal _min_amount;
        
        public decimal min_amount
        {
            get { return _min_amount; }
            set { _min_amount = value; }
        }

        //可以混合其他券类使用,1可以混用，0不可以
        private int _is_com;
       
        public int is_com
        {
            get { return _is_com; }
            set { _is_com = value; }
        }

        //是或否
        private string _is_com_label;

        public string is_com_label
        {
            get { return _is_com_label; }
            set { _is_com_label = value; }
        }

        //是否已停止
        private int _is_stop;

        public int is_stop
        {
            get { return _is_stop; }
            set { _is_stop = value; }
        }

        private bool _isSelect = true;
        
        public bool isSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }

        public String code { get; set; }

        public String info { get; set; }
    }
}
