using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class ForumPost
    {
        [Key]
        public int ForumPostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
