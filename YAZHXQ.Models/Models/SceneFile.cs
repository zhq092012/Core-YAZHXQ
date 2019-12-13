using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class SceneFile
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int DataId { get; set; }
        public int TableType { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public int Sort { get; set; }
        public int DoStaffId { get; set; }
        public DateTime DoDate { get; set; }
        public string FileType { get; set; }
        public DateTime? ProjTime { get; set; }
    }
}
