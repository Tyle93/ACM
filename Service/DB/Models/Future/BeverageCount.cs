using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class BeverageCount
    {
        public BeverageCount()
        {
            BeverageCountItems = new HashSet<BeverageCountItem>();
        }

        public Guid BeverageCountId { get; set; }
        public short EmpId { get; set; }
        public short GroupId { get; set; }
        public int InCount { get; set; }
        public int OutCount { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsEndCount { get; set; }
        public string? ComputerName { get; set; }

        public virtual ICollection<BeverageCountItem> BeverageCountItems { get; set; }
    }
}
