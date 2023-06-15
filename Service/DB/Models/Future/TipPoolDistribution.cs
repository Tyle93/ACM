using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TipPoolDistribution
    {
        public Guid TipPoolDistributionId { get; set; }
        public Guid TipPoolId { get; set; }
        public byte JobCode { get; set; }
        public byte DistributionType { get; set; }
        public short Percentage { get; set; }

        public virtual TipPool TipPool { get; set; } = null!;
    }
}
