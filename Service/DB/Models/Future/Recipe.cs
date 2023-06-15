using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Recipe
    {
        public Guid RecipeId { get; set; }
        public Guid RegionId { get; set; }
        public string RecipeName { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string Recipe1 { get; set; } = null!;
    }
}
