using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ReceiptFormat
    {
        public ReceiptFormat()
        {
            ReceiptFormatItems = new HashSet<ReceiptFormatItem>();
        }

        public Guid ReceiptFormatId { get; set; }
        public int StoreId { get; set; }
        public int TerminalNumber { get; set; }
        public int ReceiptType { get; set; }

        public virtual ICollection<ReceiptFormatItem> ReceiptFormatItems { get; set; }
    }
}
