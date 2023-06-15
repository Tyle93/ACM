using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PalertQueue
    {
        public Guid AlertQueueId { get; set; }
        public Guid AlertId { get; set; }
        public DateTime QueueDate { get; set; }
        public string Email { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public int RetryCount { get; set; }
        public bool IsSent { get; set; }
        public byte[]? Attachment { get; set; }
        public string? FileName { get; set; }
        public string? AltBodyText { get; set; }
        public string? AltBodyMimeType { get; set; }
    }
}
