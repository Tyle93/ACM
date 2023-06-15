using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TaxTranslation
    {
        public Guid TaxTranslationId { get; set; }
        public Guid TaxId { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Tax Tax { get; set; } = null!;
    }
}
