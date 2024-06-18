namespace ICE.POS.Common
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public class MyDataGrid : DataGridView
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    return this.ProcessLeftKey(keyData);

                case Keys.Right:
                case Keys.Return:
                    return this.ProcessRightKey(keyData);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public bool ProcessLeftKey(Keys keyData)
        {
            if (base.CurrentCell.ColumnIndex == 0)
            {
                if (base.CurrentCell.RowIndex != 0)
                {
                    base.CurrentCell = base.Rows[base.CurrentCell.RowIndex - 1].Cells[base.ColumnCount - 1];
                }
                return true;
            }
            return base.ProcessLeftKey(keyData);
        }

        public bool ProcessRightKey(Keys keyData)
        {
            if (base.CurrentCell.ColumnIndex == (base.ColumnCount - 1))
            {
                if (base.CurrentCell.RowIndex != (base.RowCount - 1))
                {
                    base.CurrentCell = base.Rows[base.CurrentCell.RowIndex + 1].Cells[0];
                }
                return true;
            }
            return base.ProcessRightKey(keyData);
        }
    }
}

