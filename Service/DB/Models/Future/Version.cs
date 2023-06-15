using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Version
    {
        public Guid VersionId { get; set; }
        public int StoreId { get; set; }
        public int CodeVersion { get; set; }
        public int DatabaseVersion { get; set; }
    }
}
