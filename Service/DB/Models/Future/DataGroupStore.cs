using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DataGroupStore
    {
        public Guid DataGroupStoreId { get; set; }
        public Guid DataGroupId { get; set; }
        public int StoreId { get; set; }

        public virtual DataGroup DataGroup { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
