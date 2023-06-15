using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class VContentLink
    {
        public Guid LinkId { get; set; }
        public Guid PlayListId { get; set; }
        public Guid PlaylistItemId { get; set; }
        public int MediaDisplayTime { get; set; }
        public int TransitionNumber { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int ItemOrder { get; set; }
        public bool IsEnabled { get; set; }
        public int MediaType { get; set; }
        public Guid LinkPlayListItemId { get; set; }
        public string ItemName { get; set; } = null!;
    }
}
