using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VSaleItemLink
    {
        public Guid SaleId { get; set; }
        public Guid SaleItemId { get; set; }
        public string? ItemName { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ReceiptDescription { get; set; }
        public short Quantity { get; set; }
        public string Expr1 { get; set; } = null!;
        public string? Department { get; set; }
        public int ActualPrice { get; set; }
        public bool IsSuspend { get; set; }
        public short EmpId { get; set; }
        public int Total { get; set; }
        public int SubTotal { get; set; }
    }
}
