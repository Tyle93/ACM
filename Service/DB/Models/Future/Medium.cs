using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Medium
    {
        public Medium()
        {
            MediaTranslations = new HashSet<MediaTranslation>();
        }

        public Guid MediaId { get; set; }
        public Guid RegionId { get; set; }
        public int MediaIndex { get; set; }
        public string? MediaName { get; set; }
        public int MaxTender { get; set; }
        public int MinimumTender { get; set; }
        public short FontHeight { get; set; }
        public short FontWidth { get; set; }
        public short FontEscapement { get; set; }
        public short FontOrientation { get; set; }
        public short FontWeight { get; set; }
        public short FontItalic { get; set; }
        public short FontUnderline { get; set; }
        public short FontStrikeOut { get; set; }
        public short FontCharSet { get; set; }
        public short FontOutPrecision { get; set; }
        public short FontClipPrecision { get; set; }
        public short FontQuality { get; set; }
        public short FontPitchAndFamily { get; set; }
        public string? FontFaceName { get; set; }
        public int Foreground { get; set; }
        public int Background { get; set; }
        public string? ButtonText { get; set; }
        public bool ForceAmtTender { get; set; }
        public bool AllowPickup { get; set; }
        public bool AllowLoan { get; set; }
        public bool AllowRefund { get; set; }
        public short OvertenderOption { get; set; }
        public bool OvertenderIsTips { get; set; }
        public bool OpenDrawer { get; set; }
        public short SpecialOption { get; set; }
        public short MinimumSecLevel { get; set; }
        public bool AskForSuperId { get; set; }
        public bool NeedMemo { get; set; }
        public short ForgiveTax { get; set; }
        public short EuroTermType { get; set; }
        public int HouseTipPercent { get; set; }
        public short CreditCardType { get; set; }
        public short PmsmediaNum { get; set; }
        public string? Pmsaccount { get; set; }
        public bool PromptForSignature { get; set; }
        public short ForeignCurrencyType { get; set; }
        public bool NoPartialTender { get; set; }
        public byte[]? ImageData { get; set; }
        public bool NeedCv2 { get; set; }
        public bool NeedZipCode { get; set; }
        public bool UndertenderTips { get; set; }
        public bool LimitTerminals { get; set; }
        public byte[]? AllowedTerminals { get; set; }
        public bool NotInOfflineMode { get; set; }
        public bool MediaLivesInDrawer { get; set; }
        public bool HouseTipLivesInDrawer { get; set; }
        public bool MediaIsManual { get; set; }
        public bool DueRoundingNotAllowed { get; set; }
        public bool PromptForConfirmation { get; set; }

        public virtual ICollection<MediaTranslation> MediaTranslations { get; set; }
    }
}
