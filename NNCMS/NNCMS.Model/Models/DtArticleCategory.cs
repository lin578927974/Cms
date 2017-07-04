using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtArticleCategory
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public string Title { get; set; }
        public string CallIndex { get; set; }
        public int? ParentId { get; set; }
        public string ClassList { get; set; }
        public int? ClassLayer { get; set; }
        public int? SortId { get; set; }
        public string LinkUrl { get; set; }
        public string ImgUrl { get; set; }
        public string Content { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
    }
}
