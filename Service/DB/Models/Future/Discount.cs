using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Discount
    {
        public Discount()
        {
            DiscountTranslations = new HashSet<DiscountTranslation>();
        }

        public Guid DiscountId { get; set; }
        public Guid RegionId { get; set; }
        public int DiscountIndex { get; set; }
        public string DiscountName { get; set; } = null!;
        public short DiscountType { get; set; }
        public int PercentOff { get; set; }
        public int DollarsOff { get; set; }
        public int MaxAmount { get; set; }
        public bool EnterAmount { get; set; }
        public bool SubFrTax { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short Days { get; set; }
        public short Reason { get; set; }
        public short SecurityLevel { get; set; }
        public string? Text { get; set; }
        public int DollarsOffSale { get; set; }
        public bool IsExclusive { get; set; }
        public bool DisplayInOwnSection { get; set; }

        public virtual ICollection<DiscountTranslation> DiscountTranslations { get; set; }
    }
}
