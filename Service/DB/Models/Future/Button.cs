using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Button
    {
        public Guid ButtonId { get; set; }
        public Guid RegionId { get; set; }
        public string ButtonName { get; set; } = null!;
        public string? Menu { get; set; }
        public byte Position { get; set; }
        public byte Function { get; set; }
        public byte MinSecLevel { get; set; }
        public bool AskForSupervisor { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public byte[]? Data { get; set; }
        public string? Text { get; set; }
        public short FontHeight { get; set; }
        public short FontWidth { get; set; }
        public short FontEscapement { get; set; }
        public short FontOrientation { get; set; }
        public short FontWeight { get; set; }
        public byte FontItalic { get; set; }
        public byte FontUnderline { get; set; }
        public byte FontStrikeOut { get; set; }
        public byte FontCharSet { get; set; }
        public byte FontOutPrecision { get; set; }
        public byte FontClipPrecision { get; set; }
        public byte FontQuality { get; set; }
        public byte FontPitchAndFamily { get; set; }
        public string? FontFaceName { get; set; }
        public int ForeGround { get; set; }
        public int BackGround { get; set; }
        public byte ImageType { get; set; }
        public byte CtrOrTitle { get; set; }
        public string? GraphicName { get; set; }
        public byte NoBorder { get; set; }
        public bool IsRequired { get; set; }
    }
}
