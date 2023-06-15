using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TabbedOutAlert
    {
        public Guid MessageId { get; set; }
        public string TabOutCode { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool WasViewed { get; set; }
    }
}
