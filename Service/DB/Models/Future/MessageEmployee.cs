using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MessageEmployee
    {
        public Guid MessageEmployeeId { get; set; }
        public Guid MessageId { get; set; }
        public int MessageEmployeeIndex { get; set; }
        public int EmployeeId { get; set; }

        public virtual Message Message { get; set; } = null!;
    }
}
