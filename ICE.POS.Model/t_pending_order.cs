namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public class t_pending_order
    {

        private string _flow_no = "";
        private string _sale_man = "";
        private string _pending_type = "";
        private string _vip_no = "";

       
        public string flow_no
        {
            get { return _flow_no; }
            set { _flow_no = value; }
        }

        public string sale_man
        {
            get { return _sale_man; }
            set { _sale_man = value; }
        }

        public string pending_type
        {
            get { return _pending_type; }
            set { _pending_type = value; }
        }

        public string vip_no
        {
            get { return _vip_no; }
            set { _vip_no = value; }
        }

    }
}
