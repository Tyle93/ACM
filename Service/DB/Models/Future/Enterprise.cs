using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Enterprise
    {
        public Guid EntId { get; set; }
        public int ServerIpaddress { get; set; }
        public int CustomerLevel { get; set; }
        public int GiftLevel { get; set; }
        public string EnterpriseName { get; set; } = null!;
        public int CountryCode { get; set; }
        public string? Apikey { get; set; }
        public string? EmailServer { get; set; }
        public string? EmailUser { get; set; }
        public string? EmailPassword { get; set; }
        public int EmailPort { get; set; }
        public bool EmailUseSsl { get; set; }
        public byte[]? EmailPasswordEnc { get; set; }
    }
}
