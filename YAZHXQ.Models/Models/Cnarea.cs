using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Cnarea
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string ShortCode { get; set; }
        public string ParentShortCode { get; set; }
        public string Name { get; set; }
        public string Province1 { get; set; }
        public string City1 { get; set; }
        public string District1 { get; set; }
        public string Town1 { get; set; }
        public string Village1 { get; set; }
        public int Grade { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
        public string Village { get; set; }
        public string FullName { get; set; }
        public string Category { get; set; }
    }
}
