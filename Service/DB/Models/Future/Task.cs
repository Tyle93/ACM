using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Task
    {
        public Task()
        {
            TaskItems = new HashSet<TaskItem>();
        }

        public Guid TaskId { get; set; }
        public int StoreId { get; set; }
        public short LastTaskIndex { get; set; }

        public virtual ICollection<TaskItem> TaskItems { get; set; }
    }
}
