using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MobileTerminal
    {
        public MobileTerminal()
        {
            MobileTerminalSessionInfos = new HashSet<MobileTerminalSessionInfo>();
        }

        public Guid MobileTerminalId { get; set; }
        public string MobileIdentifier { get; set; } = null!;
        public short? EmpId { get; set; }
        public int DeviceStatus { get; set; }
        public int? TerminalNumber { get; set; }
        public string? SyncFile { get; set; }
        public string? Description { get; set; }
        public int? SyncId { get; set; }

        public virtual ICollection<MobileTerminalSessionInfo> MobileTerminalSessionInfos { get; set; }
    }
}
