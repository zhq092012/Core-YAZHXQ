using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class SpotMenu
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public int Sort { get; set; }
        public int Hierarchy { get; set; }
        public string Path { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int SpotId { get; set; }
    }
}
