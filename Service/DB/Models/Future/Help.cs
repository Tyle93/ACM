using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Help
    {
        public Guid HelpId { get; set; }
        public Guid RegionId { get; set; }
        public string HelpName { get; set; } = null!;
        public string HelpText { get; set; } = null!;
    }
}
