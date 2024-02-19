using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Cuisine
    {
        [Key]
        public int CuisineId { get; set; }
        [Required]
        public string CuisineName { get; set;}
        public string Price { get; set; }
        public string Phone { get; set; }
        public virtual CategoryFood CategoryFood { get; set; }
        public virtual History History { get; set; }
        public TouristAttraction TouristAttraction { get; set;}
    }
}
