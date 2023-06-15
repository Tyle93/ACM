using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class RewardPlanLevel
    {
        public Guid RewardPlanLevelId { get; set; }
        public Guid RewardPlanId { get; set; }
        public int LevelIndex { get; set; }
        public short BonusMethod { get; set; }
        public int VisitCount { get; set; }
        public int DollarsSpent { get; set; }
        public int ItemsPurchased { get; set; }
        public short RepeatCount { get; set; }
        public short RewardType { get; set; }
        public short CouponIndex { get; set; }
        public short DiscountIndex { get; set; }
        public short GiftSeriesIndex { get; set; }
        public int GiftAmount { get; set; }
        public short GiftPrintOptions { get; set; }
        public string? ItemMask { get; set; }
        public string? SkipDepartmentMask { get; set; }
        public int HoursCount { get; set; }
        public int CreditAmount { get; set; }

        public virtual RewardPlan RewardPlan { get; set; } = null!;
    }
}
