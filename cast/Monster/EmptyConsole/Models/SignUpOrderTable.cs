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
    
    public partial class SignUpOrderTable
    {
        public int so_Id { get; set; }
        public string so_OrderId { get; set; }
        public string so_ChildOrderId { get; set; }
        public Nullable<int> so_Type { get; set; }
        public Nullable<int> so_StudentId { get; set; }
        public Nullable<int> so_ConsultId { get; set; }
        public Nullable<int> so_CompusId { get; set; }
        public Nullable<int> so_CourseId { get; set; }
        public Nullable<int> so_ClassId { get; set; }
        public Nullable<System.DateTime> so_ClassStartDate { get; set; }
        public Nullable<System.DateTime> so_ClassEndDate { get; set; }
        public Nullable<System.DateTime> so_ValidDate { get; set; }
        public Nullable<decimal> so_Price { get; set; }
        public Nullable<int> so_Amount { get; set; }
        public Nullable<decimal> so_Money { get; set; }
        public Nullable<int> so_OffType { get; set; }
        public Nullable<decimal> so_OffValue { get; set; }
        public Nullable<decimal> so_OffMoney { get; set; }
        public Nullable<decimal> so_MaterialMoney { get; set; }
        public string so_OutRemark { get; set; }
        public string so_InnerRemark { get; set; }
        public Nullable<bool> so_NeedStay { get; set; }
        public string so_ActiveCode { get; set; }
        public Nullable<int> so_SellerId { get; set; }
        public Nullable<int> so_LeafLetId { get; set; }
        public Nullable<int> so_HandleCompusId { get; set; }
        public Nullable<System.DateTime> so_HandleTime { get; set; }
        public Nullable<int> so_StaffId { get; set; }
        public Nullable<System.DateTime> so_AddTime { get; set; }
        public Nullable<int> so_ChannelId { get; set; }
        public Nullable<decimal> so_RefundMoney { get; set; }
        public Nullable<int> so_ClassHour { get; set; }
    }
}
