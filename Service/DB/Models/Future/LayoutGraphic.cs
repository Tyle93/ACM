using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class LayoutGraphic
    {
        public Guid LayoutGraphicId { get; set; }
        public Guid LayoutId { get; set; }
        public int GraphicIndex { get; set; }
        public short RoomIndex { get; set; }

        public virtual Layout Layout { get; set; } = null!;
    }
}
