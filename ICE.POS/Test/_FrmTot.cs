namespace ICE.POS
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using ICE.POS.Common;
    public partial class _FrmTot : Form
    {
        Size _sizeInputPayText;
        private int _inputPayDisplayMax = 15;
        //private int _inputDisplayMax = 13;
        //private Size _sizeInputText;
        public _FrmTot()
        {
            InitializeComponent();
           
        }
        private void ResetPayCursor()
        {
            TextGraphics graphics = new TextGraphics(base.CreateGraphics());
            this._sizeInputPayText = graphics.MeasureText("A", this.lbPayInput.Font);
            graphics.Dispose();
            this._inputPayDisplayMax = (this.lbPayInput.Width / this._sizeInputPayText.Width) - 1;
        }
        private string _inputText = "";
        private void SetCursorText()
        {
            if (true)
            {
                if (this._inputText.Length > this._inputPayDisplayMax)
                {
                    this.lbPayInput.Text = this._inputText.Substring(this._inputText.Length - this._inputPayDisplayMax, this._inputPayDisplayMax);
                }
                else
                {
                    this.lbPayInput.Text = this._inputText;
                }
                this.lbPayInput.Refresh();
                this.lbPayCursor.Visible = false;
                this.lbPayCursor.Left = ((int)(this._sizeInputPayText.Width + 10 * 0.65f)) + (this.lbPayInput.Text.Length * this._sizeInputPayText.Width);
                this.lbPayCursor.Visible = true;
            }
            else
            {
                //if (this._inputText.Length > this._inputDisplayMax)
                //{
                //    this.lbPayInput.Text = this._inputText.Substring(this._inputText.Length - this._inputDisplayMax, this._inputDisplayMax);
                //}
                //else
                //{
                //    this.lbPayInput.Text = this._inputText;
                //}
                //this.lbPayInput.Refresh();
                //this.lbPayCursor.Visible = false;
                //this.lbPayCursor.Left = ((int)(this._sizeInputText.Width * 0.5f)) + (this.lbPayInput.Text.Length * this._sizeInputText.Width);
            }
        }

        private void FrmTot_Load(object sender, EventArgs e)
        {
            SetCursorText();
            ResetPayCursor();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          this.lbPayCursor.Visible = !this.lbPayCursor.Visible;
        }

        private void txtInput_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                base.DialogResult = DialogResult.OK;
            }

        }
    }
}
