using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class FollowMe
    {
        public Guid FollowMeId { get; set; }
        public Guid SaleId { get; set; }
        public Guid EmployeeId { get; set; }
        public short CurrentTerminal { get; set; }
        public short RequestTermimal { get; set; }
        public short State { get; set; }
    }
}
