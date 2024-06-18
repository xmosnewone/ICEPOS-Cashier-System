namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;
    public partial class FrmPendingOrder : FrmBase
    {
        private List<t_pending_order> _penOrd;
        
        
        
        private List<t_cur_saleflow> _listSaleFlows;
        
        
        
        private List<t_cur_payflow> _listPendingPayFlow;

        private string _vip_no;

        private string _pendingType;

        private string flowNo = "";

        
        
        
        private int _penOrdCount;

        public FrmPendingOrder()
        {
            InitializeComponent();
            try
            {
                this._penOrd = Gattr.Bll.GetPenOrdRows();
                this._penOrdCount = this._penOrd.Count;
                if (this._penOrdCount == 1)
                {
                    this.bindingPenOrd.DataSource = this._penOrd;
                    this.dgvPenOrd.DataSource = this.bindingPenOrd;
                    this.GetCurSaleFlow();
                }
            }
            catch
            {
            }
        }
        
        
        
        
        
        private void FrmPendingOrder_Load(object sender, EventArgs e)
        {
            this._penOrd = Gattr.Bll.GetPenOrdRows();
            this._penOrdCount = this._penOrd.Count;

            this.SetGridViewColumns();
            //绑定挂单主数据
            this.bindingPenOrd.DataSource = this._penOrd;
            this.dgvPenOrd.DataSource = this.bindingPenOrd;

            this.GetCurSaleFlow();
            this.bindingSaleFlow.DataSource = this._listSaleFlows;
            this.dgvSaleFlow.DataSource = this.bindingSaleFlow;

        }

        private void GetCurSaleFlow()
        {

            if (_penOrdCount > 0)
            {
                try
                {
                    t_pending_order current = this.bindingPenOrd.Current as t_pending_order;

                    this.flowNo = current.flow_no;
                    this._vip_no = current.vip_no;
                    this._pendingType = current.pending_type;
                    this._listSaleFlows = Gattr.Bll.GetPenOrdSaleFlow(flowNo);
                    //获取挂起的支付信息列表
                    this._listPendingPayFlow = Gattr.Bll.GetPendingPayRow(flowNo);
                }
                catch
                {

                }
            }
        }
        
        
        
        
        
        private void dgvPenOrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.dgvPenOrd.RowCount; i++)
            {
                this.dgvPenOrd.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        
        
        
        
        
        private void dgvPenOrd_SelectionChanged(object sender, EventArgs e)
        {
            this.GetCurSaleFlow();
            this.bindingSaleFlow.DataSource = this._listSaleFlows;
            this.dgvSaleFlow.Refresh();
        }
        
        
        
        private void SetGridViewColumns()
        {
            DataGridViewCellStyle style = null;
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                HeaderText = "行号",
                Name = "flow_id",
                DataPropertyName = "flow_id",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = 40,
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor
            };
            column.DefaultCellStyle = style;
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn
            {
                HeaderText = "品称",
                Name = "item_name",
                DataPropertyName = "Item_name",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = (int)((this.dgvSaleFlow.Width - column.Width) * 0.28M),
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor
            };
            column2.DefaultCellStyle = style;
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn
            {
                HeaderText = "货号",
                Name = "item_no",
                DataPropertyName = "Item_no",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = (int)((this.dgvSaleFlow.Width - column.Width) * 0.18M),
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor
            };
            column3.DefaultCellStyle = style;
            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn
            {
                HeaderText = "数量",
                Name = "sale_qnty",
                DataPropertyName = "Sale_qnty",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = (int)((this.dgvSaleFlow.Width - column.Width) * 0.12M),
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor,
                Format = Gattr.PosSaleNumPoint
            };
            column4.DefaultCellStyle = style;
            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn
            {
                HeaderText = "原价",
                Name = "sale_price",
                DataPropertyName = "Sale_price",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = (int)((this.dgvSaleFlow.Width - column.Width) * 0.13M),
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor,
                Format = Gattr.PosSalePrcPoint
            };
            column5.DefaultCellStyle = style;
            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn
            {
                HeaderText = "售价",
                Name = "unit_price",
                DataPropertyName = "Unit_price",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = (int)((this.dgvSaleFlow.Width - column.Width) * 0.13M),
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor,
                Format = Gattr.PosSalePrcPoint
            };
            column6.DefaultCellStyle = style;
            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn
            {
                HeaderText = "小计",
                Name = "sale_money",
                DataPropertyName = "Sale_money",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = ((((((this.dgvSaleFlow.Width - column.Width) - column2.Width) - column3.Width) - column4.Width) - column5.Width) - column6.Width) - 2,
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor,
                Format = Gattr.PosSaleAmtPoint
            };
            column7.DefaultCellStyle = style;
            this.dgvSaleFlow.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle style2 = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 4, 0, 0)
            };
            this.dgvSaleFlow.ColumnHeadersDefaultCellStyle = style2;
            this.dgvSaleFlow.BorderStyle = BorderStyle.FixedSingle;
            this.dgvSaleFlow.RowHeadersVisible = false;
            this.dgvSaleFlow.Columns.AddRange(new DataGridViewColumn[] { column, column2, column3, column4, column5, column6, column7 });
            this.dgvSaleFlow.AutoGenerateColumns = false;
            this.dgvSaleFlow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleFlow.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dgvSaleFlow.BackgroundColor = this.BackColor;
            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn
            {
                HeaderText = "行号",
                Name = "id",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = 40,
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor
            };
            column8.DefaultCellStyle = style;
            DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn
            {
                HeaderText = "单据",
                Name = "flow_no",
                DataPropertyName = "Flow_no",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = this.dgvPenOrd.Width - column8.Width,
                Resizable = DataGridViewTriState.False
            };
            style = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor
            };
            column9.DefaultCellStyle = style;
            this.dgvPenOrd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvPenOrd.ColumnHeadersDefaultCellStyle = style2;
            this.dgvPenOrd.BorderStyle = BorderStyle.FixedSingle;
            this.dgvPenOrd.RowHeadersVisible = false;
            this.dgvPenOrd.Columns.AddRange(new DataGridViewColumn[] { column8, column9 });
            this.dgvPenOrd.AutoGenerateColumns = false;
            this.dgvPenOrd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenOrd.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dgvPenOrd.BackgroundColor = this.BackColor;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void dgvPenOrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                base.Close();
            }
            if (e.KeyCode == Keys.D)
            {
                this.btnDel.PerformClick();
            }
            if (e.KeyCode == Keys.O)
            {
                this.btnOk.PerformClick();
            }
        }
        public t_pending_order GetCurrentPenOrd()
        {
            t_pending_order _hungbill = new t_pending_order
            {
                flow_no = ""
            };
            if (this._penOrdCount <= 0)
            {
                return _hungbill;
            }
            return (this.bindingPenOrd.Current as t_pending_order);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((this._penOrdCount > 0) && ((MessageBox.Show("是否确定删除所选挂单信息？", "提示对话框", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) && this.DelPendingOrder()))
            {

                this.dgvPenOrd.Refresh();
                this.dgvSaleFlow.Refresh();
            }

        }
        
        
        
        
        public bool DelPendingOrder()
        {
            if (this._penOrdCount <= 0)
            {
                return false;
            }
            try
            {
                t_pending_order current = this.bindingPenOrd.Current as t_pending_order;
                this.flowNo = current.flow_no;
                Gattr.Bll.DelPenOrd(flowNo);
                Gattr.Bll.DelPendingPayRow(flowNo);
                this.flowNo = "";
            }
            catch
            {
            }
            this.bindingPenOrd.RemoveCurrent();
            
            this._penOrdCount = this.bindingPenOrd.Count;

            if (this._penOrdCount == 0)
            {
                if (this.bindingSaleFlow.Count > 0)
                {
                    this.bindingSaleFlow.Clear();
                }
                //this._listSaleFlows = new List<t_cur_saleflow>();
                //this.bindingPenOrd.DataSource = this._listSaleFlows;
                //this.dgvPenOrd.DataSource = this.bindingPenOrd;
            }
            return true;
        }

        
        
        
        public int PenOrdCount
        {
            get { return _penOrdCount; }
        }
        
        
        
        public List<t_cur_saleflow> ListSaleFlows
        {
            get { return _listSaleFlows; }
        }
        
        
        
        public List<t_cur_payflow> ListPendingPayFlow
        {
            get { return _listPendingPayFlow; }
        }
        
        
        
        public string Vip_No
        {
            get { return _vip_no; }
        }
        public string PendingType
        {
            get { return _pendingType; }
        }
        public string FlowNo
        {
            get { return flowNo; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this._penOrdCount = -1;
            base.Close();
        }

        private void dgvSaleFlow_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
