using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SaleCoupons = new HashSet<SaleCoupon>();
            SaleCreditCards = new HashSet<SaleCreditCard>();
            SaleDiscounts = new HashSet<SaleDiscount>();
            SaleGiftSolds = new HashSet<SaleGiftSold>();
            SaleGiftUseds = new HashSet<SaleGiftUsed>();
            SaleItems = new HashSet<SaleItem>();
            SaleLoyalties = new HashSet<SaleLoyalty>();
            SaleMedia = new HashSet<SaleMedium>();
            SalePms = new HashSet<SalePm>();
            SaleShares = new HashSet<SaleShare>();
            SaleTaxes = new HashSet<SaleTax>();
            SaleTenders = new HashSet<SaleTender>();
        }

        public Guid SaleId { get; set; }
        public int StoreId { get; set; }
        public int CheckNumber { get; set; }
        public bool IsSuspend { get; set; }
        public byte WasReopened { get; set; }
        public byte IsTrainMode { get; set; }
        public byte IsNegativeSale { get; set; }
        public byte IsCancelled { get; set; }
        public byte IsEncrypted { get; set; }
        public byte WasRefunded { get; set; }
        public byte CheckWasPrinted { get; set; }
        public byte DescriptionEdited { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short TerminalNumber { get; set; }
        public byte CheckType { get; set; }
        public short CustomerCount { get; set; }
        public short TableIndex { get; set; }
        public int StartedEmpId { get; set; }
        public int TransferEmpId { get; set; }
        public int SettledEmpId { get; set; }
        public string? CheckDescription { get; set; }
        public short ItemCount { get; set; }
        public byte CheckStatus { get; set; }
        public byte IsRetrieved { get; set; }
        public int SubTotal { get; set; }
        public int GratuityPercent { get; set; }
        public int GratuityAmount { get; set; }
        public int Total { get; set; }
        public int SuspendNumber { get; set; }
        public byte ForgiveTaxMask { get; set; }
        public byte CustomerEntered { get; set; }
        public byte FtaxToggle { get; set; }
        public byte TogoFtax { get; set; }
        public int OvertAmount { get; set; }
        public byte RecPrtOpts { get; set; }
        public int CustomerNumber { get; set; }
        public byte DrawerNumber { get; set; }
        public DateTime? PromisedDate { get; set; }
        public short DriverId { get; set; }
        public short OrderTakerEmpId { get; set; }
        public int SurchargeDollars { get; set; }
        public int OrderPrintTime { get; set; }
        public byte OvertMedia { get; set; }
        public int EmpTips { get; set; }
        public int HouseTips { get; set; }
        public byte ExpCourse { get; set; }
        public int CurrentEmpId { get; set; }
        public int DueRound { get; set; }
        public byte OrderType { get; set; }
        public short StartTerminalNumber { get; set; }
        public byte CurrentCourse { get; set; }
        public int OrigionalSubTotal { get; set; }
        public byte SplitNum { get; set; }
        public DateTime? AssignDriverDate { get; set; }
        public byte ZoneChargeIndex { get; set; }
        public int ZoneChargeAmount { get; set; }
        public byte TipCashier { get; set; }
        public int PreAuthAmt { get; set; }
        public byte NoSmartVat { get; set; }
        public byte GratuityDecimalPlaces { get; set; }
        public byte CustomerPriceLevel { get; set; }
        public byte SectionPriceLevel { get; set; }
        public byte SaleSection { get; set; }
        public byte LightState { get; set; }
        public byte SalePriceLevel { get; set; }
        public byte[]? PreCardNum { get; set; }
        public byte[]? PreExpirationDate { get; set; }
        public byte[]? PreTrack2 { get; set; }
        public byte[]? PreCardName { get; set; }
        public byte[]? PreAuthResponse { get; set; }
        public byte PreMedia { get; set; }
        public int CreditCardCount { get; set; }
        public int GiftSoldCount { get; set; }
        public int GiftUsedCount { get; set; }
        public int Pmscount { get; set; }
        public int ReOpenCheckNumber { get; set; }
        public byte NoSboutput { get; set; }
        public byte GratuityEdited { get; set; }
        public byte TenderCount { get; set; }
        public byte RevenueCenter { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? EmployeeName { get; set; }
        public string? DriverName { get; set; }
        public byte ExtChkStatus { get; set; }
        public byte OvertenderOption { get; set; }
        public byte OvertenderIsTip { get; set; }
        public short ShareCount { get; set; }
        public string? WebLastName { get; set; }
        public string? WebFirstName { get; set; }
        public byte WebMiddleInitial { get; set; }
        public string? WebPhone { get; set; }
        public string? WebAddress1 { get; set; }
        public string? WebAddress2 { get; set; }
        public string? WebCity { get; set; }
        public string? WebState { get; set; }
        public string? WebZip { get; set; }
        public string? WebEmail { get; set; }
        public string? WebComment { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CustomerDiscount { get; set; }
        public string? TabOutCode { get; set; }
        public bool TipsBeenChanged { get; set; }
        public bool IsCombined { get; set; }
        public int CombinedCheckNumber { get; set; }
        public int ZoneDriverAmount { get; set; }
        public bool PreIsE2eencryption { get; set; }
        public byte[]? PreEncryptedBlock { get; set; }
        public byte[]? PreEncryptionKey { get; set; }
        public int PreCardSource { get; set; }
        public int LanStatus { get; set; }
        public int WebOrderCustomerId { get; set; }
        public bool IsWebOrderComplete { get; set; }
        public byte WrkTaxFlags { get; set; }
        public byte OrigTaxFlags { get; set; }
        public bool Idprovided { get; set; }
        public byte[]? PreReferenceNumber { get; set; }
        public int LoyaltyLookupResult { get; set; }
        public int TicketNumber { get; set; }
        public int LevelUpOrderId { get; set; }
        public string? PaydiantTransactionRefId { get; set; }
        public string? PaydiantCheckoutToken { get; set; }
        public int PsubTotal { get; set; }
        public short SuspendNumberTerminal { get; set; }
        public int DataVersion { get; set; }
        public int ServiceChargeAmount { get; set; }
        public int ServiceChargePercent { get; set; }
        public byte ServiceChargeEdited { get; set; }
        public byte ServiceChargeDecimalPlaces { get; set; }
        public bool ZoneIsServiceCharge { get; set; }
        public byte[]? PreEncryptedRawSwipe { get; set; }
        public int PzeroRated { get; set; }
        public byte[]? PreVaultId { get; set; }
        public byte[]? PreReferenceData { get; set; }
        public byte[]? PreProcessData { get; set; }
        public byte[]? PreEmvapplicationLabel { get; set; }
        public byte[]? PreEmvaid { get; set; }
        public byte[]? PreEmvtvr { get; set; }
        public byte[]? PreEmviad { get; set; }
        public byte[]? PreEmvtsi { get; set; }
        public byte[]? PreEmvarc { get; set; }
        public byte[]? PreEmvcvm { get; set; }
        public byte[]? PreEmventryMethod { get; set; }
        public byte[]? PreZip { get; set; }
        public string LevelUpUuid { get; set; } = null!;
        public bool PreUsedToSettle { get; set; }

        public virtual ICollection<SaleCoupon> SaleCoupons { get; set; }
        public virtual ICollection<SaleCreditCard> SaleCreditCards { get; set; }
        public virtual ICollection<SaleDiscount> SaleDiscounts { get; set; }
        public virtual ICollection<SaleGiftSold> SaleGiftSolds { get; set; }
        public virtual ICollection<SaleGiftUsed> SaleGiftUseds { get; set; }
        public virtual ICollection<SaleItem> SaleItems { get; set; }
        public virtual ICollection<SaleLoyalty> SaleLoyalties { get; set; }
        public virtual ICollection<SaleMedium> SaleMedia { get; set; }
        public virtual ICollection<SalePm> SalePms { get; set; }
        public virtual ICollection<SaleShare> SaleShares { get; set; }
        public virtual ICollection<SaleTax> SaleTaxes { get; set; }
        public virtual ICollection<SaleTender> SaleTenders { get; set; }
    }
}
