using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class PostInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDel { get; set; }
        public int Grade { get; set; }
        public int OrderId { get; set; }
        public string Desc { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
