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
    
    public partial class ChatStatusTable
    {
        public int cs_Id { get; set; }
        public Nullable<int> cs_UserId { get; set; }
        public Nullable<int> cs_Type { get; set; }
        public Nullable<int> cs_DataId { get; set; }
        public Nullable<System.DateTime> cs_Time { get; set; }
        public Nullable<int> cs_LastChatId { get; set; }
        public Nullable<System.DateTime> cs_AddTime { get; set; }
    }
}
