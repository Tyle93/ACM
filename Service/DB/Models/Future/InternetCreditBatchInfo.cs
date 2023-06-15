using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class InternetCreditBatchInfo
    {
        public Guid InternetCreditBatchInfoId { get; set; }
        public int CurrentBatchNumber { get; set; }
        public int CurrentBatchItemNumber { get; set; }
        public long CurrentGiftCardNumber { get; set; }
    }
}
