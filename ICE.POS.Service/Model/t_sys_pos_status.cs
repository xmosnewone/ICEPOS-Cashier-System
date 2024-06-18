namespace ICE.POS.Service
{
    using System;
	/// t_sys_pos_status:实体类(属性说明自动提取数据库字段的描述信息)
	[Serializable]
	public partial class t_sys_pos_status
	{
		public t_sys_pos_status()
		{}
		#region Model
		private string _branch_no;
		private string _posid;
		private string _posdesc;
		private string _hostip;
		private string _hostname;
		private string _operdate;
		private decimal? _amount=0M;
		private decimal _orderqty;
		private DateTime _lasttime;
		private string _lastcashier;
		private string _status;
		private string _other;
		private string _com_flag="0";
		private string _load_flag="0";
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
		public string posid
		{
			set{ _posid=value;}
			get{return _posid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string posdesc
		{
			set{ _posdesc=value;}
			get{return _posdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hostip
		{
			set{ _hostip=value;}
			get{return _hostip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hostname
		{
			set{ _hostname=value;}
			get{return _hostname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operdate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal orderqty
		{
			set{ _orderqty=value;}
			get{return _orderqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime lasttime
		{
			set{ _lasttime=value;}
			get{return _lasttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lastcashier
		{
			set{ _lastcashier=value;}
			get{return _lastcashier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string other
		{
			set{ _other=value;}
			get{return _other;}
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
		public string load_flag
		{
			set{ _load_flag=value;}
			get{return _load_flag;}
		}
		#endregion Model

	}
}

