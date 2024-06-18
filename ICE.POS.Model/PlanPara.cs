/********************************************************
 * Description:POS促销规则参数实体
 * ******************************************************/
using System.Collections.Generic;
namespace ICE.POS.Model
{
    
    public class PlanPara
    {
        
        private string _planNo = "";
        
        
        private string _row_id = "";
        
        
        private string _typeNo = "ALL";
        
        
        private bool _isN = false;
        
        
        private bool _isAnd = false;
        private string _typeValue = "";
        
        
        
        public string typeValue
        {
            get { return _typeValue; }
            set { _typeValue = value; }
        }
        
        
        
        public string planNo
        {
            get { return _planNo; }
            set { _planNo = value; }
        }
        
        
        
        public string row_id
        {
            get { return _row_id; }
            set { _row_id = value; }
        }
        
        
        
        public string typeNo
        {
            get { return _typeNo; }
            set { _typeNo = value; }
        }
        
        
        
        public bool isAnd
        {
            get { return _isAnd; }
            set { _isAnd = value; }
        }
        
        
        
        public bool isN
        {
            get { return _isN; }
            set { _isN = value; }
        }
        private List<CheckPara> _checkParas;
        
        
        
        public List<CheckPara> CheckParas
        {
            get { return _checkParas; }
            set { _checkParas = value; }
        }
        private List<CheckPara> _resultParas;
        
        
        
        public List<CheckPara> ResultParas
        {
            get { return _resultParas; }
            set { _resultParas = value; }
        }
        public List<CheckPara> _addPara;
        
        
        
        public List<CheckPara> AddPara
        {
            get { return _addPara; }
            set { _addPara = value; }
        }
        private PlanRule _planRule;
        
        
        
        public PlanRule PlanRule
        {
            get
            {
                return _planRule;
            }
            set {
                _planRule = value;
            }
        }
    }
}
