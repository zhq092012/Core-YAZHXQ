using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Content { get; set; }
        public int? CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? DelTime { get; set; }
    }
}
