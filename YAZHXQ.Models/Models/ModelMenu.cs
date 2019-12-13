using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ModelMenu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public int? ParentId { get; set; }
        public int OrderId { get; set; }
        public int ModelType { get; set; }
        public string TargetUrl { get; set; }
        public int? Lvl { get; set; }
        public string Path { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
