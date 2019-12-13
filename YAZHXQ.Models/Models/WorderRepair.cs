using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class WorderRepair
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public string RepairContent { get; set; }
        public string RepairVehicle { get; set; }
        public string RepairCost { get; set; }
        public string Remark { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDel { get; set; }
    }
}
