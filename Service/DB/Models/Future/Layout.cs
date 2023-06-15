using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Layout
    {
        public Layout()
        {
            LayoutGraphics = new HashSet<LayoutGraphic>();
            LayoutRooms = new HashSet<LayoutRoom>();
            LayoutSections = new HashSet<LayoutSection>();
            LayoutTables = new HashSet<LayoutTable>();
            LayoutTexts = new HashSet<LayoutText>();
        }

        public Guid LayoutId { get; set; }
        public int StoreId { get; set; }
        public int TableCount { get; set; }
        public short ColorStyle { get; set; }
        public bool NeedCleaned { get; set; }
        public short State1ColorIndex { get; set; }
        public short State2ColorIndex { get; set; }
        public short State3ColorIndex { get; set; }
        public short State4ColorIndex { get; set; }
        public short State5ColorIndex { get; set; }
        public short State6ColorIndex { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<LayoutGraphic> LayoutGraphics { get; set; }
        public virtual ICollection<LayoutRoom> LayoutRooms { get; set; }
        public virtual ICollection<LayoutSection> LayoutSections { get; set; }
        public virtual ICollection<LayoutTable> LayoutTables { get; set; }
        public virtual ICollection<LayoutText> LayoutTexts { get; set; }
    }
}
