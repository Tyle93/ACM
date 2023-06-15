using System;
using System.Collections.Generic;

namespace ACM.ACM_Models
{
    public partial class CouponItem
    {
        public string Id { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string Operation { get; set; } = null!;
        public long Amount { get; set; }
        public byte[] IsRequired { get; set; } = null!;
        public string? CouponRuleId { get; set; }

        public virtual CouponRule? CouponRule { get; set; }
    }
}
