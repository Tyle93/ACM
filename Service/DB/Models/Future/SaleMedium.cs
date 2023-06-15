using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleMedium
    {
        public Guid SaleMediaId { get; set; }
        public Guid SaleId { get; set; }
        public int MediaIndex { get; set; }
        public int Amount { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
