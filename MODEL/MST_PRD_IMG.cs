//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MST_PRD_IMG
    {
        public int IMAGE_ID { get; set; }
        public string IMG_URL { get; set; }
        public string IMG_DESC { get; set; }
        public string IMG_PATH { get; set; }
        public int ISDEFAULT { get; set; }
        public string PRD_CD { get; set; }
        public Nullable<decimal> VERSION { get; set; }
        public string SYNCOPERATION { get; set; }
        public Nullable<System.DateTime> SYNCVERSION { get; set; }
        public string SYNCFLAG { get; set; }
    }
}
