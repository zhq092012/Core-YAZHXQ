using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Dbbackup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataBasePath { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
