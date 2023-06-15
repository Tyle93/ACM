using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MenuPageGroup
    {
        public Guid MenuPageGroupId { get; set; }
        public int IsActive { get; set; }
        public Guid MenuPageId { get; set; }
        public DateTime? CreateStamp { get; set; }
        public string GroupName { get; set; } = null!;
        public int GroupFunctionType { get; set; }
        public int ParentMenuPageGroupId { get; set; }
        public int SecLevel { get; set; }
        public int OrderIndex { get; set; }
        public int DisplayMode { get; set; }

        public virtual MenuPage MenuPage { get; set; } = null!;
    }
}
