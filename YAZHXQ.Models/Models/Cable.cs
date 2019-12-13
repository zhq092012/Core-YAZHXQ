using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Cable
    {
        public int Id { get; set; }
        public int SpotId { get; set; }
        public int Type { get; set; }
        public decimal? Length { get; set; }
        public string Param { get; set; }
        public string Remark { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
