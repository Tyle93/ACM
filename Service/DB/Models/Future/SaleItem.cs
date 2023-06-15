using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class SaleItem
    {
        public SaleItem()
        {
            SaleItemCoupons = new HashSet<SaleItemCoupon>();
            SaleItemDiscounts = new HashSet<SaleItemDiscount>();
        }

        public Guid SaleItemId { get; set; }
        public Guid SaleId { get; set; }
        public int ItemIndex { get; set; }
        public string? ItemName { get; set; }
        public string? ReceiptDescription { get; set; }
        public string? Department { get; set; }
        public int BasePrice { get; set; }
        public short Flags { get; set; }
        public byte WrkTaxFlags { get; set; }
        public byte OrigTaxFlags { get; set; }
        public byte[]? DiscountFlags { get; set; }
        public byte[]? DiscountApplied { get; set; }
        public int PrintOptions { get; set; }
        public int WasPrinted { get; set; }
        public int BergPlu { get; set; }
        public int RemotePrns { get; set; }
        public short EmpId { get; set; }
        public byte OrderPriority { get; set; }
        public byte VoidReason { get; set; }
        public byte[]? CouponApplied { get; set; }
        public bool TogoSurcharge { get; set; }
        public bool IsModifier { get; set; }
        public byte OldSplitLevel { get; set; }
        public short VoidEmpId { get; set; }
        public DateTime? VoidDate { get; set; }
        public byte SplitQuantity { get; set; }
        public bool IsNotTippable { get; set; }
        public short CourseFireDelay { get; set; }
        public int CourseFireDateOffset { get; set; }
        public bool JustRerung { get; set; }
        public int CustomerNumber { get; set; }
        public string? ModifierGroupItem { get; set; }
        public byte ModifierParent { get; set; }
        public byte SeriesIndex { get; set; }
        public string? GiftCardNum { get; set; }
        public byte GiftCardPrintOption { get; set; }
        public byte CourseNumber { get; set; }
        public bool IsPromoItem { get; set; }
        public bool FollowsParent { get; set; }
        public bool AreadySplit { get; set; }
        public bool IsOpenPriced { get; set; }
        public int SendTime { get; set; }
        public bool IsRandomWeight { get; set; }
        public DateTime? TimedStartDate { get; set; }
        public byte TimedIncrement { get; set; }
        public int TimedMinimumPrice { get; set; }
        public DateTime? TimedEndDate { get; set; }
        public byte Vducolor { get; set; }
        public string? ShortDescription { get; set; }
        public byte OrderType { get; set; }
        public int TripleHigh { get; set; }
        public int QuadHigh { get; set; }
        public int ItemWeight { get; set; }
        public byte PriceLevel { get; set; }
        public bool IsReload { get; set; }
        public string? BankAuthCode { get; set; }
        public DateTime? SoldDate { get; set; }
        public int SurchargeDollars { get; set; }
        public int GrossPrice { get; set; }
        public int Vatamt { get; set; }
        public short Quantity { get; set; }
        public short LastRoundQuantity { get; set; }
        public short ThisRoundQuantity { get; set; }
        public int ActualPrice { get; set; }
        public int TaxablePrice { get; set; }
        public short ParentIndex { get; set; }
        public string? BankRefNumber { get; set; }
        public bool IsIngredientProcessed { get; set; }
        public byte[]? SplitLevel { get; set; }
        public string? BankAuthorizationCode { get; set; }
        public int TimedSplitCount { get; set; }
        public int TimedSplitIndex { get; set; }
        public byte[]? HasRemoteDescription { get; set; }
        public bool ItemWorkCenter { get; set; }
        public bool IsNotGratable { get; set; }
        public int TotalTax { get; set; }
        public DateTime? AddDate { get; set; }
        public bool ItemWasZeroQty { get; set; }
        public int MobileUserId { get; set; }
        public string? Upc { get; set; }
        public byte ItemWorkCenterValue { get; set; }
        public int VatItemActualAmount { get; set; }
        public int PbasePrice { get; set; }
        public int Flags2 { get; set; }
        public Guid SplitParentId { get; set; }

        public virtual Sale Sale { get; set; } = null!;
        public virtual ICollection<SaleItemCoupon> SaleItemCoupons { get; set; }
        public virtual ICollection<SaleItemDiscount> SaleItemDiscounts { get; set; }
    }
}
