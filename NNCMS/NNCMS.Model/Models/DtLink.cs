using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtLink
    {
        public int Id { get; set; }
        public string SitePath { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string UserTel { get; set; }
        public string Email { get; set; }
        public string SiteUrl { get; set; }
        public string ImgUrl { get; set; }
        public int IsImage { get; set; }
        public int SortId { get; set; }
        public byte IsRed { get; set; }
        public byte IsLock { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
