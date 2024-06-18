namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using ICE.POS.Model;
    public partial class FrmItemQuery : FrmBase
    {
        private List<t_item_info> _itemList;
        private bool IsClose;
        public string itemF5;
        private string TxtTitle;
        FrmDmSheetDetail frmDmSheetDetail = null;
        public FrmItemQuery()
        {
            this._itemList = new List<t_item_info>();
            this.itemF5 = string.Empty;
            this.IsClose = true;
            this.TxtTitle = "可输入货号、自编码、商品名、类别、品牌关键字进行查询";
            this.components = null;
            this.InitializeComponent();
            this.txtSearchKey.Text = this.TxtTitle;
            this.txtSearchKey.ForeColor = Color.Silver;
            this.Text = Gattr.AppTitle;
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public FrmItemQuery(FrmDmSheetDetail frm)
        {
            this._itemList = new List<t_item_info>();
            this.itemF5 = string.Empty;
            this.IsClose = true;
            this.TxtTitle = "可输入货号、自编码、商品名、类别、品牌关键字进行查询";
            this.components = null;
            this.IsClose = false;
            this.frmDmSheetDetail = frm;
            this.InitializeComponent();
            this.txtSearchKey.Text = this.TxtTitle;
            this.txtSearchKey.ForeColor = Color.Silver;
            this.Text = Gattr.AppTitle;
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public FrmItemQuery(string itemNo)
        {
            this._itemList = new List<t_item_info>();
            this.itemF5 = string.Empty;
            this.IsClose = true;
            this.TxtTitle = "可输入货号、自编码、商品名、类别、品牌关键字进行查询";
            this.components = null;
            this.InitializeComponent();
            this.txtSearchKey.Text = itemNo;
            this.Text = Gattr.AppTitle;
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }


        public FrmItemQuery(string itemNo, List<t_cur_saleflow> _saleInfoList)
        {
            this._itemList = new List<t_item_info>();
            this.itemF5 = string.Empty;
            this.IsClose = true;
            this.TxtTitle = "可输入货号、自编码、商品名、类别、品牌关键字进行查询";
            this.components = null;
            this.InitializeComponent();
            this.txtSearchKey.Text = itemNo;
            this.Text = Gattr.AppTitle;
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Init(List<t_cur_saleflow> saleInfos)
        {
            List<t_item_info> items = new List<t_item_info>();
            foreach (t_cur_saleflow saleInfo in saleInfos)
            {
                t_item_info item = new t_item_info();
                item.item_no = saleInfo.item_no;
                item.item_subno = saleInfo.item_subno;
                item.item_name = saleInfo.item_name;
                item.sale_price = saleInfo.sale_price;
                item.vip_price = saleInfo.sale_price;
                item.base_price = saleInfo.price;
                item.item_subname = saleInfo.item_subname;
                item.item_clsno = saleInfo.item_clsno;
                item.unit_no = saleInfo.unit_no;
                item.product_area = saleInfo.product_area;
                item.item_rem = saleInfo.item_rem;
                item.main_supcust = saleInfo.main_supcust;
                item.item_size = saleInfo.item_size;
                items.Add(item);
            }
            this.dgItem.DataSource = items;
            this.SetCloumns();

        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string itemNO = this.txtSearchKey.Text.Trim();
            if (itemNO.Equals(this.TxtTitle))
            {
                this.txtSearchKey.Text = string.Empty;
                itemNO = string.Empty;
            }
            this.SearchData(itemNO);
            if (this.dgItem.SelectedRows.Count > 0)
            {
                this.dgItem.Focus();
            }
        }

        private void dgItem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                string str = Convert.ToString(this.dgItem.Rows[e.RowIndex].Cells["item_no"].Value);
                if (!string.IsNullOrEmpty(str))
                {

                    if (this.frmDmSheetDetail == null)
                    {
                        this.itemF5 = str;
                        base.Close();
                    }
                    else
                    {
                        this.frmDmSheetDetail.AddItem(str);
                        base.Close();
                    }

                }
            }
        }

        private void dgItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }

        private void dgItem_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Right:
                case Keys.Down:
                    break;

                case Keys.F5:
                case Keys.Return:
                    if (this.dgItem.CurrentRow.Index >= 0)
                    {
                        if (this.dgItem.Rows[this.dgItem.CurrentRow.Index].Cells["item_no"].Value != null)
                        {
                            this.itemF5 = this.dgItem.Rows[this.dgItem.CurrentRow.Index].Cells["item_no"].Value.ToString().ToUpper();
                        }
                        else
                        {
                            this.itemF5 = string.Empty;
                        }
                    }
                    else
                    {
                        this.itemF5 = string.Empty;
                    }
                    if (this.IsClose)
                    {
                        base.Close();
                    }
                    else
                    {
                        this.frmDmSheetDetail.AddItem(this.itemF5);
                    }
                    break;

                case Keys.Escape:
                    base.Close();
                    break;

                default:
                    this.txtSearchKey.Focus();
                    break;
            }
        }
        private void FrmItemQuery_Activated(object sender, EventArgs e)
        {
            this.txtSearchKey.Focus();
            this.txtSearchKey.Text = this.TxtTitle;
            this.txtSearchKey.ForeColor = Color.Silver;
        }

        private void FrmItemQuery_Load(object sender, EventArgs e)
        {
            if (this.txtSearchKey.Text.Trim() != this.TxtTitle)
            {
                this.SearchData(this.txtSearchKey.Text.Trim());
            }
        }
        private void SearchData(string ItemNO)
        {
            this._itemList.Clear();
            this._itemList.Add(new t_item_info());
            if (!string.IsNullOrEmpty(ItemNO) && ItemNO!=this.TxtTitle)
            {
                List<t_item_info> list_t = null;
                list_t = Gattr.Bll.GetItemInfoNew(ItemNO);
                if (list_t.Count >0)
                {
                    this.dgItem.DataSource = list_t;
                }
                else
                {
                    MessageBox.Show("您所查询的信息不存在！",Gattr.AppTitle);
                    this.dgItem.DataSource = list_t;
                }
            }
            else
            {
                this.dgItem.DataSource = Gattr.Bll.GetItemInfoNew("");
            }

            this.SetCloumns();
        }

        private void SetCloumns()
        {
            for (int i = 0; i < this.dgItem.ColumnCount; i++)
            {
                this.dgItem.Columns[i].Visible = false;
            }
            this.dgItem.Columns["item_no"].Visible = true;
            this.dgItem.Columns["item_subno"].Visible = true;
            this.dgItem.Columns["item_rem"].Visible = true;
            this.dgItem.Columns["item_name"].Visible = true;
            this.dgItem.Columns["sale_price"].Visible = true;
            this.dgItem.Columns["vip_price"].Visible = true;
            this.dgItem.Columns["base_price"].Visible = false;
            this.dgItem.Columns["item_subname"].Visible = true;
            this.dgItem.Columns["item_clsno"].Visible = true;
            this.dgItem.Columns["item_size"].Visible = true;
            this.dgItem.Columns["product_area"].Visible = true;
            this.dgItem.Columns["main_supcust"].Visible = true;
            this.dgItem.Columns["unit_no"].Visible = true;
            this.dgItem.Columns["item_no"].HeaderCell.Value = "商品编码";
            this.dgItem.Columns["item_no"].Width = 150;
            this.dgItem.Columns["item_no"].DisplayIndex = 1;
            this.dgItem.Columns["item_name"].HeaderCell.Value = "商品名称";
            this.dgItem.Columns["item_name"].Width = 150;
            this.dgItem.Columns["item_name"].DisplayIndex = 2;
            this.dgItem.Columns["sale_price"].HeaderCell.Value = "零售价";
            this.dgItem.Columns["sale_price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgItem.Columns["sale_price"].DisplayIndex = 3;
            this.dgItem.Columns["vip_price"].HeaderCell.Value = "会员价";
            this.dgItem.Columns["vip_price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgItem.Columns["vip_price"].DisplayIndex = 4;
            this.dgItem.Columns["item_rem"].HeaderCell.Value = "助记码";
            this.dgItem.Columns["item_rem"].DisplayIndex = 5;
            this.dgItem.Columns["item_subno"].HeaderCell.Value = "自编码";
            this.dgItem.Columns["item_subno"].Width = 100;
            this.dgItem.Columns["item_subno"].DisplayIndex = 6;
            this.dgItem.Columns["base_price"].HeaderCell.Value = "批发价";
            this.dgItem.Columns["base_price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgItem.Columns["base_price"].DisplayIndex = 7;
            this.dgItem.Columns["item_subname"].HeaderCell.Value = "商品简称";
            this.dgItem.Columns["item_subname"].Width = 150;
            this.dgItem.Columns["item_subname"].DisplayIndex = 8;
            this.dgItem.Columns["item_clsno"].HeaderCell.Value = "类别";
            this.dgItem.Columns["item_clsno"].DisplayIndex = 9;
            this.dgItem.Columns["item_size"].HeaderCell.Value = "规格";
            this.dgItem.Columns["product_area"].HeaderCell.Value = "原产地";
            this.dgItem.Columns["main_supcust"].HeaderCell.Value = "主供应商";
            this.dgItem.Columns["unit_no"].HeaderCell.Value = "单位";
            this.dgItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn column in this.dgItem.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            this.dgItem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            this.dgItem.Focus();
            this.txtSearchKey.Text = this.txtSearchKey.Text.Replace(this.TxtTitle, "");
            this.txtSearchKey.ForeColor = Color.Black;
            switch (e.KeyCode)
            {
                //case Keys.Up:
                //    if (this.dgItem.Rows.Count > 0)
                //    {
                //        if (this.dgItem.CurrentRow == null)
                //        {
                //            //this.dgItem.CurrentCell = this.dgItem[1, 1];
                //            this.dgItem.CurrentCell = this.dgItem.Rows[0].Cells["item_no"];
                //        }
                //        else if (this.dgItem.CurrentRow.Index != 0)
                //        {
                //            this.dgItem.CurrentCell = this.dgItem.Rows[this.dgItem.CurrentRow.Index - 1].Cells["item_no"];
                //            //this.dgItem.CurrentCell = this.dgItem[1, this.dgItem.CurrentRow.Index - 1];
                //            e.Handled = true;
                //        }
                //        return;
                //    }
                //    return;

                //case Keys.Down:
                //    if (this.dgItem.Rows.Count > 0)
                //    {
                //        if (this.dgItem.CurrentRow == null)
                //        {
                //            //this.dgItem.CurrentCell = this.dgItem[1, 1];
                //            this.dgItem.CurrentCell = this.dgItem.Rows[0].Cells["item_no"];
                //        }
                //        else if (this.dgItem.Rows.Count != (this.dgItem.CurrentRow.Index + 1))
                //        {
                //            this.dgItem.CurrentCell = this.dgItem.Rows[this.dgItem.CurrentRow.Index + 1].Cells["item_no"];
                //            //this.dgItem.CurrentCell = this.dgItem[1, this.dgItem.CurrentRow.Index + 1];
                //            e.Handled = true;
                //        }
                //        return;
                //    }
                //    return;

                case Keys.F5:
                    this.itemF5 = string.Empty;
                    if ((this.dgItem.SelectedRows.Count > 0) && (this.dgItem.SelectedRows[0] != null))
                    {
                        this.itemF5 = this.dgItem.SelectedRows[0].Cells["item_no"].Value.ToString().ToUpper();
                    }
                    if (this.IsClose)
                    {
                        base.Close();
                    }
                    else
                    {
                        this.frmDmSheetDetail.AddItem(this.itemF5);
                    }
                    return;

                case Keys.Return:
                    if ((e.KeyCode == Keys.Delete) && (this.dgItem.CurrentRow != null))
                    {
                        string str = SIString.TryStr(this.dgItem.Rows[this.dgItem.CurrentRow.Index].Cells["item_no"].Value);
                        if (!string.IsNullOrEmpty(str))
                        {
                            this.itemF5 = str;
                            base.Close();
                        }
                    }
                    else
                    {
                        this.btnSerch_Click(sender, e);
                    }
                    return;

                case Keys.Escape:
                    base.Close();
                    return;
            }
            this.txtSearchKey.Focus();
        }

        private void txtSearchKey_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtSearchKey.Text))
            {
                //this.txtSearchKey.Text = this.TxtTitle;
                this.txtSearchKey.ForeColor = Color.Silver;
            }
        }

        private void txtSearchKey_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtSearchKey.Text.Equals(this.TxtTitle))
            {
                this.txtSearchKey.Text = string.Empty;
                this.txtSearchKey.ForeColor = Color.Black;
            }
        }

    }
}
