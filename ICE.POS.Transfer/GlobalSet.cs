namespace ICE.POS.Transfer
{
    using System;
    using System.Configuration;



    public static class GlobalSet
    {
        private static String _appname = "POS数据传输";
        
        public static String appname
        {
            get
            {
                return _appname;
            }
            set
            {
                _appname = value;
            }
        }

        private static String _appinifile = "transfer.ini";
        
        
        
        public static String appinifile
        {
            get
            {
                return _appinifile;
            }
            set
            {
                _appinifile = value;
            }
        }

        private static String _posServiceUrl = "http://127.0.0.1/";
        
        
        
        public static String posserviceurl
        {
            get
            {
                return _posServiceUrl;
            }
            set
            {
                _posServiceUrl = value;
            }
        }

        private static String _posServiceName = "api/posServices";
        
        
        
        public static String posservicename
        {
            get
            {
                return _posServiceName;
            }
            set
            {
                _posServiceName = value;
            }
        }

        private static String _dbsaleconnection;
        
        
        
        public static String dbsaleconn
        {
            get
            {
                return _dbsaleconnection;
            }
            set
            {
                _dbsaleconnection = value;
            }
        }

        private static string _connect_string;
        
        
        
        public static string ConnectString
        {
            get { return _connect_string; }
            set { _connect_string = value; }
        }

        private static string _client_id = "POS";
        
        
        
        public static string client_id
        {
            get { return _client_id; }
            set { _client_id = value; }
        }
        private static string _access_token = ConfigurationManager.AppSettings["accessToken"];
        
        
        
        public static string access_token
        {
            get { return _access_token; }
            set { _access_token = value; }
        }
        private static string _serverUrl = "";
        
        
        
        public static string serverUrl
        {
            get { return _serverUrl; }
            set { _serverUrl = value; }
        }


        private static string _memberUrl;
        
        
        
        public static string memberUrl
        {
            get
            {
                return _memberUrl;
            }
            set {
                _memberUrl = value;
            }
        }

        private static string _access_way;
        
        
        
        public static string access_way
        {
            get
            {
                return _access_way;
            }
            set
            {
                _access_way = value;
            }
        }
        private static string _mem_access_token;
        
        
        
        public static string mem_access_token
        {
            get
            {
                return _mem_access_token;
            }
            set
            {
                _mem_access_token = value;
            }
        }
    }
}
