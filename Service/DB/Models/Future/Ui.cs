using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Ui
    {
        public Ui()
        {
            Uicolumns = new HashSet<Uicolumn>();
        }

        public Guid Uiid { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Uicolumn> Uicolumns { get; set; }
    }
}
