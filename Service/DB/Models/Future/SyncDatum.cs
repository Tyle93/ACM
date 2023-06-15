using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SyncDatum
    {
        public Guid SyncDataId { get; set; }
        public Guid SyncId { get; set; }
        public Guid DbrecordId { get; set; }

        public virtual Sync Sync { get; set; } = null!;
    }
}
