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
        public string? Phone { get; set; }
        public virtual History History { get; set; }
        public virtual ICollection<Repository> Repositories { get; set; }
        public virtual ICollection<CategoryFood> CategoryFoods { get; set; }
        public virtual ICollection<CategoryTakeAway> CategoryTakeAways { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Rate> Rates { get; set; }

    }
}
