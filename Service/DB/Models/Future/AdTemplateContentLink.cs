using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class AdTemplateContentLink
    {
        public Guid LinkTemplateId { get; set; }
        public Guid PlaylistItemId { get; set; }
        public Guid TemplateId { get; set; }
        public int ContentIdtag { get; set; }
        public int Display { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
