using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class LogInfo
    {
        public int Id { get; set; }
        public int? MenuId { get; set; }
        public string Desc { get; set; }
        public int? Type { get; set; }
        public string Ip { get; set; }
        public string TableName { get; set; }
        public string UserName { get; set; }
        public string AccountNo { get; set; }
        public int? DeptId { get; set; }
        public string DeptName { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
