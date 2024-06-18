namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;

    public partial class FrmVipInfoList : FrmBase
    {
        private List<t_vip_info> _vipInfoList;
        private t_vip_info _vipInfo;
        public FrmVipInfoList(List<t_vip_info> list)
        {
            InitializeComponent();
            try
            {
                _vipInfoList = list;
            }
            catch
            {

            }
        }
        
        
        
        
        
        private void FrmVipInfoList_Load(object sender, EventArgs e)
        {
            this.dgvVipInfoList.AutoGenerateColumns = false;
            this.bindingVipInfoList.DataSource = this._vipInfoList;
            this.dgvVipInfoList.DataSource = this.bindingVipInfoList;
            this.dgvVipInfoList.Refresh();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.selectVipInfo();
            this.DialogResult = DialogResult.OK;
        }

        private void dgvPenOrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.selectVipInfo();
                this.DialogResult = DialogResult.OK;

            }
        }
        public void selectVipInfo()
        {
            if (this.dgvVipInfoList.CurrentRow != null)
            {
                if (this.dgvVipInfoList.CurrentRow.Index >= 0)
                {
                    //if (this.dgvVipInfoList.Rows[this.dgvVipInfoList.CurrentRow.Index].Cells["vip_card_no"].Value != null)
                    //{
                    //    this._vipCardNo = this.dgvVipInfoList.Rows[this.dgvVipInfoList.CurrentRow.Index].Cells["vip_card_no"].Value.ToString();

                    //}
                    this._vipInfo = (t_vip_info)this.dgvVipInfoList.CurrentRow.DataBoundItem;
                }
            }
        }

        public t_vip_info VipInfo
        {
            get
            {
                return this._vipInfo;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            base.Close();
        }

        private void dgvOperList_DoubleClick(object sender, EventArgs e)
        {
            selectVipInfo();
            this.DialogResult = DialogResult.OK;
        }
    }
}
