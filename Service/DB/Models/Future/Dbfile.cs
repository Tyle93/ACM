using System;
using System.Collections.Generic;

namespace ACM.Models
{
    public partial class Dbfile
    {
        public Guid DbfileId { get; set; }
        public int FileType { get; set; }
        public DateTime FileDate { get; set; }
        public string FileName { get; set; } = null!;
        public byte[] Data { get; set; } = null!;
        public int StoreId { get; set; }
    }
}
