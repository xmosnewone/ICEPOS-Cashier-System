
namespace ICE.POS
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class _frmMain : Form
    {
        private int _iRightWidth;
        private int _iRightHeight;
        private int _iRowCount;//行显示数量
        private int _iCellCount;//列显示数量
        private int _iSum;//显示数量
        private int _iStarIndex;//查询数据开始位置
        DataTable dtItemInfo = new DataTable("ItemInfo"); //商品列表
        DataTable dtSaleFlow = new DataTable("dtSaleFlow");//查询全部指定数据
        bool _bColumnsHeader = false; //设置购买商品列表头

        public _frmMain()
        {

            InitializeComponent();
            _iRightWidth = this.flpRight.Width;
            _iRightHeight = this.flpRight.Height;
            _iRowCount = _iRightWidth / 80;//行显示数量
            _iCellCount = _iRightHeight / 80;//列显示数量
            _iSum = _iRowCount * _iCellCount - 2;//显示数量

            initItemInfo();

        }
        #region 购买列表向上滚动
        
        
        
        
        
        private void btnBuyListUp_Click(object sender, EventArgs e)
        {

            if (this.bindingSaleFlow.Count != 0)
            {
                int num = 8;
                if (num < 0)
                {
                    num = 8;
                }
                if (this.bindingSaleFlow.Count <= num)
                {
                    this.bindingSaleFlow.MoveFirst();
                }
                int num2 = this.bindingSaleFlow.Position - num;
                if (num2 > 0)
                {
                    this.bindingSaleFlow.Position = num2;
                }
                else
                {
                    this.bindingSaleFlow.MoveFirst();
                }
                this.dgvSaleFlow.Refresh();
            }
        }
        #endregion

        #region 购买列表向下滚动
        
        
        
        
        
        private void btnBuyListDown_Click(object sender, EventArgs e)
        {
            if (this.bindingSaleFlow.Count != 0)
            {
                int num = 8;
                if (num < 0)
                {
                    num = 8;
                }
                if (this.bindingSaleFlow.Count <= num)
                {
                    this.bindingSaleFlow.MoveLast();
                }
                int num2 = this.bindingSaleFlow.Position + num;
                if (this.bindingSaleFlow.Count > num2)
                {
                    this.bindingSaleFlow.Position = num2;
                }
                else
                {
                    this.bindingSaleFlow.MoveLast();
                }
                this.dgvSaleFlow.Refresh();
            }
        }
        #endregion

        #region 监听窗体热键
        
        
        
        
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            // 按快捷键
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:
                            MessageBox.Show("数量 *");
                            break;
                        case 101:
                            MessageBox.Show("删除 U");
                            break;
                        case 102:
                            MessageBox.Show("单价 W");
                            break;
                        case 103:
                            MessageBox.Show("折扣 O");
                            break;
                        case 104:
                            MessageBox.Show("挂单 P");
                            break;
                        case 105:
                            MessageBox.Show("会员 M");
                            break;
                        case 106:
                            MessageBox.Show("营业员 L");
                            break;
                        case 107:
                            MessageBox.Show("加号 +");
                            break;
                        case 108:

                            Close();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        #region 注册热键
        
        
        
        
        
        private void frmMain_Activated(object sender, EventArgs e)
        {
            //HotKey.RegisterHotKey(this.Handle, 100, 0, Keys.D8); //数量 *
            //HotKey.RegisterHotKey(this.Handle, 101, 0, Keys.U); //删除 U
            //HotKey.RegisterHotKey(this.Handle, 102, 0, Keys.W); //单价 W
            //HotKey.RegisterHotKey(this.Handle, 103, 0, Keys.O); //折扣 O
            //HotKey.RegisterHotKey(this.Handle, 104, 0, Keys.P); //挂单 P
            //HotKey.RegisterHotKey(this.Handle, 105, 0, Keys.M); //会员 M
            //HotKey.RegisterHotKey(this.Handle, 106, 0, Keys.L); //营业员 L
            //HotKey.RegisterHotKey(this.Handle, 107, 0, Keys.Add); //加号 +
            //HotKey.RegisterHotKey(this.Handle, 108, 0, Keys.Escape); //ESC
        }
        #endregion

        #region 撤销热键
        
        
        
        
        
        private void frmMain_Leave(object sender, EventArgs e)
        {
            //HotKey.UnregisterHotKey(this.Handle, 100); //数量 *
            //HotKey.UnregisterHotKey(this.Handle, 101); //删除 U
            //HotKey.UnregisterHotKey(this.Handle, 102); //单价 W
            //HotKey.UnregisterHotKey(this.Handle, 103); //折扣 O
            //HotKey.UnregisterHotKey(this.Handle, 104); //挂单 P
            //HotKey.UnregisterHotKey(this.Handle, 105); //会员 M
            //HotKey.UnregisterHotKey(this.Handle, 106); //营业员 L
            //HotKey.UnregisterHotKey(this.Handle, 107); //加号 +
            //HotKey.UnregisterHotKey(this.Handle, 108); //ESC
        }
        #endregion

        #region 商品向上翻页
        private void btnUpPage_Click(object sender, EventArgs e)
        {
            if (_iStarIndex > 0)
            {
                PosBll pb = new PosBll();
                this.flpRight.Controls.Clear();

                _iStarIndex = _iStarIndex - _iSum;

                //dtItemInfo = pb.GetItemPage(_iStarIndex, _iSum, true);
                SetItemInfo(dtItemInfo);
            }
        }
        #endregion

        #region 商品向下翻页
        private void btnDownPage_Click(object sender, EventArgs e)
        {
            PosBll pb = new PosBll();
            this.flpRight.Controls.Clear(); //清空控件
            //dtItemInfo = pb.GetItemPage(_iStarIndex, _iSum, true);//查询全部指定数据

            //DataTable dtTemp = pb.GetItemPage(0, _iRowCount, false);//查询全部数据

            //if (_iStarIndex < dtTemp.Rows.Count)
            //{

            //    SetItemInfo(dtItemInfo);
            //    _iStarIndex = _iStarIndex + _iSum;
            //}
            //else
            //{
            //    SetItemInfo(dtItemInfo);
            //}
        }
        #endregion

        #region 设置右侧商品细项按钮
        
        
        
        
        private void SetItemInfo(DataTable itemInfo)
        {

            for (int i = 0; i < itemInfo.Rows.Count; i++)
            {
                Button btnTmp = new Button();
                btnTmp.Name = dtItemInfo.Rows[i]["item_no"].ToString();
                btnTmp.Size = new System.Drawing.Size(80, 80);
                btnTmp.TabIndex = 6;
                btnTmp.Text = "*" + dtItemInfo.Rows[i]["item_no"] + "*\r\n" + dtItemInfo.Rows[i]["item_subname"];
                btnTmp.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                btnTmp.UseVisualStyleBackColor = true;
                btnTmp.Click += new EventHandler(btnItem_Click);
                this.flpRight.Controls.Add(btnTmp);
            }
            //if (_iStarIndex  this._iSum)
            //{
                Button btnListUp = new Button();
                btnListUp.Name = "btnListUp";
                btnListUp.Size = new System.Drawing.Size(80, 80);
                btnListUp.TabIndex = 6;
                btnListUp.Text = "<";
                btnListUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnListUp.UseVisualStyleBackColor = true;
                btnListUp.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                btnListUp.Click += new EventHandler(btnUpPage_Click);

                Button btnListDown = new Button();
                btnListDown.Name = "btnListDown";
                btnListDown.Size = new System.Drawing.Size(80, 80);
                btnListDown.TabIndex = 6;
                btnListDown.Text = ">";
                btnListDown.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                btnListDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnListDown.UseVisualStyleBackColor = true;
                btnListDown.Click += new EventHandler(btnDownPage_Click);

                this.flpRight.Controls.Add(btnListUp);
                this.flpRight.Controls.Add(btnListDown);
            //}
        }
        #endregion

        #region 初始化右侧商品细项按钮
        
        
        
        private void initItemInfo()
        {
            PosBll pb = new PosBll();
            //dtItemInfo = pb.GetItemPage(0, _iSum, true);

            _iStarIndex = dtItemInfo.Rows.Count;


            SetItemInfo(dtItemInfo);
        }

        #endregion

        #region 单击商品事件

        
        
        
        
        
        private void btnItem_Click(object sender, EventArgs e)
        {
            Button btnItem = (Button)sender;
            this.addSaleItem(btnItem.Name.Trim());
        }

        #endregion

        #region 添加购买商品事件
        
        
        
        
        private void addSaleItem(string item_no)
        {
            //初始化选择商品列表
            PosBll pb = new PosBll();
            //DataTable dtItemDetails = pb.GetItemDetails(item_no);//查询全部指定数据
            DataTable dtItemDetails = null;//pb.GetItemDetails(item_no);//查询全部指定数据
            //初始化选择商品列表
            DataColumn dc = null;
            if (!_bColumnsHeader)
            {
                dc = dtSaleFlow.Columns.Add("NO", Type.GetType("System.Int32"));
                dc.AutoIncrement = true;//自动增加
                dc.AutoIncrementSeed = 1;//起始为1
                dc.AutoIncrementStep = 1;//步长为1
                dc.AllowDBNull = false;//
                dc = dtSaleFlow.Columns.Add("Product", Type.GetType("System.String"));
                dc = dtSaleFlow.Columns.Add("Count", Type.GetType("System.String"));
                dc = dtSaleFlow.Columns.Add("FixedPrice", Type.GetType("System.Decimal"));
                dc = dtSaleFlow.Columns.Add("UnitPrice", Type.GetType("System.Decimal"));
                dc = dtSaleFlow.Columns.Add("Calculate", Type.GetType("System.Decimal"));
                this._bColumnsHeader = true;
            }
            DataRow newRow;
            newRow = dtSaleFlow.NewRow();
            newRow["Product"] = dtItemDetails.Rows[0]["item_no"] + " \r\n" + dtItemDetails.Rows[0]["item_subname"];
            newRow["Count"] = 1;
            newRow["FixedPrice"] = Gfunc.strToDecimal(dtItemDetails.Rows[0]["sale_price"].ToString());
            newRow["UnitPrice"] = Gfunc.strToDecimal(dtItemDetails.Rows[0]["sale_price1"].ToString());
            newRow["Calculate"] = Gfunc.strToDecimal(dtItemDetails.Rows[0]["sale_price1"].ToString());
#region
            //bool ifAdd = true;
            //if (this.dtSaleFlow.Rows.Count > 0)
            //{
                
            //    for (int i = 0; i < this.dtSaleFlow.Rows.Count; i++)
            //    {
            //        string strProduct = this.dtSaleFlow.Rows[i]["Product"].ToString();
            //        string strId = strProduct.Substring(0, strProduct.IndexOf("\r\n"));
            //        //同一商品只需修改价格和数量。
            //        if (item_no.Equals(strId.Trim()))
            //        {
                        
            //            decimal count = System.Decimal.Parse(this.dtSaleFlow.Rows[i]["Count"].ToString()) + 1;
            //            decimal calculate = count * System.Decimal.Parse(dtItemDetails.Rows[0]["sale_price"].ToString());

            //            dtSaleFlow.Rows[i]["Product"] = dtItemDetails.Rows[0]["item_no"] + " \r\n" + dtItemDetails.Rows[0]["item_subname"];
            //            dtSaleFlow.Rows[i]["Count"] = count;
            //            dtSaleFlow.Rows[i]["FixedPrice"] = UtilityClass.strToDecimal(dtItemDetails.Rows[0]["sale_price"].ToString()).ToString();
            //            dtSaleFlow.Rows[i]["UnitPrice"] = UtilityClass.strToDecimal(dtItemDetails.Rows[0]["sale_price1"].ToString()).ToString();
            //            dtSaleFlow.Rows[i]["Calculate"] = UtilityClass.strToDecimal(calculate.ToString());
                       
                        
            //            ifAdd = false;
            //        }
            //        //int sum =  UtilityClass.strToDecimal(dtSaleFlow.Rows[i]["Calculate"]);

            //        //this.lbTotal.Text = UtilityClass.strToDecimal(dtItemDetails.Rows[i]["Calculate"].ToString()).ToString();
                   
            //    }
            //    this.dgvSaleFlow.Refresh();

            //}
            //if (ifAdd)
            //{
                //合计


            //}
#endregion
            dtSaleFlow.Rows.Add(newRow);
            //合计总数
            decimal decTotal = 0;
            decimal decCount = 0;
            for (int i = 0; i < dtSaleFlow.Rows.Count;i++ )
            {
                decTotal = Gfunc.strToDecimal(dtSaleFlow.Rows[i]["Calculate"].ToString()) + decTotal;
                decCount = Gfunc.strToDecimal(dtSaleFlow.Rows[i]["Count"].ToString()) + decCount;
               
            }
            this.lbTotal.Text = decTotal.ToString();
            this.lbCount.Text = decCount.ToString();
            this.bindingSaleFlow.DataSource = dtSaleFlow;

            for (int i = 1; i <= dgvSaleFlow.RowCount; i++)
            {
                dgvSaleFlow.Rows[i - 1].Cells[0].Value = i.ToString();
            }
           
            this.dgvSaleFlow.DataSource = bindingSaleFlow;

            //设置宽度
            dgvSaleFlow.Columns["NO"].Width = 50;
            dgvSaleFlow.Columns["NO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSaleFlow.Columns["Product"].Width = 110;
            dgvSaleFlow.Columns["Product"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvSaleFlow.Columns["Count"].Width = 60;
            dgvSaleFlow.Columns["Count"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSaleFlow.Columns["FixedPrice"].Width = 60;
            dgvSaleFlow.Columns["FixedPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSaleFlow.Columns["UnitPrice"].Width = 60;
            dgvSaleFlow.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSaleFlow.Columns["Calculate"].Width = 60;
            dgvSaleFlow.Columns["Calculate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
     
        }
        #endregion

        #region 删除已选择商品
        
        
        
        
        
        
       
        private void btnDel_Click(object sender, EventArgs e)
        {

            try
            {
                int RowNumber;
                if (null == dgvSaleFlow.CurrentCell)
                {
                    return;
                }
                RowNumber = dgvSaleFlow.CurrentCell.RowIndex;
                dtSaleFlow.Rows.RemoveAt(RowNumber);

                for (int i = 1; i <= dgvSaleFlow.RowCount; i++)
                {
                    dgvSaleFlow.Rows[i - 1].Cells[0].Value = i.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region 初始化窗体控件
        
        
        
        private void initWinFormControls()
        {



        }
        #endregion

        private void btnCount_Click(object sender, EventArgs e)
        {
            FrmNum frmNums = new FrmNum();

            frmNums.ShowDialog();
        }

        #region 键盘事件
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int WM_KEYDOWN = 256;
            int WM_SYSKEYDOWN = 260;
            //if (msg.Msg == 0x100 || msg.Msg == 0x104)                       // WM_KEYDOWN, WM_SYSKEYDOWN  
            if (msg.Msg == WM_KEYDOWN || msg.Msg == WM_SYSKEYDOWN) 
            {
                switch (keyData)
                {
                    case Keys.Escape:

                        base.Close();//esc关闭窗体

                     break;

                }
                MessageBox.Show(keyData.ToString());
            }
            return false;
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}

            