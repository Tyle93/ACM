using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class RewardPlan
    {
        public RewardPlan()
        {
            RewardPlanLevels = new HashSet<RewardPlanLevel>();
        }

        public Guid RewardPlanId { get; set; }
        public Guid RegionId { get; set; }
        public int RewardIndex { get; set; }
        public string RewardPlanName { get; set; } = null!;
        public int LevelCount { get; set; }
        public bool NoRewardMessage { get; set; }

        public virtual ICollection<RewardPlanLevel> RewardPlanLevels { get; set; }
    }
}
