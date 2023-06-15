using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class StatusMessage
    {
        public Guid StatusMessageId { get; set; }
        public int StoreId { get; set; }
        public int TerminalId { get; set; }
        public byte StatusType { get; set; }
        public byte SubStatusType { get; set; }
        public int DeviceId { get; set; }
        public string DeviceName { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime LastUpdated { get; set; }
    }
}
