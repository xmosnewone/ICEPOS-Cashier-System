/********************************************************
 * Description:POS机要货单详细页面
 * ******************************************************/
namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    
    public partial class FrmDmSheetDetail : FrmBase
    {
        private string _itemNo;
        private object EditBackValue;
        private string flagBody;

        private DataTable currentStock;
        public FrmDmSheetDetail()
        {
            this.components = null;
            this.dt = new DataTable("Temp");
            this.flagBody = "--出自Pos前台";
            this._itemNo = string.Empty;
            this.InitializeComponent();
        }

        public FrmDmSheetDetail(string sheet_no)
        {
            this.components = null;
            this.dt = new DataTable("Temp");
            this.flagBody = "--出自Pos前台";
            this._itemNo = string.Empty;
            this.InitializeComponent();
            this.SheetNO = sheet_no;
        }

        public FrmDmSheetDetail(string branch, string itemNo)
        {
            this.components = null;
            this.dt = new DataTable("Temp");
            this.flagBody = "--出自Pos前台";
            this._itemNo = string.Empty;
            this.InitializeComponent();
            this.txtdBranchNO.Text = branch;
            this.ItemNo = itemNo;
            this.SheetNO = "";
        }

        public FrmDmSheetDetail(object dataRow)
        {
            this.components = null;
            this.dt = new DataTable("Temp");
            this.flagBody = "--出自Pos前台";
            this._itemNo = string.Empty;
            this.InitializeComponent();
            DataRowView dv = dataRow as DataRowView;
            DataRow dr = dv.Row;
            this.SheetNO = ExtendUtility.Instance.ParseToString(dr["sheet_no"]);
            this.txtSheetNO.Text = ExtendUtility.Instance.ParseToString(dr["sheet_no"]);
            this.cmbType.SelectedIndex = 0;
            this.txtBranchNO.Text = ExtendUtility.Instance.ParseToString(dr["d_branch_no"]);
            this.txtdBranchNO.Text = ExtendUtility.Instance.ParseToString(dr["branch_no"]);
            this.txtSqPersion.Text = ExtendUtility.Instance.ParseToString(dr["oper_id"]) + "[" + ExtendUtility.Instance.ParseToString(dr["oper_name"]) + "]";
            this.txtRemark.Text = ExtendUtility.Instance.ParseToString(dr["memo"]);
            this.IsApprove = ExtendUtility.Instance.ParseToString(dr["approve_flag"]).Equals("1");
            string order_status = ExtendUtility.Instance.ParseToString(dr["order_status"]);
            if (order_status != "t")
            {
                this.btnSave.Enabled = false;
                this.btnDel.Enabled = false;
                this.btnDelAll.Enabled = false;
                this.btnSelectBranch.Enabled = false;
                this.btnApprove.Enabled = false;
                this.btnSelectItem.Enabled = false;
                //this.dgvItemList.Enabled = false;
            }
        }
        
        
        
        
        
        public FrmDmSheetDetail(string branch_no, DataTable _table)
        {
            this.components = null;
            this.dt = new DataTable("Temp");
            this.flagBody = "--出自Pos前台";
            this._itemNo = string.Empty;
            this.InitializeComponent();
            this.txtdBranchNO.Text = branch_no;
            //this.ItemNo = itemNo;
            this.currentStock = _table;
            this.SheetNO = "";
        }
        public void AddItem(string ItemNO)
        {
            List<t_item_info> itemInfoByOne = Gattr.Bll.GetItemInfoNew(ItemNO);
            if (itemInfoByOne.Count > 0)
            {
                t_item_info _info = itemInfoByOne[0];
                DataRow row = this.dt.NewRow();
                row["item_no"] = _info.item_no;
                row["item_subno"] = _info.item_subno;
                row["item_name"] = _info.item_name;
                row["unit_no"] = _info.unit_no;
                row["real_qty"] = 1;
                row["other1"] = "";
                this.dt.Rows.Add(row);

            }
            this.dgvItemList.DataSource = this.dt;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定提交审核当前单据,提交审核后不能再次修改?", Gattr.AppTitle, MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                SaveData(true);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void SaveData(bool istj)
        {
            string cashierNo = Gattr.OperId;
            if (this.cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("请选择单据类型！", Gattr.AppTitle);
                return;
            }
            if (this.cmbType.SelectedIndex == 0 || this.cmbType.SelectedIndex == -1)
            {
                if (this.txtdBranchNO.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入发货门店", Gattr.AppTitle);
                    return;
                }
                if (this.txtdBranchNO.Text.Trim() == Gattr.BranchNo)//发货门店和申请门店相同
                {
                    MessageBox.Show("发货门店和申请门店不能相同", Gattr.AppTitle);
                    return;
                }
                if (this.dgvItemList.Rows.Count <= 0)
                {
                    MessageBox.Show("没有要货商品信息", Gattr.AppTitle);
                    return;
                }
                DataTable detail = new DataTable();
                string[] dcs = new string[] { "sheet_no", "item_no", "real_qty", "other1" };
                foreach (string str in dcs)
                {
                    DataColumn dc = new DataColumn(str);
                    if (str != "real_qty")
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
                //decimal _sumAmt = 0M;
                List<t_pm_sheet_detail> _details = new List<t_pm_sheet_detail>();
                bool isok111 = true;
                foreach (DataGridViewRow dgvr in this.dgvItemList.Rows)
                {
                    t_pm_sheet_detail _detail = new t_pm_sheet_detail();
                    if (!string.IsNullOrEmpty(SheetNO))
                    {
                        _detail.sheet_no = SheetNO;
                    }
                    _detail.item_no = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_no"].Value);
                    t_cur_saleflow sale = Gattr.Bll.GetItemInfo(_detail.item_no);
                    _detail.real_qty = ExtendUtility.Instance.ParseToDecimal(dgvr.Cells["real_qty"].Value);
                    if (istj)
                    {
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
                        //if (this.dgvItemList.Rows[e.RowIndex].Cells["stock_qty"].Visible == true)
                        //{
                        //    decimal stock_qty = ExtendUtility.Instance.ParseToDecimal(
                        //        this.dgvItemList.Rows[e.RowIndex].Cells["stock_qty"].Value);
                        //    if (result > stock_qty)
                        //    {
                        //        MessageBox.Show("要货数量不能大于发货门店库存", Gattr.AppTitle);
                        //  isok111 = false;
                        //        this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.EditBackValue;
                        //    }
                        //}
                    }
                    _detail.other1 = ExtendUtility.Instance.ParseToString(dgvr.Cells["other1"].Value);
                    _details.Add(_detail);
                }
                if (isok111 == false)
                {
                    return;
                }
                bool isok = true;
                string sheet_no = ExtendUtility.Instance.ParseToString(this.SheetNO);
                string memo = this.txtRemark.Text.Contains(this.flagBody) ? this.txtRemark.Text : (this.txtRemark.Text + this.flagBody);
                t_pm_sheet_master _master = new t_pm_sheet_master();
                //_master.db_no = "+";
                _master.sheet_no = SheetNO;
                _master.trans_no = "YH";
                _master.d_branch_no = Gattr.BranchNo;
                _master.branch_no = txtdBranchNO.Text.Trim();
                _master.oper_id = Gattr.OperId;
                _master.valid_date = ExtendUtility.Instance.ParseToDateTime(ExtendUtility.Instance.ParseToDateTime(dateValid.Text.Trim()).ToString(ICE.Common.GobalStaticString.DATE_FORMAT));
                _master.memo = memo;
                if (istj)
                {
                    _master.order_status = "0";//等待提交
                }
                else
                {
                    _master.order_status = "t";//临时状态,提交审核后转为0，t则管理后台不显示
                }
                List<t_pm_sheet_master> _masters = new List<t_pm_sheet_master>();
                _masters.Add(_master);
                string master1 = JsonUtility.Instance.ObjectToJson<t_pm_sheet_master>(_masters);
                string detail1 = JsonUtility.Instance.ObjectToJson<t_pm_sheet_detail>(_details);
                Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                _dic.Add("master", master1);
                _dic.Add("detail", detail1);
                if (string.IsNullOrEmpty(this.SheetNO))//新增
                {
                    _dic.Add("add", "add");
                }
                else
                {
                    _dic.Add("add", "edit");
                    _dic.Add("sheet_no", SheetNO);
                }
                string errorMessage = string.Empty;
                string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Addpsheet", _dic, ref isok, ref errorMessage);
                if (isok)
                {
                    if (result != "-10" && result != "-20")
                    {
                        if (result != "-1" && result != "0" && result != "-2"&&result!="404")
                        {
                            if (string.IsNullOrEmpty(this.SheetNO))//新增
                            {
                                this.SheetNO = result;
                                this.txtSheetNO.Text = result;
                            }
                            MessageBox.Show("保存成功", Gattr.AppTitle);
                            if (istj)
                            {
                                this.btnSave.Enabled = false;
                                this.btnDel.Enabled = false;
                                this.btnDelAll.Enabled = false;
                                this.btnSelectBranch.Enabled = false;
                                this.btnApprove.Enabled = false;
                                this.btnSelectItem.Enabled = false;
                                this.dgvItemList.Enabled = false;
                            }
                        }
                        else
                        {
                            string error = "";
                            switch (result)
                            {
                                case "-1":
                                    error = "记录不存在";
                                    break;
                                case "-2":
                                    error = "保存异常";
                                    break;
                                case "404":
                                    error = "提交出错";
                                    break;
                                default:
                                    error = "保存失败";
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData(false);
            
        }
        
        
        
        
        
        private void btnSelectBranch_Click(object sender, EventArgs e)
        {
            #region test1
            string type = "0,2";
            using (FrmBranchSelect select = new FrmBranchSelect(type.ToString()))
            {
                select.ShowDialog();
                if (!string.IsNullOrEmpty(select.BranchNO))
                {
                    bool isok = true;
                    string errorMessage=string.Empty;;
                    this.txtdBranchNO.Text = select.BranchNO;
                    Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                    _dic.Add("branch_no", Gattr.BranchNo);
                    _dic.Add("d_branch_no", this.txtdBranchNO.Text);
                    try {

                        string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Getcomstock", _dic, ref isok, ref errorMessage);
                        if (isok)
                        {
                            if (result != "-10" && result != "-20")
                            {
                                if (result != "-1" && result != "0" && result != "-2")
                                {

                                    DataTable table = JsonUtility.Instance.JsonToDataTable(result);
                                    if (table.Rows.Count==0) {
                                        this.dt.Clear();
                                        MessageBox.Show("没有找到库存低于存量指标的商品");
                                        return;
                                    }
                                    this.dt.Clear();
                                    foreach (DataRow dr in table.Rows)
                                    {
                                        DataRow dr1 = this.dt.NewRow();
                                        dr1["item_no"] = ExtendUtility.Instance.ParseToString(dr["item_no"]);
                                        dr1["item_subno"] = "";
                                        dr1["item_name"] = ExtendUtility.Instance.ParseToString(dr["item_name"]);
                                        //dr1["item_size"] = ExtendUtility.Instance.ParseToString(dr["item_size"]);
                                        dr1["unit_no"] = ExtendUtility.Instance.ParseToString(dr["unit_no"]);
                                        dr1["real_qty"] = 1;
                                        dr1["other1"] = "";
                                        dr1["stock"] = ExtendUtility.Instance.ParseToString(dr["item_stock"]);
                                        dr1["stock_qty"] = ExtendUtility.Instance.ParseToString(dr["d_stock_qty"]);
                                        this.dt.Rows.Add(dr1);
                                    }
                                }
                                else
                                {
                                    string error = "";
                                    switch (result)
                                    {
                                        case "-1":
                                            error = "记录不存在";
                                            break;
                                        case "-2":
                                            error = "保存异常";
                                            break;
                                        default:
                                            error = "保存失败";
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
                    catch (Exception error) {
                        Console.WriteLine(error.ToString());
                    }
                   
                    
                }
            }
            if (this.txtdBranchNO.Text.Trim() != "")
            {
                this.cmbType.SelectedIndex = 0;
                this.dateValid.Visible = this.cmbType.SelectedIndex == 0;
                this.lblValide.Visible = this.cmbType.SelectedIndex == 0;
            }
            #endregion
        }
        
        
        
        
        
        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtdBranchNO.Text))
            {
                MessageBox.Show("请输入发货门店", Gattr.AppTitle);
            }
            else if (this.txtBranchNO.Text.Equals(this.txtdBranchNO.Text))
            {
                MessageBox.Show("申请门店与发货门店不能相同", Gattr.AppTitle);
            }
            else
            {
                FrmStockQuery query = new FrmStockQuery(false, this, this.txtdBranchNO.Text);
                query.SetStock += (table) =>
                {
                    currentStock = table;
                };
                if (query.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.BindItem(currentStock);
                }
            }
        }
        
        
        
        
        
        private void buttonEx1_Click(object sender, EventArgs e)
        {
            if (!this.dgvItemList.ReadOnly)
            {
                if (this.dgvItemList.CurrentRow != null)
                {
                    string str = SIString.TryStr(this.dgvItemList.Rows[this.dgvItemList.CurrentRow.Index].Cells["item_no"].Value);
                    DataRow[] rowArray = this.dt.Select(string.Format(" item_no='{0}' ", str));
                    if (rowArray.Length > 0)
                    {
                        this.dt.Rows.Remove(rowArray[0]);
                        this.dgvItemList.DataSource = this.dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选中需要删除的商品，再进行操作！", Gattr.AppTitle);
            }
        }

        private void dgvItemList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.EditBackValue = this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvItemList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string s = this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (this.dgvItemList.Columns[e.ColumnIndex].Name == "real_qty")
            {
                decimal result = 0M;
                if (!decimal.TryParse(s, out result))
                {
                    this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.EditBackValue;
                }
                else if (result <= 0M)
                {
                    MessageBox.Show("数量必须大于 0 ", Gattr.AppTitle);
                    this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.EditBackValue;
                }
                else
                {
                    //if (this.dgvItemList.Rows[e.RowIndex].Cells["stock_qty"].Visible == true)
                    //{
                    //    decimal stock_qty = ExtendUtility.Instance.ParseToDecimal(
                    //        this.dgvItemList.Rows[e.RowIndex].Cells["stock_qty"].Value);
                    //    if (result > stock_qty)
                    //    {
                    //        MessageBox.Show("要货数量不能大于发货门店库存", Gattr.AppTitle);
                    //        this.dgvItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.EditBackValue;
                    //    }
                    //}
                }
            }
        }

        private void dgvItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.dgvItemList.ReadOnly)
            {
                if ((e.KeyCode == Keys.Delete) && (this.dgvItemList.CurrentRow != null))
                {
                    string str = SIString.TryStr(this.dgvItemList.Rows[this.dgvItemList.CurrentRow.Index].Cells["item_no"].Value);
                    DataRow[] rowArray = this.dt.Select(string.Format(" item_no='{0}' ", str));
                    if (rowArray.Length > 0)
                    {
                        this.dt.Rows.Remove(rowArray[0]);
                        this.dgvItemList.DataSource = this.dt;
                    }
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                this.buttonEx1_Click(sender, e);
            }
        }
        private void FrmDmSheetDetail_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    if (this.btnSelectBranch.Enabled)
                    {
                        this.btnSelectBranch_Click(sender, e);
                    }
                    break;

                case Keys.F2:
                    if (this.btnSelectBranch.Enabled)
                    {
                        this.btnSave_Click(sender, e);
                    }
                    break;

                case Keys.F3:
                    if (this.btnApprove.Enabled)
                    {
                        this.btnApprove_Click(sender, e);
                    }
                    break;

                case Keys.F4:
                    if (this.btnSelectBranch.Enabled)
                    {
                        this.btnSelectItem_Click(sender, e);
                    }
                    break;

                case Keys.Escape:
                    this.btnExit_Click(sender, e);
                    break;
            }
        }

        private void BindItem(DataTable table)
        {
            DataTable tableStock = Gattr.Bll.GetItemStock();
            if (tableStock != null && tableStock.Rows.Count > 0)
            {
                DataTable tableLast = new DataTable();
                foreach (DataColumn dc in tableStock.Columns)
                {
                    if (!tableLast.Columns.Contains(dc.ColumnName))
                    {
                        DataColumn dcc = new DataColumn();
                        dcc.ColumnName = dc.ColumnName;
                        dcc.DataType = Type.GetType("System.String");
                        tableLast.Columns.Add(dcc);
                    }
                }
                tableLast.Columns.Add(new DataColumn("stock_qty"));
                tableLast.Columns.Add(new DataColumn("real_qty"));
                tableLast.Columns.Add(new DataColumn("other1"));
                foreach (DataRow dr in table.Rows)
                {
                    DataRow dr1 = tableLast.NewRow();
                    string item_no = ExtendUtility.Instance.ParseToString(dr["item_no"]);
                    dr1["item_no"] = item_no;
                    dr1["item_name"] = ExtendUtility.Instance.ParseToString(dr["item_name"]);
                    dr1["item_size"] = ExtendUtility.Instance.ParseToString(dr["item_size"]);
                    dr1["unit_no"] = ExtendUtility.Instance.ParseToString(dr["unit_no"]);
                    dr1["stock_qty"] = ExtendUtility.Instance.ParseToString(dr["stock_qty"]);
                    dr1["item_clsname"] = ExtendUtility.Instance.ParseToString(dr["item_clsname"]);
                    dr1["code_name"] = ExtendUtility.Instance.ParseToString(dr["code_name"]);
                    DataRow[] drs = tableStock.Select("  item_no='" + item_no + "'");
                    if (drs.Length > 0)
                    {
                        dr1["stock"] = ExtendUtility.Instance.ParseToString(drs[0]["stock"]);
                        dr1["item_subno"] = ExtendUtility.Instance.ParseToString(drs[0]["item_subno"]);
                    }
                    else
                    {
                        dr1["stock"] = 0;
                        dr1["item_subno"] = "";
                    }
                    dr1["real_qty"] = "";
                    dr1["other1"] = "";
                    tableLast.Rows.Add(dr1);
                }
                this.dgvItemList.AutoGenerateColumns = false;
                DataTable table1 = null;
                if (this.dgvItemList.DataSource != null)
                {
                    table1 = this.dgvItemList.DataSource as DataTable;
                    if (table1 != null && table1.Rows.Count > 0)
                    {
                        DataTable table2 = MergeData(table1, tableLast);
                        ProcessDataTable(table2);
                        this.dgvItemList.DataSource = dt;
                    }
                    else
                    {
                        ProcessDataTable(tableLast);
                        this.dgvItemList.DataSource = dt;
                    }
                }
                else
                {
                    ProcessDataTable(tableLast);
                    this.dgvItemList.DataSource = dt;
                }
                this.dgvItemList.Columns["stock"].Visible = true;
                this.dgvItemList.Columns["stock_qty"].Visible = true;
            }
        }
        void ProcessDataTable(DataTable table)
        {
            if (this.dt != null)
            {
                this.dt.Columns.Clear();
                this.dt.Rows.Clear();
            }
            foreach (DataColumn dc in table.Columns)
            {
                if (!dt.Columns.Contains(dc.ColumnName))
                {
                    DataColumn dcc = new DataColumn(dc.ColumnName);
                    dcc.DataType = Type.GetType("System.String");
                    dt.Columns.Add(dcc);
                }
            }
            foreach (DataRow dr in table.Rows)
            {
                DataRow dr1 = this.dt.NewRow();
                foreach (DataColumn dc in table.Columns)
                {
                    dr1[dc.ColumnName] = dr[dc.ColumnName];
                }
                this.dt.Rows.Add(dr1);
            }
        }
        
        
        
        
        
        
        private DataTable MergeData(DataTable table1, DataTable table2)
        {
            DataTable table = new DataTable();
            try
            {
                foreach (DataColumn dc in table1.Columns)
                {
                    if (!table.Columns.Contains(dc.ColumnName))
                    {
                        DataColumn dcc = new DataColumn(dc.ColumnName);
                        dcc.DataType = Type.GetType("System.String");
                        table.Columns.Add(dcc);
                    }
                }
                foreach (DataRow dr in table1.Rows)
                {
                    DataRow dr1 = table.NewRow();
                    foreach (DataColumn dc in table1.Columns)
                    {
                        dr1[dc.ColumnName] = dr[dc.ColumnName];
                    }
                    table.Rows.Add(dr1);  // 将DataRow添加到DataTable中
                }
                foreach (DataRow dr in table2.Rows)
                {
                    string item_no = ExtendUtility.Instance.ParseToString(dr["item_no"]);
                    DataRow[] dritem = table.Select("item_no='" + item_no + "'");
                    if (dritem != null && dritem.Length > 0)
                    {
                        DataRow dr3 = dritem[0];
                        dr3["real_qty"] = ExtendUtility.Instance.ParseToString(
                            (ExtendUtility.Instance.ParseToDecimal(dr3["real_qty"]) +
                            ExtendUtility.Instance.ParseToDecimal(dr["real_qty"])));
                        table.AcceptChanges();
                    }
                    else
                    {
                        DataRow dr2 = table.NewRow();
                        foreach (DataColumn dc in table.Columns)
                        {
                            if (table2.Columns.Contains(dc.ColumnName))
                            {
                                dr2[dc.ColumnName] = dr[dc.ColumnName];
                            }
                            else
                            {
                                dr2[dc.ColumnName] = string.Empty;
                            }
                        }
                        table.Rows.Add(dr2);  // 将DataRow添加到DataTable中
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log(Gattr.LoggerName, "ICE.POS->FrmDmSheetDetail-->Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            }
            return table;
        }
        private void FrmDmSheetDetail_Load(object sender, EventArgs e)
        {
            this.Text = Gattr.AppTitle;
            this.SetItemView();
            if (string.IsNullOrEmpty(this.SheetNO))
            {
                this.txtBranchNO.Text = "[" + Gattr.BranchNo + "]" + Gattr.BranchNo;
                this.txtSqPersion.Text = "[" + Gattr.OperId + "]" + Gattr.OperFullName;
                this.dateValid.Value = DateTime.Now.AddMonths(1);
                this.cmbType.Enabled = true;
                if (this.txtdBranchNO.Text.Trim() != "")
                {
                    this.cmbType.SelectedIndex = 0;
                    this.dateValid.Visible = this.cmbType.SelectedIndex == 0;
                    this.lblValide.Visible = this.cmbType.SelectedIndex == 0;
                }
                if (!string.IsNullOrEmpty(this.ItemNo))
                {
                    this.AddItem(this.ItemNo);
                }
                if (currentStock != null)
                {
                    this.BindItem(this.currentStock);
                }
            }
            else
            {
                if (this.IsApprove)
                {
                    this.btnSave.Enabled = false;
                }
                this.dgvItemList.AutoGenerateColumns = false;
                if (this.SheetNO.Contains("YH"))
                {
                    this.dt = new DataTable("SheetDetail");
                    try
                    {
                        bool isok = true;
                        string errorMessage = string.Empty;
                        Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                        _dic.Add("sheet_no", SheetNO);
                        _dic.Add("trans_no", "YH");
                        string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Getsdetail", _dic, ref isok, ref errorMessage);
                        if (isok)
                        {
                            if (result != "-10" && result != "-20")
                            {
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
                                else
                                {
                                    //禁止操作
                                    MessageBox.Show("禁止操作", Gattr.AppTitle);
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
                }
                this.cmbType.Enabled = false;
                this.txtdBranchNO.ReadOnly = true;
                this.dateValid.Enabled = false;
                this.btnSelectBranch.Enabled = false;
                if (this.IsApprove)
                {
                    this.btnSelectItem.Enabled = false;
                    this.dgvItemList.ReadOnly = false;
                    this.txtRemark.ReadOnly = false;
                    this.btnApprove.Enabled = false;
                    this.lblApprove.Visible = true;
                    this.btnDel.Enabled = false;
                    this.btnDelAll.Enabled = false;
                }
            }
        }
        private void SetItemView()
        {
            if (this.dt.Columns.Count <= 0)
            {
                this.dt.Columns.Add("item_no");
                this.dt.Columns.Add("item_subno");
                this.dt.Columns.Add("item_name");
                this.dt.Columns.Add("unit_no");
                this.dt.Columns.Add("real_qty");
                this.dt.Columns.Add("other1");
                this.dt.Columns.Add("stock");
                this.dt.Columns.Add("stock_qty");
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
            this.dgvItemList.Columns["item_name"].Width = 160;
            this.dgvItemList.Columns["item_name"].ReadOnly = true;
            this.dgvItemList.Columns["item_name"].DefaultCellStyle = style;
            this.dgvItemList.Columns["unit_no"].HeaderText = "单位";
            this.dgvItemList.Columns["unit_no"].Width = 80;
            this.dgvItemList.Columns["unit_no"].ReadOnly = true;
            this.dgvItemList.Columns["unit_no"].DefaultCellStyle = style;
            DataGridViewCellStyle style2 = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Format = "N2"
            };
            this.dgvItemList.Columns["stock"].HeaderText = "当前门店库存";
            this.dgvItemList.Columns["stock"].Width = 90;
            this.dgvItemList.Columns["stock"].DefaultCellStyle = style;
            this.dgvItemList.Columns["stock_qty"].HeaderText = "发货门店库存";
            this.dgvItemList.Columns["stock_qty"].Width = 90;
            this.dgvItemList.Columns["stock_qty"].DefaultCellStyle = style;
            //this.dgvItemList.Columns["stock"].Visible = false;
            //this.dgvItemList.Columns["stock_qty"].Visible = false;
            this.dgvItemList.Columns["real_qty"].HeaderText = "数量";
            this.dgvItemList.Columns["real_qty"].Width = 80;
            this.dgvItemList.Columns["real_qty"].DefaultCellStyle = style2;
            this.dgvItemList.Columns["other1"].HeaderText = "备注";
            this.dgvItemList.Columns["other1"].Width = 90;
            this.dgvItemList.Columns["other1"].DefaultCellStyle = style;
        }
        public bool IsApprove { get; set; }
        public string ItemNo { get; set; }
        public string SheetNO { get; set; }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            this.dt.Clear();
        }
    }
}
