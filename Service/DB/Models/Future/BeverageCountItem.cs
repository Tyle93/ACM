using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class BeverageCountItem
    {
        public Guid BeverageCountItemId { get; set; }
        public Guid BeverageCountId { get; set; }
        public string ItemName { get; set; } = null!;
        public int InCount { get; set; }
        public int OutCount { get; set; }

        public virtual BeverageCount BeverageCount { get; set; } = null!;
    }
}
