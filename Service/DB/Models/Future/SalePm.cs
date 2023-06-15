using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SalePm
    {
        public Guid SalePmsid { get; set; }
        public Guid SaleId { get; set; }
        public int Pmsindex { get; set; }
        public string? AccountNumber { get; set; }
        public int AuthAmount { get; set; }
        public int EmployeeTip { get; set; }
        public int HouseTip { get; set; }
        public int MediaIndex { get; set; }
        public string? GuestName { get; set; }
        public int Gratuity { get; set; }
        public int Discount { get; set; }
        public int Bucket1 { get; set; }
        public int Bucket2 { get; set; }
        public int Bucket3 { get; set; }
        public int Bucket4 { get; set; }

        public virtual Sale Sale { get; set; } = null!;
    }
}
