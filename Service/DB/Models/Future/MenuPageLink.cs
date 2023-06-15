using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MenuPageLink
    {
        public Guid MenuPageLinkId { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int IsActive { get; set; }
        public Guid MenuPageItemId { get; set; }
        public Guid MenuPageGroupId { get; set; }
        public int OrderIndex { get; set; }
        public string Notes { get; set; } = null!;
        public string NameReplace { get; set; } = null!;
    }
}
