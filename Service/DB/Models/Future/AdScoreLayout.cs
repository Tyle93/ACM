using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class AdScoreLayout
    {
        public Guid DesignId { get; set; }
        public int DisplayNumber { get; set; }
        public int TerminalNumber { get; set; }
        public string BackgroundColor { get; set; } = null!;
        public int WidthPercent { get; set; }
        public string LeftColumnHeader { get; set; } = null!;
        public string RightColumnHeader { get; set; } = null!;
        public string FontColor { get; set; } = null!;
        public int TopPadding { get; set; }
        public string EvenRowBackgroundColor { get; set; } = null!;
        public string OddRowBackgroundColor { get; set; } = null!;
        public string EvenRowFontColor { get; set; } = null!;
        public string OddRowFontColor { get; set; } = null!;
        public string HeaderLineColor { get; set; } = null!;
        public int HeaderLineHeight { get; set; }
        public string TotalLineColor { get; set; } = null!;
        public int TotalLineHeight { get; set; }
        public string StageColor { get; set; } = null!;
        public string TotalColumnHeaderText { get; set; } = null!;
        public bool? DrawModifiers { get; set; }
        public Guid TemplateItemId { get; set; }
        public int HeightPercent { get; set; }
        public int TableBorder { get; set; }
        public string FontFamily { get; set; } = null!;
        public bool? FontWeight { get; set; }
        public int FontSize { get; set; }
    }
}
