namespace ICE.POS.Common
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public class TableLayoutPanelEx : TableLayoutPanel
    {
        private IContainer components;

        public TableLayoutPanelEx()
        {
            this.InitializeComponent();
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        public TableLayoutPanelEx(IContainer container)
        {
            container.Add(this);
            this.InitializeComponent();
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

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
    }
}

