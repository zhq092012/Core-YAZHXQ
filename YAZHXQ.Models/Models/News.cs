using System;
using System.Collections.Generic;

namespace YAZHXQ.Models.Models
{
    public partial class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? TopicId { get; set; }
        public int CategoryId { get; set; }
        public bool IsTopicOnly { get; set; }
        public DateTime PubDate { get; set; }
        public string ImageUrl { get; set; }
        public string Summary { get; set; }
        public string Source { get; set; }
        public string Author { get; set; }
        public bool IsPublic { get; set; }
        public int CreateStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateStaffId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
