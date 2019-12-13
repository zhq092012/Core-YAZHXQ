using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchMenuColumn
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string ColCode { get; set; }
        public string ColName { get; set; }
        public int ColType { get; set; }
        public string ColText { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public int MenuType { get; set; }
        public bool NullCheck { get; set; }
    }
}
