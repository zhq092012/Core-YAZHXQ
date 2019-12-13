using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchVirtual
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? OrderId { get; set; }
        public int? Hierarchy { get; set; }
        public string Path { get; set; }
        public int? Status { get; set; }
        public string Remark { get; set; }
    }
}
