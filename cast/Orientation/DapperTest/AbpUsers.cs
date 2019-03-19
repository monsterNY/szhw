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
    
    public partial class AbpUsers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AbpUsers()
        {
            this.AbpPermissions = new HashSet<AbpPermissions>();
            this.AbpRoles = new HashSet<AbpRoles>();
            this.AbpRoles1 = new HashSet<AbpRoles>();
            this.AbpRoles2 = new HashSet<AbpRoles>();
            this.AbpSettings = new HashSet<AbpSettings>();
            this.AbpTenants = new HashSet<AbpTenants>();
            this.AbpTenants1 = new HashSet<AbpTenants>();
            this.AbpTenants2 = new HashSet<AbpTenants>();
            this.AbpUserClaims = new HashSet<AbpUserClaims>();
            this.AbpUserLogins = new HashSet<AbpUserLogins>();
            this.AbpUserRoles = new HashSet<AbpUserRoles>();
            this.AbpUsers1 = new HashSet<AbpUsers>();
            this.AbpUsers11 = new HashSet<AbpUsers>();
            this.AbpUsers12 = new HashSet<AbpUsers>();
            this.AbpUserTokens = new HashSet<AbpUserTokens>();
        }
    
        public long Id { get; set; }
        public int AccessFailedCount { get; set; }
        public string AuthenticationSource { get; set; }
        public string ConcurrencyStamp { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
        public Nullable<long> DeleterUserId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
        public string EmailAddress { get; set; }
        public string EmailConfirmationCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public bool IsLockoutEnabled { get; set; }
        public bool IsPhoneNumberConfirmed { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<long> LastModifierUserId { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public string Name { get; set; }
        public string NormalizedEmailAddress { get; set; }
        public string NormalizedUserName { get; set; }
        public string Password { get; set; }
        public string PasswordResetCode { get; set; }
        public string PhoneNumber { get; set; }
        public string SecurityStamp { get; set; }
        public string Surname { get; set; }
        public Nullable<int> TenantId { get; set; }
        public string UserName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpPermissions> AbpPermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpRoles> AbpRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpRoles> AbpRoles1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpRoles> AbpRoles2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpSettings> AbpSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpTenants> AbpTenants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpTenants> AbpTenants1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpTenants> AbpTenants2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpUserClaims> AbpUserClaims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpUserLogins> AbpUserLogins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpUserRoles> AbpUserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpUsers> AbpUsers1 { get; set; }
        public virtual AbpUsers AbpUsers2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpUsers> AbpUsers11 { get; set; }
        public virtual AbpUsers AbpUsers3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpUsers> AbpUsers12 { get; set; }
        public virtual AbpUsers AbpUsers4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AbpUserTokens> AbpUserTokens { get; set; }
    }
}
