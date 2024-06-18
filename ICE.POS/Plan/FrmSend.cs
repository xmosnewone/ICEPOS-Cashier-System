
/********************************************************
 * Description:赠品选择窗体
 * Modify:
 * ******************************************************/
namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using ICE.POS.Model;
    using System.Windows.Forms;
    public partial class FrmSend : FrmBase
    {
        
        
        
        
        public delegate void SetSendItem(List<t_cur_saleflow> saleInfos);
        
        
        
        public event SetSendItem SetSend;

        public FrmSend(string showMessage, List<t_cur_saleflow> saleinfos)
        {
            InitializeComponent();
            BindData(showMessage, saleinfos);
        }
        #region 私有方法
        
        
        
        
        private void BindData(string showMessage, List<t_cur_saleflow> saleinfos)
        {
            this.lbMessage.Text = showMessage;
            this.dgItem.AutoGenerateColumns = false;
            this.dgItem.DataSource = saleinfos;
            for (int i = 0; i < this.dgItem.Rows.Count; i++)
            {
                this.dgItem.Rows[i].Cells[0].Value = true;
            }
        }
        #endregion
        #region 事件逻辑代码
        
        
        
        
        
        private void buttonEx1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgItem.Rows.Count; i++)
            {
                this.dgItem.Rows[i].Cells[0].Value = true;
            }
        }
        
        
        
        
        
        private void buttonEx2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgItem.Rows.Count; i++)
            {
                this.dgItem.Rows[i].Cells[0].Value = false;
            }
        }
        
        
        
        
        
        private void btnDm_Click(object sender, EventArgs e)
        {
            List<t_cur_saleflow> saleInfos = new List<t_cur_saleflow>();
            for (int i = 0; i < this.dgItem.Rows.Count; i++)
            {
                t_cur_saleflow saleinfo = this.dgItem.Rows[i].DataBoundItem as t_cur_saleflow;
                if (saleinfo.isSelect)
                {
                    saleInfos.Add(saleinfo);
                }
            }
            if (saleInfos.Count == 0)
            {
                if (MessageBox.Show("确定不选择促销商品?", Gattr.AppTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
                else
                {
                    base.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
            else
            {
                if (SetSend != null)
                {
                    SetSend(saleInfos);
                }
                base.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        
        
        
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void dgItem_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {

        }
        #endregion
    }
}
