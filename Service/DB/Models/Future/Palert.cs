using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Palert
    {
        public Palert()
        {
            PalertSettings = new HashSet<PalertSetting>();
            PalertTos = new HashSet<PalertTo>();
        }

        public Guid AlertId { get; set; }
        public int StoreId { get; set; }
        public string AlertName { get; set; } = null!;
        public string AlertType { get; set; } = null!;
        public string? AdditionalEmail { get; set; }
        public DateTime? LastRun { get; set; }
        public bool IsEnabled { get; set; }
        public string ScheduleData { get; set; } = null!;
        public bool ClockedInOnly { get; set; }
        public int FormatType { get; set; }
        public bool RunImmediately { get; set; }

        public virtual ICollection<PalertSetting> PalertSettings { get; set; }
        public virtual ICollection<PalertTo> PalertTos { get; set; }
    }
}
