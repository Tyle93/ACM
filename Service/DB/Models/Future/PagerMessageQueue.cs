using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class PagerMessageQueue
    {
        public Guid PagerMessageQueueId { get; set; }
        public Guid PagerId { get; set; }
        public string Message { get; set; } = null!;
        public int RetryCount { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Pager Pager { get; set; } = null!;
    }
}
