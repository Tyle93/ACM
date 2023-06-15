using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DeliveryDriver
    {
        public Guid DriverId { get; set; }
        public int StoreId { get; set; }
        public int EmpId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public byte InOutStatus { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
