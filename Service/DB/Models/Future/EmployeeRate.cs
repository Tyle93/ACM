using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class EmployeeRate
    {
        public Guid EmployeeRateId { get; set; }
        public Guid EmployeeId { get; set; }
        public int RateIndex { get; set; }
        public int WorkCenter { get; set; }
        public int OvertimeRate { get; set; }
        public int RegularRate { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
