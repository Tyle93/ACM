using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MediaTranslation
    {
        public Guid MediaTranslationId { get; set; }
        public Guid MediaId { get; set; }
        public int Language { get; set; }
        public string Value { get; set; } = null!;

        public virtual Medium Media { get; set; } = null!;
    }
}
