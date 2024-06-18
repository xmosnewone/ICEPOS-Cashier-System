namespace ICE.POS.Common
{
   
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Windows.Forms;
    using ICE.POS.Model;

    public class WinPrinter
    {
        private List<t_pos_printer_out> _listPrint = null;
        public int rowint = 0;

        //----------------------------
        bool PrintMorePage = true;
        int FontSize = 8;
        string FontName = "黑体";
        public void PrintOut(string printerName, List<t_pos_printer_out> listPrint)
        {
            if (((listPrint != null) && (listPrint.Count != 0)) && !string.IsNullOrEmpty(printerName))
            {
                this._listPrint = listPrint;
                try
                {
                    PrintDialog dialog = new PrintDialog();
                    PrintDocument document = new PrintDocument {
                        DocumentName = "POS机小票"
                    };
                    document.PrinterSettings.PrinterName = printerName;
                    document.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                    document.PrintController = new StandardPrintController();
                    if (PrintMorePage)
                    {
                        document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPageEventHandler2);
                    }
                    else
                    {
                        document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPageEventHandler);
                    }
                    dialog.Document = document;
                    document.Print();
                    document.Dispose();
                    dialog.Dispose();
                }
                catch (InvalidPrinterException exception)
                {
                    MessageBox.Show(exception.Message,"系统提示");
                }
                catch (Exception exception2)
                {
                    MessageBox.Show(exception2.Message,"系统提示");
                }
            }
        }

        private void PrintPageEventHandler(object obj, PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Y;
            foreach (t_pos_printer_out _out in this._listPrint)
            {
                double num2 = FontSize * (_out.BigFont ? 1.25 : 1.0);
                float emSize = (float) num2;
                using (Font font = new Font(FontName, emSize, FontStyle.Regular))
                {
                    e.Graphics.DrawString(_out.Text, font, Brushes.Black, (float) e.MarginBounds.X, y);
                    y += font.GetHeight();
                }
            }
        }

        private void PrintPageEventHandler2(object obj, PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Y;
            e.HasMorePages = false;
            if (FontSize <= 0)
            {
                FontSize = 10;
            }
            double num2 = FontSize * 1.25;
            float num3 = (float) num2;
            float height = 0f;
            for (int i = this.rowint; i < this._listPrint.Count; i++)
            {
                this.rowint++;
                t_pos_printer_out _out = this._listPrint[i];
                using (Font font = new Font(FontName, _out.BigFont ? num3 : ((float)FontSize), FontStyle.Regular))
                {
                    e.Graphics.DrawString(_out.Text, font, Brushes.Black, (float) e.MarginBounds.X, y);
                    height = font.GetHeight();
                    y += height;
                }
                if ((((y + (height * 3f)) * 96f) / 100f) > e.PageSettings.PrintableArea.Height)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }
    }
}

