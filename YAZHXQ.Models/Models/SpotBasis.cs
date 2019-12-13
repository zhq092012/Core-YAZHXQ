using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class SpotBasis
    {
        public int Id { get; set; }
        public int SpotId { get; set; }
        public string BasisCode { get; set; }
        public int BasisClass { get; set; }
        public string BasisLocation { get; set; }
        public string SoilClass { get; set; }
        public string DesignSize { get; set; }
        public string DesignCubage { get; set; }
        public string ActualSize { get; set; }
        public string ActualCubage { get; set; }
        public string Remark { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
