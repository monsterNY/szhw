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
    
    public partial class AbpUserLogins
    {
        public long Id { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public Nullable<int> TenantId { get; set; }
        public long UserId { get; set; }
    
        public virtual AbpUsers AbpUsers { get; set; }
    }
}
