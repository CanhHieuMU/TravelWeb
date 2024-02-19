using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Rate
    {
        [Key]
        public int RateId { get; set; }
        [Required]
        public int RateStar { get; set; }
        public bool IsRateed { get; set; }
        public TouristAttraction TouristAttraction { get; set; }
        public Homestay Homestay { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}
