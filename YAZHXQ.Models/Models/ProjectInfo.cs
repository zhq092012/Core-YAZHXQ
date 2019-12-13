using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ProjectInfo
    {
        public int Id { get; set; }
        public string Pname { get; set; }
        public DateTime? PstartTime { get; set; }
        public DateTime? PfinshTime { get; set; }
        public int CurrentState { get; set; }
        public string Remark { get; set; }
        public bool IsDel { get; set; }
        public string Pcode { get; set; }
        public string BuildCompany { get; set; }
        public string BuildCompanyInfo { get; set; }
        public string ConCompany { get; set; }
        public string ConCompanyInfo { get; set; }
        public int Schedule { get; set; }
        public DateTime? AcceptTime { get; set; }
        public int GisproType { get; set; }
        public int GisobjId { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
