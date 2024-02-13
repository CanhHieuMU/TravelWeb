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

    }
}
