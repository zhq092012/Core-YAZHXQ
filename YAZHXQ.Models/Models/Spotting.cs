using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Spotting
    {
        public int Id { get; set; }
        public int ProId { get; set; }
        public string SpotCode { get; set; }
        public string SpotName { get; set; }
        public int SpotSchedule { get; set; }
        public int State { get; set; }
        public string Remark { get; set; }
        public bool IsDel { get; set; }
        public int GissoptType { get; set; }
        public int GissoptId { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int SpotClass { get; set; }
    }
}
