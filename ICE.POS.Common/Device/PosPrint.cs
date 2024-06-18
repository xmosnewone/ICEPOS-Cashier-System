namespace ICE.POS.Common
{
     
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;
    using ICE.POS.Model;

    public class PosPrint
    {
    
        private DevPortType _devPortType = DevPortType.NONE;
        public bool _isHzPrinter = false;
        private bool _isWindowPrinter = true;
        private string _printerName = "NONE";
        private WinPrinter _winPrinter = null;

        //------------------------
        private int _numHeaderNL = 3;
        private int _numPrinterNL = 3;

        public void FooterEmptyLine()
        {
            if (this._devPortType != DevPortType.WIN)
            {
                for (int i = 0; i < _numPrinterNL; i++)
                {
                    //this.PrintOut("\r\n");
                }
            }
        }

        public void HeaderEmptyLine()
        {
            if (this._devPortType != DevPortType.WIN)
            {
                for (int i = 0; i < _numHeaderNL; i++)
                {
                    //this.PrintOut("\r\n");
                }
            }
        }

        public bool OpenPrinter(string printerName, string portName)
        {
            this._printerName = printerName;
            if (this.IsWindowPrinter)
            {
                if (string.IsNullOrEmpty(this._printerName))
                {
                    MessageBox.Show("请输入打印机名称！！！");
                }
                else
                {
                    this._winPrinter = new WinPrinter();
                    this._devPortType = DevPortType.WIN;
                }
            }
            return true;
        }

        public void PrintOut(List<t_pos_printer_out> listOut)
        {
            if ((this._devPortType == DevPortType.WIN) && (this._winPrinter != null))
            {
                this._winPrinter.PrintOut(this._printerName, listOut);
            }
        }

        public bool IsWindowPrinter
        {
            get
            {
                return this._isWindowPrinter;
            }
            set
            {
                this._isWindowPrinter = value;
            }
        }

     

        private enum DevPortType
        {
            NONE,
            COM,
            LPT,
            USB,
            TCP,
            EXE,
            DLL,
            WIN
        }
    }
}

