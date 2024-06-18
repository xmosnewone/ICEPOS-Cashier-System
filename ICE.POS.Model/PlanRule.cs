/********************************************************
 * Description:POS促销规则实体
 * ******************************************************/
namespace ICE.POS.Model
{
    
    
    
    public class PlanRule
    {
        
        
        
        private string _ruleno;
        
        
        
        private string _range_flag;
        
        
        
        private string _rule_conditon;
        
        
        
        private string _rule_result;
        
        
        
        public string rule_no
        {
            get { return _ruleno; }
            set { _ruleno = value; }
        }
        
        
        
        public string range_flag
        {
            get { return _range_flag; }
            set { _range_flag = value; }
        }
        
        
        
        public string rule_condition
        {
            get { return _rule_conditon; }
            set { _rule_conditon = value; }
        }
        
        
        
        public string rule_result
        {
            get { return _rule_result; }
            set { _rule_result = value; }
        }
    }
}
