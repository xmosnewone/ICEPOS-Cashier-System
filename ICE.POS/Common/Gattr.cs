namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Common;
    using System.Configuration;
    using ICE.Utility;

    public static class Gattr
    {
        //返回业务逻辑对象
        private static PosBll _bll = new PosBll();
        private static string _posSalePrcPoint = "N2"; //流水原价
        private static string _posSaleNumPoint = "N2"; //流水数量
        private static string _posSaleAmtPoint = "N2";//流水小计
        private static string _posSaleNumPointF = "N4";
        private static string _posSalePrcPointF = "N4";
        private static Dictionary<string, t_attr_function> _FunKeys = null;
        private static ServerBll _serverBll = new ServerBll(); //操作服务器类
        private static bool _isTotRollBack; //结算是否回滚操作
        private static string _operId; //当前操作人编码
        private static string _operFullName; //操作人名称
        private static string _operPwd; //当前用户操作密码
        private static string _checkStandId;//收银台ID
        private static string _oper_flag;//操作人标记
        private static string _net_status;//联网状态
        private static PosPrint _posPrinter = new PosPrint();//打印类
        private static int _numHeaderNL = 0; //打印换行
        private static string _myHelp = Application.StartupPath + @"\Menu.pdf";
        private static string _textFile = Application.StartupPath + @"\notepad.txt";
        private static string _appTitle = ConfigurationManager.AppSettings["appName"]; //分店名称
        private static string _systemTitle = ConfigurationManager.AppSettings["systemName"]; //系统名称
        private static string _networkName = ConfigurationManager.AppSettings["networkName"]; //判读网络状态的域名
        private static string _billFile = Application.StartupPath + @"\log\小票" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
        private static bool _isBillPrintLog = true;//是否写日志
        private static int _prtLen = ExtendUtility.Instance.ParseToInt32(ConfigurationManager.AppSettings["posWidth"]); //小票纸张宽度
        private static string _posModel = ConfigurationManager.AppSettings["posName"];// "POS58"; //POS机型号
        private static string _posPort = ""; //POS机端口
        //private static string _vipCardNo = "";//会员编号
        //private static bool _isVip = false;//是否是VIP
        //private static decimal _vipScore = 0M; //VIP积分
        private static string _webPosServicePath = "";
        private static string _posId = ""; //POS机ID
        private static string _PortType = ConfigurationManager.AppSettings["portType"];//打印端口类型
        private static string _PortName = ConfigurationManager.AppSettings["portName"];//端口名称
        private static string _branchNo = "";//分支ID
        private static string _branchName = "";//分支名称
        private static string _httpAddress = "http://localhost";//webservice地址
        private static string _errMsg = "";
        private static bool _isConnectonServer;
        private static int _flowNo = 0; //流水ID
        private static string _flowNoFile;//流水文件路径
        private static bool _isWeigh; //是否是称重
        #region 双屏属性
        public static short DoubleColorBlue = 240;
        public static short DoubleColorGreen = 240;
        public static short DoubleColorRed = 240;
        public static int DoubleSetheight = 600;// 双屏高
        public static int DoubleSetwidth = 800; // 双屏宽
        public static bool IsDoubleSetwh = false;

        private static string _isDouble = ExtendUtility.Instance.ParseToString(ConfigurationManager.AppSettings["isDouble"]); //流水ID
        private static bool _isDoubleModule = false;//开启双屏标记
        private static string _adUrl = string.Empty;

        public static string LoggerName = "MsmkLogger";

        public static string adUrl
        {
            get
            {
                return _adUrl;
            }
            set
            {
                _adUrl = value;
            }
        }
        #endregion
        private static int _pendingOrderMaxNo = 10;//最大挂单数
        private static bool _isRecordPosAccount = true;//自动记录对帐信息


        public static String ITEM_DB_FILE = Application.StartupPath + @"\item.db";
        public static String SALE_DB_FILE = Application.StartupPath + @"\sale.db";

        public static string ITEM_DB_FILE_NAME = GobalStaticString.SQLITE_DB_STRING.Replace("%path%", Application.StartupPath + @"\item.db");
        public static string SALE_DB_ITEM_NAME = GobalStaticString.SQLITE_DB_STRING.Replace("%path%", Application.StartupPath + @"\sale.db");

        private static Dictionary<String, String> _usedDicKeyTags = new Dictionary<string, string>();

        public static string BranchName
        {
            get
            {
                return _branchName;
            }
            set
            {
                _branchName = value;
            }
        }
        private static string _server = "127.0.0.1";
        
        
        
        public static string Server
        {
            get { return _server; }
            set { _server = value; }
        }
        private static string _user = "root";
        
        
        
        public static string User
        {
            get { return _user; }
            set { _user = value; }
        }
        private static string _password = "root";
        
        
        
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private static string _database = "icepos";
        
        
        
        public static string Database
        {
            get { return _database; }
            set { _database = value; }
        }
        
        
        
        public static string CONNECT_STRING
        {
            get { return GobalStaticString.MYSQL_DB_STRING.Replace("%server%", Server).Replace("%user%", User).Replace("%password%", Password).Replace("%database%", Database); }
        }
        
        
        
        public static Dictionary<String, String> UsedDicKeyTag
        {
            get
            {
                return _usedDicKeyTags;
            }
            set
            {
                _usedDicKeyTags = value;
            }
        }

        private static Dictionary<String, PosOpType> _dicPosOpType = new Dictionary<string, PosOpType>();
        
        
        
        public static Dictionary<String, PosOpType> DicPosOpType
        {
            get
            {

                return _dicPosOpType;
            }
            set
            {
                _dicPosOpType = value;
            }
        }
        private static string _applicationXml = "Application.xml";
        
        
        
        public static string ApplicationXml
        {
            get
            {
                return _applicationXml;
            }
            set
            {
                _applicationXml = value;
            }
        }
        
        
        
        public static String NetStatus
        {
            get
            {
                return _net_status;
            }
            set
            {
                _net_status = value;
            }
        }
        private static String _PayHtml;
        
        
        
        public static String PayHtml
        {
            set
            {
                _PayHtml = value;
            }
            get
            {
                return _PayHtml;
            }
        }
        
        
        
        private static String _memberServiceUri = ConfigurationManager.AppSettings["memberUrl"];
        
        
        
        public static String MemberServiceUri
        {
            get
            {
                return _memberServiceUri;
            }
            set
            {
                _memberServiceUri = value;
            }
        }

        private static String _useToken = "de9b968de5ba6c10f683661a3a7fe18ac5946ed4";
        
        
        
        public static String UseToken
        {
            get
            {
                return _useToken;
            }
            set
            {
                _useToken = value;
            }
        }
        private static String _serviceWay = "POS";
        
        
        
        public static String ServiceWay
        {
            get
            {
                return _serviceWay;
            }
            set
            {
                _serviceWay = value;
            }
        }
        
        
        
        public static bool IsConnectonServer
        {
            get { return Gattr._isConnectonServer; }
            set { Gattr._isConnectonServer = value; }
        }
        
        
        
        public static string BranchNo
        {
            get { return Gattr._branchNo; }
            set { Gattr._branchNo = value; }
        }
        
        
        
        public static string HttpAddress
        {
            get { return Gattr._httpAddress; }
            set { Gattr._httpAddress = value; }
        }
        
        
        
        
        public static string WebPosServicePath
        {
            get { return Gattr._webPosServicePath; }
            set { Gattr._webPosServicePath = value; }
        }
        
        
        
        public static string PosId
        {
            get { return Gattr._posId; }
            set { Gattr._posId = value; }
        }
        
        
        
        public static string PortName
        {
            get { return Gattr._PortName; }
            set { Gattr._PortName = value; }
        }
        
        
        
        public static string PortType
        {
            get { return Gattr._PortType; }
            set { Gattr._PortType = value; }
        }
        
        
        
        public static string PosPort
        {
            get { return Gattr._posPort; }
            set { Gattr._posPort = value; }
        }
        
        
        
        public static string PosModel
        {
            get { return Gattr._posModel; }
            set { Gattr._posModel = value; }
        }
        
        
        
        public static ServerBll ServerBll
        {
            get { return Gattr._serverBll; }
        }
        
        
        
        public static int PrtLen
        {
            get { return Gattr._prtLen; }
            set { Gattr._prtLen = value; }
        }
        
        
        
        public static bool IsTotRollBack
        {
            get { return _isTotRollBack; }
            set { _isTotRollBack = value; }
        }

        
        
        
        public static PosBll Bll
        {
            get
            {
                return _bll;
            }
        }
        
        
        
        public static string PosSaleNumPoint
        {
            get
            {
                return _posSaleNumPoint;
            }
            set
            {
                _posSaleNumPoint = value;
            }
        }
        
        
        
        public static string PosSalePrcPoint
        {
            get
            {
                return _posSalePrcPoint;
            }
            set
            {
                _posSalePrcPoint = value;
            }
        }
        
        
        
        public static string PosSaleAmtPoint
        {
            get
            {
                return _posSaleAmtPoint;
            }
            set
            {
                _posSaleAmtPoint = value;
            }
        }
        
        
        
        public static Dictionary<string, t_attr_function> FunKeys
        {
            get
            {
                return _FunKeys;
            }
            set
            {
                _FunKeys = value;
            }
        }
        
        
        
        public static string OperId
        {
            get { return Gattr._operId; }
            set { Gattr._operId = value; }
        }
        
        
        
        public static string Oper_flag
        {
            get { return Gattr._oper_flag; }
            set { Gattr._oper_flag = value; }
        }
        
        
        
        public static string OperPwd
        {
            get { return Gattr._operPwd; }
            set { Gattr._operPwd = value; }
        }
        private static string _operGrant;
        
        
        
        public static string OperGrant
        {
            get { return Gattr._operGrant; }
            set { Gattr._operGrant = value; }
        }
        private static Decimal _operDiscount;
        
        
        
        public static Decimal OperDiscount
        {
            get { return Gattr._operDiscount; }
            set { Gattr._operDiscount = value; }
        }
        
        
        
        public static string CheckStandId
        {
            get { return Gattr._checkStandId; }
            set { Gattr._checkStandId = value; }
        }
        
        
        
        public static string OperFullName
        {
            get { return Gattr._operFullName; }
            set { Gattr._operFullName = value; }
        }
        
        
        
        public static PosPrint PosPrinter
        {
            get
            {
                return _posPrinter;
            }
        }
        
        
        
        public static int NumHeaderNL
        {
            get { return Gattr._numHeaderNL; }
            set { Gattr._numHeaderNL = value; }
        }
        
        
        
        public static string AppTitle
        {
            get { return Gattr._appTitle; }
            set { Gattr._appTitle = value; }
        }

        public static string SystemTitle
        {
            get { return Gattr._systemTitle; }
            set { Gattr._systemTitle = value; }
        }

        public static string NetworkName
        {
            get { return Gattr._networkName; }
            set { Gattr._networkName = value; }
        }
        
        public static string TextFile
        {
            get { return Gattr._textFile; }
            set { Gattr._textFile = value; }
        }
        
        
        
        public static string MyHelp
        {
            get { return Gattr._myHelp; }
            set { Gattr._myHelp = value; }
        }
        
        
        
        public static string BillFile
        {
            get { return Gattr._billFile; }
            set { Gattr._billFile = value; }
        }
        
        
        
        public static bool IsBillPrintLog
        {
            get { return Gattr._isBillPrintLog; }
            set { Gattr._isBillPrintLog = value; }
        }

        
        
        
        public static string ErrMsg
        {
            get { return Gattr._errMsg; }
            set { Gattr._errMsg = value; }
        }

        private static string dateFormat = "yyyy-MM-dd HH:mm:ss";
        
        
        
        public static string DateFormat
        {
            get { return Gattr.dateFormat; }
            set { Gattr.dateFormat = value; }
        }
        private static string stampFormat = "yyyy-MM-dd HH:mm:ss.fff";
        
        
        
        public static string StampFormat
        {
            get { return Gattr.stampFormat; }
            set { Gattr.stampFormat = value; }
        }
        public static string PosSalePrcPointF
        {
            get { return Gattr._posSalePrcPointF; }
            set { Gattr._posSalePrcPointF = value; }
        }
        public static string PosSaleNumPointF
        {
            get { return Gattr._posSaleNumPointF; }
            set { Gattr._posSaleNumPointF = value; }
        }
        
        
        
        public static int FlowNo
        {
            get { return Gattr._flowNo; }
            set { Gattr._flowNo = value; }
        }
        
        
        
        public static string FlowNoFile
        {
            get { return Gattr._flowNoFile; }
            set { Gattr._flowNoFile = value; }
        }
        
        
        
        public static bool IsWeigh
        {
            get { return Gattr._isWeigh; }
            set { Gattr._isWeigh = value; }
        }
        
        
        
        public static int PendingOrderMaxNo
        {
            get
            {
                return _pendingOrderMaxNo;
            }
            set
            {
                _pendingOrderMaxNo = value;
            }
        }
        
        
        
        public static bool IsDoubleModule
        {
            get
            {
                if (_isDouble == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //set { Gattr._isDoubleModule = value; }
        }
        
        
        
        public static bool IsRecordPosAccount
        {
            get { return Gattr._isRecordPosAccount; }
            set { Gattr._isRecordPosAccount = value; }
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

        private static string _serverUrl = ConfigurationManager.AppSettings["serviceUrl"]; 
        
        
        
        public static string serverUrl
        {
            get { return _serverUrl; }
            set { _serverUrl = value; }
        }
        private static string _oper_pwd;
        
        
        
        public static string Oper_Pwd
        {
            get { return _oper_pwd; }
            set { _oper_pwd = value; }
        }
        
        
        
        public static string DB_FILE_PATH = AppDomain.CurrentDomain.BaseDirectory + "DBSQLite/sql/";
        
        
        
        public static string LAST_UPDATE_TIME = System.DateTime.Now.Year + "-01-01";
        
        
        
        public static string INI_FILE_PATH = AppDomain.CurrentDomain.BaseDirectory + "ICEPOS.ini";
    }
}
