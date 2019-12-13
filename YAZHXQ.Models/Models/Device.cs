using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Device
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
        public string Param { get; set; }
        public string Brand { get; set; }
        public decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Code { get; set; }
    }
}
