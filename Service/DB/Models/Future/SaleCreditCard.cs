using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleCreditCard
    {
        public Guid SaleCreditCardId { get; set; }
        public Guid SaleId { get; set; }
        public int CardIndex { get; set; }
        public byte[]? CardNum { get; set; }
        public byte[]? ExpirationDate { get; set; }
        public byte[]? AuthResponse { get; set; }
        public byte[]? CardName { get; set; }
        public byte[]? ReferenceNumber { get; set; }
        public int AuthorizeAmount { get; set; }
        public int EmployeeTips { get; set; }
        public int HouseTips { get; set; }
        public byte MediaIndex { get; set; }
        public byte CardType { get; set; }
        public byte TipTerm { get; set; }
        public int UkrefNo { get; set; }
        public int Bgcbalance { get; set; }
        public string? BankGcissueCurr { get; set; }
        public int BankGcicprevBal { get; set; }
        public int BankGcicendBal { get; set; }
        public string? BankGcicexchRate { get; set; }
        public bool IsE2eencryption { get; set; }
        public byte[]? EncryptedBlock { get; set; }
        public byte[]? EncryptionKey { get; set; }
        public int CardSource { get; set; }
        public bool WasRefunded { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataId { get; set; }
        public byte[]? EncryptedRawSwipe { get; set; }
        public Guid? SignatureId { get; set; }
        public bool IsMoneris { get; set; }
        public byte[]? VaultId { get; set; }
        public byte[]? ReferenceData { get; set; }
        public byte[]? ProcessData { get; set; }
        public byte[]? EmvapplicationLabel { get; set; }
        public byte[]? Emvaid { get; set; }
        public byte[]? Emvtvr { get; set; }
        public byte[]? Emviad { get; set; }
        public byte[]? Emvtsi { get; set; }
        public byte[]? Emvarc { get; set; }
        public byte[]? Emvcvm { get; set; }
        public byte[]? EmventryMethod { get; set; }
        public byte[]? ZipCode { get; set; }
        public string? OfflineId { get; set; }
        public bool IsOffline { get; set; }
        public byte OfflineTerminal { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
