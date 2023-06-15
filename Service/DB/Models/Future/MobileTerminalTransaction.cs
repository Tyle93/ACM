using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MobileTerminalTransaction
    {
        public Guid MobileTerminalTransactionId { get; set; }
        public Guid TransactionId { get; set; }
        public byte[] SessionId { get; set; } = null!;
        public byte State { get; set; }
        public byte[] Response { get; set; } = null!;
        public int TerminalNumber { get; set; }
    }
}
