using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class LayoutRoom
    {
        public Guid LayoutRoomId { get; set; }
        public Guid LayoutId { get; set; }
        public int RoomIndex { get; set; }
        public string RoomName { get; set; } = null!;
        public string ImageFile { get; set; } = null!;
        public short PriceLevel { get; set; }

        public virtual Layout Layout { get; set; } = null!;
    }
}
