using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class EnterpriseSort
    {
        public Guid EnterpriseSortId { get; set; }
        public int FileType { get; set; }
        public DateTime UpdateDate { get; set; }
        public int StoreId { get; set; }
        public string FileName { get; set; } = null!;
    }
}
