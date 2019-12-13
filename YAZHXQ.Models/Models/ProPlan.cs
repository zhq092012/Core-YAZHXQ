using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ProPlan
    {
        public int Id { get; set; }
        public int ProId { get; set; }
        public int TabId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Workers { get; set; }
        public decimal? WorkDays { get; set; }
        public string Leader { get; set; }
        public string Resource { get; set; }
        public string WorkFocus { get; set; }
        public string WorkTask { get; set; }
        public string WorkResults { get; set; }
        public string Hazard { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
