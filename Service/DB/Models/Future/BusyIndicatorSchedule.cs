using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class BusyIndicatorSchedule
    {
        public Guid BusyIndicatorScheduleId { get; set; }
        public Guid BusyIndicatorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TerminalNumber { get; set; }
    }
}
