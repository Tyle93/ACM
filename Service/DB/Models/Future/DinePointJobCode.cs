using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DinePointJobCode
    {
        public int JobCodeIndex { get; set; }
        public int StoreId { get; set; }
        public string JobCodeName { get; set; } = null!;
    }
}
