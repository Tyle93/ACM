using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class CurrencyConversionItem
    {
        public Guid CurrencyConversionItemId { get; set; }
        public Guid CurrencyConversionId { get; set; }
        public int ConversionIndex { get; set; }
        public string ConversionName { get; set; } = null!;
        public string ConversionShortName { get; set; } = null!;
        public decimal ConversionRate { get; set; }

        public virtual CurrencyConversion CurrencyConversion { get; set; } = null!;
    }
}
