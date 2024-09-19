namespace ICE.POS.Transfer
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.Utility;
    using ICE.POS.Model;
    
    
    
    public partial class FormMain : Form
    {
        const int WM_SYSCOMMAND = 0x112;
        const int SC_CLOSE = 0xF060;
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030;
        #region 全局声名
        
        
        
        bool windowCreate = true;
        
        
        
        Thread currentThread = null;
        
        
        
        bool isWork = false;

        bool DealerAccountWork = true;//收银员对账记录错误后暂停
        bool DealerDataWork = true;//上传支付和商品销售流水出现错误后暂停
        bool DealerVipWork = true;//上传VIP消费记录出现错误后暂停
        #endregion
        #region 构造函数
        public FormMain()
        {
            InitializeComponent();
            Load += new EventHandler(FormMain_Load);
        }
        #endregion
        
        
        
        
        
        void FormMain_Load(object sender, EventArgs e)
        {
            InitControl();
            InitData();
        }
        #region 窗体事件逻辑
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam.ToInt32() == SC_MINIMIZE)
                {
                    windowCreate = false;
                    Visible = false;
                    Hide();
                    ShowInTaskbar = false;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        
        
        
        
        
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ShowOrHide();
            }
        }
        
        
        
        
        
        private void btnLog_Click(object sender, EventArgs e)
        {
            String _path = AppDomain.CurrentDomain.BaseDirectory + GlobalSet.appinifile;
            String _setfolder = "transferlog";
            String _settimespan = WindowsAPIUtility.GetLocalSysParam("posset", "transfer_folder", _setfolder, _path);
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + _settimespan);
        }
        
        
        
        
        
        private void btnDeal_Click(object sender, EventArgs e)
        {
            btnDeal.Enabled = false;
            isWork = false;
            if (currentThread != null && currentThread.ThreadState == System.Threading.ThreadState.Running)
            {
                MessageBox.Show("当前程序正在上传数据，请耐心等待再停止！", GlobalSet.appname);
                btnDeal.Enabled = true;
                return;
            }
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            DealerData(false, 0);
            Thread.Sleep(1000);
            MessageBox.Show("即时处理完毕", GlobalSet.appname);
            btnDeal.Enabled = true;
            btnStart_Click(null, null);
        }
        
        
        
        
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (currentThread != null)
            {
                this.currentThread.Abort();
                this.currentThread = null;
            }
            currentThread = new Thread(new ThreadStart(DoDealerWork));
            currentThread.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }
        
        
        
        
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            isWork = false;
            btnStop.Enabled = false;
            if (currentThread != null && currentThread.ThreadState == System.Threading.ThreadState.Running)
            {
                MessageBox.Show("当前程序正在上传数据，请耐心等待再停止！", GlobalSet.appname);
                btnStop.Enabled = true;
                return;
            }
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
        
        
        
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        
        
        
        
        
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (tbNum.Enabled)
            {
                tbNum.Enabled = false;
                tbNum.ReadOnly = true;
                String _path = AppDomain.CurrentDomain.BaseDirectory + GlobalSet.appinifile;
                WindowsAPIUtility.WritePrivateProfileString("posset", "transfer_time", tbNum.Value.ToString(), _path);
            }
            else
            {
                tbNum.Enabled = true;
                tbNum.ReadOnly = false;
            }
        }
        
        
        
        
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowOrHide();
        }
        
        
        
        
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        
        
        
        
        
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出当前传输程序？", GlobalSet.appname, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            isWork = false;
            if (currentThread != null)
            {
                if (currentThread.ThreadState == System.Threading.ThreadState.Running)
                {
                    if (MessageBox.Show("当前程序正在上传数据，请确定是否退出？", GlobalSet.appname, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        btnStop.Enabled = false;
                        btnStart.Enabled = true;
                        return;
                    }
                }
                currentThread.Abort();
                currentThread = null;
            }
        }
        
        
        
        
        
        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.BalloonTipText = GlobalSet.appname;
        }
        #endregion
        #region 私有方法
        
        
        
        void ExitApplication()
        {
            Close();
        }
        
        
        //循环定时执行上传数据的方法
        void DoDealerWork()
        {
            isWork = true;
            try
            {
                while (isWork)
                {
                    if (isWork)
                    {
                        DealerAccount(true);
                        DealerData(true, 0);
                        DealerVip(true);
                    }
                    else
                    {
                        break;
                    }
                    int millsecond = (int)tbNum.Value * 60 * 1000;
                    if (!(Thread.CurrentThread.ThreadState == System.Threading.ThreadState.Running))
                    {
                        Thread.Sleep(millsecond);
                    }
                }
            }
            catch (ThreadAbortException threadex)
            {
                LoggerHelper.Log("MsmkLogger", "FormMain--->DoDealerWork-->Error:" + threadex.ToString(), LogEnum.ExceptionLog);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "FormMain--->DoDealerWork-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        
        
        
        void DealerData(bool isWorkInvoke, int mark)
        {
            if (DealerDataWork == false)
            {
                //LoggerHelper.Log("MsmkLogger", "上传支付和商品销售流水出现错误##", LogEnum.TransferLog);
                return;
            }

            String _branchNo = string.Empty;
            DataTable tableFlowNo = null;
            DataTable tablePayFlow = null;
            DataTable tableSaleFlow = null;
            DataTable tableCoupon = null;
            try
            {
                tableFlowNo = UploadInfoBLL.Instance.GetUploadPayNo(GlobalSet.dbsaleconn);
                if (tableFlowNo != null && tableFlowNo.Rows.Count > 0)
                {
                    foreach (DataRow dr in tableFlowNo.Rows)
                    {
                        tablePayFlow = UploadInfoBLL.Instance.GetUploadPayInfoByFlowNo(GlobalSet.dbsaleconn, dr[0].ToString());
                        tableSaleFlow = UploadInfoBLL.Instance.GetUploadSaleInfoByFlowNo(GlobalSet.dbsaleconn, dr[0].ToString());
                        tableCoupon = UploadInfoBLL.Instance.GetUploadCouponByFlowNo(GlobalSet.dbsaleconn, dr[0].ToString());
                        if ((tablePayFlow != null && tablePayFlow.Rows.Count > 0) || (tableSaleFlow != null && tableSaleFlow.Rows.Count > 0))
                        {
                            StringBuilder sb = new StringBuilder();
                            if (isWorkInvoke)
                            {
                                if (isWork == false)
                                {
                                    break;
                                }
                            }
                          
                            Dictionary<string, object> _dic = new Dictionary<string, object>();
                            _dic.Add("username", "");
                            _dic.Add("password", "");
                            _dic.Add("client_id", GlobalSet.client_id);
                            _dic.Add("access_token", GlobalSet.access_token);
                            _dic.Add("pay", JsonUtility.Instance.DataTableToJson(tablePayFlow));
                            _dic.Add("sale", JsonUtility.Instance.DataTableToJson(tableSaleFlow));
                            if (tableCoupon != null && tableCoupon.Rows.Count > 0)
                            {
                                _dic.Add("coupon", JsonUtility.Instance.DataTableToJson(tableCoupon));//优惠券
                            }
                            else {
                                _dic.Add("coupon", "");//优惠券
                            }
                            
                            string errorMessage = string.Empty;
                            bool isok11 = true;
                            string isConnect = PServiceProvider.Instance.InvokeMethod(GlobalSet.serverUrl + "/Testconn", _dic, ref isok11, ref errorMessage);
                            if (isok11 && isConnect == "1")
                            {
                                string json = PServiceProvider.Instance.InvokeMethod(GlobalSet.serverUrl + "/" + "Addflow", _dic, ref isok11, ref errorMessage);
                                if (isok11)
                                {
                                    if (json != "-10" && json != "-20")
                                    {
                                        int result = ExtendUtility.Instance.ParseToInt32(json);
                                        if (result == 1)
                                        {
                                            UploadInfoBLL.Instance.UpdateFlowComFlag(GlobalSet.dbsaleconn, dr[0].ToString());
                                            if (tableCoupon != null && tableCoupon.Rows.Count > 0)
                                            {
                                                UploadInfoBLL.Instance.UpdateCouponComFlag(GlobalSet.dbsaleconn, dr[0].ToString());//优惠券
                                            }

                                            if (tablePayFlow != null && tablePayFlow.Rows.Count > 0)
                                            {
                                                sb.AppendLine("流水号:" + dr[0].ToString() + "支付记录条数:" + tablePayFlow.Rows.Count);
                                            }
                                            if (tableSaleFlow != null && tableSaleFlow.Rows.Count > 0)
                                            {
                                                sb.AppendLine("流水号:" + dr[0].ToString() + "销售记录条数:" + tableSaleFlow.Rows.Count);
                                            }
                                            LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                        }
                                        else
                                        {
                                            DealerDataWork = false;
                                            sb.AppendLine("流水号:" + dr[0].ToString() + "Error:" + result.ToString());
                                            LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                        }
                                    }
                                    else
                                    {
                                            DealerDataWork = false;
                                        if (json == "-10")
                                        {
                                            sb.AppendLine("流水号:" + dr[0].ToString() + "Error:参数错误");
                                            LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                        }
                                        else
                                        {
                                            sb.AppendLine("流水号:" + dr[0].ToString() + "Error:权限不足");
                                            LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                        }
                                    }
                                }
                                else
                                {
                                             DealerDataWork = false;
                                    sb.AppendLine("流水号:" + dr[0].ToString() + "Error:" + errorMessage);
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                            }
                            else
                            {
  
                            }
                        }
                    }
                }
                else
                {
                    if (mark == 1)
                    {
                        MessageBox.Show("数据上传完毕", GlobalSet.appname);

                    }
                }
                DataTable table = UploadInfoBLL.Instance.GetNoneUploadMember(GlobalSet.dbsaleconn);
                if (table != null && table.Rows.Count > 0)
                {

                    foreach (DataRow dr in table.Rows)
                    {
                        string mem_no = ExtendUtility.Instance.ParseToString(dr["card_no"]);
                        string flow_no = ExtendUtility.Instance.ParseToString(dr["flow_no"]);
                        string score = ExtendUtility.Instance.ParseToString(dr["score"]);
                        string voucher_no = ExtendUtility.Instance.ParseToString(dr["voucher_no"]);
                        DateTime oper_date = ExtendUtility.Instance.ParseToDateTime(dr["oper_date"]);
                        string memo = "门店消费";
                        if (!string.IsNullOrEmpty(voucher_no))
                        {
                            memo = "门店退货" + voucher_no;
                        }
                        Dictionary<String, String> _dic = new Dictionary<string, string>();
                        t_member_info t = null;
                        _dic.Add("mem_no", mem_no);
                        if (isWorkInvoke)
                        {
                            if (isWork == false)
                            {
                                break;
                            }
                        }
                        t = SyncProcessor.Instance.InvokeMemberService("get_mem_info", _dic);
                        if (t.code == "1")
                        {

                            _dic.Add("else", System.Web.HttpUtility.UrlEncode(memo).ToUpper());
                            _dic.Add("score", score);
                            _dic.Add("ordername", flow_no);
                            t = SyncProcessor.Instance.InvokeMemberService("addscore", _dic);
                            if (t.code == "1")
                            {
                                UploadInfoBLL.Instance.UpdateUploadMember(GlobalSet.dbsaleconn, flow_no, mem_no, "1", "1");
                                LoggerHelper.Log("MsmkLogger", "离线会员消费信息上传成功，流水号:" + flow_no + "会员卡号:" + mem_no,
                         LogEnum.TransferLog);
                            }
                            else
                            {
                                if (t.code == "-1")
                                {
                                    LoggerHelper.Log("MsmkLogger", "离线会员消费信息上传失败，流水号:" + flow_no + "会员卡号:" + mem_no,
                             LogEnum.TransferLog);
                                }
                            }
                        }
                        else
                        {
                            if (t.code == "-1")
                            {
                                UploadInfoBLL.Instance.UpdateUploadMember(GlobalSet.dbsaleconn, flow_no, mem_no, "1", "0");
                                LoggerHelper.Log("MsmkLogger", "离线会员消费信息验证失败，流水号:" + flow_no + "会员卡号:" + mem_no,
                         LogEnum.TransferLog);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "ICE.POS.Transfer->FormMain-->DealerData--->" + ex.ToString(), LogEnum.TransferLog);
            }
        }
        
        
        
        
        void DealerAccount(bool isWorkInvoke)
        {
            if (DealerAccountWork == false) {
                //LoggerHelper.Log("MsmkLogger", "上传收银员对账记录错误##", LogEnum.TransferLog);
                return;
            }

            DataTable tableAcc = null;
            bool isok = true;
            string errorMessage = string.Empty;
            try
            {
                tableAcc = UploadInfoBLL.Instance.GetUploadAccount(GlobalSet.dbsaleconn);
                if (tableAcc != null && tableAcc.Rows.Count > 0)
                {
                    foreach (DataRow dr in tableAcc.Rows)
                    {
                        if (isWorkInvoke)
                        {
                            if (isWork == false)
                            {
                                break;
                            }
                        }
                        StringBuilder sb = new StringBuilder();
                        t_pos_account account = new t_pos_account();
                        account.branch_no = ExtendUtility.Instance.ParseToString(dr["branch_no"]);
                        account.end_time = ExtendUtility.Instance.ParseToString(dr["end_time"]);
                        account.oper_date = ExtendUtility.Instance.ParseToString(dr["oper_date"]);
                        account.oper_id = ExtendUtility.Instance.ParseToString(dr["oper_id"]);
                        account.pos_id = ExtendUtility.Instance.ParseToString(dr["pos_id"]);
                        account.sale_amt = ExtendUtility.Instance.ParseToDecimal(dr["sale_amt"]);
                        account.hand_amt = ExtendUtility.Instance.ParseToDecimal(dr["hand_amt"]);
                        account.start_time = ExtendUtility.Instance.ParseToString(dr["start_time"]);
                        List<t_pos_account> acList = new List<t_pos_account>();
                        acList.Add(account);
                        string ac = JsonUtility.Instance.ObjectToJson<t_pos_account>(acList);
                        Dictionary<string, object> _dic = new Dictionary<string, object>();
                        _dic.Add("username", "");
                        _dic.Add("password", "");
                        _dic.Add("client_id", GlobalSet.client_id);
                        _dic.Add("access_token", GlobalSet.access_token);
                        _dic.Add("ac", ac);
                        string json = PServiceProvider.Instance.InvokeMethod(GlobalSet.serverUrl + "/" + "Addposac", _dic, ref isok, ref errorMessage);
                        if (isok)
                        {
                            if (json != "-10" && json != "-20")
                            {
                                int result = ExtendUtility.Instance.ParseToInt32(json);
                                if (result == 1)
                                {
                                    UploadInfoBLL.Instance.UpdateAccountFlag(GlobalSet.dbsaleconn, dr[0].ToString());
                                    sb.Append("门店：" + account.branch_no);
                                    sb.Append("POS机：" + account.pos_id);
                                    sb.Append("收银员：" + account.oper_id);
                                    sb.Append(" 对账上传成功");
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                                else
                                {
                                    DealerAccountWork = false;
                                    sb.Append("门店：" + account.branch_no);
                                    sb.Append("POS机：" + account.pos_id);
                                    sb.Append("收银员：" + account.oper_id);
                                    sb.Append(" 对账上传失败" + "Error:" + errorMessage);
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                            }
                            else
                            {
                                    DealerAccountWork = false;
                                if (json == "-10")
                                {
                                    sb.AppendLine("流水号:" + dr[0].ToString() + "Error:参数错误");
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                                else
                                {
                                    sb.AppendLine("流水号:" + dr[0].ToString() + "Error:权限不足");
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        
        
        
        
        void DealerVip(bool isWorkInvoke)
        {
            if (DealerVipWork == false)
            {
                //LoggerHelper.Log("MsmkLogger", "上传会员消费记录错误##", LogEnum.TransferLog);
                return;
            }

            DataTable tableAcc = null;
            bool isok = true;
            string errorMessage = string.Empty;
            try
            {
                tableAcc = UploadInfoBLL.Instance.GetUploadVip(GlobalSet.dbsaleconn);
                if (tableAcc != null && tableAcc.Rows.Count > 0)
                {
                    foreach (DataRow dr in tableAcc.Rows)
                    {
                        if (isWorkInvoke)
                        {
                            if (isWork == false)
                            {
                                break;
                            }
                        }
                        StringBuilder sb = new StringBuilder();
                        t_app_viplist vip = new t_app_viplist();
                        vip.flow_no = ExtendUtility.Instance.ParseToString(dr["flow_no"]);
                        vip.card_no = ExtendUtility.Instance.ParseToString(dr["card_no"]);
                        vip.score = ExtendUtility.Instance.ParseToDecimal(dr["score"]);
                        vip.sale_amt = ExtendUtility.Instance.ParseToDecimal(dr["sale_amt"]);
                        vip.voucher_no = ExtendUtility.Instance.ParseToString(dr["voucher_no"]);
                        vip.card_score = ExtendUtility.Instance.ParseToDecimal(dr["card_score"]);
                        vip.card_amount = ExtendUtility.Instance.ParseToDecimal(dr["card_amount"]);
                        vip.oper_date = ExtendUtility.Instance.ParseToString(dr["oper_date"]);
                        List<t_app_viplist> acList = new List<t_app_viplist>();
                        acList.Add(vip);
                        string ac = JsonUtility.Instance.ObjectToJson<t_app_viplist>(acList);
                        Dictionary<string, object> _dic = new Dictionary<string, object>();
                        _dic.Add("username", "");
                        _dic.Add("password", "");
                        _dic.Add("client_id", GlobalSet.client_id);
                        _dic.Add("access_token", GlobalSet.access_token);
                        _dic.Add("vip", ac);
                        string json = PServiceProvider.Instance.InvokeMethod(GlobalSet.serverUrl + "/" + "Addvip", _dic, ref isok, ref errorMessage);
                        if (isok)
                        {
                            if (json != "-10" && json != "-20")
                            {
                                int result = ExtendUtility.Instance.ParseToInt32(json);
                                if (result == 1)
                                {
                                    UploadInfoBLL.Instance.UpdateVipFlag(GlobalSet.dbsaleconn, vip.flow_no, vip.card_no);
                                    sb.Append("流水号：" + vip.flow_no);
                                    sb.Append("会员卡：" + vip.card_no);
                                    sb.Append(" 会员消费上传成功");
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                                else
                                {
                                    DealerVipWork = false;
                                    sb.Append("流水号：" + vip.flow_no);
                                    sb.Append("会员卡：" + vip.card_no);
                                    sb.Append(" 会员消费上传失败" + "Error:" + errorMessage);
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                            }
                            else
                            {
                                    DealerVipWork = false;
                                if (json == "-10")
                                {
                                    sb.AppendLine("流水号:" + dr[0].ToString() + "Error:参数错误");
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                                else
                                {
                                    sb.AppendLine("流水号:" + dr[0].ToString() + "Error:权限不足");
                                    LoggerHelper.Log("MsmkLogger", sb.ToString(), LogEnum.TransferLog);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        
        
        
        void ShowOrHide()
        {
            if (windowCreate)
            {
                windowCreate = false;
                Hide();
                ShowInTaskbar = false;
            }
            else
            {
                Visible = true;
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
                BringToFront();
                windowCreate = true;
                Activate();
            }
        }
        
        
        
        void InitControl()
        {
            windowCreate = false;
            Visible = false;
            Hide();
            ShowInTaskbar = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }
        
        
        
        void InitData()
        {
            try
            {
                String _path = AppDomain.CurrentDomain.BaseDirectory + GlobalSet.appinifile;
                String _xmlpath = "Application.xml";
                string _appname = WindowsAPIUtility.GetLocalSysParam("posset", "transfer_appname", "", _path);
                Text = GlobalSet.appname;
                notifyIcon1.Text = GlobalSet.appname;
                notifyIcon1.BalloonTipText = GlobalSet.appname;
                notifyIcon1.ShowBalloonTip(100, GlobalSet.appname, GlobalSet.appname, ToolTipIcon.Info);
                String _applicationXml = WindowsAPIUtility.GetLocalSysParam("posset", "app_xml", _xmlpath, _path); ;
                _xmlpath = AppDomain.CurrentDomain.BaseDirectory + _applicationXml;
                Dictionary<String, String> _dic = XMLUtility.Instance.GetNodesText(_xmlpath, new string[] { "//applicationConfig/BranchNo" });
                if (_dic == null || _dic["//applicationConfig/BranchNo"] == null || _dic["//applicationConfig/BranchNo"].ToString() == string.Empty)
                {
                    MessageBox.Show("POS机注册信息不存在或有误，请运行程序注册POS机！", GlobalSet.appname);
                    Process.GetCurrentProcess().Kill();
                }
                currentThread = new Thread(DoDealerWork);
                currentThread.Start();
                Decimal _time = 1M;
                String _timespan = "1";
                String _settimespan = WindowsAPIUtility.GetLocalSysParam("posset", "transfer_time", _timespan, _path);
                Decimal.TryParse(_settimespan, out _time);
                _time = _time < 1M ? 1M : _time;
                tbNum.Value = _time;
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "FormMain--->InitData-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }
        #endregion

        private void FormMain_MinimumSizeChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isWork = false;
            if (currentThread != null && currentThread.ThreadState == System.Threading.ThreadState.Running)
            {
                MessageBox.Show("当前程序正在上传数据，请耐心等待再停止！", GlobalSet.appname);
                btnStop.Enabled = true;
                return;
            }
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            try
            {
                DealerVip(false);
                DealerAccount(false);
                DealerData(false, 1);
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", "FormMain--->手动上传-->Error:" + ex.ToString(), LogEnum.ExceptionLog);
            }
        }

    }
}
