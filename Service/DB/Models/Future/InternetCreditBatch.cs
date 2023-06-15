using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class InternetCreditBatch
    {
        public Guid InternetBatchId { get; set; }
        public int StoreId { get; set; }
        public byte IsCaptured { get; set; }
        public byte IsVoided { get; set; }
        public DateTime ProcessDate { get; set; }
        public byte[] AccountNumber { get; set; } = null!;
        public byte[] ExpirationDate { get; set; } = null!;
        public byte[] Track2 { get; set; } = null!;
        public byte[] ApprovalCode { get; set; } = null!;
        public byte[] ReferenceData { get; set; } = null!;
        public byte[] ReferenceNumber { get; set; } = null!;
        public byte OpType { get; set; }
        public short EmployeeId { get; set; }
        public int CheckNumber { get; set; }
        public int SaleAmount { get; set; }
        public int TipAmount { get; set; }
        public string MerchantId { get; set; } = null!;
        public int BatchNumber { get; set; }
        public int BatchItemNumber { get; set; }
        public int BatchRevisionNumber { get; set; }
        public byte IsOffline { get; set; }
        public int OfflineSaleAmount { get; set; }
        public int OfflineTipAmount { get; set; }
        public byte[]? AdditionalInfo { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataId { get; set; }
    }
}
