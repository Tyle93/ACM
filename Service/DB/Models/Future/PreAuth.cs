using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PreAuth
    {
        public Guid PreAuthId { get; set; }
        public int StoreId { get; set; }
        public DateTime PreAuthDate { get; set; }
        public int CheckNumber { get; set; }
        public byte[] CardNumber { get; set; } = null!;
        public byte[] ExpirationDate { get; set; } = null!;
        public byte[] AuthResponse { get; set; } = null!;
        public byte[] CardName { get; set; } = null!;
        public byte[] AcqRefData { get; set; } = null!;
        public int Amount { get; set; }
        public bool UsedToSettle { get; set; }
        public int MediaIndex { get; set; }
        public byte[]? Track2 { get; set; }
        public Guid SaleId { get; set; }
        public bool IsE2eencryption { get; set; }
        public byte[]? EncryptedBlock { get; set; }
        public byte[]? EncryptionKey { get; set; }
        public int CardSource { get; set; }
        public byte[]? ReferenceNumber { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataId { get; set; }
        public byte[]? EncryptedRawSwipe { get; set; }
        public byte[]? VaultId { get; set; }
        public byte[]? ReferenceData { get; set; }
        public byte[]? ProcessData { get; set; }
        public byte[]? EmvapplicationData { get; set; }
        public byte[]? Emvaid { get; set; }
        public byte[]? Emvtvr { get; set; }
        public byte[]? Emviad { get; set; }
        public byte[]? Emvtsi { get; set; }
        public byte[]? Emvarc { get; set; }
        public byte[]? Emvcvm { get; set; }
        public byte[]? EmventryMethod { get; set; }
    }
}
