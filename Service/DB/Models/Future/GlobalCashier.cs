using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class GlobalCashier
    {
        public Guid GlobalCashierId { get; set; }
        public int GroupIndex { get; set; }
        public DateTime ChangeDate { get; set; }
        public int LastCashier { get; set; }
        public int StoreId { get; set; }
    }
}
