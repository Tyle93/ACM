using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class DinePointDayDivide
    {
        public DateTime BusinessDate { get; set; }
        public int StoreId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
