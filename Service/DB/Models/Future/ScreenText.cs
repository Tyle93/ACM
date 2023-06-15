using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ScreenText
    {
        public Guid ScreenTextId { get; set; }
        public Guid ScreenId { get; set; }
        public int ScreenTextIndex { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public string? Text { get; set; }

        public virtual Screen Screen { get; set; } = null!;
    }
}
