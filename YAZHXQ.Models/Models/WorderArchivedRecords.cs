using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class WorderArchivedRecords
    {
        public int Id { get; set; }
        public int WorkOrderId { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
