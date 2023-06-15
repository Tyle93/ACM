using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemPrinter
    {
        public Guid ItemPrinterId { get; set; }
        public Guid ItemId { get; set; }
        public int PrinterIndex { get; set; }
        public string? ReceiptDescription { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
