namespace ICE.POS.Common
{
   
    public enum PosOpType
    {
        PLU = 1,
        数量, //NUM = 2,
        删除, //DEL = 3,
        单价,//PRC = 4,
        折扣, //DCT = 5,
        挂单,// GDJ=6,
        会员, //VIP,
        营业员,//DOU,
        结算,//TOT,
        其他,//OTH,
        退出,//exit
        现金,//RMB,
        银行卡,// CDT,
        储值卡,//CSC,
        购物券,// GWQ,
        支付宝,//ZFB
        微信支付,//wechat
        余额支付,//yezf
        整单赠送,//AZS
        挂账,//AGZ
        其他方式,//
        整单折扣,//ADS,
        整单取消,//ACA
        支付退出,//payesc
        退货,//ret
        交易查询,//
        优惠券,//coupon 
        开钱箱 //opd
    }
}
