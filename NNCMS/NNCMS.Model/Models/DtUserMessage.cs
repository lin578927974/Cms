using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtUserMessage
    {
        public int Id { get; set; }
        public byte? Type { get; set; }
        public string PostUserName { get; set; }
        public string AcceptUserName { get; set; }
        public byte? IsRead { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }
        public DateTime? ReadTime { get; set; }
    }
}
