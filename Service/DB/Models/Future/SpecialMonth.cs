using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SpecialMonth
    {
        public Guid SpecialMonthId { get; set; }
        public Guid SpecialId { get; set; }
        public int SpecialMonthIndex { get; set; }
        public string ItemName { get; set; } = null!;
        public bool ShowCountAvailable { get; set; }
        public int Price { get; set; }

        public virtual Special Special { get; set; } = null!;
    }
}
