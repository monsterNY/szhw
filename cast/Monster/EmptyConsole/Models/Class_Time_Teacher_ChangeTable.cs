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
    
    public partial class Class_Time_Teacher_ChangeTable
    {
        public string cttc_id { get; set; }
        public int cttc_teacher_id { get; set; }
        public int cttc_class_time_id { get; set; }
        public System.DateTime cttc_date { get; set; }
        public Nullable<int> cttc_status { get; set; }
        public int cttc_staff_id { get; set; }
        public Nullable<System.DateTime> cttc_add_time { get; set; }
        public Nullable<System.DateTime> cttc_cancel_time { get; set; }
        public Nullable<int> cttc_cancel_staff { get; set; }
        public int cttc_no { get; set; }
    }
}
