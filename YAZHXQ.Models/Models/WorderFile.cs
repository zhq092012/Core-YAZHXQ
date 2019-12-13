using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class WorderFile
    {
        public int Id { get; set; }
        public int WorderId { get; set; }
        public int WorderFileType { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public int Sort { get; set; }
        public string FileType { get; set; }
        public DateTime? ProjTime { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
