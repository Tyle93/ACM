using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleTender
    {
        public Guid SaleTenderId { get; set; }
        public Guid SaleId { get; set; }
        public int TenderIndex { get; set; }
        public int MediaIndex { get; set; }
        public int Amount { get; set; }
        public int ForeignIndex { get; set; }
        public int ForeignAmount { get; set; }
        public int Customer { get; set; }
        public int EmployeeTip { get; set; }
        public int HouseTip { get; set; }
        public bool UseTipCalc { get; set; }
        public Guid? SignatureId { get; set; }
        public string? MediaMemo { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
