using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SecurityCheck
    {
        public Guid SecurityCheckId { get; set; }
        public int Type { get; set; }
        public byte[]? Path { get; set; }
        public byte[]? FileName { get; set; }
    }
}
