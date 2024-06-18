namespace ICE.POS.Common
{
    using Microsoft.Win32;
    using System;
    using System.ComponentModel;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class TextBoxEx : TextBox
    {
        private int _byteCount;
        private int _textType;
        private IContainer components;

        public TextBoxEx()
        {
            this._byteCount = 0x4e20;
            this.InitializeComponent();
        }

        public TextBoxEx(IContainer container)
        {
            this._byteCount = 0x4e20;
            container.Add(this);
            this.InitializeComponent();
            bool flag = false;
            if (!Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion").GetValue("ProductName").ToString().Contains("Windows XP"))
            {
                goto Label_00C7;
            }
            using (RegistryKey key2 = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\NET Framework Setup\NDP", false))
            {
                if (key2 != null)
                {
                    foreach (string str2 in key2.GetSubKeyNames())
                    {
                        if (((str2.Length >= 2) && !str2.Equals("CDF")) && (Convert.ToInt32(str2.Substring(1, 1)) > 2))
                        {
                            flag = true;
                            goto Label_00BD;
                        }
                    }
                }
            }
        Label_00BD:
            if (!flag)
            {
                base.ImeMode = ImeMode.Off;
            }
        Label_00C7:
            base.KeyPress += new KeyPressEventHandler(this.TextBoxEx_KeyPress);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
        }

        private void TextBoxEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = this.Text.Substring(0, base.SelectionStart) + e.KeyChar.ToString() + this.Text.Substring(base.SelectionStart + this.SelectionLength, (this.Text.Length - base.SelectionStart) - this.SelectionLength);
            if ((e.KeyChar != Keys.Back.GetHashCode()) && (Encoding.Default.GetByteCount(s) > this._byteCount))
            {
                e.Handled = true;
            }
            else if (e.KeyChar != '\b')
            {
                switch (this._textType)
                {
                    case 0:
                        return;

                    case 1:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('-'))
                            {
                                if (this.Text == string.Empty)
                                {
                                    e.Handled = true;
                                }
                                if (this.Text.IndexOf("-") > 0)
                                {
                                    e.Handled = true;
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^-?\d+$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 2:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int index = s.IndexOf(".");
                                if (index >= 0)
                                {
                                    s.IndexOf(".", (int) (index + 1));
                                    if (s.IndexOf(".", (int) (index + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^[-+]?[0-9]+(\.[0-9]+)?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 3:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('-'))
                            {
                                if (this.Text != string.Empty)
                                {
                                    e.Handled = true;
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^-\d+$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 4:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int num2 = s.IndexOf(".");
                                if (num2 >= 0)
                                {
                                    s.IndexOf(".", (int) (num2 + 1));
                                    if (s.IndexOf(".", (int) (num2 + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s + e.KeyChar.ToString(), @"^[-+]?[0-9]+(\.[0-9]+)?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 5:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (!Regex.Match(s, "^[A-Za-z0-9]+$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 6:
                        if (!e.KeyChar.Equals('.'))
                        {
                            if (!Regex.Match(s, @"^(0([\.]\d*[0-9])+|0|1)$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        if (this.Text == string.Empty)
                        {
                            e.Handled = true;
                        }
                        if (this.Text.IndexOf(".") > 0)
                        {
                            e.Handled = true;
                        }
                        return;

                    case 7:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int num3 = s.IndexOf(".");
                                if (num3 >= 0)
                                {
                                    s.IndexOf(".", (int) (num3 + 1));
                                    if (s.IndexOf(".", (int) (num3 + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^(-?\d{0,8})(\.\d{0,2})?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 8:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int num4 = s.IndexOf(".");
                                if (num4 >= 0)
                                {
                                    s.IndexOf(".", (int) (num4 + 1));
                                    if (s.IndexOf(".", (int) (num4 + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^(-?\d{0,1})(\.\d{0,2})?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 9:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int num5 = s.IndexOf(".");
                                if (num5 >= 0)
                                {
                                    s.IndexOf(".", (int) (num5 + 1));
                                    if (s.IndexOf(".", (int) (num5 + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^(-?\d{0,12})(\.\d{0,4})?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 10:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int num6 = s.IndexOf(".");
                                if (num6 >= 0)
                                {
                                    s.IndexOf(".", (int) (num6 + 1));
                                    if (s.IndexOf(".", (int) (num6 + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^(-?\d{0,2})(\.\d{0,2})?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 11:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int num7 = s.IndexOf(".");
                                if (num7 >= 0)
                                {
                                    s.IndexOf(".", (int) (num7 + 1));
                                    if (s.IndexOf(".", (int) (num7 + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^(-?\d{0,4})(\.\d{0,2})?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;

                    case 12:
                        if (e.KeyChar <= '\x0080')
                        {
                            if (e.KeyChar.Equals('.'))
                            {
                                if (s == e.KeyChar.ToString())
                                {
                                    e.Handled = true;
                                }
                                int num8 = s.IndexOf(".");
                                if (num8 >= 0)
                                {
                                    s.IndexOf(".", (int) (num8 + 1));
                                    if (s.IndexOf(".", (int) (num8 + 1)) > 0)
                                    {
                                        e.Handled = true;
                                    }
                                }
                                return;
                            }
                            if (!Regex.Match(s, @"^(-?\d{0,6})(\.\d{0,2})?$").Success)
                            {
                                e.Handled = true;
                            }
                            return;
                        }
                        e.Handled = true;
                        return;
                }
            }
        }

        [Description("字节长度"), DefaultValue(0x4e20)]
        public int ByteCount
        {
            get
            {
                return this._byteCount;
            }
            set
            {
                this._byteCount = value;
            }
        }

        public DateTime? DataTimeValue
        {
            get
            {
                DateTime time;
                if (DateTime.TryParse(this.Text.Trim(), out time))
                {
                    return new DateTime?(time);
                }
                return null;
            }
        }

        public decimal DecValue
        {
            get
            {
                decimal result = 0M;
                if (decimal.TryParse(this.Text.Trim(), out result))
                {
                    return result;
                }
                return result;
            }
        }

        public int IntValue
        {
            get
            {
                int num;
                if (int.TryParse(this.Text.Trim(), out num))
                {
                    return num;
                }
                return num;
            }
        }

        [Description("0 全部（默认） 1 整数 2 小数 3 负整数 4 负小数 5 非特殊字符 6 0-1之间的小数 7 numeric(10, 2) 8 numeric(3, 2) 9 numeric(16, 4) 10 numeric(4, 2) 11 numeric(6, 2) 12 numeric(8, 2)"), DefaultValue(0)]
        public int TextType
        {
            get
            {
                return this._textType;
            }
            set
            {
                this._textType = value;
            }
        }
    }
}

