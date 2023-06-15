using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CustomerLastOrder
    {
        public Guid CustomerOrderId { get; set; }
        public Guid? CustomerId { get; set; }
        public int OrderIndex { get; set; }
        public DateTime? OrderDate { get; set; }
        public int CheckNumber { get; set; }
        public DateTime? SettleDate { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
