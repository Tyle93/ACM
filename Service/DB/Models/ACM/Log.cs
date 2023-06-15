using System;
using System.Collections.Generic;

namespace ACM.ACM_Models
{
    public partial class Log
    {
        public string Id { get; set; } = null!;
        public string FposSaleId { get; set; } = null!;
        public string FposSaleItemId { get; set; } = null!;
        public string Rule { get; set; } = null!;
        public string RuleItem { get; set; } = null!;
        public long OriginalPrice { get; set; }
        public long AlteredPrice { get; set; }
        public string Operation { get; set; } = null!;
        public long OperationAmount { get; set; }
        public byte[] CreatedAt { get; set; } = null!;
    }
}
