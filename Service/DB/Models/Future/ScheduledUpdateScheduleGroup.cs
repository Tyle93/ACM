using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScheduledUpdateScheduleGroup
    {
        public ScheduledUpdateScheduleGroup()
        {
            DataGroups = new HashSet<DataGroup>();
            ScheduledUpdateScheduleGroupUpdates = new HashSet<ScheduledUpdateScheduleGroupUpdate>();
        }

        public Guid ScheduleGroupId { get; set; }
        public string? ScheduleGroupName { get; set; }
        public DateTime ScheduleGroupDate { get; set; }
        public Guid? DataGroupId { get; set; }

        public virtual ICollection<DataGroup> DataGroups { get; set; }
        public virtual ICollection<ScheduledUpdateScheduleGroupUpdate> ScheduledUpdateScheduleGroupUpdates { get; set; }
    }
}
