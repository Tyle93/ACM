using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MobileTerminalTransfer
    {
        public Guid MobileTerminalTransferId { get; set; }
        public DateTime CreateDate { get; set; }
        public int TransferType { get; set; }
        public int Destination { get; set; }
        public int ToStoreId { get; set; }
        public int FromStoreId { get; set; }
        public int ToTerminalNumber { get; set; }
        public int FromTerminalNumber { get; set; }
        public string? Data { get; set; }
        public int DbtableNumber { get; set; }
        public Guid DbrecordId { get; set; }
        public bool ProcessOnServer { get; set; }
        public int RetryCount { get; set; }
    }
}
