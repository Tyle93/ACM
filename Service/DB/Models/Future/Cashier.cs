using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Cashier
    {
        public Guid CashierId { get; set; }
        public int StoreId { get; set; }
        public int CashierIndex { get; set; }
        public string Cashier1 { get; set; } = null!;
    }
}
