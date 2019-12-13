using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class FunMapService
    {
        public int Id { get; set; }
        public int FunId { get; set; }
        public int MapId { get; set; }
        public string LayerIds { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
