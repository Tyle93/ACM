using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DashBoardItem
    {
        public Guid DashBoardItemId { get; set; }
        public DateTime? CreateStamp { get; set; }
        public int IsActive { get; set; }
        public Guid DasboardItemType { get; set; }
        public string DasboardItemName { get; set; } = null!;
        public int RefreshInterval { get; set; }
        public Guid DockingCellId { get; set; }
        public int StoreId { get; set; }
    }
}
