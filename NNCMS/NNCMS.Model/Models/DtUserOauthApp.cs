using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserOauthApp
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string AppId { get; set; }
        public string AppKey { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
        public byte? IsLock { get; set; }
        public string ApiPath { get; set; }
    }
}
