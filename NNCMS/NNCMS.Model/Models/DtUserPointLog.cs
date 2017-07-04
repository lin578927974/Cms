using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserPointLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? Value { get; set; }
        public string Remark { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
