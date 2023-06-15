using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Sync
    {
        public Sync()
        {
            SyncData = new HashSet<SyncDatum>();
        }

        public Guid SyncId { get; set; }
        public int DbtableNumber { get; set; }
        public int Source { get; set; }
        public int Destination { get; set; }
        public string Status { get; set; } = null!;
        public int ToStore { get; set; }
        public int FromStore { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? CurrentRecordNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<SyncDatum> SyncData { get; set; }
    }
}
