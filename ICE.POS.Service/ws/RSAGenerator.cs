using System;
using System.Collections.Generic;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Xml;

namespace ICE.POS.Service
{
    public class RSAGenerator
    {
        private RSACryptoServiceProvider rsa;
        //构造函数 
        public RSAGenerator()
        {
            rsa = new RSACryptoServiceProvider();
        }
        //获取公钥 
        public string GetPublicKey()
        {
            return MD5Manager.Md5Encrypt(rsa.ToXmlString(false));
        }
        //获取私钥 
        public string GetPrivateKey()
        {
            return MD5Manager.Md5Encrypt(rsa.ToXmlString(true));
        }

        /// <summary> 
        /// 根据公钥加密字符串         
        /// </summary> 
        /// <param name="originalString">要加密的字符串</param>         
        /// <param name="publicKey">公钥</param>         
        /// <returns></returns> 
        public string EncriptByPublicKey(string originalString, string publicKey)
        {
            rsa.FromXmlString(MD5Manager.Md5Decrypt(publicKey));
            byte[] tempByte = rsa.Encrypt(Encoding.UTF8.GetBytes(originalString), false); 
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < tempByte.Length; i++)
            {
                sb.Append(tempByte[i].ToString("X2"));
                if (i % 2 != 0)
                {
                    sb.Append("(");
                }
                else
                {
                    sb.Append(")");
                }
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }
        /// <summary>         
        /// 根据私钥解密  
        /// </summary> 
        /// <param name="encriptedString">要解密的字符串</param>         
        /// <param name="privateKey">私钥</param>         
        /// <returns></returns> 
        public string DecriptByPrivateKey(string encriptedString, string privateKey)
        {
            rsa.FromXmlString(MD5Manager.Md5Decrypt(privateKey));
            byte[] tempByte = new byte[128];
            string[] tempStr = encriptedString.Split(',');
            for (int i = 0; i < tempStr.Length; i++)
            {
                tempByte[i] = Convert.ToByte(tempStr[i]);
            }
            return Encoding.UTF8.GetString(rsa.Decrypt(tempByte, false));
        }
    }
}

