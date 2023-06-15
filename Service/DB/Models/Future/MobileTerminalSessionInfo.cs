using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MobileTerminalSessionInfo
    {
        public Guid MobileTerminalSessionInfoId { get; set; }
        public byte[] SessionId { get; set; } = null!;
        public byte[] BinaryData { get; set; } = null!;
        public byte[] BinaryData2 { get; set; } = null!;
        public DateTime InsertDateTime { get; set; }
        public int BinaryDataLength { get; set; }
        public int BinaryData2Length { get; set; }
        public Guid MobileTerminalId { get; set; }
        public byte[] SessionKey { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public bool IsFinalized { get; set; }

        public virtual MobileTerminal MobileTerminal { get; set; } = null!;
    }
}
