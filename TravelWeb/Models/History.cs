using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual Cuisine Cuisine { get; set; }
        public int CuisineId { get; set; }
        public virtual TouristAttraction TouristAttraction { get; set;}
        public int TouristId { get; set; }
    }
}
