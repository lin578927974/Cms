using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtManager
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? RoleType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string RealName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int? IsLock { get; set; }
        public DateTime? AddTime { get; set; }

        public virtual DtManagerRole Role { get; set; }
    }
}
