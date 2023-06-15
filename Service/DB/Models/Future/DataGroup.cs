using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DataGroup
    {
        public DataGroup()
        {
            DataGroupStores = new HashSet<DataGroupStore>();
        }

        public Guid DataGroupId { get; set; }
        public Guid ScheduleGroupId { get; set; }
        public DateTime? AppliedDate { get; set; }

        public virtual ScheduledUpdateScheduleGroup ScheduleGroup { get; set; } = null!;
        public virtual ICollection<DataGroupStore> DataGroupStores { get; set; }
    }
}
