using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Xmlbucket
    {
        public Guid XmlbucketsId { get; set; }
        public int StoreId { get; set; }
        public DateTime BusinessDate { get; set; }
        public bool IsPartial { get; set; }
        public int Version { get; set; }
        public int BucketType { get; set; }
        public string Xml { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string? Xml2 { get; set; }
    }
}
