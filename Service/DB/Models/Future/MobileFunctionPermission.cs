using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class MobileFunctionPermission
    {
        public Guid PermissionId { get; set; }
        public string FunctionName { get; set; } = null!;
        public bool? AskForSupervisorId { get; set; }
        public int? MinimumSecurityLevel { get; set; }
        public int? TerminalNumber { get; set; }
    }
}
