using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class LayerAttribute
    {
        public int Id { get; set; }
        public int LayersId { get; set; }
        public string AttributeName { get; set; }
        public string Alias { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
