namespace ICE.POS.Service
{
    using System;
	/// t_rm_card_paylist:实体类(属性说明自动提取数据库字段的描述信息)
	[Serializable]
	public partial class t_rm_card_paylist
	{
		public t_rm_card_paylist()
		{}
		#region Model
		private decimal _id;
		private string _flow_no;
		private string _card_type;
		private string _card_id;
		private decimal? _amount=0M;
		private DateTime _pay_time;
		private string _other1;
		private string _other2;
		private string _branch_no;
		private decimal? _residual_amt=0M;
		private string _com_flag="0";
		private decimal? _vip_acc=0M;
		private DateTime? _real_date;
		/// <summary>
		/// 
		/// </summary>
		public decimal id
		{
			set{ _id=value;}
			get{return _id;}
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
		public string card_type
		{
			set{ _card_type=value;}
			get{return _card_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_id
		{
			set{ _card_id=value;}
			get{return _card_id;}
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
		public DateTime pay_time
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string other1
		{
			set{ _other1=value;}
			get{return _other1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string other2
		{
			set{ _other2=value;}
			get{return _other2;}
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
		public decimal? residual_amt
		{
			set{ _residual_amt=value;}
			get{return _residual_amt;}
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
		public decimal? vip_acc
		{
			set{ _vip_acc=value;}
			get{return _vip_acc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? real_date
		{
			set{ _real_date=value;}
			get{return _real_date;}
		}
		#endregion Model

	}
}

