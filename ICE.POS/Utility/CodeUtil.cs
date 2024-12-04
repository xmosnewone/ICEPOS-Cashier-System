namespace ICE.POS
{
    using System;
    using System.Collections.Generic;
    public static class CodeUtil
    {
        //判断是否超市自编码
        public static bool isShopCode(string code) {

            bool result = false;
            string codeStart = Gattr.codeStart;

            if ((code.Length == 13|| code.Length == 18) && code.Substring(0, 2).Equals(codeStart))
            {
                result = true;
            }
            return result;
        }

        //拆解自编号返回货号、单价、重量、或者小计金额
        public static Dictionary<string, string> getGoodInfo(string code)
        {
            var array = new Dictionary<string, string>();
            if (!CodeUtil.isShopCode(code)) {

                array.Add("goodCode", "");
                return array;
            }

            string codeStart = Gattr.codeStart;
            int length = code.Length;
            int codeType = Gattr.codeType;

            string goodCode = "";
            decimal goodPrice = 0;//单价
            decimal goodMoney = 0;//总金额
            decimal goodWeight = 0;//重量
            int needToSum = 0;//是否需要计算总价

            //3-7位是商品货号
            goodCode = code.Substring(2, 5);

            //13位编码或18位编码
            if (length == 13) {

                if (codeType == 2)
                {
                    //代表8-12位是总金额
                    string strPrice = code.Substring(7, 3) + "." + code.Substring(10, 2);
                    goodMoney = Convert.ToDecimal(strPrice);
                }
                else {
                    //代表8-12位是重量
                    string strWeight = code.Substring(7, 5);
                    goodWeight = Convert.ToDecimal(strWeight);
                    needToSum = 1;
                }

            } else if (length==18) {

                string strWeight = code.Substring(7, 5);
                string strPrice = code.Substring(12, 3) + "." + code.Substring(15, 2);

                if (codeType == 2)
                {
                    //代表8-12位是重量+金额
                    goodWeight = Convert.ToDecimal(strWeight);
                    goodMoney = Convert.ToDecimal(strPrice);
                }
                else
                {
                    //代表8-12位是重量+单价
                    goodWeight = Convert.ToDecimal(strWeight);
                    goodPrice = Convert.ToDecimal(strPrice);
                    goodMoney = Math.Round(goodWeight* goodPrice,2);
                }
            }

            array.Add("goodCode", goodCode);
            array.Add("goodPrice", goodPrice.ToString());
            array.Add("goodMoney", goodMoney.ToString());
            array.Add("goodWeight", goodWeight.ToString());
            array.Add("needToSum", needToSum.ToString());

            return array;

        }


    }
}
