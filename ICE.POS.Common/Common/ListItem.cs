namespace ICE.POS.Common
{
    public class ListItem
    {
        private string _key = string.Empty;
        private string _value = string.Empty;

        public ListItem(string key, string value)
        {
            this._key = key;
            this._value = value;
        }

        public override string ToString()
        {
            return this._value;
        }

        public string Key
        {
            get
            {
                return this._key;
            }
        }

        public string Value
        {
            get
            {
                return this._value;
            }
        }
    }
}
