namespace ICE.POS
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Collections;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.Utility;
    public partial class FrmDmSheet : FrmBase
    {
        public FrmDmSheet()
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmDmSheetDetail().ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //string cashierNo = Gattr.CashierNo;
            //string msg = "";
            //if (Gfunc.PosCheckGrant(ref cashierNo, PosGrant.UpdateDmSheet, ref msg))
            //{
            if (this.dgvSheet.CurrentRow != null)
            {
                string sheetNO = SIString.TryStr(this.dgvSheet.Rows[this.dgvSheet.CurrentRow.Index].Cells["sheet_no"].Value.ToString().Trim());
                string str4 = SIString.TryStr(this.dgvSheet.Rows[this.dgvSheet.CurrentRow.Index].Cells["approve_name"].Value.ToString().Trim());
                string strStatus = SIString.TryStr(this.dgvSheet.Rows[this.dgvSheet.CurrentRow.Index].Cells["order_status"].Value.ToString().Trim());
                if ((sheetNO != "") && (str4 != "已审核"))
                {
                    DialogResult dialogResult = new DialogResult();
                    if (strStatus == "t")
                    {
                        dialogResult=MessageBox.Show("当前选中单据为[" + sheetNO + "]，是否删除？", Gattr.AppTitle, MessageBoxButtons.YesNo);
                    }
                    else
                    {
                        dialogResult=MessageBox.Show("当前选中单据[" + sheetNO + "]已经提交审核，是否删除？", Gattr.AppTitle, MessageBoxButtons.YesNo);
                    }
                    if (dialogResult == DialogResult.Yes)
                    {
                        Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                        _dic.Add("sheet_no", sheetNO);
                        bool isok = true;
                        string errorMessage = string.Empty;
                        string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Delpsheet", _dic, ref isok, ref errorMessage);
                        if (isok&&result!="")
                        {
                            switch(result)
                            {
                                case "1" :
                                    MessageBox.Show("删除成功！",Gattr.AppTitle);
                                    btnSearch_Click(sender, e);
                                    break;
                                case "0":
                                    MessageBox.Show("删除失败，请重试！",Gattr.AppTitle);
                                    break;
                                case "-1":
                                    MessageBox.Show("记录不存在！",Gattr.AppTitle);
                                    break;
                                case "-2":
                                    MessageBox.Show("返回异常！",Gattr.AppTitle);
                                    break;
                                case "-3":
                                    MessageBox.Show("业务错误！-3",Gattr.AppTitle);
                                    break;
                                default:
                                    MessageBox.Show("未知错误！",Gattr.AppTitle);
                                    break;
                            }
                        }
                        //string transNO = sheetNO.Contains("DY") ? "DY" : "AP";
                        //string transNO = "YH";
                        //if (RetailGlobal.ServerBll.DelSheet(transNO, sheetNO) > 0)
                        //{
                        //    MessageBox.Show("单据[" + sheetNO + "]删除成功！", Gattr.AppTitle);
                        //    this.btnSearch_Click(sender, e);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("单据[" + sheetNO + "]删除失败，请检查是否为已审核单据！", Gattr.AppTitle);
                        //    this.btnSearch_Click(sender, e);
                        //}
                        LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】进行删除要货单！", LogEnum.SysLog);
                    }
                }
                else
                {
                    MessageBox.Show("单据[" + sheetNO + "]状态为已审核，不能删除！", Gattr.AppTitle);
                }
            }
            else
            {
                MessageBox.Show("请先选中一行再进行操作！", Gattr.AppTitle);
            }
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (this.dgvSheet.CurrentRow != null)
            {
                string str = SIString.TryStr(this.dgvSheet.Rows[this.dgvSheet.CurrentRow.Index].Cells["sheet_no"].Value.ToString().Trim());
                if (!string.IsNullOrEmpty(str))
                {
                    object dataRow = this.dgvSheet.CurrentRow.DataBoundItem;
                    using (FrmDmSheetDetail detail = new FrmDmSheetDetail(dataRow))
                    {
                        detail.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选中一行再进行操作！", Gattr.AppTitle);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string transNO = "YH";
            if (this.cmbType.SelectedIndex == 0)
            {
                transNO = "YH";
            }
            DateTime startDate = DateTime.Parse(this.dateStart.Value.ToShortDateString() + " 00:00");
            DateTime endDate = DateTime.Parse(this.dateEnd.Value.ToShortDateString() + " 23:59");
            if (endDate < startDate)
            {
                MessageBox.Show("结束时间要比开始时间大", Gattr.AppTitle);
            }
            else
            {
                int status = -1;
                if (this.cmbStatus.SelectedIndex == 1)
                {
                    status = 0;
                }
                else if (this.cmbStatus.SelectedIndex == 2)
                {
                    status = 1;
                }
                else
                {
                    status = -1;
                }
                BaseInfoService.Instance.TransNO = transNO;
                BaseInfoService.Instance.BranchNO = Gattr.BranchNo;
                BaseInfoService.Instance.SheetNO = this.txtSheetNO.Text.Trim();
                BaseInfoService.Instance.Status = status.ToString();
                BaseInfoService.Instance.StartDate = startDate;
                BaseInfoService.Instance.EndDate = endDate;
                bool isok = true;
                try
                {
                    if (isok)
                    {
                        dgvSheet.AutoGenerateColumns = false;
                        if (dgvSheet.DataSource != null)
                        {
                            DataTable dt = (DataTable)dgvSheet.DataSource;
                            dt.Rows.Clear();
                            dgvSheet.DataSource = dt;
                        }
                        //string mark = "GetPMSheetMaster";
                        //DataTable table = (DataTable)BaseInfoService.Instance.InvokeService(Gattr.HttpAddress, Gattr.WebPosServicePath, mark, ref isok, "");
                        //DataTable table = PosUploadServiceProvider.Instance.SearchMaster(Gattr.CONNECT_STRING, ref isok, Gattr.BranchNo, transNO, startDate.ToString(), endDate.ToString(), this.txtSheetNO.Text.Trim(), status.ToString());
                        //t_pm_sheet_master _master = new t_pm_sheet_master();
                        Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                        _dic.Add("branch_no", Gattr.BranchNo);
                        _dic.Add("trans_no", transNO);
                        _dic.Add("start", startDate.ToString());
                        _dic.Add("end", endDate.ToString());
                        _dic.Add("sheet_no", txtSheetNO.Text.Trim());
                        _dic.Add("approve_flag", status.ToString());
                        bool isok1 = true;
                        string errorMessage = string.Empty;
                        string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Getsheet", _dic, ref isok1, ref errorMessage);
                        if (isok1)
                        {
                            if (result != "-10" && result != "-20")
                            {
                                DataTable table = JsonUtility.Instance.JsonToDataTable(result);
                                if (table != null && table.Rows.Count > 0)
                                {
                                    this.dgvSheet.DataSource = table;
                                }
                                else
                                {
                                    MessageBox.Show("没有找到数据", Gattr.AppTitle);
                                }
                            }
                            else
                            {
                                if (result == "-10")
                                {
                                    //参数错误
                                    MessageBox.Show("参数错误", Gattr.AppTitle);
                                }
                                else
                                {
                                    //禁止操作
                                    MessageBox.Show("禁止操作", Gattr.AppTitle);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, Gattr.AppTitle);
                        }

                        //if (SIString.IsNullOrEmptyDataTable(table))
                        //{
                        //    MessageBox.Show("没有找到数据", Gattr.AppTitle);
                        //}
                        //else
                        //{
                        //    this.dgvSheet.DataSource = table;
                        //}
                    }
                }
                catch (Exception exc)
                {
                    throw exc;
                }

            }
        }

        private void dgvSheet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string str = SIString.TryStr(this.dgvSheet.Rows[e.RowIndex].Cells["sheet_no"].Value);
                if (!string.IsNullOrEmpty(str))
                {
                    object obj = this.dgvSheet.Rows[e.RowIndex].DataBoundItem;
                    //t_
                    using (FrmDmSheetDetail detail = new FrmDmSheetDetail(obj))
                    {
                        detail.ShowDialog();
                    }
                }
            }
        }

        private void FrmDmSheet_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    this.btnSearch_Click(sender, e);
                    break;

                case Keys.Escape:
                    base.Close();
                    break;

                case Keys.Up:
                case Keys.Down:
                    if (!this.dgvSheet.Focused)
                    {
                        this.dgvSheet.Focus();
                    }
                    break;

                case Keys.F2:
                    this.btnAdd_Click(sender, e);
                    break;

                case Keys.F3:
                    this.btnOpen_Click(sender, e);
                    break;

                case Keys.F4:
                    this.btnDel_Click(sender, e);
                    break;
            }
        }

        private void FrmDmSheet_Load(object sender, EventArgs e)
        {
            this.cmbType.SelectedIndex = 0;
            this.cmbStatus.SelectedIndex = 0;
            this.dateStart.Value = DateTime.Now.AddMonths(-1);
            this.txtSheetNO.Focus();
        }

    }
}
