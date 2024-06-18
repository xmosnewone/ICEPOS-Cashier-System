namespace ICE.POS
{
    using System.Drawing;
    using System.Windows.Forms;
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
            this.BackColor = Color.FromArgb(224, 227, 232);
        }
    }
}
