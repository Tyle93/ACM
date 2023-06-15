using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VMenuSchedule
    {
        public string ItemName { get; set; } = null!;
        public Guid PlaylistItemId { get; set; }
        public Guid GroupId { get; set; }
        public Guid DisplayId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsEnabled { get; set; }
        public int Type { get; set; }
        public int Priority { get; set; }
    }
}
