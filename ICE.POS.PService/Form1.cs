using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICE.Utility;
using ICE.POS.Model;

namespace ICE.POS.PService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> _dic = new Dictionary<string, object>();
                _dic.Add("access_token", "c2e3c130b7040fbe18e7f9b319844b42558aeb34");
                _dic.Add("client_id", "POS");
                _dic.Add("username", "1020");
                _dic.Add("password", "35393837");
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/getbrninfo", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getitemcls", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getbarcode", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getiteminfo", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getbasecode", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getbase", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getoper", _dic);
                _dic.Add("branch_no", "004");
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getstock", _dic);
                //_dic.Add("item_no", "001097");
                //_dic.Add("qty", "10");
                //_dic.Add("db_no", "+");
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Updatestock", _dic);
                // string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getpayinfo", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getkey", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getposstatus", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getbraprc", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getprule", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getpmaster", _dic);
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getpdetail", _dic);
                _dic.Add("trans_no", "YH");
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getsheet", _dic);
                _dic.Add("sheet_no", "YH0041408160013");
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Getsdetail", _dic);
                string _master = GenerateYhMasterData();
                string _detail = GenerYhDetailData();
                _dic.Add("master", _master);
                _dic.Add("detail", _detail);
                _dic.Add("add", "edit");
                //string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Addpsheet", _dic);
                string _pay = GeneratePayData();
                string _sale = GenerateSaleData();
                _dic.Add("pay", _pay);
                _dic.Add("sale", _sale);
                string result = PServiceProvider.Instance.InvokeMethod("http://icepos.cc/api/api/Addflow", _dic);
                this.label1.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GeneratePayData()
        {
            List<t_pos_payflow> pays = new List<t_pos_payflow>();
            t_pos_payflow pay = new t_pos_payflow();
            pay.branch_no = "004";
            pay.card_no = "15020364165";
            pay.coin_rate = 0;
            pay.coin_type = "";
            pay.com_flag = "1";
            pay.convert_amt = 0m;
            pay.flow_id = 1;
            pay.flow_no = "0041408160001";
            pay.memo = "tetst";
            pay.oper_date = ExtendUtility.Instance.ParseToDateTime(System.DateTime.Now.ToShortDateString());
            pay.oper_id = "1020";
            pay.pay_amount = 150;
            pay.pay_name = "人民币";
            pay.pay_way = "RMB";
            pay.pos_id = "1001";
            pay.sale_amount = 150;
            pay.sale_way = "A";
            pay.vip_no = "";
            pay.voucher_no = "";
            pays.Add(pay);
            string result = JsonUtility.Instance.ObjectToJson<t_pos_payflow>(pays);
            return result;
        }
        private string GenerateSaleData()
        {
            List<t_pos_saleflow> sales = new List<t_pos_saleflow>();
            t_pos_saleflow sale = new t_pos_saleflow();
            sale.branch_no = "004";
            sale.com_flag = "1";
            sale.discount_rate = 0M;
            sale.flow_id = 1;
            sale.flow_no = "0041408160001";
            sale.in_price = 0;
            sale.item_brand = "7M";
            sale.item_clsno = "4002";
            sale.item_name = "Test";
            sale.item_no = "1002";
            sale.item_status = "1";
            sale.item_subname = "tEST";
            sale.item_subno = "1414";
            sale.oper_date = ExtendUtility.Instance.ParseToDateTime(System.DateTime.Now.ToShortDateString());
            sale.oper_id = "1020";
            sale.plan_no = "";
            sale.pos_id = "1001";
            sale.reasonid = null;
            sale.sale_money = 150;
            sale.sale_price = 152;
            sale.sale_qnty = 1;
            sale.sell_way = "A";
            sale.unit_price = 153;
            sales.Add(sale);
            string result = JsonUtility.Instance.ObjectToJson<t_pos_saleflow>(sales);
            return result;
        }
        private string GenerateYhMasterData()
        {
            t_pm_sheet_master _master = new t_pm_sheet_master();
            _master.sheet_no = "YH0041408160013";
            _master.trans_no = "YH";
            _master.branch_no = "003";
            _master.d_branch_no = "004";
            _master.oper_id = "1020";
            _master.valid_date = ExtendUtility.Instance.ParseToDateTime(System.DateTime.Now.ToShortDateString());
            _master.sheet_amt = 100.52M;
            _master.memo = "Test2333333333333333";
            List<t_pm_sheet_master> _masters = new List<t_pm_sheet_master>();
            _masters.Add(_master);
            string result = JsonUtility.Instance.ObjectToJson<t_pm_sheet_master>(_masters);
            return result;
        }
        private string GenerYhDetailData()
        {
            t_pm_sheet_detail _detail = new t_pm_sheet_detail();
            _detail.sheet_no = "YH0041408160013";
            _detail.item_no = "10003";
            _detail.real_qty = 11;
            _detail.other1 = "Test";
            List<t_pm_sheet_detail> _details = new List<t_pm_sheet_detail>();
            _details.Add(_detail);
            string result = JsonUtility.Instance.ObjectToJson<t_pm_sheet_detail>(_details);
            return result;
        }
    }
}
