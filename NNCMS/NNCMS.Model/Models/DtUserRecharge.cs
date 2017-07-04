using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserRecharge
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string RechargeNo { get; set; }
        public int? PaymentId { get; set; }
        public decimal? Amount { get; set; }
        public byte? Status { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? CompleteTime { get; set; }
    }
}
