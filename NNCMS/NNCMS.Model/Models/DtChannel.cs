using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtChannel
    {
        public DtChannel()
        {
            DtChannelField = new HashSet<DtChannelField>();
        }

        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public byte? IsAlbums { get; set; }
        public byte? IsAttach { get; set; }
        public byte? IsSpec { get; set; }
        public int? SortId { get; set; }

        public virtual ICollection<DtChannelField> DtChannelField { get; set; }
        public virtual DtChannelSite Site { get; set; }
    }
}
