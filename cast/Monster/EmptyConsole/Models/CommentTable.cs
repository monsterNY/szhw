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
    
    public partial class CommentTable
    {
        public int c_Id { get; set; }
        public Nullable<int> c_Type { get; set; }
        public Nullable<int> c_UserId { get; set; }
        public Nullable<int> c_ToUserId { get; set; }
        public Nullable<int> c_Work_id { get; set; }
        public Nullable<int> c_ContentType { get; set; }
        public string c_Content { get; set; }
        public Nullable<int> c_IsRead { get; set; }
        public Nullable<int> c_Status { get; set; }
        public Nullable<System.DateTime> c_AddTime { get; set; }
    }
}
