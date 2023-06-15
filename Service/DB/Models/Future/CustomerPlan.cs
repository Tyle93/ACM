using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CustomerPlan
    {
        public Guid CustomerPlanId { get; set; }
        public Guid CustomerId { get; set; }
        public int PlanIndex { get; set; }
        public int CurrentAmount { get; set; }
        public byte CurrentLevel { get; set; }
        public byte RepeatCount { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
