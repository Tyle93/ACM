using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            ScheduleItems = new HashSet<ScheduleItem>();
        }

        public Guid ScheduleId { get; set; }
        public int StoreId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public int ScheduleCount { get; set; }

        public virtual ICollection<ScheduleItem> ScheduleItems { get; set; }
    }
}
