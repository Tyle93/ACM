using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Shorthand
    {
        public Guid ShorthandId { get; set; }
        public string ShortCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string? Modifiers { get; set; }
    }
}
