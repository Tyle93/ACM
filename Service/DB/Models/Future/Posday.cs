using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Posday
    {
        public Guid PosdayId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StartEmpId { get; set; }
        public int EndEmpId { get; set; }
        public int BankDeposit { get; set; }
        public string? Comment { get; set; }
        public int StoreId { get; set; }
    }
}
