using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Shift
    {
        public Guid ShiftId { get; set; }
        public int StoreId { get; set; }
        public short ShiftIndex { get; set; }
        public bool IsActive { get; set; }
        public string ShiftDescription { get; set; } = null!;
        public int WorkCenter { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}
