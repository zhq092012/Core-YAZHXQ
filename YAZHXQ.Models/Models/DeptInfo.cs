using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class DeptInfo
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string OrgCode { get; set; }
        public bool IsDel { get; set; }
        public int OrderId { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string ManagerName { get; set; }
        public string Desc { get; set; }
        public string ImgUrl { get; set; }
        public int? Lvl { get; set; }
        public string Path { get; set; }
        public int Grade { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
