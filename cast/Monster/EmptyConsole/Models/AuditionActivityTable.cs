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
    
    public partial class AuditionActivityTable
    {
        public int a_Id { get; set; }
        public string a_Name { get; set; }
        public int a_Type { get; set; }
        public int a_CompuId { get; set; }
        public int a_CourseId { get; set; }
        public Nullable<int> a_TeacherId { get; set; }
        public Nullable<int> a_ClassRoomId { get; set; }
        public Nullable<System.DateTime> a_Date { get; set; }
        public Nullable<System.TimeSpan> a_StartTime { get; set; }
        public Nullable<System.TimeSpan> a_EndTime { get; set; }
        public Nullable<int> a_Status { get; set; }
        public Nullable<System.DateTime> a_AddTime { get; set; }
        public Nullable<int> a_AddStaffId { get; set; }
    }
}
