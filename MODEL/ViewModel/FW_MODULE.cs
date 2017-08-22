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
    
    public partial class VIEW_FW_MODULE_P
    {
        public VIEW_FW_MODULE_P()
        {
            this.FW_MODULEPERMISSIONLIST = new HashSet<FW_MODULEPERMISSION>();
        }
    
        public string MODULE_ID { get; set; }
        public string MODULE_NAME { get; set; }
        public string MODULE_LINK { get; set; }
        public string ICON { get; set; }
        public string MODULE_PID { get; set; }
        public Nullable<int> SEQ_NO { get; set; }
        public bool ISVISIBLE { get; set; }
        public bool ISLEAF { get; set; }
        public bool ISMENU { get; set; }
        public string MODULE_CONTROLLER { get; set; }
        public Nullable<System.DateTime> CREATE_DT { get; set; }
        public string CREATE_BY { get; set; }
        public Nullable<System.DateTime> MODIFY_DT { get; set; }
        public string MODIFY_BY { get; set; }
    
        public virtual ICollection<FW_MODULEPERMISSION> FW_MODULEPERMISSIONLIST { get; set; }
    }
    public partial class VIEW_FW_MODULE:VIEW_FW_MODULE_P
    {
    
    
    
    	public static FW_MODULE ToEntity(VIEW_FW_MODULE model)
        {
           FW_MODULE item = new FW_MODULE();
       		item.MODULE_ID=model.MODULE_ID;
    		item.MODULE_NAME=model.MODULE_NAME;
    		item.MODULE_LINK=model.MODULE_LINK;
    		item.ICON=model.ICON;
    		item.MODULE_PID=model.MODULE_PID;
    		item.SEQ_NO=model.SEQ_NO;
    		item.ISVISIBLE=model.ISVISIBLE;
    		item.ISLEAF=model.ISLEAF;
    		item.ISMENU=model.ISMENU;
    		item.MODULE_CONTROLLER=model.MODULE_CONTROLLER;
    		item.CREATE_DT=model.CREATE_DT;
    		item.CREATE_BY=model.CREATE_BY;
    		item.MODIFY_DT=model.MODIFY_DT;
    		item.MODIFY_BY=model.MODIFY_BY;
            return item;
        }
    
    
    	public static VIEW_FW_MODULE ToViewModel(FW_MODULE model)
        {
           VIEW_FW_MODULE item = new VIEW_FW_MODULE();
       		item.MODULE_ID=model.MODULE_ID;
    		item.MODULE_NAME=model.MODULE_NAME;
    		item.MODULE_LINK=model.MODULE_LINK;
    		item.ICON=model.ICON;
    		item.MODULE_PID=model.MODULE_PID;
    		item.SEQ_NO=model.SEQ_NO;
    		item.ISVISIBLE=model.ISVISIBLE;
    		item.ISLEAF=model.ISLEAF;
    		item.ISMENU=model.ISMENU;
    		item.MODULE_CONTROLLER=model.MODULE_CONTROLLER;
    		item.CREATE_DT=model.CREATE_DT;
    		item.CREATE_BY=model.CREATE_BY;
    		item.MODIFY_DT=model.MODIFY_DT;
    		item.MODIFY_BY=model.MODIFY_BY;
            return item;
        }
    
    	    public static IEnumerable<VIEW_FW_MODULE> ToListViewModel(IEnumerable<FW_MODULE> list)
            {
                var listModel = new List<VIEW_FW_MODULE>();
                foreach (FW_MODULE item in list)
                {
                    listModel.Add(VIEW_FW_MODULE.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

