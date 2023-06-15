using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VPlayListItem
    {
        public Guid PlaylistItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string MediaType { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public bool IsEnabled { get; set; }
        public bool LoadContent { get; set; }
    }
}
