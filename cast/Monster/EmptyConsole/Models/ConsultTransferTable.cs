//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmptyConsole.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConsultTransferTable
    {
        public int ct_Id { get; set; }
        public int ct_ConsultId { get; set; }
        public int ct_Type { get; set; }
        public Nullable<int> ct_FromRecruiter { get; set; }
        public Nullable<int> ct_ToRecruiter { get; set; }
        public string ct_Content { get; set; }
        public Nullable<int> ct_StaffId { get; set; }
        public string ct_Remark { get; set; }
        public Nullable<System.DateTime> ct_AddTime { get; set; }
    }
}
