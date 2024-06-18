namespace ICE.POS.Service
{
    using System;
	/// t_pm_sheet_master:实体类(属性说明自动提取数据库字段的描述信息)
	[Serializable]
	public partial class t_pm_sheet_master
	{
		public t_pm_sheet_master()
		{}
		#region Model
        private t_pm_sheet_detail[] detailListField;
		private string _sheet_no;
		private string _trans_no;
		private string _db_no;
		private string _branch_no;
		private string _d_branch_no;
		private string _voucher_no;
		private string _supcust_no;
		private string _coin_no="RMB";
		private string _pay_way;
		private DateTime? _pay_date;
		private string _dept_flag;
		private string _approve_flag;
		private DateTime _oper_date;
		private DateTime? _work_date;
		private DateTime? _valid_date;
		private decimal? _order_amt=0M;
		private string _order_status;
		private string _order_man;
		private string _oper_id;
		private string _confirm_man;
		private string _dept_id;
		private string _sale_way="A";
		private string _reverse_flag;
		private string _reverse_sheet;
		private string _direct_flag="0";
		private string _trans_flag;
		private string _acct_flag;
		private string _other1;
		private string _other2;
		private string _other3;
		private decimal? _sheet_amt=0M;
		private string _branch_flag;
		private string _com_flag="0";
		private decimal? _num1=0M;
		private decimal? _num2=0M;
		private string _relate_sheet_no;
		private string _memo;
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
		public string trans_no
		{
			set{ _trans_no=value;}
			get{return _trans_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string db_no
		{
			set{ _db_no=value;}
			get{return _db_no;}
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
		public string d_branch_no
		{
			set{ _d_branch_no=value;}
			get{return _d_branch_no;}
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
		public string supcust_no
		{
			set{ _supcust_no=value;}
			get{return _supcust_no;}
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
		public string pay_way
		{
			set{ _pay_way=value;}
			get{return _pay_way;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? pay_date
		{
			set{ _pay_date=value;}
			get{return _pay_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept_flag
		{
			set{ _dept_flag=value;}
			get{return _dept_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string approve_flag
		{
			set{ _approve_flag=value;}
			get{return _approve_flag;}
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
		public DateTime? work_date
		{
			set{ _work_date=value;}
			get{return _work_date;}
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
		public decimal? order_amt
		{
			set{ _order_amt=value;}
			get{return _order_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string order_status
		{
			set{ _order_status=value;}
			get{return _order_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string order_man
		{
			set{ _order_man=value;}
			get{return _order_man;}
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
		public string confirm_man
		{
			set{ _confirm_man=value;}
			get{return _confirm_man;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dept_id
		{
			set{ _dept_id=value;}
			get{return _dept_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sale_way
		{
			set{ _sale_way=value;}
			get{return _sale_way;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reverse_flag
		{
			set{ _reverse_flag=value;}
			get{return _reverse_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reverse_sheet
		{
			set{ _reverse_sheet=value;}
			get{return _reverse_sheet;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string direct_flag
		{
			set{ _direct_flag=value;}
			get{return _direct_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trans_flag
		{
			set{ _trans_flag=value;}
			get{return _trans_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string acct_flag
		{
			set{ _acct_flag=value;}
			get{return _acct_flag;}
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
		public decimal? sheet_amt
		{
			set{ _sheet_amt=value;}
			get{return _sheet_amt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string branch_flag
		{
			set{ _branch_flag=value;}
			get{return _branch_flag;}
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
		public string relate_sheet_no
		{
			set{ _relate_sheet_no=value;}
			get{return _relate_sheet_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
        public t_pm_sheet_detail[] detailList
        {
            get
            {
                return this.detailListField;
            }
            set
            {
                this.detailListField = value;
            }
        }
		#endregion Model

	}
}

