using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class TouristAttraction
    {
        
        [Key]
        public int TouristId { get; set; }
        [Required]
        public string TouristName { get; set; }
        public string PriceTicketTourist { get; set; }
        public string CategoryTourist { get; set; }
        public virtual History History { get; set; }
        public  virtual ICollection<Repository> Repositories { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Rate> Rates { get; set; }
    }
}
