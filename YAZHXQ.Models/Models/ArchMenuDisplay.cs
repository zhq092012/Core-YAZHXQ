using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchMenuDisplay
    {
        public int Id { get; set; }
        public string ColCode { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public int DisplayType { get; set; }
        public int MenuType { get; set; }
        public int ArchType { get; set; }
    }
}
