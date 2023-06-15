using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TaskItem
    {
        public Guid TaskItemId { get; set; }
        public Guid TaskId { get; set; }
        public short TaskIndex { get; set; }
        public string? TaskDescription { get; set; }
        public string? ProgramName { get; set; }
        public DateTime RunDate { get; set; }
        public short Frequency { get; set; }
        public short Interval { get; set; }
        public short WindowState { get; set; }

        public virtual Task Task { get; set; } = null!;
    }
}
