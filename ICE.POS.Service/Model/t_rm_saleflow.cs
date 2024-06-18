namespace ICE.POS.Service
{
    using System;
	/// t_rm_saleflow:实体类(属性说明自动提取数据库字段的描述信息)
	[Serializable]
	public partial class t_rm_saleflow
	{
		public t_rm_saleflow()
		{}
		#region Model
		private decimal _com_no;
		private decimal _flow_id;
		private string _flow_no;
		private string _branch_no;
		private string _item_no;
		private decimal? _source_price=0M;
		private decimal? _sale_price=0M;
		private decimal? _sale_qnty=0M;
		private decimal? _sale_money=0M;
		private string _sell_way="A";
		private string _oper_id;
		private string _sale_man;
		private string _counter_no;
		private DateTime _oper_date;
		private string _remote_flag="0";
		private string _shift_no;
		private string _com_flag="0";
		private string _spec_flag;
		private decimal? _pref_amt=0M;
		private decimal? _in_price=0M;
		private decimal? _n_stan=0M;
		private string _chr_stan;
		private string _posid;
		private DateTime _uptime;
		private string _is_jxc="0";
		private DateTime _real_date;
		private string _spec_sheet_no;
		private string _spec_group_id;
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
		public string branch_no
		{
			set{ _branch_no=value;}
			get{return _branch_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string item_no
		{
			set{ _item_no=value;}
			get{return _item_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? source_price
		{
			set{ _source_price=value;}
			get{return _source_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sale_price
		{
			set{ _sale_price=value;}
			get{return _sale_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sale_qnty
		{
			set{ _sale_qnty=value;}
			get{return _sale_qnty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sale_money
		{
			set{ _sale_money=value;}
			get{return _sale_money;}
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
		public string oper_id
		{
			set{ _oper_id=value;}
			get{return _oper_id;}
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
		public string counter_no
		{
			set{ _counter_no=value;}
			get{return _counter_no;}
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
		public string remote_flag
		{
			set{ _remote_flag=value;}
			get{return _remote_flag;}
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
		public string spec_flag
		{
			set{ _spec_flag=value;}
			get{return _spec_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pref_amt
		{
			set{ _pref_amt=value;}
			get{return _pref_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? in_price
		{
			set{ _in_price=value;}
			get{return _in_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_stan
		{
			set{ _n_stan=value;}
			get{return _n_stan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string chr_stan
		{
			set{ _chr_stan=value;}
			get{return _chr_stan;}
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
		public DateTime uptime
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
		public DateTime real_date
		{
			set{ _real_date=value;}
			get{return _real_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string spec_sheet_no
		{
			set{ _spec_sheet_no=value;}
			get{return _spec_sheet_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string spec_group_id
		{
			set{ _spec_group_id=value;}
			get{return _spec_group_id;}
		}
		#endregion Model

	}
}

