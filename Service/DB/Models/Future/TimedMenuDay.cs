using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TimedMenuDay
    {
        public Guid TimedMenuDayId { get; set; }
        public Guid TimedMenuId { get; set; }
        public int DayIndex { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int RevenueCenter { get; set; }
        public string MenuName { get; set; } = null!;
        public string CommonMenuName { get; set; } = null!;
        public bool IsActive { get; set; }
        public int TerminalNumber { get; set; }

        public virtual TimedMenu TimedMenu { get; set; } = null!;
    }
}
