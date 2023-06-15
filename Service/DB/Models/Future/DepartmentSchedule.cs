using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DepartmentSchedule
    {
        public Guid DepartmentScheduleId { get; set; }
        public Guid DepartmentId { get; set; }
        public int DayIndex { get; set; }
        public bool IsUsed { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
