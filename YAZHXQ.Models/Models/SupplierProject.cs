using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class SupplierProject
    {
        public int Id { get; set; }
        public int SuppId { get; set; }
        public int ProId { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime JointTime { get; set; }
        public string Goods { get; set; }
        public string FirstName { get; set; }
        public string FirstTel { get; set; }
        public string SecondName { get; set; }
        public string SecondTel { get; set; }
        public string Remark { get; set; }
    }
}
