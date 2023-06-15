using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CustomerCharge
    {
        public Guid CustomerChargeId { get; set; }
        public int StoreId { get; set; }
        public int CustomerNumber { get; set; }
        public DateTime ChargeDate { get; set; }
        public short ChargeType { get; set; }
        public string? Description { get; set; }
        public byte TerminalNumber { get; set; }
        public short SupervisorId { get; set; }
        public int CheckNumber { get; set; }
        public int Amount { get; set; }
        public int SubTotal { get; set; }
        public int TaxTotal { get; set; }
        public int Gratuity { get; set; }
        public int TogoSurcharge { get; set; }
        public int AmoutRounded { get; set; }
        public Guid SaleId { get; set; }
        public Guid RegionId { get; set; }
    }
}
