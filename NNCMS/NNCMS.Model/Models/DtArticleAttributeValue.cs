using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtArticleAttributeValue
    {
        public int ArticleId { get; set; }
        public string SubTitle { get; set; }
        public string Source { get; set; }
        public string Author { get; set; }
        public string GoodsNo { get; set; }
        public int? StockQuantity { get; set; }
        public decimal? MarketPrice { get; set; }
        public decimal? SellPrice { get; set; }
        public int? Point { get; set; }
        public string VideoSrc { get; set; }

        public virtual DtArticle Article { get; set; }
    }
}
