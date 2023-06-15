using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Vdu
    {
        public Vdu()
        {
            Vduitems = new HashSet<Vduitem>();
        }

        public Guid Vduid { get; set; }
        public int TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ToPrinterNumber { get; set; }
        public short TerminalNumber { get; set; }
        public int CheckNumber { get; set; }
        public int EmpId { get; set; }
        public byte OrderType { get; set; }
        public short TableIndex { get; set; }
        public int Total { get; set; }
        public string? CustomerName { get; set; }
        public int CustomerCount { get; set; }
        public int SubTotal { get; set; }
        public DateTime? PromiseTime { get; set; }
        public byte CheckStatus { get; set; }
        public short OrderTakerEmpId { get; set; }
        public string? CheckDescription { get; set; }

        public virtual ICollection<Vduitem> Vduitems { get; set; }
    }
}
