using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Tax
    {
        public Tax()
        {
            TaxSchedules = new HashSet<TaxSchedule>();
            TaxTables = new HashSet<TaxTable>();
            TaxTranslations = new HashSet<TaxTranslation>();
        }

        public Guid TaxId { get; set; }
        public int StoreId { get; set; }
        public short TaxIndex { get; set; }
        public string TaxName { get; set; } = null!;
        public short TaxType { get; set; }
        public bool IsVat { get; set; }
        public bool AddOddPennies { get; set; }
        public int NoTaxUnder { get; set; }
        public short CalculationType { get; set; }
        public int TaxPercent { get; set; }
        public short RoundingType { get; set; }
        public short LastUpToIndex { get; set; }
        public int ScheduledDays { get; set; }
        public bool DoNotIncludeInDisplayedTotal { get; set; }
        public bool IncludeInAlternateDisplayTotal { get; set; }
        public bool UseItemPriceForAlternateTotal { get; set; }
        public bool ForgiveAlternateTotalTaxOnSmartVat { get; set; }
        public bool UseFloridaCalculation { get; set; }

        public virtual ICollection<TaxSchedule> TaxSchedules { get; set; }
        public virtual ICollection<TaxTable> TaxTables { get; set; }
        public virtual ICollection<TaxTranslation> TaxTranslations { get; set; }
    }
}
