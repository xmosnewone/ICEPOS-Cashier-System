namespace ICE.Utility
{
    using System;
    using System.IO;
    using System.Net;
    using System.Text;
    
    public class WebUtility
    {
        #region 单例模式
        private static object sync = new object();
        private static WebUtility _instance;
        
        private WebUtility()
        {

        }
        
        public static WebUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new WebUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        
        public String GetHttpWebResponse(String address)
        {
            HttpWebRequest webrequest = null;
            HttpWebResponse webreponse = null;
            Stream stream = null;
            String result = string.Empty;
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
                | SecurityProtocolType.Tls
                | (SecurityProtocolType)0x300 //Tls11
                | (SecurityProtocolType)0xC00; //Tls12
                webrequest = (HttpWebRequest)HttpWebRequest.Create(address);
                webrequest.Timeout = 60 * 1000;
                webreponse = (HttpWebResponse)webrequest.GetResponse();
                // Get the stream associated with the response.
                Stream receiveStream = webreponse.GetResponseStream();
                // Pipes the stream to a higher level stream reader with the required encoding format. 
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                result = readStream.ReadToEnd();
            }
            catch (Exception)
            {
                //result = ex.Message;
                result = "404";
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
                if (webreponse != null)
                {
                    webreponse.Close();
                }
            }
            return result;
        }
        public String GetPostHttpWebResponse(String address, String parameters)
        {
            HttpWebRequest webrequest = null;
            HttpWebResponse webreponse = null;
            Stream receiveStream = null;
            String result = string.Empty;
            Stream requestStream = null;
            StreamReader readStream = null;
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
                | SecurityProtocolType.Tls
                | (SecurityProtocolType)0x300 //Tls11
                | (SecurityProtocolType)0xC00; //Tls12
                webrequest = (HttpWebRequest)HttpWebRequest.Create(address);
                webrequest.Timeout = 30 * 1000;
                webrequest.Method = "POST";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = encoding.GetBytes(parameters);
                webrequest.ContentLength = data.Length;
                requestStream = webrequest.GetRequestStream();
                requestStream.Write(data, 0, data.Length);
                webreponse = (HttpWebResponse)webrequest.GetResponse();
                receiveStream = webreponse.GetResponseStream();
                readStream = new StreamReader(receiveStream, Encoding.UTF8);
                result = readStream.ReadToEnd();
            }
            catch (Exception)
            {
                result = "404";
            }
            finally
            {
                if (readStream != null)
                {
                    readStream.Close();
                    readStream.Dispose();
                }
                if (requestStream != null)
                {
                    requestStream.Close();
                    requestStream.Dispose();
                }
                if (receiveStream != null)
                {
                    receiveStream.Close();
                    receiveStream.Dispose();
                }
                if (webreponse != null)
                {
                    webreponse.Close();
                }
            }
            return result;
        }
    }
}
