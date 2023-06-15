using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Configuration
    {
        public Guid ConfigurationId { get; set; }
        public int StoreId { get; set; }
        public int TerminalNumber { get; set; }
        public string Section { get; set; } = null!;
        public string Parameter { get; set; } = null!;
        public int ParameterIndex { get; set; }
        public string Value { get; set; } = null!;
        public int ParameterIndex2 { get; set; }
        public int DataType { get; set; }
        public Guid? DeviceId { get; set; }
    }
}
