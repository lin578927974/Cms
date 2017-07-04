using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtExpress
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ExpressCode { get; set; }
        public decimal? ExpressFee { get; set; }
        public string Website { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
        public byte? IsLock { get; set; }
    }
}
