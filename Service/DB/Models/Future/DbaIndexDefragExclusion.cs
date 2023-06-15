using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DbaIndexDefragExclusion
    {
        public int DatabaseId { get; set; }
        public string DatabaseName { get; set; } = null!;
        public int ObjectId { get; set; }
        public string ObjectName { get; set; } = null!;
        public int IndexId { get; set; }
        public string IndexName { get; set; } = null!;
        public int ExclusionMask { get; set; }
    }
}
