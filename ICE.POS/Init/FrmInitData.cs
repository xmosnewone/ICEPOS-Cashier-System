namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.Utility;
    using ICE.Common;

    /// <summary>
    /// 初始化系统应用环境窗体
    /// </summary>
    public partial class FrmInitData : Form
    {
        #region 窗体全局声名
        private string _serverUrl = string.Empty;
        /// <summary>
        /// 访问URL或者IP
        /// </summary>
        private string ServerUrl
        {
            get { return _serverUrl; }
            set { _serverUrl = value; }
        }
        #endregion
        #region 窗体构造
        public FrmInitData()
        {
            InitializeComponent();
            if (this.txtServerUrl.Text.Trim().Length == 0)
            {
                this.txtServerUrl.Text = Gattr.serverUrl;
            }
        }
        public FrmInitData(bool isReset)
        {
            InitializeComponent();
            if (this.txtServerUrl.Text.Trim().Length == 0)
            {
                this.txtServerUrl.Text = Gattr.serverUrl;
            }
        }
        #endregion
        #region 事件逻辑
        /// <summary>
        /// 连接测试按钮事件逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                ButtonEx btn = sender as ButtonEx;
                switch (btn.Tag.ToString())
                {
                    case "ok"://完成按钮事件逻辑
                        btnOk.Enabled = false;
                        //TODO:完成

                        try {
                            ListItem item1 = cbbBranch.SelectedItem as ListItem;
                            String selectedItem = SIString.TryStr(item1.Key);
                            String branch_no = StringUtility.Instance.StringTrim(selectedItem);
                            ListItem item2 = cbbPOS.SelectedItem as ListItem;
                            String selectedItem2 = SIString.TryStr(item2.Key);
                            String pos_no = StringUtility.Instance.StringTrim(selectedItem2);

                            if (ValidatePos(branch_no, pos_no))
                            {
                                String path = Application.StartupPath + @"\" + Gattr.ApplicationXml;
                                Dictionary<String, Object> _dic = new Dictionary<string, Object>();
                                ServerUrl = this.txtServerUrl.Text.Trim();
                                _dic.Add("ServerUrl", ServerUrl);
                                _dic.Add("BranchNo", branch_no);
                                _dic.Add("PosId", pos_no);
                                XMLUtility.Instance.WriteXmlFile(path, _dic, "applicationConfig");
                                DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                btnOk.Enabled = true;
                            }
                        }
                        catch (Exception) {
                            MessageBox.Show("请选择门店和POS机或在管理后台添加POS机信息");
                            btnOk.Enabled = true;
                        }
                        
                        break;
                    case "ca"://取消按钮事件逻辑
                        DialogResult = DialogResult.Cancel;
                        break;
                    default: //连接按钮事件逻辑
                        Gattr.serverUrl = this.txtServerUrl.Text.Trim();
                        btnOk.Enabled = false;
                        cbbBranch.Items.Clear();
                        cbbPOS.Items.Clear();
                        //InvokeMethod("GetBranchList", string.Empty);
                        GetBranchInfo();
                        break;
                }
            }
        }
        /// <summary>
        /// 验证当前选择的POS的信息
        /// </summary>
        /// <param name="branch_no"></param>
        /// <param name="posid"></param>
        /// <returns></returns>
        private bool ValidatePos(string branch_no, string posid)
        {
            string errorMessage = string.Empty;
            if (!PosServericeBll.Instance.ValidatePos(branch_no, posid, ref errorMessage))
            {
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, Gattr.AppTitle);
                }
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, Gattr.AppTitle);
                }
                return true;
            }
            //bool isok = false;
            //try
            //{
            //    string mac = ComputerUtility.Instance.GetMacAddress();
            //    string disk = ComputerUtility.Instance.GetDiskVolumeSerialNumber();
            //    if (disk == ICE.Common.GobalStaticString.UN_KNOWN_DISK || string.IsNullOrEmpty(disk))
            //    {
            //        MessageBox.Show("获取机器信息失败", Gattr.AppTitle);
            //        return false;
            //    }
            //    string hostname = System.Environment.MachineName;
            //    Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
            //    _dic.Add("hostname", hostname);
            //    _dic.Add("hostmac", mac);
            //    _dic.Add("hostdisk", disk);
            //    _dic.Add("branch_no", branch_no);
            //    _dic.Add("posid", posid);
            //    bool isok1 = true;
            //    string errorMessage = string.Empty;
            //    string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Validpos", _dic, ref isok1, ref errorMessage);
            //    if (isok1)
            //    {
            //        if (result != "-10" && result != "-20")
            //        {
            //            switch (result)
            //            {
            //                case "0":
            //                    isok = true;
            //                    break;
            //                case "1":
            //                    MessageBox.Show("注册成功", Gattr.AppTitle);
            //                    isok = true;
            //                    break;
            //                case "2":
            //                    MessageBox.Show("该机器已注册其他POS机", Gattr.AppTitle);
            //                    break;
            //                case "3":
            //                    MessageBox.Show("该POS机已被其他机器注册", Gattr.AppTitle);
            //                    break;
            //                case "-2":
            //                case "-1":
            //                default:
            //                    MessageBox.Show("注册/验证失败" + result, Gattr.AppTitle);
            //                    foreach (KeyValuePair<string, object> _kv in _dic)
            //                    {
            //                        LoggerHelper.Log("MsmkLogger", "ICE.POS->Init->FrmInitData->ValidatePos->Exception:Key" + _kv.Key + ",Value:" + _kv.Value, LogEnum.ExceptionLog);
            //                    }
            //                    break;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("注册/验证POS机失败", Gattr.AppTitle);
            //        LoggerHelper.Log("MsmkLogger", "ICE.POS->Init->FrmInitData->ValidatePos->Exception:" + errorMessage, LogEnum.ExceptionLog);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("注册/验证POS机失败", Gattr.AppTitle);
            //    LoggerHelper.Log("MsmkLogger", "ICE.POS->Init->FrmInitData->ValidatePos->Exception:" + ex.ToString(), LogEnum.ExceptionLog);
            //}
            //return isok;
        }
        /// <summary>
        /// 门店选择事件逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO:加载门店下POS机信息.
            //String selectedValue = SIString.TryStr(cbbBranch.SelectedValue);
            //InvokeMethod("GetPosStatus", selectedValue);
            cbbPOS.Items.Clear();
            ListItem item = cbbBranch.SelectedItem as ListItem;
            //InvokeMethod("GetPosStatus", item.Key);
            GetPosStatus(item.Key);
        }
        #endregion
        #region 界面私有方法
        void GetBranchInfo()
        {
            try
            {
                Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                string errorMessage = string.Empty;
                bool isok = true;
                string json = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Getbrninfo", _dic, ref isok, ref errorMessage);
                if (isok)
                {
                    if (!string.IsNullOrEmpty(json))
                    {
                        if (json != "-10" && json != "-20")
                        {
                            DataTable table = JsonUtility.Instance.JsonToDataTable(json);
                            if (table != null && table.Rows.Count > 0)
                            {
                                cbbBranch.Items.Clear();
                                foreach (DataRow dr in table.Rows)
                                {
                                    string property = ExtendUtility.Instance.ParseToString(dr["property"]);
                                    if (property == "0")
                                    {
                                        ListItem item = new ListItem(SIString.TryStr(dr["branch_no"]), "[" + SIString.TryStr(dr["branch_no"]) + "]" + SIString.TryStr(dr["branch_name"]));
                                        cbbBranch.Items.Add(item);
                                    }
                                }
                                cbbBranch.SelectedIndex = 0;
                                ListItem item1 = cbbBranch.SelectedItem as ListItem;
                                String selectedItem = SIString.TryStr(item1.Key);
                                GetPosStatus(selectedItem);
                                btnOk.Enabled = true;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, Gattr.AppTitle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接失败", Gattr.AppTitle);
                LoggerHelper.Log("MsmkLogger", ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        void GetPosStatus(String branch_no)
        {
            try
            {
                Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                _dic.Add("branch_no", branch_no);
                string errorMessage = string.Empty;
                bool isok = true;
                string json = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Getposstatus", _dic, ref isok, ref errorMessage);
                if (isok)
                {
                    if (!string.IsNullOrEmpty(json))
                    {
                        if (json != "-10" && json != "-20")
                        {
                            DataTable table = JsonUtility.Instance.JsonToDataTable(json);
                            if (table != null && table.Rows.Count > 0)
                            {
                                cbbPOS.Items.Clear();
                                if (table != null && table.Rows.Count > 0)
                                {
                                    foreach (DataRow dr in table.Rows)
                                    {
                                        ListItem item = new ListItem(SIString.TryStr(dr["posid"]), "[" + SIString.TryStr(dr["posid"]) + "]" + SIString.TryStr(dr["posid"]));
                                        cbbPOS.Items.Add(item);
                                    }
                                    cbbPOS.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, Gattr.AppTitle);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", ex.ToString(), LogEnum.ExceptionLog);
            }
        }




        /// <summary>
        /// 根据不同的方法参数执行不同的方法参数
        /// </summary>
        /// <param name="mark"></param>
        void InvokeMethod(String mark, String branch_no)
        {
            //if (this.txtServerUrl.Text.Trim().Length == 0 && mark != "GetPosStatusList")
            //{
            //    MessageBox.Show("服务器地址不能为空", Gattr.AppTitle);
            //}
            //else
            //{
            bool isok = true;
            //this.ServerUrl = this.txtServerUrl.Text.Trim();
            object obj = null;
            DataTable table = null;

            try
            {
                //obj = BaseInfoService.Instance.InvokeService(this.txtServerUrl.Text.Trim(), Gattr.WebPosServicePath, mark, ref isok, parameter);
                branch_no = branch_no == string.Empty ? Gattr.BranchNo : branch_no;
                obj = PosDownServiceProvider.Instance.InvokeService(Gattr.CONNECT_STRING, mark, ref isok, branch_no, "", 0, "");
                if (isok)
                {
                    table = (DataTable)obj;
                    if (mark == "GetBranchList")
                    {
                        cbbBranch.Items.Clear();
                        foreach (DataRow dr in table.Rows)
                        {
                            ListItem item = new ListItem(SIString.TryStr(dr["branch_no"]), "[" + SIString.TryStr(dr["branch_no"]) + "]" + SIString.TryStr(dr["branch_name"]));
                            cbbBranch.Items.Add(item);
                        }
                        cbbBranch.SelectedIndex = 0;
                        ListItem item1 = cbbBranch.SelectedItem as ListItem;
                        String selectedItem = SIString.TryStr(item1.Key);
                        InvokeMethod("GetPosStatus", selectedItem);
                        MessageBox.Show("连接成功", Gattr.AppTitle);
                        btnOk.Enabled = true;
                    }
                    else
                    {
                        cbbPOS.Items.Clear();
                        if (table != null && table.Rows.Count > 0)
                        {
                            foreach (DataRow dr in table.Rows)
                            {
                                ListItem item = new ListItem(SIString.TryStr(dr["posid"]), "[" + SIString.TryStr(dr["posid"]) + "]" + SIString.TryStr(dr["posid"]));
                                cbbPOS.Items.Add(item);
                            }
                            cbbPOS.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", ex.ToString(), LogEnum.ExceptionLog);
            }
            // }
        }
        #endregion

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
