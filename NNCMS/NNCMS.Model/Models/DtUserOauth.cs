using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserOauth
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string OauthName { get; set; }
        public string OauthAccessToken { get; set; }
        public string OauthOpenid { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
