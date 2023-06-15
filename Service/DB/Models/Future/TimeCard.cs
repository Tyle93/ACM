using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TimeCard
    {
        public Guid TimeCardId { get; set; }
        public int StoreId { get; set; }
        public short EmpId { get; set; }
        public DateTime CardDate { get; set; }
        public DateTime? RoundedDate { get; set; }
        public short PunchType { get; set; }
        public byte WorkCenter { get; set; }
        public int BreakIndex { get; set; }
        public Guid? ShadowTimeCardForId { get; set; }
    }
}
