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
    
    public partial class VIEW_TG_tuihuo_P
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public string orderNum { get; set; }
        public string transaction_id { get; set; }
        public string userName { get; set; }
        public string UserTel { get; set; }
        public Nullable<System.DateTime> orderTime { get; set; }
        public string linkTel { get; set; }
        public Nullable<int> tkType { get; set; }
        public string tkInfo { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
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
    }
    public partial class VIEW_TG_tuihuo:VIEW_TG_tuihuo_P
    {
    
    
    
    	public static TG_tuihuo ToEntity(VIEW_TG_tuihuo model)
        {
           TG_tuihuo item = new TG_tuihuo();
       		item.Id=model.Id;
    		item.orderId=model.orderId;
    		item.orderNum=model.orderNum;
    		item.transaction_id=model.transaction_id;
    		item.userName=model.userName;
    		item.UserTel=model.UserTel;
    		item.orderTime=model.orderTime;
    		item.linkTel=model.linkTel;
    		item.tkType=model.tkType;
    		item.tkInfo=model.tkInfo;
    		item.AddTime=model.AddTime;
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
            return item;
        }
    
    
    	public static VIEW_TG_tuihuo ToViewModel(TG_tuihuo model)
        {
           VIEW_TG_tuihuo item = new VIEW_TG_tuihuo();
       		item.Id=model.Id;
    		item.orderId=model.orderId;
    		item.orderNum=model.orderNum;
    		item.transaction_id=model.transaction_id;
    		item.userName=model.userName;
    		item.UserTel=model.UserTel;
    		item.orderTime=model.orderTime;
    		item.linkTel=model.linkTel;
    		item.tkType=model.tkType;
    		item.tkInfo=model.tkInfo;
    		item.AddTime=model.AddTime;
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
            return item;
        }
    
    	    public static IEnumerable<VIEW_TG_tuihuo> ToListViewModel(IEnumerable<TG_tuihuo> list)
            {
                var listModel = new List<VIEW_TG_tuihuo>();
                foreach (TG_tuihuo item in list)
                {
                    listModel.Add(VIEW_TG_tuihuo.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

