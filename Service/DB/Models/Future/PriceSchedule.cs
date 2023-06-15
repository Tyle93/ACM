using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PriceSchedule
    {
        public Guid PriceScheduleId { get; set; }
        public int StoreId { get; set; }
        public int PriceScheduleIndex { get; set; }
        public string PriceScheduleName { get; set; } = null!;
        public int ScheduleDays { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public bool IsSeasonal { get; set; }
        public int SeasonalStartMonth { get; set; }
        public int SeasonalStartDay { get; set; }
        public int SeasonalEndMonth { get; set; }
        public int SeasonalEndDay { get; set; }
    }
}
