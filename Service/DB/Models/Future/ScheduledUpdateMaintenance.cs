using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScheduledUpdateMaintenance
    {
        public ScheduledUpdateMaintenance()
        {
            ScheduledUpdateScheduleGroupUpdates = new HashSet<ScheduledUpdateScheduleGroupUpdate>();
        }

        public Guid ScheduledUpdateMaintenanceId { get; set; }
        public string Maintenance { get; set; } = null!;
        public string PrimaryTable { get; set; } = null!;
        public Guid? MenuPageItemId { get; set; }

        public virtual ICollection<ScheduledUpdateScheduleGroupUpdate> ScheduledUpdateScheduleGroupUpdates { get; set; }
    }
}
