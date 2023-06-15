using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Paydiant
    {
        public Guid PaydiantId { get; set; }
        public int StoreId { get; set; }
        public string StoreLocationId { get; set; } = null!;
        public string WebServiceUrl { get; set; } = null!;
        public string MerchantId { get; set; } = null!;
        public string TerminalId { get; set; } = null!;
        public string GatewayUrl { get; set; } = null!;
        public byte[] MerchantKey { get; set; } = null!;
        public int OfferMediaIndex { get; set; }
    }
}
