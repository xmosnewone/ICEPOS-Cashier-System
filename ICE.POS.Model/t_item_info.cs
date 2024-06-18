namespace ICE.POS.Model
{
    using System;
    [Serializable]
    public partial class t_item_info
    {
        public t_item_info()
		{}
		#region Model
		private string _item_no;
		private string _item_subno="0";
		private string _item_name;
		private string _item_subname;
		private string _item_clsno="LB";
		private string _item_brand="PP";
		private string _item_brandname="PM";
		private string _unit_no;
		private string _item_size;
		private string _product_area;
		private decimal _price=0M;
		private decimal _base_price=0M;
		private decimal _sale_price=0M;
		private string _combine_sta="0";
		private string _status="1";
		private string _display_flag="1";
		private string _other1;
		private string _other2;
		private string _other3;
		private decimal? _num1=0M;
		private decimal? _num2=0M;
		private decimal? _num3=0M;
		private int? _po_cycle=0;
		private int? _so_cycle=0;
		private string _automin_flag="1";
		private string _en_dis="0";
		private string _direct="2";
		private string _change_price="0";
		private decimal? _purchase_tax=0.17M;
		private decimal? _sale_tax=0.17M;
		private decimal? _purchase_spec=1M;
		private decimal? _shipment_spec=1M;
		private string _item_supcust;
		private string _main_supcust="0";
		private decimal? _lose_rate=0M;
		private string _item_sup_flag="A";
		private string _item_stock="0";
		private string _item_counter="9999";
		private decimal? _sup_ly_rate=0M;
		private DateTime _build_date;
		private DateTime? _modify_date;
		private DateTime? _stop_date;
		private decimal? _return_rate=0M;
		private string _abc="C";
		private string _branch_price="0";
		private string _item_rem;
		private decimal? _vip_price=0M;
		private decimal? _sale_min_price=0M;
		private string _branch_no;
		private string _cost_compute="0";
		private string _com_flag="0";
		private decimal? _base_price1=0M;
		private decimal? _base_price2=0M;
		private decimal? _base_price3=0M;
		private string _vip_acc_flag="1";
		private decimal? _vip_acc_num=0M;
		private string _dpfm_type="0";
		private decimal? _trans_price=0M;
		private decimal? _vip_price1=0M;
		private decimal? _vip_price2=0M;
		private decimal? _base_price4=0M;
		private string _build_man;
		private string _last_modi_man;
		private decimal? _order_man_rate=0M;
		private string _om_rate_type;
		private string _is_high="0";
		private string _is_focus="0";



		public string item_no
		{
			set{ _item_no=value;}
			get{return _item_no;}
		}



		public string item_subno
		{
			set{ _item_subno=value;}
			get{return _item_subno;}
		}



		public string item_name
		{
			set{ _item_name=value;}
			get{return _item_name;}
		}



		public string item_subname
		{
			set{ _item_subname=value;}
			get{return _item_subname;}
		}



		public string item_clsno
		{
			set{ _item_clsno=value;}
			get{return _item_clsno;}
		}



		public string item_brand
		{
			set{ _item_brand=value;}
			get{return _item_brand;}
		}



		public string item_brandname
		{
			set{ _item_brandname=value;}
			get{return _item_brandname;}
		}



		public string unit_no
		{
			set{ _unit_no=value;}
			get{return _unit_no;}
		}



		public string item_size
		{
			set{ _item_size=value;}
			get{return _item_size;}
		}



		public string product_area
		{
			set{ _product_area=value;}
			get{return _product_area;}
		}



		public decimal price
		{
			set{ _price=value;}
			get{return _price;}
		}



		public decimal base_price
		{
			set{ _base_price=value;}
			get{return _base_price;}
		}



		public decimal sale_price
		{
			set{ _sale_price=value;}
			get{return _sale_price;}
		}



		public string combine_sta
		{
			set{ _combine_sta=value;}
			get{return _combine_sta;}
		}



		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}



		public string display_flag
		{
			set{ _display_flag=value;}
			get{return _display_flag;}
		}



		public string other1
		{
			set{ _other1=value;}
			get{return _other1;}
		}



		public string other2
		{
			set{ _other2=value;}
			get{return _other2;}
		}



		public string other3
		{
			set{ _other3=value;}
			get{return _other3;}
		}



		public decimal? num1
		{
			set{ _num1=value;}
			get{return _num1;}
		}



		public decimal? num2
		{
			set{ _num2=value;}
			get{return _num2;}
		}



		public decimal? num3
		{
			set{ _num3=value;}
			get{return _num3;}
		}



		public int? po_cycle
		{
			set{ _po_cycle=value;}
			get{return _po_cycle;}
		}



		public int? so_cycle
		{
			set{ _so_cycle=value;}
			get{return _so_cycle;}
		}



		public string automin_flag
		{
			set{ _automin_flag=value;}
			get{return _automin_flag;}
		}



		public string en_dis
		{
			set{ _en_dis=value;}
			get{return _en_dis;}
		}



		public string direct
		{
			set{ _direct=value;}
			get{return _direct;}
		}



		public string change_price
		{
			set{ _change_price=value;}
			get{return _change_price;}
		}



		public decimal? purchase_tax
		{
			set{ _purchase_tax=value;}
			get{return _purchase_tax;}
		}



		public decimal? sale_tax
		{
			set{ _sale_tax=value;}
			get{return _sale_tax;}
		}



		public decimal? purchase_spec
		{
			set{ _purchase_spec=value;}
			get{return _purchase_spec;}
		}



		public decimal? shipment_spec
		{
			set{ _shipment_spec=value;}
			get{return _shipment_spec;}
		}



		public string item_supcust
		{
			set{ _item_supcust=value;}
			get{return _item_supcust;}
		}



		public string main_supcust
		{
			set{ _main_supcust=value;}
			get{return _main_supcust;}
		}



		public decimal? lose_rate
		{
			set{ _lose_rate=value;}
			get{return _lose_rate;}
		}



		public string item_sup_flag
		{
			set{ _item_sup_flag=value;}
			get{return _item_sup_flag;}
		}



		public string item_stock
		{
			set{ _item_stock=value;}
			get{return _item_stock;}
		}



		public string item_counter
		{
			set{ _item_counter=value;}
			get{return _item_counter;}
		}



		public decimal? sup_ly_rate
		{
			set{ _sup_ly_rate=value;}
			get{return _sup_ly_rate;}
		}



		public DateTime build_date
		{
			set{ _build_date=value;}
			get{return _build_date;}
		}



		public DateTime? modify_date
		{
			set{ _modify_date=value;}
			get{return _modify_date;}
		}



		public DateTime? stop_date
		{
			set{ _stop_date=value;}
			get{return _stop_date;}
		}



		public decimal? return_rate
		{
			set{ _return_rate=value;}
			get{return _return_rate;}
		}



		public string abc
		{
			set{ _abc=value;}
			get{return _abc;}
		}



		public string branch_price
		{
			set{ _branch_price=value;}
			get{return _branch_price;}
		}



		public string item_rem
		{
			set{ _item_rem=value;}
			get{return _item_rem;}
		}



		public decimal? vip_price
		{
			set{ _vip_price=value;}
			get{return _vip_price;}
		}



		public decimal? sale_min_price
		{
			set{ _sale_min_price=value;}
			get{return _sale_min_price;}
		}



		public string branch_no
		{
			set{ _branch_no=value;}
			get{return _branch_no;}
		}



		public string cost_compute
		{
			set{ _cost_compute=value;}
			get{return _cost_compute;}
		}



		public string com_flag
		{
			set{ _com_flag=value;}
			get{return _com_flag;}
		}



		public decimal? base_price1
		{
			set{ _base_price1=value;}
			get{return _base_price1;}
		}



		public decimal? base_price2
		{
			set{ _base_price2=value;}
			get{return _base_price2;}
		}



		public decimal? base_price3
		{
			set{ _base_price3=value;}
			get{return _base_price3;}
		}



		public string vip_acc_flag
		{
			set{ _vip_acc_flag=value;}
			get{return _vip_acc_flag;}
		}



		public decimal? vip_acc_num
		{
			set{ _vip_acc_num=value;}
			get{return _vip_acc_num;}
		}



		public string dpfm_type
		{
			set{ _dpfm_type=value;}
			get{return _dpfm_type;}
		}



		public decimal? trans_price
		{
			set{ _trans_price=value;}
			get{return _trans_price;}
		}



		public decimal? vip_price1
		{
			set{ _vip_price1=value;}
			get{return _vip_price1;}
		}



		public decimal? vip_price2
		{
			set{ _vip_price2=value;}
			get{return _vip_price2;}
		}



		public decimal? base_price4
		{
			set{ _base_price4=value;}
			get{return _base_price4;}
		}



		public string build_man
		{
			set{ _build_man=value;}
			get{return _build_man;}
		}



		public string last_modi_man
		{
			set{ _last_modi_man=value;}
			get{return _last_modi_man;}
		}



		public decimal? order_man_rate
		{
			set{ _order_man_rate=value;}
			get{return _order_man_rate;}
		}



		public string om_rate_type
		{
			set{ _om_rate_type=value;}
			get{return _om_rate_type;}
		}



		public string is_high
		{
			set{ _is_high=value;}
			get{return _is_high;}
		}



		public string is_focus
		{
			set{ _is_focus=value;}
			get{return _is_focus;}
		}
		#endregion Model
    }
}
