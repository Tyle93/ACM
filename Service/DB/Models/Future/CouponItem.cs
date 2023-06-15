using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CouponItem
    {
        public Guid CouponItemId { get; set; }
        public Guid CouponId { get; set; }
        public int CouponItemIndex { get; set; }
        public string? ItemName { get; set; }
        public bool IsRequired { get; set; }
        public int Price { get; set; }

        public virtual Coupon Coupon { get; set; } = null!;
    }
}
