//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL.ViewModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class VIEW_TG_order_P
    {
        public int Id { get; set; }
        public string orderNum { get; set; }
        public string ThingNum { get; set; }
        public string transaction_id { get; set; }
        public string trade_type { get; set; }
        public decimal total_fee { get; set; }
        public Nullable<decimal> yunPrice { get; set; }
        public Nullable<int> fenxiaoId { get; set; }
        public string UserId { get; set; }
        public string userOpenId { get; set; }
        public string userName { get; set; }
        public string userSex { get; set; }
        public string UserTel { get; set; }
        public string UserAddress { get; set; }
        public string UserPostNum { get; set; }
        public Nullable<int> ispay { get; set; }
        public System.DateTime orderTime { get; set; }
        public Nullable<System.DateTime> payTime { get; set; }
        public Nullable<System.DateTime> sendTime { get; set; }
        public Nullable<System.DateTime> GetTime { get; set; }
        public Nullable<System.DateTime> tuiHuoTime { get; set; }
        public string kdName { get; set; }
        public string kdNum { get; set; }
        public string kdMailNum { get; set; }
        public Nullable<int> years { get; set; }
        public Nullable<int> months { get; set; }
        public string remark1 { get; set; }
        public string remark2 { get; set; }
        public string remark3 { get; set; }
        public Nullable<int> flat1 { get; set; }
        public Nullable<int> flat2 { get; set; }
        public string remark4 { get; set; }
        public string remark5 { get; set; }
        public string remark6 { get; set; }
        public Nullable<int> flat7 { get; set; }
        public Nullable<int> flat8 { get; set; }
        public Nullable<System.DateTime> RegTim1 { get; set; }
        public Nullable<System.DateTime> RegTim2 { get; set; }
        public int ssh_status { get; set; }
        public Nullable<int> VERSION { get; set; }
        public string SYNCOPERATION { get; set; }
        public Nullable<System.DateTime> SYNCVERSION { get; set; }
        public string SYNCFLAG { get; set; }
    }
    public partial class VIEW_TG_order:VIEW_TG_order_P
    {
    
    
    
    	public static TG_order ToEntity(VIEW_TG_order model)
        {
           TG_order item = new TG_order();
       		item.Id=model.Id;
    		item.orderNum=model.orderNum;
    		item.ThingNum=model.ThingNum;
    		item.transaction_id=model.transaction_id;
    		item.trade_type=model.trade_type;
    		item.total_fee=model.total_fee;
    		item.yunPrice=model.yunPrice;
    		item.fenxiaoId=model.fenxiaoId;
    		item.UserId=model.UserId;
    		item.userOpenId=model.userOpenId;
    		item.userName=model.userName;
    		item.userSex=model.userSex;
    		item.UserTel=model.UserTel;
    		item.UserAddress=model.UserAddress;
    		item.UserPostNum=model.UserPostNum;
    		item.ispay=model.ispay;
    		item.orderTime=model.orderTime;
    		item.payTime=model.payTime;
    		item.sendTime=model.sendTime;
    		item.GetTime=model.GetTime;
    		item.tuiHuoTime=model.tuiHuoTime;
    		item.kdName=model.kdName;
    		item.kdNum=model.kdNum;
    		item.kdMailNum=model.kdMailNum;
    		item.years=model.years;
    		item.months=model.months;
    		item.remark1=model.remark1;
    		item.remark2=model.remark2;
    		item.remark3=model.remark3;
    		item.flat1=model.flat1;
    		item.flat2=model.flat2;
    		item.remark4=model.remark4;
    		item.remark5=model.remark5;
    		item.remark6=model.remark6;
    		item.flat7=model.flat7;
    		item.flat8=model.flat8;
    		item.RegTim1=model.RegTim1;
    		item.RegTim2=model.RegTim2;
    		item.ssh_status=model.ssh_status;
    		item.VERSION=model.VERSION;
    		item.SYNCOPERATION=model.SYNCOPERATION;
    		item.SYNCVERSION=model.SYNCVERSION;
    		item.SYNCFLAG=model.SYNCFLAG;
            return item;
        }
    
    
    	public static VIEW_TG_order ToViewModel(TG_order model)
        {
           VIEW_TG_order item = new VIEW_TG_order();
       		item.Id=model.Id;
    		item.orderNum=model.orderNum;
    		item.ThingNum=model.ThingNum;
    		item.transaction_id=model.transaction_id;
    		item.trade_type=model.trade_type;
    		item.total_fee=model.total_fee;
    		item.yunPrice=model.yunPrice;
    		item.fenxiaoId=model.fenxiaoId;
    		item.UserId=model.UserId;
    		item.userOpenId=model.userOpenId;
    		item.userName=model.userName;
    		item.userSex=model.userSex;
    		item.UserTel=model.UserTel;
    		item.UserAddress=model.UserAddress;
    		item.UserPostNum=model.UserPostNum;
    		item.ispay=model.ispay;
    		item.orderTime=model.orderTime;
    		item.payTime=model.payTime;
    		item.sendTime=model.sendTime;
    		item.GetTime=model.GetTime;
    		item.tuiHuoTime=model.tuiHuoTime;
    		item.kdName=model.kdName;
    		item.kdNum=model.kdNum;
    		item.kdMailNum=model.kdMailNum;
    		item.years=model.years;
    		item.months=model.months;
    		item.remark1=model.remark1;
    		item.remark2=model.remark2;
    		item.remark3=model.remark3;
    		item.flat1=model.flat1;
    		item.flat2=model.flat2;
    		item.remark4=model.remark4;
    		item.remark5=model.remark5;
    		item.remark6=model.remark6;
    		item.flat7=model.flat7;
    		item.flat8=model.flat8;
    		item.RegTim1=model.RegTim1;
    		item.RegTim2=model.RegTim2;
    		item.ssh_status=model.ssh_status;
    		item.VERSION=model.VERSION;
    		item.SYNCOPERATION=model.SYNCOPERATION;
    		item.SYNCVERSION=model.SYNCVERSION;
    		item.SYNCFLAG=model.SYNCFLAG;
            return item;
        }
    
    	    public static IEnumerable<VIEW_TG_order> ToListViewModel(IEnumerable<TG_order> list)
            {
                var listModel = new List<VIEW_TG_order>();
                foreach (TG_order item in list)
                {
                    listModel.Add(VIEW_TG_order.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

