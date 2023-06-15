using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PrintJobLine
    {
        public Guid PrintLineId { get; set; }
        public Guid PrintJobId { get; set; }
        public int LineIndex { get; set; }
        public string? Text { get; set; }
        public string? RightText { get; set; }
        public string? LeftText { get; set; }
        public int LineLength { get; set; }
        public int PrintOptions { get; set; }
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public int Flags { get; set; }
        public int BergPlu { get; set; }
        public int ActualPrice { get; set; }
        public int BasePrice { get; set; }
        public byte Vducolor { get; set; }
        public int? ParentIndex { get; set; }
        public int? Peplu { get; set; }
        public Guid? SaleItemId { get; set; }
        public Guid? SaleTenderId { get; set; }
        public Guid? SignatureId { get; set; }
        public int Language { get; set; }
        public string? SeparatedText { get; set; }

        public virtual PrintJob PrintJob { get; set; } = null!;
    }
}
