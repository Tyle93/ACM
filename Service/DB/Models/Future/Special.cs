using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Special
    {
        public Special()
        {
            SpecialMonths = new HashSet<SpecialMonth>();
            SpecialWeeks = new HashSet<SpecialWeek>();
        }

        public Guid SpecialId { get; set; }
        public Guid RegionId { get; set; }
        public int SpecialIndex { get; set; }
        public string? SpecialName { get; set; }
        public short SpecialType { get; set; }

        public virtual ICollection<SpecialMonth> SpecialMonths { get; set; }
        public virtual ICollection<SpecialWeek> SpecialWeeks { get; set; }
    }
}
