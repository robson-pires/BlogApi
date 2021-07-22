using System;
namespace BlogApi.Dtos
{
    public class CreatePostDto
    {
        public string Title { get; set; }
        public string Text { get; set; }    
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}