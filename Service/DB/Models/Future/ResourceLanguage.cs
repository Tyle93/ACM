using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ResourceLanguage
    {
        public Guid ResourceLanguageId { get; set; }
        public int StoreId { get; set; }
        public int Language { get; set; }
        public int ResourceKey { get; set; }
        public string Value { get; set; } = null!;
    }
}
