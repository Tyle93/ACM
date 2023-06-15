using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponItems = new HashSet<CouponItem>();
            CouponTranslations = new HashSet<CouponTranslation>();
        }

        public Guid CouponId { get; set; }
        public Guid RegionId { get; set; }
        public int CouponIndex { get; set; }
        public string CouponName { get; set; } = null!;
        public short Type { get; set; }
        public int Percent { get; set; }
        public short ApplyType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short Days { get; set; }
        public bool SubFrTax { get; set; }
        public short? MaxTimesUsed { get; set; }
        public string? Upc { get; set; }
        public string? Text { get; set; }
        public bool AutoApply { get; set; }
        public bool IsExclusive { get; set; }
        public bool ApplyToZeroPrice { get; set; }
        public bool IsWebCoupon { get; set; }
        public string? WebRedemptionCode { get; set; }

        public virtual ICollection<CouponItem> CouponItems { get; set; }
        public virtual ICollection<CouponTranslation> CouponTranslations { get; set; }
    }
}
