using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.Utility;
namespace ICE.POS
{
    public partial class FrmArrearage : FrmBase
    {
        public FrmArrearage()
        {
            InitializeComponent();
        }

        private void FrmArrearage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_retMoney_Click(object sender, EventArgs e)
        {
            OpenDataInfo();
        }
        
        
        
        private void LoadData()
        {
            
            DataTable table = Gattr.Bll.GetPayFlowInfoDataTableByE();
            dgvArrearage.AutoGenerateColumns = false;
            dgvArrearage.DataSource = table;
        }

        
        
        
        private void OpenDataInfo()
        {
            string flow_no = ExtendUtility.Instance.ParseToString(this.dgvArrearage.Rows[this.dgvArrearage.CurrentRow.Index].Cells["flow_no"].Value.ToString().Trim());
            FrmCPayWay frmcPayWay = new FrmCPayWay(flow_no, true);
            frmcPayWay.ShowDialog();
            LoadData();
        }

        
        
        
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }

        
        private void dgvArrearage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenDataInfo();
        }

        private void dgvArrearage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenDataInfo();
            }
        }
    }
}
