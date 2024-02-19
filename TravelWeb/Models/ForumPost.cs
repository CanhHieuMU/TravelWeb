using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class ForumPost
    {
        public ForumPost() 
        {
            this.Repositories = new HashSet<Repository>();
        }
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
    }
}
