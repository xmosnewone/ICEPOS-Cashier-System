namespace ICE.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    
    
    public class JsonUtility
    {
        #region 单例模式
        
        
        
        private static object sync = new object();
        private static JsonUtility _instance;
        
        
        
        private JsonUtility()
        {

        }
        
        
        
        public static JsonUtility Instance
        {
            get
            {
                lock (sync)
                {
                    if (_instance == null)
                    {
                        lock (sync)
                        {
                            _instance = new JsonUtility();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region 公共方法
        
        
        
        
        public T JsonToObject<T>(String json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {

            }
            return default(T);
        }
        
        
        
        
        
        public String DataTableToJson(DataTable table)
        {
            String json = String.Empty;
            try
            {
                json = JsonConvert.SerializeObject(table, new DataTableConverter());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return json;
        }
        
        
        
        
        
        
        public String ObjectToJson<T>(List<T> t)
        {
            String json = String.Empty;
            try
            {
                json = JsonConvert.SerializeObject(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return json;
        }
        
        
        
        
        
        public DataTable JsonToDataTable(String json)
        {
            DataTable table = null;
            try
            {
                table = new DataTable();
                table=JsonConvert.DeserializeObject<DataTable>(json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return table;
        }
        #endregion
    }
}
