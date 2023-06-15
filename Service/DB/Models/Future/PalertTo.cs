using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PalertTo
    {
        public Guid AlertEmpId { get; set; }
        public Guid AlertId { get; set; }
        public int ToType { get; set; }
        public int EmpId { get; set; }
        public int ClassIndex { get; set; }

        public virtual Palert Alert { get; set; } = null!;
    }
}
