using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Screen
    {
        public Screen()
        {
            ScreenAutoMenus = new HashSet<ScreenAutoMenu>();
            ScreenBitmaps = new HashSet<ScreenBitmap>();
            ScreenButtons = new HashSet<ScreenButton>();
            ScreenEdits = new HashSet<ScreenEdit>();
            ScreenFrames = new HashSet<ScreenFrame>();
            ScreenHelps = new HashSet<ScreenHelp>();
            ScreenLists = new HashSet<ScreenList>();
            ScreenTexts = new HashSet<ScreenText>();
        }

        public Guid ScreenId { get; set; }
        public Guid RegionId { get; set; }
        public int ScreenIndex { get; set; }
        public string ScreenName { get; set; } = null!;
        public bool IsRequired { get; set; }

        public virtual ICollection<ScreenAutoMenu> ScreenAutoMenus { get; set; }
        public virtual ICollection<ScreenBitmap> ScreenBitmaps { get; set; }
        public virtual ICollection<ScreenButton> ScreenButtons { get; set; }
        public virtual ICollection<ScreenEdit> ScreenEdits { get; set; }
        public virtual ICollection<ScreenFrame> ScreenFrames { get; set; }
        public virtual ICollection<ScreenHelp> ScreenHelps { get; set; }
        public virtual ICollection<ScreenList> ScreenLists { get; set; }
        public virtual ICollection<ScreenText> ScreenTexts { get; set; }
    }
}
