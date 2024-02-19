using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class Cuisine
    {
        public Cuisine() 
        {
            this.Repositories = new List<Repository>();
        }
        [Key]
        public int CuisineId { get; set; }
        [Required]
        public string CuisineName { get; set;}
        public string Price { get; set; }
        public string Phone { get; set; }
        public virtual CategoryFood CategoryFood { get; set; }
        public virtual History History { get; set; }
        public TouristAttraction TouristAttraction { get; set;}
        public virtual ICollection<Repository> Repositories { get; set; }
    }
}
