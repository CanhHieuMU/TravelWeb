using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Comment
    {
        [Key] 
        public int CommentId { get; set; }
        [Required]
        public string Content { get; set; }
        public Cuisine Cuisine { get; set; }
        public TouristAttraction TouristActtraction { get; set; }
        public User User { get; set; }
    }
}
