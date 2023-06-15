using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DbaIndexDefragStatus
    {
        public int DatabaseId { get; set; }
        public string DatabaseName { get; set; } = null!;
        public int ObjectId { get; set; }
        public int IndexId { get; set; }
        public short PartitionNumber { get; set; }
        public double Fragmentation { get; set; }
        public int PageCount { get; set; }
        public long RangeScanCount { get; set; }
        public string? SchemaName { get; set; }
        public string? ObjectName { get; set; }
        public string? IndexName { get; set; }
        public DateTime ScanDate { get; set; }
        public DateTime? DefragDate { get; set; }
        public bool PrintStatus { get; set; }
        public int ExclusionMask { get; set; }
    }
}
