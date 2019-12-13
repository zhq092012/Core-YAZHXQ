using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchFileDataPublic
    {
        public int FileDataId { get; set; }
        public int MenuId { get; set; }
        public int MenuType { get; set; }
        public int ZlstaffId { get; set; }
        public DateTime Zldate { get; set; }
    }
}
