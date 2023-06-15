using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class WageHistoryWage
    {
        public Guid WageHistoryWageId { get; set; }
        public Guid WageHistoryId { get; set; }
        public int WageHistoryWageIndex { get; set; }
        public int OldWorkCenter { get; set; }
        public int OldOvertimeRate { get; set; }
        public int OldRegularRate { get; set; }
        public int NewWorkCenter { get; set; }
        public int NewOvertimeRate { get; set; }
        public int NewRegularRate { get; set; }

        public virtual WageHistory WageHistory { get; set; } = null!;
    }
}
