using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleLoyalty
    {
        public Guid SaleLoyaltyId { get; set; }
        public Guid SaleId { get; set; }
        public int LoyaltyIndex { get; set; }
        public int CurrentCredits { get; set; }
        public string? Rating { get; set; }
        public string CouponCode { get; set; } = null!;
        public int Credits { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
