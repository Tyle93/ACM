using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class GiftSeriesAvailability
    {
        public Guid GiftSeriesAvailabilityId { get; set; }
        public Guid GiftSeriesId { get; set; }
        public int DayIndex { get; set; }
        public bool IsAvailable { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public virtual GiftSeries GiftSeries { get; set; } = null!;
    }
}
