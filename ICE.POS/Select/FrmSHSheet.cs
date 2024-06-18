namespace ICE.POS
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Collections;
    using System.Windows.Forms;
    using ICE.POS.Common;
    using ICE.Utility;
    public partial class FrmSHSheet : FrmBase
    {
        public FrmSHSheet()
        {
            InitializeComponent();
            this.Text = Gattr.AppTitle;
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
                    using (FrmSHSheetDetail detail = new FrmSHSheetDetail(dataRow))
                    {
                        if (detail.ShowDialog() == DialogResult.Cancel)
                        {
                            this.btnSearch_Click(null, null);
                        }
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
            DateTime startDate = DateTime.Parse(this.dateStart.Value.ToShortDateString() + " 00:00");
            DateTime endDate = DateTime.Parse(this.dateEnd.Value.ToShortDateString() + " 23:59");
            if (endDate < startDate)
            {
                MessageBox.Show("结束时间要比开始时间大", Gattr.AppTitle);
            }
            else
            {
                //配置POS信息
                BaseInfoService.Instance.BranchNO = Gattr.BranchNo;
                BaseInfoService.Instance.SheetNO = this.txtSheetNO.Text.Trim();
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
                        //接口参数
                        Dictionary<string, object> _dic = Gfunc.GetServiceParameter();
                        _dic.Add("branch_no", Gattr.BranchNo);
                        _dic.Add("start", startDate.ToString());
                        _dic.Add("end", endDate.ToString());
                        _dic.Add("sheet_no", txtSheetNO.Text.Trim());
                        bool isok1 = true;
                        string errorMessage = string.Empty;
                        //参数提交
                        string result = PServiceProvider.Instance.InvokeMethod(Gattr.serverUrl + "/Getmosheet", _dic, ref isok1, ref errorMessage);
                        if (isok1)
                        {
                            if (result != "-10" && result != "-20" && result != "-2" && result != "-1")
                            {
                                //Json转换Table
                                DataTable table = JsonUtility.Instance.JsonToDataTable(result);
                                if (table != null && table.Rows.Count > 0)
                                {
                                    this.dgvSheet.DataSource = table;
                                }
                                else
                                {
                                    MessageBox.Show("没有找到数据", Gattr.AppTitle);
                                }
                                LoggerHelper.Log("MsmkLogger", System.DateTime.Now.ToString() + "【" + Gattr.OperId + "】查看收货单！", LogEnum.SysLog);
                            }
                            else
                            {
                                if (result == "-10")
                                {
                                    //参数错误
                                    MessageBox.Show("参数错误", Gattr.AppTitle);
                                }
                                else if (result == "-20")
                                {
                                    //禁止操作
                                    MessageBox.Show("禁止操作", Gattr.AppTitle);
                                }
                                else if (result == "-2")
                                {
                                    //操作异常
                                    MessageBox.Show("操作异常", Gattr.AppTitle);
                                }
                                else
                                {
                                    //数据库连接失败
                                    MessageBox.Show("数据库连接失败", Gattr.AppTitle);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, Gattr.AppTitle);
                        }
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
                    using (FrmSHSheetDetail detail = new FrmSHSheetDetail(obj))
                    {
                        if (detail.ShowDialog() == DialogResult.Cancel)
                        {
                            this.btnSearch_Click(null, null);
                        }
                    }
                }
            }
        }

        private void FrmSHSheet_KeyDown(object sender, KeyEventArgs e)
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

                case Keys.F3:
                    this.btnOpen_Click(sender, e);
                    break;
            }
        }

        private void FrmSHSheet_Load(object sender, EventArgs e)
        {
            this.dateStart.Value = DateTime.Now.AddMonths(-1);
            this.txtSheetNO.Focus();
        }

    }
}
