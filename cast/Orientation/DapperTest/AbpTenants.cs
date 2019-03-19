//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DapperTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class AbpTenants
    {
        public int Id { get; set; }
        public string ConnectionString { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
        public Nullable<long> DeleterUserId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
        public Nullable<int> EditionId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<long> LastModifierUserId { get; set; }
        public string Name { get; set; }
        public string TenancyName { get; set; }
    
        public virtual AbpEditions AbpEditions { get; set; }
        public virtual AbpUsers AbpUsers { get; set; }
        public virtual AbpUsers AbpUsers1 { get; set; }
        public virtual AbpUsers AbpUsers2 { get; set; }
    }
}
