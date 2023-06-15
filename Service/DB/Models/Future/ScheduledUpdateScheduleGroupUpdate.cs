using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScheduledUpdateScheduleGroupUpdate
    {
        public ScheduledUpdateScheduleGroupUpdate()
        {
            ScheduledUpdateScheduleGroupUpdateSettingChanges = new HashSet<ScheduledUpdateScheduleGroupUpdateSettingChange>();
        }

        public Guid ScheduledUpdateUpdateId { get; set; }
        public Guid ScheduledUpdateMaintenanceId { get; set; }
        public Guid ScheduleGroupId { get; set; }

        public virtual ScheduledUpdateScheduleGroup ScheduleGroup { get; set; } = null!;
        public virtual ScheduledUpdateMaintenance ScheduledUpdateMaintenance { get; set; } = null!;
        public virtual ICollection<ScheduledUpdateScheduleGroupUpdateSettingChange> ScheduledUpdateScheduleGroupUpdateSettingChanges { get; set; }
    }
}
