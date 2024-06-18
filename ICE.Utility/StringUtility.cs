namespace ICE.Utility
{
    using System;
    
    public class StringUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static StringUtility _instance;
        
        
        
        private StringUtility()
        {

        }
        
        
        
        public static StringUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new StringUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        
        public  String[] AsiicAsc(String[] arr)
        {
            String[] result = arr;
            String temp = String.Empty;
            for (int index = 0; index < result.Length - 1; index++)
            {
                for (int rindex = index + 1; rindex < result.Length; rindex++)
                {
                    if (!StringSortAsciic(result[index], result[rindex]))//如果前一个字符ASCIIC码大于后一个字符ASCIIC
                    {
                        temp = result[index];
                        result[index] = result[rindex];
                        result[rindex] = temp;
                    }
                }
            }
            return result;
        }

        public string GetSubString(string strSub, int start, int length)
        {
            string temp = strSub;
            int j = 0, k = 0, p = 0;

            CharEnumerator ce = temp.GetEnumerator();
            while (ce.MoveNext())
            {
                j += (ce.Current > 0 && ce.Current < 255) ? 1 : 2;

                if (j <= start)
                {
                    p++;
                }
                else
                {
                    if (j == GetLength(temp))
                    {
                        temp = temp.Substring(p, k + 1);
                        break;
                    }
                    if (j <= length + start)
                    {
                        k++;
                    }
                    else
                    {
                        temp = temp.Substring(p, k);
                        break;
                    }
                }
            }

            return temp;
        }

        
        
        
        
        
        public String StringTrim(object obj)
        {
            String result = ExtendUtility.Instance.ParseToString(obj);
            return result.Trim();
        }
        #endregion
        #region 私有方法
        
        
        
        
        
        private  int ASCIIC(string character)
        {
            if (character.Length == 1)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
                return (intAsciiCode);
            }
            return 0;
        }
        
        
        
        
        
        
        private  bool StringSortAsciic(string beforeStr, string endStr)
        {
            for (int i = 0; i < beforeStr.Length; i++)
            {
                if (endStr.Length > i)
                {
                    //如果当前字母相等则继续下个循环
                    if (ASCIIC(beforeStr.Substring(i, 1)) == ASCIIC(endStr.Substring(i, 1)))
                    {
                        continue;
                    }
                    //如果当前字母小于则代表beforeStr小于endStr
                    if (ASCIIC(beforeStr.Substring(i, 1)) < ASCIIC(endStr.Substring(i, 1)))
                    {
                        return true;
                    }
                    //如果beforeStr比endStr大 则返回false
                    if (ASCIIC(beforeStr.Substring(i, 1)) > ASCIIC(endStr.Substring(i, 1)))
                    {
                        return false;
                    }
                }
            }
            //如果上面字符都小于或者相等,前面字符长于后面字符,则代表比他大,
            if (beforeStr.Length > endStr.Length)
            {
                return false;
            }
            return true;
        }


        
        
        
        
        
        private  int GetLength(String aOrgStr)
        {
            int intLen = aOrgStr.Length;
            int i;
            char[] chars = aOrgStr.ToCharArray();
            for (i = 0; i < chars.Length; i++)
            {
                if (System.Convert.ToInt32(chars[i]) > 255)
                {
                    intLen++;
                }
            }
            return intLen;
        }
        #endregion
    }
}
