using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemDay
    {
        public Guid ItemDayId { get; set; }
        public Guid ItemId { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime Date { get; set; }
    }
}
