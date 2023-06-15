using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PriceLevel
    {
        public Guid PriceLevelId { get; set; }
        public int StoreId { get; set; }
        public int PriceLevelIndex { get; set; }
        public string PriceLevelName { get; set; } = null!;
    }
}
