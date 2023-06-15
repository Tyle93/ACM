using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Custom2dDataViewDailyVoidsByEmployee
    {
        public short Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Value { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
