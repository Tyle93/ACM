using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemTranslation
    {
        public Guid ItemTranslationId { get; set; }
        public Guid ItemId { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Item Item { get; set; } = null!;
    }
}
