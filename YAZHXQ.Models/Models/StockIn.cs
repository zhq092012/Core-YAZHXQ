using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class StockIn
    {
        public int Id { get; set; }
        public string WareNo { get; set; }
        public int GoodsId { get; set; }
        public string PurNo { get; set; }
        public string BackNo { get; set; }
        public int? ProId { get; set; }
        public DateTime WareTime { get; set; }
        public string GoodsName { get; set; }
        public int GoodsFrom { get; set; }
        public int Brokerage { get; set; }
        public decimal Quantity { get; set; }
        public string ModelNumbers { get; set; }
        public string Unit { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
