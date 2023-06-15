using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Session
    {
        public Guid SessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionKey { get; set; } = null!;
        public DateTime LastActivityDate { get; set; }
    }
}
