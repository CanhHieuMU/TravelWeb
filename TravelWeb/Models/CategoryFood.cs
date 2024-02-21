using System.ComponentModel.DataAnnotations;

namespace TravelWeb.Models
{
    public class CategoryFood
    {
        [Key]
        public int CateFoodId { get; set; }
        [Required]
        public string NameCateFood { get; set; }
        public virtual ICollection<Cuisine> Cuisines { get; set; }
    }
}
