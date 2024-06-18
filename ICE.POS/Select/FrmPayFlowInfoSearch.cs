namespace ICE.POS
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using ICE.POS.Common;
    
    
    
    public partial class FrmPayFlowInfoSearch :FrmBase
    {
        #region 窗体全局声名
        
        
        
        
        
        public delegate void SetRePrintDelegate(bool isReprint, String flowNo);
        
        
        
        public event SetRePrintDelegate SetReprintEvent;
        #endregion
        #region 窗体初始化
        public FrmPayFlowInfoSearch()
        {
            InitializeComponent();
            Text = Gattr.AppTitle;
            this.ActiveControl = txtInput;
            LoadData(0);
        }
        #endregion
        #region 窗体事件逻辑
        
        
        
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            ButtonEx btnEx = sender as ButtonEx;
            if (btnEx != null)
            {
                switch (btnEx.Tag.ToString())
                {
                    case "s":
                        if (string.IsNullOrEmpty(this.txtInput.Text.Trim()))
                        {
                            MessageBox.Show("请输入流水号", Gattr.AppTitle);
                        }
                        else
                        {
                            LoadData(0);
                        }
                        break;
                    case "p":
                        LoadData(-1);
                        break;
                    case "n":
                        LoadData(1);
                        break;
                    case "r":

                        DialogResult = DialogResult.OK;
                        if (SetReprintEvent != null)
                        {
                            SetReprintEvent(true, this.txtInput.Text.Trim());
                        }
                        break;
                    case "e":
                        DialogResult = DialogResult.Cancel;
                        break;
                }
                txtInput.Focus();
                LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】进行交易查询！", LogEnum.SysLog);
            }
        }
        
        
        
        
        
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtInput.Focus();
            }
            else if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
            {
                btnOK_Click(btnOK, null);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnOK_Click(buttonEx3, null);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnOK_Click(btnPre, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnOK_Click(btnNext, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnOK_Click(buttonEx4, null);
            }
        }
        #endregion
        #region 窗体私有方法
        
        
        
        void LoadData(int mark)
        {
            String operate = "=";
            if (mark == -1)
            {
                operate = "<";
            }
            else if (mark == 1)
            {
                operate = ">";
            }
            DataTable table = Gattr.Bll.GetMaxPayFlowInfo(Gattr.BranchNo, Gattr.PosId, txtInput.Text, operate);
            table.Columns.Add("sale_way_name");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                switch (table.Rows[i]["sale_way"].ToString())
                {
                    case  "A":
                        table.Rows[i]["sale_way_name"] = "销售";
                        break;
                    case "B":
                        table.Rows[i]["sale_way_name"] = "退货";
                        break;
                    case "C":
                        table.Rows[i]["sale_way_name"] = "赠送";
                        break;
                    default :
                        table.Rows[i]["sale_way_name"] = "挂账";
                        break;
                }
            }
            dgvPay.AutoGenerateColumns = false;
            dgvPay.DataSource = table;
            dgvSale.DataSource = null;
            bool isLoadDetails = true;
            if (table != null && table.Rows.Count > 0)
            {
                txtInput.Text = SIString.TryStr(table.Rows[0]["flow_no"]);
            }
            else
            {
                if (txtInput.Text.Trim().Length > 0)
                {
                    if (mark == 0)
                    {
                        MessageBox.Show("没有找到流水号[" + txtInput.Text + "]的订单", Gattr.AppTitle);
                    }
                    else
                    {
                        MessageBox.Show("已是最后一条", Gattr.AppTitle);
                        isLoadDetails = false;
                    }
                }
            }
            if (isLoadDetails)
                LoadDetails(txtInput.Text);
        }
        
        
        
        
        void LoadDetails(String flowNo)
        {
            DataTable table = Gattr.Bll.GetSaleFlowInfos(flowNo);
            dgvSale.AutoGenerateColumns = false;
            if (table != null && table.Rows.Count > 0)
            {
                dgvSale.DataSource = table;
            }
        }
        #endregion




    }
}
