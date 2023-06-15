using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PrepTime
    {
        public Guid PrepTimeId { get; set; }
        public int StoreId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; } = null!;
    }
}
