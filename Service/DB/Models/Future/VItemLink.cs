using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VItemLink
    {
        public string ItemName { get; set; } = null!;
        public int IconIndex { get; set; }
        public Guid MenuPageLinkId { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int IsActive { get; set; }
        public Guid MenuPageItemId { get; set; }
        public Guid MenuPageGroupId { get; set; }
        public int OrderIndex { get; set; }
        public string Notes { get; set; } = null!;
        public Guid MenuPageId { get; set; }
        public string NameReplace { get; set; } = null!;
    }
}
