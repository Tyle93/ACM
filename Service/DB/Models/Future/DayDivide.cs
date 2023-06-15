using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DayDivide
    {
        public int DayDivideId { get; set; }
        public DateTime? DayDivideDateTime { get; set; }
        public DateTime? DayDivideDateTimeNxt { get; set; }
    }
}
