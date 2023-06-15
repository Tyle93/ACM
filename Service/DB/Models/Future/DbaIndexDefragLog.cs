using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DbaIndexDefragLog
    {
        public int IndexDefragId { get; set; }
        public int DatabaseId { get; set; }
        public string DatabaseName { get; set; } = null!;
        public int ObjectId { get; set; }
        public string ObjectName { get; set; } = null!;
        public int IndexId { get; set; }
        public string IndexName { get; set; } = null!;
        public short PartitionNumber { get; set; }
        public double Fragmentation { get; set; }
        public int PageCount { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public int? DurationSeconds { get; set; }
        public string? SqlStatement { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
