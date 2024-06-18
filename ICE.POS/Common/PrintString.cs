namespace ICE.POS
{
    class PrintString
    {
        private bool _isBigSize;
        private string _prtSrt;

        public PrintString()
        {
            this._prtSrt = "";
            this._isBigSize = false;
        }

        public PrintString(string strPrt)
        {
            this._prtSrt = "";
            this._isBigSize = false;
            this._prtSrt = strPrt;
        }
        
        
        
        
        
        public PrintString(string strPrt, int intLen)
        {
            this._prtSrt = "";
            this._isBigSize = false;
            this._prtSrt = Gfunc.PrintStrAlign(strPrt, intLen, TextAlign.Left);
        }
        
        
        
        
        
        
        public PrintString(string strPrt, int intLen, TextAlign align)
        {
            this._prtSrt = "";
            this._isBigSize = false;
            this._prtSrt = Gfunc.PrintStrAlign(strPrt, intLen, align);
        }
        
        
        
        
        
        
        
        public PrintString(string strPrt, int intLen, TextAlign align, bool isBigSize)
        {
            this._prtSrt = "";
            this._isBigSize = false;
            this._prtSrt = Gfunc.PrintStrAlign(strPrt, intLen, align);
            this._isBigSize = isBigSize;
            if (this._isBigSize && (Gattr.PosPrinter != null))
            {
                if (Gattr.PosPrinter.IsWindowPrinter)
                {
                    this._prtSrt = Gfunc.PrintStrAlign(strPrt, (int)(((double)intLen) / 1.23), align);
                }
                else if (Gattr.PosPrinter._isHzPrinter)
                {
                    this._prtSrt = Gfunc.PrintStrAlign(strPrt, (int)(((double)intLen) / 1.8), align);
                }
            }
        }

        public bool IsBigSize
        {
            get
            {
                return this._isBigSize;
            }
            set
            {
                this._isBigSize = value;
            }
        }

        public string PrtSrt
        {
            get
            {
                return this._prtSrt;
            }
            set
            {
                this._prtSrt = value;
            }
        }
    }
    public enum TextAlign
    {
        Center = 2,
        Left = 1,
        Right = 3
    }
}
