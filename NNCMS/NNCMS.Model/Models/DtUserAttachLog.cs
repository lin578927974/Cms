using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserAttachLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? AttachId { get; set; }
        public string FileName { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
