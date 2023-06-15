using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScreenFrame
    {
        public Guid ScreenFrameId { get; set; }
        public Guid ScreenId { get; set; }
        public int ScreenFrameIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
