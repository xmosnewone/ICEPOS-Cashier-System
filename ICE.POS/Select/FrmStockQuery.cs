namespace ICE.POS
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.Utility;

    public partial class FrmStockQuery : FrmBase
    {
        private FrmDmSheetDetail _detail = null;
        public delegate void DelegateSetStock(DataTable table);
        public event DelegateSetStock SetStock;
        public FrmStockQuery(bool isThisStock, FrmDmSheetDetail _detail, string branch_no)
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
            if (isThisStock)
            {
                this.txtBranchNO.Text = Gattr.BranchNo;
                this.txtBranchNO.Enabled = false;
                this.btnSelectBranch.Enabled = false;
                this.txtKey.Focus();
                this.btnSelectBranch.Enabled = false;
            }
            else
            {
                this.txtBranchNO.Text = Gattr.BranchNo;
                this.txtBranchNO.Enabled = true;
                this.txtKey.Focus();
                this.btnDm.Visible = true;
            }
            if (_detail != null)
            {
                this._detail = _detail;
            }
            this.txtBranchNO.Text = branch_no;
        }

        private void btnDm_Click(object sender, EventArgs e)
        {
            if (this.dgItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择商品", Gattr.AppTitle);
            }
            else
            {
                if (Gattr.BranchNo == this.txtBranchNO.Text.Trim())
                {
                    MessageBox.Show("发货门店和收货门店不能相同", Gattr.AppTitle);
                }
                else
                {
                    DataTable table = new DataTable();
                    table.Columns.Add(new DataColumn("item_no"));
                    table.Columns.Add(new DataColumn("stock_qty"));
                    table.Columns.Add(new DataColumn("item_name"));
                    table.Columns.Add(new DataColumn("item_size"));
                    table.Columns.Add(new DataColumn("item_clsname"));
                    table.Columns.Add(new DataColumn("code_name"));
                    table.Columns.Add(new DataColumn("unit_no"));
                    foreach (DataGridViewRow dgvr in this.dgItem.SelectedRows)
                    {
                        DataRow dr = table.NewRow();
                        dr["item_no"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_no"].Value);
                        dr["item_name"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_name"].Value);
                        dr["item_size"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_size"].Value);
                        dr["item_clsname"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_clsname"].Value);
                        dr["code_name"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["code_name"].Value);
                        dr["unit_no"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["unit_no"].Value);
                        dr["stock_qty"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["stock_qty"].Value);
                        table.Rows.Add(dr);
                    }
                    string branch_no = this.txtBranchNO.Text.Trim();
                    if (_detail == null)
                    {
                        FrmDmSheetDetail detail = new FrmDmSheetDetail(branch_no, table);
                        detail.ShowDialog();
                    }
                    else
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        if (SetStock != null)
                        {
                            SetStock(table);
                        }
                    }
                }
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (this.txtBranchNO.Enabled)
            {
                if (string.IsNullOrEmpty(this.txtKey.Text.Trim()) && string.IsNullOrEmpty(this.txtBranchNO.Text.Trim()))
                {
                    MessageBox.Show("请输入查询条件！", Gattr.AppTitle);
                    return;
                }
            }
            else if (string.IsNullOrEmpty(this.txtBranchNO.Text.Trim()))
            {
                MessageBox.Show("请输入分店编号！", Gattr.AppTitle);
                return;
            }
            if (this.txtKey.Text.Equals(this.TxtTitle))
            {
                this.txtKey.Text = string.Empty;
                this.txtKey.ForeColor = Color.Black;
            }
            
            this.DisplayDt();
            LoggerHelper.Log("MsmkLogger", "【"+Gattr.OperId + "】进行库存查询！", LogEnum.SysLog);
            
        }

        private void btnSelectBranch_Click(object sender, EventArgs e)
        {
            using (FrmBranchSelect select = new FrmBranchSelect("0,2"))
            {
                select.ShowDialog();
                if (!string.IsNullOrEmpty(select.BranchNO))
                {
                    this.txtBranchNO.Text = select.BranchNO;
                }
            }
        }

        private void dgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtKey.Focus();
        }

        private void dgItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemNo = SIString.TryStr(this.dgItem.Rows[this.dgItem.CurrentRow.Index].Cells["item_no"].Value.ToString().Trim());
            string str2 = SIString.TryStr(this.dgItem.Rows[this.dgItem.CurrentRow.Index].Cells["branch_no"].Value.ToString().Trim());
            if (!string.IsNullOrEmpty(str2))
            {
                if (Gattr.BranchNo == this.txtBranchNO.Text.Trim())
                {
                    MessageBox.Show("发货门店和收货门店不能相同", Gattr.AppTitle);
                }
                else
                {
                    DataTable table = new DataTable();
                    table.Columns.Add(new DataColumn("item_no"));
                    table.Columns.Add(new DataColumn("stock_qty"));
                    table.Columns.Add(new DataColumn("item_name"));
                    table.Columns.Add(new DataColumn("item_size"));
                    table.Columns.Add(new DataColumn("item_clsname"));
                    table.Columns.Add(new DataColumn("code_name"));
                    table.Columns.Add(new DataColumn("unit_no"));
                    foreach (DataGridViewRow dgvr in this.dgItem.SelectedRows)
                    {
                        DataRow dr = table.NewRow();
                        dr["item_no"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_no"].Value);
                        dr["item_name"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_name"].Value);
                        dr["item_size"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_size"].Value);
                        dr["item_clsname"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["item_clsname"].Value);
                        dr["code_name"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["code_name"].Value);
                        dr["unit_no"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["unit_no"].Value);
                        dr["stock_qty"] = ExtendUtility.Instance.ParseToString(dgvr.Cells["stock_qty"].Value);
                        table.Rows.Add(dr);
                    }
                    string branch_no = this.txtBranchNO.Text.Trim();
                    if (_detail == null)
                    {
                        FrmDmSheetDetail detail = new FrmDmSheetDetail(branch_no, table);
                        detail.ShowDialog();
                    }
                    else
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        if (SetStock != null)
                        {
                            SetStock(table);
                        }
                    }
                }
                //using (FrmDmSheetDetail detail = new FrmDmSheetDetail(str2, itemNo))
                //{
                //    detail.ShowDialog();
                //}
            }
        }
        private void DisplayDt()
        {
            try
            {
                System.Collections.Generic.Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                _dic.Add("branch_no", this.txtBranchNO.Text.Trim());
                _dic.Add("item_clsno", this.textBox1.Text.Trim());
                _dic.Add("item_brand", this.textBox2.Text.Trim());
                _dic.Add("item_supcust", this.textBox3.Text.Trim());
                _dic.Add("item_no", txtKey.Text.Trim());
                String result = CommonProvider.InvokePOSAPI("Getstock", _dic);
                if (result != "404")
                {
                    if (result != "-10" && result != "-20")
                    {
                        DataTable table = JsonUtility.Instance.JsonToDataTable(result);
                        if (table != null)
                        {
                            this.dgItem.DataSource = table;
                            this.dgItem.EditMode = DataGridViewEditMode.EditOnEnter;
                            this.dgItem.Columns["item_no"].HeaderCell.Value = "货号";
                            this.dgItem.Columns["item_no"].MinimumWidth = 130;
                            this.dgItem.Columns["item_no"].Width = 130;
                            this.dgItem.Columns["item_name"].HeaderCell.Value = "商品名称";
                            this.dgItem.Columns["item_name"].MinimumWidth = 200;
                            this.dgItem.Columns["item_name"].Width = 200;
                            this.dgItem.Columns["item_size"].HeaderCell.Value = "规格";
                            this.dgItem.Columns["item_size"].MinimumWidth = 80;
                            this.dgItem.Columns["item_size"].Width = 80;
                            this.dgItem.Columns["branch_no"].HeaderCell.Value = "仓库";
                            this.dgItem.Columns["branch_no"].MinimumWidth = 100;
                            this.dgItem.Columns["branch_no"].Width = 100;
                            this.dgItem.Columns["stock_qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            this.dgItem.Columns["stock_qty"].DefaultCellStyle.Format = Gattr.PosSaleNumPoint;
                            this.dgItem.Columns["stock_qty"].HeaderCell.Value = "实时库存";
                            this.dgItem.Columns["stock_qty"].MinimumWidth = 90;
                            this.dgItem.Columns["stock_qty"].Width = 90;
                            this.dgItem.Columns["item_clsname"].HeaderCell.Value = "类别";
                            this.dgItem.Columns["item_clsname"].MinimumWidth = 80;
                            this.dgItem.Columns["item_clsname"].Width = 80;
                            this.dgItem.Columns["code_name"].HeaderCell.Value = "品牌";
                            this.dgItem.Columns["code_name"].MinimumWidth = 70;
                            this.dgItem.Columns["code_name"].Width = 70;
                            this.dgItem.Columns["unit_no"].HeaderCell.Value = "单位";
                            this.dgItem.Columns["unit_no"].MinimumWidth = 70;
                            this.dgItem.Columns["unit_no"].Width = 70;
                            this.dgItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            this.dgItem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            this.dgItem.ReadOnly = true;
                            foreach (DataGridViewColumn column in this.dgItem.Columns)
                            {
                                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                            }
                        }
                    }
                    else
                    {
                        if (result == "-10")
                        {
                            MessageBox.Show("参数错误", Gattr.AppTitle);
                        }
                        else// if (result == "-20")
                        {
                            MessageBox.Show("权限不足", Gattr.AppTitle);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("服务器返回异常", Gattr.AppTitle);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS->FrmStockQuery->DisplayDt-->Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        private void FrmStockQuery_Activated(object sender, EventArgs e)
        {
            this.txtBranchNO.ImeMode = ImeMode.Close;
            this.txtKey.ImeMode = ImeMode.Close;
            this.txtKey.Focus();
        }

        private void FrmStockQuery_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3://门店选择
                    this.btnSelectBranch_Click(sender, e);
                    break;
                case Keys.F4://商品分类选择
                    buttonEx1_Click(buttonEx1, null);
                    break;
                case Keys.F5://商品品牌选择
                    buttonEx1_Click(buttonEx2, null);
                    break;
                case Keys.F6://供应商选择
                    buttonEx1_Click(buttonEx3, null);
                    break;
                case Keys.F7://获取焦点
                    this.txtKey.Focus();
                    break;
                case Keys.F8:
                    this.btnDm_Click(sender, e);
                    break;
                case Keys.Return:
                    this.btnok.PerformClick();
                    break;
            }
        }

        private void FrmStockQuery_KeyUp(object sender, KeyEventArgs e)
        {
            this.txtKey.Text = this.txtKey.Text.Replace(this.TxtTitle, "");
            this.txtKey.ForeColor = Color.Black;
            if (e.KeyCode == Keys.F3)
            {
                this.txtBranchNO.Focus();
            }
            else if (e.KeyCode == Keys.F4)
            {
                this.txtKey.Focus();
            }
            else if (((e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down)) && !this.dgItem.Focused)
            {
                this.dgItem.Focus();
            }
        }

        private void FrmStockQuery_Load(object sender, EventArgs e)
        {
        }
        private void txtKey_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtKey.Text))
            {
                this.txtKey.Text = this.TxtTitle;
                this.txtKey.ForeColor = Color.Silver;
            }
        }

        private void txtKey_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtKey.Text.Equals(this.TxtTitle))
            {
                this.txtKey.Text = string.Empty;
                this.txtKey.ForeColor = Color.Black;
            }
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            ButtonEx btnEx = sender as ButtonEx;
            if (btnEx != null)
            {
                FrmComSel _frmSel = null;
                switch (btnEx.Tag.ToString())
                {
                    case "0":
                        _frmSel = new FrmComSel("商品分类选择", "商品分类", "0");
                        break;
                    case "1":
                        _frmSel = new FrmComSel("商品品牌选择", "商品品牌", "1");
                        break;
                    case "2":
                        _frmSel = new FrmComSel("供应商选择", "供应商", "2");
                        break;
                }
                string code = string.Empty;
                string name = string.Empty;
                _frmSel.SetComSelEvent += (c, n) =>
                {
                    code = c;
                    name = n;
                };
                if (_frmSel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (btnEx.Tag.ToString())
                    {
                        case "0":
                            this.textBox1.Text = code;
                            break;
                        case "1":
                            this.textBox2.Text = code;
                            break;
                        case "2":
                            this.textBox3.Text = code;
                            break;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
