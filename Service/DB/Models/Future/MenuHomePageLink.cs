using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MenuHomePageLink
    {
        public Guid HomePageLinkId { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int EmpId { get; set; }
        public Guid MenuPageId { get; set; }

        public virtual MenuPage MenuPage { get; set; } = null!;
    }
}
