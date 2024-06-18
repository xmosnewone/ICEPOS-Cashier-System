using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ICE.Utility
{
    public class FileUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static FileUtility _instance;
        
        
        
        private FileUtility()
        {

        }
        
        
        
        public static FileUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new FileUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        
        
        
        
        
        
        public String GetFileContent(string file, ref String errorMessage)
        {
            FileStream fs = null;
            StreamReader reader = null;
            String content = string.Empty;
            try
            {
                if (File.Exists(file))
                {
                    fs = new FileStream(file, FileMode.Open);
                    reader = new StreamReader(fs);
                    content = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    fs.Close();
                    fs.Dispose();
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
            }
            return content;
        }
        
        
        
        
        
        public void WriteFile(string Path, string Strings)
        {

            if (!System.IO.File.Exists(Path))
            {
                System.IO.FileStream f = System.IO.File.Create(Path);
                f.Close();
                f.Dispose();
            }
            FileStream fs = new FileStream(Path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Strings);
            sw.Close();
            sw.Dispose();
            fs.Close();
            fs.Dispose();


        }
        public string ReadFile(string Path)
        {
            string s = "";
            if (!System.IO.File.Exists(Path))
                s = "不存在相应的目录";
            else
            {
                StreamReader f2 = new StreamReader(Path, System.Text.Encoding.GetEncoding("gb2312"));
                s = f2.ReadToEnd();
                f2.Close();
                f2.Dispose();
            }

            return s;
        }
        
        
        
        
        
        
        
        public bool CreateFile(string file, bool autoDel, ref string errorMessage)
        {
            bool isCreate = true;
            FileStream fs = null;
            try
            {
                if (File.Exists(file))
                {
                    if (autoDel)
                    {
                        File.Delete(file);
                    }
                }
                if (!File.Exists(file))
                {
                    fs = File.Create(file);
                    isCreate = fs.CanRead;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                isCreate = false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
            return isCreate;
        }
    }
}
