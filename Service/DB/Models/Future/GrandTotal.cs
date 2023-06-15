using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class GrandTotal
    {
        public Guid GrandTotalId { get; set; }
        public long Total { get; set; }
        public DateTime LastUpdate { get; set; }
        public short TerminalNumber { get; set; }
    }
}
