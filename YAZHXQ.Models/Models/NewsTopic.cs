using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class NewsTopic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Logo { get; set; }
        public bool IsPublic { get; set; }
        public string Description { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
