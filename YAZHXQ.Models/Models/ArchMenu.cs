using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchMenu
    {
        public int MenuId { get; set; }
        public int ArchId { get; set; }
        public string MenuName { get; set; }
        public int PageNum { get; set; }
        public int FileType { get; set; }
        public int Sort { get; set; }
        public int DoStaffId { get; set; }
        public DateTime DoDate { get; set; }
        public string Remark { get; set; }
        public int? MenuType { get; set; }
        public int ArchType { get; set; }
    }
}
