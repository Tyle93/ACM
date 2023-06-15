using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScreenList
    {
        public Guid ScreenListId { get; set; }
        public Guid ScreenId { get; set; }
        public int ScreenListIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public short SortType { get; set; }
        public short SortOrder { get; set; }
        public int OpenCheckColumnCount { get; set; }
        public short ChecksToShow { get; set; }
        public short OrderType { get; set; }
        public short UnassignedOnly { get; set; }
        public int OpenCheckThreshold { get; set; }
        public byte RevenueCenter { get; set; }
        public short UseWebCustomer { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
