using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class CategoryTakeAway
    {
        [Key]
        public int CategoryTakeId { get; set; }
        [Required]
        public string CategoryTakeName { get; set;}
        public Cuisine Cuisine { get; set;}
    }
}
