using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtArticleAttributeField
    {
        public DtArticleAttributeField()
        {
            DtChannelField = new HashSet<DtChannelField>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ControlType { get; set; }
        public string DataType { get; set; }
        public int? DataLength { get; set; }
        public byte? DataPlace { get; set; }
        public string ItemOption { get; set; }
        public string DefaultValue { get; set; }
        public byte? IsRequired { get; set; }
        public byte? IsPassword { get; set; }
        public byte? IsHtml { get; set; }
        public byte? EditorType { get; set; }
        public string ValidTipMsg { get; set; }
        public string ValidErrorMsg { get; set; }
        public string ValidPattern { get; set; }
        public int? SortId { get; set; }
        public byte? IsSys { get; set; }

        public virtual ICollection<DtChannelField> DtChannelField { get; set; }
    }
}
