using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtArticleComment
    {
        public int Id { get; set; }
        public int? ChannelId { get; set; }
        public int? ArticleId { get; set; }
        public int? ParentId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string UserIp { get; set; }
        public string Content { get; set; }
        public byte? IsLock { get; set; }
        public DateTime? AddTime { get; set; }
        public byte? IsReply { get; set; }
        public string ReplyContent { get; set; }
        public DateTime? ReplyTime { get; set; }
    }
}
