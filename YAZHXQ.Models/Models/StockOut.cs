using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class StockOut
    {
        public int Id { get; set; }
        public string OutNo { get; set; }
        public int GoodsId { get; set; }
        public string InNo { get; set; }
        public int? ProId { get; set; }
        public DateTime OutTime { get; set; }
        public string GoodsName { get; set; }
        public int Brokerage { get; set; }
        public string Using { get; set; }
        public decimal Quantity { get; set; }
        public string ModelNumbers { get; set; }
        public string Unit { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
