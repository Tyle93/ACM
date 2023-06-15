using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Region
    {
        public Guid RegionId { get; set; }
        public string RegionName { get; set; } = null!;
        public string? RegionDescription { get; set; }
        public string Area { get; set; } = null!;
    }
}
