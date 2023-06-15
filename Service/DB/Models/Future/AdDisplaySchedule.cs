using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class AdDisplaySchedule
    {
        public Guid DisplayScheduleId { get; set; }
        public Guid DisplayId { get; set; }
        public Guid ObjectId { get; set; }
        public string DaysOfWeek { get; set; } = null!;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsEnabled { get; set; }
        public int Priority { get; set; }
        public int Type { get; set; }
        public Guid GroupId { get; set; }
    }
}
