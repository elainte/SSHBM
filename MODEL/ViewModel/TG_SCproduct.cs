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
    
    public partial class VIEW_TG_SCproduct_P
    {
        public int Id { get; set; }
        public Nullable<int> userId { get; set; }
        public string opneid { get; set; }
        public Nullable<int> pid { get; set; }
        public Nullable<System.DateTime> ddTime { get; set; }
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
    public partial class VIEW_TG_SCproduct:VIEW_TG_SCproduct_P
    {
    
    
    
    	public static TG_SCproduct ToEntity(VIEW_TG_SCproduct model)
        {
           TG_SCproduct item = new TG_SCproduct();
       		item.Id=model.Id;
    		item.userId=model.userId;
    		item.opneid=model.opneid;
    		item.pid=model.pid;
    		item.ddTime=model.ddTime;
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
    
    
    	public static VIEW_TG_SCproduct ToViewModel(TG_SCproduct model)
        {
           VIEW_TG_SCproduct item = new VIEW_TG_SCproduct();
       		item.Id=model.Id;
    		item.userId=model.userId;
    		item.opneid=model.opneid;
    		item.pid=model.pid;
    		item.ddTime=model.ddTime;
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
    
    	    public static IEnumerable<VIEW_TG_SCproduct> ToListViewModel(IEnumerable<TG_SCproduct> list)
            {
                var listModel = new List<VIEW_TG_SCproduct>();
                foreach (TG_SCproduct item in list)
                {
                    listModel.Add(VIEW_TG_SCproduct.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

