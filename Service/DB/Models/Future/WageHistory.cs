using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class WageHistory
    {
        public WageHistory()
        {
            WageHistoryWages = new HashSet<WageHistoryWage>();
        }

        public Guid WageHistoryId { get; set; }
        public int StoreId { get; set; }
        public int EmpId { get; set; }
        public DateTime WageDate { get; set; }

        public virtual ICollection<WageHistoryWage> WageHistoryWages { get; set; }
    }
}
