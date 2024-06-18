namespace ICE.POS.Common
{
    using System;
    using System.Windows.Forms;

    public sealed class MyDataGridView : DataGridView
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Return:
                case Keys.Escape:
                case Keys.F5:
                    this.OnKeyDown(new KeyEventArgs(keyData));
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

