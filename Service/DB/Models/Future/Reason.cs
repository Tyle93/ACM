using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Reason
    {
        public Guid ReasonId { get; set; }
        public Guid RegionId { get; set; }
        public int ReasonType { get; set; }
        public int ReasonIndex { get; set; }
        public string ReasonName { get; set; } = null!;
    }
}
