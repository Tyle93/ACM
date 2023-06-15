using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleItemCoupon
    {
        public Guid SaleItemCouponId { get; set; }
        public Guid SaleItemId { get; set; }
        public int ItemIndex { get; set; }
        public int CouponIndex { get; set; }
        public int Amount { get; set; }
        public int SplitAmount { get; set; }

        public virtual SaleItem SaleItem { get; set; } = null!;
    }
}
