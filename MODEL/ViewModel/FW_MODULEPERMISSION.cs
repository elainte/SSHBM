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
    
    public partial class VIEW_FW_MODULEPERMISSION_P
    {
        public string MP_ID { get; set; }
        public string MODULE_ID { get; set; }
        public string PERMISSION_ID { get; set; }
        public Nullable<System.DateTime> CREATE_DT { get; set; }
        public string CREATE_BY { get; set; }
        public Nullable<System.DateTime> MODIFY_DT { get; set; }
        public string MODIFY_BY { get; set; }
    
        public virtual FW_MODULE FW_MODULE { get; set; }
        public virtual FW_PERMISSION FW_PERMISSION { get; set; }
    }
    public partial class VIEW_FW_MODULEPERMISSION:VIEW_FW_MODULEPERMISSION_P
    {
    
    
    
    	public static FW_MODULEPERMISSION ToEntity(VIEW_FW_MODULEPERMISSION model)
        {
           FW_MODULEPERMISSION item = new FW_MODULEPERMISSION();
       		item.MP_ID=model.MP_ID;
    		item.MODULE_ID=model.MODULE_ID;
    		item.PERMISSION_ID=model.PERMISSION_ID;
    		item.CREATE_DT=model.CREATE_DT;
    		item.CREATE_BY=model.CREATE_BY;
    		item.MODIFY_DT=model.MODIFY_DT;
    		item.MODIFY_BY=model.MODIFY_BY;
            return item;
        }
    
    
    	public static VIEW_FW_MODULEPERMISSION ToViewModel(FW_MODULEPERMISSION model)
        {
           VIEW_FW_MODULEPERMISSION item = new VIEW_FW_MODULEPERMISSION();
       		item.MP_ID=model.MP_ID;
    		item.MODULE_ID=model.MODULE_ID;
    		item.PERMISSION_ID=model.PERMISSION_ID;
    		item.CREATE_DT=model.CREATE_DT;
    		item.CREATE_BY=model.CREATE_BY;
    		item.MODIFY_DT=model.MODIFY_DT;
    		item.MODIFY_BY=model.MODIFY_BY;
            return item;
        }
    
    	    public static IEnumerable<VIEW_FW_MODULEPERMISSION> ToListViewModel(IEnumerable<FW_MODULEPERMISSION> list)
            {
                var listModel = new List<VIEW_FW_MODULEPERMISSION>();
                foreach (FW_MODULEPERMISSION item in list)
                {
                    listModel.Add(VIEW_FW_MODULEPERMISSION.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

