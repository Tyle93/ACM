using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TabbedOut
    {
        public Guid TabOutId { get; set; }
        public string TabOutCode { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public byte[] CardName { get; set; } = null!;
        public byte[] CardNum { get; set; } = null!;
        public byte[] ExpirationDate { get; set; } = null!;
        public byte[] AuthResponse { get; set; } = null!;
        public byte[] ReferenceNumber { get; set; } = null!;
        public byte[] PreAuthResponse { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int MediaIndex { get; set; }
        public Guid SaleId { get; set; }
        public int DataVersion { get; set; }
        public Guid? DataId { get; set; }
    }
}
