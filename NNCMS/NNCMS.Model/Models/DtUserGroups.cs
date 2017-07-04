using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserGroups
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Grade { get; set; }
        public int? UpgradeExp { get; set; }
        public decimal? Amount { get; set; }
        public int? Point { get; set; }
        public int? Discount { get; set; }
        public byte? IsDefault { get; set; }
        public byte? IsUpgrade { get; set; }
        public byte? IsLock { get; set; }
    }
}
