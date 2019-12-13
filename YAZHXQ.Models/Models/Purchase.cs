using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Purchase
    {
        public int Id { get; set; }
        public string Numbers { get; set; }
        public string Heading { get; set; }
        public int? ProId { get; set; }
        public DateTime ApplyTime { get; set; }
        public DateTime CompletionTime { get; set; }
        public decimal Amount { get; set; }
        public string Remake { get; set; }
        public int PurchaseType { get; set; }
        public int State { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
