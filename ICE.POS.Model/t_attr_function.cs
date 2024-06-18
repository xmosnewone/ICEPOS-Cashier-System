namespace ICE.POS.Model
{
    using System;
    
    
    
    [Serializable]
    public class t_attr_function
    {
        private string _flag;
        private string _func_id;
        private string _func_name;
        private string _func_udname;
        private string _memo;
        private string _pos_key;
        private char _type;

        public string flag
        {
            get
            {
                return this._flag;
            }
            set
            {
                this._flag = value;
            }
        }

        public string func_id
        {
            get
            {
                return this._func_id;
            }
            set
            {
                this._func_id = value;
            }
        }

        public string func_name
        {
            get
            {
                return this._func_name;
            }
            set
            {
                this._func_name = value;
            }
        }

        public string func_udname
        {
            get
            {
                return this._func_udname;
            }
            set
            {
                this._func_udname = value;
            }
        }

        public string memo
        {
            get
            {
                return this._memo;
            }
            set
            {
                this._memo = value;
            }
        }

        public string pos_key
        {
            get
            {
                return this._pos_key;
            }
            set
            {
                this._pos_key = value;
            }
        }

        public char type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}

