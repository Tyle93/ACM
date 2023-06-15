using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DiscountTranslation
    {
        public Guid DiscountTranslationId { get; set; }
        public Guid DiscountId { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Discount Discount { get; set; } = null!;
    }
}
