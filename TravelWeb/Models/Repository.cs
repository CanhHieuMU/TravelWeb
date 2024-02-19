    using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Repository
    {
        public Repository()
        {
            this.Homestays = new HashSet<Homestay>();
            this.Cuisines = new HashSet<Cuisine>();
            this.TouristAttractions = new HashSet<TouristAttraction>();
            this.ForumPosts = new HashSet<ForumPost>();
        }
        [Key] 
        public int RepositoryId { get; set; }
        [Required]
        public string RepositoryName { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<Homestay> Homestays { get; set; }
        public virtual ICollection<TouristAttraction> TouristAttractions { get; set; }
        public virtual ICollection<Cuisine> Cuisines { get; set; }
        public virtual ICollection<ForumPost> ForumPosts { get; set; }
    }
}
