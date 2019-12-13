using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class FunAttribute
    {
        public int Id { get; set; }
        public int FunId { get; set; }
        public int LayerAttrId { get; set; }
        public int AttributeType { get; set; }
        public bool IsShow { get; set; }
        public int OrderId { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
