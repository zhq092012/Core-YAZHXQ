using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsRelease { get; set; }
        public int ReleaseArea { get; set; }
        public string Content { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int OrderId { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
