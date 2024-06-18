namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;
    using ICE.POS.Common;
    
    
    
    public partial class FrmSaleDetails :FrmBase
    {
        #region 窗体声名

        //支付类型为RMB和CHA的总金额
        decimal moneyT = 0;
        decimal moneyCHA = 0;
        
        
        
        
        public delegate void DelegateSetSaleList(List<t_cur_saleflow> _saleFlowList,decimal _moneyCHA);
        
        
        
        public event DelegateSetSaleList EventSetSaleList;
        #endregion
        #region 窗体构造
        public FrmSaleDetails(List<t_cur_saleflow> saleList)
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
            this.ActiveControl = dgvSaleFlow;
            LoadData(saleList);
            InitControls();
        }
        #endregion
        #region 窗体事件逻辑
        
        
        
        
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            SetData();
        }
        
        
        
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
        
        
        
        
        private void dgvSaleFlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if ((this.dgvSaleFlow != null) && (this.dgvSaleFlow.Rows.Count > 0))
                {
                    this.dgvSaleFlow.CurrentCell = this.dgvSaleFlow.CurrentRow.Cells[7];
                    if (this.dgvSaleFlow.CurrentRow.Cells[7].Value.ToString().Equals("B"))
                    {
                        this.dgvSaleFlow.CurrentRow.Cells[7].Value = "A";
                    }
                    else
                    {
                        this.dgvSaleFlow.CurrentRow.Cells[7].Value = "B";
                    }
                    this.dgvSaleFlow.Refresh();
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                this.btnOk.Focus();
                SetData();
            }
            else if ((e.KeyCode == Keys.F5) && this.btnAll.Visible)
            {
                this.btnAll_Click(null, null);
            }
        }
        
        
        
        
        
        private void btnAll_Click(object sender, EventArgs e)
        {
            if ((this.dgvSaleFlow != null) && (this.dgvSaleFlow.Rows.Count > 0))
            {
                List<t_cur_saleflow> dataSource = this.bindingSource1.DataSource as List<t_cur_saleflow>;
                int itemIndex = 0;
                string flow_no = "";
                moneyCHA = 0;
                moneyT = 0;
                foreach (t_cur_saleflow _saleflow in dataSource)
                {
                    _saleflow.sale_way = "B";
                    this.bindingSource1.ResetItem(itemIndex);
                    this.dgvSaleFlow.CurrentCell = this.dgvSaleFlow.Rows[itemIndex].Cells[3];
                    this.dgvSaleFlow.Focus();
                    flow_no = _saleflow.flow_no;
                    itemIndex++;
                }
                //含有余额支付的退货操作
                //先退余额再退现金
                List<t_cur_payflow> payFlowList = Gattr.Bll.GetPayFlowInfoByFlowNo(flow_no);
                foreach (t_cur_payflow payItem in payFlowList)
                {
                    if (payItem.pay_way == "CHA" || payItem.pay_way == "RMB")
                    {
                        //计算余额支付的总金额
                        moneyT += payItem.pay_amount;
                        if (payItem.pay_way == "CHA")
                            moneyCHA += payItem.pay_amount;
                    }
                }
            }
            SetData();
            LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】进行全部退货！", LogEnum.SysLog);
        }
        
        
        
        
        
        private void dgvSaleFlow_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (((this.dgvSaleFlow != null) && (this.dgvSaleFlow.Rows.Count > 0)) && (this.dgvSaleFlow.Columns[e.ColumnIndex].Name == "sale_qnty"))
            {
                MessageBox.Show("请输入正确的退货商品数量", Gattr.AppTitle);
                this.dgvSaleFlow.CurrentRow.Cells[e.ColumnIndex].Value = "1.00";
                return;
            }
        }
        #endregion
        #region 界面私有方法
        
        
        
        void InitControls()
        {
            #region gridview控件列初始化
            DataGridViewCellStyle style = null;

            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                HeaderText = "行号",
                Name = "flow_id",
                DataPropertyName = "flow_id",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = 35,
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
                HeaderText = "退货数量",
                Name = "sale_qnty",
                DataPropertyName = "sale_qnty",
                ReadOnly = false,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = (int)((this.dgvSaleFlow.Width - column.Width) * 0.10M),
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
                //Width = ((((((this.dgvSaleFlow.Width - column.Width) - column2.Width) - column3.Width) - column4.Width) - column5.Width) - column6.Width) - 2,
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

            DataGridViewCheckBoxColumn column8 = new DataGridViewCheckBoxColumn
            {
                HeaderText = "退货",
                Name = "sale_way",
                DataPropertyName = "sale_way",
                TrueValue = "B",
                FalseValue = "A",
                ReadOnly = false,
                Width = 45,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False
            };
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = this.BackColor;
            style.ForeColor = this.ForeColor;
            column7.DefaultCellStyle = style;

            this.dgvSaleFlow.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle style2 = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(0, 4, 0, 0)
            };
            this.dgvSaleFlow.ColumnHeadersDefaultCellStyle = style2;
            this.dgvSaleFlow.BorderStyle = BorderStyle.Fixed3D;
            this.dgvSaleFlow.RowHeadersVisible = false;
            this.dgvSaleFlow.Columns.AddRange(new DataGridViewColumn[] { column, column2, column3, column4, column5, column6, column7, column8 });
            this.dgvSaleFlow.AutoGenerateColumns = false;
            this.dgvSaleFlow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleFlow.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dgvSaleFlow.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgvSaleFlow.BackgroundColor = this.BackColor;
            this.dgvSaleFlow.ScrollBars = ScrollBars.Vertical;
            this.dgvSaleFlow.DataSource = this.bindingSource1;
            this.dgvSaleFlow.Focus();
            #endregion
        }
        
        
        
        void LoadData(List<t_cur_saleflow> saleList)
        {
            int index = 0;
            string flow_no="";
            moneyCHA = 0;
            moneyT = 0;
            foreach (t_cur_saleflow sale in saleList)
            {
                sale.source_qnty = sale.sale_qnty;
                sale.flow_id = index + 1;
                index++;
                flow_no = sale.flow_no;
            }
            List<t_cur_payflow> payFlowList = Gattr.Bll.GetPayFlowInfoByFlowNo(flow_no);
            foreach (t_cur_payflow payItem in payFlowList)
            {
                if (payItem.pay_way == "CHA" || payItem.pay_way == "RMB")
                {
                    moneyT += payItem.pay_amount;
                    if (payItem.pay_way == "CHA")
                        moneyCHA += payItem.pay_amount;
                }
            }
            this.bindingSource1.DataSource = saleList;
        }
        
        
        
        void SetData()
        {
            List<t_cur_saleflow> resultList = this.bindingSource1.DataSource as List<t_cur_saleflow>;
            if ((this.dgvSaleFlow != null) && (this.dgvSaleFlow.Rows.Count > 0))
            {
                int num = 0;
                decimal allMoney = 0;
                foreach (t_cur_saleflow _saleflow in resultList)
                {
                    if (_saleflow.sale_qnty > _saleflow.source_qnty)
                    {
                        MessageBox.Show("第" + (num + 1) + "行退货商品数量不能大于总商品数量", Gattr.AppTitle);
                        this.dgvSaleFlow.CurrentCell = this.dgvSaleFlow.Rows[num].Cells[3];
                        this.dgvSaleFlow.Focus();
                        return;
                    }
                    if (_saleflow.sale_qnty <= 0M)
                    {
                        MessageBox.Show("第" + (num + 1) + "行退货商品数量不能小于等于零", Gattr.AppTitle);
                        this.dgvSaleFlow.CurrentCell = this.dgvSaleFlow.Rows[num].Cells[3];
                        this.dgvSaleFlow.Focus();
                        return;
                    }
                    allMoney += _saleflow.unit_price * _saleflow.sale_qnty;
                    num++;
                }
                if (allMoney > moneyT)
                {
                    MessageBox.Show("总退货金额：" + allMoney + "元，人民币和余额支付金额：" + moneyT + "元，总退货金额大于人民币和余额支付的总金额无法进行退货！", Gattr.AppTitle);
                    return;
                }
            }
            List<t_cur_saleflow> saleList = new List<t_cur_saleflow>();
            foreach (t_cur_saleflow sale in resultList)
            {
                if (sale.sale_way == "B")
                {
                    saleList.Add(sale);
                }
            }
            //TODO:
            if (EventSetSaleList != null)
            {
                EventSetSaleList(saleList,moneyCHA);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion

        private void FrmSaleDetails_Load(object sender, EventArgs e)
        {
            if ((this.dgvSaleFlow != null) && (this.dgvSaleFlow.Rows.Count > 0))
            {
                this.dgvSaleFlow.CurrentCell = this.dgvSaleFlow.Rows[0].Cells[3];
                this.dgvSaleFlow.Focus();
            }
        }


    }
}
