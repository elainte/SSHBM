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
    
    public partial class VIEW_MST_MEMBER_P
    {
        public string MEMBER_CD { get; set; }
        public string EMAIL { get; set; }
        public string NAME { get; set; }
        public string PASSWORD { get; set; }
        public string PHONE { get; set; }
        public string NICKNAME { get; set; }
        public string REMARK { get; set; }
        public string USERTYPE { get; set; }
        public string LOGINIP { get; set; }
        public string PORTRAIT { get; set; }
        public string STATUS { get; set; }
        public System.DateTime LOGINDATE { get; set; }
        public System.DateTime CREATE_DT { get; set; }
        public int VERSION { get; set; }
        public string SYNCOPERATION { get; set; }
        public Nullable<System.DateTime> SYNCVERSION { get; set; }
        public string SYNCFLAG { get; set; }
    }
    public partial class VIEW_MST_MEMBER:VIEW_MST_MEMBER_P
    {
    
    
    
    	public static MST_MEMBER ToEntity(VIEW_MST_MEMBER model)
        {
           MST_MEMBER item = new MST_MEMBER();
       		item.MEMBER_CD=model.MEMBER_CD;
    		item.EMAIL=model.EMAIL;
    		item.NAME=model.NAME;
    		item.PASSWORD=model.PASSWORD;
    		item.PHONE=model.PHONE;
    		item.NICKNAME=model.NICKNAME;
    		item.REMARK=model.REMARK;
    		item.USERTYPE=model.USERTYPE;
    		item.LOGINIP=model.LOGINIP;
    		item.PORTRAIT=model.PORTRAIT;
    		item.STATUS=model.STATUS;
    		item.LOGINDATE=model.LOGINDATE;
    		item.CREATE_DT=model.CREATE_DT;
    		item.VERSION=model.VERSION;
    		item.SYNCOPERATION=model.SYNCOPERATION;
    		item.SYNCVERSION=model.SYNCVERSION;
    		item.SYNCFLAG=model.SYNCFLAG;
            return item;
        }
    
    
    	public static VIEW_MST_MEMBER ToViewModel(MST_MEMBER model)
        {
           VIEW_MST_MEMBER item = new VIEW_MST_MEMBER();
       		item.MEMBER_CD=model.MEMBER_CD;
    		item.EMAIL=model.EMAIL;
    		item.NAME=model.NAME;
    		item.PASSWORD=model.PASSWORD;
    		item.PHONE=model.PHONE;
    		item.NICKNAME=model.NICKNAME;
    		item.REMARK=model.REMARK;
    		item.USERTYPE=model.USERTYPE;
    		item.LOGINIP=model.LOGINIP;
    		item.PORTRAIT=model.PORTRAIT;
    		item.STATUS=model.STATUS;
    		item.LOGINDATE=model.LOGINDATE;
    		item.CREATE_DT=model.CREATE_DT;
    		item.VERSION=model.VERSION;
    		item.SYNCOPERATION=model.SYNCOPERATION;
    		item.SYNCVERSION=model.SYNCVERSION;
    		item.SYNCFLAG=model.SYNCFLAG;
            return item;
        }
    
    	    public static IEnumerable<VIEW_MST_MEMBER> ToListViewModel(IEnumerable<MST_MEMBER> list)
            {
                var listModel = new List<VIEW_MST_MEMBER>();
                foreach (MST_MEMBER item in list)
                {
                    listModel.Add(VIEW_MST_MEMBER.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

