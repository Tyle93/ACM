using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CouponTranslation
    {
        public Guid CouponTranslationId { get; set; }
        public Guid CouponId { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Coupon Coupon { get; set; } = null!;
    }
}
