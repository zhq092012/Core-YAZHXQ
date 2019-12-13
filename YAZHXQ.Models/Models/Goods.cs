using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Goods
    {
        public int Id { get; set; }
        public string GoodsName { get; set; }
        public int? PurchaseId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Inquantity { get; set; }
        public decimal? Outquantity { get; set; }
        public decimal? WaitQuantity { get; set; }
        public decimal? Stocks { get; set; }
        public decimal Price { get; set; }
        public decimal SumMonmey { get; set; }
        public string Supplier { get; set; }
        public string ModelNumbers { get; set; }
        public string Unit { get; set; }
        public string Parameter { get; set; }
        public int SourceType { get; set; }
        public int? ExchangeId { get; set; }
    }
}
