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
    
    public partial class CoursewareAdjunctTable
    {
        public int ca_Id { get; set; }
        public Nullable<int> ca_Courseware_id { get; set; }
        public Nullable<int> ca_Staff_id { get; set; }
        public string ca_Name { get; set; }
        public string ca_Filename { get; set; }
        public string ca_File_url { get; set; }
        public Nullable<int> ca_Status { get; set; }
        public Nullable<System.DateTime> ca_Created_at { get; set; }
    }
}
