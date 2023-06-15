using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class GiftUsed
    {
        public Guid GiftUsedId { get; set; }
        public Guid GiftId { get; set; }
        public int UseIndex { get; set; }
        public int CheckNumber { get; set; }
        public int Amount { get; set; }

        public virtual Gift Gift { get; set; } = null!;
    }
}
