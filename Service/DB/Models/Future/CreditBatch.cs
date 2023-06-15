using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CreditBatch
    {
        public Guid BatchId { get; set; }
        public int StoreId { get; set; }
        public int TransSeq { get; set; }
        public byte[] AccountNumber { get; set; } = null!;
        public byte[] AppCd { get; set; } = null!;
        public byte[] ExpirationDate { get; set; } = null!;
        public int AuthAmount { get; set; }
        public int CheckNumber { get; set; }
        public DateTime? AuthorizeDate { get; set; }
        public byte[] BatchRecord { get; set; } = null!;
        public int BatchNumber { get; set; }
        public bool IsSettled { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataId { get; set; }
    }
}
