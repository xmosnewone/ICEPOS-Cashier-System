/********************************************************
 * Description:促销提示窗体
 * ******************************************************/
namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using ICE.POS.Model;
    using System.Windows.Forms;
    public partial class FrmPlan : FrmBase
    {
        #region 窗体声名
        
        
        
        
        public delegate void DelegateSetPlanMaster(List<t_rm_plan_master> _planMasters);
        
        
        
        public event DelegateSetPlanMaster EventSetPlanMaster;
        #endregion
        public FrmPlan(List<t_rm_plan_master> _masters)
        {
            InitializeComponent();
            BindData(_masters);
        }
        #region 事件逻辑
        
        
        
        
        
        private void dgItem_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                SetSelect();
            }
            else
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.btnDm_Click(null, null);
                }
                else if(e.KeyCode== Keys.Escape)
                {
                    base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
        }
        
        
        
        
        
        private void dgItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if (((this.dgItem != null) && (this.dgItem.Rows.Count > 0)) && (e.ColumnIndex == 0))
            //{
            //    //this.dgItem.CurrentRow.Cells[e.ColumnIndex].Value = false;
            //    return;
            //}
        }

        
        
        
        
        
        private void dgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SetSelect();
            }
            
        }
        
        
        
        
        
        private void btnDm_Click(object sender, EventArgs e)
        {
            List<t_rm_plan_master> planMasters = new List<t_rm_plan_master>();
            for (int i = 0; i < this.dgItem.Rows.Count; i++)
            {
                t_rm_plan_master master = this.dgItem.Rows[i].DataBoundItem as t_rm_plan_master;
                bool flag = master.isSelect;
                if (flag)
                {
                    planMasters.Add(master);
                }
            }

            if (planMasters.Count == 0)
            {
                if (MessageBox.Show("确定不选择优惠活动?", Gattr.AppTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
                else
                {
                    base.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
            else
            {
                t_rm_plan_master currentmaster = this.dgItem.CurrentRow.DataBoundItem as t_rm_plan_master;
                if (EventSetPlanMaster != null)
                {
                    EventSetPlanMaster(planMasters);
                }
                base.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        #endregion
        #region 私有方法
        #region 绑定数据
        private void BindData(List<t_rm_plan_master> _masters)
        {
            this.dgItem.AutoGenerateColumns = false;
            this.dgItem.DataSource = _masters;
        }
        
        
        
        private void SetSelect()
        {
            if (this.dgItem.Rows.Count > 0)
            {
                int index = this.dgItem.CurrentRow.Index;
                this.dgItem.CurrentCell = this.dgItem[0, index];
                t_rm_plan_master currentMaster = this.dgItem.CurrentRow.DataBoundItem as t_rm_plan_master;
                bool flag = currentMaster.isSelect;
                if (!flag)
                {
                    string proCls = currentMaster.range_flag;//当前选中的范围
                    string text3 = currentMaster.PlanPara.typeValue;//范围
                    //string text = this.dgItem[1, index].Value.ToString();//类型
                    //string text2 = this.dgItem[3, index].Value.ToString();//规则描述
                    //string text3 = this.dgItem[4, index].Value.ToString().Trim();//范围
                    //string proCls = this.GetProCls(text2.Trim());//当前选中的范围
                    for (int i = 0; i < this.dgItem.Rows.Count; i++)
                    {
                        t_rm_plan_master _master = this.dgItem.Rows[i].DataBoundItem as t_rm_plan_master;
                        string proCls2 = _master.range_flag;
                        bool flag2 = _master.isSelect;
                        string a = _master.PlanPara.typeValue;
                        if (proCls == "A")
                        {
                            if (i != index)
                            {
                                if (flag2)
                                {
                                    if (proCls2 == "A")
                                    {
                                        MessageBox.Show(this, "只能选择一种全场促销！");
                                    }
                                    else
                                    {
                                        MessageBox.Show(this, "已选择其他买满促销，不能在选择全场促销！");
                                    }
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (i != index && proCls2 != proCls)
                            {
                                string range = "全场";
                                if (_master.range_flag == "C")
                                {
                                    range = "分类";
                                }
                                else if (_master.range_flag == "B")
                                {
                                    range = "品牌";
                                }
                                else if (_master.range_flag == "I")
                                {
                                    range = "商品";
                                }
                                if (flag2)
                                {
                                    MessageBox.Show(this, "已选择促销范围[" + range + "]，不能在选择其他促销范围！");
                                    return;
                                }
                            }
                            if (i != index && a == text3)
                            {
                                if (flag2)
                                {
                                    string itemName = "";
                                    if (_master.range_flag == "C")
                                    {
                                        itemName = Gattr.Bll.GetClsNameByClsNo(a);
                                    }
                                    else if (_master.range_flag == "B")
                                    {
                                        itemName = Gattr.Bll.GetBrandName(a);
                                    }
                                    else if (_master.range_flag == "I")
                                    {
                                        itemName = Gattr.Bll.GetItemName(a);
                                    }
                                    MessageBox.Show(this, "已选择该促销明细[" + itemName + "]，不能在选择其他相同的促销明细！");
                                    return;
                                }
                            }
                        }
                    }
                }
                this.dgItem.BeginEdit(true);
                this.dgItem[0, index].Value = !flag;
                this.dgItem.EndEdit();
            }
        }
        #endregion


        #endregion
    }
}
