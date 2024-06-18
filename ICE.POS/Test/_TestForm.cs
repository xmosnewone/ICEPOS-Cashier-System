

namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    public partial class _TestForm : Form
    {

        public _TestForm()
        {
            InitializeComponent();
        }

        //private void TestForm_MouseClick(object sender, MouseEventArgs e)
        //{
        //    // MessageBox.Show("MouseClick");
        //}

        //private void TestForm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    MessageBox.Show(e.KeyCode.ToString());
        //}
        private void TestForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void TestForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Gfunc.InitSystem() == 1)
            {
                this.tbText.Text = 
                                Gattr.BranchNo +" = 分支\r\n" +
                                Gattr.PosId + " = PosId\r\n" + 
                                Gattr.WebPosServicePath + " = serviceFileName \r\n" +
                                Gattr.HttpAddress ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.label2.Text = Gattr.ServerBll.GetHellWorld();
        }
    }
}
