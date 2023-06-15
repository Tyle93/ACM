using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TipPoolContribution
    {
        public Guid TipPoolContributionId { get; set; }
        public Guid TipPoolId { get; set; }
        public byte JobCode { get; set; }
        public string? Name { get; set; }
        public byte ContributionType { get; set; }
        public short Percentage { get; set; }

        public virtual TipPool TipPool { get; set; } = null!;
    }
}
