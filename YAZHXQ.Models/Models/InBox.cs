using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class InBox
    {
        public int MsgId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime? ReadTime { get; set; }
        public DateTime? DelTime { get; set; }
    }
}
