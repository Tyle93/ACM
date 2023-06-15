using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class AlertEmail
    {
        public Guid AlertEmailId { get; set; }
        public string AlertEmailAddress { get; set; } = null!;
        public string AlertEmailFname { get; set; } = null!;
        public string AlertEmailLname { get; set; } = null!;
        public string AlertEmailPhone { get; set; } = null!;
        public string AlertEmailCarrier { get; set; } = null!;
    }
}
