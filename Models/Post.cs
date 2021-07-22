using System;
namespace BlogApi.Models
{
    public class Post
    {
        public int PostId { get; set; } 
        public string Title { get; set; }
        public string Text { get; set; }    
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public int DeletedBy { get; set; }

    }
}