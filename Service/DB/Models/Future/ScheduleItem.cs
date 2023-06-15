using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScheduleItem
    {
        public Guid ScheduleItemId { get; set; }
        public Guid ScheduleId { get; set; }
        public int ScheduleItemIndex { get; set; }
        public byte WorkCenter { get; set; }
        public byte Shift { get; set; }
        public int EmpId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string? ShiftDescription { get; set; }

        public virtual Schedule Schedule { get; set; } = null!;
    }
}
