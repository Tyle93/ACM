using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PalertSetting
    {
        public Guid AlertSettingId { get; set; }
        public Guid AlertId { get; set; }
        public string Setting { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual Palert Alert { get; set; } = null!;
    }
}
