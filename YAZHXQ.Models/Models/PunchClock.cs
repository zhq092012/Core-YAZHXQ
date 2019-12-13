using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class PunchClock
    {
        public int Id { get; set; }
        public string MeId { get; set; }
        public DateTime? AmstartTime { get; set; }
        public DateTime? AmendTime { get; set; }
        public DateTime? PmstartTime { get; set; }
        public DateTime? PmendTime { get; set; }
        public int? IsError { get; set; }
        public DateTime? MeDate { get; set; }
        public string MeName { get; set; }
    }
}
