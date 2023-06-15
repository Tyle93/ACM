using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemRank
    {
        public Guid ItemRankId { get; set; }
        public Guid ItemId { get; set; }
        public int Rank { get; set; }
    }
}
