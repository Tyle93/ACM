using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class EmployeeAvailabilityRange
    {
        public Guid EmployeeAvailabilityRangeId { get; set; }
        public Guid EmployeeAvailabilityId { get; set; }
        public int RangeIndex { get; set; }
        public string RangeDescription { get; set; } = null!;
        public byte RangeType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual EmployeeAvailability EmployeeAvailability { get; set; } = null!;
    }
}
