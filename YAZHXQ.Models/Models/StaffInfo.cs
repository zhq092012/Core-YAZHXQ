using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class StaffInfo
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public string Kqjno { get; set; }
        public string Name { get; set; }
        public bool IsDel { get; set; }
        public string Tel { get; set; }
        public int OrderId { get; set; }
        public string AreasCode { get; set; }
        public string AccountPwd { get; set; }
        public string SexName { get; set; }
        public int? SexCode { get; set; }
        public DateTime? Birthday { get; set; }
        public string ColledgeName { get; set; }
        public string ProfessionalName { get; set; }
        public string StaffImg { get; set; }
        public string MarriageName { get; set; }
        public int? MarriageCode { get; set; }
        public int? NationalCode { get; set; }
        public string NationalName { get; set; }
        public string PoliticalStatusName { get; set; }
        public int? PoliticalStatusCode { get; set; }
        public string Idnumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string OtherInfo { get; set; }
        public int? PostId { get; set; }
        public int DeptId { get; set; }
        public string StaffIp { get; set; }
        public int Grade { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
