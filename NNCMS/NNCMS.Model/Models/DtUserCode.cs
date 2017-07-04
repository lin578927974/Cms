using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserCode
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Type { get; set; }
        public string StrCode { get; set; }
        public int? Count { get; set; }
        public byte? Status { get; set; }
        public string UserIp { get; set; }
        public DateTime EffTime { get; set; }
        public DateTime AddTime { get; set; }
    }
}
