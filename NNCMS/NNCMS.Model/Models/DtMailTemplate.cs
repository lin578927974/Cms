using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtMailTemplate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CallIndex { get; set; }
        public string MaillTitle { get; set; }
        public string Content { get; set; }
        public byte? IsSys { get; set; }
    }
}
