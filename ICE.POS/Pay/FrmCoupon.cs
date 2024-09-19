using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using ICE.POS.Model;
using ICE.POS.Common;
using ICE.Utility;



namespace ICE.POS
{

    public partial class FrmCoupon : FrmBase
    {

        public delegate void DelegateSetCoupon(List<t_pos_coupon> _pos_coupon);



        public event DelegateSetCoupon EventSetPosCoupon;

        //判断优惠券状态
        private bool CouponStatus = false;

        //返回扫描的授权码
        private string _returnCode = "";

        //订单支付金额
        private decimal _payAmt = 0;

       //DataGrid 数据
        public List<t_pos_coupon> couponList;

        //记录主窗口当前账单所有已使用的优惠券
        public List<t_pos_coupon> FrmcouponUsed;

        public FrmCoupon(decimal payAmt,List<t_pos_coupon> _couponUsed)
        {
            InitializeComponent();

            this._payAmt = payAmt;

            this.cpNo.Focus();

            this.dgItem.AutoGenerateColumns = false;

            this.couponList = new List<t_pos_coupon>();

            this.FrmcouponUsed = new List<t_pos_coupon>();

            this.FrmcouponUsed = _couponUsed;
        }

        private void couponCancle(object sender, EventArgs e)
        {
            this.Hide();
        }

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
                else if (e.KeyCode == Keys.Escape)
                {
                    base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
        }

        //设置列表数据
        private void BindData(List<t_pos_coupon> _couponList)
        {
            this.dgItem.DataSource = null;
            this.dgItem.DataSource = _couponList;
            this.dgItem.Refresh();
        }

        private void btnDm_Click(object sender, EventArgs e)
        {
            List<t_pos_coupon> PosCoupon = new List<t_pos_coupon>();
            for (int i = 0; i < this.dgItem.Rows.Count; i++)
            {
                t_pos_coupon row = this.dgItem.Rows[i].DataBoundItem as t_pos_coupon;
                bool flag = row.isSelect;
                if (flag)
                {
                    PosCoupon.Add(row);
                }
            }

            if (PosCoupon.Count == 0)
            {
                if (MessageBox.Show("确定不选择优惠券?", Gattr.AppTitle, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
                t_pos_coupon currentmaster = this.dgItem.CurrentRow.DataBoundItem as t_pos_coupon;
                if (EventSetPosCoupon != null)
                {
                    EventSetPosCoupon(PosCoupon);
                }
                base.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void dgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SetSelect();
            }

        }

        private void SetSelect()
        {
            if (this.dgItem.Rows.Count > 0)
            {
                int index = this.dgItem.CurrentRow.Index;
                this.dgItem.CurrentCell = this.dgItem[0, index];
                t_pos_coupon current = this.dgItem.CurrentRow.DataBoundItem as t_pos_coupon;
                bool flag = current.isSelect;

                this.dgItem.BeginEdit(true);
                this.dgItem[0, index].Value = true;
                this.dgItem.EndEdit();
            }
        }

        //窗口按钮事件
        private void Frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                return;
            }

            switch (e.KeyCode)
            {

                case Keys.Enter:
                    this.onScancode();
                    break;
                case Keys.Escape:
                    base.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }

        }


        //检测输入
        private void onScancode()
        {
            String _result = String.Empty;
            this._returnCode = this.cpNo.Text.Trim();

            if (this._returnCode=="") {
                return;
            }

            //查询主窗口券码是否已存在
            if (this.FrmcouponUsed.Count>0)
            {
                for (int i = 0; i < this.FrmcouponUsed.Count; i++)
                {
                    t_pos_coupon tpc = this.FrmcouponUsed[i];
                    String g_no = tpc.giftcert_no;
                    if (g_no== _returnCode) {
                        this.mention.Text = "该券码已在本单中使用";
                        return;
                    }
                }
             }

            this.mention.Text = "券码检测中,请稍后..";
            //执行查询
            t_pos_coupon _temp = MemberService.Instance.CounponCheck(this._returnCode, this._payAmt);

            if (_temp.code == "1")
            {
                bool    repeat = false;
                bool    conflit = false;
                bool    limited = false;
                int     used = 0;//统计跟当前录入优惠券同种类的其他优惠券已用数量

                String type = _temp.gift_type;//种类id
                int is_com = _temp.is_com;//是否互斥，1是可以组合，0是互斥
                String no = _temp.giftcert_no;//券码
                int max_num = _temp.max_num;//限制使用张数，0则不限制
                decimal min_amount = _temp.min_amount;//要使用优惠券的最低消费金额

                if (min_amount>0&&this._payAmt<min_amount) {
                    this.mention.Text = "该优惠券可用的最低消费金额是：" + (min_amount.ToString());
                    this.clearInput();
                    return;
                }


                if (max_num>0) {
                    //有最大使用量限制
                    limited = true;
                }

                //对比是否已存在列表中
                for (int i = 0; i < this.couponList.Count; i++)
                {
                        t_pos_coupon tpc = this.couponList[i];
                        String no1 = tpc.giftcert_no;
                        String type1 = tpc.gift_type;
                        int is_com1 = tpc.is_com;
                        
                        //与已经在列表中的不同种类的优惠券互斥
                        if (type!=type1&& (is_com==0|| is_com1==0)) {
                                conflit = true;
                                break;
                        }

                        //同分类的优惠券限制使用数量
                        if (type==type1&& max_num>0) {
                            used += 1;
                        }


                        //判断是否重复券号
                        if (no1 == no)
                        {
                            repeat = true;
                            break;
                        }

                 
                }//end of for

                if (conflit) {
                    this.mention.Text = "该优惠券或其他已使用优惠券不能组合使用";
                    this.clearInput();
                    return;
                }

                if (repeat)
                {
                    this.mention.Text = "该优惠券已登记在列表中";
                    this.clearInput();
                    return;
                }

                if (limited && used >= max_num)
                {
                    this.mention.Text = "该种类优惠券已使用超过限制的数量";
                    this.clearInput();
                    return;
                }
                
                try
                {
                    this.couponList.Add(_temp);
                    this.BindData(this.couponList);
                    this.clearInput(true);
                    return;
                }
                catch (Exception)
                {
                    this.mention.Text = "优惠券使用错误,请重试";
                    this.cpNo.Text = "";
                }
                
            }
            else {

                this.mention.Text = _temp.info;
            }

            this.clearInput();
            return;
        }

        //删除已输入券码
        public void clear_code(object sender, EventArgs e) {

            this.clearInput(true);
        }

        public void clearInput(bool clearMetion=false) {

            this._returnCode = "";
            this.cpNo.Text = "";
            if (clearMetion) {
                //删除提示信息
                this.mention.Text = "";
            }
        }

        //删除勾选的券
        private void delBtn_Click(object sender, EventArgs e)
        {
            List<t_pos_coupon> PosCoupon = new List<t_pos_coupon>();
            for (int i = 0; i < this.dgItem.Rows.Count; i++)
            {
                t_pos_coupon row = this.dgItem.Rows[i].DataBoundItem as t_pos_coupon;
                bool flag = row.isSelect;
                if (flag)
                {
                    PosCoupon.Add(row);
                }
            }

            if (PosCoupon.Count<=0) {
                MessageBox.Show("请选择要删除的优惠券");
                return;
            }

            for (int i = 0; i < PosCoupon.Count; i++)
            {
                t_pos_coupon tpc =  PosCoupon[i];
                String no = tpc.giftcert_no;
                for (int k = 0; k < this.couponList.Count; k++)
                {
                    t_pos_coupon tpc1 = this.couponList[k];
                    String no1 = tpc1.giftcert_no;
                    if (no== no1)
                    {
                        //删除对应键
                        this.couponList.RemoveAt(k);
                        break;
                    }
                }

             }

            this.BindData(this.couponList);

        }






    }
}
