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
    
    public partial class AbpRoles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AbpRoles()
        {
            this.AbpPermissions = new HashSet<AbpPermissions>();
            this.AbpRoleClaims = new HashSet<AbpRoleClaims>();
        }
    
        public int Id { get; set; }
        public string ConcurrencyStamp { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
        public Nullable<long> DeleterUserId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
        public string DisplayName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsStatic { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<long> LastModifierUserId { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public Nullable<int> TenantId { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpPermissions> AbpPermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpRoleClaims> AbpRoleClaims { get; set; }
        public virtual AbpUsers AbpUsers { get; set; }
        public virtual AbpUsers AbpUsers1 { get; set; }
        public virtual AbpUsers AbpUsers2 { get; set; }
    }
}