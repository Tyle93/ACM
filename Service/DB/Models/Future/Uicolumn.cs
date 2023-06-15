using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Uicolumn
    {
        public Guid UicolumnId { get; set; }
        public Guid Uiid { get; set; }
        /// <summary>
        /// A Database Column Name (Must match table)
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Display Order Index
        /// </summary>
        public int Position { get; set; }
        public int State { get; set; }

        public virtual Ui Ui { get; set; } = null!;
    }
}
