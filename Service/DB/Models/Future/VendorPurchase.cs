using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VendorPurchase
    {
        public Guid VendorPurchaseId { get; set; }
        public int StoreId { get; set; }
        public Guid? VendorId { get; set; }
        public string ItemName { get; set; } = null!;
        public int ItemCount { get; set; }
        public DateTime ReceivedDate { get; set; }
        public bool IsRemoval { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual Vendor? Vendor { get; set; }
    }
}
