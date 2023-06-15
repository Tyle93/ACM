using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class IngredientInventory
    {
        public Guid IngredientInventoryId { get; set; }
        public int IngredientInventoryIndex { get; set; }
        public Guid IngredientId { get; set; }
        public string Location { get; set; } = null!;
        public int UnitCount { get; set; }
        public int PackageCount { get; set; }
        public int CaseCount { get; set; }

        public virtual Ingredient Ingredient { get; set; } = null!;
    }
}
