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
    
    public partial class VIEW_SYS_USERLOGIN_P
    {
        public string LOGIN_ID { get; set; }
        public string SLSORG_CD { get; set; }
        public decimal SLSORG_LEVEL { get; set; }
        public Nullable<decimal> SEQ_NO { get; set; }
    }
    public partial class VIEW_SYS_USERLOGIN:VIEW_SYS_USERLOGIN_P
    {
    
    
    
    	public static SYS_USERLOGIN ToEntity(VIEW_SYS_USERLOGIN model)
        {
           SYS_USERLOGIN item = new SYS_USERLOGIN();
       		item.LOGIN_ID=model.LOGIN_ID;
    		item.SLSORG_CD=model.SLSORG_CD;
    		item.SLSORG_LEVEL=model.SLSORG_LEVEL;
    		item.SEQ_NO=model.SEQ_NO;
            return item;
        }
    
    
    	public static VIEW_SYS_USERLOGIN ToViewModel(SYS_USERLOGIN model)
        {
           VIEW_SYS_USERLOGIN item = new VIEW_SYS_USERLOGIN();
       		item.LOGIN_ID=model.LOGIN_ID;
    		item.SLSORG_CD=model.SLSORG_CD;
    		item.SLSORG_LEVEL=model.SLSORG_LEVEL;
    		item.SEQ_NO=model.SEQ_NO;
            return item;
        }
    
    	    public static IEnumerable<VIEW_SYS_USERLOGIN> ToListViewModel(IEnumerable<SYS_USERLOGIN> list)
            {
                var listModel = new List<VIEW_SYS_USERLOGIN>();
                foreach (SYS_USERLOGIN item in list)
                {
                    listModel.Add(VIEW_SYS_USERLOGIN.ToViewModel(item));
                }
                return listModel;
            }
    
    
    }
}

//----------------------------jiezhi------------------------------------

