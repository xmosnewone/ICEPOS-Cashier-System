using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.POS.Model
{
    public class Alipay_model
    {
        //返回代码
        private String _code;
        public String code
        {
            set
            {
                _code=value;
            }
            get
            {
                return _code;
            }
        }
        //数据信息
        private Alipay_model_data _data;
        
        
        
        public Alipay_model_data data
        {
            set{
                _data=value;
            }
            get
            {
                return _data;
            }
        }
    }
    public class Alipay_model_data
    {
        private String _is_success;
        public String is_success
        {
            set
            {
                _is_success=value;
            }
            get
            {
                return _is_success;
            }
        }
    }
}
