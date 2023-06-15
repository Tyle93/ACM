using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class TaxTable
    {
        public Guid TaxTableId { get; set; }
        public Guid TaxId { get; set; }
        public int TaxTableIndex { get; set; }
        public int UpToAmount { get; set; }
        public int TaxAmount { get; set; }

        public virtual Tax Tax { get; set; } = null!;
    }
}
