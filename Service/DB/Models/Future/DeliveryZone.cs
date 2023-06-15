using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DeliveryZone
    {
        public Guid DeliveryZoneId { get; set; }
        public int ZoneIndex { get; set; }
        public Guid RegionId { get; set; }
        public string ZoneName { get; set; } = null!;
        public int Amount { get; set; }
        public int DriverAmount { get; set; }
        public bool IsServiceCharge { get; set; }
    }
}
