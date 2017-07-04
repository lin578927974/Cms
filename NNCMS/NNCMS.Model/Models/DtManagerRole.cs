using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtManagerRole
    {
        public DtManagerRole()
        {
            DtManager = new HashSet<DtManager>();
            DtManagerRoleValue = new HashSet<DtManagerRoleValue>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public byte? RoleType { get; set; }
        public byte? IsSys { get; set; }

        public virtual ICollection<DtManager> DtManager { get; set; }
        public virtual ICollection<DtManagerRoleValue> DtManagerRoleValue { get; set; }
    }
}
