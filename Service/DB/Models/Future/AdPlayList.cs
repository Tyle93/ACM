using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class AdPlayList
    {
        public Guid PlayListId { get; set; }
        public string PlayListName { get; set; } = null!;
        public bool? IsEnabled { get; set; }
        public string SyncFolderPath { get; set; } = null!;
        public bool? SyncByFileDate { get; set; }
        public bool IsSyncFolder { get; set; }
        public bool IsUpdated { get; set; }
        public int ImportTime { get; set; }
        public bool? ImportByName { get; set; }
    }
}
