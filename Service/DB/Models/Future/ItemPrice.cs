using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class ItemPrice
    {
        public Guid ItemPriceId { get; set; }
        public Guid ItemId { get; set; }
        public int ScheduleIndex { get; set; }
        public int DefaultPrice { get; set; }
        public int Level1Price { get; set; }
        public int Level2Price { get; set; }
        public int Level3Price { get; set; }
        public int Level4Price { get; set; }
        public int Level5Price { get; set; }
        public int Level6Price { get; set; }
        public int Level7Price { get; set; }
        public int Level8Price { get; set; }
        public int Level9Price { get; set; }
        public int Level10Price { get; set; }
        public int Level11Price { get; set; }
        public int Level12Price { get; set; }
        public int Level13Price { get; set; }
        public int Level14Price { get; set; }
        public int Level15Price { get; set; }
        public int Level16Price { get; set; }
        public int Level17Price { get; set; }
        public int Level18Price { get; set; }
        public int Level19Price { get; set; }
        public int Level20Price { get; set; }
        public int Level21Price { get; set; }
        public int Level22Price { get; set; }
        public int Level23Price { get; set; }
        public int Level24Price { get; set; }
        public int Level25Price { get; set; }
        public int Level26Price { get; set; }
        public int Level27Price { get; set; }
        public int Level28Price { get; set; }
        public int Level29Price { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
