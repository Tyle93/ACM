using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Break
    {
        public Break()
        {
            BreakJobs = new HashSet<BreakJob>();
        }

        public Guid BreakId { get; set; }
        public Guid RegionId { get; set; }
        public int BreakIndex { get; set; }
        public string BreakName { get; set; } = null!;
        public bool IsPaid { get; set; }
        public int MinutesAllowed { get; set; }
        public int MinutesToQualify { get; set; }
        public bool PunchIn { get; set; }
        public bool TrackEndBreak { get; set; }

        public virtual ICollection<BreakJob> BreakJobs { get; set; }
    }
}
