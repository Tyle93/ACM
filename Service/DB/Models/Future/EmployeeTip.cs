using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class EmployeeTip
    {
        public Guid EmployeeTipId { get; set; }
        public int StoreId { get; set; }
        public short IsFinalized { get; set; }
        public int EmpId { get; set; }
        public int CheckNumber { get; set; }
        public short MediaIndex { get; set; }
        public int Amount { get; set; }
        public int Declared { get; set; }
        public DateTime TipDate { get; set; }
        public int SharedEmpId { get; set; }
    }
}
