using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ICE.POS.Common;

namespace ICE.POS
{
    public partial class FrmDeleteGood : ICE.POS.FrmBase
    {
        public FrmDeleteGood()
        {
            InitializeComponent();
        }

        private void buttonConfirm(object sender, EventArgs e)
        {
           DialogResult _DR= MessageBox.Show("确定要清空所有商品分类和数据吗？", "商品数据清除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if (_DR == DialogResult.OK)
           {
               bool isok = Gattr.Bll.DelItemClsData();
               bool isok2 = Gattr.Bll.DelItemData();
               bool isOk3 = Gattr.Bll.UpdateTHandleData();
               if (isok&&isok2&&isOk3)
               {
                    MessageBox.Show("执行成功");
                    this.Hide();
               }else{
                   MessageBox.Show("执行失败");
               }

            }
        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
