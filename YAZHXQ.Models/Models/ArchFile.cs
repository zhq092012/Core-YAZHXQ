using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchFile
    {
        public int FileId { get; set; }
        public int FileDataId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public int Sort { get; set; }
        public DateTime DoDate { get; set; }
        public int MenuType { get; set; }
        public int QcstaffId { get; set; }
        public int Status { get; set; }
        public int HierarchyId { get; set; }
    }
}
