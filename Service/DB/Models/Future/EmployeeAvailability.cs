using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class EmployeeAvailability
    {
        public EmployeeAvailability()
        {
            EmployeeAvailabilityRanges = new HashSet<EmployeeAvailabilityRange>();
        }

        public Guid EmployeeAvailabilityId { get; set; }
        public int EmpId { get; set; }
        public int StoreId { get; set; }
        public byte[]? Weekly { get; set; }
        public int RangeUsed { get; set; }

        public virtual ICollection<EmployeeAvailabilityRange> EmployeeAvailabilityRanges { get; set; }
    }
}
