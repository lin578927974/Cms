using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserAmountLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? PaymentId { get; set; }
        public decimal? Value { get; set; }
        public string Remark { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
