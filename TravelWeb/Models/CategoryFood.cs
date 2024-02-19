using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class CategoryFood
    {
        [Key]
        public int CateFoodId { get; set; }
        [Required]
        public string NameCateFood { get; set; }
        public virtual Cuisine Cuisine { get; set; }
        public int CuisineId { get; set; }
    }
}
