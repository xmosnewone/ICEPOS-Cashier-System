namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public partial class t_base_code
    {
        public t_base_code()
        { }
        #region Model
        private string _type_no;
        private string _code_id;
        private string _code_name;
        private string _english_name;
        private string _code_type;
        private string _memo;
        
        
        
        public string type_no
        {
            set { _type_no = value; }
            get { return _type_no; }
        }
        
        
        
        public string code_id
        {
            set { _code_id = value; }
            get { return _code_id; }
        }
        
        
        
        public string code_name
        {
            set { _code_name = value; }
            get { return _code_name; }
        }
        
        
        
        public string english_name
        {
            set { _english_name = value; }
            get { return _english_name; }
        }
        
        
        
        public string code_type
        {
            set { _code_type = value; }
            get { return _code_type; }
        }
        
        
        
        public string memo
        {
            set { _memo = value; }
            get { return _memo; }
        }
        #endregion Model
    }
}
