using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PendingSale
    {
        public bool AllowPartialAuth { get; set; }
        public int AuthBalance { get; set; }
        public byte[] AuthCardName { get; set; } = null!;
        public byte[] AuthCardNumber { get; set; } = null!;
        public byte[] AuthCardNumberEncrypted { get; set; } = null!;
        public byte[] AuthCardType { get; set; } = null!;
        public short AuthCv2 { get; set; }
        public byte[] AuthCv2strEncrypted { get; set; } = null!;
        public int AuthDataVersion { get; set; }
        public byte[] AuthEncryptedBlock { get; set; } = null!;
        public byte[] AuthEncryptionKey { get; set; } = null!;
        public byte[] AuthExpirationDateEncrypted { get; set; } = null!;
        public bool AuthIsE2eencryption { get; set; }
        public int AuthMediaIndex { get; set; }
        public byte[] AuthMsrswipe { get; set; } = null!;
        public byte[] AuthReferenceData { get; set; } = null!;
        public byte[] AuthReferenceNumber { get; set; } = null!;
        public byte[] AuthResponse { get; set; } = null!;
        public int AuthSource { get; set; }
        public int AuthTipAmount { get; set; }
        public byte[] AuthTrack2Encrypted { get; set; } = null!;
        public int AuthTransactionAmount { get; set; }
        public int AuthZipCode { get; set; }
        public byte CardIndex { get; set; }
        public int CheckNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public bool DoingRoa { get; set; }
        public int MsrencryptionType { get; set; }
        public short EmployeeId { get; set; }
        public Guid PendingSaleId { get; set; }
        public bool InOfflineMode { get; set; }
        public bool IsPreAuth { get; set; }
        public bool IsRefund { get; set; }
        public byte[] PublicKey { get; set; } = null!;
        public long PublicKeyLength { get; set; }
        public int NoNonSufficentFundsAmount { get; set; }
        public int RevenueCenter { get; set; }
        public Guid SaleId { get; set; }
        public byte[] Salt { get; set; } = null!;
        public long SaltLength { get; set; }
        public byte[] SessionId { get; set; } = null!;
        public Guid TransactionId { get; set; }
        public bool UseBalance { get; set; }
        public byte OpCode { get; set; }
    }
}
