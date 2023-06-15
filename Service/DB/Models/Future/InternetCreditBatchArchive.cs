using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class InternetCreditBatchArchive
    {
        public Guid CreditBatchArchiveId { get; set; }
        public int StoreId { get; set; }
        public DateTime BatchDate { get; set; }
        public byte[] ReportData { get; set; } = null!;
        public string MerchantId { get; set; } = null!;
        public byte[]? ReceiptData { get; set; }
    }
}
