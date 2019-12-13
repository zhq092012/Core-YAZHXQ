using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class BaseData
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string DataCode { get; set; }
        public bool IsDel { get; set; }
        public int Type { get; set; }
        public int OrderId { get; set; }
        public int Lvl { get; set; }
        public string Path { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
