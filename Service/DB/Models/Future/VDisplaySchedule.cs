using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VDisplaySchedule
    {
        public Guid PlayListId { get; set; }
        public string PlayListName { get; set; } = null!;
        public bool IsEnabled { get; set; }
        public Guid GroupId { get; set; }
        public Guid DisplayId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool Expr1 { get; set; }
        public int Type { get; set; }
        public int Priority { get; set; }
    }
}
