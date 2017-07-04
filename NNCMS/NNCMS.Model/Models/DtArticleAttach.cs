using System;
using System.Collections.Generic;

namespace NNCMS.Model.Models
{
    public partial class DtArticleAttach
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int? FileSize { get; set; }
        public string FileExt { get; set; }
        public int? DownNum { get; set; }
        public int? Point { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
