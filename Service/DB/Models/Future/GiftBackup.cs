using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class GiftBackup
    {
        public Guid GiftBackupId { get; set; }
        public byte[] Id { get; set; } = null!;
        public byte[] Data { get; set; } = null!;
        public int ProcessorType { get; set; }
        public int Balance { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Processed { get; set; }
        public int StoreId { get; set; }
    }
}
