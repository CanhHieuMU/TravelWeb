using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class ForumPost
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
