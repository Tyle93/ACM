using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScreenBitmap
    {
        public Guid ScreenBitmapId { get; set; }
        public Guid ScreenId { get; set; }
        public int ScreenBitmapIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public string? BitmapFile { get; set; }
        public short DisplayMethod { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
