using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DepartmentRank
    {
        public Guid DepartmentRankId { get; set; }
        public Guid DepartmentId { get; set; }
        public int Rank { get; set; }
    }
}
