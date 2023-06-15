using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class BeverageCountInfo
    {
        public Guid BeverageCountInfoId { get; set; }
        public short EmpId { get; set; }
        public short CountType { get; set; }
        public DateTime EnteredTime { get; set; }
    }
}
