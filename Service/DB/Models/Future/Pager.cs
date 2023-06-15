using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Pager
    {
        public Pager()
        {
            PagerEmployees = new HashSet<PagerEmployee>();
            PagerMessageQueues = new HashSet<PagerMessageQueue>();
        }

        public Guid PagerId { get; set; }
        public int PagerType { get; set; }
        public string PagerDescription { get; set; } = null!;
        public int PagerNumber { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<PagerEmployee> PagerEmployees { get; set; }
        public virtual ICollection<PagerMessageQueue> PagerMessageQueues { get; set; }
    }
}
