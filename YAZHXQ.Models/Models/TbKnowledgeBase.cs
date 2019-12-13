using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class TbKnowledgeBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string SharedBy { get; set; }
        public string SharedByName { get; set; }
        public DateTime SharedTime { get; set; }
        public string AttachmentUrl { get; set; }
        public string AttachmentName { get; set; }
        public string Classfy { get; set; }
        public bool IsDelete { get; set; }
    }
}
