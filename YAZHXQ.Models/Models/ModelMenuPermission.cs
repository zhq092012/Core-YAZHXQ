using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ModelMenuPermission
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ControllerCode { get; set; }
        public string ActionName { get; set; }
        public string ActionCode { get; set; }
        public int? DependOn { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsOpen { get; set; }
    }
}
