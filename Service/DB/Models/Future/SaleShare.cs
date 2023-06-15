using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleShare
    {
        public Guid SaleShareId { get; set; }
        public Guid SaleId { get; set; }
        public int ShareIndex { get; set; }
        public int EmpId { get; set; }
        public int SalePercent { get; set; }
        public int TipPercent { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
