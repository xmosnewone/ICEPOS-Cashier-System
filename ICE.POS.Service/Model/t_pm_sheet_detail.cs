namespace ICE.POS.Service
{
    using System;
	/// t_pm_sheet_detail:实体类(属性说明自动提取数据库字段的描述信息)
	[Serializable]
	public partial class t_pm_sheet_detail
	{
		public t_pm_sheet_detail()
		{}
		#region Model
		private decimal _flow_id;
		private string _sheet_no;
		private string _item_no;
		private decimal? _order_qty=0M;
		private decimal? _real_qty=0M;
		private decimal? _large_qty=0M;
		private decimal? _orgi_price=0M;
		private decimal? _valid_price=0M;
		private decimal? _sub_amt=0M;
		private decimal? _tax;
		private DateTime? _valid_date;
		private string _other1;
		private string _other2;
		private string _other3;
		private decimal? _num1=0M;
		private decimal? _num2=0M;
		private decimal? _num3=0M;
		private decimal? _route_qty;
		private decimal? _jhd_qty;
		private string _sheet_mo;
		private decimal? _mo_qty;
		private string _sheet_po;
		private decimal? _po_qty;
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
		public string sheet_no
		{
			set{ _sheet_no=value;}
			get{return _sheet_no;}
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
		public decimal? order_qty
		{
			set{ _order_qty=value;}
			get{return _order_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? real_qty
		{
			set{ _real_qty=value;}
			get{return _real_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? large_qty
		{
			set{ _large_qty=value;}
			get{return _large_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? orgi_price
		{
			set{ _orgi_price=value;}
			get{return _orgi_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? valid_price
		{
			set{ _valid_price=value;}
			get{return _valid_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sub_amt
		{
			set{ _sub_amt=value;}
			get{return _sub_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? tax
		{
			set{ _tax=value;}
			get{return _tax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? valid_date
		{
			set{ _valid_date=value;}
			get{return _valid_date;}
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
		public string other3
		{
			set{ _other3=value;}
			get{return _other3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? num1
		{
			set{ _num1=value;}
			get{return _num1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? num2
		{
			set{ _num2=value;}
			get{return _num2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? num3
		{
			set{ _num3=value;}
			get{return _num3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? route_qty
		{
			set{ _route_qty=value;}
			get{return _route_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? jhd_qty
		{
			set{ _jhd_qty=value;}
			get{return _jhd_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sheet_mo
		{
			set{ _sheet_mo=value;}
			get{return _sheet_mo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? mo_qty
		{
			set{ _mo_qty=value;}
			get{return _mo_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sheet_po
		{
			set{ _sheet_po=value;}
			get{return _sheet_po;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? po_qty
		{
			set{ _po_qty=value;}
			get{return _po_qty;}
		}
		#endregion Model

	}
}

