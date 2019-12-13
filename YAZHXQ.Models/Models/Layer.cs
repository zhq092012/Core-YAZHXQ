using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Layer
    {
        public int Id { get; set; }
        public int MapId { get; set; }
        public int LayerIndex { get; set; }
        public string LayerName { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsShow { get; set; }
    }
}
