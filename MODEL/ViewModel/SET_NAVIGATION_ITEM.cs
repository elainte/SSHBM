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
    
    public partial class VIEW_SET_NAVIGATION_ITEM_P
    {
        public string ID { get; set; }
        public string PARENTID { get; set; }
        public string NAME { get; set; }
        public string TITLE { get; set; }
        public string MENU_TYPE { get; set; }
        public string MENU_URL { get; set; }
        public string PUBLISHED { get; set; }
        public string ISOPEN_NEW { get; set; }
        public string MENU_IMAGE { get; set; }
        public Nullable<int> SEQ_NO { get; set; }
        public Nullable<decimal> VERSION { get; set; }
        public string SYNCOPERATION { get; set; }
        public Nullable<System.DateTime> SYNCVERSION { get; set; }
        public string SYNCFLAG { get; set; }
        public Nullable<System.DateTime> CREATE_DT { get; set; }
        public string CREATE_BY { get; set; }
        public Nullable<System.DateTime> MODIFY_DT { get; set; }
        public string MODIFY_BY { get; set; }
    }
    public partial class VIEW_SET_NAVIGATION_ITEM:VIEW_SET_NAVIGATION_ITEM_P
    {
    
    
    
    	public static SET_NAVIGATION_ITEM ToEntity(VIEW_SET_NAVIGATION_ITEM model)
        {
           SET_NAVIGATION_ITEM item = new SET_NAVIGATION_ITEM();
       		item.ID=model.ID;
    		item.PARENTID=model.PARENTID;
    		item.NAME=model.NAME;
    		item.TITLE=model.TITLE;
    		item.MENU_TYPE=model.MENU_TYPE;
    		item.MENU_URL=model.MENU_URL;
    		item.PUBLISHED=model.PUBLISHED;
    		item.ISOPEN_NEW=model.ISOPEN_NEW;
    		item.MENU_IMAGE=model.MENU_IMAGE;
    		item.SEQ_NO=model.SEQ_NO;
    		item.VERSION=model.VERSION;
    		item.SYNCOPERATION=model.SYNCOPERATION;
    		item.SYNCVERSION=model.SYNCVERSION;
    		item.SYNCFLAG=model.SYNCFLAG;
    		item.CREATE_DT=model.CREATE_DT;
    		item.CREATE_BY=model.CREATE_BY;
    		item.MODIFY_DT=model.MODIFY_DT;
    		item.MODIFY_BY=model.MODIFY_BY;
            return item;
        }
    
    
    	public static VIEW_SET_NAVIGATION_ITEM ToViewModel(SET_NAVIGATION_ITEM model)
        {
           VIEW_SET_NAVIGATION_ITEM item = new VIEW_SET_NAVIGATION_ITEM();
       		item.ID=model.ID;
    		item.PARENTID=model.PARENTID;
    		item.NAME=model.NAME;
    		item.TITLE=model.TITLE;
    		item.MENU_TYPE=model.MENU_TYPE;
    		item.MENU_URL=model.MENU_URL;
    		item.PUBLISHED=model.PUBLISHED;
    		item.ISOPEN_NEW=model.ISOPEN_NEW;
    		item.MENU_IMAGE=model.MENU_IMAGE;
    		item.SEQ_NO=model.SEQ_NO;
    		item.VERSION=model.VERSION;
    		item.SYNCOPERATION=model.SYNCOPERATION;
    		item.SYNCVERSION=model.SYNCVERSION;
    		item.SYNCFLAG=model.SYNCFLAG;
    		item.CREATE_DT=model.CREATE_DT;
    		item.CREATE_BY=model.CREATE_BY;
    		item.MODIFY_DT=model.MODIFY_DT;
    		item.MODIFY_BY=model.MODIFY_BY;
            return item;
        }
    
    	    public static IEnumerable<VIEW_SET_NAVIGATION_ITEM> ToListViewModel(IEnumerable<SET_NAVIGATION_ITEM> list)
            {
                var listModel = new List<VIEW_SET_NAVIGATION_ITEM>();
                foreach (SET_NAVIGATION_ITEM item in list)
                {
                    listModel.Add(VIEW_SET_NAVIGATION_ITEM.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

