namespace ICE.POS
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    public partial class FrmBranchSelect : FrmBase
    {
        private string _type = "0";
        public FrmBranchSelect(string type)
        {
            InitializeComponent();
            this._type = type;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void dgvBranch_DoubleClick(object sender, EventArgs e)
        {
            this.SelectBranch();
        }

        private void dgvBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.SelectBranch();
            }
            if (e.KeyCode == Keys.Return)
            {
                this.SelectBranch();
            }
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }
        private void FrmBranchSelect_Load(object sender, EventArgs e)
        {
            this.Text = Gattr.AppTitle;
            this.SetItemView();
        }
        private void SelectBranch()
        {
            if ((this.dgvBranch.SelectedRows.Count > 0) && (this.dgvBranch.SelectedRows[0] != null))
            {
                this.BranchNO = SIString.TryStr(this.dgvBranch.SelectedRows[0].Cells["branch_no"].Value);
                base.Close();
            }
        }

        private void SetItemView()
        {
            string where = string.Empty;
            switch (this._type)
            {
                case "1":
                    where = string.Format("AND (trade_type='0' OR trade_type='2') AND BRANCH_NO <> '{0}' ", Gattr.BranchNo);
                    break;
                case "2":
                    where = string.Format("AND (trade_type='3' OR trade_type='8') AND BRANCH_NO <> '{0}' ", Gattr.BranchNo);
                    break;
                default:
                    where = string.Format("AND  trade_type <>'5'", new object[0]);
                    break;
            }
            if (!string.IsNullOrEmpty(this._type.ToString()))
            {
                where += "  AND property in (" + this._type.ToString() + ")";
            }
            DataTable branchInfo = Gattr.Bll.GetBranchInfo(where);
            if (this._type == "3")
            {
                DataRow row = branchInfo.NewRow();
                row["branch_no"] = "ALL";
                row["branch_name"] = "所有门店";
                branchInfo.Rows.Add(row);
            }
            this.dgvBranch.DataSource = branchInfo;
            this.dgvBranch.Columns[0].HeaderText = "门店编号";
            this.dgvBranch.Columns[0].Width = 100;
            this.dgvBranch.Columns[1].HeaderText = "门店名称";
            this.dgvBranch.Columns[1].Width = 180;
        }

        public string BranchNO { get; set; }
    }
}
