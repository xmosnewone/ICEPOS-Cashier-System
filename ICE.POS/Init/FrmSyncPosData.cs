/********************************************************
 * Author:xmos
 * Description:POS端同步下载最新的商品/价格/库存/促销政策等数据
 * ******************************************************/
namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading;
    using System.IO;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.POS.Model;
    using ICE.Utility;
    using System.Configuration;
    /// <summary>
    /// 同步Pos机基本数据窗体逻辑
    /// </summary>
    public partial class FrmSyncPosData : FrmBase
    {
        #region 窗体全局声名
        /// <summary>
        /// 设置控件值代理声名
        /// </summary>
        /// <param name="isSet">提示消息</param>
        /// <param name="isSet">进度条位置</param>
        /// <returns></returns>
        public delegate void SetMessageDelegate(String message, Int32 percentage);
        /// <summary>
        /// 是否自动下载
        /// </summary>
        private bool _isAutoDownload = false;
        #endregion
        #region 构造函数
        public FrmSyncPosData()
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
        }
        public FrmSyncPosData(bool isAutoDownload)
        {
            this.InitializeComponent();
            this.Text = Gattr.AppTitle;
            this._isAutoDownload = isAutoDownload;
            this.progressBar1.Value = 0;
            this.Load += new EventHandler(FrmSyncPosData_Load);
        }
        #endregion
        #region 窗体事件逻辑
        /// <summary>
        /// 窗体加载事件逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FrmSyncPosData_Load(object sender, System.EventArgs e)
        {

            bool isok = false;
            if (this._isAutoDownload)
            {
                isok = true;

                /**var updater = FSLib.App.SimpleUpdater.Updater.Instance;
                updater.Context.UpdateDownloadUrl = ConfigurationManager.AppSettings["updateUrl"];
                //updater.Context.AutoKillProcesses = true;
                //当检查发生错误时,这个事件会触发
                //updater.Error += new EventHandler(updater_Error);
                //没有找到更新的事件
                updater.NoUpdatesFound += (s1, e1) =>
                {
                    isok = true;
                    btnOk.Enabled = false;
                    buttonEx2.Enabled = false;
                    btnOk_Click(null, null);
                };
                updater.UpdatesFound += (s2, e2) =>
                {
                    isok = false;
                    btnOk.Enabled = true;
                    buttonEx2.Enabled = true;
                };
                FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple();
                **/
            }
            else
            {
                btnOk.Enabled = true;
                buttonEx2.Enabled = true;
            }
            //if (isok)
            //{
            //    btnOk.Enabled = false;
            //    buttonEx2.Enabled = false;
            //    btnOk_Click(null, null);
            //}
            //else
            //{
            //    btnOk.Enabled = true;
            //    buttonEx2.Enabled = true;
            //}
        }
        /// <summary>
        /// 下载按钮事件逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, System.EventArgs e)
        {

            //bool isAll = false;
            //if (btnEx.Tag.ToString() == "all")
            //{
            //    isAll = true;
            //}
            Thread thd = new Thread(new ParameterizedThreadStart(InitData));
            CheckForIllegalCrossThreadCalls = false;
            thd.SetApartmentState(ApartmentState.STA);//关键设置
            thd.IsBackground = true;
            Thread.Sleep(500);
            try
            {
                thd.Start();
            }
            catch (ThreadStateException stateException)
            {
                Console.WriteLine(stateException.ToString());
            }
           
        }
        /// <summary>
        /// 取消按钮事件逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEx2_Click(object sender, System.EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion
        #region 窗体私有方法
        /// <summary>
        /// 初始化信息
        /// </summary>
        void InitData(Object t)
        {
            if (base.IsHandleCreated)
            {
                base.Invoke(new EventHandler(delegate
               {
                   btnOk.Enabled = false;
                   buttonEx2.Enabled = false;
               }));
            }
            if (btnOk.IsHandleCreated)
            {
                btnOk.Invoke(new EventHandler(delegate
                {
                    btnOk.Enabled = false;
                }));
            }
            if (buttonEx2.IsHandleCreated)
            {
                buttonEx2.Invoke(new EventHandler(delegate
                {
                    buttonEx2.Enabled = false;
                }));
            }

            //标记全部完成
            bool isAll = true;
            //全新加载系统
            bool initSys = false;

            //判断是否有item.db，没有则认为是首次初始化，下载所有商品数据
            if (!File.Exists(Gattr.ITEM_DB_FILE))
            {
                initSys = true;
            }
            
            //1、初始化的基本信息2、各基本信息所占总初始化信息的百分比
            //需要初始化的信息：商品分类10、商品条码20、商品40、支付方式10、基础信息类型，基础信息数据10、营业员10
            try
            {

                int progressValue = this.progressBar1.Value;
                List<ThreadStruct> _list = new List<ThreadStruct>();

                _list.Add(new ThreadStruct() { Desc = "数据库基本", Method = "InitDB", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "门店信息", Method = "Getbrninfo", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "商品分类", Method = "Getitemcls", Percent = 5 });
                if (!initSys)
                {
                    _list.Add(new ThreadStruct() { Desc = "商品数据", Method = "Getiteminfo", Percent = 10 });
                }
                else {
                    _list.Add(new ThreadStruct() { Desc = "商品数据", Method = "GetItemsData", Percent = 10 });
                }
                _list.Add(new ThreadStruct() { Desc = "商品条形码", Method = "Getbarcode", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "商品价格", Method = "Getbraprc", Percent = 10 });
                _list.Add(new ThreadStruct() { Desc = "商品库存", Method = "Getbrastock", Percent = 10 });
                _list.Add(new ThreadStruct() { Desc = "基础信息类型", Method = "Getbasecode", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "基础信息数据", Method = "Getbase", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "营业员", Method = "Getoper", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "支付方式", Method = "Getpayinfo", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "快捷键", Method = "Getkey", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "促销规则", Method = "Getprule", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "促销", Method = "Getpmaster", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "促销详细", Method = "Getpdetail", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "组合商品", Method = "Getcomb", Percent = 5 });
                _list.Add(new ThreadStruct() { Desc = "供应商", Method = "Getsup", Percent = 5 });
                //_list.Add(new ThreadStruct() { Desc = "POS机设置", Method = "GetPosSet", Percent = 5 });

                foreach (ThreadStruct ts in _list)
                {
                    Thread.Sleep(500);
                    if (ts.Method == "InitDB")
                    {
                        if (!Gfunc.InitDB())
                        {
                            isAll = false;
                            MessageBox.Show("更新" + ts.Desc + "时错误", Gattr.AppTitle);
                            this.Invoke(new EventHandler(delegate
                            {
                                buttonEx2.Enabled = true;
                            }));
                            break;
                        }
                    }
                    else
                    {
                        if (InvokeServices(ts.Method, true))
                        {
                            progressValue = progressBar1.Value + ts.Percent;
                            this.Invoke((MethodInvoker)(() => SetControlText("正在更新" + ts.Desc + "信息操作，已完成" + (progressValue) + "%", progressValue)));
                        }
                        else
                        {
                            isAll = false;
                            MessageBox.Show("更新" + ts.Desc + "时错误", Gattr.AppTitle);
                            this.Invoke(new EventHandler(delegate
                            {
                                buttonEx2.Enabled = true;
                            }));
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Log("MsmkLogger", ex.ToString(), LogEnum.ExceptionLog);
            }
            finally
            {
                //Gattr.Bll.dbClose();
            }
            if (isAll)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        /// <summary>
        /// 调用服务更新数据库
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        bool InvokeServices(String mark, bool isAll)
        {
            bool result = false;
            //1、调用方法获取数据
            //2、将数据导入到表
            //bool isok = true;
            DataTable table = null;
            object obj;
            try
            {
                t_handle _t_handle = Gattr.Bll.SelectHandleData();
                //obj = PosServiceProvider.Instance.InvokeService(Gattr.HttpAddress, Gattr.WebPosServicePath, mark, ref isok, Gattr.BranchNo);
                //obj = PosDownServiceProvider.Instance.InvokeService(Gattr.CONNECT_STRING, mark, ref isok, Gattr.BranchNo, "", 0, "");
                Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                _dic.Add("branch_no", Gattr.BranchNo);
                switch (mark)
                {
                    case "Getiteminfo":
                        string last_time = WindowsAPIUtility.GetLocalSysParam("download", "t_product_food", Gattr.LAST_UPDATE_TIME, Gattr.INI_FILE_PATH);
                        _dic.Add("rid",_t_handle.t_product_food);
                        _dic.Add("last_time", ExtendUtility.Instance.ParseToDateTime(last_time).ToString());
                        //Console.WriteLine("执行更新");
                        break;
                    case "GetItemsData":
                        //下载全部商品信息
                        //Console.WriteLine("执行全新下载");
                        break;
                    case "Getbrastock":
                        string last_time1 = WindowsAPIUtility.GetLocalSysParam("download", "t_pos_branch_stock", Gattr.LAST_UPDATE_TIME, Gattr.INI_FILE_PATH);
                        _dic.Add("rid", _t_handle.t_product_food_kc);
                        _dic.Add("last_time", ExtendUtility.Instance.ParseToDateTime(last_time1).ToString());
                        break;
                    case "Getbraprc":
                        string last_time2 = WindowsAPIUtility.GetLocalSysParam("download", "t_pos_branch_price", Gattr.LAST_UPDATE_TIME, Gattr.INI_FILE_PATH);
                        _dic.Add("rid", _t_handle.t_product_food_jg);
                        _dic.Add("last_time", ExtendUtility.Instance.ParseToDateTime(last_time2).ToString());
                        break;
                    case "Getbarcode":
                        // string last_time3 = WindowsAPIUtility.GetLocalSysParam("download", "barcode", Gattr.LAST_UPDATE_TIME, Gattr.INI_FILE_PATH);
                        //_dic.Add("rid", _t_handle.t_product_food_barcode);
                        //_dic.Add("last_time", ExtendUtility.Instance.ParseToDateTime(last_time3).ToString());
                        _dic.Add("rid","-1");//全部下载
                        break;
                    case "Getitemcls":
                        //_dic.Add("rid", _t_handle.t_product_food_type);
                        _dic.Add("rid","-1");//全部下载
                        break;
                    case "Getbasecode":
                        _dic.Add("rid", _t_handle.t_base_code_type);
                        break;
                    case "Getbase":
                        _dic.Add("rid", _t_handle.t_base_code);
                        break;
                    case "Getoper":
                        _dic.Add("rid", _t_handle.t_operator);
                        break;
                    case "Getpmaster":
                        //_dic.Add("rid", _t_handle.t_rm_plan_master);
                        _dic.Add("rid","-1");
                        break;
                    case "Getcomb":
                        _dic.Add("rid", _t_handle.t_bd_item_combsplit);
                        break;
                    case "Getpdetail":
                        //_dic.Add("rid", _t_handle.t_rm_plan_detail);
                        _dic.Add("rid", "-1");
                        break;

                }
                string errorMessage = string.Empty;
                bool isok1 = true;
                obj = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/" + mark, _dic, ref isok1, ref errorMessage);
                if (isok1)
                {
                    //if (isok)
                    //{
                    //    //获取数据
                    //    //插入数据
                    //    if (mark != "GetPosSet")
                    //    {
                    string result1 = ExtendUtility.Instance.ParseToString(obj);
                    //if (!string.IsNullOrEmpty(result1))
                    {
                        if (result1 != "-10" && result1 != "-20")
                        {
                            table = JsonUtility.Instance.JsonToDataTable(result1);

                            if (!SIString.IsNullOrEmptyDataTable(table))
                            {
                                decimal rid = 0M;
                                switch (mark)
                                {
                                    case "Getitemcls":
                                        result = Gattr.Bll.InsertItemClsData(table, _t_handle.t_product_food_type, ref rid);
                                        if (result) _t_handle.t_product_food_type = rid;
                                        break;
                                    case "Getbarcode":
                                        result = Gattr.Bll.InsertBarcodeData(table, _t_handle.t_product_food_barcode, ref rid);
                                        if (result) _t_handle.t_product_food_barcode = rid;
                                        break;
                                    case "Getiteminfo":
                                        result = Gattr.Bll.InsertItemData(table, _t_handle.t_product_food, ref rid);
                                        if (result) _t_handle.t_product_food = rid;
                                        break;
                                    case "GetItemsData":
                                        //新建所有商品信息
                                        result = Gattr.Bll.InsertItemData(table,0, ref rid);
                                        if (result) _t_handle.t_product_food = rid;
                                        break;
                                    case "Getoper":
                                        result = Gattr.Bll.InsertCashierData(table, _t_handle.t_operator, ref rid);
                                        if (result) _t_handle.t_operator = rid;
                                        break;
                                    case "Getbasecode":
                                        result = Gattr.Bll.InsertBaseTypeData(table, _t_handle.t_base_code_type, ref rid);
                                        if (result) _t_handle.t_base_code_type = rid;
                                        break;
                                    case "Getbase":
                                        result = Gattr.Bll.InsertBaseData(table, _t_handle.t_base_code, ref rid);
                                        if (result) _t_handle.t_base_code = rid;
                                        break;
                                    case "Getpayinfo":
                                        result = Gattr.Bll.InsertPaymentInfo(table);
                                        break;
                                    case "Getkey":
                                        result = Gattr.Bll.InsertFunction(table);
                                        break;
                                    case "Getbrninfo":
                                        result = Gattr.Bll.InsertBrancheList(table);
                                        break;
                                    case "Getbraprc":
                                        result = Gattr.Bll.UpdateItemPrice(table, ref rid);
                                        if (result) _t_handle.t_product_food_jg = rid;
                                        break;
                                    case "Getbrastock":
                                        result = Gattr.Bll.UpdateItemStock(table, ref rid);
                                        if (result) _t_handle.t_product_food_kc = rid;
                                        break;
                                    case "Getprule":
                                        result = Gattr.Bll.InsertPlanRule(table);
                                        break;
                                    case "Getpmaster":
                                        result = Gattr.Bll.InsertPlanMaster(table, _t_handle.t_rm_plan_master, ref rid);
                                        if (result) _t_handle.t_rm_plan_master = rid;
                                        break;
                                    case "Getpdetail":
                                        result = Gattr.Bll.InsertPlanDetail(table, _t_handle.t_rm_plan_detail, ref rid);
                                        if (result) _t_handle.t_rm_plan_detail = rid;
                                        break;
                                    case "Getcomb":
                                        result = Gattr.Bll.InsertItemComb(table, _t_handle.t_bd_item_combsplit, ref rid);
                                        if (result) _t_handle.t_bd_item_combsplit = rid;
                                        break;
                                    case "Getsup":
                                        result = Gattr.Bll.InsertSupinfo(table);
                                        break;
                                    default:
                                        break;
                                }
                                //如果数据更新成功则更新标识信息
                                if (result)
                                {
                                    Gattr.Bll.UpdateHandleData(_t_handle);
                                }
                            }
                            else
                            {
                                result = true;
                            }
                        }
                    }
                    //    }
                    //    else
                    //    {
                    //        // List<t_sys_pos_set> sets = JsonUtility.Instance.JsonToObject<List<t_sys_pos_set>>(obj.ToString());
                    //        // result = Gattr.Bll.InsertPosSysSet(sets);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show(SIString.TryStr(obj), Gattr.AppTitle);
                    //}
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
            return result;
        }
        /// <summary>
        /// 设置控件的值
        /// </summary>
        /// <param name="isVisible"></param>
        void SetControlText(String message, Int32 percentage)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetMessageDelegate(SetControlText), new object[] { message, percentage });
            }
            else
            {
                lbMessage.Text = message;
                progressBar1.Value = percentage;
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }


        }
        /// <summary>
        /// 
        /// </summary>
        public struct ThreadStruct
    {
        public String Method { get; set; }
        public String Desc { get; set; }
        public Int32 Percent { get; set; }
    }
}
