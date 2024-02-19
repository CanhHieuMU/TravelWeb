using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        [Required]
        public string NamePhoto { get; set; }
        public string Path { get; set; }
        public TouristAttraction TouristAttraction { get; set;}
        public Cuisine Cuisine { get; set; }
        public Homestay Homestay { get; set; }
    }
}
