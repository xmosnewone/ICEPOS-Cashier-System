using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.POS.Model;
using ICE.Utility;
using ICE.POS.Common;
namespace ICE.POS
{
    public partial class FrmCPayWay : FrmBase
    {
        t_pos_payflow _pay = new t_pos_payflow();
        private string _flowno = string.Empty;
        private decimal saleAmount = 0M;//商品总金额
        private bool isArrearage = false;//是否是挂账记录
        public FrmCPayWay()
        {
            InitializeComponent();
        }
        public FrmCPayWay(string _flow_no,bool _isArrearage)
        {
            InitializeComponent();
            isArrearage = _isArrearage;
            if (isArrearage)
            {
                _flowno = _flow_no;
                tbox_No.Text = _flow_no;
                tbox_No.Enabled = false;
                btn_Query.Enabled = false;
                btn_Alter.Enabled = false;
                lblTitle.Text = "挂账回款信息";
                LoadData();
            }
        }
        private void btn_Query_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        
        
        
        void LoadData()
        {
            String operate = "=";
            if (tbox_No.Text == string.Empty)
            {
                MessageBox.Show("请输入订单号！", Gattr.AppTitle);
                return;
            }
            else
            {
                _flowno = tbox_No.Text;
            }
            DataTable table = Gattr.Bll.GetMaxPayFlowInfo(Gattr.BranchNo, Gattr.PosId, _flowno, operate);
            dgvPay.AutoGenerateColumns = false;
            dgvPay.DataSource = table;
            if (table != null && table.Rows.Count > 0)
            {
                string saleway = SIString.TryStr(table.Rows[0]["sale_way"]);
                tbox_No.Text = SIString.TryStr(table.Rows[0]["flow_no"]);
                _pay.flow_id = ExtendUtility.Instance.ParseToInt32(table.Rows[0]["flow_id"]);
                _pay.flow_no = ExtendUtility.Instance.ParseToString(table.Rows[0]["flow_no"]);
                saleAmount = ExtendUtility.Instance.ParseToDecimal(table.Rows[0]["sale_amount"]);
                _pay.oper_id = ExtendUtility.Instance.ParseToString(table.Rows[0]["oper_id"]);
                _pay.oper_date = ExtendUtility.Instance.ParseToDateTime(table.Rows[0]["oper_date"]).ToString("s");
                _pay.pos_id = ExtendUtility.Instance.ParseToString(table.Rows[0]["pos_id"]);
                _pay.branch_no = ExtendUtility.Instance.ParseToString(table.Rows[0]["branch_no"]);
                _pay.sale_amount = saleAmount;

                if (saleway == "A" || saleway == "D")
                {
                    _pay.sale_way = "A";
                }
                else 
                {
                    if (!isArrearage)
                    {
                        MessageBox.Show(tbox_No.Text + "不是有效的销售订单", Gattr.AppTitle);
                        return;
                    }
                }
                DataTable tablePayWay = Gattr.Bll.GetPayFlowInfoDataTableByFlowNo(tbox_No.Text);
                //判断是不是赠送的订单，单个商品一个订单  赠送  sale_way A , pay_amount 0
                if (tablePayWay.Rows.Count == 1 && ExtendUtility.Instance.ParseToDecimal(table.Rows[0]["pay_amount"]) == 0)
                {
                    MessageBox.Show(tbox_No.Text + "不是有效的销售订单", Gattr.AppTitle);
                }
                else
                {
                    for (int i = 0; i < tablePayWay.Rows.Count; i++)
                    {
                        //移除GZ的挂账记录，仅获取此单回款记录
                        if (ExtendUtility.Instance.ParseToString(tablePayWay.Rows[i]["pay_way"]) == "GZ")
                        {
                            tablePayWay.Rows.Remove(tablePayWay.Rows[i]);
                        }
                    }
                    btn_Add.Enabled = true;
                    btn_Alter.Enabled = true;
                    dgvPayWay.AutoGenerateColumns = false;
                    dgvPayWay.DataSource = tablePayWay;
                }
            }
            else
            {
                if (tbox_No.Text.Trim().Length > 0)
                {
                    MessageBox.Show("没有找到流水号[" + tbox_No.Text + "]的订单", Gattr.AppTitle);
                }
            }
        }
        //添加支付流水
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (_pay.flow_no != null)
            {
                if (_pay.oper_id == Gattr.OperId)
                {
                    FrmPayWayAlter frmPayWayAlter = new FrmPayWayAlter(_pay, true, isArrearage);
                    DialogResult resultPayWay = frmPayWayAlter.ShowDialog();
                    if (resultPayWay == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("您无权限操作本单！只可以修改自己的单据");
                    LoggerHelper.Log("MsmkLogger", Gattr.OperId + "试图操作无权限挂账订单" + _pay.flow_no, LogEnum.SysLog);
                }
            }
            else
            {
                MessageBox.Show("未查询到订单！");
            }
        }

        //支付流水修改
        private void btn_Alter_Click(object sender, EventArgs e)
        {
            if (_pay.flow_no != null || this.dgvPayWay.Rows.Count<1)
            {
                if (ExtendUtility.Instance.ParseToDateTime(_pay.oper_date).ToString("yyyy/MM/dd") == System.DateTime.Now.Date.ToString("yyyy/MM/dd"))
                {
                    if (_pay.oper_id == Gattr.OperId)
                    {
                        //当前流水的交易方式
                        string payName = ExtendUtility.Instance.ParseToString(this.dgvPayWay.Rows[this.dgvPayWay.CurrentRow.Index].Cells["pay_name"].Value.ToString().Trim());
                        if (payName == "余额支付" || payName == "人民币付款找零")
                        {
                            MessageBox.Show(payName + "支付禁止修改！", Gattr.AppTitle);
                            return;
                        }
                        _pay.flow_id = ExtendUtility.Instance.ParseToInt32(this.dgvPayWay.Rows[this.dgvPayWay.CurrentRow.Index].Cells["flow_id"].Value.ToString().Trim());
                        _pay.pay_amount = ExtendUtility.Instance.ParseToDecimal(this.dgvPayWay.Rows[this.dgvPayWay.CurrentRow.Index].Cells["pay_amount"].Value.ToString().Trim());
                        FrmPayWayAlter frmPayWayAlter = new FrmPayWayAlter(_pay, false, isArrearage);
                        DialogResult resultPayWay = frmPayWayAlter.ShowDialog();
                        //修改成功则重新获取当前订单的支付信息
                        if (resultPayWay == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("您无权限操作本单！只可以修改自己的单据");
                        LoggerHelper.Log("MsmkLogger", Gattr.OperId + "试图操作无权限挂账订单" + _pay.flow_no, LogEnum.SysLog);
                    }
                }
                else
                {
                    MessageBox.Show("只可以修改当日的单据");
                }
            }
            else
            {
                MessageBox.Show("未查询到订单！");
            }
        }

        private void btn_ESC_Click(object sender, EventArgs e)
        {
            decimal allAmount = 0M;
            //支付金额等于订单金额时才可以退出
            for (int i = 0; i < dgvPayWay.Rows.Count; i++)
            {
                string payName2 = ExtendUtility.Instance.ParseToString(this.dgvPayWay.Rows[i].Cells["pay_name"].Value.ToString().Trim());
                if (payName2 == "人民币付款找零")
                {
                    allAmount -= ExtendUtility.Instance.ParseToDecimal(this.dgvPayWay.Rows[i].Cells["pay_amount"].Value.ToString().Trim());
                }
                else
                {
                    allAmount += ExtendUtility.Instance.ParseToDecimal(this.dgvPayWay.Rows[i].Cells["pay_amount"].Value.ToString().Trim());
                }
            }
            if (allAmount != saleAmount)
            {
                if (dgvPayWay.Rows.Count > 0)
                {
                    if (isArrearage)
                    {
                        if (saleAmount > allAmount)
                        {
                            //部分付款
                            _pay.sale_way = "EB";
                            _pay.oper_date = DateTime.Now.ToString("s");
                            if (Gattr.Bll.UpdatePayFlowStatus(_pay))
                            {
                                LoggerHelper.Log("MsmkLogger", Gattr.OperId + "完成" + _pay.flow_no + "部分回款", LogEnum.SysLog);
                            }
                            else
                            {
                                LoggerHelper.Log("MsmkLogger", Gattr.OperId + "挂账回款" + _pay.flow_no + "部分回款更新失败", LogEnum.SysLog);
                            }
                        }
                        else
                        {
                            MessageBox.Show("支付总金额不能大于挂账金额！");
                            LoggerHelper.Log("MsmkLogger", Gattr.OperId + "挂账回款" + _pay.flow_no + "支付总金额不能大于挂账金额！", LogEnum.SysLog);
                            btn_Alter.Enabled = true;
                            this.DialogResult = DialogResult.None;
                        }
                    }
                    else
                    {
                        MessageBox.Show("支付流水总金额与订单总金额不一致，无法退出！");
                        LoggerHelper.Log("MsmkLogger", Gattr.OperId + "挂账回款" + _pay.flow_no + "时支付流水总金额与订单总金额不一致，无法退出！", LogEnum.SysLog);
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
            else
            {
                if (isArrearage)
                {
                    //更改为全部付款
                    _pay.sale_way = "EQ";
                    _pay.oper_date = DateTime.Now.ToString("s");
                    if (Gattr.Bll.UpdatePayFlowStatus(_pay))
                    {
                        LoggerHelper.Log("MsmkLogger", Gattr.OperId + "完成" + _pay.flow_no + "全部回款", LogEnum.SysLog);
                    }
                    else
                    {
                        LoggerHelper.Log("MsmkLogger", Gattr.OperId + "挂账回款" + _pay.flow_no + "全部回款更新失败！", LogEnum.SysLog);
                    }
                }
            }
        }

        private void tbox_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }
        
        
        
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }
        }
    }
}
