using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class LayoutSection
    {
        public Guid LayoutSectionId { get; set; }
        public Guid LayoutId { get; set; }
        public int SectionIndex { get; set; }
        public string SectionName { get; set; } = null!;
        public short ScreenIndex { get; set; }
        public short SectionType { get; set; }
        public bool TrackBySeat { get; set; }
        public bool NewSaleSeat { get; set; }
        public bool NewSaleToGo { get; set; }
        public bool ForceTableNumber { get; set; }
        public bool ForceCustomerCount { get; set; }
        public bool AutoAddSeats { get; set; }
        public bool ZeroCustomerCount { get; set; }
        public bool ForceOrderEmpId { get; set; }
        public short MinimumGratuityCustomerCount { get; set; }
        public int GratuityAmount { get; set; }
        public int SuggestedTip1 { get; set; }
        public int SuggestedTip2 { get; set; }
        public int SuggestedTip3 { get; set; }
        public string? HomeMenuName { get; set; }
        public short RedAfterMinutes { get; set; }
        public short BlinkAfterMinuts { get; set; }
        public bool ForceOrderType { get; set; }
        public bool ForceCheckDescription { get; set; }
        public short ForceCheckSelectionType { get; set; }
        public string? SkipModsMask { get; set; }
        public short DefaultOrderType { get; set; }
        public bool ForceDrinks { get; set; }
        public bool AutoSendOrder { get; set; }
        public short CheckInfo1 { get; set; }
        public short CheckInfo2 { get; set; }
        public short CheckInfo3 { get; set; }
        public short CheckInfo4 { get; set; }
        public short PriceLevel { get; set; }
        public bool CalcGratuityWdiscounts { get; set; }
        public string CommonMenuName { get; set; } = null!;
        public bool ForceDrinksToGo { get; set; }
        public bool AutoIncrementCourseOnSendOrder { get; set; }
        public short HandheldSignedOnScreenIndex { get; set; }
        public string? HandheldHomeMenuName { get; set; }
        public string? HandheldCommonMenuName { get; set; }
        public bool PromptForCustomerBeforeTender { get; set; }
        public byte[]? CustomerRequiredFields { get; set; }
        public bool IsServiceCharge { get; set; }

        public virtual Layout Layout { get; set; } = null!;
    }
}
