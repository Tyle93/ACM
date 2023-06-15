using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class OrderType
    {
        public int OrderTypeIndex { get; set; }
        public string Description { get; set; } = null!;
        public string WebDescription { get; set; } = null!;
        public bool IsUsedOnline { get; set; }
        public bool IsOnlineMobile { get; set; }
        public bool AddressRequired { get; set; }
        public int MinimumAmount { get; set; }
        public int ExtraCharge { get; set; }
        public bool ShippingRequired { get; set; }
        public string? ShippingServiceType { get; set; }
    }
}
