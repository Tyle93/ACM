using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleGiftUsed
    {
        public Guid SaleGiftUsedId { get; set; }
        public Guid SaleId { get; set; }
        public int GiftUsedIndex { get; set; }
        public int SeriesIndex { get; set; }
        public byte PartialOpts { get; set; }
        public byte GcprtOpt { get; set; }
        public byte MediaIndex { get; set; }
        public string? GiftNumber { get; set; }
        public int AmountRedeemed { get; set; }
        public int ChangeDue { get; set; }
        public int Balance { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
