using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Posshift
    {
        public Guid PosshiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short TerminalNumber { get; set; }
        public int DrawerNumber { get; set; }
        public int StartEmpId { get; set; }
        public int EndEmpId { get; set; }
        public int StartAmount { get; set; }
        public int EndAmount { get; set; }
        public int FloatAmount { get; set; }
        public int StoreId { get; set; }
        public short ShiftType { get; set; }
    }
}
