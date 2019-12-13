using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class SpotFile
    {
        public int Id { get; set; }
        public int SpotMenuId { get; set; }
        public int SpotId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public int Sort { get; set; }
        public DateTime DoDate { get; set; }
        public int Status { get; set; }
        public int HierarchyId { get; set; }
        public int DoStaffId { get; set; }
        public string FileType { get; set; }
    }
}
