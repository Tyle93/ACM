using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScheduledUpdateScheduleGroupUpdateSettingChange
    {
        public Guid ScheduledUpdateSettingChangeId { get; set; }
        public Guid ScheduledUpdateUpdateId { get; set; }
        public string ObjectName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string ColumnName { get; set; } = null!;
        public string OriginalFieldId { get; set; } = null!;
        public string PreviousValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public int DataTypeId { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime LastModified { get; set; }

        public virtual DataTypeReference DataType { get; set; } = null!;
        public virtual ScheduledUpdateScheduleGroupUpdate ScheduledUpdateUpdate { get; set; } = null!;
    }
}
