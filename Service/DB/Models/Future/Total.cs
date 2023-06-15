using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Total
    {
        public Guid TotalId { get; set; }
        public int StoreId { get; set; }
        public DateTime TotalDate { get; set; }
        public int TotalType { get; set; }
        public int CheckNumber { get; set; }
        public int TerminalNumber { get; set; }
        public int DrawerNumber { get; set; }
        public int TableNumber { get; set; }
        public int EmpId { get; set; }
        public int Amount { get; set; }
        public int CustomerNumber { get; set; }
        public int MediaIndex { get; set; }
        public string? Description { get; set; }
        public int Section { get; set; }
        public int RevenueCenter { get; set; }
        public int TipEmpId { get; set; }
    }
}
