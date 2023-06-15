using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Department
    {
        public Department()
        {
            DepartmentMobileExclusions = new HashSet<DepartmentMobileExclusion>();
            DepartmentSchedules = new HashSet<DepartmentSchedule>();
        }

        public Guid DepartmentId { get; set; }
        public Guid RegionId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? DepartmentDescription { get; set; }
        public string? GroupName { get; set; }
        public bool IsHash { get; set; }
        public byte PmsbucketNumber { get; set; }
        public bool IsUsedOnline { get; set; }
        public string? WebTitle { get; set; }
        public string? WebDescription { get; set; }
        public string? WebThumbPath { get; set; }
        public string? WebImagePath { get; set; }
        public bool IsDefault { get; set; }
        public int DisplayIndex { get; set; }
        public bool IsParent { get; set; }
        public Guid? ParentDepartmentId { get; set; }
        public int Vduid { get; set; }
        public bool AskId { get; set; }
        public int QuantityMultiplier { get; set; }
        public bool MobileAskId { get; set; }
        public bool IsMobile { get; set; }
        public Guid? MobileMessageId { get; set; }
        public string? OverrideAutoMenuButtonSettingsGraphic { get; set; }
        public bool IsRequired { get; set; }

        public virtual ICollection<DepartmentMobileExclusion> DepartmentMobileExclusions { get; set; }
        public virtual ICollection<DepartmentSchedule> DepartmentSchedules { get; set; }
    }
}
