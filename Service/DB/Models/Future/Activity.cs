using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityDetails = new HashSet<ActivityDetail>();
        }

        public Guid ActivityId { get; set; }
        public int StoreId { get; set; }
        public DateTime ActivityDate { get; set; }
        public int Action { get; set; }
        public int TerminalNumber { get; set; }
        public int TableNumber { get; set; }
        public int CheckNumber { get; set; }
        public int EmpId { get; set; }
        public int SupervisorId { get; set; }
        public int Data1 { get; set; }
        public int Data2 { get; set; }
        public string? Data { get; set; }
        public byte SmallData { get; set; }

        public virtual ICollection<ActivityDetail> ActivityDetails { get; set; }
    }
}
