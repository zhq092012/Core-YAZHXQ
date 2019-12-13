using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class AccountBook
    {
        public int Id { get; set; }
        public int ProId { get; set; }
        public int? SuppId { get; set; }
        public int AccountType { get; set; }
        public int IncOrExpType { get; set; }
        public decimal Amount { get; set; }
        public string IncOrExpName { get; set; }
        public string Remark { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
