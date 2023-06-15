using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DashBoardSetting
    {
        public Guid DashBoardSettingsId { get; set; }
        public string DashFieldName { get; set; } = null!;
        public string DashFieldValue { get; set; } = null!;
        public int IsActive { get; set; }
        public DateTime? CreateStamp { get; set; }
        public DateTime? UpdateStamp { get; set; }
        public Guid DashItemPanelId { get; set; }
        public int StoreId { get; set; }
    }
}
