using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PagerEmployee
    {
        public Guid PagerEmployeeId { get; set; }
        public Guid PagerId { get; set; }
        public short EmployeeId { get; set; }

        public virtual Pager Pager { get; set; } = null!;
    }
}
