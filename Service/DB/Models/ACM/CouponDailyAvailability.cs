using System;
using System.Collections.Generic;

namespace ACM.ACM_Models
{
    public partial class CouponDailyAvailability
    {
        public string Id { get; set; } = null!;
        public byte[] IsActive { get; set; } = null!;
        public long DayIndex { get; set; }
        public long StartHour { get; set; }
        public long StartMinute { get; set; }
        public long EndHour { get; set; }
        public long EndMinute { get; set; }
        public string? CouponRuleId { get; set; }

        public virtual CouponRule? CouponRule { get; set; }
    }
}
