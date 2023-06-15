using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TaxSchedule
    {
        public Guid TaxScheduleId { get; set; }
        public Guid TaxId { get; set; }
        public int DayIndex { get; set; }
        public bool UseTax { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public virtual Tax Tax { get; set; } = null!;
    }
}
