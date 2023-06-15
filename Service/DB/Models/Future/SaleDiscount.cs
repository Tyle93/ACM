using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleDiscount
    {
        public Guid SaleDiscountId { get; set; }
        public Guid? SaleId { get; set; }
        public int DiscountIndex { get; set; }
        public int Dollar { get; set; }
        public int Amount { get; set; }
        public int ReasonIndex { get; set; }
        public int MaxAmount { get; set; }

        public virtual Sale? Sale { get; set; }
    }
}
