using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemSold
    {
        public Guid ItemSoldId { get; set; }
        public int StoreId { get; set; }
        public DateTime SoldDate { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; } = null!;
        public string ItemDescription { get; set; } = null!;
        public string Department { get; set; } = null!;
        public int TerminalNumber { get; set; }
        public int TableNumber { get; set; }
        public int EmpId { get; set; }
        public int CheckNumber { get; set; }
        public int SupervisorId { get; set; }
        public bool IsModifier { get; set; }
        public int Price { get; set; }
    }
}
