using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class EnterpriseSyncExclude
    {
        public Guid EnterpriseSyncExcludeId { get; set; }
        public int StoreId { get; set; }
        public int TableId { get; set; }
        public int Destination { get; set; }
    }
}
