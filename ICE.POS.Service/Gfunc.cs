namespace ICE.POS.Service
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Xml;
    using System.Security.Cryptography;
    /// <summary>
    /// 公共方法类
    /// </summary>
    static class Gfunc
    {
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Decrypt(string source)
        {
            int num2;
            if (source.Length == 0)
            {
                return "";
            }
            char[] chArray = source.ToCharArray();
            int length = chArray.Length;
            StringBuilder builder = new StringBuilder();
            for (num2 = 0; num2 < length; num2++)
            {
                char ch = Convert.ToChar((int)(Convert.ToInt16(chArray[num2]) - (((length - (num2 + 1)) - 2) * 2)));
                builder.Append(ch);
            }
            chArray = builder.ToString().ToCharArray();
            for (num2 = 0; num2 < chArray.Length; num2++)
            {
                if (num2 <= ((chArray.Length / 2) - 1))
                {
                    char ch2 = chArray[num2];
                    chArray[num2] = chArray[(chArray.Length - 1) - num2];
                    chArray[(chArray.Length - 1) - num2] = ch2;
                }
            }
            return new string(chArray);
        }
    }
}
