using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class GiftSeries
    {
        public GiftSeries()
        {
            GiftSeriesAvailabilities = new HashSet<GiftSeriesAvailability>();
            GiftSeriesObjects = new HashSet<GiftSeriesObject>();
        }

        public Guid GiftSeriesId { get; set; }
        public Guid RegionId { get; set; }
        public short SeriesIndex { get; set; }
        public string SeriesName { get; set; } = null!;
        public bool AutoNumber { get; set; }
        public long StartNumber { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
        public bool RedeemExpired { get; set; }
        public bool AllowPartial { get; set; }
        public byte PartialType { get; set; }
        public byte ExpirationType { get; set; }
        public short ExpiresAfterType { get; set; }
        public byte ExpiresAfterCount { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool IsMagneticCard { get; set; }
        public int PageWidth { get; set; }
        public int PageHeight { get; set; }
        public int TopMargin { get; set; }
        public int BottomMargin { get; set; }
        public int LeftMargin { get; set; }
        public int RightMargin { get; set; }
        public int ColumnMargin { get; set; }
        public int RowMargin { get; set; }
        public byte ColumnCount { get; set; }
        public byte RowCount { get; set; }
        public byte ReissueType { get; set; }
        public int CashRefundUpTo { get; set; }
        public byte AvailabliityType { get; set; }
        public byte[]? DiscountFlags { get; set; }
        public int ObjectCount { get; set; }
        public int StoreId { get; set; }
        public short ExpirationValue { get; set; }
        public byte ExpirationInterval { get; set; }
        public bool SeriesCannotBeSold { get; set; }
        public bool IsDonation { get; set; }

        public virtual ICollection<GiftSeriesAvailability> GiftSeriesAvailabilities { get; set; }
        public virtual ICollection<GiftSeriesObject> GiftSeriesObjects { get; set; }
    }
}
