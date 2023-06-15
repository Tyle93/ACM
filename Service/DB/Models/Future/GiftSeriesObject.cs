using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class GiftSeriesObject
    {
        public Guid GiftSeriesObjectId { get; set; }
        public Guid GiftSeriesId { get; set; }
        public int ObjectIndex { get; set; }
        public short ObjectType { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public string? Data { get; set; }
        public byte TextType { get; set; }
        public short TextJustification { get; set; }
        public string? FontName { get; set; }
        public short FontStyle { get; set; }
        public byte TextColor { get; set; }

        public virtual GiftSeries GiftSeries { get; set; } = null!;
    }
}
