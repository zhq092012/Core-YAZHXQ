using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class FunctionInfo
    {
        public int Id { get; set; }
        public string FunctionName { get; set; }
        public int? FunScriptId { get; set; }
        public string Remark { get; set; }
        public int? ParentId { get; set; }
        public int OrderId { get; set; }
        public int? FunctionType { get; set; }
        public int? StatisticeUnit { get; set; }
        public int? StatisticalType { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsShow { get; set; }
    }
}
