using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtOrderGoods
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public int? OrderId { get; set; }
        public string GoodsNo { get; set; }
        public string GoodsTitle { get; set; }
        public string ImgUrl { get; set; }
        public string SpecText { get; set; }
        public decimal? GoodsPrice { get; set; }
        public decimal? RealPrice { get; set; }
        public int? Quantity { get; set; }
        public int? Point { get; set; }

        public virtual DtOrders Order { get; set; }
    }
}
