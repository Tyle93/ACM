using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleCoupon
    {
        public Guid SaleCouponId { get; set; }
        public Guid SaleId { get; set; }
        public int CouponIndex { get; set; }
        public int Dollar { get; set; }
        public int AppliedCount { get; set; }
        public int ActualAppliedCount { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
