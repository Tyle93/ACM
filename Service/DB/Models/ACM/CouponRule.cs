using System;
using System.Collections.Generic;

namespace ACM.ACM_Models
{
    public partial class CouponRule
    {
        public CouponRule()
        {
            CouponDailyAvailabilities = new HashSet<CouponDailyAvailability>();
            CouponItems = new HashSet<CouponItem>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ReceiptName { get; set; } = null!;
        public byte[] IsActive { get; set; } = null!;
        public long MaxApplications { get; set; }
        public byte[] IsDiscountExclusive { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;

        public virtual ICollection<CouponDailyAvailability> CouponDailyAvailabilities { get; set; }
        public virtual ICollection<CouponItem> CouponItems { get; set; }
    }
}
