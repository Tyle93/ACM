using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class LayoutText
    {
        public Guid LayoutTextId { get; set; }
        public Guid LayoutId { get; set; }
        public int TextIndex { get; set; }
        public short Orientation { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public short FontHeight { get; set; }
        public short FontWidth { get; set; }
        public short FontEscapement { get; set; }
        public short FontOrientation { get; set; }
        public short FontWeight { get; set; }
        public short FontItalic { get; set; }
        public short FontUnderline { get; set; }
        public short FontStrikeOut { get; set; }
        public short FontCharset { get; set; }
        public short FontOutPrecision { get; set; }
        public short FontClipPrecision { get; set; }
        public short FontQuality { get; set; }
        public short FontPitchAndFamily { get; set; }
        public string FontFaceName { get; set; } = null!;
        public int ForegroundColor { get; set; }
        public int BackgroundColor { get; set; }
        public int RoomIndex { get; set; }
        public string? Text { get; set; }

        public virtual Layout Layout { get; set; } = null!;
    }
}
