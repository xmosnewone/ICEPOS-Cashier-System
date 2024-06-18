namespace ICE.POS.Service
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    public class MD5Manager
    {
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

        //MD5加密 
        public static string Md5Encrypt(string strSource)
        {
            byte[] bytIn = System.Text.Encoding.Default.GetBytes(strSource); 
            byte[] iv = { 102, 17, 93, 156, 78, 4, 217, 32 }; //这些数字都是可以更改的
            byte[] key = { 55, 101, 246, 79, 36, 99, 166, 3 }; //这些数字都是可以更改的
            DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
            mobjCryptoService.Key = iv;
            mobjCryptoService.IV = key; 
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length); cs.FlushFinalBlock();
            string msStr = System.Convert.ToBase64String(ms.ToArray());
            ms.Dispose();
            return msStr;
        }
        //MD5解密 
        public static string Md5Decrypt(string Source)
        {
            byte[] bytIn = System.Convert.FromBase64String(Source);
            byte[] iv = { 102, 17, 93, 156, 78, 4, 217, 32 };//要与加密时的一致
            byte[] key = { 55, 101, 246, 79, 36, 99, 166, 3 }; //要与加密时的一致 
            DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
            mobjCryptoService.Key = iv;
            mobjCryptoService.IV = key;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);
            ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
            StreamReader strd = new StreamReader(cs, Encoding.Default);
            string msStr = strd.ReadToEnd();;
            ms.Dispose();
            return msStr;
        }  
    }
}

