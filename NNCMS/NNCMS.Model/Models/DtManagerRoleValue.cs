using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtManagerRoleValue
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string NavName { get; set; }
        public string ActionType { get; set; }

        public virtual DtManagerRole Role { get; set; }
    }
}
