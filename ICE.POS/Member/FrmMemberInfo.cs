namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    
    
    
    public partial class FrmMemberInfo : FrmBase
    {
        #region  构造函数
        public FrmMemberInfo()
        {
            InitializeComponent();
        }
        #endregion
        #region 窗体事件逻辑
        
        
        
        
        
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (SIString.TryStr(listBox1.SelectedItem).Length > 0)
            {
                ShowMember(SIString.TryStr(listBox1.SelectedItem));
            }
        }
        
        
        
        
        
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    ShowMember("查询会员卡信息		(F2)");
                    break;
                case Keys.F3:
                    MessageBox.Show("暂未开通", Gattr.AppTitle);
                    //ShowMember("会  员  充  值		(F3)");
                    break;
                case Keys.Enter:
                    ShowMember(SIString.TryStr(listBox1.SelectedItem));
                    break;
            }
        }
        #endregion
        #region 窗体私有方法
        
        
        
        
        void ShowMember(String mark)
        {
            switch (mark.ToString().Replace(" ", "").Replace("\t", ""))
            {
                case "会员充值(F3)":
                    MessageBox.Show("暂未开通", Gattr.AppTitle);
                    //FrmMemberRecharge frmRecharge = new FrmMemberRecharge();
                    //if (frmRecharge.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //{
                    //    DialogResult = DialogResult.OK;
                    //}
                    break;
                default:
                    FrmMemberInfoSearch frmMemberInfo = new FrmMemberInfoSearch();
                    frmMemberInfo.ShowDialog();
                    break;
            }
        }
        #endregion


    }
}
