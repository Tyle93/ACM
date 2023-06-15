using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class OfflineLoyaltyQueue
    {
        public Guid OfflineLoyaltyQueueId { get; set; }
        public Guid SaleId { get; set; }
        public int TransactionType { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
