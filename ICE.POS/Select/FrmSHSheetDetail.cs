/********************************************************
 * Description:POS机收货单详细页面
 * ******************************************************/
namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    //using ICE.POS.Msmk;
    using ICE.Utility;
    
    public partial class FrmSHSheetDetail : FrmBase
    {
        private string _itemNo;
        private object EditBackValue;
        private static DataTable dtOld=new DataTable();

        public FrmSHSheetDetail(string sheet_no)
        {
            this.components = null;
            this.dt = new DataTable("Temp");
            this._itemNo = string.Empty;
            this.InitializeComponent();
            this.SheetNO = sheet_no;
        }

        //public FrmSHSheetDetail(string branch, string itemNo)
        //{
        //    this.components = null;
        //    this.dt = new DataTable("Temp");
        //    this.flagBody = "--出自Pos前台";
        //    this._itemNo = string.Empty;
        //    this.InitializeComponent();
        //    this.txtdBranchNO.Text = branch;
        //    this.ItemNo = itemNo;
        //    this.SheetNO = "";
        //}

        public FrmSHSheetDetail(object dataRow)
        {
            this.components = null;
            this.dt = new DataTable("Temp");
            this._itemNo = string.Empty;
            this.InitializeComponent();
            DataRowView dv = dataRow as DataRowView;
            DataRow dr = dv.Row;
            this.SheetNO = ExtendUtility.Instance.ParseToString(dr["sheet_no"]);
            this.txtSheetNO.Text = ExtendUtility.Instance.ParseToString(dr["sheet_no"]);
            this.txtBranchNO.Text = ExtendUtility.Instance.ParseToString(dr["branch_no"])+"["+ExtendUtility.Instance.ParseToString(dr["branch_name"])+"]";
            this.txtdBranchNO.Text = ExtendUtility.Instance.ParseToString(dr["d_branch_no"]) + "[" + ExtendUtility.Instance.ParseToString(dr["d_branch_name"])+"]";
            this.txtCzPersion.Text = ExtendUtility.Instance.ParseToString(dr["oper_name"]);
            this.txtCzTime.Text = ExtendUtility.Instance.ParseToString(dr["oper_date"]);
        }

        //public FrmSHSheetDetail(string branch_no, DataTable _table)
        //{
        //    this.components = null;
        //    this.dt = new DataTable("Temp");
        //    this.flagBody = "--出自Pos前台";
        //    this._itemNo = string.Empty;
        //    this.InitializeComponent();
        //    this.txtdBranchNO.Text = branch_no;
        //    //this.ItemNo = itemNo;
        //    this.currentStock = _table;
        //    this.SheetNO = "";
        //}

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认收货,确认收货后不能再次修改?", Gattr.AppTitle, MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】进行收货确认！", LogEnum.SysLog);
                SaveData(true);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //base.Close();
            this.Close();
        }

        private void SaveData(bool istj)
        {
            if (this.btnApprove.Enabled)
            {
                if (this.txtdBranchNO.Text.Trim().Length == 0)
                {
                    MessageBox.Show("发货仓库无法获取", Gattr.AppTitle);
                    return;
                }
                if (this.txtdBranchNO.Text.Trim() == Gattr.BranchNo)//发货门店和申请门店相同
                {
                    MessageBox.Show("发货仓库和申请门店不能相同", Gattr.AppTitle);
                    return;
                }
                if (this.dgvItemList.Rows.Count <= 0)
                {
                    MessageBox.Show("没有收货商品信息", Gattr.AppTitle);
                    return;
                }
                DataTable detail = new DataTable();
                string[] dcs = new string[] { "item_no", "item_name", "large_qty", "real_qty", "other1", "item_price","purchase_spec"};
                foreach (string str in dcs)
                {
                    DataColumn dc = new DataColumn(str);
                    if (str != "real_qty" && str != "large_qty" && str != "item_price")
                    {
                        dc.DataType = Type.GetType("System.String");
                    }
                    else
                    {
                        dc.DataType = Type.GetType("System.Decimal");
                    }
                    if (!detail.Columns.Contains(str))
                    {
                        detail.Columns.Add(dc);
                    }
                }
                List<t_pm_sheet_detail> _details = new List<t_pm_sheet_detail>();
                bool isok111 = true;
                foreach (DataGridViewRow dgvr in this.dgvItemList.Rows)
                {
                    t_pm_sheet_detail _detail = new t_pm_sheet_detail();
                    //if (!string.IsNullOrEmpty(SheetNO))
                    //{
                    //    _detail.sheet_no = SheetNO;
                    //}
                    _detail.item_no = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_no"].Value);
                    //t_cur_saleflow sale = Gattr.Bll.GetItemInfo(_detail.item_no);
                    _detail.real_qty = ExtendUtility.Instance.ParseToDecimal(dgvr.Cells["real_qty"].Value);
                    _detail.large_qty = ExtendUtility.Instance.ParseToDecimal(dgvr.Cells["real_qty"].Value) / ExtendUtility.Instance.ParseToDecimal(dgvr.Cells["purchase_spec"].Value);
                    //数量规范性检测
                    if (_detail.real_qty.HasValue)
                    {
                        if (ExtendUtility.Instance.ParseToDecimal(_detail.real_qty.Value) <= 0)
                        {
                            MessageBox.Show("货号[" + _detail.item_no + "]的商品数量必须大于0", Gattr.AppTitle);
                            isok111 = false;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("货号[" + _detail.item_no + "]的商品数量不能为空", Gattr.AppTitle);
                        isok111 = false;
                        break;
                    }
                    _detail.orgi_price = ExtendUtility.Instance.ParseToDecimal(dgvr.Cells["item_price"].Value);
                    _detail.sub_amt = ExtendUtility.Instance.ParseToDecimal(dgvr.Cells["item_price"].Value) * ExtendUtility.Instance.ParseToDecimal(dgvr.Cells["real_qty"].Value);
                    _detail.other1 = ExtendUtility.Instance.ParseToString(dgvr.Cells["memo"].Value);
                    _details.Add(_detail);
                }
                if (isok111 == false)
                {
                    return;
                }
                bool isok = true;
                //string sheet_no = ExtendUtility.Instance.ParseToString(this.SheetNO);
                t_pm_sheet_master _master = new t_pm_sheet_master();
                //_master.trans_no = "+";
                //_master.trans_no = "YH";
                _master.d_branch_no = Gattr.BranchNo;
                _master.branch_no = txtdBranchNO.Text.Remove(txtdBranchNO.Text.IndexOf("[")).Trim();
                _master.voucher_no = SheetNO;
                _master.oper_id = Gattr.OperId;
                _master.order_man = Gattr.OperId;
                _master.confirm_man = Gattr.OperId;
                _master.sheet_amt = 0;
                _master.oper_date = ExtendUtility.Instance.ParseToDateTime(DateTime.Now.ToString("s"));            
                //if (istj)
                //{
                //    _master.order_status = "0";//等待提交
                //}
                //else
                //{
                //    _master.order_status = "t";
                //}
                List<t_pm_sheet_master> _masters = new List<t_pm_sheet_master>();
                _masters.Add(_master);
                string master1 = JsonUtility.Instance.ObjectToJson<t_pm_sheet_master>(_masters);
                string detail1 = JsonUtility.Instance.ObjectToJson<t_pm_sheet_detail>(_details);
                Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                _dic.Add("master", master1);
                _dic.Add("detail", detail1);
                string errorMessage = string.Empty;
                string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Addmisheet", _dic, ref isok, ref errorMessage);
                if (isok)
                {
                    if (result != "-10" && result != "-20")
                    {
                        if (result == "1")
                        {
                            MessageBox.Show("保存成功", Gattr.AppTitle);
                            this.btnApprove.Enabled = false;
                            this.dgvItemList.Enabled = false;
                            this.lblApprove.Visible = true;
                        }
                        else
                        {
                            string error = "";
                            switch (result)
                            {
                                case "-1":
                                    error = "数据库连接失败";
                                    break;
                                case "-2":
                                    error = "操作异常";
                                    break;
                                case "-5":
                                    error = "查找单据失败";
                                    break;
                                case "0":
                                    error = "保存失败";
                                    break;
                                default:
                                    error = "未知错误，保存失败";
                                    break;
                            }
                            MessageBox.Show(error, Gattr.AppTitle);
                        }
                    }
                    else
                    {
                        if (result == "-10")
                        {
                            //参数错误
                            MessageBox.Show("参数错误", Gattr.AppTitle);
                        }
                        else
                        {
                            //禁止操作
                            MessageBox.Show("禁止操作", Gattr.AppTitle);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, Gattr.AppTitle);
                }
            }
             
        }

        private void dgvItemList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.EditBackValue = this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }
        private void FrmDmSheetDetail_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    if (this.btnApprove.Enabled)
                    {
                        this.btnApprove_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    this.btnExit_Click(sender, e);
                    break;
            }
        }
        private void FrmDmSheetDetail_Load(object sender, EventArgs e)
        {
            this.Text = Gattr.AppTitle;
            this.SetItemView();
            if (string.IsNullOrEmpty(this.SheetNO))
            {
                MessageBox.Show("单号传递失败", Gattr.AppTitle);
            }
            else
            {
                this.dgvItemList.AutoGenerateColumns = false;
                this.dt = new DataTable("SheetDetail");
                try
                {
                    bool isok = true;
                    string errorMessage = string.Empty;
                    Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                    _dic.Add("sheet_no", SheetNO);
                    string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Getmodetail", _dic, ref isok, ref errorMessage);
                    if (isok)
                    {
                        if (result != "-10" && result != "-20" && result != "-2" && result != "-1")
                        {
                            dtOld = JsonUtility.Instance.JsonToDataTable(result);
                            dt = JsonUtility.Instance.JsonToDataTable(result);
                            this.dgvItemList.DataSource = this.dt;
                        }
                        else
                        {
                            if (result == "-10")
                            {
                                //参数错误
                                MessageBox.Show("参数错误", Gattr.AppTitle);
                            }
                            else if (result == "-20")
                            {
                                //禁止操作
                                MessageBox.Show("禁止操作", Gattr.AppTitle);
                            }
                            else if (result == "-2")
                            {
                                //操作异常
                                MessageBox.Show("操作异常", Gattr.AppTitle);
                            }
                            else
                            {
                                //数据库连接失败
                                MessageBox.Show("数据库连接失败", Gattr.AppTitle);
                            }
                        }
                        //this.dgvItemList.DataSource = this.dt;
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, Gattr.AppTitle);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            //this.dateValid.Enabled = false;
            }
        }
        private void SetItemView()
        {
            if (this.dt.Columns.Count <= 0)
            {
                this.dt.Columns.Add("item_no");
                this.dt.Columns.Add("item_subno");
                this.dt.Columns.Add("item_name");
                this.dt.Columns.Add("purchase_spec");
                //this.dt.Columns.Add("large_qty_1");
                this.dt.Columns.Add("real_qty");
                this.dt.Columns.Add("memo");
                this.dt.Columns.Add("item_price");
                //this.dt.Columns.Add("purchase_spec");
            }
            this.dgvItemList.DataSource = this.dt;
            this.dgvItemList.Columns["item_no"].HeaderText = "货号";
            this.dgvItemList.Columns["item_no"].Width = 130;
            this.dgvItemList.Columns["item_no"].ReadOnly = true;
            DataGridViewCellStyle style = null;
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };
            this.dgvItemList.Columns["item_no"].DefaultCellStyle = style;
            this.dgvItemList.Columns["item_subno"].HeaderText = "自编码";
            this.dgvItemList.Columns["item_subno"].Width = 130;
            this.dgvItemList.Columns["item_subno"].ReadOnly = true;
            this.dgvItemList.Columns["item_subno"].Visible = false;
            this.dgvItemList.Columns["item_subno"].DefaultCellStyle = style;
            this.dgvItemList.Columns["item_name"].HeaderText = "商品名称";
            this.dgvItemList.Columns["item_name"].Width = 180;
            this.dgvItemList.Columns["item_name"].ReadOnly = true;
            this.dgvItemList.Columns["item_name"].DefaultCellStyle = style;
            this.dgvItemList.Columns["purchase_spec"].HeaderText = "规格";
            this.dgvItemList.Columns["purchase_spec"].Width = 80;
            this.dgvItemList.Columns["purchase_spec"].ReadOnly = true;
            this.dgvItemList.Columns["purchase_spec"].DefaultCellStyle = style;
            //this.dgvItemList.Columns["large_qty_1"].HeaderText = "箱数";
            //this.dgvItemList.Columns["large_qty_1"].Width = 80;
            //this.dgvItemList.Columns["large_qty_1"].ReadOnly = true;
            //this.dgvItemList.Columns["large_qty_1"].DefaultCellStyle = style;
            DataGridViewCellStyle style2 = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Format = "N2"
            };
            this.dgvItemList.Columns["real_qty"].HeaderText = "数量";
            this.dgvItemList.Columns["real_qty"].Width = 80;
            this.dgvItemList.Columns["real_qty"].DefaultCellStyle = style2;
            //this.dgvItemList.Columns["real_qty"].ReadOnly = true;
            this.dgvItemList.Columns["memo"].HeaderText = "备注";
            this.dgvItemList.Columns["memo"].Width = 130;
            this.dgvItemList.Columns["memo"].DefaultCellStyle = style;
            this.dgvItemList.Columns["item_price"].HeaderText = "单价";
            this.dgvItemList.Columns["item_price"].Visible = false;
        }
        public bool IsApprove { get; set; }
        public string ItemNo { get; set; }
        public string SheetNO { get; set; }

        private void dgvItemList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvItemList.Columns[e.ColumnIndex].Name == "real_qty")
            {
                decimal newRowValue = ExtendUtility.Instance.ParseToDecimal(this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (newRowValue > ExtendUtility.Instance.ParseToDecimal(dtOld.Rows[e.RowIndex]["real_qty"]))
                {
                    MessageBox.Show("商品数量不能大于原始仓库发货数量", Gattr.AppTitle);
                    this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.EditBackValue;
                }
            }
        }
    }
}
