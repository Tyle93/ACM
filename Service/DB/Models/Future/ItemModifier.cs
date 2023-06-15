using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemModifier
    {
        public Guid ItemModifierId { get; set; }
        public Guid ItemId { get; set; }
        public int ModifierIndex { get; set; }
        public string ModifierName { get; set; } = null!;
        public bool IsSelected { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
