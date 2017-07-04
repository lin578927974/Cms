using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtChannelSite
    {
        public DtChannelSite()
        {
            DtChannel = new HashSet<DtChannel>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string BuildPath { get; set; }
        public string TempletPath { get; set; }
        public string Domain { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Crod { get; set; }
        public string Copyright { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeyword { get; set; }
        public string SeoDescription { get; set; }
        public byte? IsDefault { get; set; }
        public int? SortId { get; set; }

        public virtual ICollection<DtChannel> DtChannel { get; set; }
    }
}
