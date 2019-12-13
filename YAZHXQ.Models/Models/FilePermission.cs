using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class FilePermission
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public int? DeptId { get; set; }
        public int? StaffId { get; set; }
    }
}
