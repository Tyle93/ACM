using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CurrencyConversion
    {
        public CurrencyConversion()
        {
            CurrencyConversionItems = new HashSet<CurrencyConversionItem>();
        }

        public Guid CurrencyConversionId { get; set; }
        public int StoreId { get; set; }
        public string ConversionBaseName { get; set; } = null!;
        public string ConversionBaseShortName { get; set; } = null!;

        public virtual ICollection<CurrencyConversionItem> CurrencyConversionItems { get; set; }
    }
}
