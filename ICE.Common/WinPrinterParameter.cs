namespace ICE.Common
{
    using System;
    using System.Drawing;
    using System.Text;
    
    
    
    public class WinPrinterParameter
    {
        private Int32 _fontSize = 10;
        
        
        
        public Int32 FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
            }
        }
        private String _fontFamily = "宋体";
        
        
        
        public String FontFamily
        {
            get
            {
                return _fontFamily;
            }
            set
            {
                _fontFamily = value;
            }
        }
        private FontStyle _fontStyle = FontStyle.Regular;
        
        
        
        public FontStyle FontStyle
        {
            get
            {
                return _fontStyle;
            }
            set
            {
                _fontStyle = value;
            }
        }
        private String _fontText = String.Empty;
        
        
        
        public String FontText
        {
            get
            {
                return _fontText;
            }
            set
            {
                _fontText = value;
            }
        }
        private TextAlign _textAlign = TextAlign.Left;
        
        
        
        public TextAlign TextAlign
        {
            get { return _textAlign; }
            set { _textAlign = value; }
        }
    }
    
    
    
    public enum TextAlign
    {
        Left = 0,
        Center = 1,
        Right = 2
    }


}
