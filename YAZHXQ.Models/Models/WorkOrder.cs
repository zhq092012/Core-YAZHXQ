using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class WorkOrder
    {
        public int Id { get; set; }
        public int CreateStaffId { get; set; }
        public string Intersection { get; set; }
        public string DeviceName { get; set; }
        public int SourceOfError { get; set; }
        public int TypeOfError { get; set; }
        public string DescOfError { get; set; }
        public int ProcessStatus { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
