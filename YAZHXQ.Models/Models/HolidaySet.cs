using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class HolidaySet
    {
        public int Id { get; set; }
        public DateTime SetDay { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
