using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DirtyTable
    {
        public Guid DirtyTableId { get; set; }
        public int StoreId { get; set; }
        public short TableNumber { get; set; }
    }
}
