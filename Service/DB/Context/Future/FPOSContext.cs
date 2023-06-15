using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ACM.Models;

namespace ACM.Context
{
    public partial class FPOSContext : DbContext
    {
        static bool isCreated = false;
        public FPOSContext()
        {
            
        }

        public FPOSContext(DbContextOptions<FPOSContext> options)
            : base(options)
        {
        }

        public string? GetConnectionString()
        {
            return Database.GetConnectionString();
        }

        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<ActivityDetail> ActivityDetails { get; set; } = null!;
        public virtual DbSet<AdDisplay> AdDisplays { get; set; } = null!;
        public virtual DbSet<AdDisplaySchedule> AdDisplaySchedules { get; set; } = null!;
        public virtual DbSet<AdLinkContent> AdLinkContents { get; set; } = null!;
        public virtual DbSet<AdPlayList> AdPlayLists { get; set; } = null!;
        public virtual DbSet<AdPlayListItem> AdPlayListItems { get; set; } = null!;
        public virtual DbSet<AdScheduleGroup> AdScheduleGroups { get; set; } = null!;
        public virtual DbSet<AdScoreLayout> AdScoreLayouts { get; set; } = null!;
        public virtual DbSet<AdTemplateContentLink> AdTemplateContentLinks { get; set; } = null!;
        public virtual DbSet<Alert> Alerts { get; set; } = null!;
        public virtual DbSet<AlertEmail> AlertEmails { get; set; } = null!;
        public virtual DbSet<AlertSetting> AlertSettings { get; set; } = null!;
        public virtual DbSet<AveroId> AveroIds { get; set; } = null!;
        public virtual DbSet<BackupSetting> BackupSettings { get; set; } = null!;
        public virtual DbSet<BeverageCount> BeverageCounts { get; set; } = null!;
        public virtual DbSet<BeverageCountInfo> BeverageCountInfos { get; set; } = null!;
        public virtual DbSet<BeverageCountItem> BeverageCountItems { get; set; } = null!;
        public virtual DbSet<Break> Breaks { get; set; } = null!;
        public virtual DbSet<BreakJob> BreakJobs { get; set; } = null!;
        public virtual DbSet<BusyIndicatorSchedule> BusyIndicatorSchedules { get; set; } = null!;
        public virtual DbSet<Button> Buttons { get; set; } = null!;
        public virtual DbSet<Cashier> Cashiers { get; set; } = null!;
        public virtual DbSet<CheckNumber> CheckNumbers { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<ConfigurationDevice> ConfigurationDevices { get; set; } = null!;
        public virtual DbSet<ConfigurationSecure> ConfigurationSecures { get; set; } = null!;
        public virtual DbSet<CorporateMessage> CorporateMessages { get; set; } = null!;
        public virtual DbSet<ACM.Models.Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<CouponItem> CouponItems { get; set; } = null!;
        public virtual DbSet<CouponTranslation> CouponTranslations { get; set; } = null!;
        public virtual DbSet<CreditBatch> CreditBatches { get; set; } = null!;
        public virtual DbSet<CurrencyConversion> CurrencyConversions { get; set; } = null!;
        public virtual DbSet<CurrencyConversionItem> CurrencyConversionItems { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewBottom10Department> Custom2dDataViewBottom10Departments { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewBottom10DepartmentsPrice> Custom2dDataViewBottom10DepartmentsPrices { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewBottom10Item> Custom2dDataViewBottom10Items { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewBottom10ItemsPrice> Custom2dDataViewBottom10ItemsPrices { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyCheckCount> Custom2dDataViewDailyCheckCounts { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyDepartmentSale> Custom2dDataViewDailyDepartmentSales { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyGuestCount> Custom2dDataViewDailyGuestCounts { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemPercentage> Custom2dDataViewDailyItemPercentages { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSale> Custom2dDataViewDailyItemSales { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSalesFriday> Custom2dDataViewDailyItemSalesFridays { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSalesMonday> Custom2dDataViewDailyItemSalesMondays { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSalesSaturday> Custom2dDataViewDailyItemSalesSaturdays { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSalesSunday> Custom2dDataViewDailyItemSalesSundays { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSalesThursday> Custom2dDataViewDailyItemSalesThursdays { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSalesTuesday> Custom2dDataViewDailyItemSalesTuesdays { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemSalesWednesday> Custom2dDataViewDailyItemSalesWednesdays { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyItemVoidsByEmployee> Custom2dDataViewDailyItemVoidsByEmployees { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyVoid> Custom2dDataViewDailyVoids { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyVoidsByEmployee> Custom2dDataViewDailyVoidsByEmployees { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewDailyVoidsByEmployeeSum> Custom2dDataViewDailyVoidsByEmployeeSums { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewOpenCheck> Custom2dDataViewOpenChecks { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewServingPeriodSale> Custom2dDataViewServingPeriodSales { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewTop10Department> Custom2dDataViewTop10Departments { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewTop10DepartmentsPrice> Custom2dDataViewTop10DepartmentsPrices { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewTop10Item> Custom2dDataViewTop10Items { get; set; } = null!;
        public virtual DbSet<Custom2dDataViewTop10ItemsPrice> Custom2dDataViewTop10ItemsPrices { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerCard> CustomerCards { get; set; } = null!;
        public virtual DbSet<CustomerCharge> CustomerCharges { get; set; } = null!;
        public virtual DbSet<CustomerLastOrder> CustomerLastOrders { get; set; } = null!;
        public virtual DbSet<CustomerNumber> CustomerNumbers { get; set; } = null!;
        public virtual DbSet<CustomerPlan> CustomerPlans { get; set; } = null!;
        public virtual DbSet<DashBoardItem> DashBoardItems { get; set; } = null!;
        public virtual DbSet<DashBoardSetting> DashBoardSettings { get; set; } = null!;
        public virtual DbSet<DataGroup> DataGroups { get; set; } = null!;
        public virtual DbSet<DataGroupStore> DataGroupStores { get; set; } = null!;
        public virtual DbSet<DataTypeReference> DataTypeReferences { get; set; } = null!;
        public virtual DbSet<DayDivide> DayDivides { get; set; } = null!;
        public virtual DbSet<DbaIndexDefragExclusion> DbaIndexDefragExclusions { get; set; } = null!;
        public virtual DbSet<DbaIndexDefragLog> DbaIndexDefragLogs { get; set; } = null!;
        public virtual DbSet<DbaIndexDefragStatus> DbaIndexDefragStatuses { get; set; } = null!;
        public virtual DbSet<Dbfile> Dbfiles { get; set; } = null!;
        public virtual DbSet<DeliveryDriver> DeliveryDrivers { get; set; } = null!;
        public virtual DbSet<DeliveryZone> DeliveryZones { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentMobileExclusion> DepartmentMobileExclusions { get; set; } = null!;
        public virtual DbSet<DepartmentRank> DepartmentRanks { get; set; } = null!;
        public virtual DbSet<DepartmentSchedule> DepartmentSchedules { get; set; } = null!;
        public virtual DbSet<DinePointConfig> DinePointConfigs { get; set; } = null!;
        public virtual DbSet<DinePointDayDivide> DinePointDayDivides { get; set; } = null!;
        public virtual DbSet<DinePointJobCode> DinePointJobCodes { get; set; } = null!;
        public virtual DbSet<DinePointOrderType> DinePointOrderTypes { get; set; } = null!;
        public virtual DbSet<DinePointRevenueCenter> DinePointRevenueCenters { get; set; } = null!;
        public virtual DbSet<DinePointServingPeriod> DinePointServingPeriods { get; set; } = null!;
        public virtual DbSet<DirtyTable> DirtyTables { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<DiscountTranslation> DiscountTranslations { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeAvailability> EmployeeAvailabilities { get; set; } = null!;
        public virtual DbSet<EmployeeAvailabilityRange> EmployeeAvailabilityRanges { get; set; } = null!;
        public virtual DbSet<EmployeeDrawer> EmployeeDrawers { get; set; } = null!;
        public virtual DbSet<EmployeeHintShown> EmployeeHintShowns { get; set; } = null!;
        public virtual DbSet<EmployeeRate> EmployeeRates { get; set; } = null!;
        public virtual DbSet<EmployeeTip> EmployeeTips { get; set; } = null!;
        public virtual DbSet<Enterprise> Enterprises { get; set; } = null!;
        public virtual DbSet<EnterpriseEmployee> EnterpriseEmployees { get; set; } = null!;
        public virtual DbSet<EnterpriseSort> EnterpriseSorts { get; set; } = null!;
        public virtual DbSet<EnterpriseSyncExclude> EnterpriseSyncExcludes { get; set; } = null!;
        public virtual DbSet<FollowMe> FollowMes { get; set; } = null!;
        public virtual DbSet<Gift> Gifts { get; set; } = null!;
        public virtual DbSet<GiftBackup> GiftBackups { get; set; } = null!;
        public virtual DbSet<GiftSeries> GiftSeries { get; set; } = null!;
        public virtual DbSet<GiftSeriesAvailability> GiftSeriesAvailabilities { get; set; } = null!;
        public virtual DbSet<GiftSeriesObject> GiftSeriesObjects { get; set; } = null!;
        public virtual DbSet<GiftUsed> GiftUseds { get; set; } = null!;
        public virtual DbSet<GlobalCashier> GlobalCashiers { get; set; } = null!;
        public virtual DbSet<GrandTotal> GrandTotals { get; set; } = null!;
        public virtual DbSet<Graphic> Graphics { get; set; } = null!;
        public virtual DbSet<Help> Helps { get; set; } = null!;
        public virtual DbSet<Ingredient> Ingredients { get; set; } = null!;
        public virtual DbSet<IngredientInventory> IngredientInventories { get; set; } = null!;
        public virtual DbSet<InternetCreditBatch> InternetCreditBatches { get; set; } = null!;
        public virtual DbSet<InternetCreditBatchArchive> InternetCreditBatchArchives { get; set; } = null!;
        public virtual DbSet<InternetCreditBatchInfo> InternetCreditBatchInfos { get; set; } = null!;
        public virtual DbSet<InvoiceConfig> InvoiceConfigs { get; set; } = null!;
        public virtual DbSet<InvoiceConfigObject> InvoiceConfigObjects { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemDay> ItemDays { get; set; } = null!;
        public virtual DbSet<ItemIngredient> ItemIngredients { get; set; } = null!;
        public virtual DbSet<ItemMobileExclusion> ItemMobileExclusions { get; set; } = null!;
        public virtual DbSet<ItemModifier> ItemModifiers { get; set; } = null!;
        public virtual DbSet<ItemPrice> ItemPrices { get; set; } = null!;
        public virtual DbSet<ItemPrinter> ItemPrinters { get; set; } = null!;
        public virtual DbSet<ItemRank> ItemRanks { get; set; } = null!;
        public virtual DbSet<ItemSize> ItemSizes { get; set; } = null!;
        public virtual DbSet<ItemSold> ItemSolds { get; set; } = null!;
        public virtual DbSet<ItemTranslation> ItemTranslations { get; set; } = null!;
        public virtual DbSet<Layout> Layouts { get; set; } = null!;
        public virtual DbSet<LayoutGraphic> LayoutGraphics { get; set; } = null!;
        public virtual DbSet<LayoutRoom> LayoutRooms { get; set; } = null!;
        public virtual DbSet<LayoutSection> LayoutSections { get; set; } = null!;
        public virtual DbSet<LayoutTable> LayoutTables { get; set; } = null!;
        public virtual DbSet<LayoutText> LayoutTexts { get; set; } = null!;
        public virtual DbSet<LocalSuspend> LocalSuspends { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LogConfig> LogConfigs { get; set; } = null!;
        public virtual DbSet<MediaTranslation> MediaTranslations { get; set; } = null!;
        public virtual DbSet<Medium> Media { get; set; } = null!;
        public virtual DbSet<MenuHomePageLink> MenuHomePageLinks { get; set; } = null!;
        public virtual DbSet<MenuPage> MenuPages { get; set; } = null!;
        public virtual DbSet<MenuPageGroup> MenuPageGroups { get; set; } = null!;
        public virtual DbSet<MenuPageItem> MenuPageItems { get; set; } = null!;
        public virtual DbSet<MenuPageLink> MenuPageLinks { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MessageEmployee> MessageEmployees { get; set; } = null!;
        public virtual DbSet<MobileFunctionPermission> MobileFunctionPermissions { get; set; } = null!;
        public virtual DbSet<MobileMessage> MobileMessages { get; set; } = null!;
        public virtual DbSet<MobileTerminal> MobileTerminals { get; set; } = null!;
        public virtual DbSet<MobileTerminalSessionInfo> MobileTerminalSessionInfos { get; set; } = null!;
        public virtual DbSet<MobileTerminalTransaction> MobileTerminalTransactions { get; set; } = null!;
        public virtual DbSet<MobileTerminalTransfer> MobileTerminalTransfers { get; set; } = null!;
        public virtual DbSet<OfflineLoyaltyQueue> OfflineLoyaltyQueues { get; set; } = null!;
        public virtual DbSet<OrderType> OrderTypes { get; set; } = null!;
        public virtual DbSet<Pager> Pagers { get; set; } = null!;
        public virtual DbSet<PagerEmployee> PagerEmployees { get; set; } = null!;
        public virtual DbSet<PagerMessageQueue> PagerMessageQueues { get; set; } = null!;
        public virtual DbSet<Palert> Palerts { get; set; } = null!;
        public virtual DbSet<PalertQueue> PalertQueues { get; set; } = null!;
        public virtual DbSet<PalertSetting> PalertSettings { get; set; } = null!;
        public virtual DbSet<PalertTo> PalertTos { get; set; } = null!;
        public virtual DbSet<Paydiant> Paydiants { get; set; } = null!;
        public virtual DbSet<PendingSale> PendingSales { get; set; } = null!;
        public virtual DbSet<Posday> Posdays { get; set; } = null!;
        public virtual DbSet<Posshift> Posshifts { get; set; } = null!;
        public virtual DbSet<PreAuth> PreAuths { get; set; } = null!;
        public virtual DbSet<PrepTime> PrepTimes { get; set; } = null!;
        public virtual DbSet<PriceLevel> PriceLevels { get; set; } = null!;
        public virtual DbSet<PriceSchedule> PriceSchedules { get; set; } = null!;
        public virtual DbSet<PrintJob> PrintJobs { get; set; } = null!;
        public virtual DbSet<PrintJobLine> PrintJobLines { get; set; } = null!;
        public virtual DbSet<Reason> Reasons { get; set; } = null!;
        public virtual DbSet<ReceiptFormat> ReceiptFormats { get; set; } = null!;
        public virtual DbSet<ReceiptFormatItem> ReceiptFormatItems { get; set; } = null!;
        public virtual DbSet<Recipe> Recipes { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<ResourceLanguage> ResourceLanguages { get; set; } = null!;
        public virtual DbSet<RewardPlan> RewardPlans { get; set; } = null!;
        public virtual DbSet<RewardPlanLevel> RewardPlanLevels { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SaleCoupon> SaleCoupons { get; set; } = null!;
        public virtual DbSet<SaleCreditCard> SaleCreditCards { get; set; } = null!;
        public virtual DbSet<SaleDiscount> SaleDiscounts { get; set; } = null!;
        public virtual DbSet<SaleGiftSold> SaleGiftSolds { get; set; } = null!;
        public virtual DbSet<SaleGiftUsed> SaleGiftUseds { get; set; } = null!;
        public virtual DbSet<SaleItem> SaleItems { get; set; } = null!;
        public virtual DbSet<SaleItemCoupon> SaleItemCoupons { get; set; } = null!;
        public virtual DbSet<SaleItemDiscount> SaleItemDiscounts { get; set; } = null!;
        public virtual DbSet<SaleLoyalty> SaleLoyalties { get; set; } = null!;
        public virtual DbSet<SaleMedium> SaleMedia { get; set; } = null!;
        public virtual DbSet<SalePm> SalePms { get; set; } = null!;
        public virtual DbSet<SaleShare> SaleShares { get; set; } = null!;
        public virtual DbSet<SaleTax> SaleTaxes { get; set; } = null!;
        public virtual DbSet<SaleTender> SaleTenders { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<ScheduleItem> ScheduleItems { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateMaintenance> ScheduledUpdateMaintenances { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateScheduleGroup> ScheduledUpdateScheduleGroups { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateScheduleGroupUpdate> ScheduledUpdateScheduleGroupUpdates { get; set; } = null!;
        public virtual DbSet<ScheduledUpdateScheduleGroupUpdateSettingChange> ScheduledUpdateScheduleGroupUpdateSettingChanges { get; set; } = null!;
        public virtual DbSet<Screen> Screens { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenu> ScreenAutoMenus { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuFilter> ScreenAutoMenuFilters { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuFilterButtonSetting> ScreenAutoMenuFilterButtonSettings { get; set; } = null!;
        public virtual DbSet<ScreenAutoMenuPagingButtonSetting> ScreenAutoMenuPagingButtonSettings { get; set; } = null!;
        public virtual DbSet<ScreenBitmap> ScreenBitmaps { get; set; } = null!;
        public virtual DbSet<ScreenButton> ScreenButtons { get; set; } = null!;
        public virtual DbSet<ScreenEdit> ScreenEdits { get; set; } = null!;
        public virtual DbSet<ScreenFrame> ScreenFrames { get; set; } = null!;
        public virtual DbSet<ScreenHelp> ScreenHelps { get; set; } = null!;
        public virtual DbSet<ScreenList> ScreenLists { get; set; } = null!;
        public virtual DbSet<ScreenText> ScreenTexts { get; set; } = null!;
        public virtual DbSet<SecurityCheck> SecurityChecks { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Shorthand> Shorthands { get; set; } = null!;
        public virtual DbSet<Signature> Signatures { get; set; } = null!;
        public virtual DbSet<Special> Specials { get; set; } = null!;
        public virtual DbSet<SpecialMonth> SpecialMonths { get; set; } = null!;
        public virtual DbSet<SpecialWeek> SpecialWeeks { get; set; } = null!;
        public virtual DbSet<StatusMessage> StatusMessages { get; set; } = null!;
        public virtual DbSet<Store> Stores { get; set; } = null!;
        public virtual DbSet<Sync> Syncs { get; set; } = null!;
        public virtual DbSet<SyncDatum> SyncData { get; set; } = null!;
        public virtual DbSet<TabbedOut> TabbedOuts { get; set; } = null!;
        public virtual DbSet<TabbedOutAlert> TabbedOutAlerts { get; set; } = null!;
        public virtual DbSet<ACM.Models.Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskItem> TaskItems { get; set; } = null!;
        public virtual DbSet<Tax> Taxes { get; set; } = null!;
        public virtual DbSet<TaxSchedule> TaxSchedules { get; set; } = null!;
        public virtual DbSet<TaxTable> TaxTables { get; set; } = null!;
        public virtual DbSet<TaxTranslation> TaxTranslations { get; set; } = null!;
        public virtual DbSet<TerminalConfiguration> TerminalConfigurations { get; set; } = null!;
        public virtual DbSet<TimeCard> TimeCards { get; set; } = null!;
        public virtual DbSet<TimedMenu> TimedMenus { get; set; } = null!;
        public virtual DbSet<TimedMenuDay> TimedMenuDays { get; set; } = null!;
        public virtual DbSet<TimedMenuJob> TimedMenuJobs { get; set; } = null!;
        public virtual DbSet<TipPool> TipPools { get; set; } = null!;
        public virtual DbSet<TipPoolContribution> TipPoolContributions { get; set; } = null!;
        public virtual DbSet<TipPoolDistribution> TipPoolDistributions { get; set; } = null!;
        public virtual DbSet<Total> Totals { get; set; } = null!;
        public virtual DbSet<Transfer> Transfers { get; set; } = null!;
        public virtual DbSet<Ui> Uis { get; set; } = null!;
        public virtual DbSet<Uicolumn> Uicolumns { get; set; } = null!;
        public virtual DbSet<VBottom10Dept> VBottom10Depts { get; set; } = null!;
        public virtual DbSet<VBottom10DeptsPrice> VBottom10DeptsPrices { get; set; } = null!;
        public virtual DbSet<VBottom10Item> VBottom10Items { get; set; } = null!;
        public virtual DbSet<VBottom10ItemsPrice> VBottom10ItemsPrices { get; set; } = null!;
        public virtual DbSet<VButtonMenu> VButtonMenus { get; set; } = null!;
        public virtual DbSet<VContentLink> VContentLinks { get; set; } = null!;
        public virtual DbSet<VCreditBatch> VCreditBatches { get; set; } = null!;
        public virtual DbSet<VDbfileHeader> VDbfileHeaders { get; set; } = null!;
        public virtual DbSet<VDisplaySchedule> VDisplaySchedules { get; set; } = null!;
        public virtual DbSet<VItemLabel> VItemLabels { get; set; } = null!;
        public virtual DbSet<VItemLink> VItemLinks { get; set; } = null!;
        public virtual DbSet<VMenuSchedule> VMenuSchedules { get; set; } = null!;
        public virtual DbSet<VPlayListItem> VPlayListItems { get; set; } = null!;
        public virtual DbSet<VSaleItemLink> VSaleItemLinks { get; set; } = null!;
        public virtual DbSet<VTop10Dept> VTop10Depts { get; set; } = null!;
        public virtual DbSet<VTop10DeptsPrice> VTop10DeptsPrices { get; set; } = null!;
        public virtual DbSet<VTop10Item> VTop10Items { get; set; } = null!;
        public virtual DbSet<VTop10ItemsPrice> VTop10ItemsPrices { get; set; } = null!;
        public virtual DbSet<Vdu> Vdus { get; set; } = null!;
        public virtual DbSet<Vduitem> Vduitems { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<VendorPurchase> VendorPurchases { get; set; } = null!;
        public virtual DbSet<ACM.Models.Version> Versions { get; set; } = null!;
        public virtual DbSet<VideoCapture> VideoCaptures { get; set; } = null!;
        public virtual DbSet<WageHistory> WageHistories { get; set; } = null!;
        public virtual DbSet<WageHistoryWage> WageHistoryWages { get; set; } = null!;
        public virtual DbSet<Xmlbucket> Xmlbuckets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=Tyler-Desktop\\SQLEXPRESS;Database=Blue Ribbon;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.HasIndex(e => e.Action, "IX_Activity_Action")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ActivityDate, "IX_Activity_ActivityDate")
                    .HasFillFactor(90);

                entity.Property(e => e.ActivityId)
                    .HasColumnName("ActivityID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ActivityDate).HasColumnType("datetime");

                entity.Property(e => e.Data).HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");
            });

            modelBuilder.Entity<ActivityDetail>(entity =>
            {
                entity.ToTable("ActivityDetail");

                entity.Property(e => e.ActivityDetailId)
                    .HasColumnName("ActivityDetailID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.ChangedValue)
                    .HasMaxLength(2048)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalIdentifier)
                    .HasMaxLength(36)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalValue)
                    .HasMaxLength(2048)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TableName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityDetails)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ActivityDetail_Activity");
            });

            modelBuilder.Entity<AdDisplay>(entity =>
            {
                entity.HasKey(e => e.DisplayId);

                entity.ToTable("AdDisplay");

                entity.Property(e => e.DisplayId)
                    .HasColumnName("DisplayID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DefaultPlayListId).HasColumnName("DefaultPlayListID");

                entity.Property(e => e.DisplayTitle).HasMaxLength(500);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<AdDisplaySchedule>(entity =>
            {
                entity.HasKey(e => e.DisplayScheduleId);

                entity.ToTable("AdDisplaySchedule");

                entity.HasIndex(e => e.DisplayId, "IX_AdDisplaySchedule")
                    .HasFillFactor(90);

                entity.Property(e => e.DisplayScheduleId)
                    .HasColumnName("DisplayScheduleID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DaysOfWeek).HasMaxLength(50);

                entity.Property(e => e.DisplayId).HasColumnName("DisplayID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdLinkContent>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("AdLinkContent");

                entity.Property(e => e.LinkId)
                    .HasColumnName("LinkID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.PlayListId).HasColumnName("PlayListID");

                entity.Property(e => e.PlaylistItemId).HasColumnName("PlaylistItemID");

                entity.Property(e => e.TransitionNumber).HasDefaultValueSql("((6))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdPlayList>(entity =>
            {
                entity.HasKey(e => e.PlayListId);

                entity.ToTable("AdPlayList");

                entity.Property(e => e.PlayListId)
                    .HasColumnName("PlayListID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ImportByName)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ImportTime).HasDefaultValueSql("((10))");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PlayListName).HasMaxLength(50);

                entity.Property(e => e.SyncByFileDate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SyncFolderPath).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AdPlayListItem>(entity =>
            {
                entity.HasKey(e => e.PlaylistItemId);

                entity.ToTable("AdPlayListItem");

                entity.Property(e => e.PlaylistItemId)
                    .HasColumnName("PlaylistItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.LoadContent)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.MediaType)
                    .HasMaxLength(50)
                    .HasComment("0=jpg,1=gif,2=mp4,3=png,4=swf");

                entity.Property(e => e.OriginalFileName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdScheduleGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("AdScheduleGroup");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ByRange)
                    .IsRequired()
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.DisplayId).HasColumnName("DisplayID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdScoreLayout>(entity =>
            {
                entity.HasKey(e => e.DesignId);

                entity.ToTable("AdScoreLayout");

                entity.Property(e => e.DesignId)
                    .HasColumnName("DesignID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BackgroundColor).HasMaxLength(10);

                entity.Property(e => e.DrawModifiers)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.EvenRowBackgroundColor).HasMaxLength(10);

                entity.Property(e => e.EvenRowFontColor).HasMaxLength(10);

                entity.Property(e => e.FontColor).HasMaxLength(10);

                entity.Property(e => e.FontFamily)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FontWeight)
                    .IsRequired()
                    .HasDefaultValueSql("('False')");

                entity.Property(e => e.HeaderLineColor).HasMaxLength(10);

                entity.Property(e => e.LeftColumnHeader).HasMaxLength(50);

                entity.Property(e => e.OddRowBackgroundColor).HasMaxLength(10);

                entity.Property(e => e.OddRowFontColor).HasMaxLength(10);

                entity.Property(e => e.RightColumnHeader).HasMaxLength(50);

                entity.Property(e => e.StageColor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplateItemId).HasColumnName("TemplateItemID");

                entity.Property(e => e.TotalColumnHeaderText).HasMaxLength(50);

                entity.Property(e => e.TotalLineColor).HasMaxLength(10);
            });

            modelBuilder.Entity<AdTemplateContentLink>(entity =>
            {
                entity.HasKey(e => e.LinkTemplateId)
                    .HasName("PK_AdScoreContentLink");

                entity.ToTable("AdTemplateContentLink");

                entity.Property(e => e.LinkTemplateId)
                    .HasColumnName("LinkTemplateID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ContentIdtag).HasColumnName("ContentIDTag");

                entity.Property(e => e.PlaylistItemId).HasColumnName("PlaylistItemID");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            });

            modelBuilder.Entity<Alert>(entity =>
            {
                entity.ToTable("Alert");

                entity.Property(e => e.AlertId)
                    .HasColumnName("AlertID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AlertName).HasMaxLength(50);

                entity.Property(e => e.LastAlert).HasColumnType("datetime");
            });

            modelBuilder.Entity<AlertEmail>(entity =>
            {
                entity.ToTable("AlertEmail");

                entity.Property(e => e.AlertEmailId)
                    .ValueGeneratedNever()
                    .HasColumnName("AlertEmailID");

                entity.Property(e => e.AlertEmailAddress).HasMaxLength(250);

                entity.Property(e => e.AlertEmailCarrier).HasMaxLength(20);

                entity.Property(e => e.AlertEmailFname).HasMaxLength(50);

                entity.Property(e => e.AlertEmailLname).HasMaxLength(50);

                entity.Property(e => e.AlertEmailPhone).HasMaxLength(25);
            });

            modelBuilder.Entity<AlertSetting>(entity =>
            {
                entity.HasKey(e => e.AlertSettingsId)
                    .HasName("PK_AlertSettings");

                entity.ToTable("AlertSetting");

                entity.HasIndex(e => e.AlertId, "IX_AlertSetting")
                    .HasFillFactor(90);

                entity.Property(e => e.AlertSettingsId)
                    .HasColumnName("AlertSettingsID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AlertFieldName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AlertFieldValue).HasDefaultValueSql("('')");

                entity.Property(e => e.AlertId).HasColumnName("AlertID");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdateStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<AveroId>(entity =>
            {
                entity.ToTable("AveroID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BackupSetting>(entity =>
            {
                entity.HasKey(e => e.BackupSettingsId);

                entity.Property(e => e.BackupSettingsId)
                    .HasColumnName("BackupSettingsID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BackupName).HasMaxLength(50);

                entity.Property(e => e.BackupTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeverageCount>(entity =>
            {
                entity.ToTable("BeverageCount");

                entity.Property(e => e.BeverageCountId)
                    .HasColumnName("BeverageCountID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeverageCountInfo>(entity =>
            {
                entity.ToTable("BeverageCountInfo");

                entity.Property(e => e.BeverageCountInfoId)
                    .HasColumnName("BeverageCountInfoID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EnteredTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<BeverageCountItem>(entity =>
            {
                entity.ToTable("BeverageCountItem");

                entity.Property(e => e.BeverageCountItemId)
                    .HasColumnName("BeverageCountItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BeverageCountId).HasColumnName("BeverageCountID");

                entity.Property(e => e.InCount).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutCount).HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.BeverageCount)
                    .WithMany(p => p.BeverageCountItems)
                    .HasForeignKey(d => d.BeverageCountId)
                    .HasConstraintName("FK_BeverageCountItem_BeverageCount");
            });

            modelBuilder.Entity<Break>(entity =>
            {
                entity.ToTable("Break");

                entity.Property(e => e.BreakId)
                    .ValueGeneratedNever()
                    .HasColumnName("BreakID");

                entity.Property(e => e.BreakName).HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<BreakJob>(entity =>
            {
                entity.ToTable("BreakJob");

                entity.HasIndex(e => e.BreakId, "IX_BreakJob")
                    .HasFillFactor(90);

                entity.Property(e => e.BreakJobId)
                    .ValueGeneratedNever()
                    .HasColumnName("BreakJobID");

                entity.Property(e => e.BreakId).HasColumnName("BreakID");

                entity.HasOne(d => d.Break)
                    .WithMany(p => p.BreakJobs)
                    .HasForeignKey(d => d.BreakId)
                    .HasConstraintName("FK_BreakJob_Break");
            });

            modelBuilder.Entity<BusyIndicatorSchedule>(entity =>
            {
                entity.ToTable("BusyIndicatorSchedule");

                entity.Property(e => e.BusyIndicatorScheduleId)
                    .ValueGeneratedNever()
                    .HasColumnName("BusyIndicatorScheduleID");

                entity.Property(e => e.BusyIndicatorId).HasColumnName("BusyIndicatorID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Button>(entity =>
            {
                entity.ToTable("Button");

                entity.HasIndex(e => new { e.RegionId, e.Menu }, "IX_Button")
                    .HasFillFactor(90);

                entity.Property(e => e.ButtonId)
                    .HasColumnName("ButtonID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ButtonName).HasMaxLength(32);

                entity.Property(e => e.Data).HasMaxLength(512);

                entity.Property(e => e.FontFaceName).HasMaxLength(50);

                entity.Property(e => e.GraphicName).HasMaxLength(50);

                entity.Property(e => e.Menu).HasMaxLength(20);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<Cashier>(entity =>
            {
                entity.ToTable("Cashier");

                entity.Property(e => e.CashierId)
                    .HasColumnName("CashierID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Cashier1)
                    .HasMaxLength(32)
                    .HasColumnName("Cashier");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<CheckNumber>(entity =>
            {
                entity.HasKey(e => e.NextSaleId)
                    .HasName("PK_NextSaleNumber");

                entity.ToTable("CheckNumber");

                entity.HasIndex(e => e.StoreId, "IX_CheckNumber")
                    .HasFillFactor(90);

                entity.Property(e => e.NextSaleId)
                    .HasColumnName("NextSaleID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TicketNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.TicketNumberLastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.HasIndex(e => new { e.RegionId, e.ClassIndex }, "IX_Class")
                    .HasFillFactor(90);

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AbraPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Accardis)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AdDriver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Adppayroll)
                    .IsRequired()
                    .HasColumnName("ADPPayroll")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Apspayroll)
                    .IsRequired()
                    .HasColumnName("APSPayroll")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AssignClasses)
                    .HasMaxLength(13)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Brrpt).HasColumnName("BRRpt");

                entity.Property(e => e.CallerId)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CallerIdCom)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CanPchOutWopenChks).HasColumnName("CanPchOutWOpenChks");

                entity.Property(e => e.CanViewAutoReport)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cbspayroll)
                    .IsRequired()
                    .HasColumnName("CBSPayroll")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CcamcanVwCcnums).HasColumnName("CCAMCanVwCCNums");

                entity.Property(e => e.Ccmaint).HasColumnName("CCMaint");

                entity.Property(e => e.ChefTec)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClassName).HasMaxLength(20);

                entity.Property(e => e.CmcanAdj).HasColumnName("CMCanAdj");

                entity.Property(e => e.CmcanClr).HasColumnName("CMCanClr");

                entity.Property(e => e.CmcanEditCc).HasColumnName("CMCanEditCC");

                entity.Property(e => e.CmcanVw).HasColumnName("CMCanVw");

                entity.Property(e => e.ConvertExportPng).HasColumnName("ConvertExportPNG");

                entity.Property(e => e.CostGuard)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreditCardModule)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Csrpt).HasColumnName("CSRpt");

                entity.Property(e => e.CustCanEditFd).HasColumnName("CustCanEditFD");

                entity.Property(e => e.CustMntViewCcnum).HasColumnName("CustMntViewCCNum");

                entity.Property(e => e.DailyOtlimit).HasColumnName("DailyOTlimit");

                entity.Property(e => e.DataTranCcam)
                    .IsRequired()
                    .HasColumnName("DataTranCCAM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dbsetup).HasColumnName("DBSetup");

                entity.Property(e => e.DeductIt)
                    .IsRequired()
                    .HasColumnName("DeductIT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DupCrpt).HasColumnName("DupCRpt");

                entity.Property(e => e.Ecrpt).HasColumnName("ECRpt");

                entity.Property(e => e.Ejrpt).HasColumnName("EJRpt");

                entity.Property(e => e.EjrptCanViewCcs).HasColumnName("EJRptCanViewCCs");

                entity.Property(e => e.EmadjTips).HasColumnName("EMAdjTips");

                entity.Property(e => e.EmcshDwrs).HasColumnName("EMCshDwrs");

                entity.Property(e => e.EmpInclRoas).HasColumnName("EmpInclROAs");

                entity.Property(e => e.Empasswd).HasColumnName("EMPasswd");

                entity.Property(e => e.EmpayRates).HasColumnName("EMPayRates");

                entity.Property(e => e.EmpcanChgBopass).HasColumnName("EMPCanChgBOPass");

                entity.Property(e => e.EmsecLvl).HasColumnName("EMSecLvl");

                entity.Property(e => e.Emtmcrd).HasColumnName("EMTmcrd");

                entity.Property(e => e.Fdmnt).HasColumnName("FDMnt");

                entity.Property(e => e.FeAuthMobilePos).HasColumnName("FE_AuthMobilePOS");

                entity.Property(e => e.FeCshRpt).HasColumnName("FE_CshRpt");

                entity.Property(e => e.FeDsrpt).HasColumnName("FE_DSRpt");

                entity.Property(e => e.FeRcrpt).HasColumnName("FE_RCRpt");

                entity.Property(e => e.FeScrpt).HasColumnName("FE_SCRpt");

                entity.Property(e => e.FoodTrak)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Gcdestroy).HasColumnName("GCDestroy");

                entity.Property(e => e.Gcissue).HasColumnName("GCIssue");

                entity.Property(e => e.Gclist).HasColumnName("GCList");

                entity.Property(e => e.Gcmnt).HasColumnName("GCMnt");

                entity.Property(e => e.GreatPlainsGl)
                    .IsRequired()
                    .HasColumnName("GreatPlainsGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GreatPlainsPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HarmonyVdudriver).HasColumnName("HarmonyVDUDriver");

                entity.Property(e => e.HeartlandPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Icrpt).HasColumnName("ICRpt");

                entity.Property(e => e.Igmadj).HasColumnName("IGMAdj");

                entity.Property(e => e.ImadjPrc).HasColumnName("IMAdjPrc");

                entity.Property(e => e.ImcanDelete).HasColumnName("IMCanDelete");

                entity.Property(e => e.InternetCcam)
                    .IsRequired()
                    .HasColumnName("InternetCCAM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Iptrpt).HasColumnName("IPTRpt");

                entity.Property(e => e.Isrpt).HasColumnName("ISRpt");

                entity.Property(e => e.LicenseFuturePos).HasColumnName("LicenseFuturePOS");

                entity.Property(e => e.Lvsgraph).HasColumnName("LVSGraph");

                entity.Property(e => e.Lvsrpt).HasColumnName("LVSRpt");

                entity.Property(e => e.Mas90Gl)
                    .IsRequired()
                    .HasColumnName("Mas90GL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mas90Payroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLink)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkGl)
                    .IsRequired()
                    .HasColumnName("MenuLinkGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkSalesInterval)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MobilePosserviceHost).HasColumnName("MobilePOSServiceHost");

                entity.Property(e => e.PayChexPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayPeriodRefDate).HasColumnType("datetime");

                entity.Property(e => e.PeachtreeGl)
                    .IsRequired()
                    .HasColumnName("PeachtreeGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PurgeOldData)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickBooksPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickbooksGl)
                    .IsRequired()
                    .HasColumnName("QuickbooksGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RcslsRpt).HasColumnName("RCSlsRpt");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ResetDbs).HasColumnName("ResetDBs");

                entity.Property(e => e.Rsmnt).HasColumnName("RSMnt");

                entity.Property(e => e.SaaShrPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sbrgraph).HasColumnName("SBRGraph");

                entity.Property(e => e.ScoreboardDriver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sprpt).HasColumnName("SPRPT");

                entity.Property(e => e.Swarpt).HasColumnName("SWARpt");

                entity.Property(e => e.Tbrpt).HasColumnName("TBRpt");

                entity.Property(e => e.Tcrpt).HasColumnName("TCRpt");

                entity.Property(e => e.VduDriver)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Virpt).HasColumnName("VIRpt");

                entity.Property(e => e.WeeklyOtlimit).HasColumnName("WeeklyOTlimit");

                entity.Property(e => e.Wsexprt).HasColumnName("WSExprt");

                entity.Property(e => e.Wsimprt).HasColumnName("WSImprt");

                entity.Property(e => e.X10driver)
                    .IsRequired()
                    .HasColumnName("X10Driver")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Xmlexport).HasColumnName("XMLExport");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("Configuration");

                entity.Property(e => e.ConfigurationId)
                    .HasColumnName("ConfigurationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Parameter).HasMaxLength(50);

                entity.Property(e => e.ParameterIndex2).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<ConfigurationDevice>(entity =>
            {
                entity.ToTable("ConfigurationDevice");

                entity.Property(e => e.ConfigurationDeviceId)
                    .HasColumnName("ConfigurationDeviceID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<ConfigurationSecure>(entity =>
            {
                entity.ToTable("ConfigurationSecure");

                entity.Property(e => e.ConfigurationSecureId)
                    .HasColumnName("ConfigurationSecureID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Parameter).HasMaxLength(50);

                entity.Property(e => e.ParameterIndex2).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Value)
                    .HasMaxLength(4096)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CorporateMessage>(entity =>
            {
                entity.ToTable("CorporateMessage");

                entity.Property(e => e.CorporateMessageId)
                    .ValueGeneratedNever()
                    .HasColumnName("CorporateMessageID");

                entity.Property(e => e.ApplicationName).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ACM.Models.Coupon>(entity =>
            {
                entity.ToTable("Coupon");

                entity.Property(e => e.CouponId)
                    .HasColumnName("CouponID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CouponName).HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(512);

                entity.Property(e => e.Upc)
                    .HasMaxLength(32)
                    .HasColumnName("UPC");

                entity.Property(e => e.WebRedemptionCode).HasMaxLength(16);
            });

            modelBuilder.Entity<CouponItem>(entity =>
            {
                entity.ToTable("CouponItem");

                entity.HasIndex(e => e.CouponId, "IX_CouponItem")
                    .HasFillFactor(90);

                entity.Property(e => e.CouponItemId)
                    .HasColumnName("CouponItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponItems)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_CouponItem_Coupon");
            });

            modelBuilder.Entity<CouponTranslation>(entity =>
            {
                entity.ToTable("CouponTranslation");

                entity.Property(e => e.CouponTranslationId)
                    .HasColumnName("CouponTranslationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponTranslations)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_CouponTranslation_Coupon");
            });

            modelBuilder.Entity<CreditBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("CreditBatch");

                entity.HasIndex(e => e.DataVersion, "IX_CreditBatch_DataVersion")
                    .HasFillFactor(90);

                entity.Property(e => e.BatchId)
                    .ValueGeneratedNever()
                    .HasColumnName("BatchID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AppCd)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.AuthorizeDate).HasColumnType("datetime");

                entity.Property(e => e.BatchRecord)
                    .HasMaxLength(520)
                    .IsFixedLength();

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<CurrencyConversion>(entity =>
            {
                entity.ToTable("CurrencyConversion");

                entity.Property(e => e.CurrencyConversionId)
                    .HasColumnName("CurrencyConversionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ConversionBaseName).HasMaxLength(32);

                entity.Property(e => e.ConversionBaseShortName).HasMaxLength(4);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<CurrencyConversionItem>(entity =>
            {
                entity.ToTable("CurrencyConversionItem");

                entity.HasIndex(e => e.CurrencyConversionId, "IX_CurrencyConversionItem")
                    .HasFillFactor(90);

                entity.Property(e => e.CurrencyConversionItemId)
                    .HasColumnName("CurrencyConversionItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ConversionName).HasMaxLength(32);

                entity.Property(e => e.ConversionRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConversionShortName).HasMaxLength(4);

                entity.Property(e => e.CurrencyConversionId).HasColumnName("CurrencyConversionID");

                entity.HasOne(d => d.CurrencyConversion)
                    .WithMany(p => p.CurrencyConversionItems)
                    .HasForeignKey(d => d.CurrencyConversionId)
                    .HasConstraintName("FK_CurrencyConversionItem_CurrencyConversion");
            });

            modelBuilder.Entity<Custom2dDataViewBottom10Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Bottom10Departments");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Custom2dDataViewBottom10DepartmentsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Bottom10DepartmentsPrice");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Custom2dDataViewBottom10Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Bottom10Items");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewBottom10ItemsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Bottom10ItemsPrice");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyCheckCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyCheckCount");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnType("date")
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasColumnType("date");
            });

            modelBuilder.Entity<Custom2dDataViewDailyDepartmentSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyDepartmentSales");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<Custom2dDataViewDailyGuestCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyGuestCount");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnType("date")
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasColumnType("date");
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemPercentage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemPercentages");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSales");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSalesFriday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSalesFriday");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSalesMonday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSalesMonday");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSalesSaturday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSalesSaturday");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSalesSunday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSalesSunday");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSalesThursday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSalesThursday");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSalesTuesday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSalesTuesday");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemSalesWednesday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemSalesWednesday");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyItemVoidsByEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyItemVoidsByEmployee");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewDailyVoid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyVoids");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id)
                    .HasColumnType("date")
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasColumnType("date");
            });

            modelBuilder.Entity<Custom2dDataViewDailyVoidsByEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyVoidsByEmployee");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(42);
            });

            modelBuilder.Entity<Custom2dDataViewDailyVoidsByEmployeeSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_DailyVoidsByEmployeeSum");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(73);
            });

            modelBuilder.Entity<Custom2dDataViewOpenCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_OpenChecks");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Custom2dDataViewServingPeriodSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_ServingPeriodSales");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Custom2dDataViewTop10Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Top10Departments");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Custom2dDataViewTop10DepartmentsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Top10DepartmentsPrice");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<Custom2dDataViewTop10Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Top10Items");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Custom2dDataViewTop10ItemsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_Custom2dDataView_Top10ItemsPrice");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasMaxLength(32)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => new { e.CustomerNumber, e.StoreId }, "IX_Customer")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.UserData, e.LastName, e.FirstName }, "IX_Customer_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Badge, "IX_Customer_Badge")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.LastName, e.FirstName }, "IX_Customer_Name")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CustomerNumber, "IX_Customer_Number")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Phone, e.LastName, e.FirstName }, "IX_Customer_Phone")
                    .HasFillFactor(90);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address1).HasMaxLength(64);

                entity.Property(e => e.Address2).HasMaxLength(64);

                entity.Property(e => e.Badge).HasMaxLength(40);

                entity.Property(e => e.Bcitems)
                    .HasMaxLength(25)
                    .HasColumnName("BCItems")
                    .IsFixedLength();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.Comments).HasMaxLength(600);

                entity.Property(e => e.Company).HasMaxLength(32);

                entity.Property(e => e.CustomerCard).HasMaxLength(16);

                entity.Property(e => e.Directions).HasMaxLength(600);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Extension).HasMaxLength(6);

                entity.Property(e => e.Extension2).HasMaxLength(6);

                entity.Property(e => e.Extension3).HasMaxLength(6);

                entity.Property(e => e.Extension4).HasMaxLength(6);

                entity.Property(e => e.Extension5).HasMaxLength(6);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.Fpbuffer)
                    .HasMaxLength(6000)
                    .HasColumnName("FPBuffer");

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.Phone2).HasMaxLength(16);

                entity.Property(e => e.Phone3).HasMaxLength(16);

                entity.Property(e => e.Phone4).HasMaxLength(16);

                entity.Property(e => e.Phone5).HasMaxLength(16);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserData).HasMaxLength(20);

                entity.Property(e => e.WebId).HasColumnName("WebID");

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<CustomerCard>(entity =>
            {
                entity.ToTable("CustomerCard");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerCard")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DataVersion, "IX_CustomerCard_DataVersion")
                    .HasFillFactor(90);

                entity.Property(e => e.CustomerCardId)
                    .HasColumnName("CustomerCardID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreditCard)
                    .HasMaxLength(136)
                    .IsFixedLength();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.EncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.EncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.IsE2eencryption).HasColumnName("IsE2EEncryption");

                entity.Property(e => e.VaultId)
                    .HasMaxLength(128)
                    .HasColumnName("VaultID")
                    .IsFixedLength();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCards)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FKS_CustomerCard_Customer");
            });

            modelBuilder.Entity<CustomerCharge>(entity =>
            {
                entity.ToTable("CustomerCharge");

                entity.HasIndex(e => e.CustomerNumber, "IX_CustomerCharge")
                    .HasFillFactor(90);

                entity.Property(e => e.CustomerChargeId)
                    .HasColumnName("CustomerChargeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ChargeDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");
            });

            modelBuilder.Entity<CustomerLastOrder>(entity =>
            {
                entity.HasKey(e => e.CustomerOrderId);

                entity.ToTable("CustomerLastOrder");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerLastOrder")
                    .HasFillFactor(90);

                entity.Property(e => e.CustomerOrderId)
                    .HasColumnName("CustomerOrderID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.SettleDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerLastOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CustomerLastOrder_Customer");
            });

            modelBuilder.Entity<CustomerNumber>(entity =>
            {
                entity.ToTable("CustomerNumber");

                entity.Property(e => e.CustomerNumberId)
                    .HasColumnName("CustomerNumberID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CustomerNumber1).HasColumnName("CustomerNumber");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<CustomerPlan>(entity =>
            {
                entity.ToTable("CustomerPlan");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerPlan")
                    .HasFillFactor(90);

                entity.Property(e => e.CustomerPlanId)
                    .HasColumnName("CustomerPlanID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPlans)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerPlan_Customer");
            });

            modelBuilder.Entity<DashBoardItem>(entity =>
            {
                entity.ToTable("DashBoardItem");

                entity.Property(e => e.DashBoardItemId)
                    .HasColumnName("DashBoardItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.DasboardItemName).HasMaxLength(150);

                entity.Property(e => e.DockingCellId).HasColumnName("DockingCellID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DashBoardSetting>(entity =>
            {
                entity.HasKey(e => e.DashBoardSettingsId);

                entity.Property(e => e.DashBoardSettingsId)
                    .HasColumnName("DashBoardSettingsID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.DashFieldName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DashFieldValue).HasDefaultValueSql("('')");

                entity.Property(e => e.DashItemPanelId).HasColumnName("dashItemPanelID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UpdateStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<DataGroup>(entity =>
            {
                entity.ToTable("DataGroup");

                entity.Property(e => e.DataGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("DataGroupID");

                entity.Property(e => e.AppliedDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduleGroupId).HasColumnName("ScheduleGroupID");

                entity.HasOne(d => d.ScheduleGroup)
                    .WithMany(p => p.DataGroups)
                    .HasForeignKey(d => d.ScheduleGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataGroup_ScheduledUpdateScheduleGroup");
            });

            modelBuilder.Entity<DataGroupStore>(entity =>
            {
                entity.ToTable("DataGroupStore");

                entity.Property(e => e.DataGroupStoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("DataGroupStoreID");

                entity.Property(e => e.DataGroupId).HasColumnName("DataGroupID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.DataGroup)
                    .WithMany(p => p.DataGroupStores)
                    .HasForeignKey(d => d.DataGroupId)
                    .HasConstraintName("DataGroupStore_DataGroupID_FK");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.DataGroupStores)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DataGroupStore_StoreID_FK");
            });

            modelBuilder.Entity<DataTypeReference>(entity =>
            {
                entity.HasKey(e => e.DataTypeId)
                    .HasName("PK_DataType");

                entity.ToTable("DataTypeReference");

                entity.Property(e => e.DataTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("DataTypeID");

                entity.Property(e => e.DataType)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'String')");

                entity.Property(e => e.SqlDataType)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'nvarchar')");
            });

            modelBuilder.Entity<DayDivide>(entity =>
            {
                entity.ToTable("DayDivide");

                entity.Property(e => e.DayDivideId).HasColumnName("DayDivideID");

                entity.Property(e => e.DayDivideDateTime).HasColumnType("datetime");

                entity.Property(e => e.DayDivideDateTimeNxt)
                    .HasColumnType("datetime")
                    .HasColumnName("DayDivideDateTimeNXT");
            });

            modelBuilder.Entity<DbaIndexDefragExclusion>(entity =>
            {
                entity.HasKey(e => new { e.DatabaseId, e.ObjectId, e.IndexId })
                    .HasName("PK_indexDefragExclusion_v40");

                entity.ToTable("dba_indexDefragExclusion");

                entity.Property(e => e.DatabaseId).HasColumnName("databaseID");

                entity.Property(e => e.ObjectId).HasColumnName("objectID");

                entity.Property(e => e.IndexId).HasColumnName("indexID");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("databaseName");

                entity.Property(e => e.ExclusionMask).HasColumnName("exclusionMask");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(128)
                    .HasColumnName("indexName");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasColumnName("objectName");
            });

            modelBuilder.Entity<DbaIndexDefragLog>(entity =>
            {
                entity.HasKey(e => e.IndexDefragId)
                    .HasName("PK_indexDefragLog_v40");

                entity.ToTable("dba_indexDefragLog");

                entity.Property(e => e.IndexDefragId).HasColumnName("indexDefrag_id");

                entity.Property(e => e.DatabaseId).HasColumnName("databaseID");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("databaseName");

                entity.Property(e => e.DateTimeEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTimeEnd");

                entity.Property(e => e.DateTimeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTimeStart");

                entity.Property(e => e.DurationSeconds).HasColumnName("durationSeconds");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("errorMessage");

                entity.Property(e => e.Fragmentation).HasColumnName("fragmentation");

                entity.Property(e => e.IndexId).HasColumnName("indexID");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(128)
                    .HasColumnName("indexName");

                entity.Property(e => e.ObjectId).HasColumnName("objectID");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasColumnName("objectName");

                entity.Property(e => e.PageCount).HasColumnName("page_count");

                entity.Property(e => e.PartitionNumber).HasColumnName("partitionNumber");

                entity.Property(e => e.SqlStatement)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("sqlStatement");
            });

            modelBuilder.Entity<DbaIndexDefragStatus>(entity =>
            {
                entity.HasKey(e => new { e.DatabaseId, e.ObjectId, e.IndexId, e.PartitionNumber })
                    .HasName("PK_indexDefragStatus_v40");

                entity.ToTable("dba_indexDefragStatus");

                entity.Property(e => e.DatabaseId).HasColumnName("databaseID");

                entity.Property(e => e.ObjectId).HasColumnName("objectID");

                entity.Property(e => e.IndexId).HasColumnName("indexID");

                entity.Property(e => e.PartitionNumber).HasColumnName("partitionNumber");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(128)
                    .HasColumnName("databaseName");

                entity.Property(e => e.DefragDate)
                    .HasColumnType("datetime")
                    .HasColumnName("defragDate");

                entity.Property(e => e.ExclusionMask).HasColumnName("exclusionMask");

                entity.Property(e => e.Fragmentation).HasColumnName("fragmentation");

                entity.Property(e => e.IndexName)
                    .HasMaxLength(128)
                    .HasColumnName("indexName");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasColumnName("objectName");

                entity.Property(e => e.PageCount).HasColumnName("page_count");

                entity.Property(e => e.PrintStatus).HasColumnName("printStatus");

                entity.Property(e => e.RangeScanCount).HasColumnName("range_scan_count");

                entity.Property(e => e.ScanDate)
                    .HasColumnType("datetime")
                    .HasColumnName("scanDate");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(128)
                    .HasColumnName("schemaName");
            });

            modelBuilder.Entity<Dbfile>(entity =>
            {
                entity.ToTable("DBFile");

                entity.HasIndex(e => new { e.FileType, e.FileName }, "IX_DBFile")
                    .HasFillFactor(90);

                entity.Property(e => e.DbfileId)
                    .ValueGeneratedNever()
                    .HasColumnName("DBFileID");

                entity.Property(e => e.FileDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DeliveryDriver>(entity =>
            {
                entity.HasKey(e => e.DriverId);

                entity.ToTable("DeliveryDriver");

                entity.Property(e => e.DriverId)
                    .HasColumnName("DriverID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DeliveryZone>(entity =>
            {
                entity.ToTable("DeliveryZone");

                entity.Property(e => e.DeliveryZoneId)
                    .HasColumnName("DeliveryZoneID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ZoneName).HasMaxLength(32);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.HasIndex(e => new { e.RegionId, e.DepartmentName }, "IX_Department")
                    .HasFillFactor(90);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AskId).HasColumnName("AskID");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(30);

                entity.Property(e => e.DepartmentName).HasMaxLength(10);

                entity.Property(e => e.GroupName).HasMaxLength(30);

                entity.Property(e => e.MobileAskId).HasColumnName("MobileAskID");

                entity.Property(e => e.MobileMessageId).HasColumnName("MobileMessageID");

                entity.Property(e => e.OverrideAutoMenuButtonSettingsGraphic).HasMaxLength(50);

                entity.Property(e => e.ParentDepartmentId).HasColumnName("ParentDepartmentID");

                entity.Property(e => e.PmsbucketNumber).HasColumnName("PMSBucketNumber");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Vduid).HasColumnName("VDUID");

                entity.Property(e => e.WebImagePath).HasMaxLength(254);

                entity.Property(e => e.WebThumbPath).HasMaxLength(254);

                entity.Property(e => e.WebTitle).HasMaxLength(30);
            });

            modelBuilder.Entity<DepartmentMobileExclusion>(entity =>
            {
                entity.ToTable("DepartmentMobileExclusion");

                entity.HasIndex(e => e.EmpId, "IX_DepartmentMobileExclusion_EmpID")
                    .HasFillFactor(90);

                entity.Property(e => e.DepartmentMobileExclusionId)
                    .HasColumnName("DepartmentMobileExclusionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentMobileExclusions)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_DepartmentMobileExclusion_Department");
            });

            modelBuilder.Entity<DepartmentRank>(entity =>
            {
                entity.ToTable("DepartmentRank");

                entity.Property(e => e.DepartmentRankId)
                    .ValueGeneratedNever()
                    .HasColumnName("DepartmentRankID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            });

            modelBuilder.Entity<DepartmentSchedule>(entity =>
            {
                entity.ToTable("DepartmentSchedule");

                entity.HasIndex(e => e.DepartmentId, "IX_DepartmentSchedule")
                    .HasFillFactor(90);

                entity.Property(e => e.DepartmentScheduleId)
                    .HasColumnName("DepartmentScheduleID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentSchedules)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_DepartmentSchedule_Department");
            });

            modelBuilder.Entity<DinePointConfig>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.ToTable("DinePointConfig");

                entity.Property(e => e.StoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("StoreID");

                entity.Property(e => e.DayDivide).HasColumnType("datetime");
            });

            modelBuilder.Entity<DinePointDayDivide>(entity =>
            {
                entity.HasKey(e => e.BusinessDate)
                    .HasName("PK_DinePointDayDivide_1");

                entity.ToTable("DinePointDayDivide");

                entity.Property(e => e.BusinessDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DinePointJobCode>(entity =>
            {
                entity.HasKey(e => e.JobCodeIndex);

                entity.ToTable("DinePointJobCode");

                entity.Property(e => e.JobCodeIndex).ValueGeneratedNever();

                entity.Property(e => e.JobCodeName).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DinePointOrderType>(entity =>
            {
                entity.HasKey(e => e.OrderTypeIndex);

                entity.ToTable("DinePointOrderType");

                entity.Property(e => e.OrderTypeIndex).ValueGeneratedNever();

                entity.Property(e => e.OrderType).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DinePointRevenueCenter>(entity =>
            {
                entity.HasKey(e => e.RevenueCenterIndex);

                entity.ToTable("DinePointRevenueCenter");

                entity.Property(e => e.RevenueCenterIndex).ValueGeneratedNever();

                entity.Property(e => e.RevenueCenter).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DinePointServingPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodIndex);

                entity.ToTable("DinePointServingPeriod");

                entity.Property(e => e.PeriodIndex).ValueGeneratedNever();

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodName).HasMaxLength(50);

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<DirtyTable>(entity =>
            {
                entity.ToTable("DirtyTable");

                entity.HasIndex(e => e.StoreId, "IX_DirtyTable")
                    .HasFillFactor(90);

                entity.Property(e => e.DirtyTableId)
                    .HasColumnName("DirtyTableID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.DiscountId)
                    .HasColumnName("DiscountID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DiscountName).HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Text).HasMaxLength(512);
            });

            modelBuilder.Entity<DiscountTranslation>(entity =>
            {
                entity.ToTable("DiscountTranslation");

                entity.Property(e => e.DiscountTranslationId)
                    .HasColumnName("DiscountTranslationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountTranslations)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_DiscountTranslation_Discount");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => new { e.EmpId, e.StoreId }, "IX_Employee")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.StoreId, e.FrontEndPassword }, "IX_Employee_Login")
                    .HasFillFactor(90);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address).HasMaxLength(64);

                entity.Property(e => e.BackOfficeHash1)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficeHash2)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficeHash3)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficeHash4)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword1)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword2)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword3)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BackOfficePassword4)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.Badge).HasMaxLength(40);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CellPhone).HasMaxLength(16);

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FingerPrintData).HasMaxLength(6000);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.FrontEndHash)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.FrontEndPassword)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.GslcurrRoom).HasColumnName("GSLCurrRoom");

                entity.Property(e => e.GslfirstRoom).HasColumnName("GSLFirstRoom");

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.IceName).HasMaxLength(20);

                entity.Property(e => e.IcePhone).HasMaxLength(16);

                entity.Property(e => e.LastBadPwdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastBadPWDate");

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.LockedOut).HasColumnType("datetime");

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Notes).HasMaxLength(600);

                entity.Property(e => e.PasswordChanged).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.Salt)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Ssn)
                    .HasMaxLength(24)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserInfo).HasMaxLength(40);

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<EmployeeAvailability>(entity =>
            {
                entity.ToTable("EmployeeAvailability");

                entity.HasIndex(e => new { e.EmpId, e.StoreId }, "IX_EmployeeAvailability")
                    .HasFillFactor(90);

                entity.Property(e => e.EmployeeAvailabilityId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeAvailabilityID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Weekly)
                    .HasMaxLength(336)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EmployeeAvailabilityRange>(entity =>
            {
                entity.ToTable("EmployeeAvailabilityRange");

                entity.HasIndex(e => e.EmployeeAvailabilityId, "IX_EmployeeAvailabilityRange")
                    .HasFillFactor(90);

                entity.Property(e => e.EmployeeAvailabilityRangeId)
                    .HasColumnName("EmployeeAvailabilityRangeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeAvailabilityId).HasColumnName("EmployeeAvailabilityID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.RangeDescription).HasMaxLength(32);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.EmployeeAvailability)
                    .WithMany(p => p.EmployeeAvailabilityRanges)
                    .HasForeignKey(d => d.EmployeeAvailabilityId)
                    .HasConstraintName("FK_EmployeeAvailabilityRange_EmployeeAvailabilityRange");
            });

            modelBuilder.Entity<EmployeeDrawer>(entity =>
            {
                entity.ToTable("EmployeeDrawer");

                entity.HasIndex(e => e.EmployeeId, "IX_EmployeeDrawer")
                    .HasFillFactor(90);

                entity.Property(e => e.EmployeeDrawerId)
                    .HasColumnName("EmployeeDrawerID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeDrawers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeDrawer_Employee");
            });

            modelBuilder.Entity<EmployeeHintShown>(entity =>
            {
                entity.ToTable("EmployeeHintShown");

                entity.Property(e => e.EmployeeHintShownId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeHintShownID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            });

            modelBuilder.Entity<EmployeeRate>(entity =>
            {
                entity.ToTable("EmployeeRate");

                entity.HasIndex(e => e.EmployeeId, "IX_EmployeeRate")
                    .HasFillFactor(90);

                entity.Property(e => e.EmployeeRateId)
                    .HasColumnName("EmployeeRateID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRates)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeWage_Employee");
            });

            modelBuilder.Entity<EmployeeTip>(entity =>
            {
                entity.ToTable("EmployeeTip");

                entity.Property(e => e.EmployeeTipId)
                    .HasColumnName("EmployeeTipID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.SharedEmpId).HasColumnName("SharedEmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TipDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Enterprise>(entity =>
            {
                entity.HasKey(e => e.EntId);

                entity.ToTable("Enterprise");

                entity.Property(e => e.EntId)
                    .ValueGeneratedNever()
                    .HasColumnName("EntID");

                entity.Property(e => e.Apikey)
                    .HasMaxLength(200)
                    .HasColumnName("APIKey");

                entity.Property(e => e.EmailPassword).HasMaxLength(40);

                entity.Property(e => e.EmailPasswordEnc)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.EmailServer).HasMaxLength(65);

                entity.Property(e => e.EmailUseSsl).HasColumnName("EmailUseSSL");

                entity.Property(e => e.EmailUser).HasMaxLength(40);

                entity.Property(e => e.EnterpriseName).HasMaxLength(65);

                entity.Property(e => e.ServerIpaddress).HasColumnName("ServerIPAddress");
            });

            modelBuilder.Entity<EnterpriseEmployee>(entity =>
            {
                entity.ToTable("EnterpriseEmployee");

                entity.Property(e => e.EnterpriseEmployeeId)
                    .HasColumnName("EnterpriseEmployeeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AbraPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Accardis)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(64);

                entity.Property(e => e.Adppayroll)
                    .IsRequired()
                    .HasColumnName("ADPPayroll")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Apspayroll)
                    .IsRequired()
                    .HasColumnName("APSPayroll")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BackOfficeHash)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Brrpt).HasColumnName("BRRpt");

                entity.Property(e => e.Cbspayroll)
                    .IsRequired()
                    .HasColumnName("CBSPayroll")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChefTec)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.CmcanAdj).HasColumnName("CMCanAdj");

                entity.Property(e => e.CmcanClr).HasColumnName("CMCanClr");

                entity.Property(e => e.CmcanEditCc).HasColumnName("CMCanEditCC");

                entity.Property(e => e.CmcanVw).HasColumnName("CMCanVw");

                entity.Property(e => e.CmviewLoyalty).HasColumnName("CMViewLoyalty");

                entity.Property(e => e.CostGuard)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Csrpt).HasColumnName("CSRpt");

                entity.Property(e => e.CustCanEditFd).HasColumnName("CustCanEditFD");

                entity.Property(e => e.Dbsetup).HasColumnName("DBSetup");

                entity.Property(e => e.DeductIt)
                    .IsRequired()
                    .HasColumnName("DeductIT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DupCrpt).HasColumnName("DupCRpt");

                entity.Property(e => e.Ecrpt).HasColumnName("ECRpt");

                entity.Property(e => e.EemcanEditPassword).HasColumnName("EEMCanEditPassword");

                entity.Property(e => e.Eemsecurity).HasColumnName("EEMSecurity");

                entity.Property(e => e.Ejrpt).HasColumnName("EJRpt");

                entity.Property(e => e.EjrptCanViewCcs).HasColumnName("EJRptCanViewCCs");

                entity.Property(e => e.EmadjTips).HasColumnName("EMAdjTips");

                entity.Property(e => e.EmcshDwrs).HasColumnName("EMCshDwrs");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Empasswd).HasColumnName("EMPasswd");

                entity.Property(e => e.EmpayRates).HasColumnName("EMPayRates");

                entity.Property(e => e.EmpcanChgBopass).HasColumnName("EMPCanChgBOPass");

                entity.Property(e => e.EmsecLvl).HasColumnName("EMSecLvl");

                entity.Property(e => e.Emtmcrd).HasColumnName("EMTmcrd");

                entity.Property(e => e.EncryptedPassword)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.EndofDay)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntFrontEnd)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntIcrpt)
                    .IsRequired()
                    .HasColumnName("EntICRpt")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntSbr).HasColumnName("EntSBR");

                entity.Property(e => e.EnterpriseBulkDownloader)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fdmnt).HasColumnName("FDMnt");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.FoodTrak)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Gcdestroy).HasColumnName("GCDestroy");

                entity.Property(e => e.Gcissue).HasColumnName("GCIssue");

                entity.Property(e => e.Gclist).HasColumnName("GCList");

                entity.Property(e => e.Gcmnt).HasColumnName("GCMnt");

                entity.Property(e => e.Gcreconciliation)
                    .IsRequired()
                    .HasColumnName("GCReconciliation")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GreatPlainsGl)
                    .IsRequired()
                    .HasColumnName("GreatPlainsGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GreatPlainsPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HeartlandPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Icrpt).HasColumnName("ICRpt");

                entity.Property(e => e.Igmadj).HasColumnName("IGMAdj");

                entity.Property(e => e.ImadjPrc).HasColumnName("IMAdjPrc");

                entity.Property(e => e.ImcanDelete).HasColumnName("IMCanDelete");

                entity.Property(e => e.Iptrpt).HasColumnName("IPTRpt");

                entity.Property(e => e.Isrpt).HasColumnName("ISRpt");

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.LicenseFuturePos).HasColumnName("LicenseFuturePOS");

                entity.Property(e => e.Lvsrpt).HasColumnName("LVSRpt");

                entity.Property(e => e.Mas90Gl)
                    .IsRequired()
                    .HasColumnName("Mas90GL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mas90Payroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLink)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkGl)
                    .IsRequired()
                    .HasColumnName("MenuLinkGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuLinkSalesInterval)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NeedPasswordEncryption)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayChexPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PeachtreeGl)
                    .IsRequired()
                    .HasColumnName("PeachtreeGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.PurgeOldData)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickBooksPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuickbooksGl)
                    .IsRequired()
                    .HasColumnName("QuickbooksGL")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RcslsRpt).HasColumnName("RCSlsRpt");

                entity.Property(e => e.ResetDatabase)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rsmnt).HasColumnName("RSMnt");

                entity.Property(e => e.SaaShrPayroll)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Salt)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.Sbrgrph).HasColumnName("SBRGrph");

                entity.Property(e => e.ServiceManager)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Sprpt).HasColumnName("SPRPT");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(24)
                    .HasColumnName("SSN")
                    .IsFixedLength();

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.SumcanDelete).HasColumnName("SUMCanDelete");

                entity.Property(e => e.Swarpt).HasColumnName("SWARpt");

                entity.Property(e => e.Tbrpt).HasColumnName("TBRpt");

                entity.Property(e => e.Tcrpt).HasColumnName("TCRpt");

                entity.Property(e => e.UserInfo).HasMaxLength(40);

                entity.Property(e => e.Virpt).HasColumnName("VIRpt");

                entity.Property(e => e.WinSched)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Wsexprt)
                    .IsRequired()
                    .HasColumnName("WSExprt")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Wsimprt)
                    .IsRequired()
                    .HasColumnName("WSImprt")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<EnterpriseSort>(entity =>
            {
                entity.ToTable("EnterpriseSort");

                entity.Property(e => e.EnterpriseSortId)
                    .ValueGeneratedNever()
                    .HasColumnName("EnterpriseSortID");

                entity.Property(e => e.FileName).HasMaxLength(256);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EnterpriseSyncExclude>(entity =>
            {
                entity.ToTable("EnterpriseSyncExclude");

                entity.Property(e => e.EnterpriseSyncExcludeId)
                    .HasColumnName("EnterpriseSyncExcludeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Destination).HasDefaultValueSql("((-1))");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasDefaultValueSql("((-10))");
            });

            modelBuilder.Entity<FollowMe>(entity =>
            {
                entity.ToTable("FollowMe");

                entity.Property(e => e.FollowMeId)
                    .HasColumnName("FollowMeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");
            });

            modelBuilder.Entity<Gift>(entity =>
            {
                entity.ToTable("Gift");

                entity.Property(e => e.GiftId)
                    .HasColumnName("GiftID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DestroyDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FromName).HasMaxLength(50);

                entity.Property(e => e.GiftNumber).HasMaxLength(16);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Prefix).HasMaxLength(16);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.StoreNumber).HasMaxLength(8);

                entity.Property(e => e.Suffix).HasMaxLength(16);

                entity.Property(e => e.Swipe).HasMaxLength(48);

                entity.Property(e => e.ToName).HasMaxLength(50);
            });

            modelBuilder.Entity<GiftBackup>(entity =>
            {
                entity.HasKey(e => e.GiftBackupId);

                entity.ToTable("GiftBackup");

                entity.Property(e => e.GiftBackupId)
                    .HasColumnName("GiftBackupID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Data)
                    .HasMaxLength(512)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasMaxLength(48)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<GiftSeries>(entity =>
            {
                entity.Property(e => e.GiftSeriesId)
                    .HasColumnName("GiftSeriesID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DiscountFlags)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.Prefix).HasMaxLength(16);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SeriesName).HasMaxLength(32);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Suffix).HasMaxLength(16);
            });

            modelBuilder.Entity<GiftSeriesAvailability>(entity =>
            {
                entity.ToTable("GiftSeriesAvailability");

                entity.HasIndex(e => e.GiftSeriesId, "IX_GiftSeriesAvailability")
                    .HasFillFactor(90);

                entity.Property(e => e.GiftSeriesAvailabilityId)
                    .HasColumnName("GiftSeriesAvailabilityID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GiftSeriesId).HasColumnName("GiftSeriesID");

                entity.HasOne(d => d.GiftSeries)
                    .WithMany(p => p.GiftSeriesAvailabilities)
                    .HasForeignKey(d => d.GiftSeriesId)
                    .HasConstraintName("FK_GiftSeriesAvailability_GiftSeries");
            });

            modelBuilder.Entity<GiftSeriesObject>(entity =>
            {
                entity.ToTable("GiftSeriesObject");

                entity.HasIndex(e => e.GiftSeriesId, "IX_GiftSeriesObject")
                    .HasFillFactor(90);

                entity.Property(e => e.GiftSeriesObjectId)
                    .HasColumnName("GiftSeriesObjectID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Data).HasMaxLength(80);

                entity.Property(e => e.FontName).HasMaxLength(30);

                entity.Property(e => e.GiftSeriesId).HasColumnName("GiftSeriesID");

                entity.HasOne(d => d.GiftSeries)
                    .WithMany(p => p.GiftSeriesObjects)
                    .HasForeignKey(d => d.GiftSeriesId)
                    .HasConstraintName("FK_GiftSeriesObject_GiftSeries");
            });

            modelBuilder.Entity<GiftUsed>(entity =>
            {
                entity.ToTable("GiftUsed");

                entity.Property(e => e.GiftUsedId)
                    .HasColumnName("GiftUsedID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GiftId).HasColumnName("GiftID");

                entity.HasOne(d => d.Gift)
                    .WithMany(p => p.GiftUseds)
                    .HasForeignKey(d => d.GiftId)
                    .HasConstraintName("FK_GiftUsed_Gift");
            });

            modelBuilder.Entity<GlobalCashier>(entity =>
            {
                entity.ToTable("GlobalCashier");

                entity.Property(e => e.GlobalCashierId)
                    .ValueGeneratedNever()
                    .HasColumnName("GlobalCashierID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<GrandTotal>(entity =>
            {
                entity.ToTable("GrandTotal");

                entity.Property(e => e.GrandTotalId)
                    .HasColumnName("GrandTotalID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalNumber).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<Graphic>(entity =>
            {
                entity.ToTable("Graphic");

                entity.Property(e => e.GraphicId)
                    .HasColumnName("GraphicID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GraphicName).HasMaxLength(20);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<Help>(entity =>
            {
                entity.ToTable("Help");

                entity.Property(e => e.HelpId)
                    .HasColumnName("HelpID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.HelpName).HasMaxLength(20);

                entity.Property(e => e.HelpText).HasMaxLength(2021);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient");

                entity.Property(e => e.IngredientId)
                    .HasColumnName("IngredientID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CaseName).HasMaxLength(12);

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.IngredientDescription).HasMaxLength(32);

                entity.Property(e => e.IngredientName).HasMaxLength(32);

                entity.Property(e => e.PackageName).HasMaxLength(12);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Vendor).HasMaxLength(20);
            });

            modelBuilder.Entity<IngredientInventory>(entity =>
            {
                entity.ToTable("IngredientInventory");

                entity.HasIndex(e => e.IngredientId, "IX_IngredientInventory")
                    .HasFillFactor(90);

                entity.Property(e => e.IngredientInventoryId)
                    .HasColumnName("IngredientInventoryID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IngredientId).HasColumnName("IngredientID");

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.IngredientInventories)
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("FK_IngredientInventory_Ingredient");
            });

            modelBuilder.Entity<InternetCreditBatch>(entity =>
            {
                entity.HasKey(e => e.InternetBatchId);

                entity.ToTable("InternetCreditBatch");

                entity.HasIndex(e => e.DataVersion, "IX_InternetCreditBatch_DataVersion")
                    .HasFillFactor(90);

                entity.Property(e => e.InternetBatchId)
                    .HasColumnName("InternetBatchID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(512)
                    .IsFixedLength();

                entity.Property(e => e.ApprovalCode)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .HasColumnName("MerchantID")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceData)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Track2)
                    .HasMaxLength(48)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InternetCreditBatchArchive>(entity =>
            {
                entity.HasKey(e => e.CreditBatchArchiveId)
                    .HasName("PK_CreditBatchArchive");

                entity.ToTable("InternetCreditBatchArchive");

                entity.Property(e => e.CreditBatchArchiveId)
                    .ValueGeneratedNever()
                    .HasColumnName("CreditBatchArchiveID");

                entity.Property(e => e.BatchDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .HasColumnName("MerchantID")
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<InternetCreditBatchInfo>(entity =>
            {
                entity.ToTable("InternetCreditBatchInfo");

                entity.Property(e => e.InternetCreditBatchInfoId)
                    .HasColumnName("InternetCreditBatchInfoID")
                    .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<InvoiceConfig>(entity =>
            {
                entity.ToTable("InvoiceConfig");

                entity.Property(e => e.InvoiceConfigId)
                    .HasColumnName("InvoiceConfigID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<InvoiceConfigObject>(entity =>
            {
                entity.ToTable("InvoiceConfigObject");

                entity.HasIndex(e => e.InvoiceConfigId, "IX_InvoiceConfigObject")
                    .HasFillFactor(90);

                entity.Property(e => e.InvoiceConfigObjectId)
                    .HasColumnName("InvoiceConfigObjectID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Data).HasMaxLength(80);

                entity.Property(e => e.Font).HasMaxLength(30);

                entity.Property(e => e.InvoiceConfigId).HasColumnName("InvoiceConfigID");

                entity.HasOne(d => d.InvoiceConfig)
                    .WithMany(p => p.InvoiceConfigObjects)
                    .HasForeignKey(d => d.InvoiceConfigId)
                    .HasConstraintName("FK_InvoiceConfigObject_InvoiceConfig");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.HasIndex(e => new { e.ItemName, e.RegionId }, "IX_Item")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AlternateItem).HasMaxLength(32);

                entity.Property(e => e.AskId).HasColumnName("AskID");

                entity.Property(e => e.AutoMenuEndDate).HasColumnType("datetime");

                entity.Property(e => e.AutoMenuStartDate).HasColumnType("datetime");

                entity.Property(e => e.BergPlu).HasColumnName("BergPLU");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.DiscountFlags)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.DisplayDescription).HasMaxLength(140);

                entity.Property(e => e.HhcolumnCount).HasColumnName("HHColumnCount");

                entity.Property(e => e.ItemDescription).HasMaxLength(30);

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ItemSizeId).HasColumnName("ItemSizeID");

                entity.Property(e => e.MobileAskId).HasColumnName("MobileAskID");

                entity.Property(e => e.MobileMessageId).HasColumnName("MobileMessageID");

                entity.Property(e => e.ModifierDescription).HasMaxLength(30);

                entity.Property(e => e.OverrideAutoMenuButtonSettingsGraphic).HasMaxLength(50);

                entity.Property(e => e.ParentItemId).HasColumnName("ParentItemID");

                entity.Property(e => e.ReceiptDesc).HasMaxLength(20);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ShipHeight).HasMaxLength(5);

                entity.Property(e => e.ShipLength)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShipWidth).HasMaxLength(5);

                entity.Property(e => e.ShortDescription).HasMaxLength(5);

                entity.Property(e => e.Upc)
                    .HasMaxLength(32)
                    .HasColumnName("UPC");

                entity.Property(e => e.Vducolor).HasColumnName("VDUColor");

                entity.Property(e => e.Vduid).HasColumnName("VDUID");

                entity.Property(e => e.WebDepartmentId).HasColumnName("WebDepartmentID");

                entity.Property(e => e.WebImagePath).HasMaxLength(254);

                entity.Property(e => e.WebThumbPath).HasMaxLength(254);

                entity.Property(e => e.WebTitle).HasMaxLength(30);
            });

            modelBuilder.Entity<ItemDay>(entity =>
            {
                entity.ToTable("ItemDay");

                entity.HasIndex(e => e.ItemId, "IX_ItemDay")
                    .HasFillFactor(90);

                entity.Property(e => e.ItemDayId)
                    .HasColumnName("ItemDayID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<ItemIngredient>(entity =>
            {
                entity.ToTable("ItemIngredient");

                entity.HasIndex(e => e.ItemId, "IX_ItemIngredient")
                    .HasFillFactor(90);

                entity.Property(e => e.ItemIngredientId)
                    .HasColumnName("ItemIngredientID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IngredientName).HasMaxLength(33);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemIngredients)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemIngredient_Item");
            });

            modelBuilder.Entity<ItemMobileExclusion>(entity =>
            {
                entity.ToTable("ItemMobileExclusion");

                entity.HasIndex(e => e.EmpId, "IX_ItemMobileExclusion_EmpID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ItemId, "IX_ItemMobileExclusion_ItemID")
                    .HasFillFactor(90);

                entity.Property(e => e.ItemMobileExclusionId)
                    .HasColumnName("ItemMobileExclusionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemMobileExclusions)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemMobileExclusion_Item");
            });

            modelBuilder.Entity<ItemModifier>(entity =>
            {
                entity.ToTable("ItemModifier");

                entity.HasIndex(e => e.ItemId, "IX_ItemModifier")
                    .HasFillFactor(90);

                entity.Property(e => e.ItemModifierId)
                    .HasColumnName("ItemModifierID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ModifierName).HasMaxLength(33);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemModifiers)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemModifier_Item");
            });

            modelBuilder.Entity<ItemPrice>(entity =>
            {
                entity.ToTable("ItemPrice");

                entity.HasIndex(e => e.ItemId, "IX_ItemPrice")
                    .HasFillFactor(90);

                entity.Property(e => e.ItemPriceId)
                    .HasColumnName("ItemPriceID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPrices)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemPriceSchedule_Item");
            });

            modelBuilder.Entity<ItemPrinter>(entity =>
            {
                entity.ToTable("ItemPrinter");

                entity.HasIndex(e => e.ItemId, "IX_ItemPrinter")
                    .HasFillFactor(90);

                entity.Property(e => e.ItemPrinterId)
                    .HasColumnName("ItemPrinterID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPrinters)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemPrinter_Item");
            });

            modelBuilder.Entity<ItemRank>(entity =>
            {
                entity.ToTable("ItemRank");

                entity.Property(e => e.ItemRankId)
                    .ValueGeneratedNever()
                    .HasColumnName("ItemRankID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<ItemSize>(entity =>
            {
                entity.ToTable("ItemSize");

                entity.Property(e => e.ItemSizeId)
                    .HasColumnName("ItemSizeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemDescriptionPrefix)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceiptDescriptionPrefix)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<ItemSold>(entity =>
            {
                entity.ToTable("ItemSold");

                entity.Property(e => e.ItemSoldId)
                    .HasColumnName("ItemSoldID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Department).HasMaxLength(11);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ItemDescription).HasMaxLength(31);

                entity.Property(e => e.ItemName).HasMaxLength(33);

                entity.Property(e => e.SoldDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");
            });

            modelBuilder.Entity<ItemTranslation>(entity =>
            {
                entity.ToTable("ItemTranslation");

                entity.Property(e => e.ItemTranslationId)
                    .HasColumnName("ItemTranslationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemTranslations)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemTranslation_Item");
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.ToTable("Layout");

                entity.Property(e => e.LayoutId)
                    .HasColumnName("LayoutID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LayoutGraphic>(entity =>
            {
                entity.ToTable("LayoutGraphic");

                entity.HasIndex(e => e.LayoutId, "IX_LayoutGraphic")
                    .HasFillFactor(90);

                entity.Property(e => e.LayoutGraphicId)
                    .HasColumnName("LayoutGraphicID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutGraphics)
                    .HasForeignKey(d => d.LayoutId)
                    .HasConstraintName("FK_LayoutGraphic_Layout");
            });

            modelBuilder.Entity<LayoutRoom>(entity =>
            {
                entity.ToTable("LayoutRoom");

                entity.HasIndex(e => e.LayoutId, "IX_LayoutRoom")
                    .HasFillFactor(90);

                entity.Property(e => e.LayoutRoomId)
                    .HasColumnName("LayoutRoomID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ImageFile).HasMaxLength(128);

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.RoomName).HasMaxLength(20);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutRooms)
                    .HasForeignKey(d => d.LayoutId)
                    .HasConstraintName("FK_LayoutRoom_Layout");
            });

            modelBuilder.Entity<LayoutSection>(entity =>
            {
                entity.ToTable("LayoutSection");

                entity.HasIndex(e => e.LayoutId, "IX_LayoutSection")
                    .HasFillFactor(90);

                entity.Property(e => e.LayoutSectionId)
                    .HasColumnName("LayoutSectionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CalcGratuityWdiscounts).HasColumnName("CalcGratuityWDiscounts");

                entity.Property(e => e.CommonMenuName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CustomerRequiredFields).HasMaxLength(512);

                entity.Property(e => e.ForceOrderEmpId).HasColumnName("ForceOrderEmpID");

                entity.Property(e => e.HandheldCommonMenuName)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HandheldHomeMenuName).HasMaxLength(20);

                entity.Property(e => e.HomeMenuName).HasMaxLength(20);

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.SectionName).HasMaxLength(20);

                entity.Property(e => e.SkipModsMask).HasMaxLength(32);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutSections)
                    .HasForeignKey(d => d.LayoutId)
                    .HasConstraintName("FK_LayoutSection_Layout");
            });

            modelBuilder.Entity<LayoutTable>(entity =>
            {
                entity.ToTable("LayoutTable");

                entity.HasIndex(e => e.LayoutId, "IX_LayoutTable")
                    .HasFillFactor(90);

                entity.Property(e => e.LayoutTableId)
                    .HasColumnName("LayoutTableID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IsX10enabled).HasColumnName("IsX10Enabled");

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.X10deviceCode).HasColumnName("X10DeviceCode");

                entity.Property(e => e.X10houseCode).HasColumnName("X10HouseCode");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutTables)
                    .HasForeignKey(d => d.LayoutId)
                    .HasConstraintName("FK_LayoutTable_Layout");
            });

            modelBuilder.Entity<LayoutText>(entity =>
            {
                entity.ToTable("LayoutText");

                entity.HasIndex(e => e.LayoutId, "IX_LayoutText")
                    .HasFillFactor(90);

                entity.Property(e => e.LayoutTextId)
                    .HasColumnName("LayoutTextID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontFaceName).HasMaxLength(32);

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.Text).HasMaxLength(65);

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutTexts)
                    .HasForeignKey(d => d.LayoutId)
                    .HasConstraintName("FK_LayoutText_Layout");
            });

            modelBuilder.Entity<LocalSuspend>(entity =>
            {
                entity.HasKey(e => e.TerminalNumber);

                entity.ToTable("LocalSuspend");

                entity.Property(e => e.TerminalNumber).ValueGeneratedNever();
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.HasIndex(e => e.LogDate, "IX_Log")
                    .HasFillFactor(90);

                entity.Property(e => e.LogId)
                    .HasColumnName("LogID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Application).HasMaxLength(64);

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message).HasMaxLength(4000);
            });

            modelBuilder.Entity<LogConfig>(entity =>
            {
                entity.ToTable("LogConfig");

                entity.Property(e => e.LogConfigId)
                    .HasColumnName("LogConfigID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Application)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogLevel).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MediaTranslation>(entity =>
            {
                entity.ToTable("MediaTranslation");

                entity.Property(e => e.MediaTranslationId)
                    .HasColumnName("MediaTranslationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.MediaId).HasColumnName("MediaID");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.MediaTranslations)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK_MediaTranslation_Media");
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.HasKey(e => e.MediaId);

                entity.HasIndex(e => e.RegionId, "IX_Media")
                    .HasFillFactor(90);

                entity.Property(e => e.MediaId)
                    .HasColumnName("MediaID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AllowedTerminals).HasMaxLength(13);

                entity.Property(e => e.FontFaceName).HasMaxLength(32);

                entity.Property(e => e.MediaName).HasMaxLength(20);

                entity.Property(e => e.NeedCv2).HasColumnName("NeedCV2");

                entity.Property(e => e.Pmsaccount)
                    .HasMaxLength(20)
                    .HasColumnName("PMSAccount");

                entity.Property(e => e.PmsmediaNum).HasColumnName("PMSMediaNum");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<MenuHomePageLink>(entity =>
            {
                entity.HasKey(e => e.HomePageLinkId)
                    .HasName("PK_HomePageLink");

                entity.ToTable("MenuHomePageLink");

                entity.Property(e => e.HomePageLinkId)
                    .HasColumnName("HomePageLinkID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.MenuPageId).HasColumnName("MenuPageID");

                entity.HasOne(d => d.MenuPage)
                    .WithMany(p => p.MenuHomePageLinks)
                    .HasForeignKey(d => d.MenuPageId)
                    .HasConstraintName("FK_MenuHomePageLink_MenuPage");
            });

            modelBuilder.Entity<MenuPage>(entity =>
            {
                entity.ToTable("MenuPage");

                entity.Property(e => e.MenuPageId)
                    .HasColumnName("MenuPageID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AssignedUser).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.PageName).HasMaxLength(250);

                entity.Property(e => e.SavedXml)
                    .HasColumnName("SavedXML")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<MenuPageGroup>(entity =>
            {
                entity.ToTable("MenuPageGroup");

                entity.Property(e => e.MenuPageGroupId)
                    .HasColumnName("MenuPageGroupID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(450);

                entity.Property(e => e.MenuPageId).HasColumnName("MenuPageID");

                entity.Property(e => e.ParentMenuPageGroupId).HasColumnName("ParentMenuPageGroupID");

                entity.HasOne(d => d.MenuPage)
                    .WithMany(p => p.MenuPageGroups)
                    .HasForeignKey(d => d.MenuPageId)
                    .HasConstraintName("FK_MenuPageGroup_MenuPage");
            });

            modelBuilder.Entity<MenuPageItem>(entity =>
            {
                entity.ToTable("MenuPageItem");

                entity.Property(e => e.MenuPageItemId)
                    .HasColumnName("MenuPageItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ClassColumnName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.Executable).HasMaxLength(2000);

                entity.Property(e => e.ItemName).HasMaxLength(450);

                entity.Property(e => e.MenuPageGroupId).HasColumnName("MenuPageGroupID");
            });

            modelBuilder.Entity<MenuPageLink>(entity =>
            {
                entity.ToTable("MenuPageLink");

                entity.Property(e => e.MenuPageLinkId)
                    .HasColumnName("MenuPageLinkID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.MenuPageGroupId).HasColumnName("MenuPageGroupID");

                entity.Property(e => e.MenuPageItemId).HasColumnName("MenuPageItemID");

                entity.Property(e => e.NameReplace).HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(1000);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.MessageDate).HasColumnType("datetime");

                entity.Property(e => e.MessageName).HasMaxLength(20);

                entity.Property(e => e.MessageStartDate).HasColumnType("datetime");

                entity.Property(e => e.MessageText).HasMaxLength(468);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<MessageEmployee>(entity =>
            {
                entity.ToTable("MessageEmployee");

                entity.HasIndex(e => e.MessageId, "IX_MessageEmployee")
                    .HasFillFactor(90);

                entity.Property(e => e.MessageEmployeeId)
                    .HasColumnName("MessageEmployeeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageEmployees)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_MessageEmployee_Message");
            });

            modelBuilder.Entity<MobileFunctionPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("MobileFunctionPermission");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AskForSupervisorId).HasColumnName("AskForSupervisorID");

                entity.Property(e => e.FunctionName).HasMaxLength(50);
            });

            modelBuilder.Entity<MobileMessage>(entity =>
            {
                entity.ToTable("MobileMessage");

                entity.Property(e => e.MobileMessageId)
                    .ValueGeneratedNever()
                    .HasColumnName("MobileMessageID");

                entity.Property(e => e.MessageText).HasMaxLength(200);
            });

            modelBuilder.Entity<MobileTerminal>(entity =>
            {
                entity.HasKey(e => e.MobileTerminalId)
                    .IsClustered(false);

                entity.ToTable("MobileTerminal");

                entity.Property(e => e.MobileTerminalId)
                    .ValueGeneratedNever()
                    .HasColumnName("MobileTerminalID");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.SyncId).HasColumnName("SyncID");
            });

            modelBuilder.Entity<MobileTerminalSessionInfo>(entity =>
            {
                entity.ToTable("MobileTerminalSessionInfo");

                entity.HasIndex(e => e.SessionId, "IX_MobileTerminalSessionInfo_SessionID")
                    .IsUnique();

                entity.Property(e => e.MobileTerminalSessionInfoId)
                    .HasColumnName("MobileTerminalSessionInfoID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BinaryData).HasMaxLength(2048);

                entity.Property(e => e.BinaryData2).HasMaxLength(2048);

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.MobileTerminalId).HasColumnName("MobileTerminalID");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(21)
                    .HasColumnName("SessionID")
                    .IsFixedLength();

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.HasOne(d => d.MobileTerminal)
                    .WithMany(p => p.MobileTerminalSessionInfos)
                    .HasForeignKey(d => d.MobileTerminalId)
                    .HasConstraintName("FK_MobileTerminalSessionInfo_MobileTerminalID");
            });

            modelBuilder.Entity<MobileTerminalTransaction>(entity =>
            {
                entity.ToTable("MobileTerminalTransaction");

                entity.Property(e => e.MobileTerminalTransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("MobileTerminalTransactionID");

                entity.Property(e => e.Response).HasMaxLength(2048);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(21)
                    .HasColumnName("SessionID")
                    .IsFixedLength();

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            });

            modelBuilder.Entity<MobileTerminalTransfer>(entity =>
            {
                entity.ToTable("MobileTerminalTransfer");

                entity.Property(e => e.MobileTerminalTransferId)
                    .HasColumnName("MobileTerminalTransferID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Data).HasColumnType("ntext");

                entity.Property(e => e.DbrecordId).HasColumnName("DBRecordID");

                entity.Property(e => e.DbtableNumber).HasColumnName("DBTableNumber");

                entity.Property(e => e.FromStoreId).HasColumnName("FromStoreID");

                entity.Property(e => e.ToStoreId).HasColumnName("ToStoreID");
            });

            modelBuilder.Entity<OfflineLoyaltyQueue>(entity =>
            {
                entity.ToTable("OfflineLoyaltyQueue");

                entity.Property(e => e.OfflineLoyaltyQueueId)
                    .HasColumnName("OfflineLoyaltyQueueID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.HasKey(e => e.OrderTypeIndex);

                entity.Property(e => e.OrderTypeIndex).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ShippingServiceType)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.WebDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<Pager>(entity =>
            {
                entity.ToTable("Pager");

                entity.Property(e => e.PagerId)
                    .HasColumnName("PagerID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.PagerDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<PagerEmployee>(entity =>
            {
                entity.ToTable("PagerEmployee");

                entity.Property(e => e.PagerEmployeeId)
                    .HasColumnName("PagerEmployeeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PagerId).HasColumnName("PagerID");

                entity.HasOne(d => d.Pager)
                    .WithMany(p => p.PagerEmployees)
                    .HasForeignKey(d => d.PagerId)
                    .HasConstraintName("FK_PagerEmployee_Pager");
            });

            modelBuilder.Entity<PagerMessageQueue>(entity =>
            {
                entity.ToTable("PagerMessageQueue");

                entity.Property(e => e.PagerMessageQueueId)
                    .HasColumnName("PagerMessageQueueID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message).HasMaxLength(512);

                entity.Property(e => e.PagerId).HasColumnName("PagerID");

                entity.HasOne(d => d.Pager)
                    .WithMany(p => p.PagerMessageQueues)
                    .HasForeignKey(d => d.PagerId)
                    .HasConstraintName("FK_PagerMessageQueue_Pager");
            });

            modelBuilder.Entity<Palert>(entity =>
            {
                entity.HasKey(e => e.AlertId);

                entity.ToTable("PAlert");

                entity.Property(e => e.AlertId)
                    .ValueGeneratedNever()
                    .HasColumnName("AlertID");

                entity.Property(e => e.AlertName).HasMaxLength(100);

                entity.Property(e => e.AlertType).HasMaxLength(50);

                entity.Property(e => e.LastRun).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<PalertQueue>(entity =>
            {
                entity.HasKey(e => e.AlertQueueId);

                entity.ToTable("PAlertQueue");

                entity.Property(e => e.AlertQueueId)
                    .ValueGeneratedNever()
                    .HasColumnName("AlertQueueID");

                entity.Property(e => e.AlertId).HasColumnName("AlertID");

                entity.Property(e => e.AltBodyMimeType).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(254);

                entity.Property(e => e.QueueDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(200);
            });

            modelBuilder.Entity<PalertSetting>(entity =>
            {
                entity.HasKey(e => e.AlertSettingId);

                entity.ToTable("PAlertSetting");

                entity.Property(e => e.AlertSettingId)
                    .ValueGeneratedNever()
                    .HasColumnName("AlertSettingID");

                entity.Property(e => e.AlertId).HasColumnName("AlertID");

                entity.Property(e => e.Setting).HasMaxLength(50);

                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.PalertSettings)
                    .HasForeignKey(d => d.AlertId)
                    .HasConstraintName("FK_PAlertSetting_PAlert");
            });

            modelBuilder.Entity<PalertTo>(entity =>
            {
                entity.HasKey(e => e.AlertEmpId)
                    .HasName("PK_PAlertEmp");

                entity.ToTable("PAlertTo");

                entity.Property(e => e.AlertEmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("AlertEmpID");

                entity.Property(e => e.AlertId).HasColumnName("AlertID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.PalertTos)
                    .HasForeignKey(d => d.AlertId)
                    .HasConstraintName("FK_PAlertTo_PAlert");
            });

            modelBuilder.Entity<Paydiant>(entity =>
            {
                entity.ToTable("Paydiant");

                entity.Property(e => e.PaydiantId)
                    .HasColumnName("PaydiantID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GatewayUrl)
                    .HasMaxLength(255)
                    .HasColumnName("GatewayURL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantKey)
                    .HasMaxLength(264)
                    .IsFixedLength();

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.StoreLocationId)
                    .HasMaxLength(255)
                    .HasColumnName("StoreLocationID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(8)
                    .HasColumnName("TerminalID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("WebServiceURL")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PendingSale>(entity =>
            {
                entity.ToTable("PendingSale");

                entity.Property(e => e.PendingSaleId)
                    .ValueGeneratedNever()
                    .HasColumnName("PendingSaleID");

                entity.Property(e => e.AuthCardName)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.AuthCardNumber)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.AuthCardNumberEncrypted)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.AuthCardType)
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.AuthCv2).HasColumnName("AuthCV2");

                entity.Property(e => e.AuthCv2strEncrypted)
                    .HasMaxLength(384)
                    .HasColumnName("AuthCV2StrEncrypted")
                    .IsFixedLength();

                entity.Property(e => e.AuthEncryptedBlock)
                    .HasMaxLength(233)
                    .IsFixedLength();

                entity.Property(e => e.AuthEncryptionKey)
                    .HasMaxLength(41)
                    .IsFixedLength();

                entity.Property(e => e.AuthExpirationDateEncrypted)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.AuthIsE2eencryption).HasColumnName("AuthIsE2EEncryption");

                entity.Property(e => e.AuthMsrswipe)
                    .HasMaxLength(512)
                    .HasColumnName("AuthMSRSwipe")
                    .IsFixedLength();

                entity.Property(e => e.AuthReferenceData)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AuthReferenceNumber)
                    .HasMaxLength(17)
                    .IsFixedLength();

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AuthTrack2Encrypted)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DoingRoa).HasColumnName("DoingROA");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MsrencryptionType).HasColumnName("MSREncryptionType");

                entity.Property(e => e.PublicKey)
                    .HasMaxLength(2048)
                    .IsFixedLength();

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.Salt)
                    .HasMaxLength(384)
                    .IsFixedLength();

                entity.Property(e => e.SessionId)
                    .HasMaxLength(21)
                    .HasColumnName("SessionID")
                    .IsFixedLength();

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            });

            modelBuilder.Entity<Posday>(entity =>
            {
                entity.ToTable("POSDay");

                entity.Property(e => e.PosdayId)
                    .ValueGeneratedNever()
                    .HasColumnName("POSDayID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndEmpId).HasColumnName("EndEmpID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartEmpId).HasColumnName("StartEmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<Posshift>(entity =>
            {
                entity.ToTable("POSShift");

                entity.Property(e => e.PosshiftId)
                    .HasColumnName("POSShiftID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndEmpId).HasColumnName("EndEmpID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartEmpId).HasColumnName("StartEmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<PreAuth>(entity =>
            {
                entity.ToTable("PreAuth");

                entity.HasIndex(e => e.DataVersion, "IX_PreAuth_DataVersion")
                    .HasFillFactor(90);

                entity.Property(e => e.PreAuthId)
                    .HasColumnName("PreAuthID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AcqRefData)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.Emvaid)
                    .HasMaxLength(48)
                    .HasColumnName("EMVAID")
                    .IsFixedLength();

                entity.Property(e => e.EmvapplicationData)
                    .HasMaxLength(48)
                    .HasColumnName("EMVApplicationData")
                    .IsFixedLength();

                entity.Property(e => e.Emvarc)
                    .HasMaxLength(48)
                    .HasColumnName("EMVARC")
                    .IsFixedLength();

                entity.Property(e => e.Emvcvm)
                    .HasMaxLength(48)
                    .HasColumnName("EMVCVM")
                    .IsFixedLength();

                entity.Property(e => e.EmventryMethod)
                    .HasMaxLength(48)
                    .HasColumnName("EMVEntryMethod")
                    .IsFixedLength();

                entity.Property(e => e.Emviad)
                    .HasMaxLength(48)
                    .HasColumnName("EMVIAD")
                    .IsFixedLength();

                entity.Property(e => e.Emvtsi)
                    .HasMaxLength(48)
                    .HasColumnName("EMVTSI")
                    .IsFixedLength();

                entity.Property(e => e.Emvtvr)
                    .HasMaxLength(48)
                    .HasColumnName("EMVTVR")
                    .IsFixedLength();

                entity.Property(e => e.EncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.EncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.IsE2eencryption).HasColumnName("IsE2EEncryption");

                entity.Property(e => e.PreAuthDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Track2)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.VaultId)
                    .HasMaxLength(128)
                    .HasColumnName("VaultID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<PrepTime>(entity =>
            {
                entity.ToTable("PrepTime");

                entity.Property(e => e.PrepTimeId)
                    .HasColumnName("PrepTimeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<PriceLevel>(entity =>
            {
                entity.ToTable("PriceLevel");

                entity.Property(e => e.PriceLevelId)
                    .ValueGeneratedNever()
                    .HasColumnName("PriceLevelID");

                entity.Property(e => e.PriceLevelName).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<PriceSchedule>(entity =>
            {
                entity.ToTable("PriceSchedule");

                entity.Property(e => e.PriceScheduleId)
                    .HasColumnName("PriceScheduleID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.PriceScheduleName).HasMaxLength(30);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<PrintJob>(entity =>
            {
                entity.ToTable("PrintJob");

                entity.HasIndex(e => new { e.ToTerminalNumber, e.OnHold, e.StoreId }, "IX_PrintJob")
                    .HasFillFactor(90);

                entity.Property(e => e.PrintJobId)
                    .HasColumnName("PrintJobID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CheckDescription).HasMaxLength(15);

                entity.Property(e => e.CheckStartDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmployeeName).HasMaxLength(64);

                entity.Property(e => e.PrintDate).HasColumnType("datetime");

                entity.Property(e => e.RerouteDescription).HasMaxLength(33);

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TableDescription).HasMaxLength(32);
            });

            modelBuilder.Entity<PrintJobLine>(entity =>
            {
                entity.HasKey(e => e.PrintLineId)
                    .HasName("PK_PrintQueueLine");

                entity.ToTable("PrintJobLine");

                entity.HasIndex(e => e.PrintJobId, "IX_PrintJobLine")
                    .HasFillFactor(90);

                entity.Property(e => e.PrintLineId)
                    .HasColumnName("PrintLineID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BergPlu).HasColumnName("BergPLU");

                entity.Property(e => e.ItemName).HasMaxLength(33);

                entity.Property(e => e.LeftText).HasMaxLength(128);

                entity.Property(e => e.Peplu).HasColumnName("PEPLU");

                entity.Property(e => e.PrintJobId).HasColumnName("PrintJobID");

                entity.Property(e => e.RightText).HasMaxLength(128);

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItemID");

                entity.Property(e => e.SaleTenderId).HasColumnName("SaleTenderID");

                entity.Property(e => e.SeparatedText)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignatureId).HasColumnName("SignatureID");

                entity.Property(e => e.Text).HasMaxLength(128);

                entity.Property(e => e.Vducolor).HasColumnName("VDUColor");

                entity.HasOne(d => d.PrintJob)
                    .WithMany(p => p.PrintJobLines)
                    .HasForeignKey(d => d.PrintJobId)
                    .HasConstraintName("FK_PrintJobLine_PrintJob");
            });

            modelBuilder.Entity<Reason>(entity =>
            {
                entity.ToTable("Reason");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("ReasonID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReasonName).HasMaxLength(32);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<ReceiptFormat>(entity =>
            {
                entity.ToTable("ReceiptFormat");

                entity.Property(e => e.ReceiptFormatId)
                    .HasColumnName("ReceiptFormatID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<ReceiptFormatItem>(entity =>
            {
                entity.ToTable("ReceiptFormatItem");

                entity.Property(e => e.ReceiptFormatItemId)
                    .HasColumnName("ReceiptFormatItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ReceiptFormatId).HasColumnName("ReceiptFormatID");

                entity.Property(e => e.ReceiptName).HasMaxLength(50);

                entity.HasOne(d => d.ReceiptFormat)
                    .WithMany(p => p.ReceiptFormatItems)
                    .HasForeignKey(d => d.ReceiptFormatId)
                    .HasConstraintName("FK_ReceiptFormatItem_ReceiptFormat");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("Recipe");

                entity.Property(e => e.RecipeId)
                    .HasColumnName("RecipeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.Recipe1)
                    .HasMaxLength(1000)
                    .HasColumnName("Recipe");

                entity.Property(e => e.RecipeName).HasMaxLength(32);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("Region");

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Area).HasMaxLength(30);

                entity.Property(e => e.RegionDescription).HasMaxLength(32);

                entity.Property(e => e.RegionName).HasMaxLength(50);
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.HasIndex(e => new { e.StoreId, e.ReservationDate }, "IX_Reservation_Store_Date")
                    .HasFillFactor(90);

                entity.Property(e => e.ReservationId)
                    .HasColumnName("ReservationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CustomerName).HasMaxLength(64);

                entity.Property(e => e.LongNote).HasMaxLength(512);

                entity.Property(e => e.Note).HasMaxLength(20);

                entity.Property(e => e.ReservationDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<ResourceLanguage>(entity =>
            {
                entity.ToTable("ResourceLanguage");

                entity.Property(e => e.ResourceLanguageId)
                    .HasColumnName("ResourceLanguageID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Value).HasMaxLength(4000);
            });

            modelBuilder.Entity<RewardPlan>(entity =>
            {
                entity.ToTable("RewardPlan");

                entity.Property(e => e.RewardPlanId)
                    .HasColumnName("RewardPlanID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RewardPlanName).HasMaxLength(20);
            });

            modelBuilder.Entity<RewardPlanLevel>(entity =>
            {
                entity.ToTable("RewardPlanLevel");

                entity.HasIndex(e => e.RewardPlanId, "IX_RewardPlanLevel")
                    .HasFillFactor(90);

                entity.Property(e => e.RewardPlanLevelId)
                    .HasColumnName("RewardPlanLevelID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemMask).HasMaxLength(32);

                entity.Property(e => e.RewardPlanId).HasColumnName("RewardPlanID");

                entity.Property(e => e.SkipDepartmentMask).HasMaxLength(50);

                entity.HasOne(d => d.RewardPlan)
                    .WithMany(p => p.RewardPlanLevels)
                    .HasForeignKey(d => d.RewardPlanId)
                    .HasConstraintName("FK_RewardPlanLevel_RewardPlan");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("Sale");

                entity.HasIndex(e => new { e.StoreId, e.IsSuspend }, "IX_Sale")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CheckNumber, "IX_Sale_CheckNumber")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CurrentEmpId, "IX_Sale_CurrentEmpID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DataVersion, "IX_Sale_DataVersion")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.EndDate, "IX_Sale_FinishDate")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.IsSuspend, "IX_Sale_IsSuspend")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ReOpenCheckNumber, "IX_Sale_ReOpenCheckNumber")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StartDate, "IX_Sale_StartDate")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.StoreId, e.IsSuspend, e.CurrentEmpId }, "IX_Sale_SuspendList")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SuspendNumber, "IX_Sale_SuspendNumber")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.IsSuspend, e.TerminalNumber }, "IX_Sale_TerminalSuspends");

                entity.Property(e => e.SaleId)
                    .HasColumnName("SaleID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AssignDriverDate).HasColumnType("datetime");

                entity.Property(e => e.CheckDescription).HasMaxLength(50);

                entity.Property(e => e.CurrentEmpId).HasColumnName("CurrentEmpID");

                entity.Property(e => e.CustomerAddress).HasMaxLength(65);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FtaxToggle).HasColumnName("FTaxToggle");

                entity.Property(e => e.Idprovided).HasColumnName("IDProvided");

                entity.Property(e => e.IsWebOrderComplete).HasComment("");

                entity.Property(e => e.LevelUpOrderId).HasColumnName("LevelUpOrderID");

                entity.Property(e => e.LevelUpUuid)
                    .HasMaxLength(64)
                    .HasColumnName("LevelUpUUID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoSboutput).HasColumnName("NoSBOutput");

                entity.Property(e => e.NoSmartVat).HasColumnName("NoSmartVAT");

                entity.Property(e => e.OrderTakerEmpId).HasColumnName("OrderTakerEmpID");

                entity.Property(e => e.PaydiantCheckoutToken)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaydiantTransactionRefId)
                    .HasMaxLength(255)
                    .HasColumnName("PaydiantTransactionRefID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pmscount).HasColumnName("PMSCount");

                entity.Property(e => e.PreAuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.PreCardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreCardNum)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreEmvaid)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVAID")
                    .IsFixedLength();

                entity.Property(e => e.PreEmvapplicationLabel)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVApplicationLabel")
                    .IsFixedLength();

                entity.Property(e => e.PreEmvarc)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVARC")
                    .IsFixedLength();

                entity.Property(e => e.PreEmvcvm)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVCVM")
                    .IsFixedLength();

                entity.Property(e => e.PreEmventryMethod)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVEntryMethod")
                    .IsFixedLength();

                entity.Property(e => e.PreEmviad)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVIAD")
                    .IsFixedLength();

                entity.Property(e => e.PreEmvtsi)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVTSI")
                    .IsFixedLength();

                entity.Property(e => e.PreEmvtvr)
                    .HasMaxLength(48)
                    .HasColumnName("PreEMVTVR")
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.PreEncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.PreExpirationDate)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.PreIsE2eencryption).HasColumnName("PreIsE2EEncryption");

                entity.Property(e => e.PreProcessData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreReferenceData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.PreTrack2)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.PreVaultId)
                    .HasMaxLength(128)
                    .HasColumnName("PreVaultID")
                    .IsFixedLength();

                entity.Property(e => e.PreZip)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.PromisedDate).HasColumnType("datetime");

                entity.Property(e => e.PsubTotal).HasColumnName("PSubTotal");

                entity.Property(e => e.PzeroRated).HasColumnName("PZeroRated");

                entity.Property(e => e.SettledEmpId).HasColumnName("SettledEmpID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartedEmpId).HasColumnName("StartedEmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TabOutCode).HasMaxLength(10);

                entity.Property(e => e.TogoFtax).HasColumnName("TogoFTax");

                entity.Property(e => e.TransferEmpId).HasColumnName("TransferEmpID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WebAddress1).HasMaxLength(65);

                entity.Property(e => e.WebAddress2).HasMaxLength(65);

                entity.Property(e => e.WebCity).HasMaxLength(50);

                entity.Property(e => e.WebComment).HasMaxLength(600);

                entity.Property(e => e.WebEmail).HasMaxLength(255);

                entity.Property(e => e.WebFirstName).HasMaxLength(50);

                entity.Property(e => e.WebLastName).HasMaxLength(50);

                entity.Property(e => e.WebOrderCustomerId).HasColumnName("WebOrderCustomerID");

                entity.Property(e => e.WebPhone).HasMaxLength(50);

                entity.Property(e => e.WebState).HasMaxLength(2);

                entity.Property(e => e.WebZip).HasMaxLength(50);
            });

            modelBuilder.Entity<SaleCoupon>(entity =>
            {
                entity.ToTable("SaleCoupon");

                entity.HasIndex(e => e.SaleId, "IX_SaleCoupon")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleCouponId)
                    .HasColumnName("SaleCouponID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleCoupons)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleCoupon_Sale");
            });

            modelBuilder.Entity<SaleCreditCard>(entity =>
            {
                entity.ToTable("SaleCreditCard");

                entity.HasIndex(e => e.SaleId, "IX_SaleCreditCard")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DataVersion, "IX_SaleCreditCard_DataVersion")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleCreditCardId)
                    .HasColumnName("SaleCreditCardID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.BankGcicendBal).HasColumnName("BankGCICEndBal");

                entity.Property(e => e.BankGcicexchRate)
                    .HasMaxLength(12)
                    .HasColumnName("BankGCICExchRate");

                entity.Property(e => e.BankGcicprevBal).HasColumnName("BankGCICPrevBal");

                entity.Property(e => e.BankGcissueCurr)
                    .HasMaxLength(8)
                    .HasColumnName("BankGCIssueCurr");

                entity.Property(e => e.Bgcbalance).HasColumnName("BGCBalance");

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.CardNum)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.Emvaid)
                    .HasMaxLength(48)
                    .HasColumnName("EMVAID")
                    .IsFixedLength();

                entity.Property(e => e.EmvapplicationLabel)
                    .HasMaxLength(48)
                    .HasColumnName("EMVApplicationLabel")
                    .IsFixedLength();

                entity.Property(e => e.Emvarc)
                    .HasMaxLength(48)
                    .HasColumnName("EMVARC")
                    .IsFixedLength();

                entity.Property(e => e.Emvcvm)
                    .HasMaxLength(48)
                    .HasColumnName("EMVCVM")
                    .IsFixedLength();

                entity.Property(e => e.EmventryMethod)
                    .HasMaxLength(48)
                    .HasColumnName("EMVEntryMethod")
                    .IsFixedLength();

                entity.Property(e => e.Emviad)
                    .HasMaxLength(48)
                    .HasColumnName("EMVIAD")
                    .IsFixedLength();

                entity.Property(e => e.Emvtsi)
                    .HasMaxLength(48)
                    .HasColumnName("EMVTSI")
                    .IsFixedLength();

                entity.Property(e => e.Emvtvr)
                    .HasMaxLength(48)
                    .HasColumnName("EMVTVR")
                    .IsFixedLength();

                entity.Property(e => e.EncryptedBlock)
                    .HasMaxLength(232)
                    .IsFixedLength();

                entity.Property(e => e.EncryptedRawSwipe)
                    .HasMaxLength(1024)
                    .IsFixedLength();

                entity.Property(e => e.EncryptionKey)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.IsE2eencryption).HasColumnName("IsE2EEncryption");

                entity.Property(e => e.OfflineId)
                    .HasMaxLength(128)
                    .HasColumnName("OfflineID");

                entity.Property(e => e.ProcessData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceData)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.SignatureId).HasColumnName("SignatureID");

                entity.Property(e => e.UkrefNo).HasColumnName("UKRefNo");

                entity.Property(e => e.VaultId)
                    .HasMaxLength(128)
                    .HasColumnName("VaultID")
                    .IsFixedLength();

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleCreditCards)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleCreditCard_Sale");
            });

            modelBuilder.Entity<SaleDiscount>(entity =>
            {
                entity.ToTable("SaleDiscount");

                entity.HasIndex(e => e.SaleId, "IX_SaleDiscount")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleDiscountId)
                    .HasColumnName("SaleDiscountID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleDiscounts)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SaleDiscount_Sale");
            });

            modelBuilder.Entity<SaleGiftSold>(entity =>
            {
                entity.ToTable("SaleGiftSold");

                entity.HasIndex(e => e.SaleId, "IX_SaleGiftSold")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleGiftSoldId)
                    .HasColumnName("SaleGiftSoldID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GiftNumber)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleGiftSolds)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleGiftSold_Sale");
            });

            modelBuilder.Entity<SaleGiftUsed>(entity =>
            {
                entity.ToTable("SaleGiftUsed");

                entity.HasIndex(e => e.SaleId, "IX_SaleGiftUsed")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleGiftUsedId)
                    .HasColumnName("SaleGiftUsedID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.GcprtOpt).HasColumnName("GCPrtOpt");

                entity.Property(e => e.GiftNumber).HasMaxLength(16);

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleGiftUseds)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleGiftUsed_Sale");
            });

            modelBuilder.Entity<SaleItem>(entity =>
            {
                entity.ToTable("SaleItem");

                entity.HasIndex(e => e.SaleId, "IX_SaleItem")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.SplitQuantity, e.SplitParentId }, "IX_SplitParentID");

                entity.Property(e => e.SaleItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("SaleItemID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BankAuthCode).HasMaxLength(24);

                entity.Property(e => e.BankAuthorizationCode).HasMaxLength(24);

                entity.Property(e => e.BankRefNumber).HasMaxLength(16);

                entity.Property(e => e.BergPlu).HasColumnName("BergPLU");

                entity.Property(e => e.CouponApplied)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.DiscountApplied)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.DiscountFlags)
                    .HasMaxLength(13)
                    .IsFixedLength();

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.GiftCardNum).HasMaxLength(16);

                entity.Property(e => e.HasRemoteDescription)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.MobileUserId).HasColumnName("MobileUserID");

                entity.Property(e => e.ModifierGroupItem).HasMaxLength(32);

                entity.Property(e => e.PbasePrice).HasColumnName("PBasePrice");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.ShortDescription).HasMaxLength(6);

                entity.Property(e => e.SoldDate).HasColumnType("datetime");

                entity.Property(e => e.SplitLevel)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.SplitParentId).HasColumnName("SplitParentID");

                entity.Property(e => e.TimedEndDate).HasColumnType("datetime");

                entity.Property(e => e.TimedStartDate).HasColumnType("datetime");

                entity.Property(e => e.Upc)
                    .HasMaxLength(32)
                    .HasColumnName("UPC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vatamt).HasColumnName("VATAmt");

                entity.Property(e => e.Vducolor).HasColumnName("VDUColor");

                entity.Property(e => e.VoidDate).HasColumnType("datetime");

                entity.Property(e => e.VoidEmpId).HasColumnName("VoidEmpID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleItems)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleItem_Sale1");
            });

            modelBuilder.Entity<SaleItemCoupon>(entity =>
            {
                entity.ToTable("SaleItemCoupon");

                entity.HasIndex(e => e.SaleItemId, "IX_SaleItemCoupon")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleItemCouponId)
                    .ValueGeneratedNever()
                    .HasColumnName("SaleItemCouponID");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItemID");

                entity.HasOne(d => d.SaleItem)
                    .WithMany(p => p.SaleItemCoupons)
                    .HasForeignKey(d => d.SaleItemId)
                    .HasConstraintName("FK_SaleItemCoupon_SaleItem");
            });

            modelBuilder.Entity<SaleItemDiscount>(entity =>
            {
                entity.ToTable("SaleItemDiscount");

                entity.HasIndex(e => e.SaleItemId, "IX_SaleItemDiscount")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleItemDiscountId)
                    .ValueGeneratedNever()
                    .HasColumnName("SaleItemDiscountID");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItemID");

                entity.HasOne(d => d.SaleItem)
                    .WithMany(p => p.SaleItemDiscounts)
                    .HasForeignKey(d => d.SaleItemId)
                    .HasConstraintName("FK_SaleItemDiscount_SaleItem");
            });

            modelBuilder.Entity<SaleLoyalty>(entity =>
            {
                entity.ToTable("SaleLoyalty");

                entity.Property(e => e.SaleLoyaltyId)
                    .HasColumnName("SaleLoyaltyID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rating).HasMaxLength(50);

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleLoyalties)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleLoyalty_Sale");
            });

            modelBuilder.Entity<SaleMedium>(entity =>
            {
                entity.HasKey(e => e.SaleMediaId);

                entity.Property(e => e.SaleMediaId)
                    .HasColumnName("SaleMediaID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleMedia)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleMedia_Sale");
            });

            modelBuilder.Entity<SalePm>(entity =>
            {
                entity.HasKey(e => e.SalePmsid)
                    .HasName("PK_EJPMSUsed");

                entity.ToTable("SalePMS");

                entity.HasIndex(e => e.SaleId, "IX_SalePMSUsed")
                    .HasFillFactor(90);

                entity.Property(e => e.SalePmsid)
                    .HasColumnName("SalePMSID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.GuestName).HasMaxLength(50);

                entity.Property(e => e.Pmsindex).HasColumnName("PMSIndex");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalePms)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SalePMS_Sale");
            });

            modelBuilder.Entity<SaleShare>(entity =>
            {
                entity.ToTable("SaleShare");

                entity.HasIndex(e => e.SaleId, "IX_SaleShare")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleShareId)
                    .HasColumnName("SaleShareID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleShares)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleShare_Sale");
            });

            modelBuilder.Entity<SaleTax>(entity =>
            {
                entity.ToTable("SaleTax");

                entity.HasIndex(e => e.SaleId, "IX_SaleTax")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleTaxId)
                    .HasColumnName("SaleTaxID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleTaxes)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleTax_Sale");
            });

            modelBuilder.Entity<SaleTender>(entity =>
            {
                entity.ToTable("SaleTender");

                entity.HasIndex(e => e.SaleId, "IX_SaleTender")
                    .HasFillFactor(90);

                entity.Property(e => e.SaleTenderId)
                    .HasColumnName("SaleTenderID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.MediaMemo)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.SignatureId).HasColumnName("SignatureID");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleTenders)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_SaleTender_Sale");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("ScheduleID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<ScheduleItem>(entity =>
            {
                entity.ToTable("ScheduleItem");

                entity.HasIndex(e => e.ScheduleId, "IX_ScheduleItem")
                    .HasFillFactor(90);

                entity.Property(e => e.ScheduleItemId)
                    .HasColumnName("ScheduleItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.ShiftDescription).HasMaxLength(20);

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleItems)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_ScheduleItem_Schedule");
            });

            modelBuilder.Entity<ScheduledUpdateMaintenance>(entity =>
            {
                entity.ToTable("ScheduledUpdateMaintenance");

                entity.Property(e => e.ScheduledUpdateMaintenanceId)
                    .HasColumnName("ScheduledUpdateMaintenanceID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Maintenance)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MenuPageItemId).HasColumnName("MenuPageItemID");

                entity.Property(e => e.PrimaryTable)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ScheduledUpdateScheduleGroup>(entity =>
            {
                entity.HasKey(e => e.ScheduleGroupId)
                    .HasName("PK_ScheduleGroupID");

                entity.ToTable("ScheduledUpdateScheduleGroup");

                entity.Property(e => e.ScheduleGroupId)
                    .HasColumnName("ScheduleGroupID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DataGroupId).HasColumnName("DataGroupID");

                entity.Property(e => e.ScheduleGroupDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScheduleGroupName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ScheduledUpdateScheduleGroupUpdate>(entity =>
            {
                entity.HasKey(e => e.ScheduledUpdateUpdateId)
                    .HasName("PK_ScheduledUpdateUpdate");

                entity.ToTable("ScheduledUpdateScheduleGroupUpdate");

                entity.Property(e => e.ScheduledUpdateUpdateId)
                    .HasColumnName("ScheduledUpdateUpdateID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScheduleGroupId).HasColumnName("ScheduleGroupID");

                entity.Property(e => e.ScheduledUpdateMaintenanceId).HasColumnName("ScheduledUpdateMaintenanceID");

                entity.HasOne(d => d.ScheduleGroup)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdates)
                    .HasForeignKey(d => d.ScheduleGroupId)
                    .HasConstraintName("FK_ScheduledUpdateUpdate_ScheduledUpdateScheduleGroup");

                entity.HasOne(d => d.ScheduledUpdateMaintenance)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdates)
                    .HasForeignKey(d => d.ScheduledUpdateMaintenanceId)
                    .HasConstraintName("FK_ScheduledUpdateUpdate_ScheduledUpdateMaintenance");
            });

            modelBuilder.Entity<ScheduledUpdateScheduleGroupUpdateSettingChange>(entity =>
            {
                entity.HasKey(e => e.ScheduledUpdateSettingChangeId)
                    .HasName("PK_ScheduledUpdateSettingChange");

                entity.ToTable("ScheduledUpdateScheduleGroupUpdateSettingChange");

                entity.Property(e => e.ScheduledUpdateSettingChangeId)
                    .HasColumnName("ScheduledUpdateSettingChangeID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewValue).HasDefaultValueSql("('')");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalFieldId)
                    .HasMaxLength(40)
                    .HasColumnName("OriginalFieldID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreviousValue).HasDefaultValueSql("('')");

                entity.Property(e => e.ScheduledUpdateUpdateId).HasColumnName("ScheduledUpdateUpdateID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdateSettingChanges)
                    .HasForeignKey(d => d.DataTypeId)
                    .HasConstraintName("FK_ScheduledUpdateSettingChange_DataType");

                entity.HasOne(d => d.ScheduledUpdateUpdate)
                    .WithMany(p => p.ScheduledUpdateScheduleGroupUpdateSettingChanges)
                    .HasForeignKey(d => d.ScheduledUpdateUpdateId)
                    .HasConstraintName("FK_ScheduledUpdateSettingChange_ScheduledUpdateUpdate");
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.ToTable("Screen");

                entity.HasIndex(e => new { e.RegionId, e.ScreenIndex }, "IX_Screen")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenId)
                    .HasColumnName("ScreenID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.ScreenName).HasMaxLength(40);
            });

            modelBuilder.Entity<ScreenAutoMenu>(entity =>
            {
                entity.ToTable("ScreenAutoMenu");

                entity.Property(e => e.ScreenAutoMenuId)
                    .HasColumnName("ScreenAutoMenuID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentTextSource).HasMaxLength(40);

                entity.Property(e => e.ItemTextSource).HasMaxLength(40);

                entity.Property(e => e.NextButtonText).HasMaxLength(40);

                entity.Property(e => e.PreviousButtonText).HasMaxLength(40);

                entity.Property(e => e.ScreenAutoMenuName).HasMaxLength(40);

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenAutoMenus)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenAutoMenu_Screen");
            });

            modelBuilder.Entity<ScreenAutoMenuFilter>(entity =>
            {
                entity.ToTable("ScreenAutoMenuFilter");

                entity.Property(e => e.ScreenAutoMenuFilterId)
                    .HasColumnName("ScreenAutoMenuFilterID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentGroupFilter).HasMaxLength(30);

                entity.Property(e => e.DepartmentNameFilter).HasMaxLength(10);

                entity.Property(e => e.FilterMax).HasMaxLength(32);

                entity.Property(e => e.ItemNameFilter).HasMaxLength(32);

                entity.Property(e => e.ItemUpcfilter)
                    .HasMaxLength(32)
                    .HasColumnName("ItemUPCFilter");

                entity.Property(e => e.MenuFilter).HasMaxLength(20);

                entity.Property(e => e.ProcessItemBuffer)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReplaceItemBuffer)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ScreenAutoMenuId).HasColumnName("ScreenAutoMenuID");

                entity.HasOne(d => d.ScreenAutoMenu)
                    .WithMany(p => p.ScreenAutoMenuFilters)
                    .HasForeignKey(d => d.ScreenAutoMenuId)
                    .HasConstraintName("FK_ScreenAutoMenuFilter_ScreenAutoMenu");
            });

            modelBuilder.Entity<ScreenAutoMenuFilterButtonSetting>(entity =>
            {
                entity.HasKey(e => e.ScreenAutoMenuFilterButtonSettingsId);

                entity.Property(e => e.ScreenAutoMenuFilterButtonSettingsId)
                    .HasColumnName("ScreenAutoMenuFilterButtonSettingsID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontFaceName).HasMaxLength(50);

                entity.Property(e => e.GraphicName).HasMaxLength(50);

                entity.Property(e => e.ScreenAutoMenuFilterId).HasColumnName("ScreenAutoMenuFilterID");

                entity.HasOne(d => d.ScreenAutoMenuFilter)
                    .WithMany(p => p.ScreenAutoMenuFilterButtonSettings)
                    .HasForeignKey(d => d.ScreenAutoMenuFilterId)
                    .HasConstraintName("FK_ScreenAutoMenuFilterButtonSettings_ScreenAutoMenuFilter");
            });

            modelBuilder.Entity<ScreenAutoMenuPagingButtonSetting>(entity =>
            {
                entity.HasKey(e => e.ScreenAutoMenuPagingButtonSettingsId);

                entity.Property(e => e.ScreenAutoMenuPagingButtonSettingsId)
                    .HasColumnName("ScreenAutoMenuPagingButtonSettingsID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FontFaceName).HasMaxLength(50);

                entity.Property(e => e.GraphicName).HasMaxLength(50);

                entity.Property(e => e.ScreenAutoMenuId).HasColumnName("ScreenAutoMenuID");

                entity.HasOne(d => d.ScreenAutoMenu)
                    .WithMany(p => p.ScreenAutoMenuPagingButtonSettings)
                    .HasForeignKey(d => d.ScreenAutoMenuId)
                    .HasConstraintName("FK_ScreenAutoMenuPagingButtonSettings_ScreenAutoMenu");
            });

            modelBuilder.Entity<ScreenBitmap>(entity =>
            {
                entity.ToTable("ScreenBitmap");

                entity.HasIndex(e => e.ScreenId, "IX_ScreenBitmap")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenBitmapId)
                    .HasColumnName("ScreenBitmapID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.BitmapFile).HasMaxLength(128);

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenBitmaps)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenBitmap_Screen");
            });

            modelBuilder.Entity<ScreenButton>(entity =>
            {
                entity.ToTable("ScreenButton");

                entity.HasIndex(e => e.ScreenId, "IX_ScreenButton")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenButtonId)
                    .HasColumnName("ScreenButtonID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenButtons)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenButton_Screen");
            });

            modelBuilder.Entity<ScreenEdit>(entity =>
            {
                entity.ToTable("ScreenEdit");

                entity.HasIndex(e => e.ScreenId, "IX_ScreenEdit")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenEditId)
                    .HasColumnName("ScreenEditID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenEdits)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenEdit_Screen");
            });

            modelBuilder.Entity<ScreenFrame>(entity =>
            {
                entity.ToTable("ScreenFrame");

                entity.HasIndex(e => e.ScreenId, "IX_ScreenFrame")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenFrameId)
                    .HasColumnName("ScreenFrameID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenFrames)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenFrame_Screen");
            });

            modelBuilder.Entity<ScreenHelp>(entity =>
            {
                entity.ToTable("ScreenHelp");

                entity.HasIndex(e => e.ScreenId, "IX_ScreenHelp")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenHelpId)
                    .HasColumnName("ScreenHelpID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.Topic).HasMaxLength(40);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenHelps)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenHelp_Screen");
            });

            modelBuilder.Entity<ScreenList>(entity =>
            {
                entity.ToTable("ScreenList");

                entity.HasIndex(e => e.ScreenId, "IX_ScreenList")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenListId)
                    .HasColumnName("ScreenListID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenLists)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenList_Screen");
            });

            modelBuilder.Entity<ScreenText>(entity =>
            {
                entity.ToTable("ScreenText");

                entity.HasIndex(e => e.ScreenId, "IX_ScreenText")
                    .HasFillFactor(90);

                entity.Property(e => e.ScreenTextId)
                    .HasColumnName("ScreenTextID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.Text).HasMaxLength(40);

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.ScreenTexts)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_ScreenText_Screen");
            });

            modelBuilder.Entity<SecurityCheck>(entity =>
            {
                entity.ToTable("SecurityCheck");

                entity.Property(e => e.SecurityCheckId)
                    .HasColumnName("SecurityCheckID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.FileName)
                    .HasMaxLength(48)
                    .IsFixedLength();

                entity.Property(e => e.Path)
                    .HasMaxLength(128)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.LastActivityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastActivityDate");

                entity.Property(e => e.SessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sessionDate");

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(200)
                    .HasColumnName("sessionKey");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ShiftDescription).HasMaxLength(32);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<Shorthand>(entity =>
            {
                entity.ToTable("Shorthand");

                entity.Property(e => e.ShorthandId)
                    .HasColumnName("ShorthandID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ShortCode).HasMaxLength(32);
            });

            modelBuilder.Entity<Signature>(entity =>
            {
                entity.ToTable("Signature");

                entity.Property(e => e.SignatureId)
                    .HasColumnName("SignatureID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.SignatureDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<Special>(entity =>
            {
                entity.ToTable("Special");

                entity.Property(e => e.SpecialId)
                    .HasColumnName("SpecialID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SpecialName).HasMaxLength(32);
            });

            modelBuilder.Entity<SpecialMonth>(entity =>
            {
                entity.ToTable("SpecialMonth");

                entity.HasIndex(e => e.SpecialId, "IX_SpecialMonth")
                    .HasFillFactor(90);

                entity.Property(e => e.SpecialMonthId)
                    .HasColumnName("SpecialMonthID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.SpecialId).HasColumnName("SpecialID");

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.SpecialMonths)
                    .HasForeignKey(d => d.SpecialId)
                    .HasConstraintName("FK_SpecialMonth_Special");
            });

            modelBuilder.Entity<SpecialWeek>(entity =>
            {
                entity.ToTable("SpecialWeek");

                entity.HasIndex(e => e.SpecialId, "IX_SpecialWeek")
                    .HasFillFactor(90);

                entity.Property(e => e.SpecialWeekId)
                    .HasColumnName("SpecialWeekID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.SpecialId).HasColumnName("SpecialID");

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.SpecialWeeks)
                    .HasForeignKey(d => d.SpecialId)
                    .HasConstraintName("FK_SpecialWeek_Special");
            });

            modelBuilder.Entity<StatusMessage>(entity =>
            {
                entity.ToTable("StatusMessage");

                entity.Property(e => e.StatusMessageId)
                    .HasColumnName("StatusMessageID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.DeviceName).HasMaxLength(50);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(512);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.StoreId)
                    .ValueGeneratedNever()
                    .HasColumnName("StoreID");

                entity.Property(e => e.Apikey)
                    .HasMaxLength(200)
                    .HasColumnName("APIKey");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.StoreDescription).HasMaxLength(32);

                entity.Property(e => e.StoreName).HasMaxLength(8);
            });

            modelBuilder.Entity<Sync>(entity =>
            {
                entity.ToTable("Sync");

                entity.Property(e => e.SyncId)
                    .HasColumnName("SyncID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DbtableNumber).HasColumnName("DBTableNumber");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'I')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SyncDatum>(entity =>
            {
                entity.HasKey(e => e.SyncDataId);

                entity.HasIndex(e => e.SyncId, "IX_SyncData")
                    .HasFillFactor(90);

                entity.Property(e => e.SyncDataId)
                    .HasColumnName("SyncDataID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DbrecordId).HasColumnName("DBRecordID");

                entity.Property(e => e.SyncId).HasColumnName("SyncID");

                entity.HasOne(d => d.Sync)
                    .WithMany(p => p.SyncData)
                    .HasForeignKey(d => d.SyncId)
                    .HasConstraintName("FK_SyncData_Sync");
            });

            modelBuilder.Entity<TabbedOut>(entity =>
            {
                entity.HasKey(e => e.TabOutId);

                entity.ToTable("TabbedOut");

                entity.HasIndex(e => e.DataVersion, "IX_TabbedOut_DataVersion")
                    .HasFillFactor(90);

                entity.Property(e => e.TabOutId)
                    .ValueGeneratedNever()
                    .HasColumnName("TabOutID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.AuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.CardName)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.CardNum)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PreAuthResponse)
                    .HasMaxLength(32)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(24)
                    .IsFixedLength();

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.TabOutCode).HasMaxLength(10);

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<TabbedOutAlert>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("TabbedOutAlert");

                entity.Property(e => e.MessageId)
                    .ValueGeneratedNever()
                    .HasColumnName("MessageID");

                entity.Property(e => e.Message).HasMaxLength(2000);

                entity.Property(e => e.TabOutCode).HasMaxLength(10);
            });

            modelBuilder.Entity<ACM.Models.Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.ToTable("TaskItem");

                entity.HasIndex(e => e.TaskId, "IX_TaskItem")
                    .HasFillFactor(90);

                entity.Property(e => e.TaskItemId)
                    .HasColumnName("TaskItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ProgramName).HasMaxLength(100);

                entity.Property(e => e.RunDate).HasColumnType("datetime");

                entity.Property(e => e.TaskDescription).HasMaxLength(100);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskItems)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskItem_Task");
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.ToTable("Tax");

                entity.Property(e => e.TaxId)
                    .HasColumnName("TaxID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.IsVat).HasColumnName("IsVAT");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TaxName).HasMaxLength(64);
            });

            modelBuilder.Entity<TaxSchedule>(entity =>
            {
                entity.ToTable("TaxSchedule");

                entity.HasIndex(e => e.TaxId, "IX_TaxSchedule")
                    .HasFillFactor(90);

                entity.Property(e => e.TaxScheduleId)
                    .HasColumnName("TaxScheduleID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxSchedules)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FKS_TaxSchedule_Tax");
            });

            modelBuilder.Entity<TaxTable>(entity =>
            {
                entity.ToTable("TaxTable");

                entity.HasIndex(e => e.TaxId, "IX_TaxTable")
                    .HasFillFactor(90);

                entity.Property(e => e.TaxTableId)
                    .HasColumnName("TaxTableID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxTables)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FKS_TaxTable_Tax");
            });

            modelBuilder.Entity<TaxTranslation>(entity =>
            {
                entity.ToTable("TaxTranslation");

                entity.Property(e => e.TaxTranslationId)
                    .HasColumnName("TaxTranslationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.Value).HasMaxLength(4000);

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.TaxTranslations)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FK_TaxTranslation_Tax");
            });

            modelBuilder.Entity<TerminalConfiguration>(entity =>
            {
                entity.ToTable("TerminalConfiguration");

                entity.Property(e => e.TerminalConfigurationId)
                    .HasColumnName("TerminalConfigurationID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ConfigurationXml)
                    .HasColumnType("ntext")
                    .HasColumnName("ConfigurationXML");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<TimeCard>(entity =>
            {
                entity.ToTable("TimeCard");

                entity.HasIndex(e => new { e.CardDate, e.PunchType }, "IX_CardDatePunchType");

                entity.HasIndex(e => new { e.StoreId, e.EmpId, e.CardDate }, "IX_TimeCard")
                    .HasFillFactor(90);

                entity.Property(e => e.TimeCardId)
                    .HasColumnName("TimeCardID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CardDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.RoundedDate).HasColumnType("datetime");

                entity.Property(e => e.ShadowTimeCardForId).HasColumnName("ShadowTimeCardForID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<TimedMenu>(entity =>
            {
                entity.ToTable("TimedMenu");

                entity.Property(e => e.TimedMenuId)
                    .HasColumnName("TimedMenuID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<TimedMenuDay>(entity =>
            {
                entity.ToTable("TimedMenuDay");

                entity.HasIndex(e => e.TimedMenuId, "IX_TimedMenuDay")
                    .HasFillFactor(90);

                entity.Property(e => e.TimedMenuDayId)
                    .ValueGeneratedNever()
                    .HasColumnName("TimedMenuDayID");

                entity.Property(e => e.CommonMenuName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TerminalNumber).HasDefaultValueSql("((99))");

                entity.Property(e => e.TimedMenuId).HasColumnName("TimedMenuID");

                entity.HasOne(d => d.TimedMenu)
                    .WithMany(p => p.TimedMenuDays)
                    .HasForeignKey(d => d.TimedMenuId)
                    .HasConstraintName("FK_TimedMenuDay_TimedMenu");
            });

            modelBuilder.Entity<TimedMenuJob>(entity =>
            {
                entity.ToTable("TimedMenuJob");

                entity.HasIndex(e => e.TimedMenuId, "IX_TimedMenuJob")
                    .HasFillFactor(90);

                entity.Property(e => e.TimedMenuJobId)
                    .ValueGeneratedNever()
                    .HasColumnName("TimedMenuJobID");

                entity.Property(e => e.TimedMenuId).HasColumnName("TimedMenuID");

                entity.HasOne(d => d.TimedMenu)
                    .WithMany(p => p.TimedMenuJobs)
                    .HasForeignKey(d => d.TimedMenuId)
                    .HasConstraintName("FK_TimedMenuJob_TimedMenu");
            });

            modelBuilder.Entity<TipPool>(entity =>
            {
                entity.ToTable("TipPool");

                entity.Property(e => e.TipPoolId)
                    .HasColumnName("TipPoolID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.TipPoolName).HasMaxLength(255);
            });

            modelBuilder.Entity<TipPoolContribution>(entity =>
            {
                entity.ToTable("TipPoolContribution");

                entity.Property(e => e.TipPoolContributionId)
                    .HasColumnName("TipPoolContributionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.TipPoolId).HasColumnName("TipPoolID");

                entity.HasOne(d => d.TipPool)
                    .WithMany(p => p.TipPoolContributions)
                    .HasForeignKey(d => d.TipPoolId)
                    .HasConstraintName("FK_TipPoolContribution_TipPool");
            });

            modelBuilder.Entity<TipPoolDistribution>(entity =>
            {
                entity.ToTable("TipPoolDistribution");

                entity.Property(e => e.TipPoolDistributionId)
                    .HasColumnName("TipPoolDistributionID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.TipPoolId).HasColumnName("TipPoolID");

                entity.HasOne(d => d.TipPool)
                    .WithMany(p => p.TipPoolDistributions)
                    .HasForeignKey(d => d.TipPoolId)
                    .HasConstraintName("FK_TipPoolDistribution_TipPool");
            });

            modelBuilder.Entity<Total>(entity =>
            {
                entity.ToTable("Total");

                entity.HasIndex(e => e.TotalDate, "IX_Total")
                    .HasFillFactor(90);

                entity.Property(e => e.TotalId)
                    .HasColumnName("TotalID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Description).HasMaxLength(32);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TipEmpId).HasColumnName("TipEmpID");

                entity.Property(e => e.TotalDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("Transfer");

                entity.HasIndex(e => new { e.ToTerminalNumber, e.ProcessOnServer, e.RetryCount }, "IX_Transfer")
                    .HasFillFactor(90);

                entity.Property(e => e.TransferId)
                    .HasColumnName("TransferID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Data).HasColumnType("ntext");

                entity.Property(e => e.DbrecordId).HasColumnName("DBRecordID");

                entity.Property(e => e.DbtableNumber).HasColumnName("DBTableNumber");

                entity.Property(e => e.FromStoreId).HasColumnName("FromStoreID");

                entity.Property(e => e.ToStoreId).HasColumnName("ToStoreID");
            });

            modelBuilder.Entity<Ui>(entity =>
            {
                entity.ToTable("UI");

                entity.HasIndex(e => e.Name, "UIName_Unique")
                    .IsUnique();

                entity.Property(e => e.Uiid)
                    .HasColumnName("UIID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Uicolumn>(entity =>
            {
                entity.ToTable("UIColumn");

                entity.Property(e => e.UicolumnId)
                    .HasColumnName("UIColumnID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("A Database Column Name (Must match table)");

                entity.Property(e => e.Position).HasComment("Display Order Index");

                entity.Property(e => e.Uiid).HasColumnName("UIID");

                entity.HasOne(d => d.Ui)
                    .WithMany(p => p.Uicolumns)
                    .HasForeignKey(d => d.Uiid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UIColumn_UIColumn");
            });

            modelBuilder.Entity<VBottom10Dept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10Depts");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NumItems).HasColumnName("numItems");
            });

            modelBuilder.Entity<VBottom10DeptsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10DeptsPrice");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.PriceItems).HasColumnName("priceItems");
            });

            modelBuilder.Entity<VBottom10Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10Items");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.NumItems).HasColumnName("numItems");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<VBottom10ItemsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBottom10ItemsPrice");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.PriceItems).HasColumnName("priceItems");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<VButtonMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vButtonMenu");

                entity.Property(e => e.Menu).HasMaxLength(20);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<VContentLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vContentLink");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.LinkPlayListItemId).HasColumnName("LinkPlayListItemID");

                entity.Property(e => e.PlayListId).HasColumnName("PlayListID");

                entity.Property(e => e.PlaylistItemId).HasColumnName("PlaylistItemID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VCreditBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCreditBatch");
            });

            modelBuilder.Entity<VDbfileHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDBFileHeader");

                entity.Property(e => e.DbfileId).HasColumnName("DBFileID");

                entity.Property(e => e.FileDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);
            });

            modelBuilder.Entity<VDisplaySchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDisplaySchedule");

                entity.Property(e => e.DisplayId).HasColumnName("DisplayID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.PlayListId).HasColumnName("PlayListID");

                entity.Property(e => e.PlayListName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VItemLabel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemLabel");

                entity.Property(e => e.ItemDescription).HasMaxLength(30);

                entity.Property(e => e.Upc)
                    .HasMaxLength(32)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<VItemLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemLink");

                entity.Property(e => e.CreateStamp).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(450);

                entity.Property(e => e.MenuPageGroupId).HasColumnName("MenuPageGroupID");

                entity.Property(e => e.MenuPageId).HasColumnName("MenuPageID");

                entity.Property(e => e.MenuPageItemId).HasColumnName("MenuPageItemID");

                entity.Property(e => e.MenuPageLinkId).HasColumnName("MenuPageLinkID");

                entity.Property(e => e.NameReplace).HasMaxLength(250);

                entity.Property(e => e.Notes).HasMaxLength(1000);
            });

            modelBuilder.Entity<VMenuSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMenuSchedule");

                entity.Property(e => e.DisplayId).HasColumnName("DisplayID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.PlaylistItemId).HasColumnName("PlaylistItemID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VPlayListItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPlayListItem");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MediaType).HasMaxLength(50);

                entity.Property(e => e.PlaylistItemId).HasColumnName("PlaylistItemID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VSaleItemLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSaleItemLink");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Expr1).HasMaxLength(32);

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.SaleItemId).HasColumnName("SaleItemID");
            });

            modelBuilder.Entity<VTop10Dept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10Depts");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.NumItems).HasColumnName("numItems");
            });

            modelBuilder.Entity<VTop10DeptsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10DeptsPrice");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.PriceItems).HasColumnName("priceItems");
            });

            modelBuilder.Entity<VTop10Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10Items");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.NumItems).HasColumnName("numItems");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<VTop10ItemsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTop10ItemsPrice");

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.PriceItems).HasColumnName("priceItems");

                entity.Property(e => e.ReceiptDescription).HasMaxLength(20);
            });

            modelBuilder.Entity<Vdu>(entity =>
            {
                entity.ToTable("VDU");

                entity.Property(e => e.Vduid)
                    .ValueGeneratedNever()
                    .HasColumnName("VDUID");

                entity.Property(e => e.CheckDescription).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.OrderTakerEmpId).HasColumnName("OrderTakerEmpID");

                entity.Property(e => e.PromiseTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Vduitem>(entity =>
            {
                entity.ToTable("VDUItem");

                entity.Property(e => e.VduitemId)
                    .ValueGeneratedNever()
                    .HasColumnName("VDUItemID");

                entity.Property(e => e.Department)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(20);

                entity.Property(e => e.ItemName).HasMaxLength(32);

                entity.Property(e => e.SaleItemId)
                    .HasColumnName("SaleItemID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Vduid).HasColumnName("VDUID");

                entity.HasOne(d => d.Vdu)
                    .WithMany(p => p.Vduitems)
                    .HasForeignKey(d => d.Vduid)
                    .HasConstraintName("FK_VDUItem_VDU");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address).HasMaxLength(64);

                entity.Property(e => e.City).HasMaxLength(16);

                entity.Property(e => e.Fax).HasMaxLength(16);

                entity.Property(e => e.Notes).HasMaxLength(420);

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.VendorName).HasMaxLength(20);

                entity.Property(e => e.Zip).HasMaxLength(16);
            });

            modelBuilder.Entity<VendorPurchase>(entity =>
            {
                entity.ToTable("VendorPurchase");

                entity.Property(e => e.VendorPurchaseId)
                    .HasColumnName("VendorPurchaseID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorPurchases)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VendorPurchase_Vendor");
            });

            modelBuilder.Entity<ACM.Models.Version>(entity =>
            {
                entity.ToTable("Version");

                entity.Property(e => e.VersionId)
                    .ValueGeneratedNever()
                    .HasColumnName("VersionID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");
            });

            modelBuilder.Entity<VideoCapture>(entity =>
            {
                entity.ToTable("VideoCapture");

                entity.Property(e => e.VideoCaptureId)
                    .HasColumnName("VideoCaptureID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.VideoDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WageHistory>(entity =>
            {
                entity.ToTable("WageHistory");

                entity.Property(e => e.WageHistoryId)
                    .HasColumnName("WageHistoryID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.WageDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WageHistoryWage>(entity =>
            {
                entity.ToTable("WageHistoryWage");

                entity.HasIndex(e => e.WageHistoryId, "IX_WageHistoryWage")
                    .HasFillFactor(90);

                entity.Property(e => e.WageHistoryWageId)
                    .HasColumnName("WageHistoryWageID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.WageHistoryId).HasColumnName("WageHistoryID");

                entity.HasOne(d => d.WageHistory)
                    .WithMany(p => p.WageHistoryWages)
                    .HasForeignKey(d => d.WageHistoryId)
                    .HasConstraintName("FK_WageHistoryWage_WageHistory");
            });

            modelBuilder.Entity<Xmlbucket>(entity =>
            {
                entity.HasKey(e => e.XmlbucketsId);

                entity.ToTable("XMLBuckets");

                entity.Property(e => e.XmlbucketsId)
                    .ValueGeneratedNever()
                    .HasColumnName("XMLBucketsID");

                entity.Property(e => e.BusinessDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Xml)
                    .HasColumnName("XML")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Xml2)
                    .HasColumnType("xml")
                    .HasColumnName("XML2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
