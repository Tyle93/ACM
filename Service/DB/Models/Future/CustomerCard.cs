using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CustomerCard
    {
        public Guid CustomerCardId { get; set; }
        public Guid CustomerId { get; set; }
        public int CardIndex { get; set; }
        public int CardSource { get; set; }
        public byte[] CreditCard { get; set; } = null!;
        public bool IsE2eencryption { get; set; }
        public byte[]? EncryptedBlock { get; set; }
        public byte[]? EncryptionKey { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataId { get; set; }
        public byte[]? EncryptedRawSwipe { get; set; }
        public byte[]? VaultId { get; set; }
        public int VaultMediaIndex { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
