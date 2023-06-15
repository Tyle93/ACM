using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleItemDiscount
    {
        public Guid SaleItemDiscountId { get; set; }
        public Guid SaleItemId { get; set; }
        public short ItemIndex { get; set; }
        public int DiscountIndex { get; set; }
        public int Amount { get; set; }

        public virtual SaleItem SaleItem { get; set; } = null!;
    }
}
