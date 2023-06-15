using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class InvoiceConfig
    {
        public InvoiceConfig()
        {
            InvoiceConfigObjects = new HashSet<InvoiceConfigObject>();
        }

        public Guid InvoiceConfigId { get; set; }
        public int StoreId { get; set; }
        public int StartInvoiceNumber { get; set; }
        public int DaysGrace { get; set; }
        public int MinimumPaymentPercent { get; set; }
        public int PageWidth { get; set; }
        public int PageHeight { get; set; }
        public int MaxObjects { get; set; }
        public bool IncludeZeroBalance { get; set; }
        public bool IncludePositiveBalance { get; set; }
        public bool ShowCheckDetail { get; set; }
        public bool ShowGroupTotals { get; set; }

        public virtual ICollection<InvoiceConfigObject> InvoiceConfigObjects { get; set; }
    }
}
