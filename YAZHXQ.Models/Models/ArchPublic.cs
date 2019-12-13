using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class ArchPublic
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string ArchCode { get; set; }
        public string DocketCode { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public int Town { get; set; }
        public int Village { get; set; }
        public int Group { get; set; }
        public string Remark { get; set; }
        public string Reason { get; set; }
        public int ShstaffId { get; set; }
        public DateTime Shdate { get; set; }
        public int ZlstaffId { get; set; }
        public DateTime Zldate { get; set; }
        public int SjstaffId { get; set; }
        public DateTime Sjdate { get; set; }
        public int ArchType { get; set; }
        public string BorrowPeople { get; set; }
        public DateTime BorrowDate { get; set; }
        public int BorrowStatus { get; set; }
        public DateTime ReturnDate { get; set; }
        public string StoreBeyound { get; set; }
        public string SecretLevel { get; set; }
        public string ResponsPoeple { get; set; }
        public DateTime CreateDate { get; set; }
        public int? TargetAcrhId { get; set; }
        public int Xnda { get; set; }
    }
}
