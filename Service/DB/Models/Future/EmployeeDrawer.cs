using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class EmployeeDrawer
    {
        public Guid EmployeeDrawerId { get; set; }
        public Guid EmployeeId { get; set; }
        public int DrawerIndex { get; set; }
        public short TerminalNumber { get; set; }
        public short DrawerNumber { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
