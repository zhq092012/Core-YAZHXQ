using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ProStakeholder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Position { get; set; }
        public string Tel { get; set; }
        public string ProContent { get; set; }
        public int? ProId { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
