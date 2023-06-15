using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CustomerNumber
    {
        public Guid CustomerNumberId { get; set; }
        public Guid RegionId { get; set; }
        public int CustomerNumber1 { get; set; }
    }
}
