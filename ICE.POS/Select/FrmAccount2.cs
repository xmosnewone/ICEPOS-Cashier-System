namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using ICE.POS.Model;
    using ICE.POS.Common;
    using ICE.Utility;

    public partial class FrmAccount2 : FrmBase
    {
        private bool _isLogout = false;
        public FrmAccount2()
        {
            InitializeComponent();
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                this.SetQueryPeriod(out flag);
                DateTime? lastAccountTime = Gattr.Bll.GetLastAccountTime();
                if (!flag)
                {
                    if (lastAccountTime.HasValue)
                    {
                        MessageBox.Show("自上次对账(截止:" + Convert.ToDateTime(lastAccountTime).ToString("yyyy-MM-dd HH:mm:ss") + ")后无收银数据！", Gattr.AppTitle);
                    }
                    else
                    {
                        MessageBox.Show("没有收银数据需要对账!", Gattr.AppTitle);
                    }
                }
                else
                {
                    DateTime dtStart = this.dtpFrom.Value;
                    DateTime dtEnd = this.dtpTo.Value;
                    decimal sMoney = 0M;
                    sMoney = ExtendUtility.Instance.ParseToDecimal(this.tbMoney.Text);
                    if (sMoney != 0)
                    {
                        if (MessageBox.Show("对账时间段：" + dtStart.ToString("yyyy-MM-dd HH:mm:ss") + "～" + dtEnd.ToString("yyyy-MM-dd HH:mm:ss") + " \r\n是否确认对账？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.No)
                        {
                            decimal sumAccountAmt = Gattr.Bll.GetSumAccountAmt(dtStart, dtEnd);
                            string errMsg = "";
                            if (Gattr.Bll.InsertAccountRecord(dtStart, dtEnd, sumAccountAmt, sMoney, out errMsg))
                            {
                                MessageBox.Show("对帐成功！", Gattr.AppTitle);
                                LoggerHelper.Log("MsmkLogger", "【" + Gattr.OperId + "】进行对账，对账成功！", LogEnum.SysLog);
                            }
                            else
                            {
                                MessageBox.Show("对帐失败:" + errMsg, Gattr.AppTitle);
                                LoggerHelper.Log("MsmkLogger", "【" + Gattr.OperId + "】进行对账，对账失败！", LogEnum.SysLog);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入对账金额！",Gattr.AppTitle);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Gattr.AppTitle);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (this.chkCashBox.Checked)
        //        {
        //              Gfunc.OpenCash();
        //        //    string strMemo = Language.GetString("#0514");
        //        //    Gattr.Bll.WriteRetailLog("OPD", 0M, strMemo, Gattr.CashierNo, "", 0M, true);
        //        //    Gattr.Bll.WriteSysLog(Gattr.LogFile, strMemo, strMemo, 1);
        //        }
        //        //Gattr.PosPrinter.OpenPrinter(Gattr.PrinterName, Gattr.PrinterPort);
        //        //Gattr.PosPrinter.PrintOut("\r\n");
        //        string strOut = "";
        //        List<t_pos_printer_out> listOut = new List<t_pos_printer_out>();
        //        for (int i = 0; i < this.listBox.Items.Count; i++)
        //        {
        //            if (Gattr.PosPrinter.IsWindowPrinter)
        //            {
        //                t_pos_printer_out item = new t_pos_printer_out
        //                {
        //                    BigFont = false,
        //                    Text = this.listBox.Items[i].ToString()
        //                };
        //                listOut.Add(item);
        //            }
        //            else
        //            {
        //                strOut = strOut + this.listBox.Items[i].ToString() + "\n";
        //            }
        //        }
        //        if (Gattr.PosPrinter.IsWindowPrinter)
        //        {
        //            Gattr.PosPrinter.PrintOut(listOut);
        //        }
        //        else
        //        {
        //            //Gattr.PosPrinter.PrintOut(strOut);
        //            //Gattr.PosPrinter.FooterEmptyLine();
        //            //Gattr.PosPrinter.PrintCut();
        //        }
        //        //Gattr.PosPrinter.ClosePrinter();
        //        LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】进行打印对账信息！", LogEnum.SysLog);
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message, Gattr.AppTitle);
        //    }
        //}

        private void dtpFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                e.Handled = true;
            }
        }

        private void dtpTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                e.Handled = true;
            }
        }

        private void FrmAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (this.btnAccount.Enabled && this.btnAccount.Visible)
                {
                    this.btnAccount_Click(null, null);
                }
            }
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            this.Text = Gattr.AppTitle;
            this.lbTitle.Text = "收银对账单";
            this.btnClose.Text = "返回(Esc)";
            //if ("1" == Gfunc.GetLocalSysParam("pos", "reckoning", "0", Gattr.InitFile).Trim())
            //{
            //    this.chkCashBox.Checked = true;
            //}
            this.dtpFrom.Enabled = false;// Gattr.IsModifyAccTime;
            this.dtpTo.Enabled = false;// Gattr.IsModifyAccTime;
            if (Gattr.IsRecordPosAccount)
            {
                this.btnAccount.Visible = true;
                this.label1.Visible = true;
            }
            else
            {
                this.btnAccount.Visible = false;
                this.label1.Visible = false;
            }
            this.QueryAccount();
        }
        private void QueryAccount()
        {
            try
            {
                bool flag;
                this.SetQueryPeriod(out flag);
                DateTime dtFrom = this.dtpFrom.Value;
                DateTime dtTo = this.dtpTo.Value;
                List<string> list = Gattr.Bll.AccountReportFromServer(Gattr.BranchNo, Gattr.PosId, Gattr.OperId, dtFrom, dtTo, Gattr.PrtLen);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Gattr.AppTitle);
            }
        }

        private void QueryItemAcc()
        {
            try
            {
                bool flag;
                this.SetQueryPeriod(out flag);
                DateTime dtFrom = this.dtpFrom.Value;
                DateTime dtTo = this.dtpTo.Value;
                List<string> list = Gattr.Bll.ItemAccountStatement(Gattr.BranchNo, Gattr.PosId, Gattr.OperId, Gattr.OperFullName, dtFrom, dtTo, Gattr.PrtLen);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Gattr.AppTitle);
            }
        }


        public void SetQueryPeriod(out bool hasData)
        {
            if (Gattr.IsRecordPosAccount)
            {
                DateTime now = DateTime.Now;
                DateTime dtEnd = DateTime.Now;
                hasData = false;
                Gattr.Bll.GetQueryPeriod(out now, out dtEnd, out hasData);
                this.dtpFrom.Value = now;
                this.dtpTo.Value = dtEnd.AddSeconds(1.0);
            }
            else
            {
                hasData = true;
                this.dtpFrom.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                this.dtpTo.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        public bool IsLogout
        {
            get
            {
                return this._isLogout;
            }
        }
        
        
        
        private void tbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar)&&e.KeyChar!=46)// 小数点
            {
                e.Handled = true;
            }
        }
    }
}
