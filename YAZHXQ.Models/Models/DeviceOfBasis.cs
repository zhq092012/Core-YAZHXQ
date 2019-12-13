using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class DeviceOfBasis
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public decimal Quantity { get; set; }
        public int TableType { get; set; }
        public int DataId { get; set; }
    }
}
