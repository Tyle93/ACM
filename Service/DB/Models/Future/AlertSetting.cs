using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class AlertSetting
    {
        public Guid AlertSettingsId { get; set; }
        public string AlertFieldName { get; set; } = null!;
        public string AlertFieldValue { get; set; } = null!;
        public int IsActive { get; set; }
        public DateTime CreateStamp { get; set; }
        public DateTime UpdateStamp { get; set; }
        public Guid AlertId { get; set; }
    }
}
