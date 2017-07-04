using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUsers
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public string UserName { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Telphone { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Qq { get; set; }
        public string Msn { get; set; }
        public decimal? Amount { get; set; }
        public int? Point { get; set; }
        public int? Exp { get; set; }
        public byte? Status { get; set; }
        public DateTime? RegTime { get; set; }
        public string RegIp { get; set; }
    }
}
