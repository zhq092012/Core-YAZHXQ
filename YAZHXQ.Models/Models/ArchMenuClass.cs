using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchMenuClass
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public int Status { get; set; }
        public int Sort { get; set; }
        public int Hierarchy { get; set; }
        public string Path { get; set; }
    }
}
