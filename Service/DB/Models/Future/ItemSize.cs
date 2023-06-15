using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemSize
    {
        public Guid ItemSizeId { get; set; }
        public Guid RegionId { get; set; }
        public string Description { get; set; } = null!;
        public string ItemDescriptionPrefix { get; set; } = null!;
        public string ReceiptDescriptionPrefix { get; set; } = null!;
    }
}
