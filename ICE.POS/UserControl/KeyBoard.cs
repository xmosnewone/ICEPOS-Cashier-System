namespace ICE.POS
{
    using System;
    using System.Windows.Forms;
    public partial class KeyBoard : UserControl
    {
        public KeyBoard()
        {
            InitializeComponent();
        }

        protected void KeyBoard_Click(object sender, EventArgs e)
        {
          
            Panel panel = sender as Panel;
            if ((panel != null) && (panel.Tag.ToString() != ""))
            {
                SendKeys.Send(panel.Tag.ToString());
            }
        }
    }
}
