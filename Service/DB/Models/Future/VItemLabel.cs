using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VItemLabel
    {
        public string ItemDescription { get; set; } = null!;
        public string Upc { get; set; } = null!;
        public int DefaultPrice { get; set; }
    }
}
