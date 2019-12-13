using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class MapService
    {
        public int Id { get; set; }
        public string MapServiceName { get; set; }
        public string MapServiceUrl { get; set; }
        public int MapServiceType { get; set; }
        public int OrderId { get; set; }
        public string Remark { get; set; }
        public bool IsView { get; set; }
        public int? ParentId { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
