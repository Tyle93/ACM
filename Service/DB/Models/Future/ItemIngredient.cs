using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemIngredient
    {
        public Guid ItemIngredientId { get; set; }
        public Guid ItemId { get; set; }
        public string IngredientName { get; set; } = null!;
        public int IngredientIndex { get; set; }
        public int UnitCount { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
