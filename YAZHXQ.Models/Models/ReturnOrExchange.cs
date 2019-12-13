using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ReturnOrExchange
    {
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string RetOrExNo { get; set; }
        public int? ProId { get; set; }
        public DateTime ApplyTime { get; set; }
        public string GoodsName { get; set; }
        public int RetOrExType { get; set; }
        public int State { get; set; }
        public int? Brokerage { get; set; }
        public decimal Quantity { get; set; }
        public string ModelNumbers { get; set; }
        public string Unit { get; set; }
        public string Remark { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string RelationNo { get; set; }
        public int? Source { get; set; }
    }
}
