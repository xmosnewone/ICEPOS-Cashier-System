namespace ICE.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Windows.Forms;
    using ICE.Common;
    
    
    
    public class PrinterUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static PrinterUtility _instance;
        
        
        
        private PrinterUtility()
        {

        }
        
        
        
        public static PrinterUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new PrinterUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        
        
        
        public bool Print(List<WinPrinterParameter> _parameters, String printerName, int _width, ref String errMessage)
        {
            bool isok = false;
            PrintDialog dialog = null;
            PrintDocument document = null;
            try
            {
                dialog = new PrintDialog();
                document = new PrintDocument() { DocumentName = "Pos" };
                document.PrinterSettings.PrinterName = printerName;
                document.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                document.PrintController = new StandardPrintController();
                document.PrintPage += (obj, e) =>
                {
                    isok = PrintContent(_parameters, 0, e, _width);
                };
                dialog.Document = document;
                document.Print();
                isok = true;
            }
            catch (Exception ex)
            {
                errMessage = ex.ToString();
            }
            finally
            {
                if (document != null)
                {
                    document.Dispose();
                }
                if (dialog != null)
                {
                    dialog.Dispose();
                }
            }
            return isok;
        }
      
        #endregion
        #region 私有方法
        
        
        
        
        
        
        
        private bool PrintContent(List<WinPrinterParameter> _paramters, int _startIndex, PrintPageEventArgs e, int _width)
        {
            bool isok = true;
            float y = e.MarginBounds.Y;
            float top = e.MarginBounds.Top;
            float height = 0f;
            try
            {
                for (int index = _startIndex; index < _paramters.Count; index++)
                {
                    WinPrinterParameter _para = _paramters[index];
                    using (Font font = new Font(_para.FontFamily, _para.FontSize, _para.FontStyle))
                    {
                        e.Graphics.DrawString(_para.FontText, font, Brushes.Black, (float)e.MarginBounds.X, y + 10);
                        height = font.GetHeight();
                        y += font.GetHeight();
                    }
                    //if ((((y + (height * 3f)) * 96f) / 100f) > e.PageSettings.PrintableArea.Height)
                    //{
                    //    e.HasMorePages = true;
                    //    PrintContent(_paramters, index + 1, e, _width);
                    //}
                }
            }
            catch
            {
                isok = false;
            }
            return isok;
        }
        
        #endregion
    }
}
