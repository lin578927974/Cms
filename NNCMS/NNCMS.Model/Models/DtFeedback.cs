using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtFeedback
    {
        public int Id { get; set; }
        public string SitePath { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public string UserTel { get; set; }
        public string UserQq { get; set; }
        public string UserEmail { get; set; }
        public DateTime AddTime { get; set; }
        public string ReplyContent { get; set; }
        public DateTime? ReplyTime { get; set; }
        public byte IsLock { get; set; }
    }
}
