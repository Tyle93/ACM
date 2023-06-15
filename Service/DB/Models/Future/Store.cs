using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Store
    {
        public Store()
        {
            DataGroupStores = new HashSet<DataGroupStore>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; } = null!;
        public string? StoreDescription { get; set; }
        public Guid? RegionId { get; set; }
        public byte[]? SystemSettings { get; set; }
        public byte[]? TerminalSettings { get; set; }
        public int DatabaseVersion { get; set; }
        public int CodeVersion { get; set; }
        public string? Apikey { get; set; }
        public int InitEnterprise { get; set; }
        public int GuidNode { get; set; }

        public virtual ICollection<DataGroupStore> DataGroupStores { get; set; }
    }
}
