using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ConfigurationSecure
    {
        public Guid ConfigurationSecureId { get; set; }
        public int StoreId { get; set; }
        public int TerminalNumber { get; set; }
        public string Section { get; set; } = null!;
        public string Parameter { get; set; } = null!;
        public int ParameterIndex { get; set; }
        public byte[] Value { get; set; } = null!;
        public int ParameterIndex2 { get; set; }
        public int DataType { get; set; }
        public Guid? DeviceId { get; set; }
    }
}
