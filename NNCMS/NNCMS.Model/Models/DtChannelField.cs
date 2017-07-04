using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtChannelField
    {
        public int Id { get; set; }
        public int? ChannelId { get; set; }
        public int? FieldId { get; set; }

        public virtual DtChannel Channel { get; set; }
        public virtual DtArticleAttributeField Field { get; set; }
    }
}
