using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtArticle
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public int CategoryId { get; set; }
        public string CallIndex { get; set; }
        public string Title { get; set; }
        public string LinkUrl { get; set; }
        public string ImgUrl { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public string Tags { get; set; }
        public string Zhaiyao { get; set; }
        public string Content { get; set; }
        public int? SortId { get; set; }
        public int? Click { get; set; }
        public byte? Status { get; set; }
        public byte? IsMsg { get; set; }
        public byte? IsTop { get; set; }
        public byte? IsRed { get; set; }
        public byte? IsHot { get; set; }
        public byte? IsSlide { get; set; }
        public byte? IsSys { get; set; }
        public string UserName { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual DtArticleAttributeValue DtArticleAttributeValue { get; set; }
    }
}
