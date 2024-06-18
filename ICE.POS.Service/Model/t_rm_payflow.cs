namespace ICE.POS.Service
{
    using System;
	/// t_rm_payflow:实体类(属性说明自动提取数据库字段的描述信息)
	[Serializable]
	public partial class t_rm_payflow
	{
		public t_rm_payflow()
		{}
		#region Model
		private decimal _com_no;
		private decimal _flow_id;
		private string _flow_no;
		private decimal? _sale_amount=0M;
		private string _branch_no;
		private string _pay_way;
		private string _sell_way="A";
		private string _card_no;
		private string _vip_no;
		private string _coin_no="RMB";
		private decimal? _coin_rate;
		private decimal? _pay_amount=0M;
		private DateTime _oper_date;
		private string _oper_id;
		private string _counter_no;
		private string _sale_man;
		private string _memo;
		private string _voucher_no;
		private string _remote_flag;
		private string _exchange_flag="0";
		private string _shift_no;
		private string _com_flag="0";
		private string _posid;
		private DateTime? _uptime;
		private string _is_jxc="0";
		private DateTime? _real_date;
        private t_rm_saleflow[] saleFlowlListField;

       
		/// <summary>
		/// 
		/// </summary>
		public decimal com_no
		{
			set{ _com_no=value;}
			get{return _com_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal flow_id
		{
			set{ _flow_id=value;}
			get{return _flow_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flow_no
		{
			set{ _flow_no=value;}
			get{return _flow_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sale_amount
		{
			set{ _sale_amount=value;}
			get{return _sale_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string branch_no
		{
			set{ _branch_no=value;}
			get{return _branch_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_way
		{
			set{ _pay_way=value;}
			get{return _pay_way;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sell_way
		{
			set{ _sell_way=value;}
			get{return _sell_way;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_no
		{
			set{ _card_no=value;}
			get{return _card_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vip_no
		{
			set{ _vip_no=value;}
			get{return _vip_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string coin_no
		{
			set{ _coin_no=value;}
			get{return _coin_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? coin_rate
		{
			set{ _coin_rate=value;}
			get{return _coin_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pay_amount
		{
			set{ _pay_amount=value;}
			get{return _pay_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime oper_date
		{
			set{ _oper_date=value;}
			get{return _oper_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oper_id
		{
			set{ _oper_id=value;}
			get{return _oper_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string counter_no
		{
			set{ _counter_no=value;}
			get{return _counter_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sale_man
		{
			set{ _sale_man=value;}
			get{return _sale_man;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string voucher_no
		{
			set{ _voucher_no=value;}
			get{return _voucher_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remote_flag
		{
			set{ _remote_flag=value;}
			get{return _remote_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string exchange_flag
		{
			set{ _exchange_flag=value;}
			get{return _exchange_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shift_no
		{
			set{ _shift_no=value;}
			get{return _shift_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string com_flag
		{
			set{ _com_flag=value;}
			get{return _com_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string posid
		{
			set{ _posid=value;}
			get{return _posid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? uptime
		{
			set{ _uptime=value;}
			get{return _uptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_jxc
		{
			set{ _is_jxc=value;}
			get{return _is_jxc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? real_date
		{
			set{ _real_date=value;}
			get{return _real_date;}
		}
        /// <summary>
        /// 
        /// </summary>
       public t_rm_saleflow[] saleFlowlList
        {
            get { return saleFlowlListField; }
            set { saleFlowlListField = value; }
        }
		#endregion Model

	}
}

