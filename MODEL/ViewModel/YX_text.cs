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
    
    public partial class VIEW_YX_text_P
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string msgContent { get; set; }
        public string EventCate { get; set; }
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
    public partial class VIEW_YX_text:VIEW_YX_text_P
    {
    
    
    
    	public static YX_text ToEntity(VIEW_YX_text model)
        {
           YX_text item = new YX_text();
       		item.Id=model.Id;
    		item.EventId=model.EventId;
    		item.msgContent=model.msgContent;
    		item.EventCate=model.EventCate;
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
    
    
    	public static VIEW_YX_text ToViewModel(YX_text model)
        {
           VIEW_YX_text item = new VIEW_YX_text();
       		item.Id=model.Id;
    		item.EventId=model.EventId;
    		item.msgContent=model.msgContent;
    		item.EventCate=model.EventCate;
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
    
    	    public static IEnumerable<VIEW_YX_text> ToListViewModel(IEnumerable<YX_text> list)
            {
                var listModel = new List<VIEW_YX_text>();
                foreach (YX_text item in list)
                {
                    listModel.Add(VIEW_YX_text.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

