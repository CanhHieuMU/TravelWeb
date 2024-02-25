using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Comment
    {
        [Key] 
        public int CommentId { get; set; }
        [Required]
        public string Content { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
