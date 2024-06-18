/********************************************************
 * Description:POS促销规则校验参数实体
 * ******************************************************/
namespace ICE.POS.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    
    
    public class CheckPara
    {
        private string _check_type = "ALL";
        
        
        
        public string check_type
        {
            get { return _check_type; }
            set { _check_type = value; }
        }
        private string _type_val = "";
        
        
        
        public string type_val
        {
            get { return _type_val; }
            set { _type_val = value; }
        }
        private string _check_operator = "";
        
        
        
        public string check_operator
        {
            get { return _check_operator; }
            set { _check_operator = value; }
        }
        private decimal _throld = 0M;
        
        
        
        public decimal throld
        {
            get { return _throld; }
            set { _throld = value; }
        }
        private bool _isAmt = false;
        
        
        
        public bool isAmt
        {
            get { return _isAmt; }
            set { _isAmt = value; }
        }
        private bool _isQty = false;
        
        
        
        public bool isQty
        {
            get { return _isQty; }
            set { _isQty = value; }
        }
    }
}
