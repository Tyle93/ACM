using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class AdDisplay
    {
        public Guid DisplayId { get; set; }
        public int TerminalNumber { get; set; }
        public int DisplayNumber { get; set; }
        public bool IsScoreBoard { get; set; }
        public bool IsPause { get; set; }
        public Guid DefaultPlayListId { get; set; }
        public bool IsEnabled { get; set; }
        public string DisplayTitle { get; set; } = null!;
        public string Status { get; set; } = null!;
        public bool IsPrimary { get; set; }
        public bool IsMenuBoard { get; set; }
        public Guid MenuTemplate { get; set; }
        public Guid ScoreBoardTemplate { get; set; }
    }
}
