using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchBorrowHistory
    {
        public int Id { get; set; }
        public int ArchId { get; set; }
        public string BorrowPeople { get; set; }
        public int DoStaffId { get; set; }
        public DateTime DoDate { get; set; }
        public int OldStatus { get; set; }
        public int NewStatus { get; set; }
        public string Remark { get; set; }
    }
}
