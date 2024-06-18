namespace ICE.Common
{
    using System;
    using System.Text;
    public class CommonHelper
    {
  
        public static string PrintStrAlign(string str, int intLen, TextAlign align)
        {
            int num = 0;
            int byteCount = Encoding.Default.GetByteCount(str);
            int length = str.Length;
            if (intLen == 0)
            {
                str = "";
                return str;
            }
            if (length < intLen)
            {
                switch (align)
                {
                    case TextAlign.Center:
                        if ((byteCount + 1) < intLen)
                        {
                            num = ((intLen - byteCount) / 2) + length;
                            str = str.PadLeft((num < 0) ? 0 : num, ' ');
                        }
                        return str;

                    case TextAlign.Right:
                        if (str.Length < intLen)
                        {
                            num = (intLen - byteCount) + length;
                            str = str.PadLeft((num < 0) ? 0 : num, ' ');
                        }
                        return str;
                }
                if (str.Length < intLen)
                {
                    num = (intLen - byteCount) + length;
                    str = str.PadRight((num < 0) ? 0 : num, ' ');
                }
            }
            return str;
        }
    }
}
