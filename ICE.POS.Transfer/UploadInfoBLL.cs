namespace ICE.POS.Transfer
{
    using System;
    using System.Data;
   
    public class UploadInfoBLL
    {
        #region 单例模式
        private static object lockobj = new object();
        private static UploadInfoBLL _instance = null;
        private UploadInfoBLL()
        { }
        public static UploadInfoBLL Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new UploadInfoBLL();
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion
        #region  公共方法
        
        public DataTable GetUploadPayNo(String connectinString)
        {
            return UploadInfoDAL.GetUploadPayNo(connectinString);
        }
        
        public DataTable GetUploadPayInfoByFlowNo(String connectionString, String flowno)
        {
            return UploadInfoDAL.GetUploadPayInfoByFlowNo(connectionString, flowno);
        }
        
        
        public DataTable GetUploadSaleInfoByFlowNo(String connectionString, String flowno)
        {
            return UploadInfoDAL.GetUploadSaleInfoByFlowNo(connectionString, flowno);
        }

        
        public bool UpdateFlowComFlag(String connectionString, String flowno)
        {
            return UploadInfoDAL.UpdateFlowComFlag(connectionString, flowno);
        }
        
        
        public DataTable GetNoneUploadMember(String connectionString)
        {
            return UploadInfoDAL.GetNonUploadMember(connectionString);
        }

        public bool UpdateUploadMember(String connectionString, String flowno, String cardno, String over_flag, String com_flag)
        {
            return UploadInfoDAL.UpdateUploadMember(connectionString, flowno, cardno, over_flag, com_flag);
        }
        
        public DataTable GetUploadAccount(String connectionString)
        {
            return UploadInfoDAL.GetUploadAccount(connectionString);
        }
        
        public bool UpdateAccountFlag(String connectionString, String flow_id)
        {
            return UploadInfoDAL.UpdateAccountFlag(connectionString, flow_id);
        }

        public  DataTable GetUploadVip(String connectionString)
        {
            return UploadInfoDAL.GetUploadVip(connectionString);
        }
        
        public  bool UpdateVipFlag(String connectionString, String flow_no, String card_no)
        {
            return UploadInfoDAL.UpdateVipFlag(connectionString, flow_no, card_no);
        }
        #endregion
    }
}
